using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079DE RID: 31198
	[Token(Token = "0x20079DE")]
	public class Act13SideLongTermMissionCommitResponse : PlayerDeltaResponse
	{
		// Token: 0x0602BBE9 RID: 179177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBE9")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act13SideLongTermMissionCommitResponse()
		{
		}

		// Token: 0x0403F48E RID: 259214
		[Token(Token = "0x403F48E")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;

		// Token: 0x0403F48F RID: 259215
		[Token(Token = "0x403F48F")]
		[FieldOffset(Offset = "0x30")]
		public Act13SidePrestigeService prestige;
	}
}
