using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSript : MonoBehaviour
{
    new Rigidbody rigidbody;

    private void Awake()
    {
       rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rigidbody.AddForce(Vector3.left*1, ForceMode.VelocityChange);
        }
    }
} 
