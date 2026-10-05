using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F66 RID: 16230
	[Token(Token = "0x2003F66")]
	public class SiracusaTaskRingGainRewardResponse : PlayerDeltaResponse
	{
		// Token: 0x0601930B RID: 103179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601930B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public SiracusaTaskRingGainRewardResponse()
		{
		}

		// Token: 0x0401F3C1 RID: 127937
		[Token(Token = "0x401F3C1")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
