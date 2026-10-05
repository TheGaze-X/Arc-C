using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AA2 RID: 23202
	[Token(Token = "0x2005AA2")]
	public class ShopDetailComplexView : ShopDetailCommonView, IHotfixable
	{
		// Token: 0x06021BC4 RID: 138180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BC4")]
		[Address(RVA = "0x1C31840", Offset = "0x1C30440", VA = "0x181C31840", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021BC5 RID: 138181 RVA: 0x000BB2D8 File Offset: 0x000B94D8
		[Token(Token = "0x6021BC5")]
		[Address(RVA = "0x1C31FC0", Offset = "0x1C30BC0", VA = "0x181C31FC0")]
		public int RefreshNum(int currCount)
		{
			return 0;
		}

		// Token: 0x06021BC6 RID: 138182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BC6")]
		[Address(RVA = "0x1C32070", Offset = "0x1C30C70", VA = "0x181C32070")]
		private void _RefreshClick()
		{
		}

		// Token: 0x06021BC7 RID: 138183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BC7")]
		[Address(RVA = "0x1C31720", Offset = "0x1C30320", VA = "0x181C31720")]
		public void AddOne()
		{
		}

		// Token: 0x06021BC8 RID: 138184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BC8")]
		[Address(RVA = "0x1C31D10", Offset = "0x1C30910", VA = "0x181C31D10")]
		public void MinusOne()
		{
		}

		// Token: 0x06021BC9 RID: 138185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BC9")]
		[Address(RVA = "0x1C317A0", Offset = "0x1C303A0", VA = "0x181C317A0")]
		public void AddToMax()
		{
		}

		// Token: 0x06021BCA RID: 138186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BCA")]
		[Address(RVA = "0x1C31D90", Offset = "0x1C30990", VA = "0x181C31D90")]
		public void MinusToOne()
		{
		}

		// Token: 0x06021BCB RID: 138187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BCB")]
		[Address(RVA = "0x1C31E00", Offset = "0x1C30A00", VA = "0x181C31E00", Slot = "5")]
		public override void OnClick()
		{
		}

		// Token: 0x06021BCC RID: 138188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BCC")]
		[Address(RVA = "0x1C32190", Offset = "0x1C30D90", VA = "0x181C32190")]
		public ShopDetailComplexView()
		{
		}

		// Token: 0x06021BCD RID: 138189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BCD")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x06021BCE RID: 138190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BCE")]
		[Address(RVA = "0x1C1EA20", Offset = "0x1C1D620", VA = "0x181C1EA20")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402E273 RID: 189043
		[Token(Token = "0x402E273")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _shopBuyCount;

		// Token: 0x0402E274 RID: 189044
		[Token(Token = "0x402E274")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _shopItemName;

		// Token: 0x0402E275 RID: 189045
		[Token(Token = "0x402E275")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _shopPerCount;

		// Token: 0x0402E276 RID: 189046
		[Token(Token = "0x402E276")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _shopAvailCount;

		// Token: 0x0402E277 RID: 189047
		[Token(Token = "0x402E277")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _totalPrice;

		// Token: 0x0402E278 RID: 189048
		[Token(Token = "0x402E278")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Image _finalPriceIcon;

		// Token: 0x0402E279 RID: 189049
		[Token(Token = "0x402E279")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ShopDetailItemPileView _pileView;

		// Token: 0x0402E27A RID: 189050
		[Token(Token = "0x402E27A")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Button _maxButton;

		// Token: 0x0402E27B RID: 189051
		[Token(Token = "0x402E27B")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _maxButtonText;

		// Token: 0x0402E27C RID: 189052
		[Token(Token = "0x402E27C")]
		[FieldOffset(Offset = "0xF0")]
		private int m_shopBuyCount;

		// Token: 0x0402E27D RID: 189053
		[Token(Token = "0x402E27D")]
		[FieldOffset(Offset = "0xF4")]
		private int m_perPrice;

		// Token: 0x0402E27E RID: 189054
		[Token(Token = "0x402E27E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E27F RID: 189055
		[Token(Token = "0x402E27F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshNum;

		// Token: 0x0402E280 RID: 189056
		[Token(Token = "0x402E280")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RefreshClick;

		// Token: 0x0402E281 RID: 189057
		[Token(Token = "0x402E281")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AddOne;

		// Token: 0x0402E282 RID: 189058
		[Token(Token = "0x402E282")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MinusOne;

		// Token: 0x0402E283 RID: 189059
		[Token(Token = "0x402E283")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddToMax;

		// Token: 0x0402E284 RID: 189060
		[Token(Token = "0x402E284")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_MinusToOne;

		// Token: 0x0402E285 RID: 189061
		[Token(Token = "0x402E285")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E286 RID: 189062
		[Token(Token = "0x402E286")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
