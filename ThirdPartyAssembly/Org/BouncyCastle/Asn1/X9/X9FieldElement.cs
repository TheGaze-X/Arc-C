using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003FE RID: 1022
	[Token(Token = "0x20003FE")]
	public class X9FieldElement : Asn1Encodable
	{
		// Token: 0x060021C1 RID: 8641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public X9FieldElement(ECFieldElement f)
		{
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x5354DD0", Offset = "0x53539D0", VA = "0x185354DD0")]
		public X9FieldElement(BigInteger p, Asn1OctetString s)
		{
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x5354CA0", Offset = "0x53538A0", VA = "0x185354CA0")]
		public X9FieldElement(int m, int k1, int k2, int k3, Asn1OctetString s)
		{
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000456")]
		public ECFieldElement Value
		{
			[Token(Token = "0x60021C4")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x5354B10", Offset = "0x5353710", VA = "0x185354B10", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400118A RID: 4490
		[Token(Token = "0x400118A")]
		[FieldOffset(Offset = "0x10")]
		private ECFieldElement f;
	}
}
