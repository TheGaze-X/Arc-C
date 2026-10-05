using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public static class SteamScreenshots
	{
		// Token: 0x060003D0 RID: 976 RVA: 0x00006ADC File Offset: 0x00004CDC
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x4ED2460", Offset = "0x4ED1060", VA = "0x184ED2460")]
		public static ScreenshotHandle WriteScreenshot(byte[] pubRGB, uint cubRGB, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00006AF4 File Offset: 0x00004CF4
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x4ED1D70", Offset = "0x4ED0970", VA = "0x184ED1D70")]
		public static ScreenshotHandle AddScreenshotToLibrary(string pchFilename, string pchThumbnailFilename, int nWidth, int nHeight)
		{
			return default(ScreenshotHandle);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x4ED2410", Offset = "0x4ED1010", VA = "0x184ED2410")]
		public static void TriggerScreenshot()
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x4ED2180", Offset = "0x4ED0D80", VA = "0x184ED2180")]
		public static void HookScreenshots(bool bHook)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00006B0C File Offset: 0x00004D0C
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x4ED2220", Offset = "0x4ED0E20", VA = "0x184ED2220")]
		public static bool SetLocation(ScreenshotHandle hScreenshot, string pchLocation)
		{
			return default(bool);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00006B24 File Offset: 0x00004D24
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x4ED23B0", Offset = "0x4ED0FB0", VA = "0x184ED23B0")]
		public static bool TagUser(ScreenshotHandle hScreenshot, CSteamID steamID)
		{
			return default(bool);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00006B3C File Offset: 0x00004D3C
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x4ED2350", Offset = "0x4ED0F50", VA = "0x184ED2350")]
		public static bool TagPublishedFile(ScreenshotHandle hScreenshot, PublishedFileId_t unPublishedFileID)
		{
			return default(bool);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00006B54 File Offset: 0x00004D54
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x4ED21D0", Offset = "0x4ED0DD0", VA = "0x184ED21D0")]
		public static bool IsScreenshotsHooked()
		{
			return default(bool);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00006B6C File Offset: 0x00004D6C
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x4ED1F80", Offset = "0x4ED0B80", VA = "0x184ED1F80")]
		public static ScreenshotHandle AddVRScreenshotToLibrary(EVRScreenshotType eType, string pchFilename, string pchVRFilename)
		{
			return default(ScreenshotHandle);
		}
	}
}
