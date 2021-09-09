using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDraw : MonoBehaviour
{

    public GameObject linePrefab;
    public GameObject currentLine;

    public LineRenderer lineRenderer;
    public EdgeCollider2D edgeCollider;
    public List<Vector2> fingerPos;
    public GameObject brush;
    public bool brushActive = false;
    Touch touch;
    

    // Update is called once per frame
    void Update()
    {

        
        if (Input.touchCount > 0)
        {

            touch = Input.GetTouch(0);
             Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if (brush.GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {

                brushActive = true;
                brush.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1);

            }



            if (brushActive == true)
            {

                if (touch.phase == TouchPhase.Began)
                {

                    CreateLine();

                }
                else if (touch.phase == TouchPhase.Moved)
                {

                    Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(touch.position);
                    if (Vector2.Distance(tempFingerPos, fingerPos[fingerPos.Count - 1]) > .1f)
                    {

                        UpdateLine(tempFingerPos);

                    }

                }

            }
           

        }

    }

    void CreateLine()
    {

        
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        fingerPos.Clear();
        fingerPos.Add(Camera.main.ScreenToWorldPoint(touch.position));
        fingerPos.Add(Camera.main.ScreenToWorldPoint(touch.position));
        lineRenderer.SetPosition(0, fingerPos[0]);
        lineRenderer.SetPosition(1, fingerPos[1]);
        edgeCollider.points = fingerPos.ToArray();

    }

    void UpdateLine(Vector2 newFingerPos)
    {

        fingerPos.Add(newFingerPos);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
        edgeCollider.points = fingerPos.ToArray();

    }

}
