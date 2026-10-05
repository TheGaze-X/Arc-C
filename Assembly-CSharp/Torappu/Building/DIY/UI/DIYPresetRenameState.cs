using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019D2 RID: 6610
	[Token(Token = "0x20019D2")]
	public class DIYPresetRenameState : PopupFadeState
	{
		// Token: 0x0600A603 RID: 42499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A603")]
		[Address(RVA = "0x31F4440", Offset = "0x31F3040", VA = "0x1831F4440", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600A604 RID: 42500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A604")]
		[Address(RVA = "0x31F48D0", Offset = "0x31F34D0", VA = "0x1831F48D0")]
		private void _TryRenamePreset()
		{
		}

		// Token: 0x0600A605 RID: 42501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A605")]
		[Address(RVA = "0x31F4520", Offset = "0x31F3120", VA = "0x1831F4520", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A606")]
		[Address(RVA = "0x31F4690", Offset = "0x31F3290", VA = "0x1831F4690", Slot = "29")]
		protected override void SetRootViewActive(CanvasGroup rootView, bool active)
		{
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A607")]
		[Address(RVA = "0x31F44A0", Offset = "0x31F30A0", VA = "0x1831F44A0")]
		public void OnCancelButtonPressed()
		{
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A608")]
		[Address(RVA = "0x31F4630", Offset = "0x31F3230", VA = "0x1831F4630")]
		public void OnOKButtonPressed()
		{
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A609")]
		[Address(RVA = "0x31F4AF0", Offset = "0x31F36F0", VA = "0x1831F4AF0")]
		public DIYPresetRenameState()
		{
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A60C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600A60D RID: 42509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A60D")]
		[Address(RVA = "0x15D4900", Offset = "0x15D3500", VA = "0x1815D4900")]
		private void <>xLuaBaseProxy_SetRootViewActive(CanvasGroup P0, bool P1)
		{
		}

		// Token: 0x04009DE4 RID: 40420
		[Token(Token = "0x4009DE4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InputField _nameText;

		// Token: 0x04009DE5 RID: 40421
		[Token(Token = "0x4009DE5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _background;

		// Token: 0x04009DE6 RID: 40422
		[Token(Token = "0x4009DE6")]
		[FieldOffset(Offset = "0x80")]
		private DIYPresetRenameStateBean m_stateBean;

		// Token: 0x04009DE7 RID: 40423
		[Token(Token = "0x4009DE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04009DE8 RID: 40424
		[Token(Token = "0x4009DE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryRenamePreset;

		// Token: 0x04009DE9 RID: 40425
		[Token(Token = "0x4009DE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04009DEA RID: 40426
		[Token(Token = "0x4009DEA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetRootViewActive;

		// Token: 0x04009DEB RID: 40427
		[Token(Token = "0x4009DEB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancelButtonPressed;

		// Token: 0x04009DEC RID: 40428
		[Token(Token = "0x4009DEC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnOKButtonPressed;

		// Token: 0x04009DED RID: 40429
		[Token(Token = "0x4009DED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
