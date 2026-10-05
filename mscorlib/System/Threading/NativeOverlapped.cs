using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001FE RID: 510
	[Token(Token = "0x20001FE")]
	public struct NativeOverlapped
	{
		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x0")]
		public System.IntPtr InternalLow;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x8")]
		public System.IntPtr InternalHigh;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x10")]
		public int OffsetLow;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x14")]
		public int OffsetHigh;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x18")]
		public System.IntPtr EventHandle;
	}
}
