using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bullet : MonoBehaviour
{
    //public float life = 3;

    private void Awake()
    {
        Destroy(gameObject, 3);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        //Destroy(gameObject);
        
        Debug.Log(collision.contacts[0].otherCollider.GetComponent<Transform>().name);
        
        collision.contacts[0].otherCollider.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }

    /* private void OnCollisionExit(Collision other)
    {
        Debug.Log("No longer in contact with " + other.transform.name);
        other.contacts[0].otherCollider.GetComponent<MeshRenderer>().material.color = Color.grey;
   } */

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<MeshRenderer>().material.color = Color.yellow;
        //Destroy(gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<MeshRenderer>().material.color = Color.green;
    }
    
}
