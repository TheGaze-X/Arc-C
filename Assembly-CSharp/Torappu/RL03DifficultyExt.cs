using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001202 RID: 4610
	[Token(Token = "0x2001202")]
	public class RL03DifficultyExt
	{
		// Token: 0x06006FF8 RID: 28664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL03DifficultyExt()
		{
		}

		// Token: 0x04006330 RID: 25392
		[Token(Token = "0x4006330")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeDifficulty;

		// Token: 0x04006331 RID: 25393
		[Token(Token = "0x4006331")]
		[FieldOffset(Offset = "0x14")]
		public int grade;

		// Token: 0x04006332 RID: 25394
		[Token(Token = "0x4006332")]
		[FieldOffset(Offset = "0x18")]
		public float totemProb;

		// Token: 0x04006333 RID: 25395
		[Token(Token = "0x4006333")]
		[FieldOffset(Offset = "0x20")]
		public string relicDevLevel;

		// Token: 0x04006334 RID: 25396
		[Token(Token = "0x4006334")]
		[FieldOffset(Offset = "0x28")]
		public string[] buffs;

		// Token: 0x04006335 RID: 25397
		[Token(Token = "0x4006335")]
		[FieldOffset(Offset = "0x30")]
		public string[] buffDesc;
	}
}
