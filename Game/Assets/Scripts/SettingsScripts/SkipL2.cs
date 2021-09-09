using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SkipL2 : LevelUnlocker
{

    public void Next()
    {

        SceneManager.LoadScene(5);
        globalNumber = 3;

    }

}
