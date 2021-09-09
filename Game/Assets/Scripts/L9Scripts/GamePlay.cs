using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay : LevelUnlocker
{

    public Text inputText;
    public GameObject pLetter;
    public GameObject sLetter;
    public GameObject gLetter;
    public GameObject mLetter;
    public GameObject vLetter;
    public GameObject nLetter;
    public GameObject lLetter;
    public GameObject fLetter;
    public GameObject iLetter;
    public GameObject hLetter;
    public GameObject[] rLetter;
    public GameObject[] oLetter;
    public GameObject[] aLetter;
    public GameObject[] eLetter;
    public GameObject[] bodyParts;
    int correctCounter = 0;
    int elseCounter = 0;
    public GameObject button;
    public GameObject textButton;


    public void Start()
    {

        rLetter = GameObject.FindGameObjectsWithTag("R");
        oLetter = GameObject.FindGameObjectsWithTag("O");
        aLetter = GameObject.FindGameObjectsWithTag("A");
        eLetter = GameObject.FindGameObjectsWithTag("E");
    }

    public void CorrectAnswer()
    {

        correctCounter++;
        if (inputText.text == "p" || inputText.text == "P") pLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "s" || inputText.text == "S") sLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "r" || inputText.text == "R")
        {

            foreach (GameObject letter in rLetter) letter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);

        }
        else if (inputText.text == "o" || inputText.text == "O")
        {

            foreach (GameObject letter in oLetter) letter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);

        }
        else if (inputText.text == "g" || inputText.text == "G") gLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "a" || inputText.text == "A")
        {

            foreach (GameObject letter in aLetter) letter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);

        }
        else if (inputText.text == "m" || inputText.text == "M") mLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "e" || inputText.text == "E")
        {

            foreach (GameObject letter in eLetter) letter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);

        }
        else if (inputText.text == "v" || inputText.text == "V") vLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "n" || inputText.text == "N") nLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "l" || inputText.text == "L") lLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "f" || inputText.text == "F") fLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "i" || inputText.text == "I") iLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else if (inputText.text == "h" || inputText.text == "H") hLetter.GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        else 
        { 

            Hanging();
            correctCounter--;

        }
        if (correctCounter == 14) StartCoroutine(ShowButton());
        Debug.Log(correctCounter);

    }

    public void Hanging()
    {

        bodyParts[elseCounter].GetComponent<SpriteRenderer>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        if (elseCounter == 5) Restart();
        elseCounter++;
        Debug.Log(elseCounter);

    }

    void Restart()
    {

        SceneManager.LoadScene(11);

    }

    IEnumerator ShowButton()
    {

        yield return new WaitForSeconds(2);
       
        button.GetComponent<Image>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        button.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0.8f, 0.176f, 0.176f, 1);
        globalNumber = 10;

    }

}
