using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
namespace WildBall.Inputs 
{
    //[RequireComponent(typeof(Rigidbody))]

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 20)] private float speed = 15.0f;
        [SerializeField, Range(0, 20)] private float JumpPoewr = 2.0f;
        private Rigidbody playerRigidbody;
        static public bool underControl = true;
        static bool jumpIsOn = false;

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
            TurnOnUnderControl();
        }

        public void MoveCharacter(Vector3 movement)
        {
            if (underControl == true)
            {
                playerRigidbody.AddForce(movement * speed);
            }
        }

        public void JumpCharacter()
        {
            if (underControl == true)
            {
                if(jumpIsOn)
                {
                    playerRigidbody.AddForce(new Vector3(0, 100, 0) * JumpPoewr);
                }
            }
        }

        static public void TurnOffUnderControl()
        {
            underControl = false;
        }

        static public void TurnOnUnderControl()
        {
            underControl = true;
        }

        static public void TurnOffJump()
        {
            jumpIsOn = false;
        }

        static public void TurnOnJump()
        {
            jumpIsOn = true;
        }
    }
}
