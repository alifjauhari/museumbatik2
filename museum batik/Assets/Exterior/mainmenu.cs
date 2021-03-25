using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour
{

    public Button playButton;
    

    public Text playerDisplay;

    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player: " + DBManager.playername;
        }
        playButton.interactable = DBManager.LoggedIn;
    }


    public void GoToRegister()
    {
        SceneManager.LoadScene(2);
    }

    public void GoLogin()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToGame()
    {
        SceneManager.LoadScene(4);
    }

    public void GoToLeaderboard()
    {
        SceneManager.LoadScene(5);
    }
}
