using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000359 RID: 857
	[Token(Token = "0x2000359")]
	internal class WebResponseStream : WebConnectionStream
	{
		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000545")]
		public WebRequestStream RequestStream
		{
			[Token(Token = "0x6001800")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000546")]
		public WebHeaderCollection Headers
		{
			[Token(Token = "0x6001801")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001802")]
			[Address(RVA = "0x168B8E0", Offset = "0x168A4E0", VA = "0x18168B8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000547")]
		public HttpStatusCode StatusCode
		{
			[Token(Token = "0x6001803")]
			[Address(RVA = "0x4D67380", Offset = "0x4D65F80", VA = "0x184D67380")]
			[CompilerGenerated]
			get
			{
				return (HttpStatusCode)0;
			}
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x4D67390", Offset = "0x4D65F90", VA = "0x184D67390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001806 RID: 6150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000548")]
		public string StatusDescription
		{
			[Token(Token = "0x6001805")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001806")]
			[Address(RVA = "0xF93850", Offset = "0xF92450", VA = "0x180F93850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001808 RID: 6152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000549")]
		public Version Version
		{
			[Token(Token = "0x6001807")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001808")]
			[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054A")]
		public bool KeepAlive
		{
			[Token(Token = "0x6001809")]
			[Address(RVA = "0x32F71F0", Offset = "0x32F5DF0", VA = "0x1832F71F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600180A")]
			[Address(RVA = "0x32F7210", Offset = "0x32F5E10", VA = "0x1832F7210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600180B RID: 6155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180B")]
		[Address(RVA = "0x50B7A80", Offset = "0x50B6680", VA = "0x1850B7A80")]
		public WebResponseStream(WebRequestStream request)
		{
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x1700054B")]
		public override bool CanRead
		{
			[Token(Token = "0x600180C")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x0000AE18 File Offset: 0x00009018
		[Token(Token = "0x1700054C")]
		public override bool CanWrite
		{
			[Token(Token = "0x600180D")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0000AE30 File Offset: 0x00009030
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054D")]
		private bool ChunkedRead
		{
			[Token(Token = "0x600180E")]
			[Address(RVA = "0x4211D50", Offset = "0x4210950", VA = "0x184211D50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600180F")]
			[Address(RVA = "0x4211D60", Offset = "0x4210960", VA = "0x184211D60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x50B77B0", Offset = "0x50B63B0", VA = "0x1850B77B0", Slot = "24")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001811")]
		[Address(RVA = "0x50B72B0", Offset = "0x50B5EB0", VA = "0x1850B72B0")]
		private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x50B7910", Offset = "0x50B6510", VA = "0x1850B7910", Slot = "38")]
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result)
		{
			return default(bool);
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x1700054E")]
		private bool ExpectContent
		{
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x50B7B20", Offset = "0x50B6720", VA = "0x1850B7B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x50B6CE0", Offset = "0x50B58E0", VA = "0x1850B6CE0")]
		private void Initialize(BufferOffsetSize buffer)
		{
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001815")]
		[Address(RVA = "0x50B7560", Offset = "0x50B6160", VA = "0x1850B7560")]
		private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x50B7690", Offset = "0x50B6290", VA = "0x1850B7690")]
		internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x50B79F0", Offset = "0x50B65F0", VA = "0x1850B79F0", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x50B60B0", Offset = "0x50B4CB0", VA = "0x1850B60B0", Slot = "39")]
		protected override void Close_internal(ref bool disposed)
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x50B6150", Offset = "0x50B4D50", VA = "0x1850B6150")]
		private WebException GetReadException(WebExceptionStatus status, Exception error, string where)
		{
			return null;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x50B6BD0", Offset = "0x50B57D0", VA = "0x1850B6BD0")]
		internal Task InitReadAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x600181B")]
		[Address(RVA = "0x50B63F0", Offset = "0x50B4FF0", VA = "0x1850B63F0")]
		private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state)
		{
			return default(bool);
		}

		// Token: 0x04000E0D RID: 3597
		[Token(Token = "0x4000E0D")]
		[FieldOffset(Offset = "0x58")]
		private WebReadStream innerStream;

		// Token: 0x04000E0E RID: 3598
		[Token(Token = "0x4000E0E")]
		[FieldOffset(Offset = "0x60")]
		private bool nextReadCalled;

		// Token: 0x04000E0F RID: 3599
		[Token(Token = "0x4000E0F")]
		[FieldOffset(Offset = "0x61")]
		private bool bufferedEntireContent;

		// Token: 0x04000E10 RID: 3600
		[Token(Token = "0x4000E10")]
		[FieldOffset(Offset = "0x68")]
		private WebCompletionSource pendingRead;

		// Token: 0x04000E11 RID: 3601
		[Token(Token = "0x4000E11")]
		[FieldOffset(Offset = "0x70")]
		private object locker;

		// Token: 0x04000E12 RID: 3602
		[Token(Token = "0x4000E12")]
		[FieldOffset(Offset = "0x78")]
		private int nestedRead;

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000E13")]
		[FieldOffset(Offset = "0x7C")]
		private bool read_eof;
	}
}
