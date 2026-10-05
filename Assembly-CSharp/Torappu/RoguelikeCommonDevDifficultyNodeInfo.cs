using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200125E RID: 4702
	[Token(Token = "0x200125E")]
	public class RoguelikeCommonDevDifficultyNodeInfo
	{
		// Token: 0x060071D3 RID: 29139 RVA: 0x00032B98 File Offset: 0x00030D98
		[Token(Token = "0x60071D3")]
		[Address(RVA = "0x1FF9BF0", Offset = "0x1FF87F0", VA = "0x181FF9BF0")]
		public bool ShouldSerializedecoId()
		{
			return default(bool);
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeCommonDevDifficultyNodeInfo()
		{
		}

		// Token: 0x040067B9 RID: 26553
		[Token(Token = "0x40067B9")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x040067BA RID: 26554
		[Token(Token = "0x40067BA")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeCommonDevDifficultyNodePairInfo> nodeMap;

		// Token: 0x040067BB RID: 26555
		[Token(Token = "0x40067BB")]
		[FieldOffset(Offset = "0x20")]
		public int enableGrade;

		// Token: 0x040067BC RID: 26556
		[Token(Token = "0x40067BC")]
		[FieldOffset(Offset = "0x28")]
		public string enableDesc;

		// Token: 0x040067BD RID: 26557
		[Token(Token = "0x40067BD")]
		[FieldOffset(Offset = "0x30")]
		public string lightId;

		// Token: 0x040067BE RID: 26558
		[Token(Token = "0x40067BE")]
		[FieldOffset(Offset = "0x38")]
		public string decoId;
	}
}
