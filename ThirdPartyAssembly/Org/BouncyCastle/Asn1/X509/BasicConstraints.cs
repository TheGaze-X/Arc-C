using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	public class BasicConstraints : Asn1Encodable
	{
		// Token: 0x060021DE RID: 8670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DE")]
		[Address(RVA = "0x532A940", Offset = "0x5329540", VA = "0x18532A940")]
		public static BasicConstraints GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021DF")]
		[Address(RVA = "0x532A960", Offset = "0x5329560", VA = "0x18532A960")]
		public static BasicConstraints GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E0")]
		[Address(RVA = "0x532B0D0", Offset = "0x5329CD0", VA = "0x18532B0D0")]
		private BasicConstraints(Asn1Sequence seq)
		{
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E1")]
		[Address(RVA = "0x532B050", Offset = "0x5329C50", VA = "0x18532B050")]
		public BasicConstraints(bool cA)
		{
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E2")]
		[Address(RVA = "0x532AF80", Offset = "0x5329B80", VA = "0x18532AF80")]
		public BasicConstraints(int pathLenConstraint)
		{
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		[Token(Token = "0x60021E3")]
		[Address(RVA = "0x532ABF0", Offset = "0x53297F0", VA = "0x18532ABF0")]
		public bool IsCA()
		{
			return default(bool);
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045C")]
		public BigInteger PathLenConstraint
		{
			[Token(Token = "0x60021E4")]
			[Address(RVA = "0x532B340", Offset = "0x5329F40", VA = "0x18532B340")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E5")]
		[Address(RVA = "0x532AC10", Offset = "0x5329810", VA = "0x18532AC10", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E6")]
		[Address(RVA = "0x532ADD0", Offset = "0x53299D0", VA = "0x18532ADD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040011D1 RID: 4561
		[Token(Token = "0x40011D1")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerBoolean cA;

		// Token: 0x040011D2 RID: 4562
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x18")]
		private readonly DerInteger pathLenConstraint;
	}
}
