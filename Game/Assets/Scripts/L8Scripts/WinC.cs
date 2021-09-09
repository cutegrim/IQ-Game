using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WinC : LevelUnlocker
{

    public GameObject firedStick;
    public GameObject button;
    public GameObject textButton;
    bool fired = false;

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Fire"))
        {

            firedStick.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1);
            fired = true;

        }

        if (other.gameObject.CompareTag("Bomb") && fired == true)
        {

            StartCoroutine(ShowButton());


        }

    }

    IEnumerator ShowButton()
    {

        yield return new WaitForSeconds(0.5f);
        button.GetComponent<Image>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        button.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0.8f, 0.176f, 0.176f, 1);
        globalNumber = 9;

    }

}
