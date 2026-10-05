using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x0200362D RID: 13869
	[Token(Token = "0x200362D")]
	public struct UIPageOption
	{
		// Token: 0x0401A925 RID: 108837
		[Token(Token = "0x401A925")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIPageOption DEFAULT;

		// Token: 0x0401A926 RID: 108838
		[Token(Token = "0x401A926")]
		[FieldOffset(Offset = "0x0")]
		public DataBundle savedInst;

		// Token: 0x0401A927 RID: 108839
		[Token(Token = "0x401A927")]
		[FieldOffset(Offset = "0x8")]
		public object args;

		// Token: 0x0401A928 RID: 108840
		[Token(Token = "0x401A928")]
		[FieldOffset(Offset = "0x10")]
		public UIPageController.VirtualTopResetRule virtualTopResetRule;
	}
}
