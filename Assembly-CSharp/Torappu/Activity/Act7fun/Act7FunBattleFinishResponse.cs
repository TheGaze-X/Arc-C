using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x02007198 RID: 29080
	[Token(Token = "0x2007198")]
	[LuaCallCSharp(GenFlag.No)]
	public class Act7FunBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0602943E RID: 169022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602943E")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act7FunBattleFinishResponse()
		{
		}

		// Token: 0x0403AEF2 RID: 241394
		[Token(Token = "0x403AEF2")]
		[FieldOffset(Offset = "0xA0")]
		public int completeState;

		// Token: 0x0403AEF3 RID: 241395
		[Token(Token = "0x403AEF3")]
		[FieldOffset(Offset = "0xA8")]
		public new List<RewardItemModel> rewards;

		// Token: 0x0403AEF4 RID: 241396
		[Token(Token = "0x403AEF4")]
		[FieldOffset(Offset = "0xB0")]
		public string[] unlockedStages;
	}
}
