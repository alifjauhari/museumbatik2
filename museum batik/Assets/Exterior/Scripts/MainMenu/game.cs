using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game : MonoBehaviour
{
    public Text playerDisplay;
    public Text scoreDisplay;

    private void Awake()
    {
        if (DBManager.playername == null)
        {
            SceneManager.LoadScene(1);
        }
        playerDisplay.text = "Player: " + DBManager.playername;
        scoreDisplay.text = "Score: " + DBManager.highscore;
    }

    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData());
    }

    IEnumerator SavePlayerData()
    {
        WWWForm form = new WWWForm();
        form.AddField("name", DBManager.playername);
        form.AddField("score", DBManager.highscore);

        WWW www = new WWW("http://cubestudio.id/VR/batikdb/savedata.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Game Saved.");
        }
        else
        {
            Debug.Log("Save failed. Error#" + www.text);
        }

        DBManager.LogOut();
        SceneManager.LoadScene(1);
    }


    //u can use this void if you dont want log out but wanna exit the game (it wasnt used automatically)
    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void IncreaseScore()
    {
        DBManager.highscore++;
        scoreDisplay.text = "Score: " + DBManager.highscore;
    }
}
