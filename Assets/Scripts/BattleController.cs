using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BattleController : MonoBehaviour
{
    [Header("Map Settings")]
    [SerializeField]
    private Tilemap ground;

    [SerializeField]
    private Tilemap collisions;
    [Header("Player Settings")]
    [SerializeField]
    private Vector3[] startingPoints;

    [SerializeField]
    private GameObject playerMonsterPrefab;
    [SerializeField] public PlayerPartySO team;
    [SerializeField] public BattleData battleData;

    private void Awake()
    {
        var i = 0;
        foreach (MonsterSO member in team.party)
        {
            GameObject newPlayerMonster = Instantiate(
                playerMonsterPrefab,
                new Vector3(startingPoints[i].x, startingPoints[i].y, -5),
                Quaternion.identity);
            newPlayerMonster.GetComponent<SpriteRenderer>().sprite = member.sprite;
            var text = newPlayerMonster.transform.GetChild(0).gameObject;
            text.GetComponent<TextMeshPro>().SetText(""+member.attack);
            
            i++;
            var characterData = new CharacterState();
            characterData.baseCharacter = member;
            characterData.stance = Stance.Attack;
            battleData.player.Add(characterData);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
