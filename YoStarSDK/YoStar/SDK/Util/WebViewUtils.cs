using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using Vuplex.WebView;
using YoStar.SDK.UI;

namespace YoStar.SDK.Util
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public class WebViewUtils
	{
		// Token: 0x060004FE RID: 1278 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x5C3A570", Offset = "0x5C39170", VA = "0x185C3A570")]
		public static void OpenWebview(string url)
		{
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x5C3A3D0", Offset = "0x5C38FD0", VA = "0x185C3A3D0")]
		public static void KMCVer(string url)
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x5C3A270", Offset = "0x5C38E70", VA = "0x185C3A270")]
		public static SDKWebview GoogleAuthWeb(string url, string javaScriptMsg = "", [Optional] Action<string> callback, [Optional] WebViewUtils.LoadProgressChangedCallback loadProgressChangedCallback)
		{
			return null;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x5C3A0E0", Offset = "0x5C38CE0", VA = "0x185C3A0E0")]
		public static SDKWebview BindYostarWeb(string url)
		{
			return null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x5C3A600", Offset = "0x5C39200", VA = "0x185C3A600")]
		public static SDKWebview ShowWebview(Color backgroundColor, string url = "", string html = "", string title = "", int width = 0, int height = 0, float webResolution = 0f, bool hiddenToolBar = false, string javaScriptMsg = "", [Optional] WebViewUtils.ChangeCallback urlCallback, [Optional] WebViewUtils.ChangeCallback jsCallback, [Optional] WebViewUtils.WebViewDestroyCallback destroyCallback, [Optional] WebViewUtils.LoadProgressChangedCallback loadProgressChangedCallback)
		{
			return null;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WebViewUtils()
		{
		}

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000505 RID: 1285
		[Token(Token = "0x20000B8")]
		public delegate void ChangeCallback(SDKWebview sdkWebView, string msg);

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000509 RID: 1289
		[Token(Token = "0x20000B9")]
		public delegate void WebViewDestroyCallback();

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x0600050D RID: 1293
		[Token(Token = "0x20000BA")]
		public delegate void LoadProgressChangedCallback(SDKWebview sdkWebView, ProgressChangedEventArgs eventArgs);
	}
}
