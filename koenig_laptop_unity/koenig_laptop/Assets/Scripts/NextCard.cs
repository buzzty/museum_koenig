using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NextCard : MonoBehaviour
{
    public TinderSwipeEffect _swipeEffect;
    public GameObject _firstCard;

    public RectTransform screen;

    private void Start()
    {
        screen = GameObject.Find("Cards").GetComponent<RectTransform>();

        _swipeEffect = FindObjectOfType<TinderSwipeEffect>();
        _firstCard = _swipeEffect.gameObject;
        _swipeEffect.cardMoved += CardMovedFront;
        
        transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
    }

    private void Update()
    {
        float distanceMoved = _firstCard.transform.localPosition.x;
        if (Mathf.Abs(distanceMoved)>0)
        {
            float step = Mathf.SmoothStep(0.8f, 1, Mathf.Abs(distanceMoved) / (screen.rect.width / 2));
            transform.localScale = new Vector3(step, step, step);
        }
    }

    public void CardMovedFront()
    {
        gameObject.AddComponent<TinderSwipeEffect>();
        Destroy(this);
    }
}
