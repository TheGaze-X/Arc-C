using System;
using Il2CppDummyDll;
using Torappu.DataStream;

namespace Torappu
{
	// Token: 0x020005F6 RID: 1526
	[Token(Token = "0x20005F6")]
	public class AutoChessChatData : IStreamDeserialize
	{
		// Token: 0x060061FD RID: 25085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FD")]
		[Address(RVA = "0x1DE7F50", Offset = "0x1DE6B50", VA = "0x181DE7F50", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061FE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessChatData()
		{
		}

		// Token: 0x04002C14 RID: 11284
		[Token(Token = "0x4002C14")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04002C15 RID: 11285
		[Token(Token = "0x4002C15")]
		[FieldOffset(Offset = "0x18")]
		public string emojiGroup;

		// Token: 0x04002C16 RID: 11286
		[Token(Token = "0x4002C16")]
		[FieldOffset(Offset = "0x20")]
		public string emojiId;
	}
}
