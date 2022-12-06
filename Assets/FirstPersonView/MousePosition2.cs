using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition2 : MonoBehaviour
{
    public float mouseSenstivity= 50f;

    private float xRotation = 0f;
    private float yRotation = 0f;


    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked; // hiding cursor
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSenstivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSenstivity;

        
        
        xRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(yRotation, xRotation, 0f);
        

    }
}
