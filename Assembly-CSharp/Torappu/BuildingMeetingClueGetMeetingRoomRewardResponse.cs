using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	public class BuildingMeetingClueGetMeetingRoomRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x060062A5 RID: 25253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingMeetingClueGetMeetingRoomRewardResponse()
		{
		}

		// Token: 0x04002E32 RID: 11826
		[Token(Token = "0x4002E32")]
		[FieldOffset(Offset = "0x28")]
		public List<ItemBundle> rewards;
	}
}
