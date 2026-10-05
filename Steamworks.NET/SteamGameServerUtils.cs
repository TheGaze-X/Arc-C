using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public static class SteamGameServerUtils
	{
		// Token: 0x060001EE RID: 494 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x4EBEC90", Offset = "0x4EBD890", VA = "0x184EBEC90")]
		public static uint GetSecondsSinceAppActive()
		{
			return 0U;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x4EBECE0", Offset = "0x4EBD8E0", VA = "0x184EBECE0")]
		public static uint GetSecondsSinceComputerActive()
		{
			return 0U;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4EBE8C0", Offset = "0x4EBD4C0", VA = "0x184EBE8C0")]
		public static EUniverse GetConnectedUniverse()
		{
			return EUniverse.k_EUniverseInvalid;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4EBED30", Offset = "0x4EBD930", VA = "0x184EBED30")]
		public static uint GetServerRealTime()
		{
			return 0U;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4EBEAF0", Offset = "0x4EBD6F0", VA = "0x184EBEAF0")]
		public static string GetIPCountry()
		{
			return null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4EBEC10", Offset = "0x4EBD810", VA = "0x184EBEC10")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x4EBEB90", Offset = "0x4EBD790", VA = "0x184EBEB90")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x4EBE910", Offset = "0x4EBD510", VA = "0x184EBE910")]
		public static byte GetCurrentBatteryPower()
		{
			return 0;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x4EBE830", Offset = "0x4EBD430", VA = "0x184EBE830")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x4EBF110", Offset = "0x4EBDD10", VA = "0x184EBF110")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x4EBEE20", Offset = "0x4EBDA20", VA = "0x184EBEE20")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4EBE750", Offset = "0x4EBD350", VA = "0x184EBE750")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return ESteamAPICallFailure.k_ESteamAPICallFailureSteamGone;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4EBE7A0", Offset = "0x4EBD3A0", VA = "0x184EBE7A0")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4EBEAA0", Offset = "0x4EBD6A0", VA = "0x184EBEAA0")]
		public static uint GetIPCCallCount()
		{
			return 0U;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x4EBF1B0", Offset = "0x4EBDDB0", VA = "0x184EBF1B0")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x4EBEE80", Offset = "0x4EBDA80", VA = "0x184EBEE80")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4EBE340", Offset = "0x4EBCF40", VA = "0x184EBE340")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x4EBE390", Offset = "0x4EBCF90", VA = "0x184EBE390")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x4EBF290", Offset = "0x4EBDE90", VA = "0x184EBF290")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4EBEA50", Offset = "0x4EBD650", VA = "0x184EBEA50")]
		public static uint GetEnteredGamepadTextLength()
		{
			return 0U;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x4EBE960", Offset = "0x4EBD560", VA = "0x184EBE960")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x4EBED80", Offset = "0x4EBD980", VA = "0x184EBED80")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4EBEF70", Offset = "0x4EBDB70", VA = "0x184EBEF70")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4EBF0B0", Offset = "0x4EBDCB0", VA = "0x184EBF0B0")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x4EBEF20", Offset = "0x4EBDB20", VA = "0x184EBEF20")]
		public static bool IsSteamInBigPictureMode()
		{
			return default(bool);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x4EBF490", Offset = "0x4EBE090", VA = "0x184EBF490")]
		public static void StartVRDashboard()
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4EBF010", Offset = "0x4EBDC10", VA = "0x184EBF010")]
		public static bool IsVRHeadsetStreamingEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x4EBF160", Offset = "0x4EBDD60", VA = "0x184EBF160")]
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x4EBEED0", Offset = "0x4EBDAD0", VA = "0x184EBEED0")]
		public static bool IsSteamChinaLauncher()
		{
			return default(bool);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x4EBEDD0", Offset = "0x4EBD9D0", VA = "0x184EBEDD0")]
		public static bool InitFilterText(uint unFilterOptions = 0U)
		{
			return default(bool);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x4EBE580", Offset = "0x4EBD180", VA = "0x184EBE580")]
		public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText)
		{
			return 0;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000049F4 File Offset: 0x00002BF4
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x4EBEB40", Offset = "0x4EBD740", VA = "0x184EBEB40")]
		public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol)
		{
			return ESteamIPv6ConnectivityState.k_ESteamIPv6ConnectivityState_Unknown;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00004A0C File Offset: 0x00002C0C
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4EBEFC0", Offset = "0x4EBDBC0", VA = "0x184EBEFC0")]
		public static bool IsSteamRunningOnSteamDeck()
		{
			return default(bool);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00004A24 File Offset: 0x00002C24
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4EBF200", Offset = "0x4EBDE00", VA = "0x184EBF200")]
		public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
		{
			return default(bool);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x4EBF060", Offset = "0x4EBDC60", VA = "0x184EBF060")]
		public static void SetGameLauncherMode(bool bLauncherMode)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4EBE4E0", Offset = "0x4EBD0E0", VA = "0x184EBE4E0")]
		public static bool DismissFloatingGamepadTextInput()
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4EBE530", Offset = "0x4EBD130", VA = "0x184EBE530")]
		public static bool DismissGamepadTextInput()
		{
			return default(bool);
		}
	}
}
