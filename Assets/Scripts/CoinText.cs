using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinCount;
    
    // Start is called before the first frame update
    void Start()
    {
        coinCount.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
