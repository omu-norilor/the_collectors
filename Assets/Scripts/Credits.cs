using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public static int creds;
    public  Text credsText;
    void Start()
    {
        creds = PlayerPrefs.GetInt("Credits", 0);
        credsText.GetComponent<Text>();
    }


    void Update()
    {
        Debug.Log("UPDATE"+Credits.creds);
        credsText.text = "CREDITS:" + creds.ToString();
    }
    
}
