using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class BZip2OutputStream : Stream
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4A399A0", Offset = "0x4A385A0", VA = "0x184A399A0")]
		public BZip2OutputStream(Stream stream)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4A39430", Offset = "0x4A38030", VA = "0x184A39430")]
		public BZip2OutputStream(Stream stream, int blockSize)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4A355D0", Offset = "0x4A341D0", VA = "0x184A355D0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000218C File Offset: 0x0000038C
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x17000008")]
		public override bool CanRead
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x17000009")]
		public override bool CanSeek
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x1700000A")]
		public override bool CanWrite
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x4A399B0", Offset = "0x4A385B0", VA = "0x184A399B0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x1700000B")]
		public override long Length
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x4A39A00", Offset = "0x4A38600", VA = "0x184A39A00", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002204 File Offset: 0x00000404
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		public override long Position
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x4A39A50", Offset = "0x4A38650", VA = "0x184A39A50", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x4A39AA0", Offset = "0x4A386A0", VA = "0x184A39AA0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4A37920", Offset = "0x4A36520", VA = "0x184A37920", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4A38930", Offset = "0x4A37530", VA = "0x184A38930", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4A37860", Offset = "0x4A36460", VA = "0x184A37860", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4A378C0", Offset = "0x4A364C0", VA = "0x184A378C0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4A39230", Offset = "0x4A37E30", VA = "0x184A39230", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4A38E40", Offset = "0x4A37A40", VA = "0x184A38E40", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4A34F00", Offset = "0x4A33B00", VA = "0x184A34F00", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4A37000", Offset = "0x4A35C00", VA = "0x184A37000")]
		private void MakeMaps()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4A38ED0", Offset = "0x4A37AD0", VA = "0x184A38ED0")]
		private void WriteRun()
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x1700000D")]
		public int BytesWritten
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1793F50", Offset = "0x1792B50", VA = "0x181793F50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4A34F70", Offset = "0x4A33B70", VA = "0x184A34F70", Slot = "38")]
		protected new virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4A35650", Offset = "0x4A34250", VA = "0x184A35650", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4A36580", Offset = "0x4A35180", VA = "0x184A36580")]
		private void Initialize()
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4A364E0", Offset = "0x4A350E0", VA = "0x184A364E0")]
		private void InitBlock()
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4A35370", Offset = "0x4A33F70", VA = "0x184A35370")]
		private void EndBlock()
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4A354D0", Offset = "0x4A340D0", VA = "0x184A354D0")]
		private void EndCompression()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4A34E10", Offset = "0x4A33A10", VA = "0x184A34E10")]
		private void BsSetStream(Stream stream)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4A34CF0", Offset = "0x4A338F0", VA = "0x184A34CF0")]
		private void BsFinishedWithStream()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4A34E40", Offset = "0x4A33A40", VA = "0x184A34E40")]
		private void BsW(int n, int v)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x4A34D80", Offset = "0x4A33980", VA = "0x184A34D80")]
		private void BsPutUChar(int c)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4A34D90", Offset = "0x4A33990", VA = "0x184A34D90")]
		private void BsPutint(int u)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4A34D70", Offset = "0x4A33970", VA = "0x184A34D70")]
		private void BsPutIntVS(int numBits, int c)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4A37980", Offset = "0x4A36580", VA = "0x184A37980")]
		private void SendMTFValues()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4A370C0", Offset = "0x4A35CC0", VA = "0x184A370C0")]
		private void MoveToFrontCodeAndSend()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x4A38990", Offset = "0x4A37590", VA = "0x184A38990")]
		private void SimpleSort(int lo, int hi, int d)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x4A38DB0", Offset = "0x4A379B0", VA = "0x184A38DB0")]
		private void Vswap(int p1, int p2, int n)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x4A37160", Offset = "0x4A35D60", VA = "0x184A37160")]
		private void QSort3(int loSt, int hiSt, int dSt)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4A36600", Offset = "0x4A35200", VA = "0x184A36600")]
		private void MainSort()
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x4A376F0", Offset = "0x4A362F0", VA = "0x184A376F0")]
		private void RandomiseBlock()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4A35140", Offset = "0x4A33D40", VA = "0x184A35140")]
		private void DoReversibleTransformation()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4A356A0", Offset = "0x4A342A0", VA = "0x184A356A0")]
		private bool FullGtU(int i1, int i2)
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4A34BF0", Offset = "0x4A337F0", VA = "0x184A34BF0")]
		private void AllocateCompressStructures()
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4A359C0", Offset = "0x4A345C0", VA = "0x184A359C0")]
		private void GenerateMTFValues()
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4A37100", Offset = "0x4A35D00", VA = "0x184A37100")]
		private static void Panic()
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4A35EA0", Offset = "0x4A34AA0", VA = "0x184A35EA0")]
		private static void HbMakeCodeLengths(char[] len, int[] freq, int alphaSize, int maxLen)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4A35E20", Offset = "0x4A34A20", VA = "0x184A35E20")]
		private static void HbAssignCodes(int[] code, char[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x4A37080", Offset = "0x4A35C80", VA = "0x184A37080")]
		private static byte Med3(byte a, byte b, byte c)
		{
			return 0;
		}

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		private const int SETMASK = 2097152;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		private const int CLEARMASK = -2097153;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		private const int GREATER_ICOST = 15;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		private const int LESSER_ICOST = 0;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		private const int SMALL_THRESH = 20;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		private const int DEPTH_THRESH = 10;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		private const int QSORT_STACK_SIZE = 1000;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x28")]
		private readonly int[] increments;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x30")]
		private bool isStreamOwner;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x34")]
		private int last;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x38")]
		private int origPtr;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x3C")]
		private int blockSize100k;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x40")]
		private bool blockRandomised;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x44")]
		private int bytesOut;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x48")]
		private int bsBuff;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x4C")]
		private int bsLive;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x50")]
		private IChecksum mCrc;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x58")]
		private bool[] inUse;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x60")]
		private int nInUse;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x68")]
		private char[] seqToUnseq;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x70")]
		private char[] unseqToSeq;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x78")]
		private char[] selector;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x80")]
		private char[] selectorMtf;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x88")]
		private byte[] block;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x90")]
		private int[] quadrant;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x98")]
		private int[] zptr;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xA0")]
		private short[] szptr;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xA8")]
		private int[] ftab;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0xB0")]
		private int nMTF;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0xB8")]
		private int[] mtfFreq;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0xC0")]
		private int workFactor;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xC4")]
		private int workDone;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xC8")]
		private int workLimit;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0xCC")]
		private bool firstAttempt;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xD0")]
		private int nBlocksRandomised;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xD4")]
		private int currentChar;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xD8")]
		private int runLength;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xDC")]
		private uint blockCRC;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xE0")]
		private uint combinedCRC;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xE4")]
		private int allowableBlockSize;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xE8")]
		private Stream baseStream;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0xF0")]
		private bool disposed_;

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		private struct StackElement
		{
			// Token: 0x04000063 RID: 99
			[Token(Token = "0x4000063")]
			[FieldOffset(Offset = "0x0")]
			public int ll;

			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			[FieldOffset(Offset = "0x4")]
			public int hh;

			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			[FieldOffset(Offset = "0x8")]
			public int dd;
		}
	}
}
