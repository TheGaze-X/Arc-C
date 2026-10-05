using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	internal abstract class WebReadStream : Stream
	{
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000538")]
		public WebOperation Operation
		{
			[Token(Token = "0x60017C2")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000539")]
		protected Stream InnerStream
		{
			[Token(Token = "0x60017C3")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C4")]
		[Address(RVA = "0x509A880", Offset = "0x5099480", VA = "0x18509A880")]
		public WebReadStream(WebOperation operation, Stream innerStream)
		{
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x1700053A")]
		public override long Length
		{
			[Token(Token = "0x60017C5")]
			[Address(RVA = "0x509A900", Offset = "0x5099500", VA = "0x18509A900", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0000AC98 File Offset: 0x00008E98
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053B")]
		public override long Position
		{
			[Token(Token = "0x60017C6")]
			[Address(RVA = "0x509A950", Offset = "0x5099550", VA = "0x18509A950", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60017C7")]
			[Address(RVA = "0x509A9A0", Offset = "0x50995A0", VA = "0x18509A9A0", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x1700053C")]
		public override bool CanSeek
		{
			[Token(Token = "0x60017C8")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x1700053D")]
		public override bool CanRead
		{
			[Token(Token = "0x60017C9")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x1700053E")]
		public override bool CanWrite
		{
			[Token(Token = "0x60017CA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x509A7E0", Offset = "0x50993E0", VA = "0x18509A7E0", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x509A790", Offset = "0x5099390", VA = "0x18509A790", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x509A830", Offset = "0x5099430", VA = "0x18509A830", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x509A0F0", Offset = "0x5098CF0", VA = "0x18509A0F0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x509A140", Offset = "0x5098D40", VA = "0x18509A140")]
		protected Exception GetException(Exception e)
		{
			return null;
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x509A4A0", Offset = "0x50990A0", VA = "0x18509A4A0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x5099BB0", Offset = "0x50987B0", VA = "0x185099BB0", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			return null;
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x5099EB0", Offset = "0x5098AB0", VA = "0x185099EB0", Slot = "23")]
		public override int EndRead(IAsyncResult r)
		{
			return 0;
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x509A350", Offset = "0x5098F50", VA = "0x18509A350", Slot = "24")]
		public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017D4 RID: 6100
		[Token(Token = "0x60017D4")]
		protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x5099F90", Offset = "0x5098B90", VA = "0x185099F90", Slot = "39")]
		internal virtual Task FinishReading(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x5099E60", Offset = "0x5098A60", VA = "0x185099E60", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x38")]
		private bool disposed;
	}
}
