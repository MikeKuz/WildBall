using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public static float timeElapsed = 0;
    public Text stopwatchText;
    static bool timerIsGo = true;

    void Update()
    {
        if(timerIsGo)
        { 
            timeElapsed += Time.deltaTime;
            DisplayTime(timeElapsed);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliseconds = Mathf.FloorToInt((timeToDisplay * 100) % 100);

        stopwatchText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }

    public static void StopTimer()
    {
        timerIsGo = false;
    }

    public static void RestartTimer()
    {
        timeElapsed = 0;
        timerIsGo = true;
    }
}
