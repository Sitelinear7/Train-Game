using UnityEngine;

public class ProjectileBase : MonoBehaviour
{

    public void RecieveStartData(Vector3 direction, float bulletSpeed)
    {
        AddForceInDirection(direction ,bulletSpeed);
    }

    private void AddForceInDirection(Vector3 direction ,float bulletSpeed)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * bulletSpeed);
        Destroy(this.gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(this.gameObject);
    }
}
