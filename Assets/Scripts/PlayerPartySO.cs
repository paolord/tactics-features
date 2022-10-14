using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Party Store", menuName = "Scriptable Objects/One-offs/Player Party Store")]
public class PlayerPartySO : ScriptableObject
{
    [SerializeField] public MonsterSO[] party; 
}
