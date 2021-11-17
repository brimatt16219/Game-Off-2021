using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
    }

    public void ChangeHealth(int health)
    {
        slider.value += health;
    }

    public void ChangeMaxHealth(int health)
    {
        slider.maxValue += health;
    }

    
    
}
