using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A94 RID: 23188
	[Token(Token = "0x2005A94")]
	public class ShopDetailBlindboxState : ShopDetailCommonState, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x06021B7C RID: 138108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B7C")]
		[Address(RVA = "0x1C1BF00", Offset = "0x1C1AB00", VA = "0x181C1BF00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021B7D RID: 138109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B7D")]
		[Address(RVA = "0x1C1C0C0", Offset = "0x1C1ACC0", VA = "0x181C1C0C0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06021B7E RID: 138110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B7E")]
		[Address(RVA = "0x1C1BD60", Offset = "0x1C1A960", VA = "0x181C1BD60", Slot = "33")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06021B7F RID: 138111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B7F")]
		[Address(RVA = "0x1C1CFF0", Offset = "0x1C1BBF0", VA = "0x181C1CFF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021B80 RID: 138112 RVA: 0x000BB230 File Offset: 0x000B9430
		[Token(Token = "0x6021B80")]
		[Address(RVA = "0x1C1C860", Offset = "0x1C1B460", VA = "0x181C1C860")]
		private bool _CheckIfDiamondAffordable()
		{
			return default(bool);
		}

		// Token: 0x06021B81 RID: 138113 RVA: 0x000BB248 File Offset: 0x000B9448
		[Token(Token = "0x6021B81")]
		[Address(RVA = "0x1C1C940", Offset = "0x1C1B540", VA = "0x181C1C940")]
		private bool _CheckIfDiamondShardAffordable(long price)
		{
			return default(bool);
		}

		// Token: 0x06021B82 RID: 138114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B82")]
		[Address(RVA = "0x1C1D2C0", Offset = "0x1C1BEC0", VA = "0x181C1D2C0")]
		private void _OnVoucherBuyBtnClicked()
		{
		}

		// Token: 0x06021B83 RID: 138115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B83")]
		[Address(RVA = "0x1C1D410", Offset = "0x1C1C010", VA = "0x181C1D410")]
		private void _OnVoucherDetailBtnClicked()
		{
		}

		// Token: 0x06021B84 RID: 138116 RVA: 0x000BB260 File Offset: 0x000B9460
		[Token(Token = "0x6021B84")]
		[Address(RVA = "0x1C1C700", Offset = "0x1C1B300", VA = "0x181C1C700")]
		private bool _CheckHasSkin(string skinId)
		{
			return default(bool);
		}

		// Token: 0x06021B85 RID: 138117 RVA: 0x000BB278 File Offset: 0x000B9478
		[Token(Token = "0x6021B85")]
		[Address(RVA = "0x1C1CD50", Offset = "0x1C1B950", VA = "0x181C1CD50")]
		private bool _CheckUIStable()
		{
			return default(bool);
		}

		// Token: 0x06021B86 RID: 138118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B86")]
		[Address(RVA = "0x1C1D910", Offset = "0x1C1C510", VA = "0x181C1D910")]
		private void _OpenSelectionVoucherSkinDetailPage(BlindboxDetailViewModel viewModel)
		{
		}

		// Token: 0x06021B87 RID: 138119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B87")]
		[Address(RVA = "0x1C1D740", Offset = "0x1C1C340", VA = "0x181C1D740")]
		private void _OpenGachaVoucherSkinDetailDialog(BlindboxDetailViewModel viewModel)
		{
		}

		// Token: 0x06021B88 RID: 138120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021B88")]
		[Address(RVA = "0x1C1CDF0", Offset = "0x1C1B9F0", VA = "0x181C1CDF0")]
		private SkinShopBlindboxSkinListViewModel _GenerateDialogViewModel(BlindboxDetailViewModel viewModel)
		{
			return null;
		}

		// Token: 0x06021B89 RID: 138121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B89")]
		[Address(RVA = "0x1C1C4A0", Offset = "0x1C1B0A0", VA = "0x181C1C4A0")]
		private void _BuyBlindboxItem(BlindboxDetailViewModel viewModel)
		{
		}

		// Token: 0x06021B8A RID: 138122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B8A")]
		[Address(RVA = "0x1C1DB70", Offset = "0x1C1C770", VA = "0x181C1DB70")]
		private void _SendDiamondExchangeService()
		{
		}

		// Token: 0x06021B8B RID: 138123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B8B")]
		[Address(RVA = "0x1C1D170", Offset = "0x1C1BD70", VA = "0x181C1D170")]
		private void _OnExchangeResponseSuccess(ExchangeDiamondShardResponse response)
		{
		}

		// Token: 0x06021B8C RID: 138124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B8C")]
		[Address(RVA = "0x1C1DDF0", Offset = "0x1C1C9F0", VA = "0x181C1DDF0")]
		public ShopDetailBlindboxState()
		{
		}

		// Token: 0x06021B8E RID: 138126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B8E")]
		[Address(RVA = "0x1C1C2C0", Offset = "0x1C1AEC0", VA = "0x181C1C2C0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E1F0 RID: 188912
		[Token(Token = "0x402E1F0")]
		[NonSerialized]
		public const int ON_VOUCHER_DETAIL_BTN_CLICKED = 0;

		// Token: 0x0402E1F1 RID: 188913
		[Token(Token = "0x402E1F1")]
		[NonSerialized]
		public const int ON_VOUCHER_BUY_BTN_CLICKED = 1;

		// Token: 0x0402E1F2 RID: 188914
		[Token(Token = "0x402E1F2")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0402E1F3 RID: 188915
		[Token(Token = "0x402E1F3")]
		[FieldOffset(Offset = "0x80")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0402E1F4 RID: 188916
		[Token(Token = "0x402E1F4")]
		[FieldOffset(Offset = "0x88")]
		private int m_infoDialogInst;

		// Token: 0x0402E1F5 RID: 188917
		[Token(Token = "0x402E1F5")]
		[FieldOffset(Offset = "0x8C")]
		private int m_buyDialogInst;

		// Token: 0x0402E1F6 RID: 188918
		[Token(Token = "0x402E1F6")]
		[FieldOffset(Offset = "0x90")]
		private UIItemViewModel m_costModel;

		// Token: 0x0402E1F7 RID: 188919
		[Token(Token = "0x402E1F7")]
		[FieldOffset(Offset = "0x98")]
		private UIItemViewModel m_targetModel;

		// Token: 0x0402E1F8 RID: 188920
		[Token(Token = "0x402E1F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E1F9 RID: 188921
		[Token(Token = "0x402E1F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402E1FA RID: 188922
		[Token(Token = "0x402E1FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402E1FB RID: 188923
		[Token(Token = "0x402E1FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E1FC RID: 188924
		[Token(Token = "0x402E1FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfDiamondAffordable;

		// Token: 0x0402E1FD RID: 188925
		[Token(Token = "0x402E1FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckIfDiamondShardAffordable;

		// Token: 0x0402E1FE RID: 188926
		[Token(Token = "0x402E1FE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnVoucherBuyBtnClicked;

		// Token: 0x0402E1FF RID: 188927
		[Token(Token = "0x402E1FF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnVoucherDetailBtnClicked;

		// Token: 0x0402E200 RID: 188928
		[Token(Token = "0x402E200")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckHasSkin;

		// Token: 0x0402E201 RID: 188929
		[Token(Token = "0x402E201")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x0402E202 RID: 188930
		[Token(Token = "0x402E202")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OpenSelectionVoucherSkinDetailPage;

		// Token: 0x0402E203 RID: 188931
		[Token(Token = "0x402E203")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OpenGachaVoucherSkinDetailDialog;

		// Token: 0x0402E204 RID: 188932
		[Token(Token = "0x402E204")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenerateDialogViewModel;

		// Token: 0x0402E205 RID: 188933
		[Token(Token = "0x402E205")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__BuyBlindboxItem;

		// Token: 0x0402E206 RID: 188934
		[Token(Token = "0x402E206")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SendDiamondExchangeService;

		// Token: 0x0402E207 RID: 188935
		[Token(Token = "0x402E207")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnExchangeResponseSuccess;

		// Token: 0x0402E208 RID: 188936
		[Token(Token = "0x402E208")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
