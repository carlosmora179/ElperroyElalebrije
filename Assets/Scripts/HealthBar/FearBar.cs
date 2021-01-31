using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearBar : MonoBehaviour
{
    public Slider slider;


    public void SetMaxFear(int fear){
        slider.maxValue = fear;
        slider.value = 0;

    }
    public void SetFear(int fear){
        slider.value += fear;
    }
}
