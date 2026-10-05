using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x020079E0 RID: 31200
	[Token(Token = "0x20079E0")]
	public class Act13SideLongTermMissionAllCommitResponse : PlayerDeltaResponse
	{
		// Token: 0x0602BBEB RID: 179179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BBEB")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act13SideLongTermMissionAllCommitResponse()
		{
		}

		// Token: 0x0403F492 RID: 259218
		[Token(Token = "0x403F492")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;

		// Token: 0x0403F493 RID: 259219
		[Token(Token = "0x403F493")]
		[FieldOffset(Offset = "0x30")]
		public Act13SidePrestigeService prestige;

		// Token: 0x0403F494 RID: 259220
		[Token(Token = "0x403F494")]
		[FieldOffset(Offset = "0x38")]
		public List<Act13SideEachMissionInfo> each;
	}
}
