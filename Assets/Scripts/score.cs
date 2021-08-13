using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    static public bool lose;
    static public int sore;
    public Text escor;
    void Update()
    {
        if (lose)
        {
            Time.timeScale = 0;
        }
        escor.text = sore.ToString();
    }
}
