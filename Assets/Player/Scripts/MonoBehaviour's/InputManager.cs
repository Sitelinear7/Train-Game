using System;
using UnityEngine;

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

    
}
