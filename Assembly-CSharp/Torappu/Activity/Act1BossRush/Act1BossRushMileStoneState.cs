using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush
{
	// Token: 0x020070C1 RID: 28865
	[Token(Token = "0x20070C1")]
	public class Act1BossRushMileStoneState : PopupFadeState, IHotfixable
	{
		// Token: 0x0602905B RID: 168027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602905B")]
		[Address(RVA = "0x2468620", Offset = "0x2467220", VA = "0x182468620", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602905C RID: 168028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602905C")]
		[Address(RVA = "0x2468680", Offset = "0x2467280", VA = "0x182468680", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602905D RID: 168029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602905D")]
		[Address(RVA = "0x24686F0", Offset = "0x24672F0", VA = "0x1824686F0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602905E RID: 168030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602905E")]
		[Address(RVA = "0x2468EC0", Offset = "0x2467AC0", VA = "0x182468EC0")]
		private void _OnItemClick(string mileStoneId)
		{
		}

		// Token: 0x0602905F RID: 168031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602905F")]
		[Address(RVA = "0x2468BC0", Offset = "0x24677C0", VA = "0x182468BC0")]
		private void _OnGetAllClick()
		{
		}

		// Token: 0x06029060 RID: 168032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029060")]
		[Address(RVA = "0x2468960", Offset = "0x2467560", VA = "0x182468960")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029061 RID: 168033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029061")]
		[Address(RVA = "0x2469330", Offset = "0x2467F30", VA = "0x182469330")]
		private void _RefreshView()
		{
		}

		// Token: 0x06029062 RID: 168034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029062")]
		[Address(RVA = "0x2469240", Offset = "0x2467E40", VA = "0x182469240")]
		private static IEnumerator _ReceiveItemsCoroutine(List<ActivityItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x06029063 RID: 168035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029063")]
		[Address(RVA = "0x2469510", Offset = "0x2468110", VA = "0x182469510")]
		public Act1BossRushMileStoneState()
		{
		}

		// Token: 0x06029067 RID: 168039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029067")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029068 RID: 168040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029068")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0403A8ED RID: 239853
		[Token(Token = "0x403A8ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1BossRushMileStoneView _view;

		// Token: 0x0403A8EE RID: 239854
		[Token(Token = "0x403A8EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenu;

		// Token: 0x0403A8EF RID: 239855
		[Token(Token = "0x403A8EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Act1BossRushMileStoneStateBean m_stateBean;

		// Token: 0x0403A8F0 RID: 239856
		[Token(Token = "0x403A8F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403A8F1 RID: 239857
		[Token(Token = "0x403A8F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403A8F2 RID: 239858
		[Token(Token = "0x403A8F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A8F3 RID: 239859
		[Token(Token = "0x403A8F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403A8F4 RID: 239860
		[Token(Token = "0x403A8F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x0403A8F5 RID: 239861
		[Token(Token = "0x403A8F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnGetAllClick;

		// Token: 0x0403A8F6 RID: 239862
		[Token(Token = "0x403A8F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A8F7 RID: 239863
		[Token(Token = "0x403A8F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshView;

		// Token: 0x0403A8F8 RID: 239864
		[Token(Token = "0x403A8F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403A8F9 RID: 239865
		[Token(Token = "0x403A8F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
