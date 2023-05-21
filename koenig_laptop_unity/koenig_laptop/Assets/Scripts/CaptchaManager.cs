using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class CaptchaManager : MonoBehaviour
{
    public List<Captchas> captchasList;
    public GameObject[] options;
    public int currentQuestion;

    public TMP_Text QuestionText;

    private void Start()
    {
        GenerateQuestion();
    }

    public void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = captchasList[currentQuestion].Answers[i];

            if (captchasList[currentQuestion].FirstCorrectAnswer == i+1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
            
            if (captchasList[currentQuestion].SecondCorrectAnswer == i+1)
            {
                options[i].GetComponent<Answers>().isCorrect = true;
            }
        }
    }
    public void GenerateQuestion()
    {
        if (captchasList.Count > 0)
        {
            currentQuestion = Random.Range(0,captchasList.Count);

            QuestionText.text = captchasList[currentQuestion].Question;
        
            SetAnswer();
        }
        else
        {
            Debug.Log("Out of questions");
        }
    }

    public void Correct()
    {
        captchasList.RemoveAt(currentQuestion);
        GenerateQuestion();
    }

}
