using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour
{
    public int unlockedLevels = 1;
    public static int globalNumber = 0; 
    public List<GameObject> buttons = new List<GameObject>();

    void Start()
    {

        //Deletes saved information
        /*PlayerPrefs.DeleteAll();*/ 

        //Saveing number of unlocked levels into unlocked key
        unlockedLevels = PlayerPrefs.GetInt("unlocked");
        if ( globalNumber > unlockedLevels)PlayerPrefs.SetInt("unlocked", globalNumber);
        unlockedLevels = PlayerPrefs.GetInt("unlocked");
        Unlock();

    }

    //Sets what will happen with unlocked levels
    void Unlock()
    {
        
        for (int i = 0; i < buttons.Count; i++)
        {

            if (unlockedLevels >= i + 2)   buttons[i].GetComponent<Button>().interactable = true;
          
        }

    }

}
