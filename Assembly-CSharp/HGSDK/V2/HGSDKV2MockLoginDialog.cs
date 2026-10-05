using System;
using Il2CppDummyDll;
using Torappu.UI;
using U8.SDK;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.V2
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	public class HGSDKV2MockLoginDialog : UICustomDialog<HGSDKV2MockLoginDialog.Options>
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1AD1B20", Offset = "0x1AD0720", VA = "0x181AD1B20", Slot = "7")]
		protected override void OnRender(HGSDKV2MockLoginDialog.Options options)
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1AD1940", Offset = "0x1AD0540", VA = "0x181AD1940")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1AD1AC0", Offset = "0x1AD06C0", VA = "0x181AD1AC0")]
		public void EventOnPreAnnounceClicked()
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1AD1C70", Offset = "0x1AD0870", VA = "0x181AD1C70")]
		public HGSDKV2MockLoginDialog()
		{
		}

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private InputField _inputUID;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x68")]
		private HGSDKV2MockLoginDialog.Options m_options;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnPreAnnounceClicked;

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200017C RID: 380
		[Token(Token = "0x200017C")]
		public struct Options
		{
			// Token: 0x040007B6 RID: 1974
			[Token(Token = "0x40007B6")]
			[FieldOffset(Offset = "0x0")]
			public ExternalPluginLoginParams loginParam;
		}
	}
}
