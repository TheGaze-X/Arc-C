using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012C4 RID: 4804
	[Token(Token = "0x20012C4")]
	public class SandboxV2EventChoiceData
	{
		// Token: 0x0600723D RID: 29245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2EventChoiceData()
		{
		}

		// Token: 0x04006A1F RID: 27167
		[Token(Token = "0x4006A1F")]
		[FieldOffset(Offset = "0x10")]
		public string choiceId;

		// Token: 0x04006A20 RID: 27168
		[Token(Token = "0x4006A20")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2EventChoiceType type;

		// Token: 0x04006A21 RID: 27169
		[Token(Token = "0x4006A21")]
		[FieldOffset(Offset = "0x1C")]
		public int costAction;

		// Token: 0x04006A22 RID: 27170
		[Token(Token = "0x4006A22")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x04006A23 RID: 27171
		[Token(Token = "0x4006A23")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x04006A24 RID: 27172
		[Token(Token = "0x4006A24")]
		[FieldOffset(Offset = "0x30")]
		public string expeditionId;
	}
}
