using UnityEngine;

[CreateAssetMenu(fileName = "TurretShotgun", menuName = "Scriptable Objects/TurretShotgun")]
public class TurretShotgun : TurretWeapon_BaseSO
{
    [Header("Pellets Per Shot")]
    [SerializeField] int pelletsPerShot;
    public override void ActivateWeaponLogic()
    {
        
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
        for(int z = 0; z < pelletsPerShot/2; z++)
        {
            GameObject newProjectile = Instantiate(projectile, barrel.position, shootingPosition.rotation);

            Vector3 direction = AddSpread(shootingPosition.position - barrel.position);

            newProjectile.GetComponent<ProjectileBase>().RecieveStartData(direction, projectileSpeed);
        }
        
    }


}
