using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public string gameLevel;
    private void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void startGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(gameLevel);
    }
}
