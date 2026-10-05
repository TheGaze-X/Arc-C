using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class StreamManipulator
	{
		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StreamManipulator()
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x4A503E0", Offset = "0x4A4EFE0", VA = "0x184A503E0")]
		public int PeekBits(int bitCount)
		{
			return 0;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x4A50380", Offset = "0x4A4EF80", VA = "0x184A50380")]
		public void DropBits(int bitCount)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x4A503A0", Offset = "0x4A4EFA0", VA = "0x184A503A0")]
		public int GetBits(int bitCount)
		{
			return 0;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x17000084")]
		public int AvailableBits
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x17000085")]
		public int AvailableBytes
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x4A50720", Offset = "0x4A4F320", VA = "0x184A50720")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x4A50700", Offset = "0x4A4F300", VA = "0x184A50700")]
		public void SkipToByteBoundary()
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x17000086")]
		public bool IsNeedingInput
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x369D9D0", Offset = "0x369C5D0", VA = "0x18369D9D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x4A501D0", Offset = "0x4A4EDD0", VA = "0x184A501D0")]
		public int CopyBytes(byte[] output, int offset, int length)
		{
			return 0;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x4A50480", Offset = "0x4A4F080", VA = "0x184A50480")]
		public void Reset()
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x4A50490", Offset = "0x4A4F090", VA = "0x184A50490")]
		public void SetInput(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x10")]
		private byte[] window_;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x18")]
		private int windowStart_;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x1C")]
		private int windowEnd_;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x20")]
		private uint buffer_;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x24")]
		private int bitsInBuffer_;
	}
}
