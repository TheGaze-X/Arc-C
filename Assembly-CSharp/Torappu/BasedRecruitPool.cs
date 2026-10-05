using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001061 RID: 4193
	[Token(Token = "0x2001061")]
	[Serializable]
	public class BasedRecruitPool
	{
		// Token: 0x06006DEC RID: 28140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DEC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BasedRecruitPool()
		{
		}

		// Token: 0x0400593D RID: 22845
		[Token(Token = "0x400593D")]
		[FieldOffset(Offset = "0x10")]
		public BasedRecruitPool.RecruitConstants recruitConstants;

		// Token: 0x02001062 RID: 4194
		[Token(Token = "0x2001062")]
		public class RecruitCharacter
		{
			// Token: 0x06006DED RID: 28141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecruitCharacter()
			{
			}

			// Token: 0x0400593E RID: 22846
			[Token(Token = "0x400593E")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0400593F RID: 22847
			[Token(Token = "0x400593F")]
			[FieldOffset(Offset = "0x18")]
			public int weight;
		}

		// Token: 0x02001063 RID: 4195
		[Token(Token = "0x2001063")]
		public class RecruitConstants
		{
			// Token: 0x06006DEE RID: 28142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006DEE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecruitConstants()
			{
			}

			// Token: 0x04005940 RID: 22848
			[Token(Token = "0x4005940")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, int> tagPriceList;

			// Token: 0x04005941 RID: 22849
			[Token(Token = "0x4005941")]
			[FieldOffset(Offset = "0x18")]
			public int maxRecruitTime;
		}
	}
}
