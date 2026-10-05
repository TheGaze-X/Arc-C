using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007442 RID: 29762
	[Token(Token = "0x2007442")]
	public class FoodHandbookClaimCollectRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A018 RID: 172056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A018")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public FoodHandbookClaimCollectRewardResponse()
		{
		}

		// Token: 0x0403C3D0 RID: 246736
		[Token(Token = "0x403C3D0")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> reward;
	}
}
