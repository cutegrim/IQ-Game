using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour
{

    public GameObject num15;
    public GameObject empty;
    int swiTch = 0;
    int frames = 0;
    

    void FixedUpdate()
    {

        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (num15.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                num15.GetComponent<Rigidbody2D>().gravityScale = 1;
                

            }
           

        }
        frames++ ;
        if (frames % 20 == 0) Frame20Update();


    }
    void Frame20Update()
    {

        switch (swiTch)
        {

            case 1:

                empty.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 0f);
                swiTch = 0;
                break;

            case 0:

                empty.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
                swiTch = 1;
                break;


        }
        frames = 0;

    }

}
