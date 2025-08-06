using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "TurretWeapon_PH", menuName = "Scriptable Objects/TurretWeapon_PH")]
public class TurretWeapon_PH : TurretWeapon_BaseSO
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


    //Note: Swap weapons to projectiles instead of raycast. Use a empty gameobject called shooting position to make projectiles files towards center of screen
    private void FireWeapon(Transform barrel, Transform shootingPosition)
    {
        //Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f) + spreadModifier);
        Vector3 direction = CreateDirection(shootingPosition);
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, direction, out hit))
        {
            SpawnProjectile(barrel, hit);

            Debug.Log("TurretWeapon_PH hit " + hit.transform.name);
        }
    }

    private Vector3 CreateDirection(Transform shootingPosition)
    {
        Vector3 direction = shootingPosition.transform.position - Camera.main.transform.position;
        if(addSpread)
        {
            direction.x += Random.Range(-spreadModifier.x, spreadModifier.x);
            direction.y += Random.Range(-spreadModifier.y, spreadModifier.y);
            direction.z += Random.Range(-spreadModifier.z, spreadModifier.z);
        }

        return direction;
    }

    private void SpawnProjectile(Transform barrel, RaycastHit hit)
    {
        GameObject newProjectile = Instantiate(projectile, barrel.position, Quaternion.identity);
        newProjectile.GetComponent<RaycastTrailRenderer>().RecieveStartData(hit, barrel.transform.position);
    }

    
}
