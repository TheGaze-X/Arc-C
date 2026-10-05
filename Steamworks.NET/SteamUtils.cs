using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public static class SteamUtils
	{
		// Token: 0x06000489 RID: 1161 RVA: 0x00007A9C File Offset: 0x00005C9C
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x4F17A30", Offset = "0x4F16630", VA = "0x184F17A30")]
		public static uint GetSecondsSinceAppActive()
		{
			return 0U;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00007AB4 File Offset: 0x00005CB4
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x4F17AE0", Offset = "0x4F166E0", VA = "0x184F17AE0")]
		public static uint GetSecondsSinceComputerActive()
		{
			return 0U;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00007ACC File Offset: 0x00005CCC
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x4F172C0", Offset = "0x4F15EC0", VA = "0x184F172C0")]
		public static EUniverse GetConnectedUniverse()
		{
			return EUniverse.k_EUniverseInvalid;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00007AE4 File Offset: 0x00005CE4
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x4F17B90", Offset = "0x4F16790", VA = "0x184F17B90")]
		public static uint GetServerRealTime()
		{
			return 0U;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x4F176E0", Offset = "0x4F162E0", VA = "0x184F176E0")]
		public static string GetIPCountry()
		{
			return null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00007AFC File Offset: 0x00005CFC
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x4F17950", Offset = "0x4F16550", VA = "0x184F17950")]
		public static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			return default(bool);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00007B14 File Offset: 0x00005D14
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x4F17860", Offset = "0x4F16460", VA = "0x184F17860")]
		public static bool GetImageRGBA(int iImage, byte[] pubDest, int nDestBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00007B2C File Offset: 0x00005D2C
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x4F17370", Offset = "0x4F15F70", VA = "0x184F17370")]
		public static byte GetCurrentBatteryPower()
		{
			return 0;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00007B44 File Offset: 0x00005D44
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x4F171E0", Offset = "0x4F15DE0", VA = "0x184F171E0")]
		public static AppId_t GetAppID()
		{
			return default(AppId_t);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x4F18460", Offset = "0x4F17060", VA = "0x184F18460")]
		public static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00007B5C File Offset: 0x00005D5C
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x4F17DC0", Offset = "0x4F169C0", VA = "0x184F17DC0")]
		public static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			return default(bool);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00007B74 File Offset: 0x00005D74
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x4F17010", Offset = "0x4F15C10", VA = "0x184F17010")]
		public static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			return ESteamAPICallFailure.k_ESteamAPICallFailureSteamGone;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00007B8C File Offset: 0x00005D8C
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x4F170D0", Offset = "0x4F15CD0", VA = "0x184F170D0")]
		public static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			return default(bool);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00007BA4 File Offset: 0x00005DA4
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x4F17630", Offset = "0x4F16230", VA = "0x184F17630")]
		public static uint GetIPCCallCount()
		{
			return 0U;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x4F185E0", Offset = "0x4F171E0", VA = "0x184F185E0")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00007BBC File Offset: 0x00005DBC
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x4F17EB0", Offset = "0x4F16AB0", VA = "0x184F17EB0")]
		public static bool IsOverlayEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00007BD4 File Offset: 0x00005DD4
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x4F16950", Offset = "0x4F15550", VA = "0x184F16950")]
		public static bool BOverlayNeedsPresent()
		{
			return default(bool);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00007BEC File Offset: 0x00005DEC
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x4F16A00", Offset = "0x4F15600", VA = "0x184F16A00")]
		public static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			return default(SteamAPICall_t);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00007C04 File Offset: 0x00005E04
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x4F187B0", Offset = "0x4F173B0", VA = "0x184F187B0")]
		public static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			return default(bool);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00007C1C File Offset: 0x00005E1C
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x4F17580", Offset = "0x4F16180", VA = "0x184F17580")]
		public static uint GetEnteredGamepadTextLength()
		{
			return 0U;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00007C34 File Offset: 0x00005E34
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x4F17420", Offset = "0x4F16020", VA = "0x184F17420")]
		public static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			return default(bool);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x4F17C40", Offset = "0x4F16840", VA = "0x184F17C40")]
		public static string GetSteamUILanguage()
		{
			return null;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00007C4C File Offset: 0x00005E4C
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x4F180C0", Offset = "0x4F16CC0", VA = "0x184F180C0")]
		public static bool IsSteamRunningInVR()
		{
			return default(bool);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x4F18390", Offset = "0x4F16F90", VA = "0x184F18390")]
		public static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00007C64 File Offset: 0x00005E64
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x4F18010", Offset = "0x4F16C10", VA = "0x184F18010")]
		public static bool IsSteamInBigPictureMode()
		{
			return default(bool);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x4F18AB0", Offset = "0x4F176B0", VA = "0x184F18AB0")]
		public static void StartVRDashboard()
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00007C7C File Offset: 0x00005E7C
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x4F18220", Offset = "0x4F16E20", VA = "0x184F18220")]
		public static bool IsVRHeadsetStreamingEnabled()
		{
			return default(bool);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x4F18520", Offset = "0x4F17120", VA = "0x184F18520")]
		public static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00007C94 File Offset: 0x00005E94
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x4F17F60", Offset = "0x4F16B60", VA = "0x184F17F60")]
		public static bool IsSteamChinaLauncher()
		{
			return default(bool);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00007CAC File Offset: 0x00005EAC
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x4F17D00", Offset = "0x4F16900", VA = "0x184F17D00")]
		public static bool InitFilterText(uint unFilterOptions = 0U)
		{
			return default(bool);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00007CC4 File Offset: 0x00005EC4
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x4F16D80", Offset = "0x4F15980", VA = "0x184F16D80")]
		public static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText)
		{
			return 0;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00007CDC File Offset: 0x00005EDC
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x4F177A0", Offset = "0x4F163A0", VA = "0x184F177A0")]
		public static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol)
		{
			return ESteamIPv6ConnectivityState.k_ESteamIPv6ConnectivityState_Unknown;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00007CF4 File Offset: 0x00005EF4
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x4F18170", Offset = "0x4F16D70", VA = "0x184F18170")]
		public static bool IsSteamRunningOnSteamDeck()
		{
			return default(bool);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00007D0C File Offset: 0x00005F0C
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x4F186B0", Offset = "0x4F172B0", VA = "0x184F186B0")]
		public static bool ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode eKeyboardMode, int nTextFieldXPosition, int nTextFieldYPosition, int nTextFieldWidth, int nTextFieldHeight)
		{
			return default(bool);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x4F182D0", Offset = "0x4F16ED0", VA = "0x184F182D0")]
		public static void SetGameLauncherMode(bool bLauncherMode)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00007D24 File Offset: 0x00005F24
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x4F16C20", Offset = "0x4F15820", VA = "0x184F16C20")]
		public static bool DismissFloatingGamepadTextInput()
		{
			return default(bool);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00007D3C File Offset: 0x00005F3C
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x4F16CD0", Offset = "0x4F158D0", VA = "0x184F16CD0")]
		public static bool DismissGamepadTextInput()
		{
			return default(bool);
		}
	}
}
