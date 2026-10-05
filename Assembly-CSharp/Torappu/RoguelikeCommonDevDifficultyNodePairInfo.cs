using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200125F RID: 4703
	[Token(Token = "0x200125F")]
	public class RoguelikeCommonDevDifficultyNodePairInfo
	{
		// Token: 0x060071D5 RID: 29141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeCommonDevDifficultyNodePairInfo()
		{
		}

		// Token: 0x040067BF RID: 26559
		[Token(Token = "0x40067BF")]
		[FieldOffset(Offset = "0x10")]
		public List<string> frontNodes;

		// Token: 0x040067C0 RID: 26560
		[Token(Token = "0x40067C0")]
		[FieldOffset(Offset = "0x18")]
		public string nextNode;
	}
}
