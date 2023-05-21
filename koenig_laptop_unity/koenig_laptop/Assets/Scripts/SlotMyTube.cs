using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;

public class SlotMyTube : MonoBehaviour, IDropHandler
{
    public int id;

    public GameLogic gameLogic;
    
    public GameObject[] answersMyTube;

    public GameObject slotOne;
    public GameObject slotTwo;
    public GameObject slotThree;
    public GameObject slotFour;
    public GameObject slotFive;

    private void Start()
    {
        answersMyTube = GameObject.FindGameObjectsWithTag("AnswerMyTube");
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("ItemDrop");
        
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragAndDropFour>().id == id)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                
                eventData.pointerDrag.GetComponent<DragAndDropFour>().isLocked = true;

                gameLogic.myTubeCorrectAnswers++;
                
                StartCoroutine(Fade());
                
                Debug.Log("CORRECT");
            }
            else
            {
                //eventData.pointerDrag.GetComponent<DragAndDropFour>().ResetPosition();
                Debug.Log("FALSE");
            }
        }
    }

    IEnumerator Fade()
    {
        if (id == 1)
        {
            slotOne.GetComponent<RectTransform>().DOScale(200f, 1.2f);
            slotOne.GetComponent<Image>().DOFade(0f, 1.2f);
            yield return new WaitForSeconds(1.2f);
            slotOne.SetActive(false);
        }
        if (id == 2)
        {
            slotTwo.GetComponent<RectTransform>().DOScale(200f, 1.2f);
            slotTwo.GetComponent<Image>().DOFade(0f, 1.2f);
            yield return new WaitForSeconds(1.2f);
            slotTwo.SetActive(false);
        }
        if (id == 3)
        {
            slotThree.GetComponent<RectTransform>().DOScale(200f, 1.2f);
            slotThree.GetComponent<Image>().DOFade(0f, 1.2f);
            yield return new WaitForSeconds(1.2f);
            slotThree.SetActive(false);
        }
        if (id == 4)
        {
            slotFour.GetComponent<RectTransform>().DOScale(200f, 1.2f);
            slotFour.GetComponent<Image>().DOFade(0f, 1.2f);
            yield return new WaitForSeconds(1.2f);
            slotFour.SetActive(false);
        }
        if (id == 5)
        {
            slotFive.GetComponent<RectTransform>().DOScale(200f, 1.2f);
            slotFive.GetComponent<Image>().DOFade(0f, 1.2f);
            yield return new WaitForSeconds(1.2f);
            slotFive.SetActive(false);
        }
    }

    public void Update()
    {
        if (gameLogic.myTubeCorrectAnswers == 5)
        {
            gameLogic.ubongoCorrect = true;
        }
    }
}