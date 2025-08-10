using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Scriptable Objects/EnemyStats")]
public class EnemyStats : ScriptableObject
{
    [Header("Enemy GameObject Prefab")]
    public GameObject EnemyPref;
    [Header("Enemy Health Stats")]
    public float health;
    public float armor;
    [Header("Enemy Movement Stats")]
    public float moveSpeed;
    public float dodgeInterval;
    public float dodgeSpeed;
    [Header("Enemy Weapons")]
    public List<EnemyWeaponBase> weapons = new List<EnemyWeaponBase>();


}
