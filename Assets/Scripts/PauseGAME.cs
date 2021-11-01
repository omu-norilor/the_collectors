using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGAME : MonoBehaviour
{
    public static bool paused = true;
    public GameObject pausePanel;
    public void Start()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        paused = false;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        paused = true;
    }


    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
        paused = false;
    }
}
