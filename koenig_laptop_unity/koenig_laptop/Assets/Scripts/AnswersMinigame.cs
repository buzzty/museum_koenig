using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswersMinigame : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public int id;

    private RectTransform rectTrans;
    private CanvasGroup canvasGroup;
    public Canvas canvas;
    public Vector3 intiPosition;
    
    public bool isLocked = false;

    public Minigame minigame;

    private void Awake()
    {
        intiPosition = transform.position;
    }

    private void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (minigame.canDrag)
        {
            Debug.Log("Begin Drag");
            canvasGroup.blocksRaycasts = false;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (minigame.canDrag)
        {
            Debug.Log("End Drag");
            canvasGroup.blocksRaycasts = true;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (minigame.canDrag)
        {
            if (isLocked)
            {
                return;
            }
            //Debug.Log("OnDrag");
            rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
    }

    public void ResetPosition()
    {
        if (minigame.canDrag)
        {
            transform.position = intiPosition;
        }
    }
}
