using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputClear : MonoBehaviour
{

    public InputField number;

    public void Clear()
    {

        number.text = "";
        Debug.Log("CLEAR");

    }

}
