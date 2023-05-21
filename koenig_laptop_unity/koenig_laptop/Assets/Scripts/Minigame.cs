using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Minigame : MonoBehaviour
{
    public int id;
    
    public int answersCorrect;
    
    public int answersGiven;

    public bool canDrag = true;

    public GameLogic gameLogic;

    private void Update()
    {
        if (answersCorrect == 9)
        {
            StartCoroutine(AllAnswersCorrect());
        }
    }

    IEnumerator AllAnswersCorrect()
    {
        answersCorrect++;
        canDrag = false;
        yield return new WaitForSeconds(1.8f);
        gameLogic.myTubeAccess = true;
        gameLogic.myTubeAccessPage.SetActive(false);
        gameLogic.myTubeVidOne.SetActive(true);
    }
}
