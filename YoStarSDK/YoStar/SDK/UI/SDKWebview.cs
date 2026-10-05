using System;
using System.Collections;
using System.Threading.Tasks;
using System.Timers;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Vuplex.WebView;

namespace YoStar.SDK.UI
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public class SDKWebview
	{
		// Token: 0x06000B1E RID: 2846 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x5C8E660", Offset = "0x5C8D260", VA = "0x185C8E660")]
		public SDKWebview()
		{
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x5C8D6F0", Offset = "0x5C8C2F0", VA = "0x185C8D6F0")]
		private Task InitUserAgentAsync()
		{
			return null;
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x5C8D860", Offset = "0x5C8C460", VA = "0x185C8D860")]
		public void InterceptLink()
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x22F8A70", Offset = "0x22F7670", VA = "0x1822F8A70")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x5C8DED0", Offset = "0x5C8CAD0", VA = "0x185C8DED0")]
		public void SetUrl(string url)
		{
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x5C8DE60", Offset = "0x5C8CA60", VA = "0x185C8DE60")]
		public void SetHtml(string html)
		{
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0xEDF340", Offset = "0xEDDF40", VA = "0x180EDF340")]
		public void SetUrlChangeCallBack(SDKWebview.ChangeCallback callback)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x168B8E0", Offset = "0x168A4E0", VA = "0x18168B8E0")]
		public void SetJsMsgReceivedCallBack(SDKWebview.ChangeCallback callback)
		{
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x1FC11F0", Offset = "0x1FBFDF0", VA = "0x181FC11F0")]
		public void SetPageLoadFailedCallBack(SDKWebview.ChangeCallback callback)
		{
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0xF93850", Offset = "0xF92450", VA = "0x180F93850")]
		public void SetWebViewDestroyCallback(SDKWebview.WebViewDestroyCallback callback)
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
		public void SetLoadProgressChangedCallback(SDKWebview.LoadProgressChangedCallback callback)
		{
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x5C8DEC0", Offset = "0x5C8CAC0", VA = "0x185C8DEC0")]
		public void SetSize(int width, int height)
		{
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
		public void HiddenToolBar(bool hide)
		{
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x4E6EA0", Offset = "0x4E5AA0", VA = "0x1804E6EA0")]
		public void SetBackGroupColor(Color color)
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
		public void SetJavaScriptMsg(string jsMsg)
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x5C8DF30", Offset = "0x5C8CB30", VA = "0x185C8DF30")]
		public void SetWebResolution(float resolution)
		{
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x5C8CD90", Offset = "0x5C8B990", VA = "0x185C8CD90")]
		private void ChangeWebBGColor()
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x5C8D950", Offset = "0x5C8C550", VA = "0x185C8D950")]
		public void InvokeJs(string jsonStr)
		{
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
		public void SetSortingOrder(int sort)
		{
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x5C8DF50", Offset = "0x5C8CB50", VA = "0x185C8DF50")]
		public void Show()
		{
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x5C8DFF0", Offset = "0x5C8CBF0", VA = "0x185C8DFF0")]
		public void StopCurrentLoad()
		{
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x5C8D420", Offset = "0x5C8C020", VA = "0x185C8D420")]
		public void Destroy()
		{
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x5C8D660", Offset = "0x5C8C260", VA = "0x185C8D660")]
		public void HideScrollbars(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x5C8D3A0", Offset = "0x5C8BFA0", VA = "0x185C8D3A0")]
		private void DestroyGameObject(GameObject obj)
		{
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x5C8D0E0", Offset = "0x5C8BCE0", VA = "0x185C8D0E0")]
		private Canvas CreateCanvas()
		{
			return null;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x5C8D5C0", Offset = "0x5C8C1C0", VA = "0x185C8D5C0")]
		public void GoBack()
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x5C8E0F0", Offset = "0x5C8CCF0", VA = "0x185C8E0F0")]
		public void UpdateCanvasGroup(int alpha)
		{
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x5C8BF20", Offset = "0x5C8AB20", VA = "0x185C8BF20")]
		private void AddWebViewWrap(Canvas canva)
		{
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x5C8DD60", Offset = "0x5C8C960", VA = "0x185C8DD60")]
		public void SetDefaultBackground(bool Enabled)
		{
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x5C8D7A0", Offset = "0x5C8C3A0", VA = "0x185C8D7A0")]
		private void InitWebView(CanvasWebViewPrefab canvasWebView)
		{
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x5C8DAA0", Offset = "0x5C8C6A0", VA = "0x185C8DAA0")]
		private IEnumerator LoadByUrl(string url)
		{
			return null;
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B3D")]
		[Address(RVA = "0x5C8DA10", Offset = "0x5C8C610", VA = "0x185C8DA10")]
		private IEnumerator LoadByHtml(string html)
		{
			return null;
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x5C8CCF0", Offset = "0x5C8B8F0", VA = "0x185C8CCF0")]
		private void ButtonRefreshTimer_Elapsed(object sender, ElapsedEventArgs eventArgs)
		{
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x5C8CEB0", Offset = "0x5C8BAB0", VA = "0x185C8CEB0")]
		private void Controls_MessageEmitted(object sender, EventArgs<string> eventArgs)
		{
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x5C8E330", Offset = "0x5C8CF30", VA = "0x185C8E330")]
		private void WebView_UrlChanged(object sender, UrlChangedEventArgs eventArgs)
		{
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x5C8E180", Offset = "0x5C8CD80", VA = "0x185C8E180")]
		private void WebView_PageLoadFailed(object sender, EventArgs eventArgs)
		{
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B42")]
		[Address(RVA = "0x5C8DB30", Offset = "0x5C8C730", VA = "0x185C8DB30")]
		private void LoadProgressChanged(object sender, ProgressChangedEventArgs eventArgs)
		{
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0000371C File Offset: 0x0000191C
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x3D287A0", Offset = "0x3D273A0", VA = "0x183D287A0")]
		private int ResizeToolBarHeight()
		{
			return 0;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0x5C8DCF0", Offset = "0x5C8C8F0", VA = "0x185C8DCF0")]
		private void ResizeToolBarBtnSize(Button btn)
		{
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0x5C8CE70", Offset = "0x5C8BA70", VA = "0x185C8CE70")]
		public static void ClearAllData()
		{
		}

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0x10")]
		private Color backageColor;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0x20")]
		private int width;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0x24")]
		private int height;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0x28")]
		private bool hideToolBar;

		// Token: 0x04000783 RID: 1923
		[Token(Token = "0x4000783")]
		[FieldOffset(Offset = "0x30")]
		private string javaScriptMsg;

		// Token: 0x04000784 RID: 1924
		[Token(Token = "0x4000784")]
		[FieldOffset(Offset = "0x0")]
		private static int index;

		// Token: 0x04000785 RID: 1925
		[Token(Token = "0x4000785")]
		[FieldOffset(Offset = "0x38")]
		private int sortingOrder;

		// Token: 0x04000786 RID: 1926
		[Token(Token = "0x4000786")]
		[FieldOffset(Offset = "0x3C")]
		private bool webViewInited;

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x40")]
		private float webResolution;

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x48")]
		private string url;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x50")]
		private string html;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x58")]
		private Slider processSlider;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x60")]
		private Button gobBackBtn;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x68")]
		private Canvas sdkCanvas;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x70")]
		private CanvasWebViewPrefab canvasWebViewPrefab;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x78")]
		private CanvasGroup canvasGroup;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x80")]
		private SDKWebview.ChangeCallback urlChangeCallback;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x88")]
		private SDKWebview.ChangeCallback jsMsgReceivedCallBack;

		// Token: 0x04000791 RID: 1937
		[Token(Token = "0x4000791")]
		[FieldOffset(Offset = "0x90")]
		private SDKWebview.ChangeCallback pageLoadFailedCallBack;

		// Token: 0x04000792 RID: 1938
		[Token(Token = "0x4000792")]
		[FieldOffset(Offset = "0x98")]
		private SDKWebview.WebViewDestroyCallback webViewDestroyCallback;

		// Token: 0x04000793 RID: 1939
		[Token(Token = "0x4000793")]
		[FieldOffset(Offset = "0xA0")]
		private SDKWebview.LoadProgressChangedCallback loadProgressChangedCallback;

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0xA8")]
		private Timer buttonRefreshTimer;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		private const string WebViewPrefabResourcePath = "prefab/WebviewWrap";

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0xB0")]
		private string titleText;

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0xB8")]
		private string retrieveAccount;

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x8")]
		private static string cachedUserAgent;

		// Token: 0x020001D0 RID: 464
		// (Invoke) Token: 0x06000B4C RID: 2892
		[Token(Token = "0x20001D0")]
		public delegate void ChangeCallback(SDKWebview sdkWebView, string msg);

		// Token: 0x020001D1 RID: 465
		// (Invoke) Token: 0x06000B50 RID: 2896
		[Token(Token = "0x20001D1")]
		public delegate void WebViewDestroyCallback(SDKWebview sdkWebView, string value);

		// Token: 0x020001D2 RID: 466
		// (Invoke) Token: 0x06000B54 RID: 2900
		[Token(Token = "0x20001D2")]
		public delegate void LoadProgressChangedCallback(SDKWebview sdkWebView, ProgressChangedEventArgs eventArgs);
	}
}
