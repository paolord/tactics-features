using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct CharacterState
{
    public MonsterSO baseCharacter;
    public Stance stance;
    public Vector2 position;
}

public enum Stance {
    Attack,
    Defense
}

[CreateAssetMenu(fileName = "BattleData", menuName = "Scriptable Objects/One-offs/Battle Data")]
public class BattleData : ScriptableObject
{
    [SerializeField]
    public List<CharacterState> player;
    [SerializeField]
    public List<CharacterState> cpu;
}
