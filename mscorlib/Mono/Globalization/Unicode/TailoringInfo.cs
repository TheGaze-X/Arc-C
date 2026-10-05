using System;
using Il2CppDummyDll;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	internal class TailoringInfo
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x444A710", Offset = "0x4449310", VA = "0x18444A710")]
		public TailoringInfo(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort)
		{
		}

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x10")]
		public readonly int LCID;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x14")]
		public readonly int TailoringIndex;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x18")]
		public readonly int TailoringCount;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x1C")]
		public readonly bool FrenchSort;
	}
}
