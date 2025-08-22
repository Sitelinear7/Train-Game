using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "BasicBullet_SO", menuName = "Scriptable Objects/BasicBullet_SO")]
public class BasicBullet_SO : ProjectileBase_SO
{
    public override void CurrentProjectileLogic(GameObject projectile, GameObject target)
    {
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        Vector3 direction = (target.transform.position - projectile.transform.position).normalized;
        rb.AddForce(direction * projectileSpeed);
        Destroy(projectile.gameObject, 3f);
    }


}
