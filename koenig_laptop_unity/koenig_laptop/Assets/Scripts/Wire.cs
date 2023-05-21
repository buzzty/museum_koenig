using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wire : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public LineRenderer lr;

    public Transform[] pointsA;
    public Transform[] pointsB;
    public Transform[] pointsC;
    public Transform[] pointsD;

    public Canvas canvas;

    public bool isDragStarted = false;

    private void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        if (isDragStarted)
        {
            Vector2 movePos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform,
                Input.mousePosition, canvas.worldCamera, out movePos);
            
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, canvas.transform.TransformPoint(movePos));
        }
        else
        {
            lr.SetPosition(0, Vector3.zero);
            lr.SetPosition(1, Vector3.zero);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDragStarted = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDragStarted = false;
    }

    public void SetUpLineA(Transform[] pointsA)
    {
        lr.positionCount = this.pointsA.Length;
        this.pointsA = pointsA;
    }
}
