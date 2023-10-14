using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WildBall.Inputs;

public class GroundCheck : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("На земле");
            PlayerMovement.TurnOnJump();
        }
    }

    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Над землей");
            PlayerMovement.TurnOffJump();
        }
    }

}
