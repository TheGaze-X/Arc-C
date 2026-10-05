using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A9A RID: 15002
	[Token(Token = "0x2003A9A")]
	public class UISpoilerConfirmDialog : UICustomDialog<UISpoilerConfirmDialog.Options>
	{
		// Token: 0x06017B53 RID: 97107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B53")]
		[Address(RVA = "0xFF7BF0", Offset = "0xFF67F0", VA = "0x180FF7BF0", Slot = "7")]
		protected override void OnRender(UISpoilerConfirmDialog.Options options)
		{
		}

		// Token: 0x06017B54 RID: 97108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017B54")]
		[Address(RVA = "0xFF7A00", Offset = "0xFF6600", VA = "0x180FF7A00", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06017B55 RID: 97109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B55")]
		[Address(RVA = "0xFF7AD0", Offset = "0xFF66D0", VA = "0x180FF7AD0")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x06017B56 RID: 97110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B56")]
		[Address(RVA = "0xFF7B60", Offset = "0xFF6760", VA = "0x180FF7B60")]
		public void OnFinishClicked()
		{
		}

		// Token: 0x06017B57 RID: 97111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B57")]
		[Address(RVA = "0xFF7A60", Offset = "0xFF6660", VA = "0x180FF7A60")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x06017B58 RID: 97112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B58")]
		[Address(RVA = "0xFF7E20", Offset = "0xFF6A20", VA = "0x180FF7E20")]
		public UISpoilerConfirmDialog()
		{
		}

		// Token: 0x0401C9C4 RID: 117188
		[Token(Token = "0x401C9C4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0401C9C5 RID: 117189
		[Token(Token = "0x401C9C5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0401C9C6 RID: 117190
		[Token(Token = "0x401C9C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401C9C7 RID: 117191
		[Token(Token = "0x401C9C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401C9C8 RID: 117192
		[Token(Token = "0x401C9C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x0401C9C9 RID: 117193
		[Token(Token = "0x401C9C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinishClicked;

		// Token: 0x0401C9CA RID: 117194
		[Token(Token = "0x401C9CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x0401C9CB RID: 117195
		[Token(Token = "0x401C9CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A9B RID: 15003
		[Token(Token = "0x2003A9B")]
		public struct Options
		{
			// Token: 0x0401C9CC RID: 117196
			[Token(Token = "0x401C9CC")]
			[FieldOffset(Offset = "0x0")]
			public Action onConfirm;

			// Token: 0x0401C9CD RID: 117197
			[Token(Token = "0x401C9CD")]
			[FieldOffset(Offset = "0x8")]
			public Action onFinish;

			// Token: 0x0401C9CE RID: 117198
			[Token(Token = "0x401C9CE")]
			[FieldOffset(Offset = "0x10")]
			public string content;
		}
	}
}
