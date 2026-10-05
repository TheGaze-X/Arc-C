using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[StructLayout(2)]
	internal struct NativeInputEvent
	{
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		public const int structSize = 20;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NativeInputEventType type;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort sizeInBytes;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort deviceId;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double time;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int eventId;
	}
}
