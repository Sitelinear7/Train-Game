using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Scriptable Objects/EnemyStats")]
public class EnemyStats_SO : ScriptableObject
{
    [Header("Enemy GameObject Prefab")]
    public GameObject EnemyPref;
    [Header("Enemy Health Stats")]
    public float health;
    public float armor;
    [Header("Enemy Movement Stats")]
    public EnemyMovementBase_SO enemyMovementType;
    [Header("Enemy Weapons")]
    public List<EnemyWeaponBase_SO> weapons = new List<EnemyWeaponBase_SO>();


}
