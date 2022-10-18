using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;



// public enum Result
// {
//     Win,
//     Lose,
//     Draw,
//     
// }

[CreateAssetMenu(fileName = "New Monster", menuName = "Scriptable Objects/Monster")]
public class MonsterSO : ScriptableObject
{
    [SerializeField] private string monsterName;

    [SerializeField] public int attack;

    [SerializeField] public int defense;

    [SerializeField] public Sprite sprite;

    /// <summary>
    /// Character receives attack and decides to win or lose
    /// </summary>
    /// <returns>type of Result enum</returns>
    public void ProcessAttack(int enemyAttack)
    {
        // TODO: Do ATK/DEF rules in battle manager script https://yugioh.fandom.com/wiki/ATK
    }
}
