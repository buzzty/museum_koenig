
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TinderSwipeEffect : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector3 _initialPosition;
    private float _distanceMoved;
    private bool _swipeRight;
    private bool _swipeLeft;

    public GameLogic gameLogic;

    public RectTransform screen;

    public event Action cardMoved;

    private void Start()
    {
        screen = GameObject.Find("Cards").GetComponent<RectTransform>();

        gameLogic = FindObjectOfType<GameLogic>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.localPosition = new Vector3(transform.localPosition.x + eventData.delta.x, transform.localPosition.y);

        if (transform.localPosition.x - _initialPosition.x > 0)
        {
            transform.localEulerAngles = new Vector3(0, 0,
                Mathf.LerpAngle(0, -30, _initialPosition.x + transform.localPosition.x / (screen.rect.width / 2)));
        }
        else
        {
            transform.localEulerAngles = new Vector3(0, 0,
                Mathf.LerpAngle(0, +30, _initialPosition.x - transform.localPosition.x / (screen.rect.width / 2)));
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _initialPosition = transform.localPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _distanceMoved = Mathf.Abs(transform.localPosition.x - _initialPosition.x);
        if (_distanceMoved<0.2 * screen.rect.width)
        {
            transform.localPosition = _initialPosition;
            transform.localEulerAngles = Vector3.zero;
        }
        else
        {
            if (transform.localPosition.x > _initialPosition.x)
            {
                _swipeLeft = false;
            }
            else
            {
                _swipeLeft = true;
            }
            
            gameLogic.cardsSwiped++;
            
            cardMoved?.Invoke();
            StartCoroutine(MoveCard());
        }
    }

    IEnumerator MoveCard()
    {
        float time = 0;
        while (GetComponent<Image>().color != new Color(1, 1, 1, 0))
        {
            time += Time.deltaTime;
            if (_swipeLeft)
            {
                transform.localPosition =
                    new Vector3(Mathf.SmoothStep(transform.localPosition.x, transform.localPosition.x - screen.rect.width, 4 * time),
                        transform.localPosition.y, 0);
            }
            else
            {
                transform.localPosition =
                    new Vector3(Mathf.SmoothStep(transform.localPosition.x, transform.localPosition.x + screen.rect.width, 4 * time),
                        transform.localPosition.y, 0);
            }

            GetComponent<Image>().color = new Color(1, 1, 1, Mathf.SmoothStep(1, 0, 4 * time));
            yield return null;
        }
        Destroy(gameObject);
    }

    IEnumerator AllCardsSwiped()
    {
        yield return new WaitForSeconds(0.6f);
        gameLogic.tinderAnswerScreen.SetActive(true);
    }
}
