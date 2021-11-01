using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score,scoreOld;
    public Text scoreText;

    void Start()
    {
        score = 0;
        scoreText.GetComponent<Text>();
    }

    
    void Update()
    {
        scoreText.text =":" + score.ToString();
        if (score / 10 > scoreOld / 10)
            Time.timeScale += 0.05f;
        scoreOld = score;

            
    }
}
