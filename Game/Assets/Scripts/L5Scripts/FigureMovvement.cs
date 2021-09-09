using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FigureMovvement : MonoBehaviour
{

    public GameObject king;
    public GameObject pawn;
    public GameObject knight;
    public Rigidbody2D rb;
    public Rigidbody2D rbKnight;
    public Rigidbody2D rbPawn;
    bool used = false;
    bool right = false;
    bool up = false;
    int waitTime = 2;
    FigureMenu script;
    public GameObject canvas;
    int oneCall = 0;

    void Start()
    {

        script = canvas.GetComponent<FigureMenu>();
    }

    void FixedUpdate()
    {

        // rb.AddForce(transform.up);
        if (rb.transform.position.y > 1.29 || rb.transform.position.y < -0.05 || rb.transform.position.x > 0.76 || rb.transform.position.x < -0.38) 
        { 
            
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
            StartCoroutine(Restart());

        }

        if (rbPawn.transform.position.y > 1.94) 
        { 

            rbPawn.constraints = RigidbodyConstraints2D.FreezePosition;
            if (oneCall == 0) 
            {
                
                script.MenuReveal();
                oneCall = 1;

            }

        }

        if ((rbKnight.transform.position.y > 1.35 || rbKnight.transform.position.y < -1.31) && used == false)
        {

            used = true;
            rbKnight.constraints = RigidbodyConstraints2D.FreezePositionY;
            if (right == false) KnightMove(2);
            else if (right == true) KnightMove(3);

        }
        else if ((rbKnight.transform.position.x > 1.97 || rbKnight.transform.position.x < -0.27) && used == false)
        {

            used = true;
            rbKnight.constraints = RigidbodyConstraints2D.FreezePositionX;
            if (up == false) KnightMove(6);
            else if (up == true) KnightMove(0);

        }
        else if ((rbKnight.transform.position.y > 0.68 || rbKnight.transform.position.y < -0.64) && used == true )
        {

            rbKnight.constraints = RigidbodyConstraints2D.FreezePositionY;
            if ((rbKnight.transform.position.x > 1.42 || rbKnight.transform.position.x < 0.29) && used == true)
            {

                rbKnight.constraints = RigidbodyConstraints2D.FreezePositionX;
                

            }
            else waitTime++;
            StartCoroutine(Restart());

        }

    }

    public void KingMove(int direction)
    {

        king.GetComponent<Collider2D>().enabled = false;
        pawn.GetComponent<Collider2D>().enabled = false;
        knight.GetComponent<Collider2D>().enabled = false;

        if (direction == 0) 
        {

            for (int i = 0; i < 10; i++)
            {

                rb.AddForce(transform.up);
                rb.AddForce(-transform.right);

            } 

        }
        else if (direction == 2) for (int i = 0; i < 10; i++) rb.AddForce(-transform.right);
        else if (direction == 3) for (int i = 0; i < 10; i++) rb.AddForce(transform.right);
        else if (direction == 4)
        {

            for (int i = 0; i < 10; i++)
            {

                rb.AddForce(-transform.up);
                rb.AddForce(-transform.right);

            }

        }
        else if (direction == 5) for (int i = 0; i < 10; i++) rb.AddForce(-transform.up);

    }

    public void PawnMove()
    {

        king.GetComponent<Collider2D>().enabled = false;
        pawn.GetComponent<Collider2D>().enabled = false;
        knight.GetComponent<Collider2D>().enabled = false;
        for (int i = 0; i < 10; i++) rbPawn.AddForce(transform.up);

    }
    public void KnightMove(int direction)
    {

        king.GetComponent<Collider2D>().enabled = false;
        pawn.GetComponent<Collider2D>().enabled = false;
        knight.GetComponent<Collider2D>().enabled = false;
        switch (direction)
        {

            case 0:

                for (int i = 0; i < 10; i++) rbKnight.AddForce(transform.up);
                break;

            case 1:

                for (int i = 0; i < 10; i++) rbKnight.AddForce(transform.up);
                right = true;
                break;


            case 2:

                for (int i = 0; i < 10; i++) rbKnight.AddForce(-transform.right);
                up = true;
                break;

            case 3:

                for (int i = 0; i < 10; i++) rbKnight.AddForce(transform.right);
                up = true;
                break;

            case 4:

                for (int i = 0; i < 10; i++) rbKnight.AddForce(-transform.right);
                break;

            case 5:

                for (int i = 0; i < 10; i++) rbKnight.AddForce(transform.right);
                break;

            case 6:

                for (int i = 0; i < 10; i++) rbKnight.AddForce(-transform.up);
                break;


            case 7:

                for (int i = 0; i < 10; i++) rbKnight.AddForce(-transform.up);
                right = true;
                break;

        }

    }

    IEnumerator Restart()
    {

        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(7);

    }

}
