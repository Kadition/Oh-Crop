using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Coins";
    }

    public void RestartButton()
    {
        Coin.count = 0;
        
        Plot.isWatered = 0;
        Plot.plotSeed = 0;
        Plot.killPlant = 0;
        Plot1.isWatered = 0;
        Plot1.plotSeed = 0;
        Plot1.killPlant = 0;
        Plot2.isWatered = 0;
        Plot2.plotSeed = 0;
        Plot2.killPlant = 0;
        Plot3.isWatered = 0;
        Plot3.plotSeed = 0;
        Plot3.killPlant = 0;
        Plot4.isWatered = 0;
        Plot4.plotSeed = 0;
        Plot4.killPlant = 0;
        Plot5.isWatered = 0;
        Plot5.plotSeed = 0;
        Plot5.killPlant = 0;
        Plot6.isWatered = 0;
        Plot6.plotSeed = 0;
        Plot6.killPlant = 0;
        Plot7.isWatered = 0;
        Plot7.plotSeed = 0;
        Plot7.killPlant = 0;
        Plot8.isWatered = 0;
        Plot8.plotSeed = 0;
        Plot8.killPlant = 0;
        Plot9.isWatered = 0;
        Plot9.plotSeed = 0;
        Plot9.killPlant = 0;
        Plot10.isWatered = 0;
        Plot10.plotSeed = 0;
        Plot10.killPlant = 0;
        Plot11.isWatered = 0;
        Plot11.plotSeed = 0;
        Plot11.killPlant = 0;
        Plot12.isWatered = 0;
        Plot12.plotSeed = 0;
        Plot12.killPlant = 0;
        Plot13.isWatered = 0;
        Plot13.plotSeed = 0;
        Plot13.killPlant = 0;
        Plot14.isWatered = 0;
        Plot14.plotSeed = 0;
        Plot14.killPlant = 0;
        Plot15.isWatered = 0;
        Plot15.plotSeed = 0;
        Plot15.killPlant = 0;
        Plot16.isWatered = 0;
        Plot16.plotSeed = 0;
        Plot16.killPlant = 0;
        Plot17.isWatered = 0;
        Plot17.plotSeed = 0;
        Plot17.killPlant = 0;
        Plot18.isWatered = 0;
        Plot18.plotSeed = 0;
        Plot18.killPlant = 0;
        Plot19.isWatered = 0;
        Plot19.plotSeed = 0;
        Plot19.killPlant = 0;
        Plot20.isWatered = 0;
        Plot20.plotSeed = 0;
        Plot20.killPlant = 0;
        Plot21.isWatered = 0;
        Plot21.plotSeed = 0;
        Plot21.killPlant = 0;
        Plot22.isWatered = 0;
        Plot22.plotSeed = 0;
        Plot22.killPlant = 0;
        Plot23.isWatered = 0;
        Plot23.plotSeed = 0;
        Plot23.killPlant = 0;
        
        SceneManager.LoadScene("MainScene");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
