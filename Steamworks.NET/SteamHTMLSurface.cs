using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public static class SteamHTMLSurface
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4EC16C0", Offset = "0x4EC02C0", VA = "0x184EC16C0")]
		public static bool Init()
		{
			return default(bool);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x4EC2440", Offset = "0x4EC1040", VA = "0x184EC2440")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4EC10D0", Offset = "0x4EBFCD0", VA = "0x184EC10D0")]
		public static SteamAPICall_t CreateBrowser(string pchUserAgent, string pchUserCSS)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4EC1DC0", Offset = "0x4EC09C0", VA = "0x184EC1DC0")]
		public static void RemoveBrowser(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x4EC1900", Offset = "0x4EC0500", VA = "0x184EC1900")]
		public static void LoadURL(HHTMLBrowser unBrowserHandle, string pchURL, string pchPostData)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x4EC2360", Offset = "0x4EC0F60", VA = "0x184EC2360")]
		public static void SetSize(HHTMLBrowser unBrowserHandle, uint unWidth, uint unHeight)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4EC24E0", Offset = "0x4EC10E0", VA = "0x184EC24E0")]
		public static void StopLoad(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4EC1D70", Offset = "0x4EC0970", VA = "0x184EC1D70")]
		public static void Reload(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4EC1620", Offset = "0x4EC0220", VA = "0x184EC1620")]
		public static void GoBack(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x4EC1670", Offset = "0x4EC0270", VA = "0x184EC1670")]
		public static void GoForward(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4EC0E50", Offset = "0x4EBFA50", VA = "0x184EC0E50")]
		public static void AddHeader(HHTMLBrowser unBrowserHandle, string pchKey, string pchValue)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x4EC12E0", Offset = "0x4EBFEE0", VA = "0x184EC12E0")]
		public static void ExecuteJavascript(HHTMLBrowser unBrowserHandle, string pchScript)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x4EC1C10", Offset = "0x4EC0810", VA = "0x184EC1C10")]
		public static void MouseUp(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4EC1B30", Offset = "0x4EC0730", VA = "0x184EC1B30")]
		public static void MouseDown(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4EC1AD0", Offset = "0x4EC06D0", VA = "0x184EC1AD0")]
		public static void MouseDoubleClick(HHTMLBrowser unBrowserHandle, EHTMLMouseButton eMouseButton)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4EC1B90", Offset = "0x4EC0790", VA = "0x184EC1B90")]
		public static void MouseMove(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4EC1C70", Offset = "0x4EC0870", VA = "0x184EC1C70")]
		public static void MouseWheel(HHTMLBrowser unBrowserHandle, int nDelta)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4EC17F0", Offset = "0x4EC03F0", VA = "0x184EC17F0")]
		public static void KeyDown(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers, bool bIsSystemKey = false)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x4EC1880", Offset = "0x4EC0480", VA = "0x184EC1880")]
		public static void KeyUp(HHTMLBrowser unBrowserHandle, uint nNativeKeyCode, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x4EC1770", Offset = "0x4EC0370", VA = "0x184EC1770")]
		public static void KeyChar(HHTMLBrowser unBrowserHandle, uint cUnicodeChar, EHTMLKeyModifiers eHTMLKeyModifiers)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x4EC2210", Offset = "0x4EC0E10", VA = "0x184EC2210")]
		public static void SetHorizontalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x4EC23E0", Offset = "0x4EC0FE0", VA = "0x184EC23E0")]
		public static void SetVerticalScroll(HHTMLBrowser unBrowserHandle, uint nAbsolutePixelScroll)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4EC2270", Offset = "0x4EC0E70", VA = "0x184EC2270")]
		public static void SetKeyFocus(HHTMLBrowser unBrowserHandle, bool bHasKeyFocus)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4EC2530", Offset = "0x4EC1130", VA = "0x184EC2530")]
		public static void ViewSource(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x4EC1080", Offset = "0x4EBFC80", VA = "0x184EC1080")]
		public static void CopyToClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4EC1D20", Offset = "0x4EC0920", VA = "0x184EC1D20")]
		public static void PasteFromClipboard(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x4EC1460", Offset = "0x4EC0060", VA = "0x184EC1460")]
		public static void Find(HHTMLBrowser unBrowserHandle, string pchSearchStr, bool bCurrentlyInFind, bool bReverse)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x4EC2490", Offset = "0x4EC1090", VA = "0x184EC2490")]
		public static void StopFind(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x4EC15A0", Offset = "0x4EC01A0", VA = "0x184EC15A0")]
		public static void GetLinkAtPosition(HHTMLBrowser unBrowserHandle, int x, int y)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x4EC1E70", Offset = "0x4EC0A70", VA = "0x184EC1E70")]
		public static void SetCookie(string pchHostname, string pchKey, string pchValue, string pchPath = "/", uint nExpires = 0U, bool bSecure = false, bool bHTTPOnly = false)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x4EC22D0", Offset = "0x4EC0ED0", VA = "0x184EC22D0")]
		public static void SetPageScaleFactor(HHTMLBrowser unBrowserHandle, float flZoom, int nPointX, int nPointY)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4EC1E10", Offset = "0x4EC0A10", VA = "0x184EC1E10")]
		public static void SetBackgroundMode(HHTMLBrowser unBrowserHandle, bool bBackgroundMode)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x4EC21B0", Offset = "0x4EC0DB0", VA = "0x184EC21B0")]
		public static void SetDPIScalingFactor(HHTMLBrowser unBrowserHandle, float flDPIScaling)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x4EC1CD0", Offset = "0x4EC08D0", VA = "0x184EC1CD0")]
		public static void OpenDeveloperTools(HHTMLBrowser unBrowserHandle)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x4EC1020", Offset = "0x4EBFC20", VA = "0x184EC1020")]
		public static void AllowStartRequest(HHTMLBrowser unBrowserHandle, bool bAllowed)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x4EC1710", Offset = "0x4EC0310", VA = "0x184EC1710")]
		public static void JSDialogResponse(HHTMLBrowser unBrowserHandle, bool bResult)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x4EC1400", Offset = "0x4EC0000", VA = "0x184EC1400")]
		public static void FileLoadDialogResponse(HHTMLBrowser unBrowserHandle, IntPtr pchSelectedFiles)
		{
		}
	}
}
