﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameScript : MonoBehaviour
{
    
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Кнопка выхода нажата");
    }
}
