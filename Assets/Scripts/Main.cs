using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public void PlayGame(){
      SceneManager.LoadScene("Game");
    }
    public void Settings(){
      SceneManager.LoadScene("Settings");
    }
    public void QuitGame() {
        Debug.Log("Oyundan Çýktýk");
        Application.Quit();
    }
    public void BacktoGui()
    {
        SceneManager.LoadScene("Gui");
    }
}
