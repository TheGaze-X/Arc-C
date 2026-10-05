using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B29 RID: 23337
	[Token(Token = "0x2005B29")]
	public class ShopRecommendStateBean : PageSingleComponent, IStateBean, IHotfixable
	{
		// Token: 0x06021E23 RID: 138787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E23")]
		[Address(RVA = "0x1C661E0", Offset = "0x1C64DE0", VA = "0x181C661E0")]
		public void InitData(long curTs)
		{
		}

		// Token: 0x06021E24 RID: 138788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E24")]
		[Address(RVA = "0x1C669C0", Offset = "0x1C655C0", VA = "0x181C669C0")]
		public void RefreshData()
		{
		}

		// Token: 0x06021E25 RID: 138789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E25")]
		[Address(RVA = "0x1C660A0", Offset = "0x1C64CA0", VA = "0x181C660A0")]
		public ShopRecommendViewModel GetViewModelByKey(string tagId)
		{
			return null;
		}

		// Token: 0x06021E26 RID: 138790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E26")]
		[Address(RVA = "0x1C65F10", Offset = "0x1C64B10", VA = "0x181C65F10")]
		public List<ShopRecommendData> GetImgListByKey(string tagId)
		{
			return null;
		}

		// Token: 0x06021E27 RID: 138791 RVA: 0x000BB8D8 File Offset: 0x000B9AD8
		[Token(Token = "0x6021E27")]
		[Address(RVA = "0x1C67330", Offset = "0x1C65F30", VA = "0x181C67330")]
		private static bool _CheckFurnGroupState(string furnGroup)
		{
			return default(bool);
		}

		// Token: 0x06021E28 RID: 138792 RVA: 0x000BB8F0 File Offset: 0x000B9AF0
		[Token(Token = "0x6021E28")]
		[Address(RVA = "0x1C67900", Offset = "0x1C66500", VA = "0x181C67900")]
		private static bool _CheckSkinFurnLockState(string goodId)
		{
			return default(bool);
		}

		// Token: 0x06021E29 RID: 138793 RVA: 0x000BB908 File Offset: 0x000B9B08
		[Token(Token = "0x6021E29")]
		[Address(RVA = "0x1C66FA0", Offset = "0x1C65BA0", VA = "0x181C66FA0")]
		private static bool _CheckAvail(ShopRouteTarget shopType, string param1, string skinId, string furnId, Dictionary<string, int> unlockType)
		{
			return default(bool);
		}

		// Token: 0x06021E2A RID: 138794 RVA: 0x000BB920 File Offset: 0x000B9B20
		[Token(Token = "0x6021E2A")]
		[Address(RVA = "0x1C677E0", Offset = "0x1C663E0", VA = "0x181C677E0")]
		private bool _CheckIfForbidden(List<string> forbiddenIds, ShopRecommendItem recommendItem)
		{
			return default(bool);
		}

		// Token: 0x06021E2B RID: 138795 RVA: 0x000BB938 File Offset: 0x000B9B38
		[Token(Token = "0x6021E2B")]
		[Address(RVA = "0x1C67430", Offset = "0x1C66030", VA = "0x181C67430")]
		private static bool _CheckIfCondTrigGPAvail(ShopClientGPData gpData)
		{
			return default(bool);
		}

		// Token: 0x06021E2C RID: 138796 RVA: 0x000BB950 File Offset: 0x000B9B50
		[Token(Token = "0x6021E2C")]
		[Address(RVA = "0x1C67A30", Offset = "0x1C66630", VA = "0x181C67A30")]
		private bool _GetViewModel(ShopRecommendViewModel viewModel, Dictionary<string, int> unlockType, out List<ShopRecommendData> showResult)
		{
			return default(bool);
		}

		// Token: 0x06021E2D RID: 138797 RVA: 0x000BB968 File Offset: 0x000B9B68
		[Token(Token = "0x6021E2D")]
		[Address(RVA = "0x1C65BB0", Offset = "0x1C647B0", VA = "0x181C65BB0")]
		public static bool CheckIfGoodAvailable(ShopRouteTarget shopType, string param1, string skinId, string furnId, Dictionary<string, int> unlockType)
		{
			return default(bool);
		}

		// Token: 0x06021E2E RID: 138798 RVA: 0x000BB980 File Offset: 0x000B9B80
		[Token(Token = "0x6021E2E")]
		[Address(RVA = "0x1C65C90", Offset = "0x1C64890", VA = "0x181C65C90")]
		public static bool CheckIfGoodUnlock(string goodId)
		{
			return default(bool);
		}

		// Token: 0x06021E2F RID: 138799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E2F")]
		[Address(RVA = "0x1C66670", Offset = "0x1C65270", VA = "0x181C66670")]
		public ShopPurchaseState LoadGoodsForPurchaseState()
		{
			return null;
		}

		// Token: 0x06021E30 RID: 138800 RVA: 0x000BB998 File Offset: 0x000B9B98
		[Token(Token = "0x6021E30")]
		[Address(RVA = "0x1C65D20", Offset = "0x1C64920", VA = "0x181C65D20")]
		private bool CheckShopItemAvailAble(ShopRecommendData data)
		{
			return default(bool);
		}

		// Token: 0x06021E31 RID: 138801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E31")]
		[Address(RVA = "0x1C65DA0", Offset = "0x1C649A0", VA = "0x181C65DA0")]
		public static List<string> GetGoodListFromPurchaseState(ShopPurchaseState purchaseState, ShopRouteTarget target)
		{
			return null;
		}

		// Token: 0x06021E32 RID: 138802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E32")]
		[Address(RVA = "0x1C658D0", Offset = "0x1C644D0", VA = "0x181C658D0")]
		public Dictionary<int, ShopRecommendData> CheckAvailableImageList(ShopRecommendItem closureItem)
		{
			return null;
		}

		// Token: 0x06021E33 RID: 138803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E33")]
		[Address(RVA = "0x1C68410", Offset = "0x1C67010", VA = "0x181C68410")]
		public ShopRecommendStateBean()
		{
		}

		// Token: 0x0402E6CB RID: 190155
		[Token(Token = "0x402E6CB")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<ShopRecommendViewModel> onShowList;

		// Token: 0x0402E6CC RID: 190156
		[Token(Token = "0x402E6CC")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public List<ShopKeeperWord> shopKeeperClickWords;

		// Token: 0x0402E6CD RID: 190157
		[Token(Token = "0x402E6CD")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public List<ShopKeeperWord> shopKeeperWelcomeWords;

		// Token: 0x0402E6CE RID: 190158
		[Token(Token = "0x402E6CE")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public List<KeyValuePair<string, List<ShopRecommendData>>> viewModelList;

		// Token: 0x0402E6CF RID: 190159
		[Token(Token = "0x402E6CF")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Dictionary<string, ShopRecommendTemplateViewModelBase> templateList;

		// Token: 0x0402E6D0 RID: 190160
		[Token(Token = "0x402E6D0")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Dictionary<string, int> resultList;

		// Token: 0x0402E6D1 RID: 190161
		[Token(Token = "0x402E6D1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ShopRecommendTemplateType, Type> s_templateTypeDict;

		// Token: 0x0402E6D2 RID: 190162
		[Token(Token = "0x402E6D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402E6D3 RID: 190163
		[Token(Token = "0x402E6D3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0402E6D4 RID: 190164
		[Token(Token = "0x402E6D4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetViewModelByKey;

		// Token: 0x0402E6D5 RID: 190165
		[Token(Token = "0x402E6D5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetImgListByKey;

		// Token: 0x0402E6D6 RID: 190166
		[Token(Token = "0x402E6D6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckFurnGroupState;

		// Token: 0x0402E6D7 RID: 190167
		[Token(Token = "0x402E6D7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckSkinFurnLockState;

		// Token: 0x0402E6D8 RID: 190168
		[Token(Token = "0x402E6D8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckAvail;

		// Token: 0x0402E6D9 RID: 190169
		[Token(Token = "0x402E6D9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckIfForbidden;

		// Token: 0x0402E6DA RID: 190170
		[Token(Token = "0x402E6DA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIfCondTrigGPAvail;

		// Token: 0x0402E6DB RID: 190171
		[Token(Token = "0x402E6DB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetViewModel;

		// Token: 0x0402E6DC RID: 190172
		[Token(Token = "0x402E6DC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfGoodAvailable;

		// Token: 0x0402E6DD RID: 190173
		[Token(Token = "0x402E6DD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckIfGoodUnlock;

		// Token: 0x0402E6DE RID: 190174
		[Token(Token = "0x402E6DE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadGoodsForPurchaseState;

		// Token: 0x0402E6DF RID: 190175
		[Token(Token = "0x402E6DF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckShopItemAvailAble;

		// Token: 0x0402E6E0 RID: 190176
		[Token(Token = "0x402E6E0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetGoodListFromPurchaseState;

		// Token: 0x0402E6E1 RID: 190177
		[Token(Token = "0x402E6E1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckAvailableImageList;

		// Token: 0x0402E6E2 RID: 190178
		[Token(Token = "0x402E6E2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
