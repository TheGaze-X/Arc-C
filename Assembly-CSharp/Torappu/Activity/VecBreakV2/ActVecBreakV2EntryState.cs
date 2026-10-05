using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E34 RID: 28212
	[Token(Token = "0x2006E34")]
	public class ActVecBreakV2EntryState : State, IValueMsgReceiver
	{
		// Token: 0x0602826C RID: 164460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602826C")]
		[Address(RVA = "0x236F9F0", Offset = "0x236E5F0", VA = "0x18236F9F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602826D RID: 164461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602826D")]
		[Address(RVA = "0x236FD70", Offset = "0x236E970", VA = "0x18236FD70", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602826E RID: 164462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602826E")]
		[Address(RVA = "0x2370620", Offset = "0x236F220", VA = "0x182370620")]
		private void _EventOnBtnHardZoneClick()
		{
		}

		// Token: 0x0602826F RID: 164463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602826F")]
		[Address(RVA = "0x2370380", Offset = "0x236EF80", VA = "0x182370380")]
		private void _EventOnBtnDefenseZoneClick()
		{
		}

		// Token: 0x06028270 RID: 164464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028270")]
		[Address(RVA = "0x2370980", Offset = "0x236F580", VA = "0x182370980")]
		private void _EventOnBtnOffenseZoneClick()
		{
		}

		// Token: 0x06028271 RID: 164465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028271")]
		[Address(RVA = "0x23708C0", Offset = "0x236F4C0", VA = "0x1823708C0")]
		private void _EventOnBtnMileStoneClicked()
		{
		}

		// Token: 0x06028272 RID: 164466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028272")]
		[Address(RVA = "0x2370170", Offset = "0x236ED70", VA = "0x182370170", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028273 RID: 164467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028273")]
		[Address(RVA = "0x2370CE0", Offset = "0x236F8E0", VA = "0x182370CE0")]
		private void _OnJumpToMedalGroupDisplayState(IStateBean stateBean)
		{
		}

		// Token: 0x06028274 RID: 164468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028274")]
		[Address(RVA = "0x236FA50", Offset = "0x236E650", VA = "0x18236FA50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028275 RID: 164469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028275")]
		[Address(RVA = "0x2370040", Offset = "0x236EC40", VA = "0x182370040", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x06028276 RID: 164470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028276")]
		[Address(RVA = "0x2370AD0", Offset = "0x236F6D0", VA = "0x182370AD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028277 RID: 164471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028277")]
		[Address(RVA = "0x23702D0", Offset = "0x236EED0", VA = "0x1823702D0")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x06028278 RID: 164472 RVA: 0x000D0C98 File Offset: 0x000CEE98
		[Token(Token = "0x6028278")]
		[Address(RVA = "0x2370C20", Offset = "0x236F820", VA = "0x182370C20")]
		private bool _IsUIStable()
		{
			return default(bool);
		}

		// Token: 0x06028279 RID: 164473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028279")]
		[Address(RVA = "0x2370E40", Offset = "0x236FA40", VA = "0x182370E40")]
		private void _OpenOffensePage(bool isHard)
		{
		}

		// Token: 0x0602827A RID: 164474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602827A")]
		[Address(RVA = "0x236F8E0", Offset = "0x236E4E0", VA = "0x18236F8E0")]
		public void EventOnBtnAchievementClick()
		{
		}

		// Token: 0x0602827B RID: 164475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602827B")]
		[Address(RVA = "0x236F950", Offset = "0x236E550", VA = "0x18236F950")]
		public void EventOnBtnMedalClick()
		{
		}

		// Token: 0x0602827C RID: 164476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602827C")]
		[Address(RVA = "0x2370F90", Offset = "0x236FB90", VA = "0x182370F90")]
		public ActVecBreakV2EntryState()
		{
		}

		// Token: 0x0602827D RID: 164477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602827D")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602827E RID: 164478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602827E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602827F RID: 164479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602827F")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x04039045 RID: 233541
		[Token(Token = "0x4039045")]
		public const int MSG_OFFENSE_ZONE_CLICK = 1;

		// Token: 0x04039046 RID: 233542
		[Token(Token = "0x4039046")]
		public const int MSG_DEFENSE_ZONE_CLICK = 2;

		// Token: 0x04039047 RID: 233543
		[Token(Token = "0x4039047")]
		public const int MSG_HARD_ZONE_CLICK = 3;

		// Token: 0x04039048 RID: 233544
		[Token(Token = "0x4039048")]
		public const int MSG_MILESTONE_CLICK = 4;

		// Token: 0x04039049 RID: 233545
		[Token(Token = "0x4039049")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403904A RID: 233546
		[Token(Token = "0x403904A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActVecBreakV2EntryView _view;

		// Token: 0x0403904B RID: 233547
		[Token(Token = "0x403904B")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403904C RID: 233548
		[Token(Token = "0x403904C")]
		[FieldOffset(Offset = "0x68")]
		private string m_actId;

		// Token: 0x0403904D RID: 233549
		[Token(Token = "0x403904D")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403904E RID: 233550
		[Token(Token = "0x403904E")]
		[FieldOffset(Offset = "0x80")]
		private ActVecBreakV2EntryStateBean m_stateBean;

		// Token: 0x0403904F RID: 233551
		[Token(Token = "0x403904F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039050 RID: 233552
		[Token(Token = "0x4039050")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04039051 RID: 233553
		[Token(Token = "0x4039051")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnBtnHardZoneClick;

		// Token: 0x04039052 RID: 233554
		[Token(Token = "0x4039052")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnBtnDefenseZoneClick;

		// Token: 0x04039053 RID: 233555
		[Token(Token = "0x4039053")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnBtnOffenseZoneClick;

		// Token: 0x04039054 RID: 233556
		[Token(Token = "0x4039054")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnBtnMileStoneClicked;

		// Token: 0x04039055 RID: 233557
		[Token(Token = "0x4039055")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04039056 RID: 233558
		[Token(Token = "0x4039056")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJumpToMedalGroupDisplayState;

		// Token: 0x04039057 RID: 233559
		[Token(Token = "0x4039057")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039058 RID: 233560
		[Token(Token = "0x4039058")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04039059 RID: 233561
		[Token(Token = "0x4039059")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403905A RID: 233562
		[Token(Token = "0x403905A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x0403905B RID: 233563
		[Token(Token = "0x403905B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__IsUIStable;

		// Token: 0x0403905C RID: 233564
		[Token(Token = "0x403905C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OpenOffensePage;

		// Token: 0x0403905D RID: 233565
		[Token(Token = "0x403905D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnBtnAchievementClick;

		// Token: 0x0403905E RID: 233566
		[Token(Token = "0x403905E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnBtnMedalClick;

		// Token: 0x0403905F RID: 233567
		[Token(Token = "0x403905F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
