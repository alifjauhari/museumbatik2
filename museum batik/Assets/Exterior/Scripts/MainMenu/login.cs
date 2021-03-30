using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;

    public Text falseAllert;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://cubestudio.id/VR/batikdb/login.php", form);
        yield return www;
        if (www.text[0] == '0')
        {
            DBManager.playername = nameField.text;
            DBManager.highscore = int.Parse(www.text.Split('\t')[1]);
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            falseAllert.text = "Your name or password doesn't match";//if you want to allert the wrong account - add manually
            Debug.Log("User login failed. Error #" + www.text);
        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (nameField.text.Length >= 1 && passwordField.text.Length >= 1);
    }
}
