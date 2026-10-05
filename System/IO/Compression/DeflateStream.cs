using System;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO.Compression
{
	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public class DeflateStream : Stream
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x517D870", Offset = "0x517C470", VA = "0x18517D870")]
		public DeflateStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B0")]
		[Address(RVA = "0x517DA50", Offset = "0x517C650", VA = "0x18517DA50")]
		internal DeflateStream(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits)
		{
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x517D890", Offset = "0x517C490", VA = "0x18517D890")]
		internal DeflateStream(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip)
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x4C80F70", Offset = "0x4C7FB70", VA = "0x184C80F70", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0x517C970", Offset = "0x517B570", VA = "0x18517C970", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x60011B4")]
		[Address(RVA = "0x517D0D0", Offset = "0x517BCD0", VA = "0x18517D0D0")]
		private int ReadInternal(byte[] array, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x517CF50", Offset = "0x517BB50", VA = "0x18517CF50")]
		internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken)
		{
			return default(ValueTask<int>);
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x517CF90", Offset = "0x517BB90", VA = "0x18517CF90")]
		internal int ReadCore(Span<byte> destination)
		{
			return 0;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x60011B7")]
		[Address(RVA = "0x517D120", Offset = "0x517BD20", VA = "0x18517D120", Slot = "32")]
		public override int Read(byte[] array, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x517D570", Offset = "0x517C170", VA = "0x18517D570")]
		private void WriteInternal(byte[] array, int offset, int count)
		{
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00008A60 File Offset: 0x00006C60
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x517D490", Offset = "0x517C090", VA = "0x18517D490")]
		internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x517D4D0", Offset = "0x517C0D0", VA = "0x18517D4D0")]
		internal void WriteCore(ReadOnlySpan<byte> source)
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011BB")]
		[Address(RVA = "0x517D5C0", Offset = "0x517C1C0", VA = "0x18517D5C0", Slot = "35")]
		public override void Write(byte[] array, int offset, int count)
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011BC")]
		[Address(RVA = "0x517CE80", Offset = "0x517BA80", VA = "0x18517CE80", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BD")]
		[Address(RVA = "0x517C2F0", Offset = "0x517AEF0", VA = "0x18517C2F0", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BE")]
		[Address(RVA = "0x517C630", Offset = "0x517B230", VA = "0x18517C630", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x60011BF")]
		[Address(RVA = "0x517CA40", Offset = "0x517B640", VA = "0x18517CA40", Slot = "23")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C0")]
		[Address(RVA = "0x517CC60", Offset = "0x517B860", VA = "0x18517CC60", Slot = "27")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00008A90 File Offset: 0x00006C90
		[Token(Token = "0x60011C1")]
		[Address(RVA = "0x517D3F0", Offset = "0x517BFF0", VA = "0x18517D3F0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011C2")]
		[Address(RVA = "0x517D440", Offset = "0x517C040", VA = "0x18517D440", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x170003AD")]
		public override bool CanRead
		{
			[Token(Token = "0x60011C3")]
			[Address(RVA = "0x517DA70", Offset = "0x517C670", VA = "0x18517DA70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x170003AE")]
		public override bool CanSeek
		{
			[Token(Token = "0x60011C4")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[Token(Token = "0x170003AF")]
		public override bool CanWrite
		{
			[Token(Token = "0x60011C5")]
			[Address(RVA = "0x517DAD0", Offset = "0x517C6D0", VA = "0x18517DAD0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x170003B0")]
		public override long Length
		{
			[Token(Token = "0x60011C6")]
			[Address(RVA = "0x517DB30", Offset = "0x517C730", VA = "0x18517DB30", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x00008B08 File Offset: 0x00006D08
		// (set) Token: 0x060011C8 RID: 4552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003B1")]
		public override long Position
		{
			[Token(Token = "0x60011C7")]
			[Address(RVA = "0x517DB80", Offset = "0x517C780", VA = "0x18517DB80", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60011C8")]
			[Address(RVA = "0x517DBD0", Offset = "0x517C7D0", VA = "0x18517DBD0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x28")]
		private Stream base_stream;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x30")]
		private CompressionMode mode;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x34")]
		private bool leaveOpen;

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x35")]
		private bool disposed;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x38")]
		private DeflateStreamNative native;

		// Token: 0x02000277 RID: 631
		// (Invoke) Token: 0x060011CA RID: 4554
		[Token(Token = "0x2000277")]
		private delegate int ReadMethod(byte[] array, int offset, int count);

		// Token: 0x02000278 RID: 632
		// (Invoke) Token: 0x060011CE RID: 4558
		[Token(Token = "0x2000278")]
		private delegate void WriteMethod(byte[] array, int offset, int count);
	}
}
