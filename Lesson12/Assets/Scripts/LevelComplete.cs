using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject fullWinPanel;
    public GameObject fireWork;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            WildBall.Inputs.PlayerMovement.TurnOffUnderControl();

            if (ScenesManager.LastSceneCheck())
            {
                fullWinPanel.SetActive(true);
                fireWork.SetActive(true);
            }

            else 
            {
                WinPanel.SetActive(true);
            }

            
        }

    }
}
