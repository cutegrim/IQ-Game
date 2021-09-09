using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FigureMenu : LevelUnlocker
{

    public GameObject menu;
    public GameObject rock;
    public GameObject queen;
    public GameObject knight;
    public GameObject bishop;
    public GameObject pawn;
    public Sprite rockSprite;
    public Sprite queenSprite;
    public Sprite bishopSprite;
    public Sprite knightSprite;
    public GameObject button;
    public GameObject textButton;
    int waitTime = 2;

   
    void FixedUpdate()
    {

        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (rock.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                knight.GetComponent<Collider2D>().enabled = false;
                queen.GetComponent<Collider2D>().enabled = false;
                bishop.GetComponent<Collider2D>().enabled = false;
                pawn.GetComponent<SpriteRenderer>().sprite = rockSprite;
                StartCoroutine(ShowButton());

            }
            else if (queen.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {


                knight.GetComponent<Collider2D>().enabled = false;
                rock.GetComponent<Collider2D>().enabled = false;
                bishop.GetComponent<Collider2D>().enabled = false;
                pawn.GetComponent<SpriteRenderer>().sprite = queenSprite;
                StartCoroutine(ShowButton());

            }
            else if (knight.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {


                rock.GetComponent<Collider2D>().enabled = false;
                queen.GetComponent<Collider2D>().enabled = false;
                bishop.GetComponent<Collider2D>().enabled = false;
                pawn.GetComponent<SpriteRenderer>().sprite = knightSprite;
                StartCoroutine(Restart());

            }
            else if (bishop.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {


                knight.GetComponent<Collider2D>().enabled = false;
                queen.GetComponent<Collider2D>().enabled = false;
                rock.GetComponent<Collider2D>().enabled = false;
                pawn.GetComponent<SpriteRenderer>().sprite = bishopSprite;
                StartCoroutine(Restart());

            }

        }

    }

    public void  MenuReveal()
    {

        menu.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        rock.GetComponent<Collider2D>().enabled = true;
        queen.GetComponent<Collider2D>().enabled = true;
        bishop.GetComponent<Collider2D>().enabled = true;
        knight.GetComponent<Collider2D>().enabled = true;

    }

    IEnumerator ShowButton()
    {

        yield return new WaitForSeconds(1);
        button.GetComponent<Image>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        button.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0.8f, 0.176f, 0.176f, 1);
        globalNumber = 6;

    }

    IEnumerator Restart()
    {

        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(7);

    }

}
