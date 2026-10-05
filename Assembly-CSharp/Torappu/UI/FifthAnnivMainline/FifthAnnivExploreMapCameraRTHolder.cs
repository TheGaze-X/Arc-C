using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004ECF RID: 20175
	[Token(Token = "0x2004ECF")]
	public class FifthAnnivExploreMapCameraRTHolder : IHotfixable
	{
		// Token: 0x0601E19B RID: 123291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E19B")]
		[Address(RVA = "0x17CC080", Offset = "0x17CAC80", VA = "0x1817CC080")]
		public void BindRTHost(UIBlendRTHost host)
		{
		}

		// Token: 0x0601E19C RID: 123292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E19C")]
		[Address(RVA = "0x17CC2C0", Offset = "0x17CAEC0", VA = "0x1817CC2C0")]
		public void BindRTImage(UIBlendRTImage image)
		{
		}

		// Token: 0x0601E19D RID: 123293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E19D")]
		[Address(RVA = "0x17CC3B0", Offset = "0x17CAFB0", VA = "0x1817CC3B0")]
		public FifthAnnivExploreMapCameraRTHolder()
		{
		}

		// Token: 0x040280BE RID: 164030
		[Token(Token = "0x40280BE")]
		private const int BLUR_TEX_SIZE = 640;

		// Token: 0x040280BF RID: 164031
		[Token(Token = "0x40280BF")]
		[FieldOffset(Offset = "0x10")]
		private List<UIBlendRTImage> m_pendingImages;

		// Token: 0x040280C0 RID: 164032
		[Token(Token = "0x40280C0")]
		[FieldOffset(Offset = "0x18")]
		private UIBlendRTHost m_host;

		// Token: 0x040280C1 RID: 164033
		[Token(Token = "0x40280C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindRTHost;

		// Token: 0x040280C2 RID: 164034
		[Token(Token = "0x40280C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindRTImage;

		// Token: 0x040280C3 RID: 164035
		[Token(Token = "0x40280C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
