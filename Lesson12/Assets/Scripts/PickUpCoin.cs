using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    [SerializeField] GameObject Splash;
    [SerializeField] GameObject Coin;
    CoinCounter coinCounter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Splash.SetActive(true);
            Coin.SetActive(false);
        }
    }
}
