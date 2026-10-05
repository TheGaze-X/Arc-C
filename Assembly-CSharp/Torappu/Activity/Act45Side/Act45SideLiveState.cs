using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072BF RID: 29375
	[Token(Token = "0x20072BF")]
	public class Act45SideLiveState : PopupFadeState, ICompDialogCallBack, IValueMsgReceiver
	{
		// Token: 0x06029935 RID: 170293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029935")]
		[Address(RVA = "0x24F4580", Offset = "0x24F3180", VA = "0x1824F4580", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029936 RID: 170294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029936")]
		[Address(RVA = "0x24F45E0", Offset = "0x24F31E0", VA = "0x1824F45E0", Slot = "31")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06029937 RID: 170295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029937")]
		[Address(RVA = "0x24F48F0", Offset = "0x24F34F0", VA = "0x1824F48F0", Slot = "33")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06029938 RID: 170296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029938")]
		[Address(RVA = "0x24F4150", Offset = "0x24F2D50", VA = "0x1824F4150")]
		public void EventOnCallBtnClicked()
		{
		}

		// Token: 0x06029939 RID: 170297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029939")]
		[Address(RVA = "0x24F42A0", Offset = "0x24F2EA0", VA = "0x1824F42A0")]
		public void EventOnReviewMailClicked()
		{
		}

		// Token: 0x0602993A RID: 170298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602993A")]
		[Address(RVA = "0x24F4340", Offset = "0x24F2F40", VA = "0x1824F4340")]
		public void EventOnSwitchStateClicked()
		{
		}

		// Token: 0x0602993B RID: 170299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602993B")]
		[Address(RVA = "0x24F4CE0", Offset = "0x24F38E0", VA = "0x1824F4CE0")]
		public void PlayEnterAnim()
		{
		}

		// Token: 0x0602993C RID: 170300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602993C")]
		[Address(RVA = "0x24F4750", Offset = "0x24F3350", VA = "0x1824F4750", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602993D RID: 170301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602993D")]
		[Address(RVA = "0x24F4BB0", Offset = "0x24F37B0", VA = "0x1824F4BB0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602993E RID: 170302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602993E")]
		[Address(RVA = "0x24F4FC0", Offset = "0x24F3BC0", VA = "0x1824F4FC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602993F RID: 170303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602993F")]
		[Address(RVA = "0x24F5C70", Offset = "0x24F4870", VA = "0x1824F5C70")]
		private void _TriggerAnimSteps()
		{
		}

		// Token: 0x06029940 RID: 170304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029940")]
		[Address(RVA = "0x24F5CE0", Offset = "0x24F48E0", VA = "0x1824F5CE0")]
		private void _TryPlayNextAnimStep()
		{
		}

		// Token: 0x06029941 RID: 170305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029941")]
		[Address(RVA = "0x24F4E60", Offset = "0x24F3A60", VA = "0x1824F4E60")]
		private IEnumerator _AnimStepWaitForSeconds()
		{
			return null;
		}

		// Token: 0x06029942 RID: 170306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029942")]
		[Address(RVA = "0x24F5A90", Offset = "0x24F4690", VA = "0x1824F5A90")]
		private void _SetMusic()
		{
		}

		// Token: 0x06029943 RID: 170307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029943")]
		[Address(RVA = "0x24F5120", Offset = "0x24F3D20", VA = "0x1824F5120")]
		private void _OnCharCardClicked(string clickedId)
		{
		}

		// Token: 0x06029944 RID: 170308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029944")]
		[Address(RVA = "0x24F4F10", Offset = "0x24F3B10", VA = "0x1824F4F10")]
		private IEnumerator _CharLockPanelCoroutine()
		{
			return null;
		}

		// Token: 0x06029945 RID: 170309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029945")]
		[Address(RVA = "0x24F52E0", Offset = "0x24F3EE0", VA = "0x1824F52E0")]
		private void _OpenCharUnlockDialog()
		{
		}

		// Token: 0x06029946 RID: 170310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029946")]
		[Address(RVA = "0x24F5740", Offset = "0x24F4340", VA = "0x1824F5740")]
		private void _OpenMailDialog(Act45SideMailDialog.EntryType entryType)
		{
		}

		// Token: 0x06029947 RID: 170311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029947")]
		[Address(RVA = "0x24F5520", Offset = "0x24F4120", VA = "0x1824F5520")]
		private void _OpenClockDialog()
		{
		}

		// Token: 0x06029948 RID: 170312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029948")]
		[Address(RVA = "0x24F5F50", Offset = "0x24F4B50", VA = "0x1824F5F50")]
		public Act45SideLiveState()
		{
		}

		// Token: 0x0602994A RID: 170314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602994A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602994B RID: 170315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602994B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403B736 RID: 243510
		[Token(Token = "0x403B736")]
		private const string CHAR_UNLOCK_DLG_NAME = "char_unlock_dialog";

		// Token: 0x0403B737 RID: 243511
		[Token(Token = "0x403B737")]
		private const string MAIL_DLG_NAME = "mail_dialog";

		// Token: 0x0403B738 RID: 243512
		[Token(Token = "0x403B738")]
		private const string CLOCK_DLG_NAME = "clock_dialog";

		// Token: 0x0403B739 RID: 243513
		[Token(Token = "0x403B739")]
		[NonSerialized]
		public const int MSG_CHAR_CARD_CLICK = 0;

		// Token: 0x0403B73A RID: 243514
		[Token(Token = "0x403B73A")]
		public const int MSG_ON_CALL_END = 1;

		// Token: 0x0403B73B RID: 243515
		[Token(Token = "0x403B73B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act45SideLiveView _view;

		// Token: 0x0403B73C RID: 243516
		[Token(Token = "0x403B73C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _curtainOutWaitTime;

		// Token: 0x0403B73D RID: 243517
		[Token(Token = "0x403B73D")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float _lockPanelShowTime;

		// Token: 0x0403B73E RID: 243518
		[Token(Token = "0x403B73E")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0403B73F RID: 243519
		[Token(Token = "0x403B73F")]
		[FieldOffset(Offset = "0x84")]
		private int m_currAnimStep;

		// Token: 0x0403B740 RID: 243520
		[Token(Token = "0x403B740")]
		[FieldOffset(Offset = "0x88")]
		private int m_charUnlockDlgInst;

		// Token: 0x0403B741 RID: 243521
		[Token(Token = "0x403B741")]
		[FieldOffset(Offset = "0x8C")]
		private int m_mailDlgInst;

		// Token: 0x0403B742 RID: 243522
		[Token(Token = "0x403B742")]
		[FieldOffset(Offset = "0x90")]
		private int m_clockDlgInst;

		// Token: 0x0403B743 RID: 243523
		[Token(Token = "0x403B743")]
		[FieldOffset(Offset = "0x98")]
		private Act45SideLivePage m_page;

		// Token: 0x0403B744 RID: 243524
		[Token(Token = "0x403B744")]
		[FieldOffset(Offset = "0xA0")]
		private Act45SideLiveProperty m_prop;

		// Token: 0x0403B745 RID: 243525
		[Token(Token = "0x403B745")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine m_lockPanelCoroutine;

		// Token: 0x0403B746 RID: 243526
		[Token(Token = "0x403B746")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B747 RID: 243527
		[Token(Token = "0x403B747")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403B748 RID: 243528
		[Token(Token = "0x403B748")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403B749 RID: 243529
		[Token(Token = "0x403B749")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCallBtnClicked;

		// Token: 0x0403B74A RID: 243530
		[Token(Token = "0x403B74A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnReviewMailClicked;

		// Token: 0x0403B74B RID: 243531
		[Token(Token = "0x403B74B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnSwitchStateClicked;

		// Token: 0x0403B74C RID: 243532
		[Token(Token = "0x403B74C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x0403B74D RID: 243533
		[Token(Token = "0x403B74D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B74E RID: 243534
		[Token(Token = "0x403B74E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B74F RID: 243535
		[Token(Token = "0x403B74F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B750 RID: 243536
		[Token(Token = "0x403B750")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TriggerAnimSteps;

		// Token: 0x0403B751 RID: 243537
		[Token(Token = "0x403B751")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryPlayNextAnimStep;

		// Token: 0x0403B752 RID: 243538
		[Token(Token = "0x403B752")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AnimStepWaitForSeconds;

		// Token: 0x0403B753 RID: 243539
		[Token(Token = "0x403B753")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetMusic;

		// Token: 0x0403B754 RID: 243540
		[Token(Token = "0x403B754")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnCharCardClicked;

		// Token: 0x0403B755 RID: 243541
		[Token(Token = "0x403B755")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CharLockPanelCoroutine;

		// Token: 0x0403B756 RID: 243542
		[Token(Token = "0x403B756")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OpenCharUnlockDialog;

		// Token: 0x0403B757 RID: 243543
		[Token(Token = "0x403B757")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OpenMailDialog;

		// Token: 0x0403B758 RID: 243544
		[Token(Token = "0x403B758")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OpenClockDialog;

		// Token: 0x0403B759 RID: 243545
		[Token(Token = "0x403B759")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
