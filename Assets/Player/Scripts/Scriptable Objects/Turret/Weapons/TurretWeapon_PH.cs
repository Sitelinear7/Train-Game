using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "TurretWeapon_PH", menuName = "Scriptable Objects/TurretWeapon_PH")]
public class TurretWeapon_PH : TurretWeaponBase_SO
{
    public override void ActivateWeaponLogic()
    {
        Debug.Log("Activating TurretWeapon_PH");
    }

    public override void CurrentWeaponLogic(Transform[] barrels, Transform shootingPosition)
    {
        
        foreach (Transform t in barrels)
        {
            FireWeapon(t, shootingPosition);
        }
        
        
    }

    public override void DeactivateWeaponLogic()
    {
        
    }


    private void FireWeapon(Transform barrel, Transform shootingPosition)
    {
        GameObject newProjectile = Instantiate(projectile, barrel.position, shootingPosition.rotation);

        Vector3 direction = AddSpread(shootingPosition.position - barrel.position);

        newProjectile.GetComponent<ProjectileBase>().RecieveStartData(shootingPosition.gameObject);
    }

    private void SpawnProjectile(Transform barrel, RaycastHit hit)
    {
        GameObject newProjectile = Instantiate(projectile, barrel.position, Quaternion.identity);
        newProjectile.GetComponent<RaycastTrailRenderer>().RecieveStartData(hit, barrel);
    }

    
}
