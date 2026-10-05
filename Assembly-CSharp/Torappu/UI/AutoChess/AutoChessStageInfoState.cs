using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200638C RID: 25484
	[Token(Token = "0x200638C")]
	public class AutoChessStageInfoState : AutoChessPrepareBaseState, IValueMsgReceiver, IAutoChessPrepareStateHandler, IHotfixable
	{
		// Token: 0x06024C1D RID: 150557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C1D")]
		[Address(RVA = "0x1FAA410", Offset = "0x1FA9010", VA = "0x181FAA410", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024C1E RID: 150558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C1E")]
		[Address(RVA = "0x1FAA8D0", Offset = "0x1FA94D0", VA = "0x181FAA8D0", Slot = "31")]
		protected override void OnStateEnter()
		{
		}

		// Token: 0x06024C1F RID: 150559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C1F")]
		[Address(RVA = "0x1FAAE90", Offset = "0x1FA9A90", VA = "0x181FAAE90", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06024C20 RID: 150560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C20")]
		[Address(RVA = "0x1FAA470", Offset = "0x1FA9070", VA = "0x181FAA470", Slot = "33")]
		public void OnDataChanged(AutoChessPrepareModel model)
		{
		}

		// Token: 0x06024C21 RID: 150561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C21")]
		[Address(RVA = "0x1FAA560", Offset = "0x1FA9160", VA = "0x181FAA560")]
		private void OnDestroy()
		{
		}

		// Token: 0x06024C22 RID: 150562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C22")]
		[Address(RVA = "0x1FAA610", Offset = "0x1FA9210", VA = "0x181FAA610", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06024C23 RID: 150563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C23")]
		[Address(RVA = "0x1FAAFE0", Offset = "0x1FA9BE0", VA = "0x181FAAFE0")]
		private void _EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x06024C24 RID: 150564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C24")]
		[Address(RVA = "0x1FAB150", Offset = "0x1FA9D50", VA = "0x181FAB150")]
		private void _EventOnTutorialFocusItem(string itemType)
		{
		}

		// Token: 0x06024C25 RID: 150565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C25")]
		[Address(RVA = "0x1FAB0B0", Offset = "0x1FA9CB0", VA = "0x181FAB0B0")]
		private void _EventOnTutorialFocusItemComplete()
		{
		}

		// Token: 0x06024C26 RID: 150566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C26")]
		[Address(RVA = "0x1FAB1E0", Offset = "0x1FA9DE0", VA = "0x181FAB1E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024C27 RID: 150567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C27")]
		[Address(RVA = "0x1FAB360", Offset = "0x1FA9F60", VA = "0x181FAB360")]
		public AutoChessStageInfoState()
		{
		}

		// Token: 0x06024C29 RID: 150569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C29")]
		[Address(RVA = "0x1F9E180", Offset = "0x1F9CD80", VA = "0x181F9E180")]
		private void <>xLuaBaseProxy_OnStateEnter()
		{
		}

		// Token: 0x06024C2A RID: 150570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C2A")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x040335A9 RID: 210345
		[Token(Token = "0x40335A9")]
		[NonSerialized]
		public const int ON_CONFIRM_BTN_CLICKED = 0;

		// Token: 0x040335AA RID: 210346
		[Token(Token = "0x40335AA")]
		[NonSerialized]
		public const int ON_FOCUS_ITEM = 1;

		// Token: 0x040335AB RID: 210347
		[Token(Token = "0x40335AB")]
		[NonSerialized]
		public const int ON_FOCUS_ANIM_COMPLETE = 2;

		// Token: 0x040335AC RID: 210348
		[Token(Token = "0x40335AC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AutoChessStageInfoGroupView _prefabInfo;

		// Token: 0x040335AD RID: 210349
		[Token(Token = "0x40335AD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _infoContainer;

		// Token: 0x040335AE RID: 210350
		[Token(Token = "0x40335AE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AutoChessStageInfoView _infoView;

		// Token: 0x040335AF RID: 210351
		[Token(Token = "0x40335AF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x040335B0 RID: 210352
		[Token(Token = "0x40335B0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AutoChessStageInfoAVGAdapter _tutorialAdapter;

		// Token: 0x040335B1 RID: 210353
		[Token(Token = "0x40335B1")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x040335B2 RID: 210354
		[Token(Token = "0x40335B2")]
		[FieldOffset(Offset = "0xB8")]
		private AutoChessStageInfoGroupView m_infoView;

		// Token: 0x040335B3 RID: 210355
		[Token(Token = "0x40335B3")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040335B4 RID: 210356
		[Token(Token = "0x40335B4")]
		[FieldOffset(Offset = "0xD0")]
		private AutoChessStageInfoStateBean m_stateBean;

		// Token: 0x040335B5 RID: 210357
		[Token(Token = "0x40335B5")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_entryAnim;

		// Token: 0x040335B6 RID: 210358
		[Token(Token = "0x40335B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040335B7 RID: 210359
		[Token(Token = "0x40335B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateEnter;

		// Token: 0x040335B8 RID: 210360
		[Token(Token = "0x40335B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x040335B9 RID: 210361
		[Token(Token = "0x40335B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDataChanged;

		// Token: 0x040335BA RID: 210362
		[Token(Token = "0x40335BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040335BB RID: 210363
		[Token(Token = "0x40335BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040335BC RID: 210364
		[Token(Token = "0x40335BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnConfirmBtnClicked;

		// Token: 0x040335BD RID: 210365
		[Token(Token = "0x40335BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnTutorialFocusItem;

		// Token: 0x040335BE RID: 210366
		[Token(Token = "0x40335BE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnTutorialFocusItemComplete;

		// Token: 0x040335BF RID: 210367
		[Token(Token = "0x40335BF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040335C0 RID: 210368
		[Token(Token = "0x40335C0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
