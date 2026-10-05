using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001132 RID: 4402
	[Token(Token = "0x2001132")]
	public class RecalRuneConstData
	{
		// Token: 0x06006F08 RID: 28424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F08")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneConstData()
		{
		}

		// Token: 0x04005E5D RID: 24157
		[Token(Token = "0x4005E5D")]
		[FieldOffset(Offset = "0x10")]
		public int stageCountPerSeason;

		// Token: 0x04005E5E RID: 24158
		[Token(Token = "0x4005E5E")]
		[FieldOffset(Offset = "0x14")]
		public int juniorRewardMedalCount;

		// Token: 0x04005E5F RID: 24159
		[Token(Token = "0x4005E5F")]
		[FieldOffset(Offset = "0x18")]
		public int seniorRewardMedalCount;

		// Token: 0x04005E60 RID: 24160
		[Token(Token = "0x4005E60")]
		[FieldOffset(Offset = "0x20")]
		public List<string> unlockLevelIds;
	}
}
