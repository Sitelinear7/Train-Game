using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float moveSpeed;
    private float dodgeInterval;
    private float dodgeSpeed;

    public void RecieveRelevantStats(float mspeed, float dInt, float dSpeed)
    {
        moveSpeed = mspeed;
        dodgeInterval = dInt; 
        dodgeSpeed = dSpeed;
    }
}
