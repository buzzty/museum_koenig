using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotQuizOne : MonoBehaviour, IDropHandler
{
    public int id;

    public GameLogic gameLogic;
    
    public GameObject[] answersOne;

    public GameObject[] quizOneSlots;

    private void Start()
    {
        answersOne = GameObject.FindGameObjectsWithTag("AnswerOne");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ItemDrop");
        
        if (eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<DragAndDropOne>().id == id)
        {
            gameLogic.quizOneCorrectAnswers++;
            
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;

            //eventData.pointerDrag.GetComponent<DragAndDropOne>().isLocked = true;
            eventData.pointerDrag.GetComponent<DragAndDropOne>().enabled = false;

            gameLogic.quizOneAnswersGiven++;
        }

        if (eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<DragAndDropOne>().id != id)
        {
            eventData.pointerDrag.GetComponent<DragAndDropOne>().ResetPosition();
        }
        
        if (gameLogic.quizOneCorrectAnswers == 8)
        {
            StartCoroutine(QuizOneFinished());
        }
    }

    IEnumerator QuizOneFinished()
    {
        foreach (var i in quizOneSlots)
        {
            i.GetComponent<RectTransform>().DOScale(1.5f, 1.2f);
            i.GetComponent<Image>().DOFade(0f, 1.2f);
        }

        yield return new WaitForSeconds(1.8f);
        
        gameLogic.quizOneCorrect = true;
        gameLogic.quizTaskOne.SetActive(false);
        gameLogic.quizOneAnswer.SetActive(true);
    }
}
    
