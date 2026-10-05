using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[StructLayout(2)]
	internal struct NativeInputEventBuffer
	{
		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public unsafe void* eventBuffer;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int eventCount;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int sizeInBytes;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int capacityInBytes;
	}
}
