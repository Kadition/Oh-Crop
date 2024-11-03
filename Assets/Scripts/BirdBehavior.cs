using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class BirdBehavior : MonoBehaviour
{
    private static System.Random rnd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //public int time = 0;
    public float delay = 5;
    public static float moveSpeed = 2f;
    public static float initialX;
    public static float initialY;

    void spawn()
    {
        rnd = new System.Random();

        //Chooses a random position for the bird to start at
        int side = rnd.Next(1,4+1);
        //side determines which side of the screen the bird spawns on. 
        if(side == 1) 
        { //Top
            transform.Translate(new Vector2(rnd.Next(-9, 9+1), 7));
        } else if (side == 2) { //Right
             transform.Translate(new Vector2(11, rnd.Next(-6, 6+1)));
        } else if (side == 3) { //Bottom
             transform.Translate(new Vector2(rnd.Next(-9, 9+1), -7));
        } else if (side == 4) { //Left
             transform.Translate(new Vector2(-11, rnd.Next(-6, 6+1)));
        }

        //gives the initial x and y positions
        initialX = transform.position.x;
        initialY = transform.position.y;

        //absolute value
        if(initialX < 0) {
            initialX *= -1;
        }
        if(initialY < 0) {
            initialY *= -1;
        }
        Debug.Log(initialX);
    }
    
    void Start()
    {   
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(delay > 0.5) {
            delay = delay - 0.01;
        } else if (delay <= 0.5 && delay >= 0.25); {
            delay = delay - 0.005;
        } */
        if((transform.position.x == 0) && (transform.position.y == -1))
        {
            
        }

        if(transform.position.x > 0)  //if x pos is right of 0, move left until 0;
        {
            transform.Translate(Vector2.left * (initialX / 10) * moveSpeed * Time.deltaTime);
        }

        if(transform.position.x < 0)  
        {
            transform.Translate(Vector2.right * (initialX / 10) * moveSpeed * Time.deltaTime);
        }

        if(transform.position.y > -1)  
        {
            transform.Translate(Vector2.down * ((initialY + 1)/ 10) * moveSpeed * Time.deltaTime);       
        }

        if(transform.position.y < -1)  
        {
            transform.Translate(Vector2.up * ((initialY - 1) / 10) * moveSpeed * Time.deltaTime);
        }
        
        
        //transform.rotation = Quaternion.AngleAxis(0.1, Vector3.forward);

    }
    void OnMouseDown() 
    {
        spawn();
        Debug.Log("mouse is down");
    }
}
