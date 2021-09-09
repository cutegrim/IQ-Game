using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsClick : MonoBehaviour
{
    public void SettingsEnter()
    {
        SceneManager.LoadScene(2);
    }
}
