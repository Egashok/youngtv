using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minusbut : MonoBehaviour
{

    public GameObject pl;
   static public int kolvo;
    void OnMouseDown()
    {
        if (pl.gameObject.tag == "fl")
        {
            score.sore += 1;
            kolvo += 1;

            if (time.times > 5)
            {
                time.times += 0.5f;
            }
            else
            {
                time.times += 1f;
            }
        }
        if (pl.gameObject.tag=="tr")
        {
            score.lose = true;
        }
        plusbut.sweet = true;
    }
}