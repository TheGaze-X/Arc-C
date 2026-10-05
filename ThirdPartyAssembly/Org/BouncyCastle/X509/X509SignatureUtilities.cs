using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	internal class X509SignatureUtilities
	{
		// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x54586D0", Offset = "0x54572D0", VA = "0x1854586D0")]
		internal static void SetSignatureParameters(ISigner signature, Asn1Encodable parameters)
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x54583B0", Offset = "0x5456FB0", VA = "0x1854583B0")]
		internal static string GetSignatureName(AlgorithmIdentifier sigAlgId)
		{
			return null;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x5457EF0", Offset = "0x5456AF0", VA = "0x185457EF0")]
		private static string GetDigestAlgName(DerObjectIdentifier digestAlgOID)
		{
			return null;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public X509SignatureUtilities()
		{
		}

		// Token: 0x04000641 RID: 1601
		[Token(Token = "0x4000641")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Asn1Null derNull;
	}
}
