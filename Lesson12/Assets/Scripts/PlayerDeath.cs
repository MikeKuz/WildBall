using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] public GameObject player;
    public GameObject flash;
    public GameObject lossPanel;
    //public GameObject panelMenu;

    public void KillPlayer()
    {
        player.SetActive(false);
        flash.SetActive(true);
        lossPanel.SetActive(true);
        WildBall.Inputs.PlayerMovement.TurnOffUnderControl();
        
        //panelMenu.GameMenuScript.PressedGameMenuExpceptContinue();

    }
}
