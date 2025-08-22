using UnityEngine;


public abstract class ProjectileBase_SO : ScriptableObject
{
    public float damage;
    public GameObject projectile;
    public float projectileSpeed;

    public virtual void ActivateWeaponLogic()
    {

    }

    public virtual void DeactivateWeaponLogic()
    {

    }

    public abstract void CurrentProjectileLogic(GameObject projectile, GameObject target));
}
