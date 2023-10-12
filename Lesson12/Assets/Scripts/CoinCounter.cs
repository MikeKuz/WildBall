using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance = null;

    public static int coinCounter=0;
    public Text textCoinCounter;
    public Text textCoinCounterOnWinPanel;


    private void Start()
    {
        if (instance == null)
        { 
            instance = this;
        }

        else if (instance == this)
        { 
            Destroy(gameObject);
        }

        ResetCoinCounter();
    }


    public void ResetCoinCounter()
    {
        coinCounter = 0;
        textCoinCounterOnWinPanel.text = coinCounter.ToString();
    }

    public void AddCoin()
    {
        coinCounter++;
        textCoinCounter.text = coinCounter.ToString();
        textCoinCounterOnWinPanel.text = coinCounter.ToString();
    }


}
