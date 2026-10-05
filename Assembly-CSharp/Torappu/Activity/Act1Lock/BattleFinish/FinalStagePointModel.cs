using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078F2 RID: 30962
	[Token(Token = "0x20078F2")]
	public class FinalStagePointModel : IHotfixable
	{
		// Token: 0x0602B6B6 RID: 177846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B6B6")]
		[Address(RVA = "0x275ADE0", Offset = "0x27599E0", VA = "0x18275ADE0")]
		public FinalStagePointModel()
		{
		}

		// Token: 0x0403EC90 RID: 257168
		[Token(Token = "0x403EC90")]
		[FieldOffset(Offset = "0x10")]
		public int clearPoint;

		// Token: 0x0403EC91 RID: 257169
		[Token(Token = "0x403EC91")]
		[FieldOffset(Offset = "0x18")]
		public List<FinalStageEnemyKillPointModel> enemyKillPointModels;

		// Token: 0x0403EC92 RID: 257170
		[Token(Token = "0x403EC92")]
		[FieldOffset(Offset = "0x20")]
		public int totalPoint;

		// Token: 0x0403EC93 RID: 257171
		[Token(Token = "0x403EC93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
