using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001200 RID: 4608
	[Token(Token = "0x2001200")]
	public class RL01DifficultyExt
	{
		// Token: 0x06006FF6 RID: 28662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL01DifficultyExt()
		{
		}

		// Token: 0x0400632A RID: 25386
		[Token(Token = "0x400632A")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeDifficulty;

		// Token: 0x0400632B RID: 25387
		[Token(Token = "0x400632B")]
		[FieldOffset(Offset = "0x14")]
		public int grade;

		// Token: 0x0400632C RID: 25388
		[Token(Token = "0x400632C")]
		[FieldOffset(Offset = "0x18")]
		public string[] buffDesc;
	}
}
