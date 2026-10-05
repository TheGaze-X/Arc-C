using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.IO.Compression
{
	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2000275")]
	public class GZipStream : Stream
	{
		// Token: 0x06001193 RID: 4499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001193")]
		[Address(RVA = "0x517EB40", Offset = "0x517D740", VA = "0x18517EB40")]
		public GZipStream(Stream stream, CompressionMode mode)
		{
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001194")]
		[Address(RVA = "0x517EC00", Offset = "0x517D800", VA = "0x18517EC00")]
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x170003A8")]
		public override bool CanRead
		{
			[Token(Token = "0x6001195")]
			[Address(RVA = "0x517ECE0", Offset = "0x517D8E0", VA = "0x18517ECE0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x000088F8 File Offset: 0x00006AF8
		[Token(Token = "0x170003A9")]
		public override bool CanWrite
		{
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x517ED80", Offset = "0x517D980", VA = "0x18517ED80", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x170003AA")]
		public override bool CanSeek
		{
			[Token(Token = "0x6001197")]
			[Address(RVA = "0x517ED30", Offset = "0x517D930", VA = "0x18517ED30", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x170003AB")]
		public override long Length
		{
			[Token(Token = "0x6001198")]
			[Address(RVA = "0x517EDD0", Offset = "0x517D9D0", VA = "0x18517EDD0", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00008940 File Offset: 0x00006B40
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AC")]
		public override long Position
		{
			[Token(Token = "0x6001199")]
			[Address(RVA = "0x517EE30", Offset = "0x517DA30", VA = "0x18517EE30", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600119A")]
			[Address(RVA = "0x517EE90", Offset = "0x517DA90", VA = "0x18517EE90", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119B")]
		[Address(RVA = "0x517E250", Offset = "0x517CE50", VA = "0x18517E250", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x600119C")]
		[Address(RVA = "0x517E6D0", Offset = "0x517D2D0", VA = "0x18517E6D0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600119D")]
		[Address(RVA = "0x517E730", Offset = "0x517D330", VA = "0x18517E730", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x600119E")]
		[Address(RVA = "0x517E420", Offset = "0x517D020", VA = "0x18517E420", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600119F")]
		[Address(RVA = "0x517DF50", Offset = "0x517CB50", VA = "0x18517DF50", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x60011A0")]
		[Address(RVA = "0x517E1B0", Offset = "0x517CDB0", VA = "0x18517E1B0", Slot = "23")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x517E470", Offset = "0x517D070", VA = "0x18517E470", Slot = "32")]
		public override int Read(byte[] array, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x60011A2")]
		[Address(RVA = "0x517E4F0", Offset = "0x517D0F0", VA = "0x18517E4F0", Slot = "33")]
		public override int Read(Span<byte> buffer)
		{
			return 0;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A3")]
		[Address(RVA = "0x517E020", Offset = "0x517CC20", VA = "0x18517E020", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A4")]
		[Address(RVA = "0x4B24600", Offset = "0x4B23200", VA = "0x184B24600", Slot = "27")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A5")]
		[Address(RVA = "0x517E970", Offset = "0x517D570", VA = "0x18517E970", Slot = "35")]
		public override void Write(byte[] array, int offset, int count)
		{
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A6")]
		[Address(RVA = "0x517E9F0", Offset = "0x517D5F0", VA = "0x18517E9F0", Slot = "36")]
		public override void Write(ReadOnlySpan<byte> buffer)
		{
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011A7")]
		[Address(RVA = "0x517E110", Offset = "0x517CD10", VA = "0x18517E110", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011A8")]
		[Address(RVA = "0x517E2A0", Offset = "0x517CEA0", VA = "0x18517E2A0", Slot = "24")]
		public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000089D0 File Offset: 0x00006BD0
		[Token(Token = "0x60011A9")]
		[Address(RVA = "0x517E320", Offset = "0x517CF20", VA = "0x18517E320", Slot = "25")]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, [Optional] CancellationToken cancellationToken)
		{
			return default(ValueTask<int>);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x517E7F0", Offset = "0x517D3F0", VA = "0x18517E7F0", Slot = "28")]
		public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x517E870", Offset = "0x517D470", VA = "0x18517E870", Slot = "29")]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, [Optional] CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x517E1F0", Offset = "0x517CDF0", VA = "0x18517E1F0", Slot = "21")]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x517E0F0", Offset = "0x517CCF0", VA = "0x18517E0F0")]
		private void CheckDeflateStream()
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x517E790", Offset = "0x517D390", VA = "0x18517E790")]
		[MethodImpl(8)]
		private static void ThrowStreamClosedException()
		{
		}

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private DeflateStream _deflateStream;
	}
}
