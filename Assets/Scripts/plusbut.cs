using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusbut : MonoBehaviour
{
    static public bool sweet=false;
    public GameObject pl;
  
 void OnMouseDown()
    {
        if (pl.gameObject.tag=="tr")
        {
            score.sore += 1;
            if (time.times > 5)
            {
                time.times += 0.2f;
            }
            else
            {
                time.times += 0.1f;
            }
        }
        if (pl.gameObject.tag == "fl")
        {
            score.lose = true;
        }
        sweet = true; 
    }
}
