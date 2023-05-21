using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Line : MonoBehaviour
{
    public LineRenderer lineOne;
    public LineRenderer lineTwo;
    public LineRenderer lineThree;
    public LineRenderer lineFour;
    
    public RectTransform startPosOne;
    public RectTransform endPosOne;
    public RectTransform startPosTwo;
    public RectTransform endPosTwo;
    public RectTransform startPosThree;
    public RectTransform endPosThree;
    public RectTransform startPosFour;
    public RectTransform endPosFour;
    

    private void Update()
    {
        lineOne.SetPosition(0, startPosOne.position);
        lineOne.SetPosition(1, endPosOne.position);
        
        lineTwo.SetPosition(0, startPosTwo.position);
        lineTwo.SetPosition(1, endPosTwo.position);
        
        lineThree.SetPosition(0, startPosThree.position);
        lineThree.SetPosition(1, endPosThree.position);
        
        lineFour.SetPosition(0, startPosFour.position);
        lineFour.SetPosition(1, endPosFour.position);
    }
}
