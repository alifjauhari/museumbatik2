﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour {

    public InputField nameField;
    public InputField passwordField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
    WWWForm form = new WWWForm();
    form.AddField("name", nameField.text);
    form.AddField("password", passwordField.text);
        WWW www = new WWW("http://cubestudio.id/VR/batikdb/register.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("User created succesfully.");
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("User creation failed. Error #" + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 1 && passwordField.text.Length >= 1);
    }

}
