using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public struct KerningPairKey
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x5880EF0", Offset = "0x587FAF0", VA = "0x185880EF0")]
		public KerningPairKey(uint ascii_left, uint ascii_right)
		{
		}

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x0")]
		public uint ascii_Left;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x4")]
		public uint ascii_Right;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x8")]
		public uint key;
	}
}
