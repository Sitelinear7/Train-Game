using UnityEngine;

public class EnemyBrain : MonoBehaviour
{
    //Note: Check out event based messaging to try and remove dependencies in PassRelevantStats()
    [Header("Enemy Data SO")]
    [SerializeField] EnemyStats_SO stats;

    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("Turret_PH");
        PassRelevantStats();
    }

    private void PassRelevantStats()
    {
        this.GetComponent<EnemyHealth>().RecieveRelevantStats(stats);
        this.GetComponent<EnemyMovement>().RecieveRelevantStats(stats, player);
        this.GetComponent<EnemyWeapons>().RecieveRelevantStats(stats);
    }
    
    //Note: Add functionality later
    private void UpdateStatsFromModifiers()
    {

    }

}
