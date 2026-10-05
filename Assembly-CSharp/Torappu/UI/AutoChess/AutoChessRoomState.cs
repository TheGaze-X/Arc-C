using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062D8 RID: 25304
	[Token(Token = "0x20062D8")]
	public class AutoChessRoomState : AutoChessPrepareModeChooseBaseState, ICompDialogCallBack, IAutoChessPrepareStateHandler, IHotfixable
	{
		// Token: 0x060247A3 RID: 149411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A3")]
		[Address(RVA = "0x1F4CBF0", Offset = "0x1F4B7F0", VA = "0x181F4CBF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060247A4 RID: 149412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247A4")]
		[Address(RVA = "0x1F4B220", Offset = "0x1F49E20", VA = "0x181F4B220", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060247A5 RID: 149413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A5")]
		[Address(RVA = "0x1F4B8F0", Offset = "0x1F4A4F0", VA = "0x181F4B8F0", Slot = "31")]
		protected override void OnStateEnter()
		{
		}

		// Token: 0x060247A6 RID: 149414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A6")]
		[Address(RVA = "0x1F4B660", Offset = "0x1F4A260", VA = "0x181F4B660", Slot = "33")]
		protected override void OnStateCustomMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060247A7 RID: 149415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A7")]
		[Address(RVA = "0x1F4C130", Offset = "0x1F4AD30", VA = "0x181F4C130")]
		private void _HandleInvite()
		{
		}

		// Token: 0x060247A8 RID: 149416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A8")]
		[Address(RVA = "0x1F4BDB0", Offset = "0x1F4A9B0", VA = "0x181F4BDB0")]
		private void _HandleClickCard(ValueBundle msg, AutoChessRoomViewModel model)
		{
		}

		// Token: 0x060247A9 RID: 149417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247A9")]
		[Address(RVA = "0x1F4BEC0", Offset = "0x1F4AAC0", VA = "0x181F4BEC0")]
		private void _HandleClickKick(ValueBundle msg, AutoChessRoomViewModel model)
		{
		}

		// Token: 0x060247AA RID: 149418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247AA")]
		[Address(RVA = "0x1F4C4F0", Offset = "0x1F4B0F0", VA = "0x181F4C4F0")]
		private void _HandleModeChocieViewClickBlank(AutoChessRoomViewModel model)
		{
		}

		// Token: 0x060247AB RID: 149419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247AB")]
		[Address(RVA = "0x1F4C5B0", Offset = "0x1F4B1B0", VA = "0x181F4C5B0")]
		private void _HandleModeChoiceViewConfirm(AutoChessRoomViewModel model)
		{
		}

		// Token: 0x060247AC RID: 149420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247AC")]
		[Address(RVA = "0x1F4D090", Offset = "0x1F4BC90", VA = "0x181F4D090")]
		private void _SendMsgToController(int key, [Optional] ValueBundle msg)
		{
		}

		// Token: 0x060247AD RID: 149421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60247AD")]
		[Address(RVA = "0x1F4B280", Offset = "0x1F49E80", VA = "0x181F4B280", Slot = "34")]
		protected override AutoChessModeChoiceViewModel GetViewModel()
		{
			return null;
		}

		// Token: 0x060247AE RID: 149422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247AE")]
		[Address(RVA = "0x1F4BC60", Offset = "0x1F4A860", VA = "0x181F4BC60", Slot = "35")]
		protected override void RefreshView()
		{
		}

		// Token: 0x060247AF RID: 149423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247AF")]
		[Address(RVA = "0x1F4B310", Offset = "0x1F49F10", VA = "0x181F4B310", Slot = "36")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x060247B0 RID: 149424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B0")]
		[Address(RVA = "0x1F4B5B0", Offset = "0x1F4A1B0", VA = "0x181F4B5B0", Slot = "38")]
		public void OnDataChanged(AutoChessPrepareModel model)
		{
		}

		// Token: 0x060247B1 RID: 149425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B1")]
		[Address(RVA = "0x1F4BCF0", Offset = "0x1F4A8F0", VA = "0x181F4BCF0")]
		private void _ClearCardShowFoldMenu()
		{
		}

		// Token: 0x060247B2 RID: 149426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B2")]
		[Address(RVA = "0x1F4CCC0", Offset = "0x1F4B8C0", VA = "0x181F4CCC0")]
		private void _KickCachedUID()
		{
		}

		// Token: 0x060247B3 RID: 149427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B3")]
		[Address(RVA = "0x1F4CE20", Offset = "0x1F4BA20", VA = "0x181F4CE20")]
		private void _RefreshRoomData(AutoChessPrepareModel prepareModel, bool isInit = false)
		{
		}

		// Token: 0x060247B4 RID: 149428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B4")]
		[Address(RVA = "0x1F4C960", Offset = "0x1F4B560", VA = "0x181F4C960")]
		private void _HandlePlayersDeltaResult(AutoChessPrepareModel prepareModel, int newPlayerCnt, List<KeyValuePair<string, string>> leavePlayerNamesBuffer)
		{
		}

		// Token: 0x060247B5 RID: 149429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B5")]
		[Address(RVA = "0x1F4C400", Offset = "0x1F4B000", VA = "0x181F4C400")]
		private void _HandleModeChanged(AutoChessRoomViewModel.RefreshDataResult result, AutoChessRoomViewModel viewModel)
		{
		}

		// Token: 0x060247B6 RID: 149430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B6")]
		[Address(RVA = "0x1F4D170", Offset = "0x1F4BD70", VA = "0x181F4D170")]
		private void _ShowKickedPlayersToast(AutoChessPrepareModel prepareModel)
		{
		}

		// Token: 0x060247B7 RID: 149431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B7")]
		[Address(RVA = "0x1F4AB30", Offset = "0x1F49730", VA = "0x181F4AB30")]
		public void EventOnClickNonCardMenu()
		{
		}

		// Token: 0x060247B8 RID: 149432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B8")]
		[Address(RVA = "0x1F4ADF0", Offset = "0x1F499F0", VA = "0x181F4ADF0")]
		public void EventOnClickRoomId()
		{
		}

		// Token: 0x060247B9 RID: 149433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247B9")]
		[Address(RVA = "0x1F4AEC0", Offset = "0x1F49AC0", VA = "0x181F4AEC0")]
		public void EventOnClickSwitchMode()
		{
		}

		// Token: 0x060247BA RID: 149434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247BA")]
		[Address(RVA = "0x1F4AB90", Offset = "0x1F49790", VA = "0x181F4AB90")]
		public void EventOnClickReadyOrLaunchBtn()
		{
		}

		// Token: 0x060247BB RID: 149435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247BB")]
		[Address(RVA = "0x1F4D3A0", Offset = "0x1F4BFA0", VA = "0x181F4D3A0")]
		public AutoChessRoomState()
		{
		}

		// Token: 0x060247BC RID: 149436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60247BC")]
		[Address(RVA = "0x1F25FB0", Offset = "0x1F24BB0", VA = "0x181F25FB0")]
		private void <>xLuaBaseProxy_OnStateEnter()
		{
		}

		// Token: 0x04032CE6 RID: 208102
		[Token(Token = "0x4032CE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AutoChessRoomView _view;

		// Token: 0x04032CE7 RID: 208103
		[Token(Token = "0x4032CE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04032CE8 RID: 208104
		[Token(Token = "0x4032CE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int m_kickDlgInst;

		// Token: 0x04032CE9 RID: 208105
		[Token(Token = "0x4032CE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string m_cacheKickUID;

		// Token: 0x04032CEA RID: 208106
		[Token(Token = "0x4032CEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<string> m_waitKickedUIDs;

		// Token: 0x04032CEB RID: 208107
		[Token(Token = "0x4032CEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032CEC RID: 208108
		[Token(Token = "0x4032CEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AutoChessPreparePage m_page;

		// Token: 0x04032CED RID: 208109
		[Token(Token = "0x4032CED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AutoChessRoomStateBean m_stateBean;

		// Token: 0x04032CEE RID: 208110
		[Token(Token = "0x4032CEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Dictionary<string, long> m_invitedCache;

		// Token: 0x04032CEF RID: 208111
		[Token(Token = "0x4032CEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032CF0 RID: 208112
		[Token(Token = "0x4032CF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04032CF1 RID: 208113
		[Token(Token = "0x4032CF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnStateEnter;

		// Token: 0x04032CF2 RID: 208114
		[Token(Token = "0x4032CF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStateCustomMessage;

		// Token: 0x04032CF3 RID: 208115
		[Token(Token = "0x4032CF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__HandleInvite;

		// Token: 0x04032CF4 RID: 208116
		[Token(Token = "0x4032CF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HandleClickCard;

		// Token: 0x04032CF5 RID: 208117
		[Token(Token = "0x4032CF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleClickKick;

		// Token: 0x04032CF6 RID: 208118
		[Token(Token = "0x4032CF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleModeChocieViewClickBlank;

		// Token: 0x04032CF7 RID: 208119
		[Token(Token = "0x4032CF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandleModeChoiceViewConfirm;

		// Token: 0x04032CF8 RID: 208120
		[Token(Token = "0x4032CF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SendMsgToController;

		// Token: 0x04032CF9 RID: 208121
		[Token(Token = "0x4032CF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetViewModel;

		// Token: 0x04032CFA RID: 208122
		[Token(Token = "0x4032CFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RefreshView;

		// Token: 0x04032CFB RID: 208123
		[Token(Token = "0x4032CFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04032CFC RID: 208124
		[Token(Token = "0x4032CFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnDataChanged;

		// Token: 0x04032CFD RID: 208125
		[Token(Token = "0x4032CFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ClearCardShowFoldMenu;

		// Token: 0x04032CFE RID: 208126
		[Token(Token = "0x4032CFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__KickCachedUID;

		// Token: 0x04032CFF RID: 208127
		[Token(Token = "0x4032CFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RefreshRoomData;

		// Token: 0x04032D00 RID: 208128
		[Token(Token = "0x4032D00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__HandlePlayersDeltaResult;

		// Token: 0x04032D01 RID: 208129
		[Token(Token = "0x4032D01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleModeChanged;

		// Token: 0x04032D02 RID: 208130
		[Token(Token = "0x4032D02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ShowKickedPlayersToast;

		// Token: 0x04032D03 RID: 208131
		[Token(Token = "0x4032D03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnClickNonCardMenu;

		// Token: 0x04032D04 RID: 208132
		[Token(Token = "0x4032D04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnClickRoomId;

		// Token: 0x04032D05 RID: 208133
		[Token(Token = "0x4032D05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnClickSwitchMode;

		// Token: 0x04032D06 RID: 208134
		[Token(Token = "0x4032D06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnClickReadyOrLaunchBtn;

		// Token: 0x04032D07 RID: 208135
		[Token(Token = "0x4032D07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020062D9 RID: 25305
		[Token(Token = "0x20062D9")]
		public static class Event
		{
			// Token: 0x04032D08 RID: 208136
			[Token(Token = "0x4032D08")]
			public const int CLICK_CARD_MENU = 1;

			// Token: 0x04032D09 RID: 208137
			[Token(Token = "0x4032D09")]
			public const int CLICK_CARD_INVITE = 2;

			// Token: 0x04032D0A RID: 208138
			[Token(Token = "0x4032D0A")]
			public const int CLICK_KICK = 3;
		}
	}
}
