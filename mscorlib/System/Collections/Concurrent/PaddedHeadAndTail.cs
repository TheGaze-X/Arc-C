using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Collections.Concurrent
{
	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	[System.Diagnostics.DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
	[StructLayout(2)]
	internal struct PaddedHeadAndTail
	{
		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int Head;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int Tail;
	}
}
