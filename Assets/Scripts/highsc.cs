using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highsc : MonoBehaviour { 
    // Start is called before the first frame update
    public int score;
    public Text sc;

    void Start()
    {

        score = PlayerPrefs.GetInt("high");
        sc.text = score.ToString();

    }

}
