using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MathSolutions : LevelUnlocker
{

    public Text inputText;
    public GameObject button;
    public GameObject textButton;

    public void IsItCorrect(int variant)
    {

        if ( inputText.text == "35" && variant == 1) StartCoroutine(ShowButton());
        else if (inputText.text == "7" && variant == 2) StartCoroutine(ShowButton());
        else if (inputText.text == "11" && variant == 3) StartCoroutine(ShowButton());
        else if (inputText.text == "31" && variant == 0) StartCoroutine(ShowButton());

    }

    IEnumerator ShowButton()
    {

        yield return new WaitForSeconds(1);
        button.GetComponent<Image>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        button.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0.8f, 0.176f, 0.176f, 1);
        globalNumber = 5;

    }

}
