using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000411 RID: 1041
	[Token(Token = "0x2000411")]
	public class RsaPublicKeyStructure : Asn1Encodable
	{
		// Token: 0x06002251 RID: 8785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002251")]
		[Address(RVA = "0x5342630", Offset = "0x5341230", VA = "0x185342630")]
		public static RsaPublicKeyStructure GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002252")]
		[Address(RVA = "0x5342650", Offset = "0x5341250", VA = "0x185342650")]
		public static RsaPublicKeyStructure GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002253")]
		[Address(RVA = "0x5342D40", Offset = "0x5341940", VA = "0x185342D40")]
		public RsaPublicKeyStructure(BigInteger modulus, BigInteger publicExponent)
		{
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002254")]
		[Address(RVA = "0x5342B10", Offset = "0x5341710", VA = "0x185342B10")]
		private RsaPublicKeyStructure(Asn1Sequence seq)
		{
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000476")]
		public BigInteger Modulus
		{
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000477")]
		public BigInteger PublicExponent
		{
			[Token(Token = "0x6002256")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002257")]
		[Address(RVA = "0x5342880", Offset = "0x5341480", VA = "0x185342880", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001213 RID: 4627
		[Token(Token = "0x4001213")]
		[FieldOffset(Offset = "0x10")]
		private BigInteger modulus;

		// Token: 0x04001214 RID: 4628
		[Token(Token = "0x4001214")]
		[FieldOffset(Offset = "0x18")]
		private BigInteger publicExponent;
	}
}
