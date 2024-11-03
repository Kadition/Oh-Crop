using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using System;

public class Plot7 : MonoBehaviour
{
    public static int plotSeed;
    // Start is called before the first frame update
    public static Vector2 mousePos;
    public Sprite noWater, Water; 
    public static int killPlant;
    public static int isWatered;
    void Start()
    {
        isWatered = 0;
        plotSeed = 0;
        killPlant = 0;
        GetComponent<SpriteRenderer>().sprite = noWater;
    }

    // Update is called once per frame
    void Update()
    {
        if((Plant7.isDead == 1) && (Plant7.isThere == 0))
        {
            GetComponent<SpriteRenderer>().sprite = noWater;
            Plant7.isDead = 0;
            isWatered = 0;
        }
    }

    void OnMouseOver()
    {
        if((Seed1.seedTimer > 0) && (Seed1.seedDown == 1) && (Plant7.isThere == 0))
        {
            if(Seed1.seedType == 1)
            {
                plotSeed = Seed1.seedType;
                Plant7.plantSeed = 1;
            }
            else if ((Seed1.seedType == 2) && (Coin.count > 2))
            {
                plotSeed = Seed1.seedType;
                Coin.count -= 3;
                Plant7.plantSeed = 1;
            }
            else if ((Seed1.seedType == 3) && (Coin.count > 9))
            {
                plotSeed = Seed1.seedType;
                Coin.count -= 10;
                Plant7.plantSeed = 1;
            }
            Seed1.seedDown = 0;
        }
        else if((WaterIcon.waterTimer > 0) && (WaterIcon.waterDown == 1) && (isWatered == 0))
        {
            isWatered = 1;
            GetComponent<SpriteRenderer>().sprite = Water;
            WaterIcon.waterDown = 0;
        }
    }

    void OnMouseDown()
    {
        if((Plant7.isThere == 1) && (Plant7.isReady == 1))
        {
            killPlant = 1;
            isWatered = 0;
            GetComponent<SpriteRenderer>().sprite = noWater;
            if(plotSeed == 1)
            {
                Coin.count += 1; //cost 0
            }
            else if(plotSeed == 2)
            {
                Coin.count += 5; //cost 3
            }
            else if(plotSeed == 3)
            {
                Coin.count += 20; //cost 10
            }
        }
    }
}
