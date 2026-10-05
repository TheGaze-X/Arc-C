using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003967 RID: 14695
	[Token(Token = "0x2003967")]
	public struct UISenderRequestParam
	{
		// Token: 0x0401C05E RID: 114782
		[Token(Token = "0x401C05E")]
		[FieldOffset(Offset = "0x0")]
		public UISender.ConcurrentType concurrentType;

		// Token: 0x0401C05F RID: 114783
		[Token(Token = "0x401C05F")]
		[FieldOffset(Offset = "0x4")]
		public UISender.LoadMaskType loadMaskType;

		// Token: 0x0401C060 RID: 114784
		[Token(Token = "0x401C060")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UISenderRequestParam DEFAULT_PARAM;
	}
}
