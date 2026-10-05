using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	internal class MonoTlsStream : IDisposable
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		internal HttpWebRequest Request
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x1700005E")]
		internal WebExceptionStatus ExceptionStatus
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return WebExceptionStatus.Success;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005F")]
		internal bool CertificateValidationFailed
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x220E7B0", Offset = "0x220D3B0", VA = "0x18220E7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x4E71920", Offset = "0x4E70520", VA = "0x184E71920")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4F5DB80", Offset = "0x4F5C780", VA = "0x184F5DB80")]
		public MonoTlsStream(HttpWebRequest request, NetworkStream networkStream)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x4F5DA20", Offset = "0x4F5C620", VA = "0x184F5DA20")]
		internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken)
		{
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x4F5DB70", Offset = "0x4F5C770", VA = "0x184F5DB70", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4F5D970", Offset = "0x4F5C570", VA = "0x184F5D970")]
		private void CloseSslStream()
		{
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x10")]
		private readonly MobileTlsProvider provider;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x18")]
		private readonly NetworkStream networkStream;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x20")]
		private readonly HttpWebRequest request;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x28")]
		private readonly MonoTlsSettings settings;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x30")]
		private SslStream sslStream;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x38")]
		private readonly object sslStreamLock;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x40")]
		private WebExceptionStatus status;
	}
}
