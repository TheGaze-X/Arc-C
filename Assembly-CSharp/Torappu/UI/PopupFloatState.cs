using System;
using System.Collections;
using System.Collections.Generic;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200399C RID: 14748
	[Token(Token = "0x200399C")]
	public abstract class PopupFloatState : UIPopupState, IInteruptInputState
	{
		// Token: 0x06017503 RID: 95491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017503")]
		[Address(RVA = "0xFADDB0", Offset = "0xFAC9B0", VA = "0x180FADDB0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06017504 RID: 95492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017504")]
		[Address(RVA = "0xFADA00", Offset = "0xFAC600", VA = "0x180FADA00", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06017505 RID: 95493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017505")]
		[Address(RVA = "0xFADEF0", Offset = "0xFACAF0", VA = "0x180FADEF0", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06017506 RID: 95494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017506")]
		[Address(RVA = "0xFADB40", Offset = "0xFAC740", VA = "0x180FADB40", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06017507 RID: 95495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017507")]
		[Address(RVA = "0xFADCA0", Offset = "0xFAC8A0", VA = "0x180FADCA0", Slot = "29")]
		protected virtual void OnPopup()
		{
		}

		// Token: 0x06017508 RID: 95496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017508")]
		[Address(RVA = "0xFADD00", Offset = "0xFAC900", VA = "0x180FADD00", Slot = "30")]
		protected virtual void SetRootViewActive(CanvasGroup rootView, bool active)
		{
		}

		// Token: 0x06017509 RID: 95497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017509")]
		[Address(RVA = "0xFAE030", Offset = "0xFACC30", VA = "0x180FAE030", Slot = "31")]
		protected virtual IEnumerator WaitForLoading()
		{
			return null;
		}

		// Token: 0x0601750A RID: 95498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601750A")]
		[Address(RVA = "0xFAE3F0", Offset = "0xFACFF0", VA = "0x180FAE3F0")]
		private void _ShotBlurCamerasAndSetToBackground()
		{
		}

		// Token: 0x0601750B RID: 95499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601750B")]
		[Address(RVA = "0xFAE1D0", Offset = "0xFACDD0", VA = "0x180FAE1D0")]
		private void _GrabCameraBlurBackground(List<Camera> cameras)
		{
		}

		// Token: 0x0601750C RID: 95500 RVA: 0x00095E80 File Offset: 0x00094080
		[Token(Token = "0x601750C")]
		[Address(RVA = "0xFAE0C0", Offset = "0xFACCC0", VA = "0x180FAE0C0")]
		private GenericPool<List<Camera>>.Ref _FindCameras4Blur()
		{
			return default(GenericPool<List<Camera>>.Ref);
		}

		// Token: 0x0601750D RID: 95501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601750D")]
		[Address(RVA = "0xFAE570", Offset = "0xFAD170", VA = "0x180FAE570")]
		protected PopupFloatState()
		{
		}

		// Token: 0x0401C237 RID: 115255
		[Token(Token = "0x401C237")]
		public const float FADE_DURATION = 0.23f;

		// Token: 0x0401C238 RID: 115256
		[Token(Token = "0x401C238")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("The background to show blurred parent view")]
		private UIFullScreenImage _background;

		// Token: 0x0401C239 RID: 115257
		[Token(Token = "0x401C239")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("The root view of the popup state")]
		private CanvasGroup _rootView;

		// Token: 0x0401C23A RID: 115258
		[Token(Token = "0x401C23A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401C23B RID: 115259
		[Token(Token = "0x401C23B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401C23C RID: 115260
		[Token(Token = "0x401C23C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0401C23D RID: 115261
		[Token(Token = "0x401C23D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0401C23E RID: 115262
		[Token(Token = "0x401C23E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPopup;

		// Token: 0x0401C23F RID: 115263
		[Token(Token = "0x401C23F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetRootViewActive;

		// Token: 0x0401C240 RID: 115264
		[Token(Token = "0x401C240")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_WaitForLoading;

		// Token: 0x0401C241 RID: 115265
		[Token(Token = "0x401C241")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShotBlurCamerasAndSetToBackground;

		// Token: 0x0401C242 RID: 115266
		[Token(Token = "0x401C242")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GrabCameraBlurBackground;

		// Token: 0x0401C243 RID: 115267
		[Token(Token = "0x401C243")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FindCameras4Blur;

		// Token: 0x0401C244 RID: 115268
		[Token(Token = "0x401C244")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
