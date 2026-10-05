using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200034B RID: 843
	[Token(Token = "0x200034B")]
	internal class WebOperation
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052F")]
		public HttpWebRequest Request
		{
			[Token(Token = "0x600179E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060017A0 RID: 6048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000530")]
		public WebConnection Connection
		{
			[Token(Token = "0x600179F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017A0")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060017A2 RID: 6050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000531")]
		public ServicePoint ServicePoint
		{
			[Token(Token = "0x60017A1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017A2")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000532")]
		public BufferOffsetSize WriteBuffer
		{
			[Token(Token = "0x60017A3")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x17000533")]
		public bool IsNtlmChallenge
		{
			[Token(Token = "0x60017A4")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A5")]
		[Address(RVA = "0x50998C0", Offset = "0x50984C0", VA = "0x1850998C0")]
		public WebOperation(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken)
		{
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x17000534")]
		public bool Aborted
		{
			[Token(Token = "0x60017A6")]
			[Address(RVA = "0x5099AA0", Offset = "0x50986A0", VA = "0x185099AA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x17000535")]
		public bool Closed
		{
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x5099AF0", Offset = "0x50986F0", VA = "0x185099AF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A8")]
		[Address(RVA = "0x50987E0", Offset = "0x50973E0", VA = "0x1850987E0")]
		public void Abort()
		{
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017A9")]
		[Address(RVA = "0x50989B0", Offset = "0x50975B0", VA = "0x1850989B0")]
		public void Close()
		{
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017AA")]
		[Address(RVA = "0x5099220", Offset = "0x5097E20", VA = "0x185099220")]
		private void SetCanceled()
		{
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017AB")]
		[Address(RVA = "0x50993E0", Offset = "0x5097FE0", VA = "0x1850993E0")]
		private void SetError(Exception error)
		{
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x60017AC")]
		[Address(RVA = "0x50992F0", Offset = "0x5097EF0", VA = "0x1850992F0")]
		private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field)
		{
			return default(ValueTuple<ExceptionDispatchInfo, bool>);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017AD")]
		[Address(RVA = "0x5098840", Offset = "0x5097440", VA = "0x185098840")]
		internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017AE")]
		[Address(RVA = "0x5099820", Offset = "0x5098420", VA = "0x185099820")]
		internal void ThrowIfDisposed()
		{
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017AF")]
		[Address(RVA = "0x5099730", Offset = "0x5098330", VA = "0x185099730")]
		internal void ThrowIfDisposed(CancellationToken cancellationToken)
		{
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B0")]
		[Address(RVA = "0x50995F0", Offset = "0x50981F0", VA = "0x1850995F0")]
		internal void ThrowIfClosedOrDisposed()
		{
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B1")]
		[Address(RVA = "0x5099650", Offset = "0x5098250", VA = "0x185099650")]
		internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken)
		{
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B2")]
		[Address(RVA = "0x5098930", Offset = "0x5097530", VA = "0x185098930")]
		private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field)
		{
			return null;
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B3")]
		[Address(RVA = "0x5098EC0", Offset = "0x5097AC0", VA = "0x185098EC0")]
		internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection)
		{
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017B4")]
		[Address(RVA = "0x5099480", Offset = "0x5098080", VA = "0x185099480")]
		public void SetPriorityRequest(WebOperation operation)
		{
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B5")]
		[Address(RVA = "0x5098D70", Offset = "0x5097970", VA = "0x185098D70")]
		public Task<Stream> GetRequestStream()
		{
			return null;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B6")]
		[Address(RVA = "0x5098D20", Offset = "0x5097920", VA = "0x185098D20")]
		internal Task<WebRequestStream> GetRequestStreamInternal()
		{
			return null;
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000536")]
		public WebRequestStream WriteStream
		{
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x5099B50", Offset = "0x5098750", VA = "0x185099B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017B8")]
		[Address(RVA = "0x5098E70", Offset = "0x5097A70", VA = "0x185098E70")]
		public Task<WebResponseStream> GetResponseStream()
		{
			return null;
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000537")]
		internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished
		{
			[Token(Token = "0x60017B9")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BA")]
		[Address(RVA = "0x5099160", Offset = "0x5097D60", VA = "0x185099160")]
		internal void Run()
		{
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BB")]
		[Address(RVA = "0x5098A20", Offset = "0x5097620", VA = "0x185098A20")]
		internal void CompleteRequestWritten(WebRequestStream stream, [Optional] Exception error)
		{
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017BC")]
		[Address(RVA = "0x5098AB0", Offset = "0x50976B0", VA = "0x185098AB0")]
		internal void Finish(bool ok, [Optional] Exception error)
		{
		}

		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CancellationTokenSource cts;

		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WebCompletionSource<WebRequestStream> requestTask;

		// Token: 0x04000DA9 RID: 3497
		[Token(Token = "0x4000DA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private WebCompletionSource<WebRequestStream> requestWrittenTask;

		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WebCompletionSource<WebResponseStream> responseTask;

		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask;

		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private WebRequestStream writeStream;

		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private WebResponseStream responseStream;

		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ExceptionDispatchInfo disposedInfo;

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ExceptionDispatchInfo closedInfo;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private WebOperation priorityRequest;

		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int requestSent;

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int finished;
	}
}
