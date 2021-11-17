using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarCount : MonoBehaviour
{
    
    public Text text;

    public Slider slider;

    void FixedUpdate()
    {
        text.text = slider.value.ToString();
    }

}
