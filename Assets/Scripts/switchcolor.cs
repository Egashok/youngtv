using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class switchcolor : MonoBehaviour
{
    public Text txt;

    public Color blue = new Color(0, 0.04705882f, 1, 1);
    public Color red = new Color(1, 0, 0, 1);
    public Color yellow = new Color(1, 0.9882353f, 0, 1);
    public Color white = new Color(1, 0.635294f, 0, 1);
    public Color black = new Color(0, 0, 0, 1);
    public Color green = new Color(0.3372549f, 0.8117647f, 0.1294118f, 1);
    public Color[] allcolor;
    public string[] names;
    public string nowcol_name;



    void Start()
    {
        plusbut.sweet = false;
        string[] names = { "blue", "red", "yellow", "black", "white", "green" };
        Color[] allcolor = { blue, red, yellow, white, black, green };
        txt.GetComponent<Text>().color = allcolor[Random.Range(0, allcolor.Length)];
        txt.text = names[Random.Range(0, names.Length)];
  
    }

    void Update()
    {

        if (plusbut.sweet)
        {

            Color[] allcolor = { blue, red, yellow, white, black, green };
            txt.GetComponent<Text>().color = allcolor[Random.Range(0, allcolor.Length)];
            if (txt.GetComponent<Text>().color == red)
            {
                nowcol_name = "red";
            }
            if (txt.GetComponent<Text>().color == blue)
            {
                nowcol_name= "blue";
            }
            if (txt.GetComponent<Text>().color == white)
            {
                nowcol_name = "white";
            }
            if (txt.GetComponent<Text>().color == yellow)
            {
                nowcol_name = "yellow";
            }
            if (txt.GetComponent<Text>().color == green)
            {
                nowcol_name = "green";
            }
            if (txt.GetComponent<Text>().color == black)
            {
                nowcol_name = "black";
            }
            
            string[] names = { "blue", nowcol_name, "red", "yellow", nowcol_name, "black", "white", "green", nowcol_name, nowcol_name };
            txt.text = names[Random.Range(0, names.Length)];

            plusbut.sweet = false;
        }
        //blue

        if (txt.text == "blue" && txt.GetComponent<Text>().color == blue)
        {
            gameObject.tag = "tr";
        }
        if (txt.text == "blue" && txt.GetComponent<Text>().color != blue)
        {
            gameObject.tag = "fl";
        }

        //red
        if (txt.text == "red" && txt.GetComponent<Text>().color == red)
        {
            gameObject.tag = "tr";
        }
        if (txt.text == "red" && txt.GetComponent<Text>().color != red)
        {
            gameObject.tag = "fl";
        }
        //yellow
        if (txt.text == "yellow" && txt.GetComponent<Text>().color == yellow)
        {
            gameObject.tag = "tr";
        }
        if (txt.text == "yellow" && txt.GetComponent<Text>().color != yellow)
        {
            gameObject.tag = "fl";
        }
        //orange
        if (txt.text == "white" && txt.GetComponent<Text>().color == white)
        {
            gameObject.tag = "tr";
        }
        if (txt.text == "white" && txt.GetComponent<Text>().color != white)
        {
            gameObject.tag = "fl";
        }
        //green
        if (txt.text == "green" && txt.GetComponent<Text>().color == green)
        {
            gameObject.tag = "tr";
        }
        if (txt.text == "green" && txt.GetComponent<Text>().color != green)
        {
            gameObject.tag = "fl";
        }
        //pink
        if (txt.text == "black" && txt.GetComponent<Text>().color == black)
        {
            gameObject.tag = "tr";
        }
        if (txt.text == "black" && txt.GetComponent<Text>().color != black)
        {
            gameObject.tag = "fl";
        }

    }
}
