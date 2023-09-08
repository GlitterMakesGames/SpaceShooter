using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float shipSpeed = 4f;

    void Start()
    {
        
    }

    void Update()
    {
        float hMove = Input.GetAxisRaw("Horizontal");
        transform.Translate(hMove * shipSpeed * Time.deltaTime, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3, 3), transform.position.y, transform.position.z);
    }
}