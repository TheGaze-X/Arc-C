using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	public static class SteamAPI
	{
		// Token: 0x06000976 RID: 2422 RVA: 0x00007EEC File Offset: 0x000060EC
		[Token(Token = "0x6000976")]
		[Address(RVA = "0x4F0D710", Offset = "0x4F0C310", VA = "0x184F0D710")]
		public static ESteamAPIInitResult InitEx(out string OutSteamErrMsg)
		{
			return ESteamAPIInitResult.k_ESteamAPIInitResult_OK;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00007F04 File Offset: 0x00006104
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x4F0DF70", Offset = "0x4F0CB70", VA = "0x184F0DF70")]
		public static bool Init()
		{
			return default(bool);
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x4F0DFF0", Offset = "0x4F0CBF0", VA = "0x184F0DFF0")]
		public static void Shutdown()
		{
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00007F1C File Offset: 0x0000611C
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x4F09510", Offset = "0x4F08110", VA = "0x184F09510")]
		public static bool RestartAppIfNecessary(AppId_t unOwnAppID)
		{
			return default(bool);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x4F094A0", Offset = "0x4F080A0", VA = "0x184F094A0")]
		public static void ReleaseCurrentThreadMemory()
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x4F0DFA0", Offset = "0x4F0CBA0", VA = "0x184F0DFA0")]
		public static void RunCallbacks()
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00007F34 File Offset: 0x00006134
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x4F09030", Offset = "0x4F07C30", VA = "0x184F09030")]
		public static bool IsSteamRunning()
		{
			return default(bool);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00007F4C File Offset: 0x0000614C
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x4F0D680", Offset = "0x4F0C280", VA = "0x184F0D680")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00007F64 File Offset: 0x00006164
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x4F0D6A0", Offset = "0x4F0C2A0", VA = "0x184F0D6A0")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
}
