using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webtest : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        WWW request = new WWW("http://cubestudio.id/VR/batikdb/webtest.php");
        yield return request;
        string[] webResults = request.text.Split('\t');
        Debug.Log(webResults[0]);
        int webNumber = int.Parse(webResults[1]);
        webNumber *= 2;
        Debug.Log(webNumber);
    }


}
