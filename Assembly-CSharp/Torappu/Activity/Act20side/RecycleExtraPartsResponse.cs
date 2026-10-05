using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200764C RID: 30284
	[Token(Token = "0x200764C")]
	public class RecycleExtraPartsResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A9AE RID: 174510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9AE")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RecycleExtraPartsResponse()
		{
		}

		// Token: 0x0403D57E RID: 251262
		[Token(Token = "0x403D57E")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
