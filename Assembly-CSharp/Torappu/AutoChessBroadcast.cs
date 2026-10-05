using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu
{
	// Token: 0x020005F7 RID: 1527
	[Token(Token = "0x20005F7")]
	public class AutoChessBroadcast : IStreamDeserialize
	{
		// Token: 0x060061FF RID: 25087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FF")]
		[Address(RVA = "0x1DE7E80", Offset = "0x1DE6A80", VA = "0x181DE7E80", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006200")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessBroadcast()
		{
		}

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x10")]
		public int uIdx;

		// Token: 0x04002C18 RID: 11288
		[Token(Token = "0x4002C18")]
		[FieldOffset(Offset = "0x18")]
		public string broadcastId;

		// Token: 0x04002C19 RID: 11289
		[Token(Token = "0x4002C19")]
		[FieldOffset(Offset = "0x20")]
		public List<string> strParams;

		// Token: 0x04002C1A RID: 11290
		[Token(Token = "0x4002C1A")]
		[FieldOffset(Offset = "0x28")]
		public List<int> intParams;
	}
}
