using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000350 RID: 848
	[Token(Token = "0x2000350")]
	internal class WebRequestStream : WebConnectionStream
	{
		// Token: 0x060017D9 RID: 6105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D9")]
		[Address(RVA = "0x509BD00", Offset = "0x509A900", VA = "0x18509BD00")]
		public WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel)
		{
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060017DA RID: 6106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700053F")]
		internal Stream InnerStream
		{
			[Token(Token = "0x60017DA")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x17000540")]
		public bool KeepAlive
		{
			[Token(Token = "0x60017DB")]
			[Address(RVA = "0x9069B0", Offset = "0x9055B0", VA = "0x1809069B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x17000541")]
		public override bool CanRead
		{
			[Token(Token = "0x60017DC")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x17000542")]
		public override bool CanWrite
		{
			[Token(Token = "0x60017DD")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060017DE RID: 6110 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x17000543")]
		internal bool HasWriteBuffer
		{
			[Token(Token = "0x60017DE")]
			[Address(RVA = "0x509BF50", Offset = "0x509AB50", VA = "0x18509BF50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x17000544")]
		internal int WriteBufferLength
		{
			[Token(Token = "0x60017DF")]
			[Address(RVA = "0x509BF80", Offset = "0x509AB80", VA = "0x18509BF80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x509AE50", Offset = "0x5099A50", VA = "0x18509AE50")]
		internal BufferOffsetSize GetWriteBuffer()
		{
			return null;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x509AD50", Offset = "0x5099950", VA = "0x18509AD50")]
		private Task FinishWriting(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x509B540", Offset = "0x509A140", VA = "0x18509B540", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x509B400", Offset = "0x509A000", VA = "0x18509B400")]
		private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x509B0B0", Offset = "0x5099CB0", VA = "0x18509B0B0")]
		private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x509A9F0", Offset = "0x50995F0", VA = "0x18509A9F0")]
		private void CheckWriteOverflow(long contentLength, long totalWritten, long size)
		{
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E6")]
		[Address(RVA = "0x509AF80", Offset = "0x5099B80", VA = "0x18509AF80")]
		internal Task Initialize(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E7")]
		[Address(RVA = "0x509B290", Offset = "0x5099E90", VA = "0x18509B290")]
		private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E8")]
		[Address(RVA = "0x509BB60", Offset = "0x509A760", VA = "0x18509BB60")]
		internal Task WriteRequestAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x509B970", Offset = "0x509A570", VA = "0x18509B970")]
		private Task WriteChunkTrailer_inner(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EA")]
		[Address(RVA = "0x509BA70", Offset = "0x509A670", VA = "0x18509BA70")]
		private Task WriteChunkTrailer()
		{
			return null;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x509B090", Offset = "0x5099C90", VA = "0x18509B090")]
		internal void KillBuffer()
		{
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x509B1F0", Offset = "0x5099DF0", VA = "0x18509B1F0", Slot = "24")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x509B3B0", Offset = "0x5099FB0", VA = "0x18509B3B0", Slot = "38")]
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result)
		{
			return default(bool);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x509AAB0", Offset = "0x50996B0", VA = "0x18509AAB0", Slot = "39")]
		protected override void Close_internal(ref bool disposed)
		{
		}

		// Token: 0x04000DCA RID: 3530
		[Token(Token = "0x4000DCA")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] crlf;

		// Token: 0x04000DCB RID: 3531
		[Token(Token = "0x4000DCB")]
		[FieldOffset(Offset = "0x58")]
		private MemoryStream writeBuffer;

		// Token: 0x04000DCC RID: 3532
		[Token(Token = "0x4000DCC")]
		[FieldOffset(Offset = "0x60")]
		private bool requestWritten;

		// Token: 0x04000DCD RID: 3533
		[Token(Token = "0x4000DCD")]
		[FieldOffset(Offset = "0x61")]
		private bool allowBuffering;

		// Token: 0x04000DCE RID: 3534
		[Token(Token = "0x4000DCE")]
		[FieldOffset(Offset = "0x62")]
		private bool sendChunked;

		// Token: 0x04000DCF RID: 3535
		[Token(Token = "0x4000DCF")]
		[FieldOffset(Offset = "0x68")]
		private WebCompletionSource pendingWrite;

		// Token: 0x04000DD0 RID: 3536
		[Token(Token = "0x4000DD0")]
		[FieldOffset(Offset = "0x70")]
		private long totalWritten;

		// Token: 0x04000DD1 RID: 3537
		[Token(Token = "0x4000DD1")]
		[FieldOffset(Offset = "0x78")]
		private byte[] headers;

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000DD2")]
		[FieldOffset(Offset = "0x80")]
		private bool headersSent;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0x84")]
		private int completeRequestWritten;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000DD4")]
		[FieldOffset(Offset = "0x88")]
		private int chunkTrailerWritten;
	}
}
