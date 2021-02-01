using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using TMPro;

public class SliderTextManager : MonoBehaviour
{
    public int defaultValue;
    public int maxValue;

    public TMP_Text sliderText;
    
    private void Start()
    {
        GetComponent<Slider>().value = defaultValue;
        GetComponent<Slider>().maxValue = maxValue;
        
        sliderText.text = defaultValue + " / " +
                                    maxValue + " Arrival";
    }
}
