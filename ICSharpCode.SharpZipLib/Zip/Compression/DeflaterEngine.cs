using System;
using ICSharpCode.SharpZipLib.Checksums;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	public class DeflaterEngine : DeflaterConstants
	{
		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x4A46D40", Offset = "0x4A45940", VA = "0x184A46D40")]
		public DeflaterEngine(DeflaterPending pending)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x4A45BD0", Offset = "0x4A447D0", VA = "0x184A45BD0")]
		public bool Deflate(bool flush, bool finish)
		{
			return default(bool);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x4A466F0", Offset = "0x4A452F0", VA = "0x184A466F0")]
		public void SetInput(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x4A46420", Offset = "0x4A45020", VA = "0x184A46420")]
		public bool NeedsInput()
		{
			return default(bool);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x4A46560", Offset = "0x4A45160", VA = "0x184A46560")]
		public void SetDictionary(byte[] buffer, int offset, int length)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x4A46460", Offset = "0x4A45060", VA = "0x184A46460")]
		public void Reset()
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x4A46430", Offset = "0x4A45030", VA = "0x184A46430")]
		public void ResetAdler()
		{
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x1700008C")]
		public int Adler
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x4A47030", Offset = "0x4A45C30", VA = "0x184A47030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x1700008D")]
		public long TotalIn
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00003390 File Offset: 0x00001590
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008E")]
		public DeflateStrategy Strategy
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			get
			{
				return DeflateStrategy.Default;
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			set
			{
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4A468F0", Offset = "0x4A454F0", VA = "0x184A468F0")]
		public void SetLevel(int level)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x4A45EB0", Offset = "0x4A44AB0", VA = "0x184A45EB0")]
		public void FillWindow()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x4A46CF0", Offset = "0x4A458F0", VA = "0x184A46CF0")]
		private void UpdateHash()
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x4A46380", Offset = "0x4A44F80", VA = "0x184A46380")]
		private int InsertString()
		{
			return 0;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x4A46C00", Offset = "0x4A45800", VA = "0x184A46C00")]
		private void SlideWindow()
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x4A45FB0", Offset = "0x4A44BB0", VA = "0x184A45FB0")]
		private bool FindLongestMatch(int curMatch)
		{
			return default(bool);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4A45A90", Offset = "0x4A44690", VA = "0x184A45A90")]
		private bool DeflateStored(bool flush, bool finish)
		{
			return default(bool);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x4A45570", Offset = "0x4A44170", VA = "0x184A45570")]
		private bool DeflateFast(bool flush, bool finish)
		{
			return default(bool);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x4A457F0", Offset = "0x4A443F0", VA = "0x184A457F0")]
		private bool DeflateSlow(bool flush, bool finish)
		{
			return default(bool);
		}

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		private const int TooFar = 4096;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x10")]
		private int ins_h;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x18")]
		private short[] head;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x20")]
		private short[] prev;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x28")]
		private int matchStart;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x2C")]
		private int matchLen;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x30")]
		private bool prevAvailable;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x34")]
		private int blockStart;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x38")]
		private int strstart;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x3C")]
		private int lookahead;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x40")]
		private byte[] window;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x48")]
		private DeflateStrategy strategy;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x4C")]
		private int max_chain;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x50")]
		private int max_lazy;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x54")]
		private int niceLength;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x58")]
		private int goodLength;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x5C")]
		private int compressionFunction;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x60")]
		private byte[] inputBuf;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x68")]
		private long totalIn;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x70")]
		private int inputOff;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x74")]
		private int inputEnd;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x78")]
		private DeflaterPending pending;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x80")]
		private DeflaterHuffman huffman;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x88")]
		private Adler32 adler;
	}
}
