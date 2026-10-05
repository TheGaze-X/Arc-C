using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001204 RID: 4612
	[Token(Token = "0x2001204")]
	public class RL05DifficultyExt
	{
		// Token: 0x06006FFA RID: 28666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL05DifficultyExt()
		{
		}

		// Token: 0x0400633E RID: 25406
		[Token(Token = "0x400633E")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeDifficulty;

		// Token: 0x0400633F RID: 25407
		[Token(Token = "0x400633F")]
		[FieldOffset(Offset = "0x14")]
		public int grade;

		// Token: 0x04006340 RID: 25408
		[Token(Token = "0x4006340")]
		[FieldOffset(Offset = "0x18")]
		public string[] buffs;

		// Token: 0x04006341 RID: 25409
		[Token(Token = "0x4006341")]
		[FieldOffset(Offset = "0x20")]
		public string[] buffDesc;

		// Token: 0x04006342 RID: 25410
		[Token(Token = "0x4006342")]
		[FieldOffset(Offset = "0x28")]
		public string leftWrathDesc;

		// Token: 0x04006343 RID: 25411
		[Token(Token = "0x4006343")]
		[FieldOffset(Offset = "0x30")]
		public string relicDevLevel;

		// Token: 0x04006344 RID: 25412
		[Token(Token = "0x4006344")]
		[FieldOffset(Offset = "0x38")]
		public string gildProbDisplay;

		// Token: 0x04006345 RID: 25413
		[Token(Token = "0x4006345")]
		[FieldOffset(Offset = "0x40")]
		public string skyStepDescription;
	}
}
