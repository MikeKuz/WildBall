using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffFromTouch : MonoBehaviour
{
    [SerializeField] GameObject Controlled;

    private void OnCollisionEnter(Collision collision)
    {
        Controlled.SetActive(false);
    }
}
