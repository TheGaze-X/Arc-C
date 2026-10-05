using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CFD RID: 19709
	[Token(Token = "0x2004CFD")]
	public class GrocerySellState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601D899 RID: 120985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D899")]
		[Address(RVA = "0x171CE80", Offset = "0x171BA80", VA = "0x18171CE80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D89A RID: 120986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D89A")]
		[Address(RVA = "0x171D060", Offset = "0x171BC60", VA = "0x18171D060", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D89B RID: 120987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D89B")]
		[Address(RVA = "0x171D400", Offset = "0x171C000", VA = "0x18171D400", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601D89C RID: 120988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D89C")]
		[Address(RVA = "0x171D0F0", Offset = "0x171BCF0", VA = "0x18171D0F0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601D89D RID: 120989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D89D")]
		[Address(RVA = "0x171CEE0", Offset = "0x171BAE0", VA = "0x18171CEE0")]
		public void OnBackBtnClicked()
		{
		}

		// Token: 0x0601D89E RID: 120990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D89E")]
		[Address(RVA = "0x171ECD0", Offset = "0x171D8D0", VA = "0x18171ECD0")]
		private void _TriggerTutorialAVG()
		{
		}

		// Token: 0x0601D89F RID: 120991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D89F")]
		[Address(RVA = "0x171E670", Offset = "0x171D270", VA = "0x18171E670")]
		private void _RefreshModel(bool resetPrice = true)
		{
		}

		// Token: 0x0601D8A0 RID: 120992 RVA: 0x000ABDB0 File Offset: 0x000A9FB0
		[Token(Token = "0x601D8A0")]
		[Address(RVA = "0x171EA70", Offset = "0x171D670", VA = "0x18171EA70")]
		private bool _RemoveToHomeStateIfNecessary()
		{
			return default(bool);
		}

		// Token: 0x0601D8A1 RID: 120993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A1")]
		[Address(RVA = "0x171D800", Offset = "0x171C400", VA = "0x18171D800")]
		private void _InitFloatPanelIfNeed(string actId)
		{
		}

		// Token: 0x0601D8A2 RID: 120994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A2")]
		[Address(RVA = "0x171DC40", Offset = "0x171C840", VA = "0x18171DC40")]
		private void _OnInquireBtnClicked()
		{
		}

		// Token: 0x0601D8A3 RID: 120995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A3")]
		[Address(RVA = "0x171D550", Offset = "0x171C150", VA = "0x18171D550")]
		private void _ConfirmInquire(string goodId, string shopId)
		{
		}

		// Token: 0x0601D8A4 RID: 120996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A4")]
		[Address(RVA = "0x171E0A0", Offset = "0x171CCA0", VA = "0x18171E0A0")]
		private void _OnSellBtnClicked()
		{
		}

		// Token: 0x0601D8A5 RID: 120997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A5")]
		[Address(RVA = "0x171E360", Offset = "0x171CF60", VA = "0x18171E360")]
		private void _OnSellRequestProceed(GrocerySellResponse response)
		{
		}

		// Token: 0x0601D8A6 RID: 120998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A6")]
		[Address(RVA = "0x171DEC0", Offset = "0x171CAC0", VA = "0x18171DEC0")]
		private void _OnInquireDetailBtnClicked()
		{
		}

		// Token: 0x0601D8A7 RID: 120999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A7")]
		[Address(RVA = "0x171DF80", Offset = "0x171CB80", VA = "0x18171DF80")]
		private void _OnPriceSliderChanged(int targetIndex)
		{
		}

		// Token: 0x0601D8A8 RID: 121000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A8")]
		[Address(RVA = "0x171EF20", Offset = "0x171DB20", VA = "0x18171EF20")]
		private void _TryAddPriceSelectIndex(int addCount)
		{
		}

		// Token: 0x0601D8A9 RID: 121001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8A9")]
		[Address(RVA = "0x171E4F0", Offset = "0x171D0F0", VA = "0x18171E4F0")]
		private void _PlayEntryAnim(string animName)
		{
		}

		// Token: 0x0601D8AA RID: 121002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8AA")]
		[Address(RVA = "0x171D9A0", Offset = "0x171C5A0", VA = "0x18171D9A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D8AB RID: 121003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8AB")]
		[Address(RVA = "0x171F080", Offset = "0x171DC80", VA = "0x18171F080")]
		public GrocerySellState()
		{
		}

		// Token: 0x0601D8AE RID: 121006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8AE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601D8AF RID: 121007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8AF")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04026F8B RID: 159627
		[Token(Token = "0x4026F8B")]
		[NonSerialized]
		public const int ON_PRICE_SLIDER_CHANGED = 1;

		// Token: 0x04026F8C RID: 159628
		[Token(Token = "0x4026F8C")]
		[NonSerialized]
		public const int ON_INQUIRE = 2;

		// Token: 0x04026F8D RID: 159629
		[Token(Token = "0x4026F8D")]
		[NonSerialized]
		public const int ON_SELL = 3;

		// Token: 0x04026F8E RID: 159630
		[Token(Token = "0x4026F8E")]
		[NonSerialized]
		public const int ON_INQUIRE_DETAIL = 4;

		// Token: 0x04026F8F RID: 159631
		[Token(Token = "0x4026F8F")]
		[NonSerialized]
		public const int ON_PRICE_ADD_BTN_CLICKED = 5;

		// Token: 0x04026F90 RID: 159632
		[Token(Token = "0x4026F90")]
		[NonSerialized]
		public const int ON_PRICE_MIN_BTN_CLICKED = 6;

		// Token: 0x04026F91 RID: 159633
		[Token(Token = "0x4026F91")]
		private const string ENTRY_ANIM_LONG = "act27side_sales_entry_long";

		// Token: 0x04026F92 RID: 159634
		[Token(Token = "0x4026F92")]
		private const string ENTRY_ANIM_SHORT = "act27side_sales_entry_short";

		// Token: 0x04026F93 RID: 159635
		[Token(Token = "0x4026F93")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GrocerySellView _sellView;

		// Token: 0x04026F94 RID: 159636
		[Token(Token = "0x4026F94")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GrocerySellCustomerView[] _customerView;

		// Token: 0x04026F95 RID: 159637
		[Token(Token = "0x4026F95")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GrocerySellSliderController _slider;

		// Token: 0x04026F96 RID: 159638
		[Token(Token = "0x4026F96")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AnimationWrapper _entryAnim;

		// Token: 0x04026F97 RID: 159639
		[Token(Token = "0x4026F97")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _rectBackBtn;

		// Token: 0x04026F98 RID: 159640
		[Token(Token = "0x4026F98")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _inquireFloatContainer;

		// Token: 0x04026F99 RID: 159641
		[Token(Token = "0x4026F99")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GrocerySellInquireFloatPanel _prefabInquireFloat;

		// Token: 0x04026F9A RID: 159642
		[Token(Token = "0x4026F9A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _inquireConfirmFloatContainer;

		// Token: 0x04026F9B RID: 159643
		[Token(Token = "0x4026F9B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GroceryInquireConfirmFloatPanel _prefabInquireConfirmFloat;

		// Token: 0x04026F9C RID: 159644
		[Token(Token = "0x4026F9C")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_hasInited;

		// Token: 0x04026F9D RID: 159645
		[Token(Token = "0x4026F9D")]
		[FieldOffset(Offset = "0xC0")]
		private GrocerySellStateBean m_stateBean;

		// Token: 0x04026F9E RID: 159646
		[Token(Token = "0x4026F9E")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_cacheEntry;

		// Token: 0x04026F9F RID: 159647
		[Token(Token = "0x4026F9F")]
		[FieldOffset(Offset = "0xD0")]
		private UIFadeFloatPanel m_cachedInquireFloatPanel;

		// Token: 0x04026FA0 RID: 159648
		[Token(Token = "0x4026FA0")]
		[FieldOffset(Offset = "0xD8")]
		private GroceryInquireConfirmFloatPanel m_cachedInquireConfirmFloatPanel;

		// Token: 0x04026FA1 RID: 159649
		[Token(Token = "0x4026FA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04026FA2 RID: 159650
		[Token(Token = "0x4026FA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04026FA3 RID: 159651
		[Token(Token = "0x4026FA3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04026FA4 RID: 159652
		[Token(Token = "0x4026FA4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04026FA5 RID: 159653
		[Token(Token = "0x4026FA5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackBtnClicked;

		// Token: 0x04026FA6 RID: 159654
		[Token(Token = "0x4026FA6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x04026FA7 RID: 159655
		[Token(Token = "0x4026FA7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshModel;

		// Token: 0x04026FA8 RID: 159656
		[Token(Token = "0x4026FA8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RemoveToHomeStateIfNecessary;

		// Token: 0x04026FA9 RID: 159657
		[Token(Token = "0x4026FA9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitFloatPanelIfNeed;

		// Token: 0x04026FAA RID: 159658
		[Token(Token = "0x4026FAA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnInquireBtnClicked;

		// Token: 0x04026FAB RID: 159659
		[Token(Token = "0x4026FAB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ConfirmInquire;

		// Token: 0x04026FAC RID: 159660
		[Token(Token = "0x4026FAC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnSellBtnClicked;

		// Token: 0x04026FAD RID: 159661
		[Token(Token = "0x4026FAD")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnSellRequestProceed;

		// Token: 0x04026FAE RID: 159662
		[Token(Token = "0x4026FAE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnInquireDetailBtnClicked;

		// Token: 0x04026FAF RID: 159663
		[Token(Token = "0x4026FAF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnPriceSliderChanged;

		// Token: 0x04026FB0 RID: 159664
		[Token(Token = "0x4026FB0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TryAddPriceSelectIndex;

		// Token: 0x04026FB1 RID: 159665
		[Token(Token = "0x4026FB1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x04026FB2 RID: 159666
		[Token(Token = "0x4026FB2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026FB3 RID: 159667
		[Token(Token = "0x4026FB3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
