using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Plant : MonoBehaviour
{
    
    public Sprite noPlant, c1, c2, c3, c4, c5, cd, t1, t2, t3, t4, t5, td, a1, a2, a3, a4, a5, ad;
    public static int isThere = 0;
    public static int isReady = 0;
    public static int plantSeed = 0;
    private static System.Random random;
    private static DateTime stime;
    private static DateTime etime;
    private static TimeSpan timeD;
    private static int timeToGrowth;
    // Start is called before the first frame update
    void Start()
    {
        //System.Random rnd = new System.Random();
        //int month  = rnd.Next(1, 13);  // creates a number between 1 and 12
        //int dice   = rnd.Next(1, 7);   // creates a number between 1 and 6
        //int card   = rnd.Next(52);     // creates a number between 0 and 51
    }

    // Update is called once per frame
    void Update()
    {
        if(Plot.killPlant == 1)
        {
            isReady = 0;
            isThere = 0;
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
        else if(plantSeed == 1)
        {
            plantSeed = 0;
            random = new System.Random();
            if(Plot.plotSeed == 1)
            {
                GetComponent<SpriteRenderer>().sprite = c1;
            }
            else if(Plot.plotSeed == 2)
            {
                GetComponent<SpriteRenderer>().sprite = t1;
            }
            else if(Plot.plotSeed == 3)
            {
                GetComponent<SpriteRenderer>().sprite = a1;
            }
            else
            {
                Debug.Log("Plant Error");
            }
            stime = DateTime.Now;
            timeToGrowth = random.Next(5, 11);
        }
        else if(GetComponent<SpriteRenderer>().sprite != noPlant)
        {
            etime = DateTime.Now;
            timeD = etime.TimeOfDay - stime.TimeOfDay;

            if(timeD.Seconds > timeToGrowth)
            {
                stime = etime;
                timeToGrowth = random.Next(5, 11);
                if(GetComponent<SpriteRenderer>().sprite == c1)
                {
                    GetComponent<SpriteRenderer>().sprite = c2;
                }
                else if(GetComponent<SpriteRenderer>().sprite == c2)
                {
                    GetComponent<SpriteRenderer>().sprite = c3;
                }
                else if(GetComponent<SpriteRenderer>().sprite == c3)
                {
                    GetComponent<SpriteRenderer>().sprite = c4;
                }
                else if(GetComponent<SpriteRenderer>().sprite == c4)
                {
                    GetComponent<SpriteRenderer>().sprite = c5;
                    isReady = 1;
                }
                else if(GetComponent<SpriteRenderer>().sprite == c5)
                {
                    GetComponent<SpriteRenderer>().sprite = cd;
                    isReady = 0;
                }
                else if(GetComponent<SpriteRenderer>().sprite == cd)
                {
                    GetComponent<SpriteRenderer>().sprite = noPlant;
                    isThere = 0;
                }
                if(GetComponent<SpriteRenderer>().sprite == t1)
                {
                    GetComponent<SpriteRenderer>().sprite = t2;
                }
                else if(GetComponent<SpriteRenderer>().sprite == t2)
                {
                    GetComponent<SpriteRenderer>().sprite = t3;
                }
                else if(GetComponent<SpriteRenderer>().sprite == t3)
                {
                    GetComponent<SpriteRenderer>().sprite = t4;
                }
                else if(GetComponent<SpriteRenderer>().sprite == t4)
                {
                    GetComponent<SpriteRenderer>().sprite = t5;
                    isReady = 1;
                }
                else if(GetComponent<SpriteRenderer>().sprite == t5)
                {
                    GetComponent<SpriteRenderer>().sprite = td;
                    isReady = 0;
                }
                else if(GetComponent<SpriteRenderer>().sprite == td)
                {
                    GetComponent<SpriteRenderer>().sprite = noPlant;
                    isThere = 0;
                }
                if(GetComponent<SpriteRenderer>().sprite == a1)
                {
                    GetComponent<SpriteRenderer>().sprite = a2;
                }
                else if(GetComponent<SpriteRenderer>().sprite == a2)
                {
                    GetComponent<SpriteRenderer>().sprite = a3;
                }
                else if(GetComponent<SpriteRenderer>().sprite == a3)
                {
                    GetComponent<SpriteRenderer>().sprite = a4;
                }
                else if(GetComponent<SpriteRenderer>().sprite == a4)
                {
                    GetComponent<SpriteRenderer>().sprite = a5;
                    isReady = 1;
                }
                else if(GetComponent<SpriteRenderer>().sprite == a5)
                {
                    GetComponent<SpriteRenderer>().sprite = ad;
                    isReady = 0;
                }
                else if(GetComponent<SpriteRenderer>().sprite == ad)
                {
                    GetComponent<SpriteRenderer>().sprite = noPlant;
                    isThere = 0;
                }
            }
        }
    }
}
