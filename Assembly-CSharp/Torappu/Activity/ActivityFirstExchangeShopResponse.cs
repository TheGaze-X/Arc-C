using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D2F RID: 27951
	[Token(Token = "0x2006D2F")]
	public class ActivityFirstExchangeShopResponse : PlayerDeltaResponse
	{
		// Token: 0x06027D9A RID: 163226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D9A")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ActivityFirstExchangeShopResponse()
		{
		}

		// Token: 0x040387C5 RID: 231365
		[Token(Token = "0x40387C5")]
		[FieldOffset(Offset = "0x28")]
		public RewardItemModel item;
	}
}
