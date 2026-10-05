using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public class DeflaterHuffman
	{
		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x4A48D30", Offset = "0x4A47930", VA = "0x184A48D30")]
		public DeflaterHuffman(DeflaterPending pending)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4A481C0", Offset = "0x4A46DC0", VA = "0x184A481C0")]
		public void Reset()
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4A48210", Offset = "0x4A46E10", VA = "0x184A48210")]
		public void SendAllTrees(int blTreeCodes)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4A47130", Offset = "0x4A45D30", VA = "0x184A47130")]
		public void CompressBlock()
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4A47F80", Offset = "0x4A46B80", VA = "0x184A47F80")]
		public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x4A47420", Offset = "0x4A46020", VA = "0x184A47420")]
		public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x4A48180", Offset = "0x4A46D80", VA = "0x184A48180")]
		public bool IsFull()
		{
			return default(bool);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x4A48750", Offset = "0x4A47350", VA = "0x184A48750")]
		public bool TallyLit(int literal)
		{
			return default(bool);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x4A485C0", Offset = "0x4A471C0", VA = "0x184A485C0")]
		public bool TallyDist(int distance, int length)
		{
			return default(bool);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x4A47060", Offset = "0x4A45C60", VA = "0x184A47060")]
		public static short BitReverse(int toReverse)
		{
			return 0;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x4A48190", Offset = "0x4A46D90", VA = "0x184A48190")]
		private static int Lcode(int length)
		{
			return 0;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x4A47400", Offset = "0x4A46000", VA = "0x184A47400")]
		private static int Dcode(int distance)
		{
			return 0;
		}

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		private const int BUFSIZE = 16384;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		private const int LITERAL_NUM = 286;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		private const int DIST_NUM = 30;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		private const int BITLEN_NUM = 19;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		private const int REP_3_6 = 16;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		private const int REP_3_10 = 17;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		private const int REP_11_138 = 18;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		private const int EOF_SYMBOL = 256;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] BL_ORDER;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] bit4Reverse;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x10")]
		private static short[] staticLCodes;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x18")]
		private static byte[] staticLLength;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x20")]
		private static short[] staticDCodes;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x28")]
		private static byte[] staticDLength;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x10")]
		public DeflaterPending pending;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x18")]
		private DeflaterHuffman.Tree literalTree;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x20")]
		private DeflaterHuffman.Tree distTree;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x28")]
		private DeflaterHuffman.Tree blTree;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x30")]
		private short[] d_buf;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x38")]
		private byte[] l_buf;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x40")]
		private int last_lit;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x44")]
		private int extra_bits;

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		private class Tree
		{
			// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x4A598F0", Offset = "0x4A584F0", VA = "0x184A598F0")]
			public Tree(DeflaterHuffman dh, int elems, int minCodes, int maxLength)
			{
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x4A59600", Offset = "0x4A58200", VA = "0x184A59600")]
			public void Reset()
			{
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x4A596C0", Offset = "0x4A582C0", VA = "0x184A596C0")]
			public void WriteSymbol(int code)
			{
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x4A594D0", Offset = "0x4A580D0", VA = "0x184A594D0")]
			public void CheckEmpty()
			{
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x4A59680", Offset = "0x4A58280", VA = "0x184A59680")]
			public void SetStaticCodes(short[] staticCodes, byte[] staticLengths)
			{
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x4A586E0", Offset = "0x4A572E0", VA = "0x184A586E0")]
			public void BuildCodes()
			{
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x4A58CD0", Offset = "0x4A578D0", VA = "0x184A58CD0")]
			public void BuildTree()
			{
			}

			// Token: 0x060002A6 RID: 678 RVA: 0x000034B0 File Offset: 0x000016B0
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x4A59590", Offset = "0x4A58190", VA = "0x184A59590")]
			public int GetEncodedLength()
			{
				return 0;
			}

			// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x4A59350", Offset = "0x4A57F50", VA = "0x184A59350")]
			public void CalcBLFreq(DeflaterHuffman.Tree blTree)
			{
			}

			// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x4A59720", Offset = "0x4A58320", VA = "0x184A59720")]
			public void WriteTree(DeflaterHuffman.Tree blTree)
			{
			}

			// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x4A588E0", Offset = "0x4A574E0", VA = "0x184A588E0")]
			private void BuildLength(int[] childs)
			{
			}

			// Token: 0x040001A7 RID: 423
			[Token(Token = "0x40001A7")]
			[FieldOffset(Offset = "0x10")]
			public short[] freqs;

			// Token: 0x040001A8 RID: 424
			[Token(Token = "0x40001A8")]
			[FieldOffset(Offset = "0x18")]
			public byte[] length;

			// Token: 0x040001A9 RID: 425
			[Token(Token = "0x40001A9")]
			[FieldOffset(Offset = "0x20")]
			public int minNumCodes;

			// Token: 0x040001AA RID: 426
			[Token(Token = "0x40001AA")]
			[FieldOffset(Offset = "0x24")]
			public int numCodes;

			// Token: 0x040001AB RID: 427
			[Token(Token = "0x40001AB")]
			[FieldOffset(Offset = "0x28")]
			private short[] codes;

			// Token: 0x040001AC RID: 428
			[Token(Token = "0x40001AC")]
			[FieldOffset(Offset = "0x30")]
			private int[] bl_counts;

			// Token: 0x040001AD RID: 429
			[Token(Token = "0x40001AD")]
			[FieldOffset(Offset = "0x38")]
			private int maxLength;

			// Token: 0x040001AE RID: 430
			[Token(Token = "0x40001AE")]
			[FieldOffset(Offset = "0x40")]
			private DeflaterHuffman dh;
		}
	}
}
