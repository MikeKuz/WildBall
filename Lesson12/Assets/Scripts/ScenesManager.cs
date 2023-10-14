using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public int index;
    public GameObject fullWinPanel;

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    static public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        TimerScript.RestartTimer();

    }

    public void SelectLevel()
    {
        SceneManager.LoadScene(index);
        TimerScript.RestartTimer();

    }

    public void LoadNextLevel()
    {
        bool lastLevel = LastSceneCheck();

        if (lastLevel==false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            TimerScript.RestartTimer();
        }

        else if (lastLevel)
        {
            fullWinPanel.SetActive(true);
        }
    }

    //проверка сцены последн€€ ли она
    static public bool LastSceneCheck()
    {
        if(SceneManager.sceneCountInBuildSettings - 1 > SceneManager.GetActiveScene().buildIndex)
        {
            return false;
        }

        else return true;
       
    }
}
