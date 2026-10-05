using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003FA RID: 1018
	[Token(Token = "0x20003FA")]
	public class X9Curve : Asn1Encodable
	{
		// Token: 0x060021A0 RID: 8608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x5352610", Offset = "0x5351210", VA = "0x185352610")]
		public X9Curve(ECCurve curve)
		{
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x5352620", Offset = "0x5351220", VA = "0x185352620")]
		public X9Curve(ECCurve curve, byte[] seed)
		{
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x53527D0", Offset = "0x53513D0", VA = "0x1853527D0")]
		public X9Curve(X9FieldID fieldID, Asn1Sequence seq)
		{
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044B")]
		public ECCurve Curve
		{
			[Token(Token = "0x60021A3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A4")]
		[Address(RVA = "0x524CEB0", Offset = "0x524BAB0", VA = "0x18524CEB0")]
		public byte[] GetSeed()
		{
			return null;
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x5352190", Offset = "0x5350D90", VA = "0x185352190", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400117D RID: 4477
		[Token(Token = "0x400117D")]
		[FieldOffset(Offset = "0x10")]
		private readonly ECCurve curve;

		// Token: 0x0400117E RID: 4478
		[Token(Token = "0x400117E")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] seed;

		// Token: 0x0400117F RID: 4479
		[Token(Token = "0x400117F")]
		[FieldOffset(Offset = "0x20")]
		private readonly DerObjectIdentifier fieldIdentifier;
	}
}
