using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Arc_Chapter_Detail", menuName = "Scriptable Objects/Encounter")]
public class EncounterData : ScriptableObject
{
    [SerializeField] public MonsterSO[] enemies;
}
