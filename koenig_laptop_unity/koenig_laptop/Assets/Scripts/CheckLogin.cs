using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckLogin : MonoBehaviour
{
    public TMP_InputField loginOne;
    public TMP_InputField loginTwo;
    public TMP_InputField loginThree;
    public TMP_InputField loginFour;

    public string loginOneInput;
    public string loginTwoInput;
    public string loginThreeInput;
    public string loginFourInput;

    private void Start()
    {
        loginOne.Select();
    }

    private void Update()
    {
        loginOneInput = loginOne.text;
        loginTwoInput = loginTwo.text;
        loginThreeInput = loginThree.text;
        loginFourInput = loginFour.text;
        
        if (!string.IsNullOrEmpty(loginOneInput) && string.IsNullOrEmpty(loginTwoInput) && string.IsNullOrEmpty(loginThreeInput) && string.IsNullOrEmpty(loginFourInput))
        {
            loginTwo.Select();
        }
        if (!string.IsNullOrEmpty(loginTwoInput) && string.IsNullOrEmpty(loginThreeInput) && string.IsNullOrEmpty(loginFourInput))
        {
            loginThree.Select();
        }
        if (!string.IsNullOrEmpty(loginThreeInput) && string.IsNullOrEmpty(loginFourInput))
        {
            loginFour.Select();
        }
    }

    public void CheckPin()
    {
        if (loginOneInput == "1" && loginTwoInput == "2" && loginThreeInput == "3" && loginFourInput == "4")
        {
            Debug.Log("Pin correct!");
        }
        else
        {
            Debug.Log("Pin incorrect, try again!");
        }
    }
}
