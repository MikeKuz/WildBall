using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffControlScript : MonoBehaviour
{
    [SerializeField]private GameObject DisabledObj;
    
    static  bool PlayerInZone = false;
    static public bool EIsPressed = false;

    private void Update()
    {
        if (DisabledObj.activeInHierarchy == true)
        {
            if (PlayerInZone && EIsPressed)
            {
                CheckTriggers();
            }
        }
    }

    public void CheckTriggers()
    {
        DisabledObj.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        PlayerInZone = false;
    }
}
