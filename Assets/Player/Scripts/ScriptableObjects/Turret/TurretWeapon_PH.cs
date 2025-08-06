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

    

    private void SpawnProjectile(Transform barrel, RaycastHit hit)
    {
        GameObject newProjectile = Instantiate(projectile, barrel.position, Quaternion.identity);
        newProjectile.GetComponent<RaycastTrailRenderer>().RecieveStartData(hit, barrel.transform.position);
    }

    
}
