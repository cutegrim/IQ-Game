using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MagnifierMove : LevelUnlocker
{

    Rigidbody2D rb;
    float deltaX, deltaY;
    public static int wasDiscovered = 0;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

   
    void FixedUpdate()
    {

        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            switch (touch.phase)
            {

                case TouchPhase.Began:

                    //If you touch right place object will became dynamic

                    if (GetComponent<BoxCollider2D>() == Physics2D.OverlapPoint(touchPos))
                    {

                        rb.bodyType = RigidbodyType2D.Dynamic;
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;

                    }
                    break;

                case TouchPhase.Moved:

                    //Object wont move unless its dynamic

                    if (rb.bodyType != RigidbodyType2D.Static) rb.MovePosition(new Vector2(touchPos.x - deltaX, touchPos.y - deltaY));

                    break;

                case TouchPhase.Ended:

                    rb.bodyType = RigidbodyType2D.Static;

                    break;

            }

            if (rb.transform.position.y > 0.47 && rb.transform.position.x < -0.20 ) wasDiscovered = 1;
        }

    }
}
