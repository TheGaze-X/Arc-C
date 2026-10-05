using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public struct GlyphPairKey
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x5880B00", Offset = "0x587F700", VA = "0x185880B00")]
		public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x5880B20", Offset = "0x587F720", VA = "0x185880B20")]
		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
		{
		}

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x0")]
		public uint firstGlyphIndex;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x4")]
		public uint secondGlyphIndex;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x8")]
		public uint key;
	}
}
