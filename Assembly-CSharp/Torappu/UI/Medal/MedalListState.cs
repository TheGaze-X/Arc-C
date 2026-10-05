using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004961 RID: 18785
	[Token(Token = "0x2004961")]
	public class MedalListState : PopupFadeState, IMedalListFilterHandler
	{
		// Token: 0x0601C501 RID: 115969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C501")]
		[Address(RVA = "0x15D3EF0", Offset = "0x15D2AF0", VA = "0x1815D3EF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C502 RID: 115970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C502")]
		[Address(RVA = "0x15D4810", Offset = "0x15D3410", VA = "0x1815D4810", Slot = "29")]
		protected override void SetRootViewActive(CanvasGroup rootView, bool active)
		{
		}

		// Token: 0x0601C503 RID: 115971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C503")]
		[Address(RVA = "0x15D40C0", Offset = "0x15D2CC0", VA = "0x1815D40C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C504 RID: 115972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C504")]
		[Address(RVA = "0x15D4690", Offset = "0x15D3290", VA = "0x1815D4690", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C505 RID: 115973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C505")]
		[Address(RVA = "0x15D4240", Offset = "0x15D2E40", VA = "0x1815D4240")]
		public void OnGetMedalReward(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C506 RID: 115974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C506")]
		[Address(RVA = "0x15D4910", Offset = "0x15D3510", VA = "0x1815D4910")]
		private void _OnReceiveItemSucceed(GetRewardMedalResponse response)
		{
		}

		// Token: 0x0601C507 RID: 115975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C507")]
		[Address(RVA = "0x15D4740", Offset = "0x15D3340", VA = "0x1815D4740")]
		public IEnumerator ReceiveItemsCoroutine(List<ItemGet> items)
		{
			return null;
		}

		// Token: 0x0601C508 RID: 115976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C508")]
		[Address(RVA = "0x15D3F50", Offset = "0x15D2B50", VA = "0x1815D3F50")]
		public void OnClickMedalEvent(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C509 RID: 115977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C509")]
		[Address(RVA = "0x15D44C0", Offset = "0x15D30C0", VA = "0x1815D44C0")]
		public void OnJumpToGroupList(string groupId)
		{
		}

		// Token: 0x0601C50A RID: 115978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C50A")]
		[Address(RVA = "0x15D4610", Offset = "0x15D3210", VA = "0x1815D4610", Slot = "32")]
		public virtual void OnMedalFilterChanged()
		{
		}

		// Token: 0x0601C50B RID: 115979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C50B")]
		[Address(RVA = "0x15D4A90", Offset = "0x15D3690", VA = "0x1815D4A90")]
		public MedalListState()
		{
		}

		// Token: 0x0601C50D RID: 115981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C50D")]
		[Address(RVA = "0x15D4900", Offset = "0x15D3500", VA = "0x1815D4900")]
		private void <>xLuaBaseProxy_SetRootViewActive(CanvasGroup P0, bool P1)
		{
		}

		// Token: 0x0601C50E RID: 115982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C50E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601C50F RID: 115983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C50F")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402508B RID: 151691
		[Token(Token = "0x402508B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MedalGroupListView _listView;

		// Token: 0x0402508C RID: 151692
		[Token(Token = "0x402508C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MedalListStateBean _stateBean;

		// Token: 0x0402508D RID: 151693
		[Token(Token = "0x402508D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402508E RID: 151694
		[Token(Token = "0x402508E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetRootViewActive;

		// Token: 0x0402508F RID: 151695
		[Token(Token = "0x402508F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025090 RID: 151696
		[Token(Token = "0x4025090")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025091 RID: 151697
		[Token(Token = "0x4025091")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnGetMedalReward;

		// Token: 0x04025092 RID: 151698
		[Token(Token = "0x4025092")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnReceiveItemSucceed;

		// Token: 0x04025093 RID: 151699
		[Token(Token = "0x4025093")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x04025094 RID: 151700
		[Token(Token = "0x4025094")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickMedalEvent;

		// Token: 0x04025095 RID: 151701
		[Token(Token = "0x4025095")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnJumpToGroupList;

		// Token: 0x04025096 RID: 151702
		[Token(Token = "0x4025096")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnMedalFilterChanged;

		// Token: 0x04025097 RID: 151703
		[Token(Token = "0x4025097")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
