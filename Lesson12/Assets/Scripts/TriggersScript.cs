using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersScript : MonoBehaviour
{
    
    public PlayerDeath playerDeath;
    public GameObject textPressE;
    public bool Interactive;
    //public CoinCounter coinCounter;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("KillObj"))
        {
            //var playerDeath = new PlayerDath();
            playerDeath.KillPlayer();
            //ScenesManager.ReloadScene();
        }

        else if (other.CompareTag("Interactive"))
        {
            Interactive = true;
            textPressE.SetActive(true);
        }

        else if (other.CompareTag("Coin"))
        {
            CoinCounter.instance.AddCoin();
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactive"))
        {
            Interactive = false;
            textPressE.SetActive(false);
        }
    }
}
