using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



[System.Serializable]
public class MyClass
{

    public GameObject colum0;
    public GameObject colum1;
    public GameObject colum2;
    public GameObject colum3;


}

public class GameLogic : MonoBehaviour
{

    double distance = 0.6f;
    public RightPlace script;
    public MyClass[] allButtons;

    void FixedUpdate()
    {

        script.IsItRight();
        for (int i = 0; i < 4; i++)
        {

            if (Math.Abs(allButtons[3].colum3.GetComponent<Transform>().position.y - allButtons[i].colum3.GetComponent<Transform>().position.y) <= distance &&
                allButtons[3].colum3.GetComponent<Transform>().position.x == allButtons[i].colum3.GetComponent<Transform>().position.x)
            {

                allButtons[i].colum3.GetComponent<BoxCollider2D>().enabled = true;

            }
            else if (Math.Abs(allButtons[3].colum3.GetComponent<Transform>().position.x - allButtons[i].colum3.GetComponent<Transform>().position.x) <= distance &&
                    allButtons[3].colum3.GetComponent<Transform>().position.y == allButtons[i].colum3.GetComponent<Transform>().position.y)
                 {

                    allButtons[i].colum3.GetComponent<BoxCollider2D>().enabled = true;

                 }
            else { allButtons[i].colum3.GetComponent<BoxCollider2D>().enabled = false; }

            if (Math.Abs(allButtons[3].colum3.GetComponent<Transform>().position.y - allButtons[i].colum2.GetComponent<Transform>().position.y) <= distance &&
                allButtons[3].colum3.GetComponent<Transform>().position.x == allButtons[i].colum2.GetComponent<Transform>().position.x)
            {

                allButtons[i].colum2.GetComponent<BoxCollider2D>().enabled = true;

            }
            else if (Math.Abs(allButtons[3].colum3.GetComponent<Transform>().position.x - allButtons[i].colum2.GetComponent<Transform>().position.x) <= distance &&
                    allButtons[3].colum3.GetComponent<Transform>().position.y == allButtons[i].colum2.GetComponent<Transform>().position.y)
                 {

                allButtons[i].colum2.GetComponent<BoxCollider2D>().enabled = true;

                 }
            else { allButtons[i].colum2.GetComponent<BoxCollider2D>().enabled = false; }

            if (Math.Abs(allButtons[3].colum3.GetComponent<Transform>().position.y - allButtons[i].colum1.GetComponent<Transform>().position.y) <= distance &&
                allButtons[3].colum3.GetComponent<Transform>().position.x == allButtons[i].colum1.GetComponent<Transform>().position.x)
            {

                allButtons[i].colum1.GetComponent<BoxCollider2D>().enabled = true;

            }
            else if (Math.Abs(allButtons[3].colum3.GetComponent<Transform>().position.x - allButtons[i].colum1.GetComponent<Transform>().position.x) <= distance &&
                    allButtons[3].colum3.GetComponent<Transform>().position.y == allButtons[i].colum1.GetComponent<Transform>().position.y)
                 {

                allButtons[i].colum1.GetComponent<BoxCollider2D>().enabled = true;

                 }
            else { allButtons[i].colum1.GetComponent<BoxCollider2D>().enabled = false; }

            if (Math.Abs(allButtons[3].colum3.GetComponent<Transform>().position.y - allButtons[i].colum0.GetComponent<Transform>().position.y) <= distance &&
               allButtons[3].colum3.GetComponent<Transform>().position.x == allButtons[i].colum0.GetComponent<Transform>().position.x)
            {

                allButtons[i].colum0.GetComponent<BoxCollider2D>().enabled = true;
               

            }
            else if (Math.Abs(allButtons[3].colum3.GetComponent<Transform>().position.x - allButtons[i].colum0.GetComponent<Transform>().position.x) <= distance &&
                    allButtons[3].colum3.GetComponent<Transform>().position.y == allButtons[i].colum0.GetComponent<Transform>().position.y)
            {

                allButtons[i].colum0.GetComponent<BoxCollider2D>().enabled = true;
               

            }
            else { allButtons[i].colum0.GetComponent<BoxCollider2D>().enabled = false; }

        }

       


    }

}
