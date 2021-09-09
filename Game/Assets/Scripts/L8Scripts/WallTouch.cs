using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WallTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Water"))
        {

            
            StartCoroutine(Restart());

        }

    }

    IEnumerator Restart()
    {

        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(10);

    }
}
