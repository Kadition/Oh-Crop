using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed1 : MonoBehaviour
{
    private Vector3 offset;
    private bool isHeld = false;
    private Vector2 startingPosition;
    public static int seedType;
    public static int seedDown = 0;

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
        seedType = 1;
    }

    private void OnMouseUp()
    {
        isHeld = false;
        transform.position = startingPosition;
        seedDown = 1;
    }
}