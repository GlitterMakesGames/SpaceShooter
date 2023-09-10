using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public bool parentIsEnemy = false;
    void OnTriggerEnter(Collider other)  // Unity's built-in collision handler
    {
        if (other.gameObject.tag == "Enemy" && !parentIsEnemy)
        {
            EnemyScript eScript = other.gameObject.GetComponent<EnemyScript>();
            eScript.enemyHealthCount--;
            if (eScript.enemyHealthCount <= 0)
            { 
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            PlayerScript eScript = other.gameObject.GetComponent<PlayerScript>();
            eScript.playerHealthCount--;
            if (eScript.playerHealthCount <= 0)
            {
                Destroy(other.gameObject);
            }
            Destroy(gameObject);
        }
    }
}