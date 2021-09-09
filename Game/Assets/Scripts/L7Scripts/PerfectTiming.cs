using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerfectTiming : MonoBehaviour
{

    public GameObject water;
    public Collision col;
    

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(WaterFall());

    }


    IEnumerator WaterFall()
    {

        yield return new WaitForSeconds(5);
        int i = 0;
        Rigidbody2D rb;
        while(i < water.transform.childCount)
        {

            rb = water.transform.GetChild(i).GetComponent<Rigidbody2D>();
            rb.gravityScale = 1;
            i++;
            

        }

    }
}
