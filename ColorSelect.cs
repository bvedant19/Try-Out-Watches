using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorSelect : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void w1ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if(buttonName == "Black Button")
        {
            //change color to black.

            band1.color = new Color(0.0f, 0.0f, 0.0f);
        }
        else if(buttonName == "Blue Button")
        {
            //change color to blue.
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#103890", out myColor);
            band1.color = myColor;
        }
    }
    public void w2colorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black Button")
        {
            //change color to black.
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;
        }
        else if (buttonName == "RED Button")
        {
            //change color to blue.
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#740202", out myColor);
            band2.color = myColor;


        }
    }
    public void w3colorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Black Button")
        {
            //change color to black.
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#464646", out myColor);
            band3.color = myColor;
        }
        else if (buttonName == "WHITE Button")
        {
            //change color to blue.
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#A1A1A1", out myColor);
            band3.color = myColor;
        }
    }

}
