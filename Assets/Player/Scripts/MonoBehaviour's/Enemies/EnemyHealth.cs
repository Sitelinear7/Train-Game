using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private float health;
    private float armor;

    public void RecieveRelevantStats(float h, float a)
    {
        health = h;
        armor = a;
    }
}
