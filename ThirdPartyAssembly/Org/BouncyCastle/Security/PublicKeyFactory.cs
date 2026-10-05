using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Security
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	public sealed class PublicKeyFactory
	{
		// Token: 0x06000814 RID: 2068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private PublicKeyFactory()
		{
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000815")]
		[Address(RVA = "0x5468760", Offset = "0x5467360", VA = "0x185468760")]
		public static AsymmetricKeyParameter CreateKey(byte[] keyInfoData)
		{
			return null;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x5469850", Offset = "0x5468450", VA = "0x185469850")]
		public static AsymmetricKeyParameter CreateKey(Stream inStr)
		{
			return null;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x5468790", Offset = "0x5467390", VA = "0x185468790")]
		public static AsymmetricKeyParameter CreateKey(SubjectPublicKeyInfo keyInfo)
		{
			return null;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x5469880", Offset = "0x5468480", VA = "0x185469880")]
		private static bool IsPkcsDHParam(Asn1Sequence seq)
		{
			return default(bool);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x5469A40", Offset = "0x5468640", VA = "0x185469A40")]
		private static DHPublicKeyParameters ReadPkcsDHParam(DerObjectIdentifier algOid, BigInteger y, Asn1Sequence seq)
		{
			return null;
		}
	}
}
