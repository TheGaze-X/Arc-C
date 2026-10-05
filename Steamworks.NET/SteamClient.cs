using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public static class SteamClient
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4EAAEE0", Offset = "0x4EA9AE0", VA = "0x184EAAEE0")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4EAAD70", Offset = "0x4EA9970", VA = "0x184EAAD70")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4EAAE10", Offset = "0x4EA9A10", VA = "0x184EAAE10")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4EAAE70", Offset = "0x4EA9A70", VA = "0x184EAAE70")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4EAD180", Offset = "0x4EABD80", VA = "0x184EAD180")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4EACDB0", Offset = "0x4EAB9B0", VA = "0x184EACDB0")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4EAB610", Offset = "0x4EAA210", VA = "0x184EAB610")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4EAD1E0", Offset = "0x4EABDE0", VA = "0x184EAD1E0")]
		public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4EAB220", Offset = "0x4EA9E20", VA = "0x184EAB220")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4EACF00", Offset = "0x4EABB00", VA = "0x184EACF00")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4EABF40", Offset = "0x4EAAB40", VA = "0x184EABF40")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4EABDF0", Offset = "0x4EAA9F0", VA = "0x184EABDF0")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4EAB760", Offset = "0x4EAA360", VA = "0x184EAB760")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4EACC60", Offset = "0x4EAB860", VA = "0x184EACC60")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4EAB4C0", Offset = "0x4EAA0C0", VA = "0x184EAB4C0")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4EAAF80", Offset = "0x4EA9B80", VA = "0x184EAAF80")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4EAC330", Offset = "0x4EAAF30", VA = "0x184EAC330")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x4EAC870", Offset = "0x4EAB470", VA = "0x184EAC870")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4EAC9C0", Offset = "0x4EAB5C0", VA = "0x184EAC9C0")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4EAB370", Offset = "0x4EA9F70", VA = "0x184EAB370")]
		public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4EAAF30", Offset = "0x4EA9B30", VA = "0x184EAAF30")]
		public static uint GetIPCCallCount()
		{
			return 0U;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4EAD240", Offset = "0x4EABE40", VA = "0x184EAD240")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4EAADC0", Offset = "0x4EA99C0", VA = "0x184EAADC0")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x4EABA00", Offset = "0x4EAA600", VA = "0x184EABA00")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4EAB0D0", Offset = "0x4EA9CD0", VA = "0x184EAB0D0")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4EACB10", Offset = "0x4EAB710", VA = "0x184EACB10")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4EAC1E0", Offset = "0x4EAADE0", VA = "0x184EAC1E0")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4EAC090", Offset = "0x4EAAC90", VA = "0x184EAC090")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x4EAB8B0", Offset = "0x4EAA4B0", VA = "0x184EAB8B0")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4EABCA0", Offset = "0x4EAA8A0", VA = "0x184EABCA0")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4EAD030", Offset = "0x4EABC30", VA = "0x184EAD030")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4EAC480", Offset = "0x4EAB080", VA = "0x184EAC480")]
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4EABB50", Offset = "0x4EAA750", VA = "0x184EABB50")]
		public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4EAC5D0", Offset = "0x4EAB1D0", VA = "0x184EAC5D0")]
		public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4EAC720", Offset = "0x4EAB320", VA = "0x184EAC720")]
		public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}
	}
}
