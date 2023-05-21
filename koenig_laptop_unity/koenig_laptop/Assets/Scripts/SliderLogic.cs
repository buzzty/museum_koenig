using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderLogic : MonoBehaviour
{
    public TMP_Text winMsg;
    
    public Slider sliderOne;
    public Slider sliderTwo;
    public Slider sliderThree;
    public Slider sliderFour;

    private void Update()
    {
        if (sliderOne.value >= 94 && sliderOne.value <= 98 && sliderTwo.value >= 66 && sliderTwo.value <= 70 && sliderThree.value >= 17 && sliderThree.value <= 21 && sliderFour.value >= 49 && sliderFour.value <= 51)
        {
            sliderOne.interactable = false;
            sliderTwo.interactable = false;
            sliderThree.interactable = false;
            sliderFour.interactable = false;
            
            winMsg.gameObject.SetActive(true);
        }
    }
}
