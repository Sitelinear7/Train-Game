using UnityEngine;

public class EnemyBrain : MonoBehaviour
{
    
    [Header("Enemy Data SO")]
    [SerializeField] EnemyStats stats;

    private void Start()
    {
        PassRelevantStats();
    }

    private void PassRelevantStats()
    {
        this.GetComponent<EnemyHealth>().RecieveRelevantStats(stats.health, stats.armor);
        this.GetComponent<EnemyMovement>().RecieveRelevantStats(stats.moveSpeed, stats.dodgeInterval, stats.dodgeSpeed);
        this.GetComponent<EnemyWeapons>().RecieveRelevantStats(stats.weapons);
    }
    
    //Note: Add functionality later
    private void UpdateStatsFromModifiers()
    {

    }

}
