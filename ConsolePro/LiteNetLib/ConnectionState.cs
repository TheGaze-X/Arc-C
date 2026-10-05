using System;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	[Flags]
	public enum ConnectionState : byte
	{
		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		Outgoing = 2,
		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		Connected = 4,
		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		ShutdownRequested = 8,
		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		Disconnected = 16,
		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		Any = 14
	}
}
