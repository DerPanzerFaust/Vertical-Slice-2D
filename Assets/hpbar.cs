using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpbar : MonoBehaviour
{



    public Slider slider;
    public Slider slider2;

    public void Setmaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }
    
    
}
