using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int lives;
    public Text livesText;
    public GameObject gameOverPanel;
    int ded = 0;
    
    void Start()
    {
        gameOverPanel.SetActive(false);
        lives = 1;
        livesText.GetComponent<Text>();
    }


    void Update()
    {   
        livesText.text = ":" + lives.ToString();
        if (lives == 0)
        {
            
            gameOverPanel.SetActive(true);
            if (ded == 0)
            {
                ded = 1;
                PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") + Score.score);
                //Score.score += Credits.creds;
                Debug.Log(Credits.creds);
                Time.timeScale = 0f;
            }
            
        }

    }
}
