using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWall : MonoBehaviour
{

    public Transform rightWall;
    public Transform leftWall;
    public float speed;
    public Transform startPos;
    Vector3 nextPos;

    void Start()
    {

        nextPos = startPos.position;

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position == rightWall.position)
        {

            nextPos = leftWall.position;

        }
        if (transform.position == leftWall.position)
        {

            nextPos = rightWall.position;

        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);

    }
}
