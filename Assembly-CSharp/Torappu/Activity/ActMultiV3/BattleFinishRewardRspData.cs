using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED2 RID: 28370
	[Token(Token = "0x2006ED2")]
	public class BattleFinishRewardRspData
	{
		// Token: 0x06028549 RID: 165193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028549")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleFinishRewardRspData()
		{
		}

		// Token: 0x0403953F RID: 234815
		[Token(Token = "0x403953F")]
		[FieldOffset(Offset = "0x10")]
		public List<ItemBundle> item;

		// Token: 0x04039540 RID: 234816
		[Token(Token = "0x4039540")]
		[FieldOffset(Offset = "0x18")]
		public int milestoneAdd;

		// Token: 0x04039541 RID: 234817
		[Token(Token = "0x4039541")]
		[FieldOffset(Offset = "0x1C")]
		public bool gainDailyReward;
	}
}
