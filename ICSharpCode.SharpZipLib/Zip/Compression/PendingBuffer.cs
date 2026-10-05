using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public class PendingBuffer
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4A50100", Offset = "0x4A4ED00", VA = "0x184A50100")]
		public PendingBuffer()
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x4A50160", Offset = "0x4A4ED60", VA = "0x184A50160")]
		public PendingBuffer(int bufferSize)
		{
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x4A4FDD0", Offset = "0x4A4E9D0", VA = "0x184A4FDD0")]
		public void Reset()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x4A4FF50", Offset = "0x4A4EB50", VA = "0x184A4FF50")]
		public void WriteByte(int value)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x4A500A0", Offset = "0x4A4ECA0", VA = "0x184A500A0")]
		public void WriteShort(int value)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x4A4FF90", Offset = "0x4A4EB90", VA = "0x184A4FF90")]
		public void WriteInt(int value)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4A4FF00", Offset = "0x4A4EB00", VA = "0x184A4FF00")]
		public void WriteBlock(byte[] block, int offset, int length)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x1700008F")]
		public int BitCount
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x4A4FCB0", Offset = "0x4A4E8B0", VA = "0x184A4FCB0")]
		public void AlignToByte()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x4A4FE70", Offset = "0x4A4EA70", VA = "0x184A4FE70")]
		public void WriteBits(int b, int count)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x4A50040", Offset = "0x4A4EC40", VA = "0x184A50040")]
		public void WriteShortMSB(int s)
		{
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x17000090")]
		public bool IsFlushed
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x4A501C0", Offset = "0x4A4EDC0", VA = "0x184A501C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x4A4FD20", Offset = "0x4A4E920", VA = "0x184A4FD20")]
		public int Flush(byte[] output, int offset, int length)
		{
			return 0;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000230A File Offset: 0x0000050A
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4A4FDE0", Offset = "0x4A4E9E0", VA = "0x184A4FDE0")]
		public byte[] ToByteArray()
		{
			return null;
		}

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x10")]
		private byte[] buffer_;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x18")]
		private int start;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x1C")]
		private int end;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x20")]
		private uint bits;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x24")]
		private int bitCount;
	}
}
