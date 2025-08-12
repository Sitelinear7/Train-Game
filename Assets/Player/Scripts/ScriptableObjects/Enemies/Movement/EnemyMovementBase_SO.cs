using System;
using UnityEngine;


public abstract class EnemyMovementBase_SO : ScriptableObject
{
    [Header("Movement Vars")]
    public float moveSpeed;
    public float dodgeInterval;
    public float dodgeSpeed;

    public virtual void ActivateMovementLogic()
    {

    }

    public virtual void DeactivateMovementLogic()
    {

    }

    public abstract void UpdateMovementLogic(GameObject enemy, GameObject target);

    public abstract void UpdateDodgeLogic(GameObject enemy);

    
}
