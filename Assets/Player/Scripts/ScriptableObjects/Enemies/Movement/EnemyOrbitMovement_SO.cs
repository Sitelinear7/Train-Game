using UnityEngine;

[CreateAssetMenu(fileName = "EnemyOrbitMovement_SO", menuName = "Scriptable Objects/EnemyOrbitMovement_SO")]
public class EnemyOrbitMovement_SO : EnemyMovementBase_SO
{
    public override void UpdateDodgeLogic(GameObject enemy)
    {
        
    }

    public override void UpdateMovementLogic(GameObject enemy, GameObject target)
    {
        enemy.transform.RotateAround(target.transform.position, Vector3.up, moveSpeed * Time.deltaTime);
    }

    //Note: Add logic to change directions at certain points in time
}
