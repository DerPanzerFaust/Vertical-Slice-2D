using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hpbar : MonoBehaviour
{



    public Slider slider;
    public Slider slider2;

    public void Setmaxhealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
        
    }
    public void SetHealth(float health)
    {
        slider.value = health;
       
    }
    public void SetMaxpsnHP(float health)
    {
        slider2.maxValue = health;
        slider2.value = health;
    }
    public void SetpsnHealth(float health)
    {
        
        slider2.value = health;
    }
}
