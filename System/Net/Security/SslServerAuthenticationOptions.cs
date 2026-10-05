using System;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net.Security
{
	// Token: 0x020003CE RID: 974
	[Token(Token = "0x20003CE")]
	public class SslServerAuthenticationOptions
	{
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x0000BB08 File Offset: 0x00009D08
		[Token(Token = "0x170005BD")]
		public bool AllowRenegotiation
		{
			[Token(Token = "0x6001A3A")]
			[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001A3B RID: 6715 RVA: 0x0000BB20 File Offset: 0x00009D20
		// (set) Token: 0x06001A3C RID: 6716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BE")]
		public bool ClientCertificateRequired
		{
			[Token(Token = "0x6001A3B")]
			[Address(RVA = "0x1241200", Offset = "0x123FE00", VA = "0x181241200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A3C")]
			[Address(RVA = "0x1241220", Offset = "0x123FE20", VA = "0x181241220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001A3D RID: 6717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001A3E RID: 6718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005BF")]
		public X509Certificate ServerCertificate
		{
			[Token(Token = "0x6001A3D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A3E")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001A3F RID: 6719 RVA: 0x0000BB38 File Offset: 0x00009D38
		// (set) Token: 0x06001A40 RID: 6720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C0")]
		public SslProtocols EnabledSslProtocols
		{
			[Token(Token = "0x6001A3F")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return SslProtocols.None;
			}
			[Token(Token = "0x6001A40")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (set) Token: 0x06001A41 RID: 6721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C1")]
		public X509RevocationMode CertificateRevocationCheckMode
		{
			[Token(Token = "0x6001A41")]
			[Address(RVA = "0x50C1FD0", Offset = "0x50C0BD0", VA = "0x1850C1FD0")]
			set
			{
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C2")]
		public EncryptionPolicy EncryptionPolicy
		{
			[Token(Token = "0x6001A42")]
			[Address(RVA = "0x50C2080", Offset = "0x50C0C80", VA = "0x1850C2080")]
			set
			{
			}
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x50C1E60", Offset = "0x50C0A60", VA = "0x1850C1E60")]
		public SslServerAuthenticationOptions()
		{
		}

		// Token: 0x04001116 RID: 4374
		[Token(Token = "0x4001116")]
		[FieldOffset(Offset = "0x10")]
		private X509RevocationMode _checkCertificateRevocation;

		// Token: 0x04001117 RID: 4375
		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x14")]
		private SslProtocols _enabledSslProtocols;

		// Token: 0x04001118 RID: 4376
		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x18")]
		private EncryptionPolicy _encryptionPolicy;

		// Token: 0x04001119 RID: 4377
		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0x1C")]
		private bool _allowRenegotiation;
	}
}
