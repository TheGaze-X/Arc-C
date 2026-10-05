using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C95 RID: 3221
	[Token(Token = "0x2000C95")]
	public class Act1VHalfIdleCharRankData
	{
		// Token: 0x06006971 RID: 26993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006971")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleCharRankData()
		{
		}

		// Token: 0x040041C2 RID: 16834
		[Token(Token = "0x40041C2")]
		[FieldOffset(Offset = "0x10")]
		public EvolvePhase evolvePhase;

		// Token: 0x040041C3 RID: 16835
		[Token(Token = "0x40041C3")]
		[FieldOffset(Offset = "0x18")]
		public List<Act1VHalfIdleCharRankData.CharRankData> expData;

		// Token: 0x02000C96 RID: 3222
		[Token(Token = "0x2000C96")]
		public class CharRankData
		{
			// Token: 0x06006972 RID: 26994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006972")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharRankData()
			{
			}

			// Token: 0x040041C4 RID: 16836
			[Token(Token = "0x40041C4")]
			[FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x040041C5 RID: 16837
			[Token(Token = "0x40041C5")]
			[FieldOffset(Offset = "0x14")]
			public int accumulatedExp;

			// Token: 0x040041C6 RID: 16838
			[Token(Token = "0x40041C6")]
			[FieldOffset(Offset = "0x18")]
			public int exp;
		}
	}
}
