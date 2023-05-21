using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answers : MonoBehaviour
{
    public bool isCorrect = false;
    public CaptchaManager manager;
    public Color startColor;
    
    public void Answer()
    {
        if (isCorrect)
        {
            GetComponent<Image>().color = Color.green;
            Debug.Log("CORRECT");
            manager.Correct();
        }
        else
        {
            GetComponent<Image>().color = Color.red;
            Debug.Log("WRONG");
            manager.Correct();
        }
    }
}
