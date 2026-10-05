using System;
using System.IO;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x4F51E90", Offset = "0x4F50A90", VA = "0x184F51E90")]
		public MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider)
		{
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public SslStream SslStream
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60", Slot = "39")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public MonoTlsSettings Settings
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public MobileTlsProvider Provider
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000026")]
		internal string TargetHost
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x22F8A80", Offset = "0x22F7680", VA = "0x1822F8A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x4F4FF70", Offset = "0x4F4EB70", VA = "0x184F4FF70")]
		internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x4F505E0", Offset = "0x4F4F1E0", VA = "0x184F505E0")]
		internal static Exception GetSSPIException(Exception e)
		{
			return null;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x4F502C0", Offset = "0x4F4EEC0", VA = "0x184F502C0")]
		internal static Exception GetIOException(Exception e, string message)
		{
			return null;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x4F50520", Offset = "0x4F4F120", VA = "0x184F50520")]
		internal static Exception GetInternalError()
		{
			return null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x4F50580", Offset = "0x4F4F180", VA = "0x184F50580")]
		internal static Exception GetInvalidNestedCallException()
		{
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x4F51A30", Offset = "0x4F50630", VA = "0x184F51A30")]
		internal ExceptionDispatchInfo SetException(Exception e)
		{
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x4F4FB00", Offset = "0x4F4E700", VA = "0x184F4FB00")]
		public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x4F4FD10", Offset = "0x4F4E910", VA = "0x184F4FD10")]
		public void AuthenticateAsServer(X509Certificate serverCertificate, bool clientCertificateRequired, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x4F4F970", Offset = "0x4F4E570", VA = "0x184F4F970", Slot = "40")]
		public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x4F51150", Offset = "0x4F4FD50", VA = "0x184F51150")]
		private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000EE RID: 238
		[Token(Token = "0x60000EE")]
		protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);

		// Token: 0x060000EF RID: 239 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x4F518E0", Offset = "0x4F504E0", VA = "0x184F518E0", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x4F51D60", Offset = "0x4F50960", VA = "0x184F51D60", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x4F51820", Offset = "0x4F50420", VA = "0x184F51820", Slot = "24")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x4F51CA0", Offset = "0x4F508A0", VA = "0x184F51CA0", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x4F51AD0", Offset = "0x4F506D0", VA = "0x184F51AD0")]
		private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x4F50C20", Offset = "0x4F4F820", VA = "0x184F50C20")]
		internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore)
		{
			return 0;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x4F50AB0", Offset = "0x4F4F6B0", VA = "0x184F50AB0")]
		private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size)
		{
			return default(ValueTuple<int, bool>);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x4F50FE0", Offset = "0x4F4FBE0", VA = "0x184F50FE0")]
		internal bool InternalWrite(byte[] buffer, int offset, int size)
		{
			return default(bool);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x4F50E20", Offset = "0x4F4FA20", VA = "0x184F50E20")]
		private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size)
		{
			return default(bool);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x4F50840", Offset = "0x4F4F440", VA = "0x184F50840")]
		internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x4F50990", Offset = "0x4F4F590", VA = "0x184F50990")]
		internal Task InnerWrite(bool sync, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x4F51290", Offset = "0x4F4FE90", VA = "0x184F51290")]
		internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate)
		{
			return AsyncOperationStatus.Initialize;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x4F515C0", Offset = "0x4F501C0", VA = "0x184F515C0")]
		internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer)
		{
			return default(ValueTuple<int, bool>);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x4F516F0", Offset = "0x4F502F0", VA = "0x184F516F0")]
		internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer)
		{
			return default(ValueTuple<int, bool>);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x17000027")]
		public override bool IsAuthenticated
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x4F522A0", Offset = "0x4F50EA0", VA = "0x184F522A0", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x4F50090", Offset = "0x4F4EC90", VA = "0x184F50090", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x4A3E4A0", Offset = "0x4A3D0A0", VA = "0x184A3E4A0", Slot = "20")]
		public override void Flush()
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public X509Certificate LocalCertificate
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x4F523C0", Offset = "0x4F50FC0", VA = "0x184F523C0", Slot = "42")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public X509Certificate InternalLocalCertificate
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x4F521A0", Offset = "0x4F50DA0", VA = "0x184F521A0", Slot = "43")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4F519E0", Offset = "0x4F505E0", VA = "0x184F519E0", Slot = "30")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4F51A80", Offset = "0x4F50680", VA = "0x184F51A80", Slot = "31")]
		public override void SetLength(long value)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x1700002A")]
		public override bool CanRead
		{
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x4F52030", Offset = "0x4F50C30", VA = "0x184F52030", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x1700002B")]
		public override bool CanTimeout
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x4F520B0", Offset = "0x4F50CB0", VA = "0x184F520B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x1700002C")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x4F52100", Offset = "0x4F50D00", VA = "0x184F52100", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x1700002D")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x1700002E")]
		public override long Length
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x4F52370", Offset = "0x4F50F70", VA = "0x184F52370", Slot = "11")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000025C8 File Offset: 0x000007C8
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002F")]
		public override long Position
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x4A3F790", Offset = "0x4A3E390", VA = "0x184A3F790", Slot = "12")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x4F52590", Offset = "0x4F51190", VA = "0x184F52590", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000030")]
		public override int ReadTimeout
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x4F524F0", Offset = "0x4F510F0", VA = "0x184F524F0", Slot = "14")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x4F525E0", Offset = "0x4F511E0", VA = "0x184F525E0", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000031")]
		public override int WriteTimeout
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x4F52540", Offset = "0x4F51140", VA = "0x184F52540", Slot = "16")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x4F52630", Offset = "0x4F51230", VA = "0x184F52630", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x38")]
		private MobileTlsContext xobileTlsContext;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x40")]
		private ExceptionDispatchInfo lastException;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x48")]
		private AsyncProtocolRequest asyncHandshakeRequest;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x50")]
		private AsyncProtocolRequest asyncReadRequest;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x58")]
		private AsyncProtocolRequest asyncWriteRequest;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x60")]
		private BufferOffsetSize2 readBuffer;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x68")]
		private BufferOffsetSize2 writeBuffer;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x70")]
		private object ioLock;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x78")]
		private int closeRequested;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x7C")]
		private bool shutdown;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x80")]
		private MobileAuthenticatedStream.Operation operation;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x0")]
		private static int uniqueNameInteger;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x4")]
		private static int nextId;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xA8")]
		internal readonly int ID;

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x2000052")]
		private enum Operation
		{
			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			None,
			// Token: 0x040000BD RID: 189
			[Token(Token = "0x40000BD")]
			Handshake,
			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			Authenticated,
			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			Renegotiate,
			// Token: 0x040000C0 RID: 192
			[Token(Token = "0x40000C0")]
			Read,
			// Token: 0x040000C1 RID: 193
			[Token(Token = "0x40000C1")]
			Write,
			// Token: 0x040000C2 RID: 194
			[Token(Token = "0x40000C2")]
			Close
		}

		// Token: 0x02000053 RID: 83
		[Token(Token = "0x2000053")]
		private enum OperationType
		{
			// Token: 0x040000C4 RID: 196
			[Token(Token = "0x40000C4")]
			Read,
			// Token: 0x040000C5 RID: 197
			[Token(Token = "0x40000C5")]
			Write,
			// Token: 0x040000C6 RID: 198
			[Token(Token = "0x40000C6")]
			Renegotiate,
			// Token: 0x040000C7 RID: 199
			[Token(Token = "0x40000C7")]
			Shutdown
		}
	}
}
