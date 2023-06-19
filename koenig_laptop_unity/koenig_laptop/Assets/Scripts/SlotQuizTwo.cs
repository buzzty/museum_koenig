using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotQuizTwo : MonoBehaviour, IDropHandler
{
    public int id;

    public GameLogic gameLogic;

    public GameObject[] answersTwo;

    private void Start()
    {
        answersTwo = GameObject.FindGameObjectsWithTag("AnswerTwo");
    }

    public void OnDrop(PointerEventData eventDataTwo)
    {
        Debug.Log("ItemDrop");
        
        if (eventDataTwo.pointerDrag != null && eventDataTwo.pointerDrag.GetComponent<DragAndDropTwo>().id == id)
        {
            gameLogic.quizThreeCorrectAnswers++;

            eventDataTwo.pointerDrag.GetComponent<RectTransform>().DOScale(1.2f, 0.5f);

            eventDataTwo.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            
            //eventDataTwo.pointerDrag.GetComponent<DragAndDropTwo>().isLocked = true;
            eventDataTwo.pointerDrag.GetComponent<DragAndDropTwo>().enabled = false;
            
            gameLogic.quizThreeAnswersGiven++;
        }

        if (eventDataTwo.pointerDrag != null && eventDataTwo.pointerDrag.GetComponent<DragAndDropTwo>().id != id)
        {
            eventDataTwo.pointerDrag.GetComponent<DragAndDropTwo>().ResetPosition();
        }

        if (gameLogic.quizThreeCorrectAnswers == 4)
        {
            StartCoroutine(QuizThreeAccessGranted());
        }
        
        IEnumerator QuizThreeAccessGranted()
        {
            yield return new WaitForSeconds(1.8f);
            gameLogic.quizThreeCorrect = true;
            gameLogic.quizTaskThree.SetActive(false);
            gameLogic.quizThreeAnswer.SetActive(true);
        }
    }
}
    
