using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net.Security
{
	// Token: 0x020003CD RID: 973
	[Token(Token = "0x20003CD")]
	public class SslClientAuthenticationOptions
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x170005B7")]
		public bool AllowRenegotiation
		{
			[Token(Token = "0x6001A30")]
			[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B8")]
		public string TargetHost
		{
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A32")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A34 RID: 6708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B9")]
		public X509CertificateCollection ClientCertificates
		{
			[Token(Token = "0x6001A33")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A34")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005BA RID: 1466
		// (set) Token: 0x06001A35 RID: 6709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BA")]
		public X509RevocationMode CertificateRevocationCheckMode
		{
			[Token(Token = "0x6001A35")]
			[Address(RVA = "0x50C1E70", Offset = "0x50C0A70", VA = "0x1850C1E70")]
			set
			{
			}
		}

		// Token: 0x170005BB RID: 1467
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BB")]
		public EncryptionPolicy EncryptionPolicy
		{
			[Token(Token = "0x6001A36")]
			[Address(RVA = "0x50C1F20", Offset = "0x50C0B20", VA = "0x1850C1F20")]
			set
			{
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BC")]
		public SslProtocols EnabledSslProtocols
		{
			[Token(Token = "0x6001A37")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return SslProtocols.None;
			}
			[Token(Token = "0x6001A38")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x50C1E60", Offset = "0x50C0A60", VA = "0x1850C1E60")]
		public SslClientAuthenticationOptions()
		{
		}

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x10")]
		private EncryptionPolicy _encryptionPolicy;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x14")]
		private X509RevocationMode _checkCertificateRevocation;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x18")]
		private SslProtocols _enabledSslProtocols;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x1C")]
		private bool _allowRenegotiation;
	}
}
