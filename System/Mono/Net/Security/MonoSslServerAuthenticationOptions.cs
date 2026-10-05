using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	internal sealed class MonoSslServerAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public SslServerAuthenticationOptions Options
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x17000054")]
		public override bool ServerMode
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4F5C170", Offset = "0x4F5AD70", VA = "0x184F5C170")]
		public MonoSslServerAuthenticationOptions()
		{
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x17000055")]
		public override bool AllowRenegotiation
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x4F5BF80", Offset = "0x4F5AB80", VA = "0x184F5BF80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000056 RID: 86
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000056")]
		public override X509RevocationMode CertificateRevocationCheckMode
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x4F5C2C0", Offset = "0x4F5AEC0", VA = "0x184F5C2C0", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x17000057 RID: 87
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000057")]
		public override EncryptionPolicy EncryptionPolicy
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x4F5C370", Offset = "0x4F5AF70", VA = "0x184F5C370", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000058")]
		public override SslProtocols EnabledSslProtocols
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x4F5C250", Offset = "0x4F5AE50", VA = "0x184F5C250", Slot = "6")]
			get
			{
				return SslProtocols.None;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x4F5C350", Offset = "0x4F5AF50", VA = "0x184F5C350", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000059")]
		public override bool ClientCertificateRequired
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x4F5C1E0", Offset = "0x4F5ADE0", VA = "0x184F5C1E0", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4F5C2E0", Offset = "0x4F5AEE0", VA = "0x184F5C2E0", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005A")]
		public override string TargetHost
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x4F5C270", Offset = "0x4F5AE70", VA = "0x184F5C270", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x4F5C390", Offset = "0x4F5AF90", VA = "0x184F5C390", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005B")]
		public override X509Certificate ServerCertificate
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x4DF2DF0", Offset = "0x4DF19F0", VA = "0x184DF2DF0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x31BC240", Offset = "0x31BAE40", VA = "0x1831BC240", Slot = "13")]
			set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005C")]
		public override X509CertificateCollection ClientCertificates
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x4F5C200", Offset = "0x4F5AE00", VA = "0x184F5C200", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x4F5C300", Offset = "0x4F5AF00", VA = "0x184F5C300", Slot = "15")]
			set
			{
			}
		}
	}
}
