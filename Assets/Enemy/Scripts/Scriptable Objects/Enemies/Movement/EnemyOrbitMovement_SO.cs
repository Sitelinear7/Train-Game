using UnityEngine;

[CreateAssetMenu(fileName = "EnemyOrbitMovement_SO", menuName = "Scriptable Objects/EnemyOrbitMovement_SO")]
public class EnemyOrbitMovement_SO : EnemyMovementBase_SO
{
    [Header("Min time before enemy will change direction")]
    [SerializeField] float holdMoveDirectionMinimum;
    [Header("Chance to change direction before (In Percentage)")]
    [SerializeField] float chanceToChangeDir;

    private float moveDirectionTime;
    public override void UpdateDodgeLogic(GameObject enemy)
    {
        
    }

    public override void UpdateMovementLogic(GameObject enemy, GameObject target)
    {
        enemy.transform.RotateAround(target.transform.position, Vector3.up, moveSpeed * Time.deltaTime);

        moveDirectionTime += Time.deltaTime;
        if(moveDirectionTime > holdMoveDirectionMinimum)
        {
            CheckChangeDirection();
            moveDirectionTime = 0f;
        }
    }

    private void CheckChangeDirection()
    {
        float chanceToBeat = Random.Range(.1f, 1f);
        if (chanceToChangeDir > chanceToBeat)
        {
            moveSpeed = moveSpeed * -1;
        }
    }



}
