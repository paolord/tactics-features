using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using Object = UnityEngine.Object;

public class BattleController : MonoBehaviour
{
    [Header("Map Settings")]
    [SerializeField]
    private Tilemap ground;

    [SerializeField]
    private Tilemap collisions;

    [SerializeField] private FormationData formation;
    
    [Header("Player Settings")]
    [SerializeField]
    private GameObject playerMonsterPrefab;
    [SerializeField] public PlayerPartySO team;
    [SerializeField] public BattleData battleData;

    [Header("CPU Player")] 
    [SerializeField]
    private EncounterData encounter;
    
    private void Awake()
    {
        var i = 0;
        foreach (MonsterSO member in team.party)
        {
            GameObject newPlayerMonster = Instantiate(
                playerMonsterPrefab,
                new Vector3(formation.playerPositions[i].x, formation.playerPositions[i].y, -5),
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

        var j = 0;
        foreach (var enemy in encounter.enemies)
        {
            var newEnemy = Instantiate(
                playerMonsterPrefab,
                new Vector3(formation.enemyPositions[j].x, formation.enemyPositions[j].y, -5),
                Quaternion.identity);
            newEnemy.GetComponent<SpriteRenderer>().sprite = enemy.sprite;
            var text = newEnemy.transform.GetChild(0).gameObject;
            text.GetComponent<TextMeshPro>().SetText(""+enemy.attack);
            j++;
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
