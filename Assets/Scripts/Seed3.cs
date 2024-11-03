using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed3 : MonoBehaviour
{
    private Vector3 offset;
    private bool isHeld = false;
    private Vector2 startingPosition;
    private SpriteRenderer sprite;

    void Start()
    {
        startingPosition = transform.position;
        sprite = GetComponent<SpriteRenderer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(isHeld)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            sprite.sortingOrder = 4;
        }
        if(!isHeld)
        {
            sprite.sortingOrder = 0;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isHeld = true;
        Seed1.seedType = 3;
    }

    private void OnMouseUp()
    {
        isHeld = false;
        transform.position = startingPosition;
        Seed1.seedDown = 1;
        Seed1.seedTimer = 5;
        Seed1.playSeedSound = 1;
    }
}
