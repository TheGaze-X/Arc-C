using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019D4 RID: 6612
	[Token(Token = "0x20019D4")]
	public class DIYPresetSaveState : PopupFadeState
	{
		// Token: 0x0600A60F RID: 42511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A60F")]
		[Address(RVA = "0x31F4BE0", Offset = "0x31F37E0", VA = "0x1831F4BE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600A610 RID: 42512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A610")]
		[Address(RVA = "0x31F5240", Offset = "0x31F3E40", VA = "0x1831F5240")]
		private void _TrySavePreset()
		{
		}

		// Token: 0x0600A611 RID: 42513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A611")]
		[Address(RVA = "0x31F4EC0", Offset = "0x31F3AC0", VA = "0x1831F4EC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600A612 RID: 42514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A612")]
		[Address(RVA = "0x31F4C40", Offset = "0x31F3840", VA = "0x1831F4C40")]
		public void OnBackButtonPressed()
		{
		}

		// Token: 0x0600A613 RID: 42515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A613")]
		[Address(RVA = "0x31F4CC0", Offset = "0x31F38C0", VA = "0x1831F4CC0")]
		public void OnConfirmPressed()
		{
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A614")]
		[Address(RVA = "0x31F5090", Offset = "0x31F3C90", VA = "0x1831F5090", Slot = "29")]
		protected override void SetRootViewActive(CanvasGroup rootView, bool active)
		{
		}

		// Token: 0x0600A615 RID: 42517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A615")]
		[Address(RVA = "0x31F5410", Offset = "0x31F4010", VA = "0x1831F5410")]
		public DIYPresetSaveState()
		{
		}

		// Token: 0x0600A618 RID: 42520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A618")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A619")]
		[Address(RVA = "0x15D4900", Offset = "0x15D3500", VA = "0x1815D4900")]
		private void <>xLuaBaseProxy_SetRootViewActive(CanvasGroup P0, bool P1)
		{
		}

		// Token: 0x04009DF3 RID: 40435
		[Token(Token = "0x4009DF3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _presetView;

		// Token: 0x04009DF4 RID: 40436
		[Token(Token = "0x4009DF4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InputField _inputText;

		// Token: 0x04009DF5 RID: 40437
		[Token(Token = "0x4009DF5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRenderTextureImage _background;

		// Token: 0x04009DF6 RID: 40438
		[Token(Token = "0x4009DF6")]
		[FieldOffset(Offset = "0x88")]
		private DIYPresetDataSaveStateBean m_stateBean;

		// Token: 0x04009DF7 RID: 40439
		[Token(Token = "0x4009DF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04009DF8 RID: 40440
		[Token(Token = "0x4009DF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TrySavePreset;

		// Token: 0x04009DF9 RID: 40441
		[Token(Token = "0x4009DF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04009DFA RID: 40442
		[Token(Token = "0x4009DFA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackButtonPressed;

		// Token: 0x04009DFB RID: 40443
		[Token(Token = "0x4009DFB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConfirmPressed;

		// Token: 0x04009DFC RID: 40444
		[Token(Token = "0x4009DFC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetRootViewActive;

		// Token: 0x04009DFD RID: 40445
		[Token(Token = "0x4009DFD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
