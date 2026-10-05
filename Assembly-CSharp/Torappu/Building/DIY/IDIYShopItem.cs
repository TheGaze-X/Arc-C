using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018DF RID: 6367
	[Token(Token = "0x20018DF")]
	public interface IDIYShopItem
	{
		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x0600A08D RID: 41101
		[Token(Token = "0x17001265")]
		string shopItemId { [Token(Token = "0x600A08D")] get; }

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x0600A08E RID: 41102
		[Token(Token = "0x17001266")]
		IDIYItem diyItem { [Token(Token = "0x600A08E")] get; }

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x0600A08F RID: 41103
		[Token(Token = "0x17001267")]
		int cashCost { [Token(Token = "0x600A08F")] get; }

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x0600A090 RID: 41104
		[Token(Token = "0x17001268")]
		int furnitureCoinCost { [Token(Token = "0x600A090")] get; }

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x0600A091 RID: 41105
		[Token(Token = "0x17001269")]
		int cashDiscount { [Token(Token = "0x600A091")] get; }

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x0600A092 RID: 41106
		[Token(Token = "0x1700126A")]
		int furnitureCoinDiscount { [Token(Token = "0x600A092")] get; }

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x0600A093 RID: 41107
		[Token(Token = "0x1700126B")]
		int cashOriginCost { [Token(Token = "0x600A093")] get; }

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x0600A094 RID: 41108
		[Token(Token = "0x1700126C")]
		int furnitureCoinOriginCost { [Token(Token = "0x600A094")] get; }

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x0600A095 RID: 41109
		[Token(Token = "0x1700126D")]
		int buyLimit { [Token(Token = "0x600A095")] get; }

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x0600A096 RID: 41110
		[Token(Token = "0x1700126E")]
		long startTime { [Token(Token = "0x600A096")] get; }

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x0600A097 RID: 41111
		[Token(Token = "0x1700126F")]
		long endTime { [Token(Token = "0x600A097")] get; }
	}
}
