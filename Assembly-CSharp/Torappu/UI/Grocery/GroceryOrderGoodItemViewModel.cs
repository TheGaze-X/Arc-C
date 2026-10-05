using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CDD RID: 19677
	[Token(Token = "0x2004CDD")]
	public class GroceryOrderGoodItemViewModel : IHotfixable
	{
		// Token: 0x1700452E RID: 17710
		// (get) Token: 0x0601D7B2 RID: 120754 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D7B3 RID: 120755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700452E")]
		public string goodId
		{
			[Token(Token = "0x601D7B2")]
			[Address(RVA = "0x16FDD00", Offset = "0x16FC900", VA = "0x1816FDD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D7B3")]
			[Address(RVA = "0x16FDF70", Offset = "0x16FCB70", VA = "0x1816FDF70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700452F RID: 17711
		// (get) Token: 0x0601D7B4 RID: 120756 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D7B5 RID: 120757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700452F")]
		public string goodName
		{
			[Token(Token = "0x601D7B4")]
			[Address(RVA = "0x16FDD60", Offset = "0x16FC960", VA = "0x1816FDD60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D7B5")]
			[Address(RVA = "0x16FDFF0", Offset = "0x16FCBF0", VA = "0x1816FDFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004530 RID: 17712
		// (get) Token: 0x0601D7B6 RID: 120758 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D7B7 RID: 120759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004530")]
		public string goodIconId
		{
			[Token(Token = "0x601D7B6")]
			[Address(RVA = "0x16FDCA0", Offset = "0x16FC8A0", VA = "0x1816FDCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D7B7")]
			[Address(RVA = "0x16FDEF0", Offset = "0x16FCAF0", VA = "0x1816FDEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x0601D7B8 RID: 120760 RVA: 0x000AB9F0 File Offset: 0x000A9BF0
		// (set) Token: 0x0601D7B9 RID: 120761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004531")]
		public int buyerCount
		{
			[Token(Token = "0x601D7B8")]
			[Address(RVA = "0x16FDC40", Offset = "0x16FC840", VA = "0x1816FDC40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D7B9")]
			[Address(RVA = "0x16FDE80", Offset = "0x16FCA80", VA = "0x1816FDE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x0601D7BA RID: 120762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004532")]
		public List<GroceryOrderOtherShopItemViewModel> otherShopItemViewModels
		{
			[Token(Token = "0x601D7BA")]
			[Address(RVA = "0x16FDDC0", Offset = "0x16FC9C0", VA = "0x1816FDDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004533 RID: 17715
		// (get) Token: 0x0601D7BB RID: 120763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004533")]
		public GroceryOrderSelfShopViewModel selfShopItemViewModel
		{
			[Token(Token = "0x601D7BB")]
			[Address(RVA = "0x16FDE20", Offset = "0x16FCA20", VA = "0x1816FDE20")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D7BC RID: 120764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7BC")]
		[Address(RVA = "0x16FB320", Offset = "0x16F9F20", VA = "0x1816FB320")]
		public void LoadData(string actId, string playerShopId, string id, Act27SideData actData, PlayerActivity.PlayerAct27SideActivity playerAct27SideActivity)
		{
		}

		// Token: 0x0601D7BD RID: 120765 RVA: 0x000ABA08 File Offset: 0x000A9C08
		[Token(Token = "0x601D7BD")]
		[Address(RVA = "0x16FB110", Offset = "0x16F9D10", VA = "0x1816FB110")]
		public bool IsOtherShopCanInquire(string shopId)
		{
			return default(bool);
		}

		// Token: 0x0601D7BE RID: 120766 RVA: 0x000ABA20 File Offset: 0x000A9C20
		[Token(Token = "0x601D7BE")]
		[Address(RVA = "0x16FAEF0", Offset = "0x16F9AF0", VA = "0x1816FAEF0")]
		public GroceryOrderOtherShopStatus GetOtherShopInquireStatus(string shopId)
		{
			return GroceryOrderOtherShopStatus.NONE;
		}

		// Token: 0x0601D7BF RID: 120767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7BF")]
		[Address(RVA = "0x16FB080", Offset = "0x16F9C80", VA = "0x1816FB080")]
		public void InquireOtherShop()
		{
		}

		// Token: 0x0601D7C0 RID: 120768 RVA: 0x000ABA38 File Offset: 0x000A9C38
		[Token(Token = "0x601D7C0")]
		[Address(RVA = "0x16FB690", Offset = "0x16FA290", VA = "0x1816FB690")]
		public bool RefreshMyShopStrategy(int strategyIndex)
		{
			return default(bool);
		}

		// Token: 0x0601D7C1 RID: 120769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C1")]
		[Address(RVA = "0x16FBCB0", Offset = "0x16FA8B0", VA = "0x1816FBCB0")]
		public void TryRefreshOtherShopIfCanInquire(PlayerActivity.PlayerAct27SideActivity.InquireInfo inquireInfo)
		{
		}

		// Token: 0x0601D7C2 RID: 120770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C2")]
		[Address(RVA = "0x16FBDC0", Offset = "0x16FA9C0", VA = "0x1816FBDC0")]
		private void _LoadShopData(string playerShopId, Act27SideData.Act27SideGoodData goodData, List<string> strategyNameList, Dictionary<string, Act27SideData.Act27SideShopData> shopDataMap)
		{
		}

		// Token: 0x0601D7C3 RID: 120771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C3")]
		[Address(RVA = "0x16FC390", Offset = "0x16FAF90", VA = "0x1816FC390")]
		private void _RefreshPlayerData()
		{
		}

		// Token: 0x0601D7C4 RID: 120772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C4")]
		[Address(RVA = "0x16FCDD0", Offset = "0x16FB9D0", VA = "0x1816FCDD0")]
		private void _RefreshStrategyInfosFromPlayerData(PlayerActivity.PlayerAct27SideActivity playerActivity)
		{
		}

		// Token: 0x0601D7C5 RID: 120773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C5")]
		[Address(RVA = "0x16FCC30", Offset = "0x16FB830", VA = "0x1816FCC30")]
		private void _RefreshPrePurchaseInfoList(Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PrePurchaseInfo[]> prePurchaseDic)
		{
		}

		// Token: 0x0601D7C6 RID: 120774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C6")]
		[Address(RVA = "0x16FD650", Offset = "0x16FC250", VA = "0x1816FD650")]
		private void _TryRefreshMyShopStock(Dictionary<string, int> stockDic)
		{
		}

		// Token: 0x0601D7C7 RID: 120775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C7")]
		[Address(RVA = "0x16FD9A0", Offset = "0x16FC5A0", VA = "0x1816FD9A0")]
		private void _TryRefreshOtherShopStrategy(Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PurchaseInfo> purchaseInfoDic)
		{
		}

		// Token: 0x0601D7C8 RID: 120776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C8")]
		[Address(RVA = "0x16FD850", Offset = "0x16FC450", VA = "0x1816FD850")]
		private void _TryRefreshOtherShopExpectedOrder()
		{
		}

		// Token: 0x0601D7C9 RID: 120777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7C9")]
		[Address(RVA = "0x16FD510", Offset = "0x16FC110", VA = "0x1816FD510")]
		private void _TryRefreshMyShopExpectedOrder()
		{
		}

		// Token: 0x0601D7CA RID: 120778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D7CA")]
		[Address(RVA = "0x16FD260", Offset = "0x16FBE60", VA = "0x1816FD260")]
		private int[] _TryGetExpectedOrderCountByMyStrategy(int strategyIndex, string shopId)
		{
			return null;
		}

		// Token: 0x0601D7CB RID: 120779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D7CB")]
		[Address(RVA = "0x16FD3C0", Offset = "0x16FBFC0", VA = "0x1816FD3C0")]
		private GroceryOrderOtherShopItemViewModel _TryGetOtherShopItem(string shopId)
		{
			return null;
		}

		// Token: 0x0601D7CC RID: 120780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7CC")]
		[Address(RVA = "0x16FDB30", Offset = "0x16FC730", VA = "0x1816FDB30")]
		public GroceryOrderGoodItemViewModel()
		{
		}

		// Token: 0x04026E29 RID: 159273
		[Token(Token = "0x4026E29")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isValid;

		// Token: 0x04026E2A RID: 159274
		[Token(Token = "0x4026E2A")]
		[FieldOffset(Offset = "0x30")]
		private string m_actId;

		// Token: 0x04026E2B RID: 159275
		[Token(Token = "0x4026E2B")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInquireTimeLeft;

		// Token: 0x04026E2C RID: 159276
		[Token(Token = "0x4026E2C")]
		[FieldOffset(Offset = "0x40")]
		private List<GroceryOrderOtherShopItemViewModel> m_otherShopItemViewModelList;

		// Token: 0x04026E2D RID: 159277
		[Token(Token = "0x4026E2D")]
		[FieldOffset(Offset = "0x48")]
		private GroceryOrderSelfShopViewModel m_selfShopItemViewModel;

		// Token: 0x04026E2E RID: 159278
		[Token(Token = "0x4026E2E")]
		[FieldOffset(Offset = "0x50")]
		private List<PlayerActivity.PlayerAct27SideActivity.PrePurchaseInfo> m_prePurchaseInfoList;

		// Token: 0x04026E2F RID: 159279
		[Token(Token = "0x4026E2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_goodId;

		// Token: 0x04026E30 RID: 159280
		[Token(Token = "0x4026E30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_goodId;

		// Token: 0x04026E31 RID: 159281
		[Token(Token = "0x4026E31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_goodName;

		// Token: 0x04026E32 RID: 159282
		[Token(Token = "0x4026E32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_goodName;

		// Token: 0x04026E33 RID: 159283
		[Token(Token = "0x4026E33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_goodIconId;

		// Token: 0x04026E34 RID: 159284
		[Token(Token = "0x4026E34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_goodIconId;

		// Token: 0x04026E35 RID: 159285
		[Token(Token = "0x4026E35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_buyerCount;

		// Token: 0x04026E36 RID: 159286
		[Token(Token = "0x4026E36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_buyerCount;

		// Token: 0x04026E37 RID: 159287
		[Token(Token = "0x4026E37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_otherShopItemViewModels;

		// Token: 0x04026E38 RID: 159288
		[Token(Token = "0x4026E38")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_selfShopItemViewModel;

		// Token: 0x04026E39 RID: 159289
		[Token(Token = "0x4026E39")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026E3A RID: 159290
		[Token(Token = "0x4026E3A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsOtherShopCanInquire;

		// Token: 0x04026E3B RID: 159291
		[Token(Token = "0x4026E3B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetOtherShopInquireStatus;

		// Token: 0x04026E3C RID: 159292
		[Token(Token = "0x4026E3C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_InquireOtherShop;

		// Token: 0x04026E3D RID: 159293
		[Token(Token = "0x4026E3D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RefreshMyShopStrategy;

		// Token: 0x04026E3E RID: 159294
		[Token(Token = "0x4026E3E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryRefreshOtherShopIfCanInquire;

		// Token: 0x04026E3F RID: 159295
		[Token(Token = "0x4026E3F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__LoadShopData;

		// Token: 0x04026E40 RID: 159296
		[Token(Token = "0x4026E40")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RefreshPlayerData;

		// Token: 0x04026E41 RID: 159297
		[Token(Token = "0x4026E41")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RefreshStrategyInfosFromPlayerData;

		// Token: 0x04026E42 RID: 159298
		[Token(Token = "0x4026E42")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RefreshPrePurchaseInfoList;

		// Token: 0x04026E43 RID: 159299
		[Token(Token = "0x4026E43")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TryRefreshMyShopStock;

		// Token: 0x04026E44 RID: 159300
		[Token(Token = "0x4026E44")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TryRefreshOtherShopStrategy;

		// Token: 0x04026E45 RID: 159301
		[Token(Token = "0x4026E45")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryRefreshOtherShopExpectedOrder;

		// Token: 0x04026E46 RID: 159302
		[Token(Token = "0x4026E46")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__TryRefreshMyShopExpectedOrder;

		// Token: 0x04026E47 RID: 159303
		[Token(Token = "0x4026E47")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TryGetExpectedOrderCountByMyStrategy;

		// Token: 0x04026E48 RID: 159304
		[Token(Token = "0x4026E48")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__TryGetOtherShopItem;

		// Token: 0x04026E49 RID: 159305
		[Token(Token = "0x4026E49")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
