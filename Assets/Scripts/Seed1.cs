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
    public static int seedTimer = 0;
    private SpriteRenderer sprite;
    public static int playSeedSound;

    void Awake()
    {
        Application.targetFrameRate = 165;
        playSeedSound = 0;
    }

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
        if(seedTimer != 0)
        {
            seedTimer--;
        }
        if(seedTimer == 0)
        {
            seedDown = 0;
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
        seedTimer = 5;
        playSeedSound = 1;

        //Todo - fix where you can fling mouse
    }
}
