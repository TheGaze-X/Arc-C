using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004963 RID: 18787
	[Token(Token = "0x2004963")]
	public class MedalSelectGroupState : PopupFadeState
	{
		// Token: 0x0601C516 RID: 115990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C516")]
		[Address(RVA = "0x15D77D0", Offset = "0x15D63D0", VA = "0x1815D77D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C517 RID: 115991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C517")]
		[Address(RVA = "0x15D7C10", Offset = "0x15D6810", VA = "0x1815D7C10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C518 RID: 115992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C518")]
		[Address(RVA = "0x15D7B00", Offset = "0x15D6700", VA = "0x1815D7B00", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601C519 RID: 115993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C519")]
		[Address(RVA = "0x15D7930", Offset = "0x15D6530", VA = "0x1815D7930", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C51A RID: 115994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C51A")]
		[Address(RVA = "0x15D7D30", Offset = "0x15D6930", VA = "0x1815D7D30")]
		private void _UpdateSelectCount()
		{
		}

		// Token: 0x0601C51B RID: 115995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C51B")]
		[Address(RVA = "0x15D7830", Offset = "0x15D6430", VA = "0x1815D7830")]
		public void OnClickMedalEvent(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C51C RID: 115996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C51C")]
		[Address(RVA = "0x15D7740", Offset = "0x15D6340", VA = "0x1815D7740")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601C51D RID: 115997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C51D")]
		[Address(RVA = "0x15D76B0", Offset = "0x15D62B0", VA = "0x1815D76B0")]
		public void EventOnClearClicked()
		{
		}

		// Token: 0x0601C51E RID: 115998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C51E")]
		[Address(RVA = "0x15D7E50", Offset = "0x15D6A50", VA = "0x1815D7E50")]
		public MedalSelectGroupState()
		{
		}

		// Token: 0x0601C51F RID: 115999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C51F")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601C520 RID: 116000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C520")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402509C RID: 151708
		[Token(Token = "0x402509C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MedalGroupListView _listView;

		// Token: 0x0402509D RID: 151709
		[Token(Token = "0x402509D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MedalListStateBean _stateBean;

		// Token: 0x0402509E RID: 151710
		[Token(Token = "0x402509E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _topMenuHolder;

		// Token: 0x0402509F RID: 151711
		[Token(Token = "0x402509F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textSelectedCount;

		// Token: 0x040250A0 RID: 151712
		[Token(Token = "0x40250A0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _btnBack;

		// Token: 0x040250A1 RID: 151713
		[Token(Token = "0x40250A1")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x040250A2 RID: 151714
		[Token(Token = "0x40250A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040250A3 RID: 151715
		[Token(Token = "0x40250A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040250A4 RID: 151716
		[Token(Token = "0x40250A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040250A5 RID: 151717
		[Token(Token = "0x40250A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040250A6 RID: 151718
		[Token(Token = "0x40250A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateSelectCount;

		// Token: 0x040250A7 RID: 151719
		[Token(Token = "0x40250A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickMedalEvent;

		// Token: 0x040250A8 RID: 151720
		[Token(Token = "0x40250A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x040250A9 RID: 151721
		[Token(Token = "0x40250A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClearClicked;

		// Token: 0x040250AA RID: 151722
		[Token(Token = "0x40250AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
