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
    #region Basic Methods for all classes
    public virtual void ActivateWeaponLogic()
    {
        Debug.Log("Weapon " + this.name + " Has been activated");
    }
    public virtual void DeactivateWeaponLogic()
    {
        Debug.Log("Weapon " + this.name + " Has been activated");
    }
    public abstract void CurrentWeaponLogic(Transform[] barrels, Transform shootingPosition);

    #endregion

    #region Specialized Methods for all classes

    #region Spread Method, can be overriden for new functionality
    public virtual Vector3 CreateDirection(Transform shootingPosition)
    {
        Vector3 direction = shootingPosition.transform.position - Camera.main.transform.position;
        if (addSpread)
        {
            direction.x += Random.Range(-spreadModifier.x, spreadModifier.x);
            direction.y += Random.Range(-spreadModifier.y, spreadModifier.y);
            direction.z += Random.Range(-spreadModifier.z, spreadModifier.z);
        }

        return direction;
    }
    #endregion

    #endregion


}
