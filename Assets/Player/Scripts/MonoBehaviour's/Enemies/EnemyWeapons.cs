using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class EnemyWeapons : MonoBehaviour
{
    EnemyStats_SO stats;
    public void RecieveRelevantStats(EnemyStats_SO s)
    {
        stats = s;
    }
}
