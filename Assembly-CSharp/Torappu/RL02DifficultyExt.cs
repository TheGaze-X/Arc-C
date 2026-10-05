using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001201 RID: 4609
	[Token(Token = "0x2001201")]
	public class RL02DifficultyExt
	{
		// Token: 0x06006FF7 RID: 28663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL02DifficultyExt()
		{
		}

		// Token: 0x0400632D RID: 25389
		[Token(Token = "0x400632D")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeDifficulty;

		// Token: 0x0400632E RID: 25390
		[Token(Token = "0x400632E")]
		[FieldOffset(Offset = "0x14")]
		public int grade;

		// Token: 0x0400632F RID: 25391
		[Token(Token = "0x400632F")]
		[FieldOffset(Offset = "0x18")]
		public string[] buffDesc;
	}
}
