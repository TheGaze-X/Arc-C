using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D11 RID: 19729
	[Token(Token = "0x2004D11")]
	public class GrocerySellResultStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D902 RID: 121090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D902")]
		[Address(RVA = "0x1718740", Offset = "0x1717340", VA = "0x181718740")]
		public void LoadData(string actId, PlayerActivity.PlayerAct27SideActivity.SellGoodState sellGoodState)
		{
		}

		// Token: 0x0601D903 RID: 121091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D903")]
		[Address(RVA = "0x1718800", Offset = "0x1717400", VA = "0x181718800")]
		public void UpdateSaleSettle(int fund, List<RewardItemModel> rewards)
		{
		}

		// Token: 0x0601D904 RID: 121092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D904")]
		[Address(RVA = "0x17188F0", Offset = "0x17174F0", VA = "0x1817188F0")]
		public GrocerySellResultStateBean()
		{
		}

		// Token: 0x04027096 RID: 159894
		[Token(Token = "0x4027096")]
		[FieldOffset(Offset = "0x10")]
		public GrocerySellResultProperty property;

		// Token: 0x04027097 RID: 159895
		[Token(Token = "0x4027097")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027098 RID: 159896
		[Token(Token = "0x4027098")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateSaleSettle;

		// Token: 0x04027099 RID: 159897
		[Token(Token = "0x4027099")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
