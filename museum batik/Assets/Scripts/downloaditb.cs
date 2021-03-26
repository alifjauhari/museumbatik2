using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class downloaditb : MonoBehaviour
{

	public void DownloadITB1()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=13Z753KYGIRfFTTZfHf9yzg1BVvQM9MUn&export=download");
		#endif
	}

	public void DownloadITB2()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1EM3k_yts3_MrnYZW1BpidP9okNUKuLYn&export=download");
		#endif
	}

	public void DownloadITB3()
	{
		#if !UNITY_EDITOR
		openWindow("https://drive.google.com/uc?id=1hLNf2YT4XPWeLFkILBIdhWSAJIqs17wK&export=download");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}