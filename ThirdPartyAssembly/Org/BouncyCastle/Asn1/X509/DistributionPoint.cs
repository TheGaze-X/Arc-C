using System;
using System.Text;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000409 RID: 1033
	[Token(Token = "0x2000409")]
	public class DistributionPoint : Asn1Encodable
	{
		// Token: 0x0600220A RID: 8714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600220A")]
		[Address(RVA = "0x533AF60", Offset = "0x5339B60", VA = "0x18533AF60")]
		public static DistributionPoint GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600220B")]
		[Address(RVA = "0x533AF80", Offset = "0x5339B80", VA = "0x18533AF80")]
		public static DistributionPoint GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600220C")]
		[Address(RVA = "0x533B6F0", Offset = "0x533A2F0", VA = "0x18533B6F0")]
		private DistributionPoint(Asn1Sequence seq)
		{
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600220D")]
		[Address(RVA = "0x43CB130", Offset = "0x43C9D30", VA = "0x1843CB130")]
		public DistributionPoint(DistributionPointName distributionPointName, ReasonFlags reasons, GeneralNames crlIssuer)
		{
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000466")]
		public DistributionPointName DistributionPointName
		{
			[Token(Token = "0x600220E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000467")]
		public ReasonFlags Reasons
		{
			[Token(Token = "0x600220F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000468")]
		public GeneralNames CrlIssuer
		{
			[Token(Token = "0x6002210")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002211")]
		[Address(RVA = "0x533B1B0", Offset = "0x5339DB0", VA = "0x18533B1B0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002212")]
		[Address(RVA = "0x533B4A0", Offset = "0x533A0A0", VA = "0x18533B4A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002213")]
		[Address(RVA = "0x533B8C0", Offset = "0x533A4C0", VA = "0x18533B8C0")]
		private void appendObject(StringBuilder buf, string sep, string name, string val)
		{
		}

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x10")]
		internal readonly DistributionPointName distributionPoint;

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x18")]
		internal readonly ReasonFlags reasons;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x20")]
		internal readonly GeneralNames cRLIssuer;
	}
}
