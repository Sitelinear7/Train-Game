using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    EnemyStats_SO stats;
    public void RecieveRelevantStats(EnemyStats_SO s)
    {
        stats = s;
    }
}
