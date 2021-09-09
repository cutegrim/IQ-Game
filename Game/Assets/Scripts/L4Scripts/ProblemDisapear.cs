using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProblemDisapear : MonoBehaviour
{

    
    public GameObject part1;
    public GameObject part3;
    public GameObject scriptHolder;
    int scenario = 0;
    MathSolutions script;

    private void Start()
    {

        script = scriptHolder.GetComponent<MathSolutions>();

    }

    void FixedUpdate()
    {
        
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (part1.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                part1.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 0);
                if (scenario == 0)
                {

                    scenario = 1;
                    

                }
                else if (scenario == 2)
                {

                    scenario = 3;

                }

            }
            else if (part3.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                part3.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 0);
                if (scenario == 0)
                {

                    scenario = 2;

                }
                else if (scenario == 1)
                {

                    scenario = 3;

                }

            }

        }
        
    }

    public void CallSolutions()
    {

        script.IsItCorrect(scenario);

    }

}
