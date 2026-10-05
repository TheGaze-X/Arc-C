using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	public static class GameServer
	{
		// Token: 0x0600097F RID: 2431 RVA: 0x00007F7C File Offset: 0x0000617C
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x4EDDE00", Offset = "0x4EDCA00", VA = "0x184EDDE00")]
		public static ESteamAPIInitResult InitEx(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString, out string OutSteamErrMsg)
		{
			return ESteamAPIInitResult.k_ESteamAPIInitResult_OK;
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00007F94 File Offset: 0x00006194
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x4EDE3F0", Offset = "0x4EDCFF0", VA = "0x184EDE3F0")]
		public static bool Init(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return default(bool);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x4EDE4F0", Offset = "0x4EDD0F0", VA = "0x184EDE4F0")]
		public static void Shutdown()
		{
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x4EDE4A0", Offset = "0x4EDD0A0", VA = "0x184EDE4A0")]
		public static void RunCallbacks()
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x4EDE430", Offset = "0x4EDD030", VA = "0x184EDE430")]
		public static void ReleaseCurrentThreadMemory()
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00007FAC File Offset: 0x000061AC
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x4EDDC50", Offset = "0x4EDC850", VA = "0x184EDDC50")]
		public static bool BSecure()
		{
			return default(bool);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00007FC4 File Offset: 0x000061C4
		[Token(Token = "0x6000985")]
		[Address(RVA = "0x4EDDD50", Offset = "0x4EDC950", VA = "0x184EDDD50")]
		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00007FDC File Offset: 0x000061DC
		[Token(Token = "0x6000986")]
		[Address(RVA = "0x4EDDCC0", Offset = "0x4EDC8C0", VA = "0x184EDDCC0")]
		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00007FF4 File Offset: 0x000061F4
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x4EDDCE0", Offset = "0x4EDC8E0", VA = "0x184EDDCE0")]
		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
}
