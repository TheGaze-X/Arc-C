using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	internal abstract class MonoSslAuthenticationOptions
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600013D RID: 317
		[Token(Token = "0x1700003F")]
		public abstract bool ServerMode { [Token(Token = "0x600013D")] get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600013E RID: 318
		[Token(Token = "0x17000040")]
		public abstract bool AllowRenegotiation { [Token(Token = "0x600013E")] get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600013F RID: 319
		// (set) Token: 0x06000140 RID: 320
		[Token(Token = "0x17000041")]
		public abstract SslProtocols EnabledSslProtocols { [Token(Token = "0x600013F")] get; [Token(Token = "0x6000140")] set; }

		// Token: 0x17000042 RID: 66
		// (set) Token: 0x06000141 RID: 321
		[Token(Token = "0x17000042")]
		public abstract EncryptionPolicy EncryptionPolicy { [Token(Token = "0x6000141")] set; }

		// Token: 0x17000043 RID: 67
		// (set) Token: 0x06000142 RID: 322
		[Token(Token = "0x17000043")]
		public abstract X509RevocationMode CertificateRevocationCheckMode { [Token(Token = "0x6000142")] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000143 RID: 323
		// (set) Token: 0x06000144 RID: 324
		[Token(Token = "0x17000044")]
		public abstract string TargetHost { [Token(Token = "0x6000143")] get; [Token(Token = "0x6000144")] set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000145 RID: 325
		// (set) Token: 0x06000146 RID: 326
		[Token(Token = "0x17000045")]
		public abstract X509Certificate ServerCertificate { [Token(Token = "0x6000145")] get; [Token(Token = "0x6000146")] set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000147 RID: 327
		// (set) Token: 0x06000148 RID: 328
		[Token(Token = "0x17000046")]
		public abstract X509CertificateCollection ClientCertificates { [Token(Token = "0x6000147")] get; [Token(Token = "0x6000148")] set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000149 RID: 329
		// (set) Token: 0x0600014A RID: 330
		[Token(Token = "0x17000047")]
		public abstract bool ClientCertificateRequired { [Token(Token = "0x6000149")] get; [Token(Token = "0x600014A")] set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		internal ServerCertSelectionCallback ServerCertSelectionDelegate
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected MonoSslAuthenticationOptions()
		{
		}
	}
}
