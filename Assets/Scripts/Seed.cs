using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    private Vector3 offset;
    private bool isHeld = false;

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
    }

    private void OnMouseUp()
    {
        isHeld = false;
    }
}
