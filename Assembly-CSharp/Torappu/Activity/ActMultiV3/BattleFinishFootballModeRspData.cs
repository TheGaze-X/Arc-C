using System;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ECE RID: 28366
	[Token(Token = "0x2006ECE")]
	public class BattleFinishFootballModeRspData
	{
		// Token: 0x06028545 RID: 165189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028545")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleFinishFootballModeRspData()
		{
		}

		// Token: 0x04039532 RID: 234802
		[Token(Token = "0x4039532")]
		[FieldOffset(Offset = "0x10")]
		public int goalMine;

		// Token: 0x04039533 RID: 234803
		[Token(Token = "0x4039533")]
		[FieldOffset(Offset = "0x14")]
		public int goalOther;

		// Token: 0x04039534 RID: 234804
		[Token(Token = "0x4039534")]
		[FieldOffset(Offset = "0x18")]
		public bool newGoal;
	}
}
