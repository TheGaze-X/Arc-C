using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C97 RID: 3223
	[Token(Token = "0x2000C97")]
	public class Act1VHalfIdleCharEvolveData
	{
		// Token: 0x06006973 RID: 26995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006973")]
		[Address(RVA = "0x1FF2C50", Offset = "0x1FF1850", VA = "0x181FF2C50")]
		public Act1VHalfIdleCharEvolveData()
		{
		}

		// Token: 0x040041C7 RID: 16839
		[Token(Token = "0x40041C7")]
		[FieldOffset(Offset = "0x10")]
		public RarityRank rarity;

		// Token: 0x040041C8 RID: 16840
		[Token(Token = "0x40041C8")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act1VHalfIdleCharEvolveData.ProfessionCharEvolveData> professionEvolveData;

		// Token: 0x02000C98 RID: 3224
		[Token(Token = "0x2000C98")]
		public class EvolveData
		{
			// Token: 0x06006974 RID: 26996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006974")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EvolveData()
			{
			}

			// Token: 0x040041C9 RID: 16841
			[Token(Token = "0x40041C9")]
			[FieldOffset(Offset = "0x10")]
			public EvolvePhase evolvePhase;

			// Token: 0x040041CA RID: 16842
			[Token(Token = "0x40041CA")]
			[FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x040041CB RID: 16843
			[Token(Token = "0x40041CB")]
			[FieldOffset(Offset = "0x20")]
			public int itemCount;

			// Token: 0x040041CC RID: 16844
			[Token(Token = "0x40041CC")]
			[FieldOffset(Offset = "0x28")]
			public string rebateItemId;

			// Token: 0x040041CD RID: 16845
			[Token(Token = "0x40041CD")]
			[FieldOffset(Offset = "0x30")]
			public int rebateItemCount;
		}

		// Token: 0x02000C99 RID: 3225
		[Token(Token = "0x2000C99")]
		public class ProfessionCharEvolveData
		{
			// Token: 0x06006975 RID: 26997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006975")]
			[Address(RVA = "0x200C8F0", Offset = "0x200B4F0", VA = "0x18200C8F0")]
			public ProfessionCharEvolveData()
			{
			}

			// Token: 0x040041CE RID: 16846
			[Token(Token = "0x40041CE")]
			[FieldOffset(Offset = "0x10")]
			public ProfessionCategory profession;

			// Token: 0x040041CF RID: 16847
			[Token(Token = "0x40041CF")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, Act1VHalfIdleCharEvolveData.EvolveData> evolveData;
		}
	}
}
