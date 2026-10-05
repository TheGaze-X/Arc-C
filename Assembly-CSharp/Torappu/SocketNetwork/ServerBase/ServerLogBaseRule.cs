using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014B7 RID: 5303
	[Token(Token = "0x20014B7")]
	public static class ServerLogBaseRule
	{
		// Token: 0x06007A68 RID: 31336 RVA: 0x00036C30 File Offset: 0x00034E30
		[Token(Token = "0x6007A68")]
		[Address(RVA = "0x2646AB0", Offset = "0x26456B0", VA = "0x182646AB0")]
		public static bool AllowedRevMsg(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x00036C48 File Offset: 0x00034E48
		[Token(Token = "0x6007A69")]
		[Address(RVA = "0x2646B20", Offset = "0x2645720", VA = "0x182646B20")]
		public static bool AllowedSendMsg(Protocol protocol)
		{
			return default(bool);
		}

		// Token: 0x06007A6A RID: 31338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6A")]
		[Address(RVA = "0x2646CC0", Offset = "0x26458C0", VA = "0x182646CC0")]
		public static void LogSendMsg(Protocol protocol, IServerLogRule logRule)
		{
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007A6B")]
		[Address(RVA = "0x2646B90", Offset = "0x2645790", VA = "0x182646B90")]
		public static void LogRevMsg(Protocol protocol, IServerLogRule logRule)
		{
		}
	}
}
