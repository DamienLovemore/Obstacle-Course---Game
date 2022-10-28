using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject playerCharacter;
    [SerializeField] private GameObject levelSpawn;
    
    void Start()
    {
        Vector3 position = levelSpawn.transform.position;
        position.y = 0.25f;

        playerCharacter.transform.position = position;
    }
}
