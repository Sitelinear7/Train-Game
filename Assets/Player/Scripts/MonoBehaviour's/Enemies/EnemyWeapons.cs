using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapons : MonoBehaviour
{
    private List<EnemyWeaponBase> weapons = new List<EnemyWeaponBase>();
    public void RecieveRelevantStats(List<EnemyWeaponBase> wList)
    {
        //NOTE!! May cause issues later: Removing an item from the list "weapons" may cause the item to also be removed from the EnemyWeaponBase SO's weapon list
        foreach (EnemyWeaponBase weapon in wList)
        {
            weapons.Add(weapon);
        }
    }
}
