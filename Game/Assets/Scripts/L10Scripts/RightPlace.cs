using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RightPlace : LevelUnlocker
{

    public GameObject number;
    public GameObject number1;
    public GameObject number2;
    public GameObject number3;
    public GameObject number4;
    public GameObject number5;
    public GameObject number6;
    public GameObject number7;
    public GameObject number8;
    public GameObject number9;
    public GameObject number10;
    public GameObject number11;
    public GameObject number12;
    public GameObject number13;
    public GameObject number14;
    public GameObject button;
    public GameObject textButton;

    public void IsItRight()
    {

        if(number.GetComponent<Transform>().position.x == -1.39f && number.GetComponent<Transform>().position.y == 1.2f)
        {

            Debug.Log("0");
            if (number1.GetComponent<Transform>().position.x == -0.79f && number1.GetComponent<Transform>().position.y == 1.2f)
            {

                Debug.Log("1");
                if (number2.GetComponent<Transform>().position.x == -0.19f && number2.GetComponent<Transform>().position.y == 1.2f)
                {

                    Debug.Log("2");
                    if (number3.GetComponent<Transform>().position.x == 0.41f && number3.GetComponent<Transform>().position.y == 1.2f)
                    {

                        Debug.Log("3");
                        if (number4.GetComponent<Transform>().position.x == -1.39f && number4.GetComponent<Transform>().position.y == 0.6f)
                        {

                            Debug.Log("4");
                            if (number5.GetComponent<Transform>().position.x == -0.79f && number5.GetComponent<Transform>().position.y == 0.6f)
                            {

                                Debug.Log("5");
                                if (number6.GetComponent<Transform>().position.x == -0.19f && number6.GetComponent<Transform>().position.y == 0.6f)
                                {

                                    Debug.Log("6");
                                    if (number7.GetComponent<Transform>().position.x == 0.41f && number7.GetComponent<Transform>().position.y == 0.6f)
                                    {

                                        Debug.Log("7");
                                        if (number8.GetComponent<Transform>().position.x == -1.39f && number8.GetComponent<Transform>().position.y == 0f)
                                        {

                                            Debug.Log("8");
                                            if (number9.GetComponent<Transform>().position.x == -0.79f && number9.GetComponent<Transform>().position.y == 0f)
                                            {

                                                Debug.Log("9");
                                                if (number10.GetComponent<Transform>().position.x == -0.19f && number10.GetComponent<Transform>().position.y == 0f)
                                                {

                                                    Debug.Log("10");
                                                    if (number11.GetComponent<Transform>().position.x == 0.41f && number11.GetComponent<Transform>().position.y == 0f)
                                                    {

                                                        Debug.Log("11");
                                                        if (number12.GetComponent<Transform>().position.x == -1.39f && number12.GetComponent<Transform>().position.y == -0.6f)
                                                        {

                                                            Debug.Log("12");
                                                            if (number13.GetComponent<Transform>().position.x == -0.79f && number13.GetComponent<Transform>().position.y == -0.6f)
                                                            {

                                                                Debug.Log("13");
                                                                if (number14.GetComponent<Transform>().position.x == -0.19f && number14.GetComponent<Transform>().position.y == -0.6f)
                                                                {

                                                                    Debug.Log("14");
                                                                    StartCoroutine(ShowButton());

                                                                }

                                                            }

                                                        }

                                                    }

                                                }

                                            }

                                        }

                                    }

                                }

                            }

                        }

                    }

                }

            }

        }

    }

    IEnumerator ShowButton()
    {

        yield return new WaitForSeconds(2);

        button.GetComponent<Image>().color = new Color(0.69f, 0.69f, 0.69f, 1);
        button.GetComponent<Button>().interactable = true;
        textButton.GetComponent<Text>().color = new Color(0.8f, 0.176f, 0.176f, 1);
        

    }

}


