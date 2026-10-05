using System;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200617B RID: 24955
	[Token(Token = "0x200617B")]
	public class BossRushFinishBattleResponse : DefaultFinishBattleResponse
	{
		// Token: 0x06024010 RID: 147472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024010")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public BossRushFinishBattleResponse()
		{
		}

		// Token: 0x04032045 RID: 204869
		[Token(Token = "0x4032045")]
		[FieldOffset(Offset = "0xA0")]
		public int wave;

		// Token: 0x04032046 RID: 204870
		[Token(Token = "0x4032046")]
		[FieldOffset(Offset = "0xA4")]
		public int milestoneBefore;

		// Token: 0x04032047 RID: 204871
		[Token(Token = "0x4032047")]
		[FieldOffset(Offset = "0xA8")]
		public int milestoneAdd;

		// Token: 0x04032048 RID: 204872
		[Token(Token = "0x4032048")]
		[FieldOffset(Offset = "0xAC")]
		public bool isMilestoneMax;

		// Token: 0x04032049 RID: 204873
		[Token(Token = "0x4032049")]
		[FieldOffset(Offset = "0xB0")]
		public int tokenAdd;

		// Token: 0x0403204A RID: 204874
		[Token(Token = "0x403204A")]
		[FieldOffset(Offset = "0xB4")]
		public bool isTokenMax;
	}
}
