
using UnityEngine;
using System.Collections.Generic;

public class TurretLoadoutManager : MonoBehaviour
{
    [Header("Scriptable Objects of all available weapons (Make Object 0 Base Weapon)")]
    [SerializeField] TurretWeapon_BaseSO[] turretWeapons;

    //
    [HideInInspector] public delegate void swappedWeapon(TurretWeapon_BaseSO currentWeapon);
    [HideInInspector] public static swappedWeapon swapToWeapon;

    private List<TurretWeapon_BaseSO> unlockedWeapons = new List<TurretWeapon_BaseSO>();
    private TurretWeapon_BaseSO currentWeapon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        unlockedWeapons.Add(turretWeapons[0]);
        currentWeapon = unlockedWeapons[0];
        swapToWeapon(currentWeapon);
    }

    private void UnlockNewWeapon(TurretWeapon_BaseSO newWeapon)
    {

    }

    
   
}
