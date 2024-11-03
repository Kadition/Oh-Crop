using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Plant22 : MonoBehaviour
{
    public Sprite noPlant, c1, c2, c3, c4, c5, cd, t1, t2, t3, t4, t5, td, a1, a2, a3, a4, a5, ad;
    public static int isThere;
    public static int isReady;
    public static int plantSeed;
    public static int isDead;
    private static System.Random random;
    private static DateTime stime;
    private static DateTime etime;
    private static TimeSpan timeD;
    private static int timeToGrowth;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = noPlant;
    }

    // Update is called once per frame
    void Update()
    {
        if(Plot22.killPlant == 1)
        {
            isReady = 0;
            isThere = 0;
            isDead = 0;
            plantSeed = 0;
            Plot22.killPlant = 0;
            GetComponent<SpriteRenderer>().sprite = noPlant;
        }
        else if(plantSeed == 1)
        {
            plantSeed = 0;
            isThere = 1;
            random = new System.Random();
            if(Plot22.plotSeed == 1)
            {
                GetComponent<SpriteRenderer>().sprite = c1;
            }
            else if(Plot22.plotSeed == 2)
            {
                GetComponent<SpriteRenderer>().sprite = t1;
            }
            else if(Plot22.plotSeed == 3)
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
                    timeToGrowth = random.Next(5, 11);
                }
                else if(GetComponent<SpriteRenderer>().sprite == c2)
                {
                    GetComponent<SpriteRenderer>().sprite = c3;
                    timeToGrowth = random.Next(5, 11);
                }
                else if(GetComponent<SpriteRenderer>().sprite == c3)
                {
                    GetComponent<SpriteRenderer>().sprite = c4;
                    timeToGrowth = random.Next(5, 11);
                }
                else if(GetComponent<SpriteRenderer>().sprite == c4)
                {
                    GetComponent<SpriteRenderer>().sprite = c5;
                    timeToGrowth = random.Next(10, 16);
                    isReady = 1;
                }
                else if(GetComponent<SpriteRenderer>().sprite == c5)
                {
                    GetComponent<SpriteRenderer>().sprite = cd;
                    timeToGrowth = random.Next(5, 11);
                    isDead = 1;
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
                    timeToGrowth = random.Next(3, 9);
                }
                else if(GetComponent<SpriteRenderer>().sprite == t2)
                {
                    GetComponent<SpriteRenderer>().sprite = t3;
                    timeToGrowth = random.Next(3, 9);
                }
                else if(GetComponent<SpriteRenderer>().sprite == t3)
                {
                    GetComponent<SpriteRenderer>().sprite = t4;
                    timeToGrowth = random.Next(3, 9);
                }
                else if(GetComponent<SpriteRenderer>().sprite == t4)
                {
                    GetComponent<SpriteRenderer>().sprite = t5;
                    timeToGrowth = random.Next(8, 13);
                    isReady = 1;
                }
                else if(GetComponent<SpriteRenderer>().sprite == t5)
                {
                    GetComponent<SpriteRenderer>().sprite = td;
                    timeToGrowth = random.Next(5, 11);
                    isDead = 1;
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
                    timeToGrowth = random.Next(7, 12);
                }
                else if(GetComponent<SpriteRenderer>().sprite == a2)
                {
                    GetComponent<SpriteRenderer>().sprite = a3;
                    timeToGrowth = random.Next(7, 12);
                }
                else if(GetComponent<SpriteRenderer>().sprite == a3)
                {
                    GetComponent<SpriteRenderer>().sprite = a4;
                    timeToGrowth = random.Next(7, 12);
                }
                else if(GetComponent<SpriteRenderer>().sprite == a4)
                {
                    GetComponent<SpriteRenderer>().sprite = a5;
                    timeToGrowth = random.Next(6, 10);
                    isReady = 1;
                }
                else if(GetComponent<SpriteRenderer>().sprite == a5)
                {
                    GetComponent<SpriteRenderer>().sprite = ad;
                    timeToGrowth = random.Next(7, 12);
                    isDead = 1;
                    isReady = 0;
                }
                else if(GetComponent<SpriteRenderer>().sprite == ad)
                {
                    GetComponent<SpriteRenderer>().sprite = noPlant;
                    isThere = 0;
                }
                
                if((Plot22.isWatered == 1) && (isReady == 0) && (isDead == 0))
                {
                    timeToGrowth = timeToGrowth / 2;
                }
            }
        }
    }
}
