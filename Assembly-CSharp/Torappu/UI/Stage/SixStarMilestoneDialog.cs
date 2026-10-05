using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006826 RID: 26662
	[Token(Token = "0x2006826")]
	public class SixStarMilestoneDialog : UICompDialog<SixStarMilestoneDialog.Input>, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0602630C RID: 156428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602630C")]
		[Address(RVA = "0x2139DA0", Offset = "0x21389A0", VA = "0x182139DA0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602630D RID: 156429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602630D")]
		[Address(RVA = "0x2139E00", Offset = "0x2138A00", VA = "0x182139E00", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602630E RID: 156430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602630E")]
		[Address(RVA = "0x213A0C0", Offset = "0x2138CC0", VA = "0x18213A0C0", Slot = "18")]
		protected override void OnRender(SixStarMilestoneDialog.Input input)
		{
		}

		// Token: 0x0602630F RID: 156431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602630F")]
		[Address(RVA = "0x2139F40", Offset = "0x2138B40", VA = "0x182139F40", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06026310 RID: 156432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026310")]
		[Address(RVA = "0x213A190", Offset = "0x2138D90", VA = "0x18213A190")]
		private void _EventOnBackClicked()
		{
		}

		// Token: 0x06026311 RID: 156433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026311")]
		[Address(RVA = "0x213A250", Offset = "0x2138E50", VA = "0x18213A250")]
		private void _EventOnClaimAllClicked()
		{
		}

		// Token: 0x06026312 RID: 156434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026312")]
		[Address(RVA = "0x213A5B0", Offset = "0x21391B0", VA = "0x18213A5B0")]
		private void _HandleClaimAllResponse(ConfirmSixStarRewardResponse response)
		{
		}

		// Token: 0x06026313 RID: 156435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026313")]
		[Address(RVA = "0x213A6C0", Offset = "0x21392C0", VA = "0x18213A6C0")]
		public SixStarMilestoneDialog()
		{
		}

		// Token: 0x06026314 RID: 156436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026314")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06026315 RID: 156437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026315")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04035CF0 RID: 220400
		[Token(Token = "0x4035CF0")]
		[NonSerialized]
		public const int ON_BACK_BTN_CLICKED = 0;

		// Token: 0x04035CF1 RID: 220401
		[Token(Token = "0x4035CF1")]
		[NonSerialized]
		public const int ON_CLAIM_ALL_BTN_CLICKED = 1;

		// Token: 0x04035CF2 RID: 220402
		[Token(Token = "0x4035CF2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _imgBlur;

		// Token: 0x04035CF3 RID: 220403
		[Token(Token = "0x4035CF3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x04035CF4 RID: 220404
		[Token(Token = "0x4035CF4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SixStarMilestoneView _view;

		// Token: 0x04035CF5 RID: 220405
		[Token(Token = "0x4035CF5")]
		[FieldOffset(Offset = "0x88")]
		private SixStarMilestoneProperty m_property;

		// Token: 0x04035CF6 RID: 220406
		[Token(Token = "0x4035CF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04035CF7 RID: 220407
		[Token(Token = "0x4035CF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04035CF8 RID: 220408
		[Token(Token = "0x4035CF8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04035CF9 RID: 220409
		[Token(Token = "0x4035CF9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04035CFA RID: 220410
		[Token(Token = "0x4035CFA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnBackClicked;

		// Token: 0x04035CFB RID: 220411
		[Token(Token = "0x4035CFB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnClaimAllClicked;

		// Token: 0x04035CFC RID: 220412
		[Token(Token = "0x4035CFC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleClaimAllResponse;

		// Token: 0x04035CFD RID: 220413
		[Token(Token = "0x4035CFD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006827 RID: 26663
		[Token(Token = "0x2006827")]
		public class Input
		{
			// Token: 0x06026316 RID: 156438 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026316")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04035CFE RID: 220414
			[Token(Token = "0x4035CFE")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;
		}
	}
}
