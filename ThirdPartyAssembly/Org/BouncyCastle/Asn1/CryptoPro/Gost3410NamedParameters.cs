using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x0200046A RID: 1130
	[Token(Token = "0x200046A")]
	public sealed class Gost3410NamedParameters
	{
		// Token: 0x06002404 RID: 9220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Gost3410NamedParameters()
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x5363310", Offset = "0x5361F10", VA = "0x185363310")]
		public static Gost3410ParamSetParameters GetByOid(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004BE")]
		public static IEnumerable Names
		{
			[Token(Token = "0x6002407")]
			[Address(RVA = "0x5363B50", Offset = "0x5362750", VA = "0x185363B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x5363140", Offset = "0x5361D40", VA = "0x185363140")]
		public static Gost3410ParamSetParameters GetByName(string name)
		{
			return null;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x5363420", Offset = "0x5362020", VA = "0x185363420")]
		public static DerObjectIdentifier GetOid(string name)
		{
			return null;
		}

		// Token: 0x0400146F RID: 5231
		[Token(Token = "0x400146F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary objIds;

		// Token: 0x04001470 RID: 5232
		[Token(Token = "0x4001470")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary parameters;

		// Token: 0x04001471 RID: 5233
		[Token(Token = "0x4001471")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Gost3410ParamSetParameters cryptoProA;

		// Token: 0x04001472 RID: 5234
		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Gost3410ParamSetParameters cryptoProB;

		// Token: 0x04001473 RID: 5235
		[Token(Token = "0x4001473")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Gost3410ParamSetParameters cryptoProXchA;
	}
}
