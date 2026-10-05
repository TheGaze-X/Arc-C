using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018E0 RID: 6368
	[Token(Token = "0x20018E0")]
	public interface IDIYShop
	{
		// Token: 0x0600A098 RID: 41112
		[Token(Token = "0x600A098")]
		void RefreshData(Action<int> resultHandler);

		// Token: 0x0600A099 RID: 41113
		[Token(Token = "0x600A099")]
		IEnumerable<IDIYShopItem> EnumShopItems();

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x0600A09A RID: 41114
		[Token(Token = "0x17001270")]
		int currentCash { [Token(Token = "0x600A09A")] get; }

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x0600A09B RID: 41115
		[Token(Token = "0x17001271")]
		int currentFurnitureCoin { [Token(Token = "0x600A09B")] get; }

		// Token: 0x0600A09C RID: 41116
		[Token(Token = "0x600A09C")]
		void TryBuyShopItem(IDIYShopItem item, int cashBuyCount, int furnitureCoinBuyCount, Action<int> resultHandler);
	}
}
