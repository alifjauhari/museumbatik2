using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;
using System.Collections;

public class whatsapp : MonoBehaviour 
{
	[DllImport("__Internal")]
	private static extern void OpenNewTab(string url);

	public void OpenWhatsapp()
	{
		#if !UNITY_EDITOR && UNITY_WEBGL
             OpenNewTab("https://chat.whatsapp.com/IvPmD4eumIv9yqAKTf2ebC");
		#endif
	}
}