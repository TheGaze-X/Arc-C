using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004130 RID: 16688
	[Token(Token = "0x2004130")]
	public class SandboxV2ConfirmDialog : UICustomDialog<SandboxV2ConfirmDialog.Options>
	{
		// Token: 0x06019C62 RID: 105570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019C62")]
		[Address(RVA = "0x12AA470", Offset = "0x12A9070", VA = "0x1812AA470", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06019C63 RID: 105571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C63")]
		[Address(RVA = "0x12AA4D0", Offset = "0x12A90D0", VA = "0x1812AA4D0", Slot = "7")]
		protected override void OnRender(SandboxV2ConfirmDialog.Options options)
		{
		}

		// Token: 0x06019C64 RID: 105572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C64")]
		[Address(RVA = "0x12AA3C0", Offset = "0x12A8FC0", VA = "0x1812AA3C0", Slot = "9")]
		protected override void BeforeDestroy()
		{
		}

		// Token: 0x06019C65 RID: 105573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019C65")]
		[Address(RVA = "0x12AAEB0", Offset = "0x12A9AB0", VA = "0x1812AAEB0")]
		private string _GetCancelStr(SandboxV2ConfirmDialog.Options options)
		{
			return null;
		}

		// Token: 0x06019C66 RID: 105574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C66")]
		[Address(RVA = "0x12AB030", Offset = "0x12A9C30", VA = "0x1812AB030")]
		private void _OnViewCancelClicked()
		{
		}

		// Token: 0x06019C67 RID: 105575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C67")]
		[Address(RVA = "0x12AB0B0", Offset = "0x12A9CB0", VA = "0x1812AB0B0")]
		private void _OnViewConfirmClicked()
		{
		}

		// Token: 0x06019C68 RID: 105576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C68")]
		[Address(RVA = "0x12AAFB0", Offset = "0x12A9BB0", VA = "0x1812AAFB0")]
		private void _OnViewBackPressed()
		{
		}

		// Token: 0x06019C69 RID: 105577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C69")]
		[Address(RVA = "0x12AB130", Offset = "0x12A9D30", VA = "0x1812AB130")]
		public SandboxV2ConfirmDialog()
		{
		}

		// Token: 0x0402051A RID: 132378
		[Token(Token = "0x402051A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0402051B RID: 132379
		[Token(Token = "0x402051B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0402051C RID: 132380
		[Token(Token = "0x402051C")]
		[FieldOffset(Offset = "0xB0")]
		private SandboxV2ConfirmDialogView m_dialogView;

		// Token: 0x0402051D RID: 132381
		[Token(Token = "0x402051D")]
		[FieldOffset(Offset = "0xB8")]
		private Action m_callback;

		// Token: 0x0402051E RID: 132382
		[Token(Token = "0x402051E")]
		[FieldOffset(Offset = "0xC0")]
		private Action m_cancelCallback;

		// Token: 0x0402051F RID: 132383
		[Token(Token = "0x402051F")]
		[FieldOffset(Offset = "0xC8")]
		private Action m_backPressCallback;

		// Token: 0x04020520 RID: 132384
		[Token(Token = "0x4020520")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04020521 RID: 132385
		[Token(Token = "0x4020521")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04020522 RID: 132386
		[Token(Token = "0x4020522")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_BeforeDestroy;

		// Token: 0x04020523 RID: 132387
		[Token(Token = "0x4020523")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetCancelStr;

		// Token: 0x04020524 RID: 132388
		[Token(Token = "0x4020524")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnViewCancelClicked;

		// Token: 0x04020525 RID: 132389
		[Token(Token = "0x4020525")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnViewConfirmClicked;

		// Token: 0x04020526 RID: 132390
		[Token(Token = "0x4020526")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnViewBackPressed;

		// Token: 0x04020527 RID: 132391
		[Token(Token = "0x4020527")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004131 RID: 16689
		[Token(Token = "0x2004131")]
		public struct Options
		{
			// Token: 0x04020528 RID: 132392
			[Token(Token = "0x4020528")]
			[FieldOffset(Offset = "0x0")]
			public static SandboxV2ConfirmDialog.Options COMMON_OPTIONS;

			// Token: 0x04020529 RID: 132393
			[Token(Token = "0x4020529")]
			[FieldOffset(Offset = "0x0")]
			public Action callback;

			// Token: 0x0402052A RID: 132394
			[Token(Token = "0x402052A")]
			[FieldOffset(Offset = "0x8")]
			public Action cancelCallback;

			// Token: 0x0402052B RID: 132395
			[Token(Token = "0x402052B")]
			[FieldOffset(Offset = "0x10")]
			public Action backPressCallback;

			// Token: 0x0402052C RID: 132396
			[Token(Token = "0x402052C")]
			[FieldOffset(Offset = "0x18")]
			public string iconId;

			// Token: 0x0402052D RID: 132397
			[Token(Token = "0x402052D")]
			[FieldOffset(Offset = "0x20")]
			public Sprite iconSprite;

			// Token: 0x0402052E RID: 132398
			[Token(Token = "0x402052E")]
			[FieldOffset(Offset = "0x28")]
			public SandboxV2ConfirmDialogDecoViewBase dialogDecoViewPrefab;

			// Token: 0x0402052F RID: 132399
			[Token(Token = "0x402052F")]
			[FieldOffset(Offset = "0x30")]
			public object dialogDecoViewParam;

			// Token: 0x04020530 RID: 132400
			[Token(Token = "0x4020530")]
			[FieldOffset(Offset = "0x38")]
			public SandboxV2ConfirmDialogThemeType themeType;

			// Token: 0x04020531 RID: 132401
			[Token(Token = "0x4020531")]
			[FieldOffset(Offset = "0x3C")]
			public SandboxV2ConfirmDialogConfirmVisualType confirmVisualType;

			// Token: 0x04020532 RID: 132402
			[Token(Token = "0x4020532")]
			[FieldOffset(Offset = "0x40")]
			public SandboxV2ConfirmDialogConfirmAudioType confirmAudioType;

			// Token: 0x04020533 RID: 132403
			[Token(Token = "0x4020533")]
			[FieldOffset(Offset = "0x48")]
			public string titleStr;

			// Token: 0x04020534 RID: 132404
			[Token(Token = "0x4020534")]
			[FieldOffset(Offset = "0x50")]
			public string descStr;

			// Token: 0x04020535 RID: 132405
			[Token(Token = "0x4020535")]
			[FieldOffset(Offset = "0x58")]
			public string confirmStr;

			// Token: 0x04020536 RID: 132406
			[Token(Token = "0x4020536")]
			[FieldOffset(Offset = "0x60")]
			public string overrideCancelStr;
		}
	}
}
