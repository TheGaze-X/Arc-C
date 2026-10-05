using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004140 RID: 16704
	[Token(Token = "0x2004140")]
	public class SandboxV2DineState : PopupFadeState, ICompDialogCallBack
	{
		// Token: 0x06019CB1 RID: 105649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019CB1")]
		[Address(RVA = "0x12AEDA0", Offset = "0x12AD9A0", VA = "0x1812AEDA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019CB2 RID: 105650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CB2")]
		[Address(RVA = "0x12AEFA0", Offset = "0x12ADBA0", VA = "0x1812AEFA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019CB3 RID: 105651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CB3")]
		[Address(RVA = "0x12AF220", Offset = "0x12ADE20", VA = "0x1812AF220", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06019CB4 RID: 105652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CB4")]
		[Address(RVA = "0x12AF1B0", Offset = "0x12ADDB0", VA = "0x1812AF1B0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06019CB5 RID: 105653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CB5")]
		[Address(RVA = "0x12AF980", Offset = "0x12AE580", VA = "0x1812AF980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019CB6 RID: 105654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CB6")]
		[Address(RVA = "0x12B08E0", Offset = "0x12AF4E0", VA = "0x1812B08E0")]
		private void _ToCookPanel()
		{
		}

		// Token: 0x06019CB7 RID: 105655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CB7")]
		[Address(RVA = "0x12AFF80", Offset = "0x12AEB80", VA = "0x1812AFF80")]
		private void _SelectItem(int index)
		{
		}

		// Token: 0x06019CB8 RID: 105656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CB8")]
		[Address(RVA = "0x12AF440", Offset = "0x12AE040", VA = "0x1812AF440")]
		private void _ConfirmDine()
		{
		}

		// Token: 0x06019CB9 RID: 105657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CB9")]
		[Address(RVA = "0x12AFD40", Offset = "0x12AE940", VA = "0x1812AFD40")]
		private void _OnBack()
		{
		}

		// Token: 0x06019CBA RID: 105658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CBA")]
		[Address(RVA = "0x12B0550", Offset = "0x12AF150", VA = "0x1812B0550")]
		private void _SendDineRequest()
		{
		}

		// Token: 0x06019CBB RID: 105659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CBB")]
		[Address(RVA = "0x12AFDA0", Offset = "0x12AE9A0", VA = "0x1812AFDA0")]
		private void _OnDineConfirmed(SandboxV2DineResponse response)
		{
		}

		// Token: 0x06019CBC RID: 105660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CBC")]
		[Address(RVA = "0x12AF8E0", Offset = "0x12AE4E0", VA = "0x1812AF8E0")]
		private void _DismissIfCan()
		{
		}

		// Token: 0x06019CBD RID: 105661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CBD")]
		[Address(RVA = "0x12AEE00", Offset = "0x12ADA00", VA = "0x1812AEE00", Slot = "31")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06019CBE RID: 105662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CBE")]
		[Address(RVA = "0x12B0C30", Offset = "0x12AF830", VA = "0x1812B0C30")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x06019CBF RID: 105663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CBF")]
		[Address(RVA = "0x12B0B10", Offset = "0x12AF710", VA = "0x1812B0B10")]
		private void _TryRaiseTutorialSignal()
		{
		}

		// Token: 0x06019CC0 RID: 105664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019CC0")]
		[Address(RVA = "0x12AF850", Offset = "0x12AE450", VA = "0x1812AF850")]
		private IEnumerator _CoroutineTriggerTutorial()
		{
			return null;
		}

		// Token: 0x06019CC1 RID: 105665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CC1")]
		[Address(RVA = "0x12B0830", Offset = "0x12AF430", VA = "0x1812B0830")]
		private void _StopTutorialCoroutine()
		{
		}

		// Token: 0x06019CC2 RID: 105666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CC2")]
		[Address(RVA = "0x12B0D60", Offset = "0x12AF960", VA = "0x1812B0D60")]
		public SandboxV2DineState()
		{
		}

		// Token: 0x06019CC3 RID: 105667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CC3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06019CC4 RID: 105668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CC4")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06019CC5 RID: 105669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019CC5")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x040205E5 RID: 132581
		[Token(Token = "0x40205E5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2DineView _dineView;

		// Token: 0x040205E6 RID: 132582
		[Token(Token = "0x40205E6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x040205E7 RID: 132583
		[Token(Token = "0x40205E7")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x040205E8 RID: 132584
		[Token(Token = "0x40205E8")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2DineStateBean m_stateBean;

		// Token: 0x040205E9 RID: 132585
		[Token(Token = "0x40205E9")]
		[FieldOffset(Offset = "0x90")]
		private int m_cookDialogInst;

		// Token: 0x040205EA RID: 132586
		[Token(Token = "0x40205EA")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine m_tutorialCoroutine;

		// Token: 0x040205EB RID: 132587
		[Token(Token = "0x40205EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040205EC RID: 132588
		[Token(Token = "0x40205EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040205ED RID: 132589
		[Token(Token = "0x40205ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040205EE RID: 132590
		[Token(Token = "0x40205EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x040205EF RID: 132591
		[Token(Token = "0x40205EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040205F0 RID: 132592
		[Token(Token = "0x40205F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ToCookPanel;

		// Token: 0x040205F1 RID: 132593
		[Token(Token = "0x40205F1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SelectItem;

		// Token: 0x040205F2 RID: 132594
		[Token(Token = "0x40205F2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ConfirmDine;

		// Token: 0x040205F3 RID: 132595
		[Token(Token = "0x40205F3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBack;

		// Token: 0x040205F4 RID: 132596
		[Token(Token = "0x40205F4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SendDineRequest;

		// Token: 0x040205F5 RID: 132597
		[Token(Token = "0x40205F5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnDineConfirmed;

		// Token: 0x040205F6 RID: 132598
		[Token(Token = "0x40205F6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DismissIfCan;

		// Token: 0x040205F7 RID: 132599
		[Token(Token = "0x40205F7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040205F8 RID: 132600
		[Token(Token = "0x40205F8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x040205F9 RID: 132601
		[Token(Token = "0x40205F9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryRaiseTutorialSignal;

		// Token: 0x040205FA RID: 132602
		[Token(Token = "0x40205FA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CoroutineTriggerTutorial;

		// Token: 0x040205FB RID: 132603
		[Token(Token = "0x40205FB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__StopTutorialCoroutine;

		// Token: 0x040205FC RID: 132604
		[Token(Token = "0x40205FC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
