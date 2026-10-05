using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035B5 RID: 13749
	[Token(Token = "0x20035B5")]
	public class CommonMapPreviewDlg : UICompDialog<CommonMapPreviewDlg.Input>
	{
		// Token: 0x06015E08 RID: 89608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E08")]
		[Address(RVA = "0xE61150", Offset = "0xE5FD50", VA = "0x180E61150", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06015E09 RID: 89609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E09")]
		[Address(RVA = "0xE61260", Offset = "0xE5FE60", VA = "0x180E61260", Slot = "18")]
		protected override void OnRender(CommonMapPreviewDlg.Input input)
		{
		}

		// Token: 0x06015E0A RID: 89610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E0A")]
		[Address(RVA = "0xE610F0", Offset = "0xE5FCF0", VA = "0x180E610F0", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06015E0B RID: 89611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E0B")]
		[Address(RVA = "0xE613D0", Offset = "0xE5FFD0", VA = "0x180E613D0")]
		private void _EventOnCloseDlg()
		{
		}

		// Token: 0x06015E0C RID: 89612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E0C")]
		[Address(RVA = "0xE61000", Offset = "0xE5FC00", VA = "0x180E61000")]
		public void EventOnClose()
		{
		}

		// Token: 0x06015E0D RID: 89613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E0D")]
		[Address(RVA = "0xE61490", Offset = "0xE60090", VA = "0x180E61490")]
		public CommonMapPreviewDlg()
		{
		}

		// Token: 0x06015E0E RID: 89614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015E0E")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06015E0F RID: 89615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015E0F")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0401A4F2 RID: 107762
		[Token(Token = "0x401A4F2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBg;

		// Token: 0x0401A4F3 RID: 107763
		[Token(Token = "0x401A4F3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgMapPreview;

		// Token: 0x0401A4F4 RID: 107764
		[Token(Token = "0x401A4F4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backTrans;

		// Token: 0x0401A4F5 RID: 107765
		[Token(Token = "0x401A4F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401A4F6 RID: 107766
		[Token(Token = "0x401A4F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401A4F7 RID: 107767
		[Token(Token = "0x401A4F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401A4F8 RID: 107768
		[Token(Token = "0x401A4F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnCloseDlg;

		// Token: 0x0401A4F9 RID: 107769
		[Token(Token = "0x401A4F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x0401A4FA RID: 107770
		[Token(Token = "0x401A4FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020035B6 RID: 13750
		[Token(Token = "0x20035B6")]
		public class Input
		{
			// Token: 0x06015E10 RID: 89616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015E10")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0401A4FB RID: 107771
			[Token(Token = "0x401A4FB")]
			[FieldOffset(Offset = "0x10")]
			public string previewId;
		}
	}
}
