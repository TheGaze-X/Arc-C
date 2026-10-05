using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052B6 RID: 21174
	[Token(Token = "0x20052B6")]
	public class RoguelikeEndingScoreViewModel : IHotfixable
	{
		// Token: 0x0601F3BC RID: 127932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3BC")]
		[Address(RVA = "0x18F85D0", Offset = "0x18F71D0", VA = "0x1818F85D0")]
		public void LoadData(List<List<int>> statsDetails)
		{
		}

		// Token: 0x0601F3BD RID: 127933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3BD")]
		[Address(RVA = "0x18F89A0", Offset = "0x18F75A0", VA = "0x1818F89A0")]
		public RoguelikeEndingScoreViewModel()
		{
		}

		// Token: 0x04029F05 RID: 171781
		[Token(Token = "0x4029F05")]
		[FieldOffset(Offset = "0x10")]
		public int crossedCount;

		// Token: 0x04029F06 RID: 171782
		[Token(Token = "0x4029F06")]
		[FieldOffset(Offset = "0x14")]
		public int crossedScore;

		// Token: 0x04029F07 RID: 171783
		[Token(Token = "0x4029F07")]
		[FieldOffset(Offset = "0x18")]
		public int arrivedCount;

		// Token: 0x04029F08 RID: 171784
		[Token(Token = "0x4029F08")]
		[FieldOffset(Offset = "0x1C")]
		public int arrivedScore;

		// Token: 0x04029F09 RID: 171785
		[Token(Token = "0x4029F09")]
		[FieldOffset(Offset = "0x20")]
		public int battleNormalCount;

		// Token: 0x04029F0A RID: 171786
		[Token(Token = "0x4029F0A")]
		[FieldOffset(Offset = "0x24")]
		public int battleNormalScore;

		// Token: 0x04029F0B RID: 171787
		[Token(Token = "0x4029F0B")]
		[FieldOffset(Offset = "0x28")]
		public int battleEliteCount;

		// Token: 0x04029F0C RID: 171788
		[Token(Token = "0x4029F0C")]
		[FieldOffset(Offset = "0x2C")]
		public int battleEliteScore;

		// Token: 0x04029F0D RID: 171789
		[Token(Token = "0x4029F0D")]
		[FieldOffset(Offset = "0x30")]
		public int battleBossCount;

		// Token: 0x04029F0E RID: 171790
		[Token(Token = "0x4029F0E")]
		[FieldOffset(Offset = "0x34")]
		public int battleBossScore;

		// Token: 0x04029F0F RID: 171791
		[Token(Token = "0x4029F0F")]
		[FieldOffset(Offset = "0x38")]
		public int itemCount;

		// Token: 0x04029F10 RID: 171792
		[Token(Token = "0x4029F10")]
		[FieldOffset(Offset = "0x3C")]
		public int itemScore;

		// Token: 0x04029F11 RID: 171793
		[Token(Token = "0x4029F11")]
		[FieldOffset(Offset = "0x40")]
		public int recruitCount;

		// Token: 0x04029F12 RID: 171794
		[Token(Token = "0x4029F12")]
		[FieldOffset(Offset = "0x44")]
		public int recruitScore;

		// Token: 0x04029F13 RID: 171795
		[Token(Token = "0x4029F13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029F14 RID: 171796
		[Token(Token = "0x4029F14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052B7 RID: 21175
		[Token(Token = "0x20052B7")]
		public enum EndingStatsType
		{
			// Token: 0x04029F16 RID: 171798
			[Token(Token = "0x4029F16")]
			STATS_CROSSED,
			// Token: 0x04029F17 RID: 171799
			[Token(Token = "0x4029F17")]
			STATS_ARRIVED,
			// Token: 0x04029F18 RID: 171800
			[Token(Token = "0x4029F18")]
			STATS_BATTLE_NORMAL,
			// Token: 0x04029F19 RID: 171801
			[Token(Token = "0x4029F19")]
			STATS_BATTLE_ELITE,
			// Token: 0x04029F1A RID: 171802
			[Token(Token = "0x4029F1A")]
			STATS_BATTLE_BOSS,
			// Token: 0x04029F1B RID: 171803
			[Token(Token = "0x4029F1B")]
			STATS_ITEM,
			// Token: 0x04029F1C RID: 171804
			[Token(Token = "0x4029F1C")]
			STATS_RECRUIT
		}

		// Token: 0x020052B8 RID: 21176
		[Token(Token = "0x20052B8")]
		public enum EndingStatsNumType
		{
			// Token: 0x04029F1E RID: 171806
			[Token(Token = "0x4029F1E")]
			TYPE_COUNT,
			// Token: 0x04029F1F RID: 171807
			[Token(Token = "0x4029F1F")]
			TYPE_SCORE
		}
	}
}
