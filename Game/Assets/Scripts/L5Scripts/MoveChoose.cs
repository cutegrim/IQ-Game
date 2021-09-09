using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChoose : MonoBehaviour
{

    public GameObject king;
    public GameObject knight;
    public GameObject pawn;
    public GameObject E3;
    public GameObject G3;
    public GameObject D4;
    public GameObject H4;
    public GameObject D5;
    public GameObject E5;
    public GameObject D6;
    public GameObject F6;
    public GameObject H6;
    public GameObject D7;
    public GameObject E7;
    public GameObject G7;
    public GameObject H8;
    int select = 0;
    FigureMovvement script;

    void Start()
    {
        
        script = king.GetComponent<FigureMovvement>();

    }

    void FixedUpdate()
    {
        
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (king.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                select = 1;

            }
            else if (pawn.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                select = 2;

            }
            else if (knight.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                select = 3;
                Debug.Log(Input.touchCount);

            }

            if (select == 1)
            {

               
                if (D7.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KingMove(0);

                }
                else if (D6.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KingMove(2);

                }
                else if (F6.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KingMove(3);

                }
                else if (D5.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KingMove(4);

                }
                else if (E5.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KingMove(5);

                }

            }
            else if (select == 2)
            {

                if (H8.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.PawnMove();

                }

            }
            else if (select == 3)
            {

                if (E7.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KnightMove(0);

                }
                else if (G7.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KnightMove(1);

                }
                else if (D6.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KnightMove(2);

                }
                else if (H6.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KnightMove(3);

                }
                else if (D4.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KnightMove(4);

                }
                else if (H4.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KnightMove(5);

                }
                else if (E3.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KnightMove(6);

                }
                else if (G3.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                {

                    script.KnightMove(7);

                }

            }

        }

    }

}
