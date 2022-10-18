using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Formation", menuName = "Scriptable Objects/Formation")]
public class FormationData : ScriptableObject
{
    [TextArea] public string description;

    [SerializeField] public Vector2[] playerPositions;
    [SerializeField] public Vector2[] enemyPositions;
}
