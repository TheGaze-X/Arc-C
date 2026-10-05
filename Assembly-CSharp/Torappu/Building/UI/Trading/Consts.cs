using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C26 RID: 7206
	[Token(Token = "0x2001C26")]
	public static class Consts
	{
		// Token: 0x0600B389 RID: 45961 RVA: 0x000442E0 File Offset: 0x000424E0
		[Token(Token = "0x600B389")]
		[Address(RVA = "0x32E3E40", Offset = "0x32E2A40", VA = "0x1832E3E40")]
		public static TradingOrderViewType TradingOrderType2ViewType(BuildingData.OrderType orderType)
		{
			return TradingOrderViewType.COMPOUND;
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x000442F8 File Offset: 0x000424F8
		[Token(Token = "0x600B38A")]
		[Address(RVA = "0x32E3E40", Offset = "0x32E2A40", VA = "0x1832E3E40")]
		public static BuildingData.OrderType TradingViewType2OrderType(TradingOrderViewType viewType)
		{
			return BuildingData.OrderType.O_COMPOUND;
		}
	}
}
