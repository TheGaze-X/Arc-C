using System;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public SslClientAuthenticationOptions Options
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x1700004A")]
		public override bool ServerMode
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4F5BF10", Offset = "0x4F5AB10", VA = "0x184F5BF10")]
		public MonoSslClientAuthenticationOptions()
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x1700004B")]
		public override bool AllowRenegotiation
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x4F5BF80", Offset = "0x4F5AB80", VA = "0x184F5BF80", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004C RID: 76
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004C")]
		public override X509RevocationMode CertificateRevocationCheckMode
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x4F5C040", Offset = "0x4F5AC40", VA = "0x184F5C040", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (set) Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004D")]
		public override EncryptionPolicy EncryptionPolicy
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x4F5C100", Offset = "0x4F5AD00", VA = "0x184F5C100", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000153 RID: 339 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004E")]
		public override SslProtocols EnabledSslProtocols
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x4BA9410", Offset = "0x4BA8010", VA = "0x184BA9410", Slot = "6")]
			get
			{
				return SslProtocols.None;
			}
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x4F5C0E0", Offset = "0x4F5ACE0", VA = "0x184F5C0E0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004F")]
		public override string TargetHost
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x4DF2DF0", Offset = "0x4DF19F0", VA = "0x184DF2DF0", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x31BC240", Offset = "0x31BAE40", VA = "0x1831BC240", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000026D0 File Offset: 0x000008D0
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000050")]
		public override bool ClientCertificateRequired
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x4F5BFA0", Offset = "0x4F5ABA0", VA = "0x184F5BFA0", Slot = "16")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x4F5C060", Offset = "0x4F5AC60", VA = "0x184F5C060", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000051")]
		public override X509CertificateCollection ClientCertificates
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x4A52E30", Offset = "0x4A51A30", VA = "0x184A52E30", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x4F5C0B0", Offset = "0x4F5ACB0", VA = "0x184F5C0B0", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000052")]
		public override X509Certificate ServerCertificate
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x4F5BFF0", Offset = "0x4F5ABF0", VA = "0x184F5BFF0", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x4F5C120", Offset = "0x4F5AD20", VA = "0x184F5C120", Slot = "13")]
			set
			{
			}
		}
	}
}
