using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001259 RID: 4697
	[Token(Token = "0x2001259")]
	public class RL03DevDifficultyNodePairInfo
	{
		// Token: 0x060071D0 RID: 29136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL03DevDifficultyNodePairInfo()
		{
		}

		// Token: 0x0400679B RID: 26523
		[Token(Token = "0x400679B")]
		[FieldOffset(Offset = "0x10")]
		public string frontNode;

		// Token: 0x0400679C RID: 26524
		[Token(Token = "0x400679C")]
		[FieldOffset(Offset = "0x18")]
		public string nextNode;
	}
}
