using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001258 RID: 4696
	[Token(Token = "0x2001258")]
	public class RL03DevDifficultyNodeInfo
	{
		// Token: 0x060071CF RID: 29135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071CF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL03DevDifficultyNodeInfo()
		{
		}

		// Token: 0x04006798 RID: 26520
		[Token(Token = "0x4006798")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x04006799 RID: 26521
		[Token(Token = "0x4006799")]
		[FieldOffset(Offset = "0x18")]
		public List<RL03DevDifficultyNodePairInfo> nodeMap;

		// Token: 0x0400679A RID: 26522
		[Token(Token = "0x400679A")]
		[FieldOffset(Offset = "0x20")]
		public int enableGrade;
	}
}
