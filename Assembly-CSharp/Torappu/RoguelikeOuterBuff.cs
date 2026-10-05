using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001181 RID: 4481
	[Token(Token = "0x2001181")]
	public class RoguelikeOuterBuff : RoguelikeBuff
	{
		// Token: 0x06006F6F RID: 28527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeOuterBuff()
		{
		}

		// Token: 0x0400600E RID: 24590
		[Token(Token = "0x400600E")]
		[FieldOffset(Offset = "0x20")]
		public string buffId;

		// Token: 0x0400600F RID: 24591
		[Token(Token = "0x400600F")]
		[FieldOffset(Offset = "0x28")]
		public int level;

		// Token: 0x04006010 RID: 24592
		[Token(Token = "0x4006010")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x04006011 RID: 24593
		[Token(Token = "0x4006011")]
		[FieldOffset(Offset = "0x38")]
		public string iconId;

		// Token: 0x04006012 RID: 24594
		[Token(Token = "0x4006012")]
		[FieldOffset(Offset = "0x40")]
		public string description;

		// Token: 0x04006013 RID: 24595
		[Token(Token = "0x4006013")]
		[FieldOffset(Offset = "0x48")]
		public string usage;
	}
}
