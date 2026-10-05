using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public static class SteamGameServerClient
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4EB0890", Offset = "0x4EAF490", VA = "0x184EB0890")]
		public static HSteamPipe CreateSteamPipe()
		{
			return default(HSteamPipe);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4EB0720", Offset = "0x4EAF320", VA = "0x184EB0720")]
		public static bool BReleaseSteamPipe(HSteamPipe hSteamPipe)
		{
			return default(bool);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4EB07C0", Offset = "0x4EAF3C0", VA = "0x184EB07C0")]
		public static HSteamUser ConnectToGlobalUser(HSteamPipe hSteamPipe)
		{
			return default(HSteamUser);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4EB0820", Offset = "0x4EAF420", VA = "0x184EB0820")]
		public static HSteamUser CreateLocalUser(out HSteamPipe phSteamPipe, EAccountType eAccountType)
		{
			return default(HSteamUser);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4EB2B30", Offset = "0x4EB1730", VA = "0x184EB2B30")]
		public static void ReleaseUser(HSteamPipe hSteamPipe, HSteamUser hUser)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4EB2760", Offset = "0x4EB1360", VA = "0x184EB2760")]
		public static IntPtr GetISteamUser(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4EB0FC0", Offset = "0x4EAFBC0", VA = "0x184EB0FC0")]
		public static IntPtr GetISteamGameServer(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x4EB2B90", Offset = "0x4EB1790", VA = "0x184EB2B90")]
		public static void SetLocalIPBinding(ref SteamIPAddress_t unIP, ushort usPort)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4EB0BD0", Offset = "0x4EAF7D0", VA = "0x184EB0BD0")]
		public static IntPtr GetISteamFriends(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4EB28B0", Offset = "0x4EB14B0", VA = "0x184EB28B0")]
		public static IntPtr GetISteamUtils(HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x4EB18F0", Offset = "0x4EB04F0", VA = "0x184EB18F0")]
		public static IntPtr GetISteamMatchmaking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x4EB17A0", Offset = "0x4EB03A0", VA = "0x184EB17A0")]
		public static IntPtr GetISteamMatchmakingServers(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x4EB1110", Offset = "0x4EAFD10", VA = "0x184EB1110")]
		public static IntPtr GetISteamGenericInterface(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x4EB2610", Offset = "0x4EB1210", VA = "0x184EB2610")]
		public static IntPtr GetISteamUserStats(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x4EB0E70", Offset = "0x4EAFA70", VA = "0x184EB0E70")]
		public static IntPtr GetISteamGameServerStats(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4EB0930", Offset = "0x4EAF530", VA = "0x184EB0930")]
		public static IntPtr GetISteamApps(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4EB1CE0", Offset = "0x4EB08E0", VA = "0x184EB1CE0")]
		public static IntPtr GetISteamNetworking(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4EB2220", Offset = "0x4EB0E20", VA = "0x184EB2220")]
		public static IntPtr GetISteamRemoteStorage(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4EB2370", Offset = "0x4EB0F70", VA = "0x184EB2370")]
		public static IntPtr GetISteamScreenshots(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x4EB0D20", Offset = "0x4EAF920", VA = "0x184EB0D20")]
		public static IntPtr GetISteamGameSearch(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x4EB08E0", Offset = "0x4EAF4E0", VA = "0x184EB08E0")]
		public static uint GetIPCCallCount()
		{
			return 0U;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x4EB2BF0", Offset = "0x4EB17F0", VA = "0x184EB2BF0")]
		public static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x4EB0770", Offset = "0x4EAF370", VA = "0x184EB0770")]
		public static bool BShutdownIfAllPipesClosed()
		{
			return default(bool);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x4EB13B0", Offset = "0x4EAFFB0", VA = "0x184EB13B0")]
		public static IntPtr GetISteamHTTP(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x4EB0A80", Offset = "0x4EAF680", VA = "0x184EB0A80")]
		public static IntPtr GetISteamController(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4EB24C0", Offset = "0x4EB10C0", VA = "0x184EB24C0")]
		public static IntPtr GetISteamUGC(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4EB1B90", Offset = "0x4EB0790", VA = "0x184EB1B90")]
		public static IntPtr GetISteamMusic(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4EB1A40", Offset = "0x4EB0640", VA = "0x184EB1A40")]
		public static IntPtr GetISteamMusicRemote(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4EB1260", Offset = "0x4EAFE60", VA = "0x184EB1260")]
		public static IntPtr GetISteamHTMLSurface(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4EB1650", Offset = "0x4EB0250", VA = "0x184EB1650")]
		public static IntPtr GetISteamInventory(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x4EB29E0", Offset = "0x4EB15E0", VA = "0x184EB29E0")]
		public static IntPtr GetISteamVideo(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x4EB1E30", Offset = "0x4EB0A30", VA = "0x184EB1E30")]
		public static IntPtr GetISteamParentalSettings(HSteamUser hSteamuser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4EB1500", Offset = "0x4EB0100", VA = "0x184EB1500")]
		public static IntPtr GetISteamInput(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x4EB1F80", Offset = "0x4EB0B80", VA = "0x184EB1F80")]
		public static IntPtr GetISteamParties(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x4EB20D0", Offset = "0x4EB0CD0", VA = "0x184EB20D0")]
		public static IntPtr GetISteamRemotePlay(HSteamUser hSteamUser, HSteamPipe hSteamPipe, string pchVersion)
		{
			return 0;
		}
	}
}
