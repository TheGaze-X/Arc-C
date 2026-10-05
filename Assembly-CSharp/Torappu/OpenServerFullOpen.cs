using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000900 RID: 2304
	[Token(Token = "0x2000900")]
	public class OpenServerFullOpen
	{
		// Token: 0x060065D8 RID: 26072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OpenServerFullOpen()
		{
		}

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[FieldOffset(Offset = "0x10")]
		public bool isAvailable;

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[FieldOffset(Offset = "0x18")]
		public long startTs;

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[FieldOffset(Offset = "0x20")]
		public bool today;

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[FieldOffset(Offset = "0x24")]
		public int remain;
	}
}
