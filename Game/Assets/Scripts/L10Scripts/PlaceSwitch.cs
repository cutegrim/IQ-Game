using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceSwitch : TurnOn
{

    Transform trans;
    Vector2 help;
    public RightPlace script;
   

    void Start()
    {

        
        trans = GetComponent<Transform>();
        

    }
    
    void FixedUpdate()
    {

        if (Input.touchCount > 0 && num15.GetComponent<Rigidbody2D>().gravityScale == 1)
        {

            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                help = trans.position;
                trans.position = empty.transform.position;
                empty.transform.position = help;
                script.IsItRight();

            }
            

        }
        

    }

}