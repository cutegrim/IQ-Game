using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClick : MonoBehaviour
{    
    public void LevelSelect()
    {
        SceneManager.LoadScene(1);
    }
}
