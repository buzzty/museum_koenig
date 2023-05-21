using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColor : MonoBehaviour
{
    public void ChangeColor()
    {
        GetComponent<Image>().color = Color.yellow;
    }
}
