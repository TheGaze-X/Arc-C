using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B38 RID: 23352
	[Token(Token = "0x2005B38")]
	public static class ShopBuyItemHandler
	{
		// Token: 0x06021E80 RID: 138880 RVA: 0x000BBB90 File Offset: 0x000B9D90
		[Token(Token = "0x6021E80")]
		[Address(RVA = "0x1C60510", Offset = "0x1C5F110", VA = "0x181C60510")]
		public static bool BuyHandler(DetailCommonViewModel viewModel, int buyCount = 1)
		{
			return default(bool);
		}

		// Token: 0x06021E81 RID: 138881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E81")]
		[Address(RVA = "0x1C60500", Offset = "0x1C5F100", VA = "0x181C60500")]
		public static void BuyHandlerWithOption(string optionId)
		{
		}

		// Token: 0x06021E82 RID: 138882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E82")]
		[Address(RVA = "0x1C60770", Offset = "0x1C5F370", VA = "0x181C60770")]
		public static void BuySkinItem(SkinShopViewModel viewModel, bool spDynIllustState, Action disMissEvent)
		{
		}

		// Token: 0x06021E83 RID: 138883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E83")]
		[Address(RVA = "0x1C5FFE0", Offset = "0x1C5EBE0", VA = "0x181C5FFE0")]
		public static void BuyFurnGroup(FurnGroupViewModel viewModel, ShopDetailPriceType priceType, Action disMissEvent)
		{
		}

		// Token: 0x06021E84 RID: 138884 RVA: 0x000BBBA8 File Offset: 0x000B9DA8
		[Token(Token = "0x6021E84")]
		[Address(RVA = "0x1C608E0", Offset = "0x1C5F4E0", VA = "0x181C608E0")]
		public static bool CheckIfMonthlySubPurchasable(string goodId)
		{
			return default(bool);
		}

		// Token: 0x06021E85 RID: 138885 RVA: 0x000BBBC0 File Offset: 0x000B9DC0
		[Token(Token = "0x6021E85")]
		[Address(RVA = "0x1C60AB0", Offset = "0x1C5F6B0", VA = "0x181C60AB0")]
		public static int GetMonthlySubMaxRemainDays(string monthlySubId)
		{
			return 0;
		}

		// Token: 0x06021E86 RID: 138886 RVA: 0x000BBBD8 File Offset: 0x000B9DD8
		[Token(Token = "0x6021E86")]
		[Address(RVA = "0x1C62F90", Offset = "0x1C61B90", VA = "0x181C62F90")]
		private static bool _CheckIfAffordable(long price, string priceItemId, ItemType priceItemType)
		{
			return default(bool);
		}

		// Token: 0x06021E87 RID: 138887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E87")]
		[Address(RVA = "0x1C613B0", Offset = "0x1C5FFB0", VA = "0x181C613B0")]
		private static void _BuyFurnGroup(BuyFurnGroupRequest request, Action callBack)
		{
		}

		// Token: 0x06021E88 RID: 138888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E88")]
		[Address(RVA = "0x1C62990", Offset = "0x1C61590", VA = "0x181C62990")]
		private static void _BuySkinViaDiamond(string goodId, int price, bool spDynIllustState, Action callback)
		{
		}

		// Token: 0x06021E89 RID: 138889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E89")]
		[Address(RVA = "0x1C62760", Offset = "0x1C61360", VA = "0x181C62760")]
		private static void _BuySkinViaCash(string goodId, Action callback)
		{
		}

		// Token: 0x06021E8A RID: 138890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E8A")]
		[Address(RVA = "0x1C61810", Offset = "0x1C60410", VA = "0x181C61810")]
		private static void _BuyGPItem(DetailCommonViewModel viewModel)
		{
		}

		// Token: 0x06021E8B RID: 138891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E8B")]
		[Address(RVA = "0x1C60BA0", Offset = "0x1C5F7A0", VA = "0x181C60BA0")]
		private static void _BuyClassicQCItem(DetailCommonViewModel viewModel, int buyCount)
		{
		}

		// Token: 0x06021E8C RID: 138892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E8C")]
		[Address(RVA = "0x1C61B00", Offset = "0x1C60700", VA = "0x181C61B00")]
		private static void _BuyHighQCItem(DetailCommonViewModel viewModel, int buyCount)
		{
		}

		// Token: 0x06021E8D RID: 138893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E8D")]
		[Address(RVA = "0x1C62CF0", Offset = "0x1C618F0", VA = "0x181C62CF0")]
		private static void _BuySocialItem(DetailCommonViewModel viewModel, int buyCount)
		{
		}

		// Token: 0x06021E8E RID: 138894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E8E")]
		[Address(RVA = "0x1C61F80", Offset = "0x1C60B80", VA = "0x181C61F80")]
		private static void _BuyLMTGSItem(DetailCommonViewModel viewModel, int buyCount)
		{
		}

		// Token: 0x06021E8F RID: 138895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E8F")]
		[Address(RVA = "0x1C624C0", Offset = "0x1C610C0", VA = "0x181C624C0")]
		private static void _BuyREPItem(DetailCommonViewModel viewModel, int buyCount)
		{
		}

		// Token: 0x06021E90 RID: 138896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E90")]
		[Address(RVA = "0x1C60E70", Offset = "0x1C5FA70", VA = "0x181C60E70")]
		private static void _BuyEPGSItem(DetailCommonViewModel viewModel, int buyCount)
		{
		}

		// Token: 0x06021E91 RID: 138897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E91")]
		[Address(RVA = "0x1C62220", Offset = "0x1C60E20", VA = "0x181C62220")]
		private static void _BuyLowQCItem(DetailCommonViewModel viewModel, int buyCount)
		{
		}

		// Token: 0x06021E92 RID: 138898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E92")]
		[Address(RVA = "0x1C61110", Offset = "0x1C5FD10", VA = "0x181C61110")]
		private static void _BuyExtraQCItem(DetailCommonViewModel viewModel, int buyCount)
		{
		}

		// Token: 0x06021E93 RID: 138899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E93")]
		[Address(RVA = "0x1C61570", Offset = "0x1C60170", VA = "0x181C61570")]
		private static void _BuyFurniture(string goodId, string furniId, int buyCount, ShopDetailFurnView.SelectClass selectType)
		{
		}

		// Token: 0x06021E94 RID: 138900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E94")]
		[Address(RVA = "0x1C61DA0", Offset = "0x1C609A0", VA = "0x181C61DA0")]
		private static void _BuyItemWithCash(string goodId, ShopType shopType)
		{
		}

		// Token: 0x06021E95 RID: 138901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E95")]
		[Address(RVA = "0x1C63410", Offset = "0x1C62010", VA = "0x181C63410")]
		private static void _OnSkinUnlocked(string charId, string skinId, bool showSpDynIllust, Action disMissEvent)
		{
		}

		// Token: 0x06021E96 RID: 138902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E96")]
		[Address(RVA = "0x1C631D0", Offset = "0x1C61DD0", VA = "0x181C631D0")]
		private static void _OnSkinUnlockedWithGift(string charId, string skinId, bool showSpDynIllust, string giftAvatarId, Action disMissEvent)
		{
		}

		// Token: 0x06021E97 RID: 138903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E97")]
		[Address(RVA = "0x1C63520", Offset = "0x1C62120", VA = "0x181C63520")]
		private static IEnumerator _ReceiveItemsFromCashPurchase(PayConfirmOrderResponse response)
		{
			return null;
		}

		// Token: 0x06021E98 RID: 138904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E98")]
		[Address(RVA = "0x1C60B00", Offset = "0x1C5F700", VA = "0x181C60B00")]
		public static IEnumerator ReceiveItemsCoroutine(List<RewardItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x06021E99 RID: 138905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021E99")]
		[Address(RVA = "0x1C634A0", Offset = "0x1C620A0", VA = "0x181C634A0")]
		private static IEnumerator _ReceiveCheckInSubItems(List<RewardItemModel> dailyGet)
		{
			return null;
		}

		// Token: 0x06021E9A RID: 138906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E9A")]
		[Address(RVA = "0x1C630E0", Offset = "0x1C61CE0", VA = "0x181C630E0")]
		private static void _OnPendingOrders(List<string> pendingOrders, [Optional] Action callback)
		{
		}
	}
}
