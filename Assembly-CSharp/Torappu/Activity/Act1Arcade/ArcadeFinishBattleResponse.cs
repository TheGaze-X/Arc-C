using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200791C RID: 31004
	[Token(Token = "0x200791C")]
	public class ArcadeFinishBattleResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0602B7EF RID: 178159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B7EF")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public ArcadeFinishBattleResponse()
		{
		}

		// Token: 0x0403EE2C RID: 257580
		[Token(Token = "0x403EE2C")]
		[FieldOffset(Offset = "0xA0")]
		public int score;

		// Token: 0x0403EE2D RID: 257581
		[Token(Token = "0x403EE2D")]
		[FieldOffset(Offset = "0xA4")]
		public int prevHighestScore;

		// Token: 0x0403EE2E RID: 257582
		[Token(Token = "0x403EE2E")]
		[FieldOffset(Offset = "0xA8")]
		public int milestoneBefore;

		// Token: 0x0403EE2F RID: 257583
		[Token(Token = "0x403EE2F")]
		[FieldOffset(Offset = "0xAC")]
		public int milestoneAdd;

		// Token: 0x0403EE30 RID: 257584
		[Token(Token = "0x403EE30")]
		[FieldOffset(Offset = "0xB0")]
		public bool isMileStoneMax;

		// Token: 0x0403EE31 RID: 257585
		[Token(Token = "0x403EE31")]
		[FieldOffset(Offset = "0xB8")]
		public List<string> unlockBadgeList;
	}
}
