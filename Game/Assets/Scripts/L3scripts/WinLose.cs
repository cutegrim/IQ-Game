using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class WinLose : LevelUnlocker
{

    public GameObject stick0;
    public GameObject stick1;
    public GameObject stick2;
    public GameObject stick3;
    public GameObject button;
    public GameObject textButton;
    List<int> numbers = new List<int>() {0,0,0,0};
    float stick0X;
    float stick0Y;

    void Update()
    {

        stick0X = stick0.GetComponent<Transform>().position.x;
        stick0Y = stick0.GetComponent<Transform>().position.y;
        if (stick0.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Dynamic)
        {

            numbers[0] = 1;
            if(numbers.Count(n => n == 1) > 1) StartCoroutine(Restart());

        }
        else if (stick1.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Dynamic)
        {

            numbers[1] = 1;
            if (numbers.Count(n => n == 1) > 1) StartCoroutine(Restart());

        }
        else if (stick2.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Dynamic)
        {

            numbers[2] = 1;
            if (numbers.Count(n => n == 1) > 1) StartCoroutine(Restart());

        }
        else if (stick3.GetComponent<Rigidbody2D>().bodyType == RigidbodyType2D.Dynamic)
        {

            numbers[3] = 1;
            if (numbers.Count(n => n == 1) > 1) StartCoroutine(Restart());

        }
        else
        {

            if (numbers.Count(n => n == 1) == 1 && 
                stick0X < -1.11f && stick0X > - 1.2f && 
                stick0Y < -0.65f && stick0Y > - 0.7f)
            {

                StartCoroutine(ShowButton());

            }

        }

    }

    IEnumerator Restart()
    {

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(5);

    }

    IEnumerator ShowButton()
    {

        yield return new WaitForSeconds(1);
        button.GetComponent<Image>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        button.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0.8f, 0.176f, 0.176f, 1);
        globalNumber = 4;

    }

}
