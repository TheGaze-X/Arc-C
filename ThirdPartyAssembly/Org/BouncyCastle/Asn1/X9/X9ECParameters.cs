using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003FB RID: 1019
	[Token(Token = "0x20003FB")]
	public class X9ECParameters : Asn1Encodable
	{
		// Token: 0x060021A6 RID: 8614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x53530B0", Offset = "0x5351CB0", VA = "0x1853530B0")]
		public static X9ECParameters GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x5353E10", Offset = "0x5352A10", VA = "0x185353E10")]
		public X9ECParameters(Asn1Sequence seq)
		{
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x53544D0", Offset = "0x53530D0", VA = "0x1853544D0")]
		public X9ECParameters(ECCurve curve, ECPoint g, BigInteger n)
		{
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A9")]
		[Address(RVA = "0x5353DE0", Offset = "0x53529E0", VA = "0x185353DE0")]
		public X9ECParameters(ECCurve curve, X9ECPoint g, BigInteger n, BigInteger h)
		{
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x53536E0", Offset = "0x53522E0", VA = "0x1853536E0")]
		public X9ECParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h)
		{
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x5353710", Offset = "0x5352310", VA = "0x185353710")]
		public X9ECParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h, byte[] seed)
		{
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x5353870", Offset = "0x5352470", VA = "0x185353870")]
		public X9ECParameters(ECCurve curve, X9ECPoint g, BigInteger n, BigInteger h, byte[] seed)
		{
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044C")]
		public ECCurve Curve
		{
			[Token(Token = "0x60021AD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044D")]
		public ECPoint G
		{
			[Token(Token = "0x60021AE")]
			[Address(RVA = "0x5354570", Offset = "0x5353170", VA = "0x185354570")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044E")]
		public BigInteger N
		{
			[Token(Token = "0x60021AF")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044F")]
		public BigInteger H
		{
			[Token(Token = "0x60021B0")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B1")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
		public byte[] GetSeed()
		{
			return null;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000450")]
		public X9Curve CurveEntry
		{
			[Token(Token = "0x60021B2")]
			[Address(RVA = "0x53544F0", Offset = "0x53530F0", VA = "0x1853544F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000451")]
		public X9FieldID FieldIDEntry
		{
			[Token(Token = "0x60021B3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000452")]
		public X9ECPoint BaseEntry
		{
			[Token(Token = "0x60021B4")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021B5")]
		[Address(RVA = "0x53531F0", Offset = "0x5351DF0", VA = "0x1853531F0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001180 RID: 4480
		[Token(Token = "0x4001180")]
		[FieldOffset(Offset = "0x10")]
		private X9FieldID fieldID;

		// Token: 0x04001181 RID: 4481
		[Token(Token = "0x4001181")]
		[FieldOffset(Offset = "0x18")]
		private ECCurve curve;

		// Token: 0x04001182 RID: 4482
		[Token(Token = "0x4001182")]
		[FieldOffset(Offset = "0x20")]
		private X9ECPoint g;

		// Token: 0x04001183 RID: 4483
		[Token(Token = "0x4001183")]
		[FieldOffset(Offset = "0x28")]
		private BigInteger n;

		// Token: 0x04001184 RID: 4484
		[Token(Token = "0x4001184")]
		[FieldOffset(Offset = "0x30")]
		private BigInteger h;

		// Token: 0x04001185 RID: 4485
		[Token(Token = "0x4001185")]
		[FieldOffset(Offset = "0x38")]
		private byte[] seed;
	}
}
