using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006503 RID: 25859
	[Token(Token = "0x2006503")]
	public class AutoChessBattleShopPanel : AutoChessBattleUIPanelBase
	{
		// Token: 0x06025297 RID: 152215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025297")]
		[Address(RVA = "0x201C090", Offset = "0x201AC90", VA = "0x18201C090", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x06025298 RID: 152216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025298")]
		[Address(RVA = "0x201C350", Offset = "0x201AF50", VA = "0x18201C350")]
		private void _InitIfNot(AutoChessBattleUIViewModel model)
		{
		}

		// Token: 0x06025299 RID: 152217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025299")]
		[Address(RVA = "0x201C570", Offset = "0x201B170", VA = "0x18201C570")]
		private void _ShowToast(string textId)
		{
		}

		// Token: 0x0602529A RID: 152218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602529A")]
		[Address(RVA = "0x201BD40", Offset = "0x201A940", VA = "0x18201BD40")]
		public void EventOnDisabledClick()
		{
		}

		// Token: 0x0602529B RID: 152219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602529B")]
		[Address(RVA = "0x201BDB0", Offset = "0x201A9B0", VA = "0x18201BDB0")]
		public void EventOnEnabledClick()
		{
		}

		// Token: 0x0602529C RID: 152220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602529C")]
		[Address(RVA = "0x201BF30", Offset = "0x201AB30", VA = "0x18201BF30")]
		public void EventOnUnfoldClick()
		{
		}

		// Token: 0x0602529D RID: 152221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602529D")]
		[Address(RVA = "0x201C490", Offset = "0x201B090", VA = "0x18201C490")]
		private void _ReqOpen(bool isOpen)
		{
		}

		// Token: 0x0602529E RID: 152222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602529E")]
		[Address(RVA = "0x201BEA0", Offset = "0x201AAA0", VA = "0x18201BEA0")]
		public void EventOnRefresh()
		{
		}

		// Token: 0x0602529F RID: 152223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602529F")]
		[Address(RVA = "0x201BE10", Offset = "0x201AA10", VA = "0x18201BE10")]
		public void EventOnFreeze()
		{
		}

		// Token: 0x060252A0 RID: 152224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A0")]
		[Address(RVA = "0x201C000", Offset = "0x201AC00", VA = "0x18201C000")]
		public void EventOnUpgrade()
		{
		}

		// Token: 0x060252A1 RID: 152225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A1")]
		[Address(RVA = "0x201BF90", Offset = "0x201AB90", VA = "0x18201BF90")]
		public void EventOnUpgradeNotEnough()
		{
		}

		// Token: 0x060252A2 RID: 152226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A2")]
		[Address(RVA = "0x201C280", Offset = "0x201AE80", VA = "0x18201C280")]
		private void _EventOnBuy(int slotId)
		{
		}

		// Token: 0x060252A3 RID: 152227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A3")]
		[Address(RVA = "0x201BC40", Offset = "0x201A840", VA = "0x18201BC40")]
		public void EventOnClickOuter()
		{
		}

		// Token: 0x060252A4 RID: 152228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A4")]
		[Address(RVA = "0x201C610", Offset = "0x201B210", VA = "0x18201C610")]
		public AutoChessBattleShopPanel()
		{
		}

		// Token: 0x040341D9 RID: 213465
		[Token(Token = "0x40341D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessBattleShopMainView _mainView;

		// Token: 0x040341DA RID: 213466
		[Token(Token = "0x40341DA")]
		[FieldOffset(Offset = "0x28")]
		private bool m_inited;

		// Token: 0x040341DB RID: 213467
		[Token(Token = "0x40341DB")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040341DC RID: 213468
		[Token(Token = "0x40341DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040341DD RID: 213469
		[Token(Token = "0x40341DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040341DE RID: 213470
		[Token(Token = "0x40341DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowToast;

		// Token: 0x040341DF RID: 213471
		[Token(Token = "0x40341DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnDisabledClick;

		// Token: 0x040341E0 RID: 213472
		[Token(Token = "0x40341E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnEnabledClick;

		// Token: 0x040341E1 RID: 213473
		[Token(Token = "0x40341E1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnUnfoldClick;

		// Token: 0x040341E2 RID: 213474
		[Token(Token = "0x40341E2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ReqOpen;

		// Token: 0x040341E3 RID: 213475
		[Token(Token = "0x40341E3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnRefresh;

		// Token: 0x040341E4 RID: 213476
		[Token(Token = "0x40341E4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnFreeze;

		// Token: 0x040341E5 RID: 213477
		[Token(Token = "0x40341E5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnUpgrade;

		// Token: 0x040341E6 RID: 213478
		[Token(Token = "0x40341E6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnUpgradeNotEnough;

		// Token: 0x040341E7 RID: 213479
		[Token(Token = "0x40341E7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnBuy;

		// Token: 0x040341E8 RID: 213480
		[Token(Token = "0x40341E8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnClickOuter;

		// Token: 0x040341E9 RID: 213481
		[Token(Token = "0x40341E9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
