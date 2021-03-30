using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager
{

    public static string playername;
    public static int highscore;

    public static bool LoggedIn { get { return playername != null; } }

    public static void LogOut()
    {
        playername = null;
    }
}
