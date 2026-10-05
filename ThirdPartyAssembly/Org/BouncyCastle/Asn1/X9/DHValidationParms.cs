using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003DF RID: 991
	[Token(Token = "0x20003DF")]
	public class DHValidationParms : Asn1Encodable
	{
		// Token: 0x0600213E RID: 8510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213E")]
		[Address(RVA = "0x5330BF0", Offset = "0x532F7F0", VA = "0x185330BF0")]
		public static DHValidationParms GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600213F")]
		[Address(RVA = "0x53309A0", Offset = "0x532F5A0", VA = "0x1853309A0")]
		public static DHValidationParms GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002140")]
		[Address(RVA = "0x5330D70", Offset = "0x532F970", VA = "0x185330D70")]
		public DHValidationParms(DerBitString seed, DerInteger pgenCounter)
		{
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002141")]
		[Address(RVA = "0x5330E70", Offset = "0x532FA70", VA = "0x185330E70")]
		private DHValidationParms(Asn1Sequence seq)
		{
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000444")]
		public DerBitString Seed
		{
			[Token(Token = "0x6002142")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000445")]
		public DerInteger PgenCounter
		{
			[Token(Token = "0x6002143")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002144")]
		[Address(RVA = "0x5330C10", Offset = "0x532F810", VA = "0x185330C10", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001160 RID: 4448
		[Token(Token = "0x4001160")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerBitString seed;

		// Token: 0x04001161 RID: 4449
		[Token(Token = "0x4001161")]
		[FieldOffset(Offset = "0x18")]
		private readonly DerInteger pgenCounter;
	}
}
