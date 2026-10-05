using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007CE RID: 1998
	[Token(Token = "0x20007CE")]
	public class ConfirmMissionGroupResponse : PlayerDeltaResponse
	{
		// Token: 0x0600644F RID: 25679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600644F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ConfirmMissionGroupResponse()
		{
		}

		// Token: 0x040030DA RID: 12506
		[Token(Token = "0x40030DA")]
		[FieldOffset(Offset = "0x28")]
		public List<MissionGroupRewards> items;
	}
}
