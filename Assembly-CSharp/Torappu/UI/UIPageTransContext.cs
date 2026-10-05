using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003630 RID: 13872
	[Token(Token = "0x2003630")]
	public struct UIPageTransContext
	{
		// Token: 0x0401A930 RID: 108848
		[Token(Token = "0x401A930")]
		[FieldOffset(Offset = "0x0")]
		public string fromPage;

		// Token: 0x0401A931 RID: 108849
		[Token(Token = "0x401A931")]
		[FieldOffset(Offset = "0x8")]
		public string toPage;

		// Token: 0x0401A932 RID: 108850
		[Token(Token = "0x401A932")]
		[FieldOffset(Offset = "0x10")]
		public UIPageTransType transType;

		// Token: 0x0401A933 RID: 108851
		[Token(Token = "0x401A933")]
		[FieldOffset(Offset = "0x18")]
		public UIPage newActivePage;

		// Token: 0x0401A934 RID: 108852
		[Token(Token = "0x401A934")]
		[FieldOffset(Offset = "0x20")]
		public bool hasPageDestroyed;
	}
}
