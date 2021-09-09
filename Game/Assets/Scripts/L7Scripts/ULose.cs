using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ULose : LevelUnlocker
{

    public GameObject button;
    public GameObject textButton;


    private void Start()
    {

        StartCoroutine(ShowButton());

    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        if (collisionInfo.collider.tag == "Water")
        {

            StartCoroutine(Restart());

        }

    }

    IEnumerator Restart()
    {

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(9);

    }

    IEnumerator ShowButton()
    {

        yield return new WaitForSeconds(12);
        button.GetComponent<Image>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        button.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0.8f, 0.176f, 0.176f, 1);
        globalNumber = 8;

    }

}
