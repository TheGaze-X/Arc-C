using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007644 RID: 30276
	[Token(Token = "0x2007644")]
	public class CarExhibitionPickResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A9A6 RID: 174502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9A6")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CarExhibitionPickResponse()
		{
		}

		// Token: 0x0403D577 RID: 251255
		[Token(Token = "0x403D577")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
