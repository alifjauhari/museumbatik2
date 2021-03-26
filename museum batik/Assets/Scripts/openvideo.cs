using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using System.Collections;

public class openvideo : MonoBehaviour 
{
	[DllImport("__Internal")]
	private static extern void OpenNewTab(string url);

	public void OpenVideo()
	{
		#if !UNITY_EDITOR && UNITY_WEBGL
             OpenNewTab("https://youtu.be/TZWpnppfv4I");
		#endif
	}
}