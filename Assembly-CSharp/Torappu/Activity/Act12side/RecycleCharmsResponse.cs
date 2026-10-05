using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act12side
{
	// Token: 0x02007A5A RID: 31322
	[Token(Token = "0x2007A5A")]
	public class RecycleCharmsResponse : PlayerDeltaResponse
	{
		// Token: 0x0602BE12 RID: 179730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BE12")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RecycleCharmsResponse()
		{
		}

		// Token: 0x0403F8BE RID: 260286
		[Token(Token = "0x403F8BE")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, int> settles;

		// Token: 0x0403F8BF RID: 260287
		[Token(Token = "0x403F8BF")]
		[FieldOffset(Offset = "0x30")]
		public List<RewardItemModel> coinGot;

		// Token: 0x0403F8C0 RID: 260288
		[Token(Token = "0x403F8C0")]
		[FieldOffset(Offset = "0x38")]
		public List<RewardItemModel> items;
	}
}
