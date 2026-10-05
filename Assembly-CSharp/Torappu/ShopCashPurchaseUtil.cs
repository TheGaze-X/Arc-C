using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.SDK;
using U8.SDK;
using XLua;

namespace Torappu
{
	// Token: 0x02001430 RID: 5168
	[Token(Token = "0x2001430")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ShopCashPurchaseUtil
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x0600779C RID: 30620 RVA: 0x00035B68 File Offset: 0x00033D68
		[Token(Token = "0x17000E57")]
		public static bool hasUnconfirmedOrdersFromLogin
		{
			[Token(Token = "0x600779C")]
			[Address(RVA = "0x253EC00", Offset = "0x253D800", VA = "0x18253EC00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600779D")]
		[Address(RVA = "0x253AF20", Offset = "0x2539B20", VA = "0x18253AF20")]
		public static List<string> ConsumeConfirmedUnfinishedOrders()
		{
			return null;
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600779E")]
		[Address(RVA = "0x253B2D0", Offset = "0x2539ED0", VA = "0x18253B2D0")]
		public static void ReceiveItemsFromUnfinishedOrders(ListDict<string, PayConfirmOrderResponse> confirmedOrders)
		{
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600779F")]
		[Address(RVA = "0x253BB20", Offset = "0x253A720", VA = "0x18253BB20")]
		public static void TryConfirmOrderWhenLogin(Action callback)
		{
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A0")]
		[Address(RVA = "0x253ACE0", Offset = "0x25398E0", VA = "0x18253ACE0")]
		public static void ConfirmUnfinishedOrders(List<string> orderList, Action<ListDict<string, PayConfirmOrderResponse>> callback)
		{
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A1")]
		[Address(RVA = "0x253C5F0", Offset = "0x253B1F0", VA = "0x18253C5F0")]
		private static void _ConfirmUnfinishedOrder(string orderId, Action<PayConfirmOrderResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A2")]
		[Address(RVA = "0x253B940", Offset = "0x253A540", VA = "0x18253B940")]
		public static void StartPurchase(CashPurchaseOptions options)
		{
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00035B80 File Offset: 0x00033D80
		[Token(Token = "0x60077A3")]
		[Address(RVA = "0x253AFD0", Offset = "0x2539BD0", VA = "0x18253AFD0")]
		public static ShopCashInfo GetProductCashInfo(string productId, int priceInData)
		{
			return default(ShopCashInfo);
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A4")]
		[Address(RVA = "0x253CA00", Offset = "0x253B600", VA = "0x18253CA00")]
		private static void _CreateOrder()
		{
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A5")]
		[Address(RVA = "0x253DCD0", Offset = "0x253C8D0", VA = "0x18253DCD0")]
		private static void _Pay(int storeId, U8OrderInfo orderInfo)
		{
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A6")]
		[Address(RVA = "0x253C290", Offset = "0x253AE90", VA = "0x18253C290")]
		private static void _ConfirmOrder()
		{
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A7")]
		[Address(RVA = "0x253D210", Offset = "0x253BE10", VA = "0x18253D210")]
		private static void _LogTraceOnConfirmOrder()
		{
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A8")]
		[Address(RVA = "0x253E640", Offset = "0x253D240", VA = "0x18253E640")]
		private static void _SendGetPurchaseGoods()
		{
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077A9")]
		[Address(RVA = "0x253D7E0", Offset = "0x253C3E0", VA = "0x18253D7E0")]
		private static void _OnGetPurchaseGoodsFail(long errorCode)
		{
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AA")]
		[Address(RVA = "0x253C070", Offset = "0x253AC70", VA = "0x18253C070")]
		private static void _AlertErrorAndFail(string errorInfo)
		{
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AB")]
		[Address(RVA = "0x253C120", Offset = "0x253AD20", VA = "0x18253C120")]
		private static void _AlertErrorAndToInitScene(string errorInfo)
		{
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AC")]
		[Address(RVA = "0x253E260", Offset = "0x253CE60", VA = "0x18253E260")]
		private static void _RouteToInitScene()
		{
		}

		// Token: 0x060077AD RID: 30637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077AD")]
		[Address(RVA = "0x253E320", Offset = "0x253CF20", VA = "0x18253E320")]
		private static void _SendCreateOrder(string goodId, int storeId, Action<U8OrderInfo> onSuc, Action<List<string>> onPendingOrders, Action<string> onFail)
		{
		}

		// Token: 0x060077AE RID: 30638 RVA: 0x00035B98 File Offset: 0x00033D98
		[Token(Token = "0x60077AE")]
		[Address(RVA = "0x253D180", Offset = "0x253BD80", VA = "0x18253D180")]
		private static bool _IsMockedPay()
		{
			return default(bool);
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x00035BB0 File Offset: 0x00033DB0
		[Token(Token = "0x60077AF")]
		[Address(RVA = "0x253BFB0", Offset = "0x253ABB0", VA = "0x18253BFB0")]
		public static bool UseMultiCurrency()
		{
			return default(bool);
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B0")]
		[Address(RVA = "0x253B6A0", Offset = "0x253A2A0", VA = "0x18253B6A0")]
		public static void SetMultiCurrencyShopCashInfo(List<SDKCashProduct> productList)
		{
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x00035BC8 File Offset: 0x00033DC8
		[Token(Token = "0x60077B1")]
		[Address(RVA = "0x253AC10", Offset = "0x2539810", VA = "0x18253AC10")]
		public static bool CheckIfMultiCurrencyInfoValid()
		{
			return default(bool);
		}

		// Token: 0x060077B2 RID: 30642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B2")]
		[Address(RVA = "0x253DBA0", Offset = "0x253C7A0", VA = "0x18253DBA0")]
		private static void _OnPurchaseSuc(PayConfirmOrderResponse response)
		{
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B3")]
		[Address(RVA = "0x253DA90", Offset = "0x253C690", VA = "0x18253DA90")]
		private static void _OnPurchaseFail()
		{
		}

		// Token: 0x060077B4 RID: 30644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077B4")]
		[Address(RVA = "0x253D960", Offset = "0x253C560", VA = "0x18253D960")]
		private static void _OnPendingOrders(List<string> pendingOrders)
		{
		}

		// Token: 0x04007512 RID: 29970
		[Token(Token = "0x4007512")]
		[FieldOffset(Offset = "0x0")]
		private static CashPurchaseOptions m_options;

		// Token: 0x04007513 RID: 29971
		[Token(Token = "0x4007513")]
		[FieldOffset(Offset = "0x18")]
		private static ShopCashPurchaseUtil.Context m_context;

		// Token: 0x04007514 RID: 29972
		[Token(Token = "0x4007514")]
		[FieldOffset(Offset = "0x38")]
		private static List<string> m_unfinishedOrdersFromLogin;

		// Token: 0x04007515 RID: 29973
		[Token(Token = "0x4007515")]
		[FieldOffset(Offset = "0x40")]
		private static Dictionary<string, ShopCashInfo> m_multiCurrencyInfo;

		// Token: 0x04007516 RID: 29974
		[Token(Token = "0x4007516")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_hasUnconfirmedOrdersFromLogin;

		// Token: 0x04007517 RID: 29975
		[Token(Token = "0x4007517")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ConsumeConfirmedUnfinishedOrders;

		// Token: 0x04007518 RID: 29976
		[Token(Token = "0x4007518")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ReceiveItemsFromUnfinishedOrders;

		// Token: 0x04007519 RID: 29977
		[Token(Token = "0x4007519")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryConfirmOrderWhenLogin;

		// Token: 0x0400751A RID: 29978
		[Token(Token = "0x400751A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ConfirmUnfinishedOrders;

		// Token: 0x0400751B RID: 29979
		[Token(Token = "0x400751B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ConfirmUnfinishedOrder;

		// Token: 0x0400751C RID: 29980
		[Token(Token = "0x400751C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_StartPurchase;

		// Token: 0x0400751D RID: 29981
		[Token(Token = "0x400751D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetProductCashInfo;

		// Token: 0x0400751E RID: 29982
		[Token(Token = "0x400751E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CreateOrder;

		// Token: 0x0400751F RID: 29983
		[Token(Token = "0x400751F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__Pay;

		// Token: 0x04007520 RID: 29984
		[Token(Token = "0x4007520")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ConfirmOrder;

		// Token: 0x04007521 RID: 29985
		[Token(Token = "0x4007521")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__LogTraceOnConfirmOrder;

		// Token: 0x04007522 RID: 29986
		[Token(Token = "0x4007522")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SendGetPurchaseGoods;

		// Token: 0x04007523 RID: 29987
		[Token(Token = "0x4007523")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnGetPurchaseGoodsFail;

		// Token: 0x04007524 RID: 29988
		[Token(Token = "0x4007524")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__AlertErrorAndFail;

		// Token: 0x04007525 RID: 29989
		[Token(Token = "0x4007525")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__AlertErrorAndToInitScene;

		// Token: 0x04007526 RID: 29990
		[Token(Token = "0x4007526")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__RouteToInitScene;

		// Token: 0x04007527 RID: 29991
		[Token(Token = "0x4007527")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__SendCreateOrder;

		// Token: 0x04007528 RID: 29992
		[Token(Token = "0x4007528")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__IsMockedPay;

		// Token: 0x04007529 RID: 29993
		[Token(Token = "0x4007529")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_UseMultiCurrency;

		// Token: 0x0400752A RID: 29994
		[Token(Token = "0x400752A")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_SetMultiCurrencyShopCashInfo;

		// Token: 0x0400752B RID: 29995
		[Token(Token = "0x400752B")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckIfMultiCurrencyInfoValid;

		// Token: 0x0400752C RID: 29996
		[Token(Token = "0x400752C")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__OnPurchaseSuc;

		// Token: 0x0400752D RID: 29997
		[Token(Token = "0x400752D")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnPurchaseFail;

		// Token: 0x0400752E RID: 29998
		[Token(Token = "0x400752E")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnPendingOrders;

		// Token: 0x02001431 RID: 5169
		[Token(Token = "0x2001431")]
		private struct Context
		{
			// Token: 0x0400752F RID: 29999
			[Token(Token = "0x400752F")]
			[FieldOffset(Offset = "0x0")]
			public string orderId;

			// Token: 0x04007530 RID: 30000
			[Token(Token = "0x4007530")]
			[FieldOffset(Offset = "0x8")]
			public string transactionId;

			// Token: 0x04007531 RID: 30001
			[Token(Token = "0x4007531")]
			[FieldOffset(Offset = "0x10")]
			public string extension;

			// Token: 0x04007532 RID: 30002
			[Token(Token = "0x4007532")]
			[FieldOffset(Offset = "0x18")]
			public U8ProductInfo productInfo;
		}
	}
}
