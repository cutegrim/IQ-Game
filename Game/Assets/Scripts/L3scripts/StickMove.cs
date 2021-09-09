using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickMove : MonoBehaviour
{

    Rigidbody2D rb;
    float deltaX, deltaY;
    
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

                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
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

        }

    }

}
