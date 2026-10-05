using System;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006730 RID: 26416
	[Token(Token = "0x2006730")]
	public class HandBookV2MapZoomModel
	{
		// Token: 0x06025E2A RID: 155178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E2A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2MapZoomModel()
		{
		}

		// Token: 0x040354B1 RID: 218289
		[Token(Token = "0x40354B1")]
		[FieldOffset(Offset = "0x10")]
		public float zoomScale;

		// Token: 0x040354B2 RID: 218290
		[Token(Token = "0x40354B2")]
		[FieldOffset(Offset = "0x14")]
		public bool isScrollLock;
	}
}
