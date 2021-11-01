using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField]
    public string sceneName;
    
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneName);
    }
}
