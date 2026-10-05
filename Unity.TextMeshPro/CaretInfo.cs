using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public struct CaretInfo
	{
		// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public CaretInfo(int index, CaretPosition position)
		{
		}

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x4")]
		public CaretPosition position;
	}
}
