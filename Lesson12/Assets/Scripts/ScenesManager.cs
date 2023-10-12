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
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene(index);
    }

    public void LoadNextLevel()
    {
        bool lastLevel = LastSceneCheck();

        if (lastLevel==false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (lastLevel)
        {
            fullWinPanel.SetActive(true);
        }
    }

    //�������� ����� ��������� �� ���
    static public bool LastSceneCheck()
    {
        if(SceneManager.sceneCountInBuildSettings - 1 > SceneManager.GetActiveScene().buildIndex)
        {
            return false;
        }

        else return true;
       
    }
}
