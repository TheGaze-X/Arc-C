using System;
using Il2CppDummyDll;
using Torappu.Network;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F9D RID: 28573
	[Token(Token = "0x2006F9D")]
	public class ActMultiV3QuickMatchState : State, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x060288D7 RID: 166103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60288D7")]
		[Address(RVA = "0x23E6260", Offset = "0x23E4E60", VA = "0x1823E6260", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060288D8 RID: 166104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288D8")]
		[Address(RVA = "0x23E6430", Offset = "0x23E5030", VA = "0x1823E6430", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060288D9 RID: 166105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288D9")]
		[Address(RVA = "0x23E6A00", Offset = "0x23E5600", VA = "0x1823E6A00", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060288DA RID: 166106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288DA")]
		[Address(RVA = "0x23E6740", Offset = "0x23E5340", VA = "0x1823E6740", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x060288DB RID: 166107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288DB")]
		[Address(RVA = "0x23E62C0", Offset = "0x23E4EC0", VA = "0x1823E62C0", Slot = "24")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x060288DC RID: 166108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288DC")]
		[Address(RVA = "0x23E8160", Offset = "0x23E6D60", VA = "0x1823E8160")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060288DD RID: 166109 RVA: 0x000D2108 File Offset: 0x000D0308
		[Token(Token = "0x60288DD")]
		[Address(RVA = "0x23E8810", Offset = "0x23E7410", VA = "0x1823E8810")]
		private bool _OnInitMatchResponse(ActMultiV3StartMatchResponse response)
		{
			return default(bool);
		}

		// Token: 0x060288DE RID: 166110 RVA: 0x000D2120 File Offset: 0x000D0320
		[Token(Token = "0x60288DE")]
		[Address(RVA = "0x23E6DC0", Offset = "0x23E59C0", VA = "0x1823E6DC0")]
		private bool _CreateInitRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x060288DF RID: 166111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288DF")]
		[Address(RVA = "0x23E8BC0", Offset = "0x23E77C0", VA = "0x1823E8BC0")]
		private void _OnLoopSenderTick(float waitSec)
		{
		}

		// Token: 0x060288E0 RID: 166112 RVA: 0x000D2138 File Offset: 0x000D0338
		[Token(Token = "0x60288E0")]
		[Address(RVA = "0x23E6D30", Offset = "0x23E5930", VA = "0x1823E6D30")]
		private bool _CreateCancelRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x060288E1 RID: 166113 RVA: 0x000D2150 File Offset: 0x000D0350
		[Token(Token = "0x60288E1")]
		[Address(RVA = "0x23E7410", Offset = "0x23E6010", VA = "0x1823E7410")]
		private bool _CreateQueryRequest(out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x060288E2 RID: 166114 RVA: 0x000D2168 File Offset: 0x000D0368
		[Token(Token = "0x60288E2")]
		[Address(RVA = "0x23E7160", Offset = "0x23E5D60", VA = "0x1823E7160")]
		private bool _CreateMatchQueryRequest(bool isCancel, out Request request, out UISenderRequestParam requestParam)
		{
			return default(bool);
		}

		// Token: 0x060288E3 RID: 166115 RVA: 0x000D2180 File Offset: 0x000D0380
		[Token(Token = "0x60288E3")]
		[Address(RVA = "0x23E8D80", Offset = "0x23E7980", VA = "0x1823E8D80")]
		private bool _OnQueryMatchResponse(ActMultiV3QueryMatchResponse response)
		{
			return default(bool);
		}

		// Token: 0x060288E4 RID: 166116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288E4")]
		[Address(RVA = "0x23E74A0", Offset = "0x23E60A0", VA = "0x1823E74A0")]
		private void _EventOnBtnBack()
		{
		}

		// Token: 0x060288E5 RID: 166117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288E5")]
		[Address(RVA = "0x23E67C0", Offset = "0x23E53C0", VA = "0x1823E67C0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060288E6 RID: 166118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288E6")]
		[Address(RVA = "0x23E7A00", Offset = "0x23E6600", VA = "0x1823E7A00")]
		private void _EventOnNavToRoom()
		{
		}

		// Token: 0x060288E7 RID: 166119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288E7")]
		[Address(RVA = "0x23E7550", Offset = "0x23E6150", VA = "0x1823E7550")]
		private void _EventOnCancelMatchClick()
		{
		}

		// Token: 0x060288E8 RID: 166120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288E8")]
		[Address(RVA = "0x23E7D20", Offset = "0x23E6920", VA = "0x1823E7D20")]
		private void _EventOnPosItemClick(string posTypeStr)
		{
		}

		// Token: 0x060288E9 RID: 166121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288E9")]
		[Address(RVA = "0x23E75C0", Offset = "0x23E61C0", VA = "0x1823E75C0")]
		private void _EventOnDiffItemClick(string modeId)
		{
		}

		// Token: 0x060288EA RID: 166122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288EA")]
		[Address(RVA = "0x23E9160", Offset = "0x23E7D60", VA = "0x1823E9160")]
		private void _StartGuideBattle(ActMultiV3MapModeType modeType)
		{
		}

		// Token: 0x060288EB RID: 166123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60288EB")]
		[Address(RVA = "0x23E8100", Offset = "0x23E6D00", VA = "0x1823E8100")]
		private ILoadAsset _GetAsssetLoader()
		{
			return null;
		}

		// Token: 0x060288EC RID: 166124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288EC")]
		[Address(RVA = "0x23E8070", Offset = "0x23E6C70", VA = "0x1823E8070")]
		private void _EventOnTrainingClick(string modeTypeStr)
		{
		}

		// Token: 0x060288ED RID: 166125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288ED")]
		[Address(RVA = "0x23E77D0", Offset = "0x23E63D0", VA = "0x1823E77D0")]
		private void _EventOnInverseToggle()
		{
		}

		// Token: 0x060288EE RID: 166126 RVA: 0x000D2198 File Offset: 0x000D0398
		[Token(Token = "0x60288EE")]
		[Address(RVA = "0x23E6B40", Offset = "0x23E5740", VA = "0x1823E6B40")]
		private bool _CheckIfSuccess(ActMultiV3StartMatchResponse response, ActMultiV3QuickMatchModel viewModel, out string toastStr)
		{
			return default(bool);
		}

		// Token: 0x060288EF RID: 166127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288EF")]
		[Address(RVA = "0x23E6130", Offset = "0x23E4D30", VA = "0x1823E6130")]
		public void EventOnPosPanelRaycastClick()
		{
		}

		// Token: 0x060288F0 RID: 166128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288F0")]
		[Address(RVA = "0x23E5DF0", Offset = "0x23E49F0", VA = "0x1823E5DF0")]
		public void EventOnBtnPosClick()
		{
		}

		// Token: 0x060288F1 RID: 166129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288F1")]
		[Address(RVA = "0x23E5F20", Offset = "0x23E4B20", VA = "0x1823E5F20")]
		public void EventOnBtnStartMatch()
		{
		}

		// Token: 0x060288F2 RID: 166130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288F2")]
		[Address(RVA = "0x23E9620", Offset = "0x23E8220", VA = "0x1823E9620")]
		public ActMultiV3QuickMatchState()
		{
		}

		// Token: 0x060288F3 RID: 166131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288F3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060288F4 RID: 166132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288F4")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x060288F5 RID: 166133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288F5")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04039C10 RID: 236560
		[Token(Token = "0x4039C10")]
		private const int QUERY_REQUEST_SHORT_INTERVAL = 1;

		// Token: 0x04039C11 RID: 236561
		[Token(Token = "0x4039C11")]
		private const int QUERY_REQUEST_SHORT_INTERVAL_COUNT = 10;

		// Token: 0x04039C12 RID: 236562
		[Token(Token = "0x4039C12")]
		private const int QUERY_REQUEST_LONG_INTERVAL = 5;

		// Token: 0x04039C13 RID: 236563
		[Token(Token = "0x4039C13")]
		private const int QUERY_REQUEST_DELAY = 1;

		// Token: 0x04039C14 RID: 236564
		[Token(Token = "0x4039C14")]
		[NonSerialized]
		public const int MSG_DIFF_ITEM_CLICK = 1;

		// Token: 0x04039C15 RID: 236565
		[Token(Token = "0x4039C15")]
		[NonSerialized]
		public const int MSG_POS_ITEM_CLICK = 2;

		// Token: 0x04039C16 RID: 236566
		[Token(Token = "0x4039C16")]
		[NonSerialized]
		public const int MSG_INVERSE_TOGGLE_CLICK = 3;

		// Token: 0x04039C17 RID: 236567
		[Token(Token = "0x4039C17")]
		[NonSerialized]
		public const int MSG_CANCEL_MATCH_CLICK = 4;

		// Token: 0x04039C18 RID: 236568
		[Token(Token = "0x4039C18")]
		[NonSerialized]
		public const int MSG_NAV_TO_MATCH_ROOM = 5;

		// Token: 0x04039C19 RID: 236569
		[Token(Token = "0x4039C19")]
		[NonSerialized]
		public const int MSG_TRAINING_ITEM_CLICK = 6;

		// Token: 0x04039C1A RID: 236570
		[Token(Token = "0x4039C1A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActMultiV3QuickMatchView _view;

		// Token: 0x04039C1B RID: 236571
		[Token(Token = "0x4039C1B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActMultiV3MatchingView _matchingPrefab;

		// Token: 0x04039C1C RID: 236572
		[Token(Token = "0x4039C1C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _matchingContainer;

		// Token: 0x04039C1D RID: 236573
		[Token(Token = "0x4039C1D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04039C1E RID: 236574
		[Token(Token = "0x4039C1E")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x04039C1F RID: 236575
		[Token(Token = "0x4039C1F")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039C20 RID: 236576
		[Token(Token = "0x4039C20")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3QuickMatchStateBean m_stateBean;

		// Token: 0x04039C21 RID: 236577
		[Token(Token = "0x4039C21")]
		[FieldOffset(Offset = "0x90")]
		private ActMultiV3MatchingView m_matchingView;

		// Token: 0x04039C22 RID: 236578
		[Token(Token = "0x4039C22")]
		[FieldOffset(Offset = "0x98")]
		private int m_trainingStageConfirmDlgInstId;

		// Token: 0x04039C23 RID: 236579
		[Token(Token = "0x4039C23")]
		[FieldOffset(Offset = "0xA0")]
		private string m_cacheStageId;

		// Token: 0x04039C24 RID: 236580
		[Token(Token = "0x4039C24")]
		[FieldOffset(Offset = "0xA8")]
		private ActMultiV3MapModeType m_cacheModeType;

		// Token: 0x04039C25 RID: 236581
		[Token(Token = "0x4039C25")]
		[FieldOffset(Offset = "0xB0")]
		private LoopRequestSender m_loopSender;

		// Token: 0x04039C26 RID: 236582
		[Token(Token = "0x4039C26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039C27 RID: 236583
		[Token(Token = "0x4039C27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039C28 RID: 236584
		[Token(Token = "0x4039C28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04039C29 RID: 236585
		[Token(Token = "0x4039C29")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04039C2A RID: 236586
		[Token(Token = "0x4039C2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04039C2B RID: 236587
		[Token(Token = "0x4039C2B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039C2C RID: 236588
		[Token(Token = "0x4039C2C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnInitMatchResponse;

		// Token: 0x04039C2D RID: 236589
		[Token(Token = "0x4039C2D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CreateInitRequest;

		// Token: 0x04039C2E RID: 236590
		[Token(Token = "0x4039C2E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnLoopSenderTick;

		// Token: 0x04039C2F RID: 236591
		[Token(Token = "0x4039C2F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateCancelRequest;

		// Token: 0x04039C30 RID: 236592
		[Token(Token = "0x4039C30")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CreateQueryRequest;

		// Token: 0x04039C31 RID: 236593
		[Token(Token = "0x4039C31")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CreateMatchQueryRequest;

		// Token: 0x04039C32 RID: 236594
		[Token(Token = "0x4039C32")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnQueryMatchResponse;

		// Token: 0x04039C33 RID: 236595
		[Token(Token = "0x4039C33")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnBtnBack;

		// Token: 0x04039C34 RID: 236596
		[Token(Token = "0x4039C34")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04039C35 RID: 236597
		[Token(Token = "0x4039C35")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnNavToRoom;

		// Token: 0x04039C36 RID: 236598
		[Token(Token = "0x4039C36")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnCancelMatchClick;

		// Token: 0x04039C37 RID: 236599
		[Token(Token = "0x4039C37")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnPosItemClick;

		// Token: 0x04039C38 RID: 236600
		[Token(Token = "0x4039C38")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnDiffItemClick;

		// Token: 0x04039C39 RID: 236601
		[Token(Token = "0x4039C39")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__StartGuideBattle;

		// Token: 0x04039C3A RID: 236602
		[Token(Token = "0x4039C3A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetAsssetLoader;

		// Token: 0x04039C3B RID: 236603
		[Token(Token = "0x4039C3B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOnTrainingClick;

		// Token: 0x04039C3C RID: 236604
		[Token(Token = "0x4039C3C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventOnInverseToggle;

		// Token: 0x04039C3D RID: 236605
		[Token(Token = "0x4039C3D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CheckIfSuccess;

		// Token: 0x04039C3E RID: 236606
		[Token(Token = "0x4039C3E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnPosPanelRaycastClick;

		// Token: 0x04039C3F RID: 236607
		[Token(Token = "0x4039C3F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventOnBtnPosClick;

		// Token: 0x04039C40 RID: 236608
		[Token(Token = "0x4039C40")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnBtnStartMatch;

		// Token: 0x04039C41 RID: 236609
		[Token(Token = "0x4039C41")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
