using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed3 : MonoBehaviour
{
    private Vector3 offset;
    private bool isHeld = false;
    private Vector2 startingPosition;

    void Start()
    {
        startingPosition = transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(isHeld)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isHeld = true;
        Seed1.seedType = 3;
    }
    //test
    private void OnMouseUp()
    {
        isHeld = false;
        transform.position = startingPosition;
        Seed1.seedDown = 1;
        //Seed1.seedType = 0;
    }
}
