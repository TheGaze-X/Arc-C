using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class NetworkStream : Stream
	{
		// Token: 0x060018C5 RID: 6341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x50A11A0", Offset = "0x509FDA0", VA = "0x1850A11A0")]
		public NetworkStream(Socket socket)
		{
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C6")]
		[Address(RVA = "0x50A11C0", Offset = "0x509FDC0", VA = "0x1850A11C0")]
		public NetworkStream(Socket socket, bool ownsSocket)
		{
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C7")]
		[Address(RVA = "0x50A11F0", Offset = "0x509FDF0", VA = "0x1850A11F0")]
		public NetworkStream(Socket socket, FileAccess access, bool ownsSocket)
		{
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x1700057A")]
		public override bool CanRead
		{
			[Token(Token = "0x60018C8")]
			[Address(RVA = "0x4E1BBB0", Offset = "0x4E1A7B0", VA = "0x184E1BBB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060018C9 RID: 6345 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x1700057B")]
		public override bool CanSeek
		{
			[Token(Token = "0x60018C9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x1700057C")]
		public override bool CanWrite
		{
			[Token(Token = "0x60018CA")]
			[Address(RVA = "0xF02F50", Offset = "0xF01B50", VA = "0x180F02F50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x1700057D")]
		public override bool CanTimeout
		{
			[Token(Token = "0x60018CB")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x0000B208 File Offset: 0x00009408
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057E")]
		public override int ReadTimeout
		{
			[Token(Token = "0x60018CC")]
			[Address(RVA = "0x50A16D0", Offset = "0x50A02D0", VA = "0x1850A16D0", Slot = "14")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60018CD")]
			[Address(RVA = "0x50A1850", Offset = "0x50A0450", VA = "0x1850A1850", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x0000B220 File Offset: 0x00009420
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057F")]
		public override int WriteTimeout
		{
			[Token(Token = "0x60018CE")]
			[Address(RVA = "0x50A1760", Offset = "0x50A0360", VA = "0x1850A1760", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60018CF")]
			[Address(RVA = "0x50A18F0", Offset = "0x50A04F0", VA = "0x1850A18F0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x17000580")]
		public virtual bool DataAvailable
		{
			[Token(Token = "0x60018D0")]
			[Address(RVA = "0x50A1410", Offset = "0x50A0010", VA = "0x1850A1410", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060018D1 RID: 6353 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x17000581")]
		public override long Length
		{
			[Token(Token = "0x60018D1")]
			[Address(RVA = "0x50A1610", Offset = "0x50A0210", VA = "0x1850A1610", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0000B268 File Offset: 0x00009468
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000582")]
		public override long Position
		{
			[Token(Token = "0x60018D2")]
			[Address(RVA = "0x50A1670", Offset = "0x50A0270", VA = "0x1850A1670", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60018D3")]
			[Address(RVA = "0x50A17F0", Offset = "0x50A03F0", VA = "0x1850A17F0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x60018D4")]
		[Address(RVA = "0x50A0130", Offset = "0x509ED30", VA = "0x1850A0130", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x60018D5")]
		[Address(RVA = "0x509FDB0", Offset = "0x509E9B0", VA = "0x18509FDB0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x509FA60", Offset = "0x509E660", VA = "0x18509FA60", Slot = "33")]
		public override int Read(Span<byte> destination)
		{
			return 0;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x509F9B0", Offset = "0x509E5B0", VA = "0x18509F9B0", Slot = "34")]
		public override int ReadByte()
		{
			return 0;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x50A0E20", Offset = "0x509FA20", VA = "0x1850A0E20", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018D9")]
		[Address(RVA = "0x50A0B30", Offset = "0x509F730", VA = "0x1850A0B30", Slot = "36")]
		public override void Write(ReadOnlySpan<byte> source)
		{
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DA")]
		[Address(RVA = "0x50A0A90", Offset = "0x509F690", VA = "0x1850A0A90", Slot = "37")]
		public override void WriteByte(byte value)
		{
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DB")]
		[Address(RVA = "0x509EA10", Offset = "0x509D610", VA = "0x18509EA10")]
		public void Close(int timeout)
		{
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x509EA90", Offset = "0x509D690", VA = "0x18509EA90", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x4C80F70", Offset = "0x4C7FB70", VA = "0x184C80F70", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x509E2D0", Offset = "0x509CED0", VA = "0x18509E2D0", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x509EBE0", Offset = "0x509D7E0", VA = "0x18509EBE0", Slot = "23")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x509E670", Offset = "0x509D270", VA = "0x18509E670", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x509EF10", Offset = "0x509DB10", VA = "0x18509EF10", Slot = "27")]
		public override void EndWrite(IAsyncResult asyncResult)
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x509F2C0", Offset = "0x509DEC0", VA = "0x18509F2C0", Slot = "24")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x509F710", Offset = "0x509E310", VA = "0x18509F710", Slot = "25")]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken)
		{
			return default(ValueTask<int>);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E4")]
		[Address(RVA = "0x50A03C0", Offset = "0x509EFC0", VA = "0x1850A03C0", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x60018E5")]
		[Address(RVA = "0x50A0800", Offset = "0x509F400", VA = "0x1850A0800", Slot = "29")]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x509F230", Offset = "0x509DE30", VA = "0x18509F230", Slot = "21")]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x50A0190", Offset = "0x509ED90", VA = "0x1850A0190", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x50A01F0", Offset = "0x509EDF0", VA = "0x1850A01F0")]
		internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent)
		{
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000583")]
		internal Socket InternalSocket
		{
			[Token(Token = "0x60018EA")]
			[Address(RVA = "0x50A1560", Offset = "0x50A0160", VA = "0x1850A1560")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x28")]
		private readonly Socket _streamSocket;

		// Token: 0x04000F67 RID: 3943
		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x30")]
		private readonly bool _ownsSocket;

		// Token: 0x04000F68 RID: 3944
		[Token(Token = "0x4000F68")]
		[FieldOffset(Offset = "0x31")]
		private bool _readable;

		// Token: 0x04000F69 RID: 3945
		[Token(Token = "0x4000F69")]
		[FieldOffset(Offset = "0x32")]
		private bool _writeable;

		// Token: 0x04000F6A RID: 3946
		[Token(Token = "0x4000F6A")]
		[FieldOffset(Offset = "0x34")]
		private int _closeTimeout;

		// Token: 0x04000F6B RID: 3947
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x38")]
		private bool _cleanedUp;

		// Token: 0x04000F6C RID: 3948
		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x3C")]
		private int _currentReadTimeout;

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x40")]
		private int _currentWriteTimeout;
	}
}
