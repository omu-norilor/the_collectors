using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public string gameLevel;
    [SerializeField]
    string unlocked_name;
    [SerializeField]
    bool locked;
    [SerializeField]
    int price;
    public Text to_change;
    private void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void startGame()
    {
        Time.timeScale = 1f;
        if(locked==true)
        {
            if (Credits.creds >= price)
            {
                PlayerPrefs.SetInt("Credits", PlayerPrefs.GetInt("Credits") - price);
                locked = false;
                to_change.text = unlocked_name;
            }
            else return;
        }
        SceneManager.LoadScene(gameLevel);
    }
}
