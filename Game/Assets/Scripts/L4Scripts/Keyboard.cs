using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard : MonoBehaviour
{

  public void Appearance()
    {

        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NumberPad, false, false, true);
        Debug.Log("Nums");

    }

}
