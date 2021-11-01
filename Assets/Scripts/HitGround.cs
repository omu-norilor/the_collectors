using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitGround : MonoBehaviour
{
    [SerializeField]
    public Dropp drop;
    [SerializeField]
    public GameObject obiect;
    private void OnTriggerEnter2D(Collider2D ground)
    {
        Debug.Log("HIT SHIT");
        if (ground.gameObject.name.Equals("Pamant"))
        {
            Lives.lives -= drop.damage;
            Destroy(obiect.gameObject);
        }

    }
    [System.Serializable]
    public class Dropp
    {
        public int damage;
    }
}
