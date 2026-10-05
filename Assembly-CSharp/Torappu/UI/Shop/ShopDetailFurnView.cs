using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AA7 RID: 23207
	[Token(Token = "0x2005AA7")]
	public class ShopDetailFurnView : ShopDetailCommonView, IHotfixable
	{
		// Token: 0x06021BFE RID: 138238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BFE")]
		[Address(RVA = "0x1C38720", Offset = "0x1C37320", VA = "0x181C38720", Slot = "5")]
		public override void OnClick()
		{
		}

		// Token: 0x06021BFF RID: 138239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BFF")]
		[Address(RVA = "0x1C374E0", Offset = "0x1C360E0", VA = "0x181C374E0", Slot = "4")]
		public override void ApplyData(DetailCommonViewModel viewModel, SpriteHub priceTypeHub)
		{
		}

		// Token: 0x06021C00 RID: 138240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C00")]
		[Address(RVA = "0x1C37CB0", Offset = "0x1C368B0", VA = "0x181C37CB0")]
		public void ApplyPriceState()
		{
		}

		// Token: 0x06021C01 RID: 138241 RVA: 0x000BB380 File Offset: 0x000B9580
		[Token(Token = "0x6021C01")]
		[Address(RVA = "0x1C38900", Offset = "0x1C37500", VA = "0x181C38900")]
		public int RefreshNum(int currCount)
		{
			return 0;
		}

		// Token: 0x06021C02 RID: 138242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C02")]
		[Address(RVA = "0x1C38C90", Offset = "0x1C37890", VA = "0x181C38C90")]
		public void TurnCoinFurn()
		{
		}

		// Token: 0x06021C03 RID: 138243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C03")]
		[Address(RVA = "0x1C38AE0", Offset = "0x1C376E0", VA = "0x181C38AE0")]
		public void TurnCoinDiam()
		{
		}

		// Token: 0x06021C04 RID: 138244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C04")]
		[Address(RVA = "0x1C37280", Offset = "0x1C35E80", VA = "0x181C37280")]
		public void AddOne()
		{
		}

		// Token: 0x06021C05 RID: 138245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C05")]
		[Address(RVA = "0x1C38570", Offset = "0x1C37170", VA = "0x181C38570")]
		public void MinusOne()
		{
		}

		// Token: 0x06021C06 RID: 138246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C06")]
		[Address(RVA = "0x1C373B0", Offset = "0x1C35FB0", VA = "0x181C373B0")]
		public void AddToMax()
		{
		}

		// Token: 0x06021C07 RID: 138247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C07")]
		[Address(RVA = "0x1C385F0", Offset = "0x1C371F0", VA = "0x181C385F0")]
		public void MinusToOne()
		{
		}

		// Token: 0x06021C08 RID: 138248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C08")]
		[Address(RVA = "0x1C38E30", Offset = "0x1C37A30", VA = "0x181C38E30")]
		public ShopDetailFurnView()
		{
		}

		// Token: 0x06021C09 RID: 138249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C09")]
		[Address(RVA = "0x1C1EA20", Offset = "0x1C1D620", VA = "0x181C1EA20")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x06021C0A RID: 138250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C0A")]
		[Address(RVA = "0x1C1EA10", Offset = "0x1C1D610", VA = "0x181C1EA10")]
		private void <>xLuaBaseProxy_ApplyData(DetailCommonViewModel P0, SpriteHub P1)
		{
		}

		// Token: 0x0402E2B6 RID: 189110
		[Token(Token = "0x402E2B6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ThreeStateToggle _coinPart;

		// Token: 0x0402E2B7 RID: 189111
		[Token(Token = "0x402E2B7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private ThreeStateToggle _diamPart;

		// Token: 0x0402E2B8 RID: 189112
		[Token(Token = "0x402E2B8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _shopBuyCount;

		// Token: 0x0402E2B9 RID: 189113
		[Token(Token = "0x402E2B9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _shopCurrentCount;

		// Token: 0x0402E2BA RID: 189114
		[Token(Token = "0x402E2BA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _shopAvailCount;

		// Token: 0x0402E2BB RID: 189115
		[Token(Token = "0x402E2BB")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0402E2BC RID: 189116
		[Token(Token = "0x402E2BC")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0402E2BD RID: 189117
		[Token(Token = "0x402E2BD")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Image _totalIcon;

		// Token: 0x0402E2BE RID: 189118
		[Token(Token = "0x402E2BE")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _totalPrice;

		// Token: 0x0402E2BF RID: 189119
		[Token(Token = "0x402E2BF")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text _addText;

		// Token: 0x0402E2C0 RID: 189120
		[Token(Token = "0x402E2C0")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _itemDetailName;

		// Token: 0x0402E2C1 RID: 189121
		[Token(Token = "0x402E2C1")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Image[] _whiteFurniIcons;

		// Token: 0x0402E2C2 RID: 189122
		[Token(Token = "0x402E2C2")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Image[] _whiteDiamondIcons;

		// Token: 0x0402E2C3 RID: 189123
		[Token(Token = "0x402E2C3")]
		[FieldOffset(Offset = "0x110")]
		private int m_shopBuyCount;

		// Token: 0x0402E2C4 RID: 189124
		[Token(Token = "0x402E2C4")]
		[FieldOffset(Offset = "0x114")]
		private bool m_isDiamAvail;

		// Token: 0x0402E2C5 RID: 189125
		[Token(Token = "0x402E2C5")]
		[FieldOffset(Offset = "0x115")]
		private bool m_isCoinAvail;

		// Token: 0x0402E2C6 RID: 189126
		[Token(Token = "0x402E2C6")]
		[FieldOffset(Offset = "0x118")]
		private int m_remainCount;

		// Token: 0x0402E2C7 RID: 189127
		[Token(Token = "0x402E2C7")]
		[FieldOffset(Offset = "0x120")]
		private SpriteHub m_priceTypeHub;

		// Token: 0x0402E2C8 RID: 189128
		[Token(Token = "0x402E2C8")]
		[FieldOffset(Offset = "0x128")]
		private ShopDetailFurnView.SelectClass m_selectPriceFlag;

		// Token: 0x0402E2C9 RID: 189129
		[Token(Token = "0x402E2C9")]
		[FieldOffset(Offset = "0x130")]
		private UIItemCard m_itemCard;

		// Token: 0x0402E2CA RID: 189130
		[Token(Token = "0x402E2CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E2CB RID: 189131
		[Token(Token = "0x402E2CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E2CC RID: 189132
		[Token(Token = "0x402E2CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyPriceState;

		// Token: 0x0402E2CD RID: 189133
		[Token(Token = "0x402E2CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshNum;

		// Token: 0x0402E2CE RID: 189134
		[Token(Token = "0x402E2CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TurnCoinFurn;

		// Token: 0x0402E2CF RID: 189135
		[Token(Token = "0x402E2CF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TurnCoinDiam;

		// Token: 0x0402E2D0 RID: 189136
		[Token(Token = "0x402E2D0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AddOne;

		// Token: 0x0402E2D1 RID: 189137
		[Token(Token = "0x402E2D1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_MinusOne;

		// Token: 0x0402E2D2 RID: 189138
		[Token(Token = "0x402E2D2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_AddToMax;

		// Token: 0x0402E2D3 RID: 189139
		[Token(Token = "0x402E2D3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_MinusToOne;

		// Token: 0x0402E2D4 RID: 189140
		[Token(Token = "0x402E2D4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005AA8 RID: 23208
		[Token(Token = "0x2005AA8")]
		public enum SelectClass
		{
			// Token: 0x0402E2D6 RID: 189142
			[Token(Token = "0x402E2D6")]
			COIN,
			// Token: 0x0402E2D7 RID: 189143
			[Token(Token = "0x402E2D7")]
			DIAMOND
		}
	}
}
