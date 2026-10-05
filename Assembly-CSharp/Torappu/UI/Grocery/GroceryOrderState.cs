using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CCF RID: 19663
	[Token(Token = "0x2004CCF")]
	public class GroceryOrderState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601D72B RID: 120619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D72B")]
		[Address(RVA = "0x1703710", Offset = "0x1702310", VA = "0x181703710", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D72C RID: 120620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D72C")]
		[Address(RVA = "0x1703810", Offset = "0x1702410", VA = "0x181703810", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D72D RID: 120621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D72D")]
		[Address(RVA = "0x1703F30", Offset = "0x1702B30", VA = "0x181703F30", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601D72E RID: 120622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D72E")]
		[Address(RVA = "0x1703A40", Offset = "0x1702640", VA = "0x181703A40", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601D72F RID: 120623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D72F")]
		[Address(RVA = "0x1703770", Offset = "0x1702370", VA = "0x181703770")]
		public void OnBackBtnPressed()
		{
		}

		// Token: 0x0601D730 RID: 120624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D730")]
		[Address(RVA = "0x17059C0", Offset = "0x17045C0", VA = "0x1817059C0")]
		private void _TriggerTutorialAVG()
		{
		}

		// Token: 0x0601D731 RID: 120625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D731")]
		[Address(RVA = "0x17052E0", Offset = "0x1703EE0", VA = "0x1817052E0")]
		private void _OnInquireShopClick(string goodId, string shopId)
		{
		}

		// Token: 0x0601D732 RID: 120626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D732")]
		[Address(RVA = "0x17055C0", Offset = "0x17041C0", VA = "0x1817055C0")]
		private IEnumerator _PlayOrderViewEnterAnim()
		{
			return null;
		}

		// Token: 0x0601D733 RID: 120627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D733")]
		[Address(RVA = "0x1705C40", Offset = "0x1704840", VA = "0x181705C40")]
		private void _TryInquireOrder(string goodId, string shopId)
		{
		}

		// Token: 0x0601D734 RID: 120628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D734")]
		[Address(RVA = "0x1704470", Offset = "0x1703070", VA = "0x181704470")]
		private void _ConfirmInquire(string goodId, string shopId)
		{
		}

		// Token: 0x0601D735 RID: 120629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D735")]
		[Address(RVA = "0x1704D90", Offset = "0x1703990", VA = "0x181704D90")]
		private void _OnChangeSelfShopStrategyClick(string goodId, long index)
		{
		}

		// Token: 0x0601D736 RID: 120630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D736")]
		[Address(RVA = "0x1704E90", Offset = "0x1703A90", VA = "0x181704E90")]
		private void _OnConfirmOrderClick()
		{
		}

		// Token: 0x0601D737 RID: 120631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D737")]
		[Address(RVA = "0x1705220", Offset = "0x1703E20", VA = "0x181705220")]
		private void _OnInquireDetailClick()
		{
		}

		// Token: 0x0601D738 RID: 120632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D738")]
		[Address(RVA = "0x1704AB0", Offset = "0x17036B0", VA = "0x181704AB0")]
		private void _InitInquireConfirmFloatPanelIfNeed()
		{
		}

		// Token: 0x0601D739 RID: 120633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D739")]
		[Address(RVA = "0x1704C30", Offset = "0x1703830", VA = "0x181704C30")]
		private void _InitInquireDetailFloatPanelIfNeed(string actId)
		{
		}

		// Token: 0x0601D73A RID: 120634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D73A")]
		[Address(RVA = "0x17047E0", Offset = "0x17033E0", VA = "0x1817047E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D73B RID: 120635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D73B")]
		[Address(RVA = "0x1705440", Offset = "0x1704040", VA = "0x181705440")]
		private void _PlayEntryAnim(string animName)
		{
		}

		// Token: 0x0601D73C RID: 120636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D73C")]
		[Address(RVA = "0x1705740", Offset = "0x1704340", VA = "0x181705740")]
		private void _ShowResultView()
		{
		}

		// Token: 0x0601D73D RID: 120637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D73D")]
		[Address(RVA = "0x1705670", Offset = "0x1704270", VA = "0x181705670")]
		private IEnumerator _PlayResultEntryAnim(string animName)
		{
			return null;
		}

		// Token: 0x0601D73E RID: 120638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D73E")]
		[Address(RVA = "0x1705B70", Offset = "0x1704770", VA = "0x181705B70")]
		private void _TryCloseSelf()
		{
		}

		// Token: 0x0601D73F RID: 120639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D73F")]
		[Address(RVA = "0x1705F00", Offset = "0x1704B00", VA = "0x181705F00")]
		public GroceryOrderState()
		{
		}

		// Token: 0x0601D742 RID: 120642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D742")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601D743 RID: 120643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D743")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04026D36 RID: 159030
		[Token(Token = "0x4026D36")]
		[NonSerialized]
		public const int ON_MSG_INQUIRE_SHOP = 0;

		// Token: 0x04026D37 RID: 159031
		[Token(Token = "0x4026D37")]
		[NonSerialized]
		public const int ON_MSG_CHANGE_SELF_SHOP_STRATEGY = 1;

		// Token: 0x04026D38 RID: 159032
		[Token(Token = "0x4026D38")]
		[NonSerialized]
		public const int ON_MSG_CONFIRM_ORDER = 2;

		// Token: 0x04026D39 RID: 159033
		[Token(Token = "0x4026D39")]
		[NonSerialized]
		public const int ON_MSG_INQUIRE_DETAIL = 3;

		// Token: 0x04026D3A RID: 159034
		[Token(Token = "0x4026D3A")]
		[NonSerialized]
		public const int ON_MSG_RESULT_BACK_CLICK = 4;

		// Token: 0x04026D3B RID: 159035
		[Token(Token = "0x4026D3B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GroceryOrderView _view;

		// Token: 0x04026D3C RID: 159036
		[Token(Token = "0x4026D3C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationWrapper _entryAnim;

		// Token: 0x04026D3D RID: 159037
		[Token(Token = "0x4026D3D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _rectBackBtn;

		// Token: 0x04026D3E RID: 159038
		[Token(Token = "0x4026D3E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _inquireConfirmFloatContainer;

		// Token: 0x04026D3F RID: 159039
		[Token(Token = "0x4026D3F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GroceryInquireConfirmFloatPanel _prefabInquireConfirmFloat;

		// Token: 0x04026D40 RID: 159040
		[Token(Token = "0x4026D40")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _inquireDetailFloatContainer;

		// Token: 0x04026D41 RID: 159041
		[Token(Token = "0x4026D41")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GrocerySellInquireFloatPanel _prefabInquireDetailFloat;

		// Token: 0x04026D42 RID: 159042
		[Token(Token = "0x4026D42")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GroceryOrderResultView _resultViewPrefab;

		// Token: 0x04026D43 RID: 159043
		[Token(Token = "0x4026D43")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform _resultViewParent;

		// Token: 0x04026D44 RID: 159044
		[Token(Token = "0x4026D44")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_hasInited;

		// Token: 0x04026D45 RID: 159045
		[Token(Token = "0x4026D45")]
		[FieldOffset(Offset = "0xC0")]
		private GroceryOrderStateBean m_stateBean;

		// Token: 0x04026D46 RID: 159046
		[Token(Token = "0x4026D46")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_cacheEntry;

		// Token: 0x04026D47 RID: 159047
		[Token(Token = "0x4026D47")]
		[FieldOffset(Offset = "0xD0")]
		private GroceryInquireConfirmFloatPanel m_cachedInquireConfirmFloatPanel;

		// Token: 0x04026D48 RID: 159048
		[Token(Token = "0x4026D48")]
		[FieldOffset(Offset = "0xD8")]
		private UIFadeFloatPanel m_cachedInquireDetailFloatPanel;

		// Token: 0x04026D49 RID: 159049
		[Token(Token = "0x4026D49")]
		[FieldOffset(Offset = "0xE0")]
		private GroceryOrderResultView m_resultView;

		// Token: 0x04026D4A RID: 159050
		[Token(Token = "0x4026D4A")]
		[FieldOffset(Offset = "0xE8")]
		private AnimationWrapper m_resultEnterAnim;

		// Token: 0x04026D4B RID: 159051
		[Token(Token = "0x4026D4B")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_cacheResultEntry;

		// Token: 0x04026D4C RID: 159052
		[Token(Token = "0x4026D4C")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_canResultBackClick;

		// Token: 0x04026D4D RID: 159053
		[Token(Token = "0x4026D4D")]
		private const string ENTRY_ANIM = "act27side_order_entry";

		// Token: 0x04026D4E RID: 159054
		[Token(Token = "0x4026D4E")]
		private const string RESULT_ENTRY_ANIM = "act27side_order_result_entry";

		// Token: 0x04026D4F RID: 159055
		[Token(Token = "0x4026D4F")]
		private const float CUSTOMER_CNT_ENTER_SHOW_DELAY = 2f;

		// Token: 0x04026D50 RID: 159056
		[Token(Token = "0x4026D50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04026D51 RID: 159057
		[Token(Token = "0x4026D51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04026D52 RID: 159058
		[Token(Token = "0x4026D52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04026D53 RID: 159059
		[Token(Token = "0x4026D53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04026D54 RID: 159060
		[Token(Token = "0x4026D54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackBtnPressed;

		// Token: 0x04026D55 RID: 159061
		[Token(Token = "0x4026D55")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TriggerTutorialAVG;

		// Token: 0x04026D56 RID: 159062
		[Token(Token = "0x4026D56")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnInquireShopClick;

		// Token: 0x04026D57 RID: 159063
		[Token(Token = "0x4026D57")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayOrderViewEnterAnim;

		// Token: 0x04026D58 RID: 159064
		[Token(Token = "0x4026D58")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryInquireOrder;

		// Token: 0x04026D59 RID: 159065
		[Token(Token = "0x4026D59")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ConfirmInquire;

		// Token: 0x04026D5A RID: 159066
		[Token(Token = "0x4026D5A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnChangeSelfShopStrategyClick;

		// Token: 0x04026D5B RID: 159067
		[Token(Token = "0x4026D5B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnConfirmOrderClick;

		// Token: 0x04026D5C RID: 159068
		[Token(Token = "0x4026D5C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnInquireDetailClick;

		// Token: 0x04026D5D RID: 159069
		[Token(Token = "0x4026D5D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitInquireConfirmFloatPanelIfNeed;

		// Token: 0x04026D5E RID: 159070
		[Token(Token = "0x4026D5E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitInquireDetailFloatPanelIfNeed;

		// Token: 0x04026D5F RID: 159071
		[Token(Token = "0x4026D5F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026D60 RID: 159072
		[Token(Token = "0x4026D60")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x04026D61 RID: 159073
		[Token(Token = "0x4026D61")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ShowResultView;

		// Token: 0x04026D62 RID: 159074
		[Token(Token = "0x4026D62")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayResultEntryAnim;

		// Token: 0x04026D63 RID: 159075
		[Token(Token = "0x4026D63")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryCloseSelf;

		// Token: 0x04026D64 RID: 159076
		[Token(Token = "0x4026D64")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
