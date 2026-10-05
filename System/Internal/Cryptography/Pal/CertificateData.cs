using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Internal.Cryptography.Pal
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	internal struct CertificateData
	{
		// Token: 0x06000355 RID: 853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x50CA740", Offset = "0x50C9340", VA = "0x1850CA740")]
		internal CertificateData(byte[] rawData)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x50C9F60", Offset = "0x50C8B60", VA = "0x1850C9F60")]
		public string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			return null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x50CA400", Offset = "0x50C9000", VA = "0x1850CA400")]
		private static string GetSimpleNameInfo(X500DistinguishedName name)
		{
			return null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x50C9DA0", Offset = "0x50C89A0", VA = "0x1850C9DA0")]
		private static string FindAltNameMatch(byte[] extensionBytes, GeneralNameType matchType, string otherOid)
		{
			return null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x50CA6C0", Offset = "0x50C92C0", VA = "0x1850CA6C0")]
		private static IEnumerable<KeyValuePair<string, string>> ReadReverseRdns(X500DistinguishedName name)
		{
			return null;
		}

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x0")]
		internal byte[] RawData;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x8")]
		internal byte[] SubjectPublicKeyInfo;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x10")]
		internal int Version;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x18")]
		internal byte[] SerialNumber;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x20")]
		internal CertificateData.AlgorithmIdentifier TbsSignature;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x30")]
		internal X500DistinguishedName Issuer;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x38")]
		internal DateTime NotBefore;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x40")]
		internal DateTime NotAfter;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x48")]
		internal X500DistinguishedName Subject;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x50")]
		internal CertificateData.AlgorithmIdentifier PublicKeyAlgorithm;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x60")]
		internal byte[] PublicKey;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x68")]
		internal byte[] IssuerUniqueId;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x70")]
		internal byte[] SubjectUniqueId;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x78")]
		internal List<X509Extension> Extensions;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x80")]
		internal CertificateData.AlgorithmIdentifier SignatureAlgorithm;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x90")]
		internal byte[] SignatureValue;

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		internal struct AlgorithmIdentifier
		{
			// Token: 0x04000201 RID: 513
			[Token(Token = "0x4000201")]
			[FieldOffset(Offset = "0x0")]
			internal string AlgorithmId;

			// Token: 0x04000202 RID: 514
			[Token(Token = "0x4000202")]
			[FieldOffset(Offset = "0x8")]
			internal byte[] Parameters;
		}
	}
}
