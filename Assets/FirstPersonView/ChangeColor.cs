using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class ChangeColor : MonoBehaviour
{
    public Camera cam;

    private void Start()
    {
        Cursor.visible = false;
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            shoot2();
        }
    }
    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward , out hit))
        {
     
            Debug.Log(hit.transform.name);
            if (hit.transform  != null )
            {
                if (hit.transform.GetComponent<MeshRenderer>())
                {
                    hit.transform.GetComponent<MeshRenderer>().material.color =Color.cyan;
                    Debug.Log("CYAN!");
                }
               
                
            }
            
        }
    }
    
    void shoot2()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward , out hit))
        {
            Debug.Log(hit.transform.name);
            if (hit.transform != null)
            {
                if (hit.transform.GetComponent<MeshRenderer>())
                {
                    hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
                    Debug.Log("RED!!");
                }
            }
          
        }
    }
}
