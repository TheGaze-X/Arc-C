using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E7D RID: 3709
	[Token(Token = "0x2000E7D")]
	public class ActivityStageRewardData
	{
		// Token: 0x06006B48 RID: 27464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B48")]
		[Address(RVA = "0x1FFCBE0", Offset = "0x1FFB7E0", VA = "0x181FFCBE0")]
		public ActivityStageRewardData()
		{
		}

		// Token: 0x04004E14 RID: 19988
		[Token(Token = "0x4004E14")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, List<StageData.DisplayDetailRewards>> stageRewardsDict;
	}
}
