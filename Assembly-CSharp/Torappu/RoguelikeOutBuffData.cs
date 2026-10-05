using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200117F RID: 4479
	[Token(Token = "0x200117F")]
	public class RoguelikeOutBuffData
	{
		// Token: 0x06006F6D RID: 28525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F6D")]
		[Address(RVA = "0x2112150", Offset = "0x2110D50", VA = "0x182112150")]
		public RoguelikeOutBuffData()
		{
		}

		// Token: 0x0400600A RID: 24586
		[Token(Token = "0x400600A")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400600B RID: 24587
		[Token(Token = "0x400600B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, RoguelikeOuterBuff> buffs;
	}
}
