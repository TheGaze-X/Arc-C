using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Oiw
{
	// Token: 0x0200045B RID: 1115
	[Token(Token = "0x200045B")]
	public class ElGamalParameter : Asn1Encodable
	{
		// Token: 0x060023C8 RID: 9160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x5362D10", Offset = "0x5361910", VA = "0x185362D10")]
		public ElGamalParameter(BigInteger p, BigInteger g)
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x5362BC0", Offset = "0x53617C0", VA = "0x185362BC0")]
		public ElGamalParameter(Asn1Sequence seq)
		{
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B5")]
		public BigInteger P
		{
			[Token(Token = "0x60023CA")]
			[Address(RVA = "0x53615E0", Offset = "0x53601E0", VA = "0x1853615E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x060023CB RID: 9163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B6")]
		public BigInteger G
		{
			[Token(Token = "0x60023CB")]
			[Address(RVA = "0x53615A0", Offset = "0x53601A0", VA = "0x1853615A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x5362A90", Offset = "0x5361690", VA = "0x185362A90", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040013E3 RID: 5091
		[Token(Token = "0x40013E3")]
		[FieldOffset(Offset = "0x10")]
		internal DerInteger p;

		// Token: 0x040013E4 RID: 5092
		[Token(Token = "0x40013E4")]
		[FieldOffset(Offset = "0x18")]
		internal DerInteger g;
	}
}
