using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B7B RID: 2939
	[Token(Token = "0x2000B7B")]
	public class PlayerActFunStage
	{
		// Token: 0x0600681A RID: 26650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600681A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerActFunStage()
		{
		}

		// Token: 0x04003CFF RID: 15615
		[Token(Token = "0x4003CFF")]
		[FieldOffset(Offset = "0x10")]
		public PlayerStageState state;

		// Token: 0x04003D00 RID: 15616
		[Token(Token = "0x4003D00")]
		[FieldOffset(Offset = "0x18")]
		public List<int> scores;
	}
}
