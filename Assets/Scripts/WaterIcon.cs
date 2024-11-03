using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterIcon : MonoBehaviour
{
    private Vector3 offset;
    private bool isHeld = false;
    private Vector2 startingPosition;
    public static int waterDown = 0;
    public static int waterTimer = 0;
    private SpriteRenderer sprite;
    public static int playWaterSound;

    void Start()
    {
        startingPosition = transform.position;
        sprite = GetComponent<SpriteRenderer>();
        playWaterSound = 0;
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
            sprite.sortingOrder = 1;
        }
        if(waterTimer != 0)
        {
            waterTimer--;
        }
        if(waterTimer == 0)
        {
            waterDown = 0;
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
        transform.position = startingPosition;
        waterDown = 1;
        waterTimer = 5;
        playWaterSound = 1;
        

        //Todo - fix where you can fling mouse
    }
}
