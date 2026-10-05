using System;
using System.Text;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200040E RID: 1038
	[Token(Token = "0x200040E")]
	public class IssuingDistributionPoint : Asn1Encodable
	{
		// Token: 0x0600223E RID: 8766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x533F090", Offset = "0x533DC90", VA = "0x18533F090")]
		public static IssuingDistributionPoint GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x533EE50", Offset = "0x533DA50", VA = "0x18533EE50")]
		public static IssuingDistributionPoint GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x533F720", Offset = "0x533E320", VA = "0x18533F720")]
		public IssuingDistributionPoint(DistributionPointName distributionPoint, bool onlyContainsUserCerts, bool onlyContainsCACerts, ReasonFlags onlySomeReasons, bool indirectCRL, bool onlyContainsAttributeCerts)
		{
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002241")]
		[Address(RVA = "0x533F400", Offset = "0x533E000", VA = "0x18533F400")]
		private IssuingDistributionPoint(Asn1Sequence seq)
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0000F810 File Offset: 0x0000DA10
		[Token(Token = "0x17000470")]
		public bool OnlyContainsUserCerts
		{
			[Token(Token = "0x6002242")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x0000F828 File Offset: 0x0000DA28
		[Token(Token = "0x17000471")]
		public bool OnlyContainsCACerts
		{
			[Token(Token = "0x6002243")]
			[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x17000472")]
		public bool IsIndirectCrl
		{
			[Token(Token = "0x6002244")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x17000473")]
		public bool OnlyContainsAttributeCerts
		{
			[Token(Token = "0x6002245")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000474")]
		public DistributionPointName DistributionPoint
		{
			[Token(Token = "0x6002246")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000475")]
		public ReasonFlags OnlySomeReasons
		{
			[Token(Token = "0x6002247")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002248")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002249")]
		[Address(RVA = "0x533F0B0", Offset = "0x533DCB0", VA = "0x18533F0B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600224A")]
		[Address(RVA = "0x533FD10", Offset = "0x533E910", VA = "0x18533FD10")]
		private void appendObject(StringBuilder buf, string sep, string name, string val)
		{
		}

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0x10")]
		private readonly DistributionPointName _distributionPoint;

		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		[FieldOffset(Offset = "0x18")]
		private readonly bool _onlyContainsUserCerts;

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		[FieldOffset(Offset = "0x19")]
		private readonly bool _onlyContainsCACerts;

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		[FieldOffset(Offset = "0x20")]
		private readonly ReasonFlags _onlySomeReasons;

		// Token: 0x040011FE RID: 4606
		[Token(Token = "0x40011FE")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool _indirectCRL;

		// Token: 0x040011FF RID: 4607
		[Token(Token = "0x40011FF")]
		[FieldOffset(Offset = "0x29")]
		private readonly bool _onlyContainsAttributeCerts;

		// Token: 0x04001200 RID: 4608
		[Token(Token = "0x4001200")]
		[FieldOffset(Offset = "0x30")]
		private readonly Asn1Sequence seq;
	}
}
