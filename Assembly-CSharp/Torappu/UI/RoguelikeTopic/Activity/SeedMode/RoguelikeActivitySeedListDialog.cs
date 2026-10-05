using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046A5 RID: 18085
	[Token(Token = "0x20046A5")]
	public class RoguelikeActivitySeedListDialog : UICompDialog<RoguelikeActivitySeedListDialog.InputParam>
	{
		// Token: 0x0601B6FB RID: 112379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6FB")]
		[Address(RVA = "0x14D3B80", Offset = "0x14D2780", VA = "0x1814D3B80", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601B6FC RID: 112380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6FC")]
		[Address(RVA = "0x14D3DB0", Offset = "0x14D29B0", VA = "0x1814D3DB0", Slot = "18")]
		protected override void OnRender(RoguelikeActivitySeedListDialog.InputParam input)
		{
		}

		// Token: 0x0601B6FD RID: 112381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6FD")]
		[Address(RVA = "0x14D44C0", Offset = "0x14D30C0", VA = "0x1814D44C0")]
		private void _OnSwitchTypeTab(SeedItemType targetType)
		{
		}

		// Token: 0x0601B6FE RID: 112382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6FE")]
		[Address(RVA = "0x14D40B0", Offset = "0x14D2CB0", VA = "0x1814D40B0")]
		private void _OnApplySeed(string seed)
		{
		}

		// Token: 0x0601B6FF RID: 112383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B6FF")]
		[Address(RVA = "0x14D45B0", Offset = "0x14D31B0", VA = "0x1814D45B0")]
		private void _SendApplySeedRequest(string seed)
		{
		}

		// Token: 0x0601B700 RID: 112384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B700")]
		[Address(RVA = "0x14D4410", Offset = "0x14D3010", VA = "0x1814D4410")]
		private void _OnClickCopySeed(string seed)
		{
		}

		// Token: 0x0601B701 RID: 112385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B701")]
		[Address(RVA = "0x14D3AC0", Offset = "0x14D26C0", VA = "0x1814D3AC0")]
		public void OnCloseDialog()
		{
		}

		// Token: 0x0601B702 RID: 112386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B702")]
		[Address(RVA = "0x14D3A60", Offset = "0x14D2660", VA = "0x1814D3A60", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601B703 RID: 112387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B703")]
		[Address(RVA = "0x14D4870", Offset = "0x14D3470", VA = "0x1814D4870")]
		public RoguelikeActivitySeedListDialog()
		{
		}

		// Token: 0x0601B705 RID: 112389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B705")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601B706 RID: 112390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B706")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x04023803 RID: 145411
		[Token(Token = "0x4023803")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blur;

		// Token: 0x04023804 RID: 145412
		[Token(Token = "0x4023804")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RoguelikeActivitySeedListView _view;

		// Token: 0x04023805 RID: 145413
		[Token(Token = "0x4023805")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04023806 RID: 145414
		[Token(Token = "0x4023806")]
		[FieldOffset(Offset = "0x88")]
		private RoguelikeActivitySeedListModel m_cachedModel;

		// Token: 0x04023807 RID: 145415
		[Token(Token = "0x4023807")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04023808 RID: 145416
		[Token(Token = "0x4023808")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04023809 RID: 145417
		[Token(Token = "0x4023809")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSwitchTypeTab;

		// Token: 0x0402380A RID: 145418
		[Token(Token = "0x402380A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnApplySeed;

		// Token: 0x0402380B RID: 145419
		[Token(Token = "0x402380B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendApplySeedRequest;

		// Token: 0x0402380C RID: 145420
		[Token(Token = "0x402380C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnClickCopySeed;

		// Token: 0x0402380D RID: 145421
		[Token(Token = "0x402380D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCloseDialog;

		// Token: 0x0402380E RID: 145422
		[Token(Token = "0x402380E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402380F RID: 145423
		[Token(Token = "0x402380F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046A6 RID: 18086
		[Token(Token = "0x20046A6")]
		public class InputParam
		{
			// Token: 0x0601B707 RID: 112391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B707")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public InputParam()
			{
			}

			// Token: 0x04023810 RID: 145424
			[Token(Token = "0x4023810")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;

			// Token: 0x04023811 RID: 145425
			[Token(Token = "0x4023811")]
			[FieldOffset(Offset = "0x18")]
			public string rlActId;
		}
	}
}
