using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C21 RID: 7201
	[Token(Token = "0x2001C21")]
	public class TradingNegoiationBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B37D RID: 45949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B37D")]
		[Address(RVA = "0x32E6740", Offset = "0x32E5340", VA = "0x1832E6740")]
		public TradingNegoiationBean()
		{
		}

		// Token: 0x0400AED2 RID: 44754
		[Token(Token = "0x400AED2")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x0400AED3 RID: 44755
		[Token(Token = "0x400AED3")]
		[FieldOffset(Offset = "0x18")]
		public BuildingData.OrderType orderType;

		// Token: 0x0400AED4 RID: 44756
		[Token(Token = "0x400AED4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
