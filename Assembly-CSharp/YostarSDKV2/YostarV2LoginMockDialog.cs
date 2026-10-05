using System;
using Il2CppDummyDll;
using Torappu.UI;
using U8.SDK;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace YostarSDKV2
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public class YostarV2LoginMockDialog : UICustomDialog<YostarV2LoginMockDialog.Options>
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x523BA0", Offset = "0x5227A0", VA = "0x180523BA0", Slot = "7")]
		protected override void OnRender(YostarV2LoginMockDialog.Options options)
		{
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x523AC0", Offset = "0x5226C0", VA = "0x180523AC0")]
		public void EventOnLoginClicked()
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x523CD0", Offset = "0x5228D0", VA = "0x180523CD0")]
		private void _Login()
		{
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x523FB0", Offset = "0x522BB0", VA = "0x180523FB0")]
		public YostarV2LoginMockDialog()
		{
		}

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InputField _inputUID;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x48")]
		private YostarV2LoginMockDialog.Options m_options;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnLoginClicked;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Login;

		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		public class Options
		{
			// Token: 0x060002C1 RID: 705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0400030F RID: 783
			[Token(Token = "0x400030F")]
			[FieldOffset(Offset = "0x10")]
			public ExternalPluginLoginParams loginParams;
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		private struct Token
		{
			// Token: 0x04000310 RID: 784
			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x04000311 RID: 785
			[Token(Token = "0x4000311")]
			[FieldOffset(Offset = "0x8")]
			public long ts;

			// Token: 0x04000312 RID: 786
			[Token(Token = "0x4000312")]
			[FieldOffset(Offset = "0x10")]
			public int type;
		}
	}
}
