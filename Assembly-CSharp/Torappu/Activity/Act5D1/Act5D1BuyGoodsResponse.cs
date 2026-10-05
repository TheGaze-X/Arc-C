using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007220 RID: 29216
	[Token(Token = "0x2007220")]
	public class Act5D1BuyGoodsResponse : PlayerDeltaResponse
	{
		// Token: 0x0602969B RID: 169627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602969B")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act5D1BuyGoodsResponse()
		{
		}

		// Token: 0x0403B249 RID: 242249
		[Token(Token = "0x403B249")]
		[FieldOffset(Offset = "0x28")]
		public RewardItemModel item;
	}
}
