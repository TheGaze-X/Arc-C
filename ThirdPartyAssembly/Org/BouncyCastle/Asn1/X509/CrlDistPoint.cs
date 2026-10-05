using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	public class CrlDistPoint : Asn1Encodable
	{
		// Token: 0x060021F5 RID: 8693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F5")]
		[Address(RVA = "0x532EDA0", Offset = "0x532D9A0", VA = "0x18532EDA0")]
		public static CrlDistPoint GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F6")]
		[Address(RVA = "0x532EB50", Offset = "0x532D750", VA = "0x18532EB50")]
		public static CrlDistPoint GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F7")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		private CrlDistPoint(Asn1Sequence seq)
		{
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021F8")]
		[Address(RVA = "0x532F0A0", Offset = "0x532DCA0", VA = "0x18532F0A0")]
		public CrlDistPoint(DistributionPoint[] points)
		{
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F9")]
		[Address(RVA = "0x532E9C0", Offset = "0x532D5C0", VA = "0x18532E9C0")]
		public DistributionPoint[] GetDistributionPoints()
		{
			return null;
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FA")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FB")]
		[Address(RVA = "0x532EDC0", Offset = "0x532D9C0", VA = "0x18532EDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040011D6 RID: 4566
		[Token(Token = "0x40011D6")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Asn1Sequence seq;
	}
}
