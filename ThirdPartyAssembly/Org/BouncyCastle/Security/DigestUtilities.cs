using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Security
{
	// Token: 0x02000154 RID: 340
	[Token(Token = "0x2000154")]
	public sealed class DigestUtilities
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private DigestUtilities()
		{
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x545C240", Offset = "0x545AE40", VA = "0x18545C240")]
		public static DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			return null;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DB")]
		public static ICollection Algorithms
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x545D740", Offset = "0x545C340", VA = "0x18545D740")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x545B930", Offset = "0x545A530", VA = "0x18545B930")]
		public static IDigest GetDigest(DerObjectIdentifier id)
		{
			return null;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x545B990", Offset = "0x545A590", VA = "0x18545B990")]
		public static IDigest GetDigest(string algorithm)
		{
			return null;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x545B870", Offset = "0x545A470", VA = "0x18545B870")]
		public static string GetAlgorithmName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x545B5A0", Offset = "0x545A1A0", VA = "0x18545B5A0")]
		public static byte[] CalculateDigest(string algorithm, byte[] input)
		{
			return null;
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x545B7D0", Offset = "0x545A3D0", VA = "0x18545B7D0")]
		public static byte[] DoFinal(IDigest digest)
		{
			return null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x545B6C0", Offset = "0x545A2C0", VA = "0x18545B6C0")]
		public static byte[] DoFinal(IDigest digest, byte[] input)
		{
			return null;
		}

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary algorithms;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary oids;

		// Token: 0x02000155 RID: 341
		[Token(Token = "0x2000155")]
		private enum DigestAlgorithm
		{
			// Token: 0x040007D5 RID: 2005
			[Token(Token = "0x40007D5")]
			GOST3411,
			// Token: 0x040007D6 RID: 2006
			[Token(Token = "0x40007D6")]
			KECCAK_224,
			// Token: 0x040007D7 RID: 2007
			[Token(Token = "0x40007D7")]
			KECCAK_256,
			// Token: 0x040007D8 RID: 2008
			[Token(Token = "0x40007D8")]
			KECCAK_288,
			// Token: 0x040007D9 RID: 2009
			[Token(Token = "0x40007D9")]
			KECCAK_384,
			// Token: 0x040007DA RID: 2010
			[Token(Token = "0x40007DA")]
			KECCAK_512,
			// Token: 0x040007DB RID: 2011
			[Token(Token = "0x40007DB")]
			MD2,
			// Token: 0x040007DC RID: 2012
			[Token(Token = "0x40007DC")]
			MD4,
			// Token: 0x040007DD RID: 2013
			[Token(Token = "0x40007DD")]
			MD5,
			// Token: 0x040007DE RID: 2014
			[Token(Token = "0x40007DE")]
			RIPEMD128,
			// Token: 0x040007DF RID: 2015
			[Token(Token = "0x40007DF")]
			RIPEMD160,
			// Token: 0x040007E0 RID: 2016
			[Token(Token = "0x40007E0")]
			RIPEMD256,
			// Token: 0x040007E1 RID: 2017
			[Token(Token = "0x40007E1")]
			RIPEMD320,
			// Token: 0x040007E2 RID: 2018
			[Token(Token = "0x40007E2")]
			SHA_1,
			// Token: 0x040007E3 RID: 2019
			[Token(Token = "0x40007E3")]
			SHA_224,
			// Token: 0x040007E4 RID: 2020
			[Token(Token = "0x40007E4")]
			SHA_256,
			// Token: 0x040007E5 RID: 2021
			[Token(Token = "0x40007E5")]
			SHA_384,
			// Token: 0x040007E6 RID: 2022
			[Token(Token = "0x40007E6")]
			SHA_512,
			// Token: 0x040007E7 RID: 2023
			[Token(Token = "0x40007E7")]
			SHA_512_224,
			// Token: 0x040007E8 RID: 2024
			[Token(Token = "0x40007E8")]
			SHA_512_256,
			// Token: 0x040007E9 RID: 2025
			[Token(Token = "0x40007E9")]
			SHA3_224,
			// Token: 0x040007EA RID: 2026
			[Token(Token = "0x40007EA")]
			SHA3_256,
			// Token: 0x040007EB RID: 2027
			[Token(Token = "0x40007EB")]
			SHA3_384,
			// Token: 0x040007EC RID: 2028
			[Token(Token = "0x40007EC")]
			SHA3_512,
			// Token: 0x040007ED RID: 2029
			[Token(Token = "0x40007ED")]
			SHAKE128,
			// Token: 0x040007EE RID: 2030
			[Token(Token = "0x40007EE")]
			SHAKE256,
			// Token: 0x040007EF RID: 2031
			[Token(Token = "0x40007EF")]
			TIGER,
			// Token: 0x040007F0 RID: 2032
			[Token(Token = "0x40007F0")]
			WHIRLPOOL
		}
	}
}
