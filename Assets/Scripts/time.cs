using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
   static public float times;
    public Text xt;

    private void Start()
    {
        times = 5f;
    }
    void Update()
    {
        if (times <= 0)
        {
            score.lose = true;
        }
        xt.text = times.ToString();
        times -= Time.deltaTime;
    }
}
