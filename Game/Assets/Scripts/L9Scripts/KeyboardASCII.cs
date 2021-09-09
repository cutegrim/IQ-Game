using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardASCII : MonoBehaviour
{

    public void Appearance()
    {

        TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        Debug.Log("Nums");

    }

}
