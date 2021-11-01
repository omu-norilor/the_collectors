using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchStars : MonoBehaviour
{
    [SerializeField]
    string identifier;
    private void OnTriggerEnter2D(Collider2D punga)
    {

        Debug.Log("COLLECT SHIT");
        if (!punga.gameObject.name.Contains("Pamant"))
            Destroy(punga.gameObject);
        if (punga.gameObject.name.Contains(identifier))
            Lives.lives -=1;
        else Score.score += 1;
    }
}
