using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    public static int plot1Seed = 0;
    // Start is called before the first frame update
    public static Vector2 mousePos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(plot1Seed == 1)
        {

        }
        else if(plot1Seed == 2)
        {

        }
        else if(plot1Seed == 3)
        {

        }
    }

    void OnMouseOver()
    {
        if((Seed1.seedTimer > 0) && (Seed1.seedDown == 1))
        {
            plot1Seed = Seed1.seedType;
            Debug.Log(plot1Seed);
            Seed1.seedDown = 0;
        }
    }
}
