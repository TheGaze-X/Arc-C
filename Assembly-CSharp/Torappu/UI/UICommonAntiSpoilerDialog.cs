using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A88 RID: 14984
	[Token(Token = "0x2003A88")]
	public class UICommonAntiSpoilerDialog : UICustomDialog<UICommonAntiSpoilerDialog.Options>
	{
		// Token: 0x06017AE8 RID: 97000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AE8")]
		[Address(RVA = "0xFF1E50", Offset = "0xFF0A50", VA = "0x180FF1E50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06017AE9 RID: 97001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AE9")]
		[Address(RVA = "0xFF1C90", Offset = "0xFF0890", VA = "0x180FF1C90", Slot = "7")]
		protected override void OnRender(UICommonAntiSpoilerDialog.Options options)
		{
		}

		// Token: 0x06017AEA RID: 97002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017AEA")]
		[Address(RVA = "0xFF1BA0", Offset = "0xFF07A0", VA = "0x180FF1BA0", Slot = "10")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x06017AEB RID: 97003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AEB")]
		[Address(RVA = "0xFF1C00", Offset = "0xFF0800", VA = "0x180FF1C00")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x06017AEC RID: 97004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017AEC")]
		[Address(RVA = "0xFF1F70", Offset = "0xFF0B70", VA = "0x180FF1F70")]
		public UICommonAntiSpoilerDialog()
		{
		}

		// Token: 0x0401C933 RID: 117043
		[Token(Token = "0x401C933")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIRenderTextureImage _bkgBlur;

		// Token: 0x0401C934 RID: 117044
		[Token(Token = "0x401C934")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0401C935 RID: 117045
		[Token(Token = "0x401C935")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0401C936 RID: 117046
		[Token(Token = "0x401C936")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401C937 RID: 117047
		[Token(Token = "0x401C937")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401C938 RID: 117048
		[Token(Token = "0x401C938")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0401C939 RID: 117049
		[Token(Token = "0x401C939")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x0401C93A RID: 117050
		[Token(Token = "0x401C93A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003A89 RID: 14985
		[Token(Token = "0x2003A89")]
		public struct Options
		{
			// Token: 0x0401C93B RID: 117051
			[Token(Token = "0x401C93B")]
			[FieldOffset(Offset = "0x0")]
			public Action onConfirm;

			// Token: 0x0401C93C RID: 117052
			[Token(Token = "0x401C93C")]
			[FieldOffset(Offset = "0x8")]
			public string content;
		}
	}
}
