using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip waterDrop;
    public AudioClip seedPlantAudio;
    public AudioClip Coin;
    public AudioSource SFX;

    void Update()
    {
        if(WaterIcon.playWaterSound == 1)
        {
            WaterIcon.playWaterSound = 0;
            SFX.clip = waterDrop;
            SFX.Play();
        }
        if(Seed1.playSeedSound == 1)
        {
            Seed1.playSeedSound = 0;
            SFX.clip = seedPlantAudio;
            SFX.Play();
        }
        if(Plot.playCoinSound == 1)
        {
            Plot.playCoinSound = 0;
            SFX.clip = Coin;
            SFX.Play();
        }
    }

    public void WaterPlayer()
    {
        SFX.clip = waterDrop;
        SFX.Play();
    }
    public void seedPlant()
    {
        SFX.clip = seedPlantAudio;
        SFX.Play();
    }
    public void CoinAudio()
    {
        SFX.clip = Coin;
        SFX.Play();
    }
}
