using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	internal struct ConsoleScreenBufferInfo
	{
		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0x0")]
		public Coord Size;

		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		[FieldOffset(Offset = "0x4")]
		public Coord CursorPosition;

		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		[FieldOffset(Offset = "0x8")]
		public short Attribute;

		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		[FieldOffset(Offset = "0xA")]
		public SmallRect Window;

		// Token: 0x040009AD RID: 2477
		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0x12")]
		public Coord MaxWindowSize;
	}
}
