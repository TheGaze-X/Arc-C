using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200040B RID: 1035
	[Token(Token = "0x200040B")]
	public class DsaParameter : Asn1Encodable
	{
		// Token: 0x0600221E RID: 8734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221E")]
		[Address(RVA = "0x533BBE0", Offset = "0x533A7E0", VA = "0x18533BBE0")]
		public static DsaParameter GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221F")]
		[Address(RVA = "0x533B9B0", Offset = "0x533A5B0", VA = "0x18533B9B0")]
		public static DsaParameter GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002220")]
		[Address(RVA = "0x533BDB0", Offset = "0x533A9B0", VA = "0x18533BDB0")]
		public DsaParameter(BigInteger p, BigInteger q, BigInteger g)
		{
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002221")]
		[Address(RVA = "0x533C000", Offset = "0x533AC00", VA = "0x18533C000")]
		private DsaParameter(Asn1Sequence seq)
		{
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046B")]
		public BigInteger P
		{
			[Token(Token = "0x6002222")]
			[Address(RVA = "0x533C240", Offset = "0x533AE40", VA = "0x18533C240")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046C")]
		public BigInteger Q
		{
			[Token(Token = "0x6002223")]
			[Address(RVA = "0x533C2B0", Offset = "0x533AEB0", VA = "0x18533C2B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046D")]
		public BigInteger G
		{
			[Token(Token = "0x6002224")]
			[Address(RVA = "0x533C1D0", Offset = "0x533ADD0", VA = "0x18533C1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002225 RID: 8741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002225")]
		[Address(RVA = "0x533BC00", Offset = "0x533A800", VA = "0x18533BC00", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x10")]
		internal readonly DerInteger p;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x18")]
		internal readonly DerInteger q;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x20")]
		internal readonly DerInteger g;
	}
}
