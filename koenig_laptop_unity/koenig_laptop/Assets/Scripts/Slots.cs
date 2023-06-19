using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Slots : MonoBehaviour, IDropHandler
{
    public int id;

    public Minigame minigame;

    public GameObject[] minigameAnswers;

    public GameObject[] minigameSlots;

    private void Start()
    {
        minigameAnswers = GameObject.FindGameObjectsWithTag("MinigameAnswers");
        minigameSlots = GameObject.FindGameObjectsWithTag("MinigameSlots");
    }

    public void OnDrop(PointerEventData eventDataMinigame)
    {
        if (eventDataMinigame.pointerDrag != null && eventDataMinigame.pointerDrag.GetComponent<AnswersMinigame>().id == id)
        {
            minigame.answersCorrect++;

            eventDataMinigame.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            
            //eventDataMinigame.pointerDrag.GetComponent<AnswersMinigame>().isLocked = true;

            eventDataMinigame.pointerDrag.GetComponent<AnswersMinigame>().enabled = false;

            minigame.answersGiven++;
        }

        if (eventDataMinigame.pointerDrag != null && eventDataMinigame.pointerDrag.GetComponent<AnswersMinigame>().id != id)
        {
            eventDataMinigame.pointerDrag.GetComponent<AnswersMinigame>().ResetPosition();
        }

        if (minigame.answersCorrect == 9)
        {
            Debug.Log("WOOHOO YOU DID IT");

            foreach (var i in minigameSlots)
            {
                i.GetComponent<RectTransform>().DOScale(1.5f, 1.2f);
                i.GetComponent<Image>().DOFade(0f, 1.2f);
            }
        }
    }
}
