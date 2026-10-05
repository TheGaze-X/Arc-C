using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D08 RID: 19720
	[Token(Token = "0x2004D08")]
	public class GrocerySellIncomingLogView : DataBinder<GrocerySellResultProperty>, IHotfixable
	{
		// Token: 0x0601D8DF RID: 121055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8DF")]
		[Address(RVA = "0x17160B0", Offset = "0x1714CB0", VA = "0x1817160B0", Slot = "7")]
		public override void OnValueChanged(GrocerySellResultProperty property)
		{
		}

		// Token: 0x0601D8E0 RID: 121056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8E0")]
		[Address(RVA = "0x1716240", Offset = "0x1714E40", VA = "0x181716240")]
		public void PlayTextIncreaseTweenWithDelay()
		{
		}

		// Token: 0x0601D8E1 RID: 121057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8E1")]
		[Address(RVA = "0x1716020", Offset = "0x1714C20", VA = "0x181716020")]
		public void OnBackGroundClicked()
		{
		}

		// Token: 0x0601D8E2 RID: 121058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8E2")]
		[Address(RVA = "0x1716440", Offset = "0x1715040", VA = "0x181716440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D8E3 RID: 121059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8E3")]
		[Address(RVA = "0x1716A10", Offset = "0x1715610", VA = "0x181716A10")]
		public GrocerySellIncomingLogView()
		{
		}

		// Token: 0x04027023 RID: 159779
		[Token(Token = "0x4027023")]
		private const float UPPER_TWEEN_DELAY = 0.17f;

		// Token: 0x04027024 RID: 159780
		[Token(Token = "0x4027024")]
		private const float UPPER_TWEEN_DURATION = 0.34f;

		// Token: 0x04027025 RID: 159781
		[Token(Token = "0x4027025")]
		private const float UPPER_TEXT_APPEAR_DELAY = 0.1f;

		// Token: 0x04027026 RID: 159782
		[Token(Token = "0x4027026")]
		private const float NET_INCOME_TWEEN_DELAY = 1f;

		// Token: 0x04027027 RID: 159783
		[Token(Token = "0x4027027")]
		private const float NET_INCOME_TWEEN_DURATION = 0.75f;

		// Token: 0x04027028 RID: 159784
		[Token(Token = "0x4027028")]
		private const float THIS_DAY_FUND_TWEEN_DELAY = 2.17f;

		// Token: 0x04027029 RID: 159785
		[Token(Token = "0x4027029")]
		private const float THIS_DAY_FUND_TWEEN_DURATION = 0.5f;

		// Token: 0x0402702A RID: 159786
		[Token(Token = "0x402702A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _backPressRect;

		// Token: 0x0402702B RID: 159787
		[Token(Token = "0x402702B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _totalPurchaseCostText;

		// Token: 0x0402702C RID: 159788
		[Token(Token = "0x402702C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _totalSellIncomeText;

		// Token: 0x0402702D RID: 159789
		[Token(Token = "0x402702D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _totalPrizeIncomeText;

		// Token: 0x0402702E RID: 159790
		[Token(Token = "0x402702E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GrocerySellSpacingTextItem _netIncomeText;

		// Token: 0x0402702F RID: 159791
		[Token(Token = "0x402702F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _lastDayFundText;

		// Token: 0x04027030 RID: 159792
		[Token(Token = "0x4027030")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _thisDayFundText;

		// Token: 0x04027031 RID: 159793
		[Token(Token = "0x4027031")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _dayNumText;

		// Token: 0x04027032 RID: 159794
		[Token(Token = "0x4027032")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _itemCardHolder;

		// Token: 0x04027033 RID: 159795
		[Token(Token = "0x4027033")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _itemCardScale;

		// Token: 0x04027034 RID: 159796
		[Token(Token = "0x4027034")]
		[FieldOffset(Offset = "0x6C")]
		private bool m_hasInited;

		// Token: 0x04027035 RID: 159797
		[Token(Token = "0x4027035")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_itemCard;

		// Token: 0x04027036 RID: 159798
		[Token(Token = "0x4027036")]
		[FieldOffset(Offset = "0x78")]
		private GrocerySellResultViewModel.IncomingLogData m_incomingLogData;

		// Token: 0x04027037 RID: 159799
		[Token(Token = "0x4027037")]
		[FieldOffset(Offset = "0x90")]
		private GrocerySellResultTextTween m_purchaseCostTween;

		// Token: 0x04027038 RID: 159800
		[Token(Token = "0x4027038")]
		[FieldOffset(Offset = "0x98")]
		private GrocerySellResultTextTween m_sellIncomeTween;

		// Token: 0x04027039 RID: 159801
		[Token(Token = "0x4027039")]
		[FieldOffset(Offset = "0xA0")]
		private GrocerySellResultTextTween m_prizeIncomeTween;

		// Token: 0x0402703A RID: 159802
		[Token(Token = "0x402703A")]
		[FieldOffset(Offset = "0xA8")]
		private GrocerySellResultTextTween m_netIncomeTween;

		// Token: 0x0402703B RID: 159803
		[Token(Token = "0x402703B")]
		[FieldOffset(Offset = "0xB0")]
		private GrocerySellResultTextTween m_thisDayFundTween;

		// Token: 0x0402703C RID: 159804
		[Token(Token = "0x402703C")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402703D RID: 159805
		[Token(Token = "0x402703D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402703E RID: 159806
		[Token(Token = "0x402703E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayTextIncreaseTweenWithDelay;

		// Token: 0x0402703F RID: 159807
		[Token(Token = "0x402703F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBackGroundClicked;

		// Token: 0x04027040 RID: 159808
		[Token(Token = "0x4027040")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027041 RID: 159809
		[Token(Token = "0x4027041")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
