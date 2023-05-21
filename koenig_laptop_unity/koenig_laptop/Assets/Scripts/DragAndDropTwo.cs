using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropTwo : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTrans;
    private CanvasGroup canvasGroup;
    public Canvas canvas;
    public int id;
    public Vector2 intiPosition;
    
    public bool isLocked;

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
        Debug.Log("Begin Drag");
        canvasGroup.blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isLocked)
        {
            return;
        }
        //Debug.Log("OnDrag");
        rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void ResetPosition()
    {
        transform.position = intiPosition;
    }
}