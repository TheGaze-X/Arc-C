using System;
using System.Text;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	public class DistributionPointName : Asn1Encodable, IAsn1Choice
	{
		// Token: 0x06002214 RID: 8724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002214")]
		[Address(RVA = "0x533A890", Offset = "0x5339490", VA = "0x18533A890")]
		public static DistributionPointName GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002215")]
		[Address(RVA = "0x533A8B0", Offset = "0x53394B0", VA = "0x18533A8B0")]
		public static DistributionPointName GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002216")]
		[Address(RVA = "0x533AE30", Offset = "0x5339A30", VA = "0x18533AE30")]
		public DistributionPointName(int type, Asn1Encodable name)
		{
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002217")]
		[Address(RVA = "0x533AD80", Offset = "0x5339980", VA = "0x18533AD80")]
		public DistributionPointName(GeneralNames name)
		{
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[Token(Token = "0x17000469")]
		public int PointType
		{
			[Token(Token = "0x6002218")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06002219 RID: 8729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046A")]
		public Asn1Encodable Name
		{
			[Token(Token = "0x6002219")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600221A")]
		[Address(RVA = "0x533ADC0", Offset = "0x53399C0", VA = "0x18533ADC0")]
		public DistributionPointName(Asn1TaggedObject obj)
		{
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221B")]
		[Address(RVA = "0x533AB20", Offset = "0x5339720", VA = "0x18533AB20", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221C")]
		[Address(RVA = "0x533ABA0", Offset = "0x53397A0", VA = "0x18533ABA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600221D")]
		[Address(RVA = "0x533AE70", Offset = "0x5339A70", VA = "0x18533AE70")]
		private void appendObject(StringBuilder buf, string sep, string name, string val)
		{
		}

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x10")]
		internal readonly Asn1Encodable name;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x18")]
		internal readonly int type;

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		public const int FullName = 0;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		public const int NameRelativeToCrlIssuer = 1;
	}
}
