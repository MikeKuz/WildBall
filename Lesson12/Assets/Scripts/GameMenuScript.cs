using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuScript : MonoBehaviour
{
    public GameObject gameMenuPanel;
    public GameObject continueButton;

    public void PressedGameMenu()
    {
        gameMenuPanel.SetActive(true);
    }

    public void PressedGameMenuExpceptContinue()
    {
        gameMenuPanel.SetActive(true);
        continueButton.GetComponent<Button>().interactable = false;
    }

}
