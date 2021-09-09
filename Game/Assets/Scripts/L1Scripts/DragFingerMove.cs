using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DragFingerMove : LevelUnlocker
{

    public GameObject button;
    public GameObject textButton;
    public GameObject owl;
    // touch offset allows ball not to shake when it starts moving
    float deltaX, deltaY;
   

    // reference to Rigidbody2D component
    Rigidbody2D rb;
    Transform trans;


    // ball movement not allowed if you touches not the ball at the first time
    


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {


        // Initiating touch event
        // if touch event takes place
        if (Input.touchCount > 0)
        {


            // get touch position
            Touch touch = Input.GetTouch(0);


            // obtain touch position
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);


            // get touch to take a deal with
            switch (touch.phase)
            {


                // if you touches the screen
                case TouchPhase.Began:

                    // if you touch the ball
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {

                        // get the offset between position you touches
                        // and the center of the game object
                        deltaX = touchPos.x  - transform.position.x;
                        deltaY = touchPos.y  - transform.position.y;

                        // if touch begins within the ball collider
                        // then it is allowed to move
                      
                       
                       

                    }
                    break;

                // you move your finger
                case TouchPhase.Moved:

                    // if you touches the ball and movement is allowed then move
                    if (Physics2D.OverlapPoint(touchPos) )

                        rb.MovePosition(new Vector2(touchPos.x  - deltaX, touchPos.y  - deltaY));

                    break;


                // you release your finger
                case TouchPhase.Ended:

                    Vector3 rightPosition = new Vector3(1.4f, 1, -9);
                    if ((trans.position.x < 2.4f && trans.position.x > 0.4f) && (trans.position.y < 2f && trans.position.y > 0f))
                    {

                        trans.position = rightPosition;
                        owl.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1);
                        StartCoroutine(ShowButton());

                    }

                    break;

            }
        }
    }

    IEnumerator ShowButton()
    {

        yield return new WaitForSeconds(1);
        button.GetComponent<Image>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        button.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0.8f, 0.176f, 0.176f, 1);
        globalNumber = 2;

    }

}

