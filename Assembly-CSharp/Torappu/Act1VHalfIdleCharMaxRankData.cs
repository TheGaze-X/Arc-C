using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C9A RID: 3226
	[Token(Token = "0x2000C9A")]
	public class Act1VHalfIdleCharMaxRankData
	{
		// Token: 0x06006976 RID: 26998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006976")]
		[Address(RVA = "0x1FF2CE0", Offset = "0x1FF18E0", VA = "0x181FF2CE0")]
		public Act1VHalfIdleCharMaxRankData()
		{
		}

		// Token: 0x040041D0 RID: 16848
		[Token(Token = "0x40041D0")]
		[FieldOffset(Offset = "0x10")]
		public RarityRank rarity;

		// Token: 0x040041D1 RID: 16849
		[Token(Token = "0x40041D1")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act1VHalfIdleCharMaxRankData.MaxRankData> maxRankData;

		// Token: 0x040041D2 RID: 16850
		[Token(Token = "0x40041D2")]
		[FieldOffset(Offset = "0x20")]
		public EvolvePhase maxEvolvePhase;

		// Token: 0x02000C9B RID: 3227
		[Token(Token = "0x2000C9B")]
		public class MaxRankData
		{
			// Token: 0x06006977 RID: 26999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006977")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MaxRankData()
			{
			}

			// Token: 0x040041D3 RID: 16851
			[Token(Token = "0x40041D3")]
			[FieldOffset(Offset = "0x10")]
			public EvolvePhase evolvePhase;

			// Token: 0x040041D4 RID: 16852
			[Token(Token = "0x40041D4")]
			[FieldOffset(Offset = "0x14")]
			public int maxLevel;

			// Token: 0x040041D5 RID: 16853
			[Token(Token = "0x40041D5")]
			[FieldOffset(Offset = "0x18")]
			public int maxSkillRank;
		}
	}
}
