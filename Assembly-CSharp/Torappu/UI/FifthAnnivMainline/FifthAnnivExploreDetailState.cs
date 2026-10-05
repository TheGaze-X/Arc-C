using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EA9 RID: 20137
	[Token(Token = "0x2004EA9")]
	public class FifthAnnivExploreDetailState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601E0AF RID: 123055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E0AF")]
		[Address(RVA = "0x17B8670", Offset = "0x17B7270", VA = "0x1817B8670", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E0B0 RID: 123056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B0")]
		[Address(RVA = "0x17B88B0", Offset = "0x17B74B0", VA = "0x1817B88B0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601E0B1 RID: 123057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B1")]
		[Address(RVA = "0x17B9210", Offset = "0x17B7E10", VA = "0x1817B9210")]
		private void _ConfirmOption(string optionId)
		{
		}

		// Token: 0x0601E0B2 RID: 123058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B2")]
		[Address(RVA = "0x17B9170", Offset = "0x17B7D70", VA = "0x1817B9170")]
		private void _ConfirmLogContinue()
		{
		}

		// Token: 0x0601E0B3 RID: 123059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B3")]
		[Address(RVA = "0x17B8E80", Offset = "0x17B7A80", VA = "0x1817B8E80")]
		private void _ConfirmEventOptionClick(FifthAnnivExploreOptionModel currOptionModel)
		{
		}

		// Token: 0x0601E0B4 RID: 123060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B4")]
		[Address(RVA = "0x17B9F90", Offset = "0x17B8B90", VA = "0x1817B9F90")]
		private void _NavToEvtResultView(FifthAnnivService.ExploreSelectEventOptionResponse response)
		{
		}

		// Token: 0x0601E0B5 RID: 123061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B5")]
		[Address(RVA = "0x17B9480", Offset = "0x17B8080", VA = "0x1817B9480")]
		private void _ConfirmTargetOptionClick(FifthAnnivExploreOptionModel currOptionModel)
		{
		}

		// Token: 0x0601E0B6 RID: 123062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B6")]
		[Address(RVA = "0x17BA2A0", Offset = "0x17B8EA0", VA = "0x1817BA2A0")]
		private void _NavToTargetResultState(FifthAnnivService.ExploreSelectTargetOptionResponse obj)
		{
		}

		// Token: 0x0601E0B7 RID: 123063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B7")]
		[Address(RVA = "0x17B9D00", Offset = "0x17B8900", VA = "0x1817B9D00")]
		private void _JumpToPrevEvt()
		{
		}

		// Token: 0x0601E0B8 RID: 123064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B8")]
		[Address(RVA = "0x17B9A70", Offset = "0x17B8670", VA = "0x1817B9A70")]
		private void _JumpToNextEvt()
		{
		}

		// Token: 0x0601E0B9 RID: 123065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0B9")]
		[Address(RVA = "0x17BA440", Offset = "0x17B9040", VA = "0x1817BA440")]
		private void _SelectOption(string optionId)
		{
		}

		// Token: 0x0601E0BA RID: 123066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0BA")]
		[Address(RVA = "0x17BA0B0", Offset = "0x17B8CB0", VA = "0x1817BA0B0")]
		private void _NavToOptionView(string choiceId)
		{
		}

		// Token: 0x0601E0BB RID: 123067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0BB")]
		[Address(RVA = "0x17B8C20", Offset = "0x17B7820", VA = "0x1817B8C20")]
		private void _BackToPrevious()
		{
		}

		// Token: 0x0601E0BC RID: 123068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0BC")]
		[Address(RVA = "0x17B8DA0", Offset = "0x17B79A0", VA = "0x1817B8DA0")]
		private void _CloseSelf()
		{
		}

		// Token: 0x0601E0BD RID: 123069 RVA: 0x000AD418 File Offset: 0x000AB618
		[Token(Token = "0x601E0BD")]
		[Address(RVA = "0x17B9930", Offset = "0x17B8530", VA = "0x1817B9930")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601E0BE RID: 123070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0BE")]
		[Address(RVA = "0x17B86D0", Offset = "0x17B72D0", VA = "0x1817B86D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E0BF RID: 123071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0BF")]
		[Address(RVA = "0x17B9770", Offset = "0x17B8370", VA = "0x1817B9770")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E0C0 RID: 123072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0C0")]
		[Address(RVA = "0x17BA660", Offset = "0x17B9260", VA = "0x1817BA660")]
		public FifthAnnivExploreDetailState()
		{
		}

		// Token: 0x0601E0C1 RID: 123073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0C1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04027F32 RID: 163634
		[Token(Token = "0x4027F32")]
		[NonSerialized]
		public const int MSG_NAV_TO_OPTION = 1;

		// Token: 0x04027F33 RID: 163635
		[Token(Token = "0x4027F33")]
		[NonSerialized]
		public const int MSG_SELECT_OPTION = 2;

		// Token: 0x04027F34 RID: 163636
		[Token(Token = "0x4027F34")]
		[NonSerialized]
		public const int MSG_JUMP_TO_PREV_EVT = 3;

		// Token: 0x04027F35 RID: 163637
		[Token(Token = "0x4027F35")]
		[NonSerialized]
		public const int MSG_JUMP_TO_NEXT_EVT = 4;

		// Token: 0x04027F36 RID: 163638
		[Token(Token = "0x4027F36")]
		[NonSerialized]
		public const int MSG_OPTION_CONFIRM = 5;

		// Token: 0x04027F37 RID: 163639
		[Token(Token = "0x4027F37")]
		[NonSerialized]
		public const int MSG_LOG_CONTINUE_CONFIRM = 6;

		// Token: 0x04027F38 RID: 163640
		[Token(Token = "0x4027F38")]
		[NonSerialized]
		public const int MSG_BACK_TO_PREVIOUS = 7;

		// Token: 0x04027F39 RID: 163641
		[Token(Token = "0x4027F39")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FifthAnnivExplorePlanView _planPrefab;

		// Token: 0x04027F3A RID: 163642
		[Token(Token = "0x4027F3A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _planContainer;

		// Token: 0x04027F3B RID: 163643
		[Token(Token = "0x4027F3B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private FifthAnnivExploreEventView _eventPrefab;

		// Token: 0x04027F3C RID: 163644
		[Token(Token = "0x4027F3C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _eventContainer;

		// Token: 0x04027F3D RID: 163645
		[Token(Token = "0x4027F3D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private FifthAnnivExploreLogView _logPrefab;

		// Token: 0x04027F3E RID: 163646
		[Token(Token = "0x4027F3E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private FifthAnnivExploreDetailBackButton _backBtn;

		// Token: 0x04027F3F RID: 163647
		[Token(Token = "0x4027F3F")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _logContainer;

		// Token: 0x04027F40 RID: 163648
		[Token(Token = "0x4027F40")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIBlendRTImage _blurImage;

		// Token: 0x04027F41 RID: 163649
		[Token(Token = "0x4027F41")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x04027F42 RID: 163650
		[Token(Token = "0x4027F42")]
		[FieldOffset(Offset = "0xB8")]
		private FifthAnnivExplorePlanView m_planView;

		// Token: 0x04027F43 RID: 163651
		[Token(Token = "0x4027F43")]
		[FieldOffset(Offset = "0xC0")]
		private FifthAnnivExploreEventView m_eventView;

		// Token: 0x04027F44 RID: 163652
		[Token(Token = "0x4027F44")]
		[FieldOffset(Offset = "0xC8")]
		private FifthAnnivExploreLogView m_logView;

		// Token: 0x04027F45 RID: 163653
		[Token(Token = "0x4027F45")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04027F46 RID: 163654
		[Token(Token = "0x4027F46")]
		[FieldOffset(Offset = "0xE0")]
		private FifthAnnivExploreDecisionProp m_decisionProp;

		// Token: 0x04027F47 RID: 163655
		[Token(Token = "0x4027F47")]
		[FieldOffset(Offset = "0xE8")]
		private FifthAnnivExploreDetailStateBean m_stateBean;

		// Token: 0x04027F48 RID: 163656
		[Token(Token = "0x4027F48")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027F49 RID: 163657
		[Token(Token = "0x4027F49")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04027F4A RID: 163658
		[Token(Token = "0x4027F4A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ConfirmOption;

		// Token: 0x04027F4B RID: 163659
		[Token(Token = "0x4027F4B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ConfirmLogContinue;

		// Token: 0x04027F4C RID: 163660
		[Token(Token = "0x4027F4C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ConfirmEventOptionClick;

		// Token: 0x04027F4D RID: 163661
		[Token(Token = "0x4027F4D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__NavToEvtResultView;

		// Token: 0x04027F4E RID: 163662
		[Token(Token = "0x4027F4E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConfirmTargetOptionClick;

		// Token: 0x04027F4F RID: 163663
		[Token(Token = "0x4027F4F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__NavToTargetResultState;

		// Token: 0x04027F50 RID: 163664
		[Token(Token = "0x4027F50")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__JumpToPrevEvt;

		// Token: 0x04027F51 RID: 163665
		[Token(Token = "0x4027F51")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__JumpToNextEvt;

		// Token: 0x04027F52 RID: 163666
		[Token(Token = "0x4027F52")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SelectOption;

		// Token: 0x04027F53 RID: 163667
		[Token(Token = "0x4027F53")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__NavToOptionView;

		// Token: 0x04027F54 RID: 163668
		[Token(Token = "0x4027F54")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__BackToPrevious;

		// Token: 0x04027F55 RID: 163669
		[Token(Token = "0x4027F55")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CloseSelf;

		// Token: 0x04027F56 RID: 163670
		[Token(Token = "0x4027F56")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x04027F57 RID: 163671
		[Token(Token = "0x4027F57")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027F58 RID: 163672
		[Token(Token = "0x4027F58")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027F59 RID: 163673
		[Token(Token = "0x4027F59")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
