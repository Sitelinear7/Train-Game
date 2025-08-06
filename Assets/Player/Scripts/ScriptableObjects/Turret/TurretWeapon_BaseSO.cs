using UnityEngine;

[CreateAssetMenu(fileName = "TurretWeapon_BaseSO", menuName = "Scriptable Objects/TurretWeapon_BaseSO")]
public abstract class TurretWeapon_BaseSO : ScriptableObject
{
    [Header("Weapon Vars")]
    public float shotDelay;
    [SerializeField] protected float damage;
    [SerializeField] protected bool addSpread;
    [SerializeField] protected Vector3 spreadModifier;

    [Header("If weapon uses projectiles, add here. Other wise leave blank")]
    [SerializeField] protected GameObject projectile;

    public virtual void ActivateWeaponLogic()
    {

    }
    public virtual void DeactivateWeaponLogic()
    {

    }
    public abstract void CurrentWeaponLogic(Transform[] barrels, Transform shootingPosition);
    

}
