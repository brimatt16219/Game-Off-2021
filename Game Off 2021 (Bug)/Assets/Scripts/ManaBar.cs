using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar: MonoBehaviour
{

    public Slider slider;

    public void SetHealth(int mana)
    {
        slider.value = mana;
    }

    public void SetMaxHealth(int mana)
    {
        slider.maxValue = mana;
    }

    public void ChangeHealth(int mana)
    {
        slider.value += mana;
    }

    public void ChangeMaxHealth(int mana)
    {
        slider.maxValue += mana;
    }

    
    
}
