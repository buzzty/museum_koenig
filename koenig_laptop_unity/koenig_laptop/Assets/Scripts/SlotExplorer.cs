using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using Object = UnityEngine.Object;

public class SlotExplorer : MonoBehaviour, IDropHandler
{
    public int id;

    public GameLogic gameLogic;

    public GameObject[] answersExplorer;

    private void Start()
    {
        answersExplorer = GameObject.FindGameObjectsWithTag("AnswerExplorer");
    }

    public void OnDrop(PointerEventData eventDataThree)
    {
        Debug.Log("ItemDrop");
        
        if (eventDataThree.pointerDrag != null)
        {
            eventDataThree.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            
            gameLogic.quizExplorerAnswersGiven ++;

            if (eventDataThree.pointerDrag.GetComponent<DragAndDropThree>().id == id)
            {
                gameLogic.quizExplorerCorrectAnswers ++;
                Debug.Log("CORRECT");
            }
            else
            {
                Debug.Log("FALSE");
            }
        }

        if (gameLogic.quizExplorerAnswersGiven == 4)
        {
            if (gameLogic.quizExplorerCorrectAnswers == 4)
            {
                gameLogic.explorerAccess = true;
                gameLogic.quizExplorerCorrect = true;
                gameLogic.explorerAccessPage.SetActive(false);
                gameLogic.explorerFrontpage.SetActive(true);
            }
            else
            {
                foreach (var i in answersExplorer)
                {
                    i.GetComponent<DragAndDropThree>().ResetPosition();
                }
                
                gameLogic.quizExplorerCorrectAnswers = 0;
                gameLogic.quizExplorerAnswersGiven = 0;
                Debug.Log("Not all correct!");
            }
        }
    }
}
    
