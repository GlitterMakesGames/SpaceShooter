using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float spawnTime = 2f;
    public float spawnRange = 2.5f;
    public GameObject enemyShipPrefab;
    private bool gamePlay;

    void Start()
    {
        gamePlay = true;
        InvokeRepeating("SpawnShip", 2f, spawnTime);
    }

    void Update()
    {

    }

    void SpawnShip()
    {
        if (gamePlay)
        {
            float randomX = Random.Range(-2.5f, 2.5f);

            Vector3 spawnPosition = new Vector3(randomX, 5, 10);

            GameObject enemyShip = Instantiate(enemyShipPrefab, spawnPosition, Quaternion.identity);

            EnemyScript enemyScript = enemyShip.GetComponent<EnemyScript>();
            enemyScript.SetInitialXPosition(randomX);
        }
    }
}