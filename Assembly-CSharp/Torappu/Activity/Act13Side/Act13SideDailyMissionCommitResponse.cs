using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079D8 RID: 31192
	[Token(Token = "0x20079D8")]
	public class Act13SideDailyMissionCommitResponse : PlayerDeltaResponse
	{
		// Token: 0x0602BBE3 RID: 179171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBE3")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act13SideDailyMissionCommitResponse()
		{
		}

		// Token: 0x0403F482 RID: 259202
		[Token(Token = "0x403F482")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;

		// Token: 0x0403F483 RID: 259203
		[Token(Token = "0x403F483")]
		[FieldOffset(Offset = "0x30")]
		public Act13SidePrestigeService prestige;

		// Token: 0x0403F484 RID: 259204
		[Token(Token = "0x403F484")]
		[FieldOffset(Offset = "0x38")]
		public int[] random;
	}
}
