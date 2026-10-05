using System;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public class Inflater
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4A4F3F0", Offset = "0x4A4DFF0", VA = "0x184A4F3F0")]
		public Inflater()
		{
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x4A4F2B0", Offset = "0x4A4DEB0", VA = "0x184A4F2B0")]
		public Inflater(bool noHeader)
		{
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x4A4ECB0", Offset = "0x4A4D8B0", VA = "0x184A4ECB0")]
		public void Reset()
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x4A4DB10", Offset = "0x4A4C710", VA = "0x184A4DB10")]
		private bool DecodeHeader()
		{
			return default(bool);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x4A4DAB0", Offset = "0x4A4C6B0", VA = "0x184A4DAB0")]
		private bool DecodeDict()
		{
			return default(bool);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x4A4DC70", Offset = "0x4A4C870", VA = "0x184A4DC70")]
		private bool DecodeHuffman()
		{
			return default(bool);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x4A4D8A0", Offset = "0x4A4C4A0", VA = "0x184A4D8A0")]
		private bool DecodeChksum()
		{
			return default(bool);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x4A4E0A0", Offset = "0x4A4CCA0", VA = "0x184A4E0A0")]
		private bool Decode()
		{
			return default(bool);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x4A4F040", Offset = "0x4A4DC40", VA = "0x184A4F040")]
		public void SetDictionary(byte[] buffer)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4A4ED50", Offset = "0x4A4D950", VA = "0x184A4ED50")]
		public void SetDictionary(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x4A4F070", Offset = "0x4A4DC70", VA = "0x184A4F070")]
		public void SetInput(byte[] buffer)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4A4F0C0", Offset = "0x4A4DCC0", VA = "0x184A4F0C0")]
		public void SetInput(byte[] buffer, int index, int count)
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x4A4EC30", Offset = "0x4A4D830", VA = "0x184A4EC30")]
		public int Inflate(byte[] buffer)
		{
			return 0;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x4A4E8D0", Offset = "0x4A4D4D0", VA = "0x184A4E8D0")]
		public int Inflate(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x17000091")]
		public bool IsNeedingInput
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x4A4F5C0", Offset = "0x4A4E1C0", VA = "0x184A4F5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x17000092")]
		public bool IsNeedingDictionary
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x4A4F5A0", Offset = "0x4A4E1A0", VA = "0x184A4F5A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x17000093")]
		public bool IsFinished
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x4A4F570", Offset = "0x4A4E170", VA = "0x184A4F570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x17000094")]
		public int Adler
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x4A4F530", Offset = "0x4A4E130", VA = "0x184A4F530")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x17000095")]
		public long TotalOut
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x17000096")]
		public long TotalIn
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x4A4F620", Offset = "0x4A4E220", VA = "0x184A4F620")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x17000097")]
		public int RemainingInput
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x4A4F5F0", Offset = "0x4A4E1F0", VA = "0x184A4F5F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		private const int DECODE_HEADER = 0;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		private const int DECODE_DICT = 1;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		private const int DECODE_BLOCKS = 2;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		private const int DECODE_STORED_LEN1 = 3;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		private const int DECODE_STORED_LEN2 = 4;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		private const int DECODE_STORED = 5;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		private const int DECODE_DYN_HEADER = 6;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		private const int DECODE_HUFFMAN = 7;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		private const int DECODE_HUFFMAN_LENBITS = 8;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		private const int DECODE_HUFFMAN_DIST = 9;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		private const int DECODE_HUFFMAN_DISTBITS = 10;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		private const int DECODE_CHKSUM = 11;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		private const int FINISHED = 12;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] CPLENS;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int[] CPLEXT;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] CPDIST;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] CPDEXT;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x10")]
		private int mode;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x14")]
		private int readAdler;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x18")]
		private int neededBits;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x1C")]
		private int repLength;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x20")]
		private int repDist;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x24")]
		private int uncomprLen;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x28")]
		private bool isLastBlock;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x30")]
		private long totalOut;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x38")]
		private long totalIn;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x40")]
		private bool noHeader;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x48")]
		private StreamManipulator input;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x50")]
		private OutputWindow outputWindow;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x58")]
		private InflaterDynHeader dynHeader;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x60")]
		private InflaterHuffmanTree litlenTree;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x68")]
		private InflaterHuffmanTree distTree;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x70")]
		private Adler32 adler;
	}
}
