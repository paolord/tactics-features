using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Monster", menuName = "Scriptable Objects/Monster")]
public class MonsterSO : ScriptableObject
{
    [SerializeField] private string monsterName;

    [SerializeField] public int attack;

    [SerializeField] public int defense;

    [SerializeField] public Sprite sprite;
}
