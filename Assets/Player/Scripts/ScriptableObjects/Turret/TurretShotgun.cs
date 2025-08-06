using UnityEngine;

[CreateAssetMenu(fileName = "TurretShotgun", menuName = "Scriptable Objects/TurretShotgun")]
public class TurretShotgun : TurretWeapon_BaseSO
{
    public override void ActivateWeaponLogic()
    {
        Debug.Log("Weapon " + this.name + " Has been activated");
    }

    public override void CurrentWeaponLogic(Transform[] barrels, Transform shootingPosition)
    {

    }

    public override void DeactivateWeaponLogic()
    {
        Debug.Log("Weapon " + this.name + " Has been Deactivated");
    }

}
