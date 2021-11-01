using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMenu : MonoBehaviour
{
    public GameObject mapPanel;
    public GameObject settingsPanel;
    public void Start()
    {
        Time.timeScale = 1f;
        mapPanel.SetActive(false);
        settingsPanel.SetActive(false);
    }
    public void RaiseMap()
    {
        Time.timeScale = 0f;
        mapPanel.SetActive(true);
        
    }

    public void FallMap()
    {
        Time.timeScale = 1f;
        mapPanel.SetActive(false);

    }
    public void RaiseSettings()
    {
        
        settingsPanel.SetActive(true);

    }

    public void FallSettings()
    {
        
        settingsPanel.SetActive(false);

    }
}
