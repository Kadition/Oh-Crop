using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Plot : MonoBehaviour
{
    public static int plotSeed = 0;
    // Start is called before the first frame update
    public static Vector2 mousePos;
    public Sprite noWater, Water; 
    public static int killPlant = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if((Seed1.seedTimer > 0) && (Seed1.seedDown == 1) && (Plant.isThere == 0))
        {
            if(Seed1.seedType == 1)
            {
                plotSeed = Seed1.seedType;
                Debug.Log(plotSeed);
            }
            else if ((Seed1.seedType == 2) && (Coin.count > 2))
            {
                plotSeed = Seed1.seedType;
                Debug.Log(plotSeed);
                Coin.count -= 3;
            }
            else if ((Seed1.seedType == 3) && (Coin.count > 9))
            {
                plotSeed = Seed1.seedType;
                Debug.Log(plotSeed);
                Coin.count -= 10;
            }
            Seed1.seedDown = 0;
        }
    }

    void OnMouseDown()
    {
        if((Plant.isThere == 1) && (Plant.isReady == 1))
        {
            killPlant = 1;
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
