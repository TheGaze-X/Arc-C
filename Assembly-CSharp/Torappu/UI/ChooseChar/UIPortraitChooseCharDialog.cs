using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A28 RID: 23080
	[Token(Token = "0x2005A28")]
	public class UIPortraitChooseCharDialog : UICompDialog<UIPortraitChooseCharDialog.Options>, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x060219CB RID: 137675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219CB")]
		[Address(RVA = "0x1C14E20", Offset = "0x1C13A20", VA = "0x181C14E20", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060219CC RID: 137676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219CC")]
		[Address(RVA = "0x1C14E80", Offset = "0x1C13A80", VA = "0x181C14E80", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060219CD RID: 137677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219CD")]
		[Address(RVA = "0x1C15480", Offset = "0x1C14080", VA = "0x181C15480", Slot = "18")]
		protected override void OnRender(UIPortraitChooseCharDialog.Options input)
		{
		}

		// Token: 0x060219CE RID: 137678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219CE")]
		[Address(RVA = "0x1C14FF0", Offset = "0x1C13BF0", VA = "0x181C14FF0", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060219CF RID: 137679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219CF")]
		[Address(RVA = "0x1C15700", Offset = "0x1C14300", VA = "0x181C15700")]
		private void _EventOnCancelClicked()
		{
		}

		// Token: 0x060219D0 RID: 137680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219D0")]
		[Address(RVA = "0x1C15AB0", Offset = "0x1C146B0", VA = "0x181C15AB0")]
		private void _EventOnConfirmClicked()
		{
		}

		// Token: 0x060219D1 RID: 137681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219D1")]
		[Address(RVA = "0x1C15760", Offset = "0x1C14360", VA = "0x181C15760")]
		private void _EventOnCharCardClicked(string charId)
		{
		}

		// Token: 0x060219D2 RID: 137682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219D2")]
		[Address(RVA = "0x1C158A0", Offset = "0x1C144A0", VA = "0x181C158A0")]
		private void _EventOnCharCardDetailClicked(string charId)
		{
		}

		// Token: 0x060219D3 RID: 137683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219D3")]
		[Address(RVA = "0x1C159D0", Offset = "0x1C145D0", VA = "0x181C159D0")]
		private void _EventOnClearAllSelectClicked()
		{
		}

		// Token: 0x060219D4 RID: 137684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219D4")]
		[Address(RVA = "0x1C15B50", Offset = "0x1C14750", VA = "0x181C15B50")]
		private void _OnCloseDialog(bool isSubmit)
		{
		}

		// Token: 0x060219D5 RID: 137685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219D5")]
		[Address(RVA = "0x1C15D00", Offset = "0x1C14900", VA = "0x181C15D00")]
		public UIPortraitChooseCharDialog()
		{
		}

		// Token: 0x060219D6 RID: 137686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60219D6")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060219D7 RID: 137687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219D7")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402DF40 RID: 188224
		[Token(Token = "0x402DF40")]
		[NonSerialized]
		public const int ON_CONFIRM_BTN_CLICKED = 0;

		// Token: 0x0402DF41 RID: 188225
		[Token(Token = "0x402DF41")]
		[NonSerialized]
		public const int ON_CANCEL_BTN_CLICKED = 1;

		// Token: 0x0402DF42 RID: 188226
		[Token(Token = "0x402DF42")]
		[NonSerialized]
		public const int ON_CHAR_CARD_CLICKED = 2;

		// Token: 0x0402DF43 RID: 188227
		[Token(Token = "0x402DF43")]
		[NonSerialized]
		public const int ON_CHAR_CARD_DETAIL_CLICKED = 3;

		// Token: 0x0402DF44 RID: 188228
		[Token(Token = "0x402DF44")]
		[NonSerialized]
		public const int ON_CLEAR_ALL_SELECT_CLICKED = 4;

		// Token: 0x0402DF45 RID: 188229
		[Token(Token = "0x402DF45")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _imgBlur;

		// Token: 0x0402DF46 RID: 188230
		[Token(Token = "0x402DF46")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIPortraitChooseCharGroupView _charGroupView;

		// Token: 0x0402DF47 RID: 188231
		[Token(Token = "0x402DF47")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIPortraitChooseCharButtonView _buttonView;

		// Token: 0x0402DF48 RID: 188232
		[Token(Token = "0x402DF48")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAtlasImage _bkgComplete;

		// Token: 0x0402DF49 RID: 188233
		[Token(Token = "0x402DF49")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAtlasImage _bkgUnComplete;

		// Token: 0x0402DF4A RID: 188234
		[Token(Token = "0x402DF4A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x0402DF4B RID: 188235
		[Token(Token = "0x402DF4B")]
		[FieldOffset(Offset = "0xA0")]
		private UIPortraitChooseCharProperty m_property;

		// Token: 0x0402DF4C RID: 188236
		[Token(Token = "0x402DF4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402DF4D RID: 188237
		[Token(Token = "0x402DF4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402DF4E RID: 188238
		[Token(Token = "0x402DF4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402DF4F RID: 188239
		[Token(Token = "0x402DF4F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402DF50 RID: 188240
		[Token(Token = "0x402DF50")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnCancelClicked;

		// Token: 0x0402DF51 RID: 188241
		[Token(Token = "0x402DF51")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnConfirmClicked;

		// Token: 0x0402DF52 RID: 188242
		[Token(Token = "0x402DF52")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnCharCardClicked;

		// Token: 0x0402DF53 RID: 188243
		[Token(Token = "0x402DF53")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnCharCardDetailClicked;

		// Token: 0x0402DF54 RID: 188244
		[Token(Token = "0x402DF54")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnClearAllSelectClicked;

		// Token: 0x0402DF55 RID: 188245
		[Token(Token = "0x402DF55")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCloseDialog;

		// Token: 0x0402DF56 RID: 188246
		[Token(Token = "0x402DF56")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A29 RID: 23081
		[Token(Token = "0x2005A29")]
		public class Options
		{
			// Token: 0x060219D8 RID: 137688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219D8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402DF57 RID: 188247
			[Token(Token = "0x402DF57")]
			[FieldOffset(Offset = "0x10")]
			public string titleText;

			// Token: 0x0402DF58 RID: 188248
			[Token(Token = "0x402DF58")]
			[FieldOffset(Offset = "0x18")]
			public int selectCount;

			// Token: 0x0402DF59 RID: 188249
			[Token(Token = "0x402DF59")]
			[FieldOffset(Offset = "0x20")]
			public List<UIPortraitChooseCharCardViewModel> charModelList;

			// Token: 0x0402DF5A RID: 188250
			[Token(Token = "0x402DF5A")]
			[FieldOffset(Offset = "0x28")]
			public List<string> selectedCharIdList;

			// Token: 0x0402DF5B RID: 188251
			[Token(Token = "0x402DF5B")]
			[FieldOffset(Offset = "0x30")]
			public Color color;
		}

		// Token: 0x02005A2A RID: 23082
		[Token(Token = "0x2005A2A")]
		public class Output
		{
			// Token: 0x060219D9 RID: 137689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60219D9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x0402DF5C RID: 188252
			[Token(Token = "0x402DF5C")]
			[FieldOffset(Offset = "0x10")]
			public bool isSubmit;

			// Token: 0x0402DF5D RID: 188253
			[Token(Token = "0x402DF5D")]
			[FieldOffset(Offset = "0x18")]
			public List<string> charIdList;
		}
	}
}
