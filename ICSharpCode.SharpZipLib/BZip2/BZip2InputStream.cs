using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class BZip2InputStream : Stream
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4A34600", Offset = "0x4A33200", VA = "0x184A34600")]
		public BZip2InputStream(Stream stream)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002054 File Offset: 0x00000254
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public bool IsStreamOwner
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x4A34AD0", Offset = "0x4A336D0", VA = "0x184A34AD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x4A34B80", Offset = "0x4A33780", VA = "0x184A34B80")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000002")]
		public override bool CanRead
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x4A34A30", Offset = "0x4A33630", VA = "0x184A34A30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x17000003")]
		public override bool CanSeek
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x4A34A80", Offset = "0x4A33680", VA = "0x184A34A80", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x17000004")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x17000005")]
		public override long Length
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x4A34AE0", Offset = "0x4A336E0", VA = "0x184A34AE0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000020CC File Offset: 0x000002CC
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		public override long Position
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x4A34B30", Offset = "0x4A33730", VA = "0x184A34B30", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x4A34B90", Offset = "0x4A33790", VA = "0x184A34B90", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4A32000", Offset = "0x4A30C00", VA = "0x184A32000", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4A33C10", Offset = "0x4A32810", VA = "0x184A33C10", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4A33D60", Offset = "0x4A32960", VA = "0x184A33D60", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4A345A0", Offset = "0x4A331A0", VA = "0x184A345A0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4A34540", Offset = "0x4A33140", VA = "0x184A34540", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4A33270", Offset = "0x4A31E70", VA = "0x184A33270", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4A31D90", Offset = "0x4A30990", VA = "0x184A31D90", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x4A32F80", Offset = "0x4A31B80", VA = "0x184A32F80", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x4A32F00", Offset = "0x4A31B00", VA = "0x184A32F00")]
		private void MakeMaps()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x4A32D00", Offset = "0x4A31900", VA = "0x184A32D00")]
		private void Initialize()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x4A32A90", Offset = "0x4A31690", VA = "0x184A32A90")]
		private void InitBlock()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x4A31EF0", Offset = "0x4A30AF0", VA = "0x184A31EF0")]
		private void EndBlock()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4A31DF0", Offset = "0x4A309F0", VA = "0x184A31DF0")]
		private void Complete()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4A31D60", Offset = "0x4A30960", VA = "0x184A31D60")]
		private void BsSetStream(Stream stream)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4A31F70", Offset = "0x4A30B70", VA = "0x184A31F70")]
		private void FillBuffer()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4A31CD0", Offset = "0x4A308D0", VA = "0x184A31CD0")]
		private int BsR(int n)
		{
			return 0;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4A31D20", Offset = "0x4A30920", VA = "0x184A31D20")]
		private char BsGetUChar()
		{
			return '\0';
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4A31CD0", Offset = "0x4A308D0", VA = "0x184A31CD0")]
		private int BsGetIntVS(int numBits)
		{
			return 0;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4A31BF0", Offset = "0x4A307F0", VA = "0x184A31BF0")]
		private int BsGetInt32()
		{
			return 0;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4A33360", Offset = "0x4A31F60", VA = "0x184A33360")]
		private void RecvDecodingTables()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4A32050", Offset = "0x4A30C50", VA = "0x184A32050")]
		private void GetAndMoveToFrontDecode()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4A33DC0", Offset = "0x4A329C0", VA = "0x184A33DC0")]
		private void SetupBlock()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4A34190", Offset = "0x4A32D90", VA = "0x184A34190")]
		private void SetupRandPartA()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4A33F50", Offset = "0x4A32B50", VA = "0x184A33F50")]
		private void SetupNoRandPartA()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4A34320", Offset = "0x4A32F20", VA = "0x184A34320")]
		private void SetupRandPartB()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4A344A0", Offset = "0x4A330A0", VA = "0x184A344A0")]
		private void SetupRandPartC()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4A34040", Offset = "0x4A32C40", VA = "0x184A34040")]
		private void SetupNoRandPartB()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4A340F0", Offset = "0x4A32CF0", VA = "0x184A340F0")]
		private void SetupNoRandPartC()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4A33C70", Offset = "0x4A32870", VA = "0x184A33C70")]
		private void SetDecompressStructureSizes(int newSize100k)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4A31E30", Offset = "0x4A30A30", VA = "0x184A31E30")]
		private static void CompressedStreamEOF()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4A31B90", Offset = "0x4A30790", VA = "0x184A31B90")]
		private static void BlockOverrun()
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x4A31B30", Offset = "0x4A30730", VA = "0x184A31B30")]
		private static void BadBlockHeader()
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4A31E90", Offset = "0x4A30A90", VA = "0x184A31E90")]
		private static void CrcError()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4A32880", Offset = "0x4A31480", VA = "0x184A32880")]
		private static void HbCreateDecodeTables(int[] limit, int[] baseArray, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
		}

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		private const int START_BLOCK_STATE = 1;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		private const int RAND_PART_A_STATE = 2;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		private const int RAND_PART_B_STATE = 3;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		private const int RAND_PART_C_STATE = 4;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		private const int NO_RAND_PART_A_STATE = 5;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		private const int NO_RAND_PART_B_STATE = 6;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		private const int NO_RAND_PART_C_STATE = 7;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x28")]
		private int last;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x2C")]
		private int origPtr;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x30")]
		private int blockSize100k;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x34")]
		private bool blockRandomised;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x38")]
		private int bsBuff;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x3C")]
		private int bsLive;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x40")]
		private IChecksum mCrc;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x48")]
		private bool[] inUse;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		private int nInUse;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x58")]
		private byte[] seqToUnseq;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x60")]
		private byte[] unseqToSeq;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x68")]
		private byte[] selector;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x70")]
		private byte[] selectorMtf;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x78")]
		private int[] tt;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x80")]
		private byte[] ll8;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x88")]
		private int[] unzftab;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x90")]
		private int[][] limit;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x98")]
		private int[][] baseArray;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xA0")]
		private int[][] perm;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0xA8")]
		private int[] minLens;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xB0")]
		private Stream baseStream;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xB8")]
		private bool streamEnd;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xBC")]
		private int currentChar;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0xC0")]
		private int currentState;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xC4")]
		private int storedBlockCRC;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0xC8")]
		private int storedCombinedCRC;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0xCC")]
		private int computedBlockCRC;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xD0")]
		private uint computedCombinedCRC;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xD4")]
		private int count;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xD8")]
		private int chPrev;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xDC")]
		private int ch2;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xE0")]
		private int tPos;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xE4")]
		private int rNToGo;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xE8")]
		private int rTPos;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xEC")]
		private int i2;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xF0")]
		private int j2;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xF4")]
		private byte z;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0xF5")]
		private bool isStreamOwner;
	}
}
