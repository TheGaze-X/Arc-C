using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	public class MonoTlsConnectionInfo
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000062")]
		[CLSCompliant(false)]
		public CipherSuiteCode CipherSuiteCode
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x4889950", Offset = "0x4888550", VA = "0x184889950")]
			[CompilerGenerated]
			get
			{
				return CipherSuiteCode.TLS_NULL_WITH_NULL_NULL;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x4A5EB20", Offset = "0x4A5D720", VA = "0x184A5EB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000063")]
		public TlsProtocols ProtocolVersion
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return TlsProtocols.Zero;
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (set) Token: 0x0600014B RID: 331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000064")]
		public string PeerDomainName
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4A9E950", Offset = "0x4A9D550", VA = "0x184A9E950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MonoTlsConnectionInfo()
		{
		}
	}
}
