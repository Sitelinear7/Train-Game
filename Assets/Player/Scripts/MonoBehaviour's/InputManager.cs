using System;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;

    private static InputManager _instance;
    private bool isShooting = false;

    public static InputManager Instance
    {
        get { return _instance; }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }


        playerControls = new PlayerControls();   
    }

    private void OnEnable()
    {
        playerControls.Enable();
        playerControls.Player.Shoot.performed += _ => ShootingPerformed();
        playerControls.Player.Shoot.canceled += _ => ShootingCanceled();
    }

    

    private void OnDisable()
    {
        playerControls.Disable();
        playerControls.Player.Shoot.performed -= _ => ShootingPerformed();
        playerControls.Player.Shoot.canceled -= _ => ShootingCanceled();
    }

    #region Movement & Rotation Methods
    public Vector2 GetPlayerMovement()
    {
        return playerControls.Player.HorzMovement.ReadValue<Vector2>();
    }

    public Vector2 GetMouseDelta()
    {
        return playerControls.Player.Look.ReadValue<Vector2>();
    }

    public bool PlayerJumpedThisFrame()
    {
        return playerControls.Player.Jump.triggered;
    }
    #endregion

    #region Shooting Methods
    private void ShootingPerformed()
    {
        isShooting = true;
    }

    private void ShootingCanceled()
    {
        isShooting = false;
    }

    public bool GetIsShooting()
    {
        return isShooting;
    }
    #endregion

    #region Loadout Methods
    public bool PlayerEquippedOne()
    {
        return playerControls.Player.EquipLoadout1.triggered;
    }
    public bool PlayerEquippedTwo()
    {
        return playerControls.Player.EquipLoadout2.triggered;
    }
    public bool PlayerEquippedThree()
    {
        return playerControls.Player.EquipLoadout3.triggered;
    }
    #endregion


}
