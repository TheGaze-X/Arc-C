using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000290 RID: 656
	[Token(Token = "0x2000290")]
	internal class ReceiveState
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001278")]
		[Address(RVA = "0x51B4A60", Offset = "0x51B3660", VA = "0x1851B4A60")]
		internal ReceiveState(CommandStream connection)
		{
		}

		// Token: 0x04000954 RID: 2388
		[Token(Token = "0x4000954")]
		[FieldOffset(Offset = "0x10")]
		internal ResponseDescription Resp;

		// Token: 0x04000955 RID: 2389
		[Token(Token = "0x4000955")]
		[FieldOffset(Offset = "0x18")]
		internal int ValidThrough;

		// Token: 0x04000956 RID: 2390
		[Token(Token = "0x4000956")]
		[FieldOffset(Offset = "0x20")]
		internal byte[] Buffer;

		// Token: 0x04000957 RID: 2391
		[Token(Token = "0x4000957")]
		[FieldOffset(Offset = "0x28")]
		internal CommandStream Connection;
	}
}
