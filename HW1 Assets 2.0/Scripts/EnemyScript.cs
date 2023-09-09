using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float _frequency = 6f;
    public float _distance = 0.75f;
    private float initialXPosition;

    void Start()
    {
        initialXPosition = transform.position.x;
    }

    void Update()
    {
        transform.Translate(0, -2.5f * Time.deltaTime, 0);
        transform.Rotate(0, 5f, 0);

        transform.position = new Vector3(initialXPosition + XSine(), transform.position.y, transform.position.z);
    }

    public float XSine()
    {
        return Mathf.Sin(Time.time * _frequency) * _distance;
    }

    public void SetInitialXPosition(float x)
    {
        initialXPosition = x;
    }
}