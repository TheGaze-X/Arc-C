using System;
using Il2CppDummyDll;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003D0C RID: 15628
	[Token(Token = "0x2003D0C")]
	public class TuningChatCommitRequest
	{
		// Token: 0x060185F2 RID: 99826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60185F2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TuningChatCommitRequest()
		{
		}

		// Token: 0x0401DCD8 RID: 122072
		[Token(Token = "0x401DCD8")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0401DCD9 RID: 122073
		[Token(Token = "0x401DCD9")]
		[FieldOffset(Offset = "0x18")]
		public string melodyId;

		// Token: 0x0401DCDA RID: 122074
		[Token(Token = "0x401DCDA")]
		[FieldOffset(Offset = "0x20")]
		public string npc;
	}
}
