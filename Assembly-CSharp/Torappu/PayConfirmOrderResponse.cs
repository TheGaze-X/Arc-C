using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000890 RID: 2192
	[Token(Token = "0x2000890")]
	public class PayConfirmOrderResponse : PlayerDeltaResponse
	{
		// Token: 0x06006530 RID: 25904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006530")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public PayConfirmOrderResponse()
		{
		}

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		[FieldOffset(Offset = "0x30")]
		public string goodId;

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		[FieldOffset(Offset = "0x38")]
		public PayConfirmOrderResponse.Good receiveItems;

		// Token: 0x02000891 RID: 2193
		[Token(Token = "0x2000891")]
		public struct Good
		{
			// Token: 0x0400322D RID: 12845
			[Token(Token = "0x400322D")]
			[FieldOffset(Offset = "0x0")]
			public List<RewardItemModel> items;

			// Token: 0x0400322E RID: 12846
			[Token(Token = "0x400322E")]
			[FieldOffset(Offset = "0x8")]
			public List<RewardItemModel> checkInItems;
		}
	}
}
