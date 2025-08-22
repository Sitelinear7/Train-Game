using System;
using UnityEngine;

public class ProjectileBase : MonoBehaviour
{
    [SerializeField] ProjectileBase_SO projectileSO;
    GameObject target;

    public void RecieveStartData(GameObject targetToFire)
    {
        target = targetToFire;
    }


    private void Update()
    {
        if(target != null)
        {
            projectileSO.CurrentProjectileLogic(this.gameObject, target);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //Destroy(this.gameObject);
    }
}
