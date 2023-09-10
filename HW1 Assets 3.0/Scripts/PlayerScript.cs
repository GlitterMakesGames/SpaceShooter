using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float shipSpeed = 4f;
    public int clampAmount = 3;

    public Transform shotSpawn;
    public float projectileSpeed = 1000f;
    public float shotTime = 025f;
    public float playerHealthCount = 3;
    public Rigidbody playerShot;
    [SerializeField] private bool canShoot;

    void Start()
    {
        canShoot = true;
    }

    void Update()
    {
        float hMove = Input.GetAxisRaw("Horizontal");
        transform.Translate(hMove * shipSpeed * Time.deltaTime, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -clampAmount, clampAmount), transform.position.y, transform.position.z);

        if (Input.GetButton("Fire1") && canShoot)
        {
            StartCoroutine("FireSpeed");
            //canShoot = false;
            //Invoke("UpdateCanShoot", shotTime);
            Rigidbody _shot;
            _shot = Instantiate(playerShot, shotSpawn.position, shotSpawn.rotation) as Rigidbody;
            _shot.AddForce(shotSpawn.up * projectileSpeed);
        }
    }

    IEnumerator FireSpeed()
    {
        //canShoot = false;
        yield return new WaitForSeconds(shotTime);
        //canShoot = true;
    }

    /*void UpdateCanShoot()
    {
        canShoot = true;
    }*/
}