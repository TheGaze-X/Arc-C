using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200013C RID: 316
	[Token(Token = "0x200013C")]
	internal abstract class X509Certificate2Impl : X509CertificateImpl
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600079C RID: 1948
		[Token(Token = "0x17000160")]
		public abstract IEnumerable<X509Extension> Extensions { [Token(Token = "0x600079C")] get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600079D RID: 1949
		[Token(Token = "0x17000161")]
		public abstract X500DistinguishedName IssuerName { [Token(Token = "0x600079D")] get; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600079E RID: 1950
		// (set) Token: 0x0600079F RID: 1951
		[Token(Token = "0x17000162")]
		public abstract AsymmetricAlgorithm PrivateKey { [Token(Token = "0x600079E")] get; [Token(Token = "0x600079F")] set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060007A0 RID: 1952
		[Token(Token = "0x17000163")]
		public abstract string SignatureAlgorithm { [Token(Token = "0x60007A0")] get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060007A1 RID: 1953
		[Token(Token = "0x17000164")]
		public abstract X500DistinguishedName SubjectName { [Token(Token = "0x60007A1")] get; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060007A2 RID: 1954
		[Token(Token = "0x17000165")]
		public abstract int Version { [Token(Token = "0x60007A2")] get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060007A3 RID: 1955
		[Token(Token = "0x17000166")]
		internal abstract X509CertificateImplCollection IntermediateCertificates { [Token(Token = "0x60007A3")] get; }

		// Token: 0x060007A4 RID: 1956
		[Token(Token = "0x60007A4")]
		public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

		// Token: 0x060007A5 RID: 1957
		[Token(Token = "0x60007A5")]
		public abstract bool Verify(X509Certificate2 thisCertificate);

		// Token: 0x060007A6 RID: 1958
		[Token(Token = "0x60007A6")]
		public abstract void AppendPrivateKeyInfo(StringBuilder sb);

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x512B760", Offset = "0x512A360", VA = "0x18512B760", Slot = "21")]
		public sealed override X509CertificateImpl CopyWithPrivateKey(RSA privateKey)
		{
			return null;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected X509Certificate2Impl()
		{
		}
	}
}
