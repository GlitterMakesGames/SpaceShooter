using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootScript : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] public float speed;
    [SerializeField] Rigidbody enemyShot;

    void Start()
    {
        enemyShot = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");

        // Set bullet trajectory toward the player
        Vector3 moveDir = (target.transform.position - transform.position).normalized * speed;
        enemyShot.velocity = new Vector3(moveDir.x, moveDir.y, moveDir.z);
    }
}