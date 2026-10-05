using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200638A RID: 25482
	[Token(Token = "0x200638A")]
	public class AutoChessStageInfoDialog : UICompDialog<AutoChessStageInfoDialog.Input>, IHotfixable
	{
		// Token: 0x06024C15 RID: 150549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C15")]
		[Address(RVA = "0x1FA6FE0", Offset = "0x1FA5BE0", VA = "0x181FA6FE0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06024C16 RID: 150550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C16")]
		[Address(RVA = "0x1FA7040", Offset = "0x1FA5C40", VA = "0x181FA7040", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06024C17 RID: 150551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C17")]
		[Address(RVA = "0x1FA7110", Offset = "0x1FA5D10", VA = "0x181FA7110", Slot = "18")]
		protected override void OnRender(AutoChessStageInfoDialog.Input input)
		{
		}

		// Token: 0x06024C18 RID: 150552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C18")]
		[Address(RVA = "0x1FA6F20", Offset = "0x1FA5B20", VA = "0x181FA6F20")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06024C19 RID: 150553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C19")]
		[Address(RVA = "0x1FA71C0", Offset = "0x1FA5DC0", VA = "0x181FA71C0")]
		public AutoChessStageInfoDialog()
		{
		}

		// Token: 0x06024C1A RID: 150554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C1A")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06024C1B RID: 150555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C1B")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0403359E RID: 210334
		[Token(Token = "0x403359E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x0403359F RID: 210335
		[Token(Token = "0x403359F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AutoChessStageInfoGroupView _prefabInfo;

		// Token: 0x040335A0 RID: 210336
		[Token(Token = "0x40335A0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _infoContainer;

		// Token: 0x040335A1 RID: 210337
		[Token(Token = "0x40335A1")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessStageInfoGroupView m_infoView;

		// Token: 0x040335A2 RID: 210338
		[Token(Token = "0x40335A2")]
		[FieldOffset(Offset = "0x90")]
		private AutoChessStageInfoGroupViewModel m_viewModel;

		// Token: 0x040335A3 RID: 210339
		[Token(Token = "0x40335A3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040335A4 RID: 210340
		[Token(Token = "0x40335A4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040335A5 RID: 210341
		[Token(Token = "0x40335A5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040335A6 RID: 210342
		[Token(Token = "0x40335A6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x040335A7 RID: 210343
		[Token(Token = "0x40335A7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200638B RID: 25483
		[Token(Token = "0x200638B")]
		public class Input
		{
			// Token: 0x06024C1C RID: 150556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024C1C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x040335A8 RID: 210344
			[Token(Token = "0x40335A8")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessStageInfoGroupViewModel.Input inputData;
		}
	}
}
