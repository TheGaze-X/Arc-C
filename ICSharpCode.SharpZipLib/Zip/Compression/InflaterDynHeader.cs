using System;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	internal class InflaterDynHeader
	{
		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InflaterDynHeader()
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x4A4C0A0", Offset = "0x4A4ACA0", VA = "0x184A4C0A0")]
		public bool Decode(StreamManipulator input)
		{
			return default(bool);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x4A4BFF0", Offset = "0x4A4ABF0", VA = "0x184A4BFF0")]
		public InflaterHuffmanTree BuildLitLenTree()
		{
			return null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x4A4BF40", Offset = "0x4A4AB40", VA = "0x184A4BF40")]
		public InflaterHuffmanTree BuildDistTree()
		{
			return null;
		}

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		private const int LNUM = 0;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		private const int DNUM = 1;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		private const int BLNUM = 2;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		private const int BLLENS = 3;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		private const int LENS = 4;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		private const int REPS = 5;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] repMin;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] repBits;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] BL_ORDER;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x10")]
		private byte[] blLens;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x18")]
		private byte[] litdistLens;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x20")]
		private InflaterHuffmanTree blTree;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x28")]
		private int mode;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x2C")]
		private int lnum;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x30")]
		private int dnum;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x34")]
		private int blnum;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x38")]
		private int num;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x3C")]
		private int repSymbol;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x40")]
		private byte lastLen;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x44")]
		private int ptr;
	}
}
