using System;
using Il2CppDummyDll;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DDD RID: 28125
	[Token(Token = "0x2006DDD")]
	public struct BattleFinishMilestoneInfo
	{
		// Token: 0x04038C9D RID: 232605
		[Token(Token = "0x4038C9D")]
		[FieldOffset(Offset = "0x0")]
		public int level;

		// Token: 0x04038C9E RID: 232606
		[Token(Token = "0x4038C9E")]
		[FieldOffset(Offset = "0x4")]
		public int progressMax;

		// Token: 0x04038C9F RID: 232607
		[Token(Token = "0x4038C9F")]
		[FieldOffset(Offset = "0x8")]
		public int progressCurr;

		// Token: 0x04038CA0 RID: 232608
		[Token(Token = "0x4038CA0")]
		[FieldOffset(Offset = "0xC")]
		public bool isMax;
	}
}
