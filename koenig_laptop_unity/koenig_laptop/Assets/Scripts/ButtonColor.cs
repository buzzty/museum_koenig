using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public bool isPressed;

    public bool answerCorrect;

    public GameLogic gl;

    public void ChangeColor()
    {
        if (!isPressed && answerCorrect)
        {
            isPressed = true;
            gl.rightCaptchaAnswers++;
            GetComponent<Image>().color = Color.yellow;
        }
        else if (!isPressed && !answerCorrect)
        {
            isPressed = true;
            gl.wrongCaptchaAnswers++;
            GetComponent<Image>().color = Color.yellow;
        }
        else if (isPressed && answerCorrect)
        {
            isPressed = false;
            gl.rightCaptchaAnswers--;
            GetComponent<Image>().color = Color.clear;
        }
        else if (isPressed && !answerCorrect)
        {
            isPressed = false;
            gl.wrongCaptchaAnswers--;
            GetComponent<Image>().color = Color.clear;
        }
    }
}
