using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CEC RID: 19692
	[Token(Token = "0x2004CEC")]
	public class GroceryOrderResultGoodItemViewModel : IHotfixable
	{
		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x0601D846 RID: 120902 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D847 RID: 120903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004554")]
		public string goodId
		{
			[Token(Token = "0x601D846")]
			[Address(RVA = "0x170FB00", Offset = "0x170E700", VA = "0x18170FB00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D847")]
			[Address(RVA = "0x170FCA0", Offset = "0x170E8A0", VA = "0x18170FCA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x0601D848 RID: 120904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D849 RID: 120905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004555")]
		public string goodName
		{
			[Token(Token = "0x601D848")]
			[Address(RVA = "0x170FB60", Offset = "0x170E760", VA = "0x18170FB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D849")]
			[Address(RVA = "0x170FD20", Offset = "0x170E920", VA = "0x18170FD20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x0601D84A RID: 120906 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D84B RID: 120907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004556")]
		public string goodIconId
		{
			[Token(Token = "0x601D84A")]
			[Address(RVA = "0x170FAA0", Offset = "0x170E6A0", VA = "0x18170FAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D84B")]
			[Address(RVA = "0x170FC20", Offset = "0x170E820", VA = "0x18170FC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x0601D84C RID: 120908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004557")]
		public List<GroceryOrderResultShopItemViewModel> shopItemViewModelList
		{
			[Token(Token = "0x601D84C")]
			[Address(RVA = "0x170FBC0", Offset = "0x170E7C0", VA = "0x18170FBC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D84D RID: 120909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D84D")]
		[Address(RVA = "0x170ED00", Offset = "0x170D900", VA = "0x18170ED00")]
		public void LoadData(string playerShopId, string goodId, Act27SideData actData, Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PurchaseInfo> purchaseDic)
		{
		}

		// Token: 0x0601D84E RID: 120910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D84E")]
		[Address(RVA = "0x170EBC0", Offset = "0x170D7C0", VA = "0x18170EBC0")]
		public GroceryOrderResultShopItemViewModel GetShopItemViewModel(string shopId)
		{
			return null;
		}

		// Token: 0x0601D84F RID: 120911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D84F")]
		[Address(RVA = "0x170F4B0", Offset = "0x170E0B0", VA = "0x18170F4B0")]
		private void _LoadShopsData(string playerShopId, Act27SideData.Act27SideGoodData goodData, Act27SideData.Act27SideConstData constData, Dictionary<string, Act27SideData.Act27SideShopData> shopDataMap, Dictionary<string, PlayerActivity.PlayerAct27SideActivity.PurchaseInfo> purchaseDic)
		{
		}

		// Token: 0x0601D850 RID: 120912 RVA: 0x000ABD20 File Offset: 0x000A9F20
		[Token(Token = "0x601D850")]
		[Address(RVA = "0x170EF90", Offset = "0x170DB90", VA = "0x18170EF90")]
		private GroceryOrderResultGoodItemViewModel.ShopSliderType _GetShopSliderPercentType(List<int> shopPurchaseCountList)
		{
			return GroceryOrderResultGoodItemViewModel.ShopSliderType.NONE;
		}

		// Token: 0x0601D851 RID: 120913 RVA: 0x000ABD38 File Offset: 0x000A9F38
		[Token(Token = "0x601D851")]
		[Address(RVA = "0x170F2B0", Offset = "0x170DEB0", VA = "0x18170F2B0")]
		private float _GetSliderPercent(int purchaseCount, List<int> shopPurchaseCountList, Act27SideData.Act27SideConstData constData)
		{
			return 0f;
		}

		// Token: 0x0601D852 RID: 120914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D852")]
		[Address(RVA = "0x170F9F0", Offset = "0x170E5F0", VA = "0x18170F9F0")]
		public GroceryOrderResultGoodItemViewModel()
		{
		}

		// Token: 0x04026F0B RID: 159499
		[Token(Token = "0x4026F0B")]
		[FieldOffset(Offset = "0x28")]
		private List<GroceryOrderResultShopItemViewModel> m_shopItemViewModelList;

		// Token: 0x04026F0C RID: 159500
		[Token(Token = "0x4026F0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_goodId;

		// Token: 0x04026F0D RID: 159501
		[Token(Token = "0x4026F0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_goodId;

		// Token: 0x04026F0E RID: 159502
		[Token(Token = "0x4026F0E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_goodName;

		// Token: 0x04026F0F RID: 159503
		[Token(Token = "0x4026F0F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_goodName;

		// Token: 0x04026F10 RID: 159504
		[Token(Token = "0x4026F10")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_goodIconId;

		// Token: 0x04026F11 RID: 159505
		[Token(Token = "0x4026F11")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_goodIconId;

		// Token: 0x04026F12 RID: 159506
		[Token(Token = "0x4026F12")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_shopItemViewModelList;

		// Token: 0x04026F13 RID: 159507
		[Token(Token = "0x4026F13")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026F14 RID: 159508
		[Token(Token = "0x4026F14")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetShopItemViewModel;

		// Token: 0x04026F15 RID: 159509
		[Token(Token = "0x4026F15")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadShopsData;

		// Token: 0x04026F16 RID: 159510
		[Token(Token = "0x4026F16")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetShopSliderPercentType;

		// Token: 0x04026F17 RID: 159511
		[Token(Token = "0x4026F17")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetSliderPercent;

		// Token: 0x04026F18 RID: 159512
		[Token(Token = "0x4026F18")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CED RID: 19693
		[Token(Token = "0x2004CED")]
		private enum ShopSliderType
		{
			// Token: 0x04026F1A RID: 159514
			[Token(Token = "0x4026F1A")]
			NONE,
			// Token: 0x04026F1B RID: 159515
			[Token(Token = "0x4026F1B")]
			RANK_1_2_3,
			// Token: 0x04026F1C RID: 159516
			[Token(Token = "0x4026F1C")]
			RANK_1_1_3,
			// Token: 0x04026F1D RID: 159517
			[Token(Token = "0x4026F1D")]
			RANK_1_2_2,
			// Token: 0x04026F1E RID: 159518
			[Token(Token = "0x4026F1E")]
			RANK_1_1_1,
			// Token: 0x04026F1F RID: 159519
			[Token(Token = "0x4026F1F")]
			RANK_1_1_0,
			// Token: 0x04026F20 RID: 159520
			[Token(Token = "0x4026F20")]
			RANK_1_2_0
		}
	}
}
