using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DailyTaskSliderText : MonoBehaviour
{
   public int sliderDefaultValue;
   public int sliderMaxValue;

   public TMP_Text sliderText;
   
   private void Start()
   {
      GetComponent<Slider>().value = sliderDefaultValue;
      GetComponent<Slider>().maxValue = sliderMaxValue;

      sliderText.text = sliderDefaultValue + "/" + sliderMaxValue;
   }
}