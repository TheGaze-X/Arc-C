using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C9C RID: 3228
	[Token(Token = "0x2000C9C")]
	public class Act1VHalfIdleCharSkillRankData
	{
		// Token: 0x06006978 RID: 27000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006978")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleCharSkillRankData()
		{
		}

		// Token: 0x040041D6 RID: 16854
		[Token(Token = "0x40041D6")]
		[FieldOffset(Offset = "0x10")]
		public RarityRank rarity;

		// Token: 0x040041D7 RID: 16855
		[Token(Token = "0x40041D7")]
		[FieldOffset(Offset = "0x18")]
		public List<Act1VHalfIdleCharSkillRankData.SkillRankData> skillRankData;

		// Token: 0x02000C9D RID: 3229
		[Token(Token = "0x2000C9D")]
		public class SkillRankData
		{
			// Token: 0x06006979 RID: 27001 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006979")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SkillRankData()
			{
			}

			// Token: 0x040041D8 RID: 16856
			[Token(Token = "0x40041D8")]
			[FieldOffset(Offset = "0x10")]
			public int skillLevel;

			// Token: 0x040041D9 RID: 16857
			[Token(Token = "0x40041D9")]
			[FieldOffset(Offset = "0x14")]
			public int cost;

			// Token: 0x040041DA RID: 16858
			[Token(Token = "0x40041DA")]
			[FieldOffset(Offset = "0x18")]
			public int accumulatedCost;
		}
	}
}
