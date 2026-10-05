using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200633F RID: 25407
	[Token(Token = "0x200633F")]
	public class AutoChessItemDetailDialog : UICompDialog<AutoChessItemDetailDialog.Option>
	{
		// Token: 0x06024A7D RID: 150141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A7D")]
		[Address(RVA = "0x1F7E520", Offset = "0x1F7D120", VA = "0x181F7E520")]
		public void EventOnCloseBtnClick()
		{
		}

		// Token: 0x06024A7E RID: 150142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A7E")]
		[Address(RVA = "0x1F7E710", Offset = "0x1F7D310", VA = "0x181F7E710")]
		public void EventOnRightBtnClick()
		{
		}

		// Token: 0x06024A7F RID: 150143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A7F")]
		[Address(RVA = "0x1F7E5E0", Offset = "0x1F7D1E0", VA = "0x181F7E5E0")]
		public void EventOnLeftBtnClick()
		{
		}

		// Token: 0x06024A80 RID: 150144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A80")]
		[Address(RVA = "0x1F7E8A0", Offset = "0x1F7D4A0", VA = "0x181F7E8A0", Slot = "18")]
		protected override void OnRender(AutoChessItemDetailDialog.Option input)
		{
		}

		// Token: 0x06024A81 RID: 150145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A81")]
		[Address(RVA = "0x1F7E840", Offset = "0x1F7D440", VA = "0x181F7E840", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06024A82 RID: 150146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024A82")]
		[Address(RVA = "0x1F7EA80", Offset = "0x1F7D680", VA = "0x181F7EA80")]
		public AutoChessItemDetailDialog()
		{
		}

		// Token: 0x06024A83 RID: 150147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024A83")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403324A RID: 209482
		[Token(Token = "0x403324A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AutoChessItemDetailView _view;

		// Token: 0x0403324B RID: 209483
		[Token(Token = "0x403324B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurImg;

		// Token: 0x0403324C RID: 209484
		[Token(Token = "0x403324C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backPressRect;

		// Token: 0x0403324D RID: 209485
		[Token(Token = "0x403324D")]
		[FieldOffset(Offset = "0x88")]
		private AutoChessItemDetailViewModel m_viewModel;

		// Token: 0x0403324E RID: 209486
		[Token(Token = "0x403324E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClick;

		// Token: 0x0403324F RID: 209487
		[Token(Token = "0x403324F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnRightBtnClick;

		// Token: 0x04033250 RID: 209488
		[Token(Token = "0x4033250")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnLeftBtnClick;

		// Token: 0x04033251 RID: 209489
		[Token(Token = "0x4033251")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033252 RID: 209490
		[Token(Token = "0x4033252")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04033253 RID: 209491
		[Token(Token = "0x4033253")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006340 RID: 25408
		[Token(Token = "0x2006340")]
		public class Option
		{
			// Token: 0x06024A84 RID: 150148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024A84")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x04033254 RID: 209492
			[Token(Token = "0x4033254")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04033255 RID: 209493
			[Token(Token = "0x4033255")]
			[FieldOffset(Offset = "0x18")]
			public string initFocusChessId;
		}
	}
}
