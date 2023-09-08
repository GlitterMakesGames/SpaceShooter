using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnTime = 2f;
    public float spawnRange = 2.5f;
    public Vector3 spawnPosition;
    public GameObject enemyShip;
    //private bool gamePlay;

    void Start()
    {
        //gamePlay = true;
        InvokeRepeating("SpawnShip", 2f, spawnTime);
    }

    void Update()
    {
        
    }

    void SpawnShip()
    {
        spawnPosition = new Vector3(Random.Range(-spawnRange, spawnRange), 12, 0);
        Instantiate(enemyShip, spawnPosition, Quaternion.identity);
    }
}