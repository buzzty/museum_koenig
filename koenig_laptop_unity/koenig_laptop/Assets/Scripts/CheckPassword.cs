using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CheckPassword : MonoBehaviour
{
    public TMP_InputField login;
    public string passwordInput;

    private void Start()
    {
        login.Select();
    }

    private void Update()
    {
        passwordInput = login.text;
    }

    public void CheckLogin()
    {
        if (passwordInput == "koenig")
        {
            Debug.Log("Password correct!");
        }
        else
        {
            login.text = null;
            login.Select();
            Debug.Log("Password incorrect, try again!");
        }
    }
}
