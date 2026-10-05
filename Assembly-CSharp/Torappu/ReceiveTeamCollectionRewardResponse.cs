using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	public class ReceiveTeamCollectionRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x060063D2 RID: 25554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063D2")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ReceiveTeamCollectionRewardResponse()
		{
		}

		// Token: 0x04002FF4 RID: 12276
		[Token(Token = "0x4002FF4")]
		[FieldOffset(Offset = "0x28")]
		public List<HandBookMissionReward> items;
	}
}
