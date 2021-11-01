using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamionMove : MonoBehaviour
{
    public GameObject camion;
    public float speed = 300;
    Animator anim;
    private Rigidbody2D camionBody;
    private float ScreenWidth;
    
    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        camionBody = camion.GetComponent<Rigidbody2D>();
        anim = camion.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        int i = 0;
        if (i < Input.touchCount)
        {

            if (Input.GetTouch(i).position.x > ScreenWidth / 2)
            {
                anim.SetBool("Fwd", true);
                MOVE(1.0f);
            }
            else anim.SetBool("Fwd", false);

            if (Input.GetTouch(i).position.x < ScreenWidth / 2)
            {
                anim.SetBool("Bw", true);
                MOVE(-1.0f);
            }
            else anim.SetBool("Bw", false);
        }
        else
        {
            anim.SetBool("Fwd", false);
            anim.SetBool("Bw", false);
        }

    }
    public void MOVE(float horizontalInput)
    {
        camionBody.AddForce(new Vector2(horizontalInput * speed * Time.deltaTime, 0));
    }
    
}
