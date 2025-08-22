using System;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    EnemyStats_SO stats;
    EnemyMovementBase_SO movementTypeInstance;
    GameObject player;

    public void RecieveRelevantStats(EnemyStats_SO s, GameObject p)
    {
        stats = s;
        player = p;

        //Create an instance of the used movementType to allow changes during runtime
        movementTypeInstance = Instantiate(stats.enemyMovementType);
        
        
    }

    private void Update()
    {
        movementTypeInstance.UpdateMovementLogic(this.gameObject, player);
    }

    private void DestorySOInstance()
    {
        ScriptableObject.Destroy(movementTypeInstance);
    }

}
