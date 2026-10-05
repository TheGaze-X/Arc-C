using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	[Flags]
	public enum SocketFlags
	{
		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		None = 0,
		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		OutOfBand = 1,
		// Token: 0x04001072 RID: 4210
		[Token(Token = "0x4001072")]
		Peek = 2,
		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001073")]
		DontRoute = 4,
		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		MaxIOVectorLength = 16,
		// Token: 0x04001075 RID: 4213
		[Token(Token = "0x4001075")]
		Truncated = 256,
		// Token: 0x04001076 RID: 4214
		[Token(Token = "0x4001076")]
		ControlDataTruncated = 512,
		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001077")]
		Broadcast = 1024,
		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		Multicast = 2048,
		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		Partial = 32768
	}
}
