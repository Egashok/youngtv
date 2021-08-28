using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public GameObject pauseBG;
    public GameObject loswindow;
    private void Start()
    {
        pauseBG.SetActive(false);
        loswindow.SetActive(false);
    }
    void OnMouseUp()
    {
        switch (gameObject.name)
        {
            case "Pause":
                
                Time.timeScale = 0;
                pauseBG.SetActive(true);
                
                break;
            case "play":
      
                pauseBG.SetActive(false);
                Time.timeScale = 1f;
                break;
            case "Home":
                pauseBG.SetActive(false);
                SceneManager.LoadScene("menu");
                break;
            case "Exit":
                Application.Quit();
                break;
            case "repl":
                loswindow.SetActive(false);
                
                score.lose = false;
                Time.timeScale = 1f;
                SceneManager.LoadScene("main");
                break;
            case "Sound":
                break;
        }
    }
}
