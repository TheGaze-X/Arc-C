using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B22 RID: 19234
	[Token(Token = "0x2004B22")]
	public abstract class HomeReplaceableState : UIPopupState, HomePage.INotResetToDefaultHomeState
	{
		// Token: 0x0601CF40 RID: 118592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF40")]
		[Address(RVA = "0x1663C50", Offset = "0x1662850", VA = "0x181663C50", Slot = "23")]
		protected sealed override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601CF41 RID: 118593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF41")]
		[Address(RVA = "0x1663DA0", Offset = "0x16629A0", VA = "0x181663DA0", Slot = "25")]
		protected sealed override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601CF42 RID: 118594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF42")]
		[Address(RVA = "0x1663870", Offset = "0x1662470", VA = "0x181663870", Slot = "24")]
		protected sealed override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601CF43 RID: 118595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF43")]
		[Address(RVA = "0x16639C0", Offset = "0x16625C0", VA = "0x1816639C0", Slot = "26")]
		protected sealed override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601CF44 RID: 118596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF44")]
		[Address(RVA = "0x16635E0", Offset = "0x16621E0", VA = "0x1816635E0", Slot = "27")]
		protected sealed override void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601CF45 RID: 118597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF45")]
		[Address(RVA = "0x16636E0", Offset = "0x16622E0", VA = "0x1816636E0", Slot = "28")]
		protected sealed override void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x0601CF46 RID: 118598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF46")]
		[Address(RVA = "0x16637E0", Offset = "0x16623E0", VA = "0x1816637E0")]
		protected void DismissToHome()
		{
		}

		// Token: 0x0601CF47 RID: 118599
		[Token(Token = "0x601CF47")]
		protected abstract IEnumerator ShowEffect(HomeReplaceableState extractState);

		// Token: 0x0601CF48 RID: 118600
		[Token(Token = "0x601CF48")]
		protected abstract IEnumerator HideEffect();

		// Token: 0x0601CF49 RID: 118601
		[Token(Token = "0x601CF49")]
		protected abstract void ShowFastMode();

		// Token: 0x0601CF4A RID: 118602
		[Token(Token = "0x601CF4A")]
		protected abstract void HideFastMode();

		// Token: 0x0601CF4B RID: 118603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF4B")]
		[Address(RVA = "0x1664030", Offset = "0x1662C30", VA = "0x181664030")]
		private static HomeReplaceableState _ExtractStateForHide(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601CF4C RID: 118604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF4C")]
		[Address(RVA = "0x16641A0", Offset = "0x1662DA0", VA = "0x1816641A0")]
		private static HomeReplaceableState _ExtractStateForShow(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601CF4D RID: 118605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF4D")]
		[Address(RVA = "0x1664310", Offset = "0x1662F10", VA = "0x181664310")]
		protected HomeReplaceableState()
		{
		}

		// Token: 0x0601CF4E RID: 118606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF4E")]
		[Address(RVA = "0xF80770", Offset = "0xF7F370", VA = "0x180F80770")]
		private void <>xLuaBaseProxy_DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x0601CF4F RID: 118607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF4F")]
		[Address(RVA = "0xF807A0", Offset = "0xF7F3A0", VA = "0x180F807A0")]
		private void <>xLuaBaseProxy_DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x04025FC6 RID: 155590
		[Token(Token = "0x4025FC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04025FC7 RID: 155591
		[Token(Token = "0x4025FC7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04025FC8 RID: 155592
		[Token(Token = "0x4025FC8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04025FC9 RID: 155593
		[Token(Token = "0x4025FC9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04025FCA RID: 155594
		[Token(Token = "0x4025FCA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x04025FCB RID: 155595
		[Token(Token = "0x4025FCB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x04025FCC RID: 155596
		[Token(Token = "0x4025FCC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DismissToHome;

		// Token: 0x04025FCD RID: 155597
		[Token(Token = "0x4025FCD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExtractStateForHide;

		// Token: 0x04025FCE RID: 155598
		[Token(Token = "0x4025FCE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExtractStateForShow;

		// Token: 0x04025FCF RID: 155599
		[Token(Token = "0x4025FCF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004B23 RID: 19235
		[Token(Token = "0x2004B23")]
		[Obsolete("Use FadeSwitchTween.Builder.ControlRaycastAndKeepActive instead.")]
		protected class SwitchTween : FadeSwitchTween
		{
			// Token: 0x0601CF50 RID: 118608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CF50")]
			[Address(RVA = "0x167AE80", Offset = "0x1679A80", VA = "0x18167AE80")]
			public SwitchTween(CanvasGroup alphaHandler, bool ignoreTimeScale)
			{
			}

			// Token: 0x0601CF51 RID: 118609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CF51")]
			[Address(RVA = "0x167AE30", Offset = "0x1679A30", VA = "0x18167AE30", Slot = "20")]
			protected override void SetObjectActive(CanvasGroup alphaHandler, bool isActive)
			{
			}
		}
	}
}
