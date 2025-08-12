
using UnityEngine;
using System.Collections.Generic;

public class TurretLoadoutManager : MonoBehaviour
{
    [Header("Scriptable Objects of all available weapons (Make Object 0 Base Weapon)")]
    [SerializeField] TurretWeaponBase_SO[] turretWeapons;

    //
    [HideInInspector] public delegate void swappedWeapon(TurretWeaponBase_SO currentWeapon);
    [HideInInspector] public static swappedWeapon swapToWeapon;

    private List<TurretWeaponBase_SO> unlockedWeapons = new List<TurretWeaponBase_SO>();
    private TurretWeaponBase_SO currentWeapon;

    private InputManager inputManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputManager = InputManager.Instance;

        unlockedWeapons.Add(turretWeapons[0]);
        unlockedWeapons.Add(turretWeapons[1]);
        SetNewCurrentWeapon(0);

    }

    private void Update()
    {
        int newIndex = inputManager.SwapWeapon();
        if(newIndex != -1 && newIndex < unlockedWeapons.Count)
        {
            SetNewCurrentWeapon(newIndex);
        }
    }


    private void UnlockNewWeapon(TurretWeaponBase_SO newWeapon)
    {

    }

    private void SetNewCurrentWeapon(int weaponIndex)
    {
        currentWeapon = unlockedWeapons[weaponIndex];  
        swapToWeapon(unlockedWeapons[weaponIndex]);
    }

    //Note add functionality for weapon swapping with input mananger

    
   
}
