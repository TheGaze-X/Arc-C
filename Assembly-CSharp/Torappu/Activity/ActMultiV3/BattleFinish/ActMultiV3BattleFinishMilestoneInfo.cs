using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x0200709B RID: 28827
	[Token(Token = "0x200709B")]
	public struct ActMultiV3BattleFinishMilestoneInfo
	{
		// Token: 0x0403A757 RID: 239447
		[Token(Token = "0x403A757")]
		[FieldOffset(Offset = "0x0")]
		public int level;

		// Token: 0x0403A758 RID: 239448
		[Token(Token = "0x403A758")]
		[FieldOffset(Offset = "0x4")]
		public int progressMax;

		// Token: 0x0403A759 RID: 239449
		[Token(Token = "0x403A759")]
		[FieldOffset(Offset = "0x8")]
		public int progressCurr;

		// Token: 0x0403A75A RID: 239450
		[Token(Token = "0x403A75A")]
		[FieldOffset(Offset = "0xC")]
		public bool isMax;
	}
}
