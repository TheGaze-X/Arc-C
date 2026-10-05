using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ADF RID: 23263
	[Token(Token = "0x2005ADF")]
	public class ShopGPStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06021D09 RID: 138505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D09")]
		[Address(RVA = "0x1C51620", Offset = "0x1C50220", VA = "0x181C51620")]
		public void InitData(GetGPGoodListResponse response)
		{
		}

		// Token: 0x06021D0A RID: 138506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D0A")]
		[Address(RVA = "0x1C51A50", Offset = "0x1C50650", VA = "0x181C51A50")]
		public void SortItem()
		{
		}

		// Token: 0x06021D0B RID: 138507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D0B")]
		[Address(RVA = "0x1C53770", Offset = "0x1C52370", VA = "0x181C53770")]
		private void _TraceItemsSafe()
		{
		}

		// Token: 0x06021D0C RID: 138508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D0C")]
		[Address(RVA = "0x1C525B0", Offset = "0x1C511B0", VA = "0x181C525B0")]
		private static void _PopulateLevelGPs(GetGPGoodListResponse response, List<ShopGPCommonItemViewModel> shopItemList, List<ShopGPCommonItemViewModel> soldOutItemList, PlayerGiftProgressData playerShop)
		{
		}

		// Token: 0x06021D0D RID: 138509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D0D")]
		[Address(RVA = "0x1C52850", Offset = "0x1C51450", VA = "0x181C52850")]
		private static void _PopulateMonthlyGroup(GetGPGoodListResponse response, List<ShopGPCommonItemViewModel> shopItemList, List<ShopGPCommonItemViewModel> soldOutItemList, PlayerGiftProgressData playerShop)
		{
		}

		// Token: 0x06021D0E RID: 138510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D0E")]
		[Address(RVA = "0x1C53390", Offset = "0x1C51F90", VA = "0x181C53390")]
		private static void _PopulateWeeklyGroup(GetGPGoodListResponse response, List<ShopGPCommonItemViewModel> shopItemList, List<ShopGPCommonItemViewModel> soldOutItemList, PlayerGiftProgressData playerShop)
		{
		}

		// Token: 0x06021D0F RID: 138511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D0F")]
		[Address(RVA = "0x1C52C30", Offset = "0x1C51830", VA = "0x181C52C30")]
		private static void _PopulateMonthlySub(GetGPGoodListResponse response, List<ShopGPCommonItemViewModel> shopItemList, List<ShopGPCommonItemViewModel> soldOutItemList, PlayerGiftProgressData playerShop)
		{
		}

		// Token: 0x06021D10 RID: 138512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D10")]
		[Address(RVA = "0x1C53040", Offset = "0x1C51C40", VA = "0x181C53040")]
		private static void _PopulateOneTimeGP(GetGPGoodListResponse response, List<ShopGPCommonItemViewModel> shopItemList, List<ShopGPCommonItemViewModel> soldOutItemList, PlayerGiftProgressData playerShop)
		{
		}

		// Token: 0x06021D11 RID: 138513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D11")]
		[Address(RVA = "0x1C521B0", Offset = "0x1C50DB0", VA = "0x181C521B0")]
		private static void _PopulateChooseGroup(GetGPGoodListResponse response, List<ShopGPCommonItemViewModel> shopItemList, List<ShopGPCommonItemViewModel> soldOutItemList, PlayerGiftProgressData playerShop)
		{
		}

		// Token: 0x06021D12 RID: 138514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D12")]
		[Address(RVA = "0x1C51E60", Offset = "0x1C50A60", VA = "0x181C51E60")]
		private static ShopGPChooseItemViewModel _LoadGPChooseItemCommonInfo(ChooseGPItem item, List<PlayerGoodItemData> boughtInfoList)
		{
			return null;
		}

		// Token: 0x06021D13 RID: 138515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D13")]
		[Address(RVA = "0x1C51D20", Offset = "0x1C50920", VA = "0x181C51D20")]
		private static ShopGPChooseItemViewModel _LoadGPChooseCondItemInfo(ChooseCondTrigGPItem item, List<PlayerGoodItemData> boughtInfoList)
		{
			return null;
		}

		// Token: 0x06021D14 RID: 138516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D14")]
		[Address(RVA = "0x1C523C0", Offset = "0x1C50FC0", VA = "0x181C523C0")]
		private static void _PopulateCondTrigGroup(GetGPGoodListResponse response, List<ShopGPCommonItemViewModel> shopItemList, List<ShopGPCommonItemViewModel> soldOutItemList, PlayerGiftProgressData playerShop)
		{
		}

		// Token: 0x06021D15 RID: 138517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D15")]
		[Address(RVA = "0x1C53870", Offset = "0x1C52470", VA = "0x181C53870")]
		private static void _UpdateGpTicketStatus(List<ShopGPCommonItemViewModel> shopItemList)
		{
		}

		// Token: 0x06021D16 RID: 138518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D16")]
		[Address(RVA = "0x1C53A60", Offset = "0x1C52660", VA = "0x181C53A60")]
		public ShopGPStateBean()
		{
		}

		// Token: 0x0402E4BF RID: 189631
		[Token(Token = "0x402E4BF")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<ShopGPCommonItemViewModel> shopItemList;

		// Token: 0x0402E4C0 RID: 189632
		[Token(Token = "0x402E4C0")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<ShopGPCommonItemViewModel> soldOutItemList;

		// Token: 0x0402E4C1 RID: 189633
		[Token(Token = "0x402E4C1")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public ShopGPProperty tabProperty;

		// Token: 0x0402E4C2 RID: 189634
		[Token(Token = "0x402E4C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402E4C3 RID: 189635
		[Token(Token = "0x402E4C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SortItem;

		// Token: 0x0402E4C4 RID: 189636
		[Token(Token = "0x402E4C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TraceItemsSafe;

		// Token: 0x0402E4C5 RID: 189637
		[Token(Token = "0x402E4C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PopulateLevelGPs;

		// Token: 0x0402E4C6 RID: 189638
		[Token(Token = "0x402E4C6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PopulateMonthlyGroup;

		// Token: 0x0402E4C7 RID: 189639
		[Token(Token = "0x402E4C7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PopulateWeeklyGroup;

		// Token: 0x0402E4C8 RID: 189640
		[Token(Token = "0x402E4C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PopulateMonthlySub;

		// Token: 0x0402E4C9 RID: 189641
		[Token(Token = "0x402E4C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PopulateOneTimeGP;

		// Token: 0x0402E4CA RID: 189642
		[Token(Token = "0x402E4CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PopulateChooseGroup;

		// Token: 0x0402E4CB RID: 189643
		[Token(Token = "0x402E4CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadGPChooseItemCommonInfo;

		// Token: 0x0402E4CC RID: 189644
		[Token(Token = "0x402E4CC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadGPChooseCondItemInfo;

		// Token: 0x0402E4CD RID: 189645
		[Token(Token = "0x402E4CD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PopulateCondTrigGroup;

		// Token: 0x0402E4CE RID: 189646
		[Token(Token = "0x402E4CE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateGpTicketStatus;

		// Token: 0x0402E4CF RID: 189647
		[Token(Token = "0x402E4CF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
