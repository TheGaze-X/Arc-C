using System;
using Il2CppDummyDll;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	internal class Contraction
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4AAA850", Offset = "0x4AA9450", VA = "0x184AAA850")]
		public Contraction(int index, char[] source, string replacement, byte[] sortkey)
		{
		}

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x10")]
		public int Index;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x18")]
		public readonly char[] Source;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x20")]
		public readonly string Replacement;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x28")]
		public readonly byte[] SortKey;
	}
}
