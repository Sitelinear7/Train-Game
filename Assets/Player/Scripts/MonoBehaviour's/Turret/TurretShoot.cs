using UnityEngine;

public class TurretShoot : MonoBehaviour
{
    [Header("Positions of gun barrels for shooting functionality")]
    [SerializeField] Transform[] barrels;
    [Header("Position of Shooting Position for weapon Raycasts and Projectile direction")]
    [SerializeField] Transform shootingPosition;

    private InputManager inputManager;

    private TurretWeapon_BaseSO currentWeapon;
    private float lastShotTime = 0;

    private void Start()
    {
        inputManager = InputManager.Instance;
        TurretLoadoutManager.swapToWeapon += GetNewWeaponData;
    }

    private void Update()
    {
        shoot();
    }

    #region Shooting Methods
    private void shoot()
    {
        
        if (inputManager.GetIsShooting() && lastShotTime + currentWeapon.shotDelay < Time.time)
        {
            FireCurrentWeapon();
            lastShotTime = Time.time;
        }
        
    }

    private void FireCurrentWeapon()
    {
        currentWeapon.CurrentWeaponLogic(barrels, shootingPosition);
    }
    #endregion

    //Get new weapon data from LoadoutManager Delegate if weapon is swapped
    private void GetNewWeaponData(TurretWeapon_BaseSO newWeapon)
    {
        currentWeapon = newWeapon;
    }



}
