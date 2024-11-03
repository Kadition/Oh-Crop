using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CoinText : MonoBehaviour
{
    public TMP_Text message;
    // Start is called before the first frame update
    void Start()
    {
        message.SetText("0");
    }

    // Update is called once per frame
    void Update()
    {
        message.SetText(Convert.ToString(Coin.count));
    }
}
