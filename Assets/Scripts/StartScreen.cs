using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class StartScreen : MonoBehaviour
{
    public static bool hasStarted = false;
    public void PlayGame()
    {
        hasStarted = true;
        SceneManager.LoadScene("MainScene");
        gameObject.SetActive(false);
    }
    void Start()
    {
        if(hasStarted)
        {
            gameObject.SetActive(false);
        }
    }
}
