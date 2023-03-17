using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Swipe : MonoBehaviour
{
    public GameObject Cube;

    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {

            startTouchPosition = Input.GetTouch(0).position;
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;

            if (endTouchPosition.x < startTouchPosition.x)
            {
                Right();
            }

            if (endTouchPosition.x < startTouchPosition.x)
            {
                Left();
            }
        }
    }
    private void Right()
    {
        Cube.transform.position = new Vector3(Cube.transform.position.x + 1, Cube.transform.position.y, Cube.transform.position.z);
    }
    private void Left()
    {
        Cube.transform.position = new Vector3(Cube.transform.position.x - 1, Cube.transform.position.y, Cube.transform.position.z);
    }
}
