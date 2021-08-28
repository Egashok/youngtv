using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    static public bool lose;
    static public int sore;
    public Text escor;
    public GameObject loswindow;
    private void Start()
    {
        sore = 0;
    }
    void Update()
    {
        if (lose)
        {
            loswindow.SetActive(true);
            Time.timeScale = 0;

        }
        
        escor.text = sore.ToString();
        if (sore >= PlayerPrefs.GetInt("high"))
        {
            PlayerPrefs.SetInt("hs", sore); 
        }
    }
}
