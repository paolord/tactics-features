using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PartyManager : MonoBehaviour
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

    [SerializeField]
    private PlayerPartySO team;

    private void Awake()
    {
        int i = 0;
        foreach ( MonsterSO member in team.party)
        {
            GameObject newPlayerMonster = Instantiate(
                playerMonsterPrefab,
                new Vector3(startingPoints[i].x, startingPoints[i].y, -5),
                Quaternion.identity);
            newPlayerMonster.GetComponent<SpriteRenderer>().sprite = member.sprite;
            var text = newPlayerMonster.transform.GetChild(0).gameObject;
            text.GetComponent<TextMeshPro>().SetText(""+member.attack);
            
            i++;
        }
    }

    void Update()
    {
        // TODO: add input system and input system abstraction SO
        // TODO: add UI layer over ground tilemap to indicate current active monster and available position to move in
        // TODO: add camera control script, tweens and slows down from one character to next
        
    }
}
