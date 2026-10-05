using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D2E RID: 27950
	[Token(Token = "0x2006D2E")]
	public class ActivityFirstExchangeShopRequest
	{
		// Token: 0x06027D99 RID: 163225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027D99")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityFirstExchangeShopRequest()
		{
		}

		// Token: 0x040387C2 RID: 231362
		[Token(Token = "0x40387C2")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040387C3 RID: 231363
		[Token(Token = "0x40387C3")]
		[FieldOffset(Offset = "0x18")]
		public string goodId;

		// Token: 0x040387C4 RID: 231364
		[Token(Token = "0x40387C4")]
		[FieldOffset(Offset = "0x20")]
		public int count;
	}
}
