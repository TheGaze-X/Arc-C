using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200713C RID: 28988
	[Token(Token = "0x200713C")]
	public class ActAutoChessRewardInfoViewModel : IHotfixable
	{
		// Token: 0x0602926F RID: 168559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602926F")]
		[Address(RVA = "0x248CDE0", Offset = "0x248B9E0", VA = "0x18248CDE0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06029270 RID: 168560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029270")]
		[Address(RVA = "0x248D4B0", Offset = "0x248C0B0", VA = "0x18248D4B0")]
		public ActAutoChessRewardInfoViewModel()
		{
		}

		// Token: 0x0403AC69 RID: 240745
		[Token(Token = "0x403AC69")]
		[FieldOffset(Offset = "0x10")]
		public List<ActAutoChessSingleRoundRewardModel> roundList;

		// Token: 0x0403AC6A RID: 240746
		[Token(Token = "0x403AC6A")]
		[FieldOffset(Offset = "0x18")]
		public List<ActAutoChessModeRewardModel> modeList;

		// Token: 0x0403AC6B RID: 240747
		[Token(Token = "0x403AC6B")]
		[FieldOffset(Offset = "0x20")]
		public List<ActAutoChessDifficultyRewardModel> difficultyList;

		// Token: 0x0403AC6C RID: 240748
		[Token(Token = "0x403AC6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403AC6D RID: 240749
		[Token(Token = "0x403AC6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
