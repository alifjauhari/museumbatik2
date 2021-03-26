using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkwa : MonoBehaviour 
{

	public void OpenLinkWhatsApp()
	{
		#if !UNITY_EDITOR
		openWindow("https://chat.whatsapp.com/IvPmD4eumIv9yqAKTf2ebC");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}