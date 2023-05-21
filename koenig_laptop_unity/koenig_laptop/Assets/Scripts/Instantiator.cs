using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject cardPrefabThree;
    public GameObject cardPrefabFour;
    public GameObject cardPrefabFive;
    public GameObject cardPrefabSix;
    public GameObject cardPrefabSeven;
    public GameObject cardPrefabEight;
    
    public int initCardsCount;

    public void InstatiateCard()
    {
        if (initCardsCount == 0)
        {
            initCardsCount++;
            GameObject newCard = Instantiate(cardPrefabThree, transform, false);
            newCard.transform.SetAsFirstSibling();
            newCard.transform.localScale = new Vector3(3.9f, 3.9f, 3.9f);
        }
        else if (initCardsCount == 1)
        {
            initCardsCount++;
            GameObject newCard = Instantiate(cardPrefabFour, transform, false);
            newCard.transform.SetAsFirstSibling();
            newCard.transform.localScale = new Vector3(3.7f, 3.7f, 3.7f);
        }
        else if (initCardsCount == 2)
        {
            initCardsCount++;
            GameObject newCard = Instantiate(cardPrefabFive, transform, false);
            newCard.transform.SetAsFirstSibling();
            newCard.transform.localScale = new Vector3(3.9f, 3.9f, 3.9f);
        }
        else if (initCardsCount == 3)
        {
            initCardsCount++;
            GameObject newCard = Instantiate(cardPrefabSix, transform, false);
            newCard.transform.SetAsFirstSibling();
            newCard.transform.localScale = new Vector3(3.9f, 3.9f, 3.9f);
        }
        else if (initCardsCount == 4)
        {
            initCardsCount++;
            GameObject newCard = Instantiate(cardPrefabSeven, transform, false);
            newCard.transform.SetAsFirstSibling();
            newCard.transform.localScale = new Vector3(3.9f, 3.9f, 3.9f);
        }
        else if (initCardsCount == 5)
        {
            initCardsCount++;
            GameObject newCard = Instantiate(cardPrefabEight, transform, false);
            newCard.transform.SetAsFirstSibling();
            newCard.transform.localScale = new Vector3(3.9f, 3.9f, 3.9f);
        }

    }

    private void Update()
    {
        if (transform.childCount < 2)
        {
            InstatiateCard();
        }
    }
}
