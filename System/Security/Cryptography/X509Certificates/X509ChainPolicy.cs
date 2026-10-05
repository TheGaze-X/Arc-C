using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000148 RID: 328
	[Token(Token = "0x2000148")]
	public sealed class X509ChainPolicy
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x5133F10", Offset = "0x5132B10", VA = "0x185133F10")]
		public X509ChainPolicy()
		{
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019A")]
		public X509Certificate2Collection ExtraStore
		{
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x5134040", Offset = "0x5132C40", VA = "0x185134040")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			internal set
			{
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x1700019B")]
		public X509RevocationFlag RevocationFlag
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return X509RevocationFlag.EndCertificateOnly;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000051F0 File Offset: 0x000033F0
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019C")]
		public X509RevocationMode RevocationMode
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return X509RevocationMode.NoCheck;
			}
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x51343D0", Offset = "0x5132FD0", VA = "0x1851343D0")]
			set
			{
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00005208 File Offset: 0x00003408
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019D")]
		public X509VerificationFlags VerificationFlags
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			get
			{
				return X509VerificationFlags.NoFlag;
			}
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x5134440", Offset = "0x5133040", VA = "0x185134440")]
			set
			{
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x1700019E")]
		public DateTime VerificationTime
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x5133DF0", Offset = "0x51329F0", VA = "0x185133DF0")]
		public void Reset()
		{
		}

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x10")]
		private OidCollection apps;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x18")]
		private OidCollection cert;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x20")]
		private X509CertificateCollection store;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x28")]
		private X509Certificate2Collection store2;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x30")]
		private X509RevocationFlag rflag;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x34")]
		private X509RevocationMode mode;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x38")]
		private TimeSpan timeout;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x40")]
		private X509VerificationFlags vflags;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x48")]
		private DateTime vtime;
	}
}
