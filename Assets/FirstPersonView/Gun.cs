using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public Transform bulletSpawn; 
    public GameObject bulletPrefab;

    private Vector3 EndPoint;
    private Canvas canvas;
    private Image img;
    private Camera cam;
    private MousePosition2 mos;





    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            // rb.velocity = Vector3.forward * bulletSpeed; 
            
            var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawn.forward * bulletSpeed;
            

        }
        

    }
    
    
}
