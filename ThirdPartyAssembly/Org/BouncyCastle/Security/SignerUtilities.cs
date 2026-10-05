using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Security
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	public sealed class SignerUtilities
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private SignerUtilities()
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x54836A0", Offset = "0x54822A0", VA = "0x1854836A0")]
		public static DerObjectIdentifier GetObjectIdentifier(string mechanism)
		{
			return null;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DD")]
		public static ICollection Algorithms
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x5488910", Offset = "0x5487510", VA = "0x185488910")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x5483580", Offset = "0x5482180", VA = "0x185483580")]
		public static Asn1Encodable GetDefaultX509Parameters(DerObjectIdentifier id)
		{
			return null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x5483320", Offset = "0x5481F20", VA = "0x185483320")]
		public static Asn1Encodable GetDefaultX509Parameters(string algorithm)
		{
			return null;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x54838B0", Offset = "0x54824B0", VA = "0x1854838B0")]
		private static Asn1Encodable GetPssX509Parameters(string digestName)
		{
			return null;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x5484F10", Offset = "0x5483B10", VA = "0x185484F10")]
		public static ISigner GetSigner(DerObjectIdentifier id)
		{
			return null;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x5483AC0", Offset = "0x54826C0", VA = "0x185483AC0")]
		public static ISigner GetSigner(string algorithm)
		{
			return null;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x54835E0", Offset = "0x54821E0", VA = "0x1854835E0")]
		public static string GetEncodingName(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly IDictionary algorithms;

		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly IDictionary oids;
	}
}
