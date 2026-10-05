using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000413 RID: 1043
	[Token(Token = "0x2000413")]
	public class TbsCertificateStructure : Asn1Encodable
	{
		// Token: 0x06002261 RID: 8801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002261")]
		[Address(RVA = "0x5344070", Offset = "0x5342C70", VA = "0x185344070")]
		public static TbsCertificateStructure GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002262")]
		[Address(RVA = "0x5343F30", Offset = "0x5342B30", VA = "0x185343F30")]
		public static TbsCertificateStructure GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002263")]
		[Address(RVA = "0x5344090", Offset = "0x5342C90", VA = "0x185344090")]
		internal TbsCertificateStructure(Asn1Sequence seq)
		{
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x1700047A")]
		public int Version
		{
			[Token(Token = "0x6002264")]
			[Address(RVA = "0x5343EB0", Offset = "0x5342AB0", VA = "0x185343EB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047B")]
		public DerInteger VersionNumber
		{
			[Token(Token = "0x6002265")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047C")]
		public DerInteger SerialNumber
		{
			[Token(Token = "0x6002266")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047D")]
		public AlgorithmIdentifier Signature
		{
			[Token(Token = "0x6002267")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047E")]
		public X509Name Issuer
		{
			[Token(Token = "0x6002268")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06002269 RID: 8809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700047F")]
		public Time StartDate
		{
			[Token(Token = "0x6002269")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000480")]
		public Time EndDate
		{
			[Token(Token = "0x600226A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000481")]
		public X509Name Subject
		{
			[Token(Token = "0x600226B")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000482")]
		public SubjectPublicKeyInfo SubjectPublicKeyInfo
		{
			[Token(Token = "0x600226C")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000483")]
		public DerBitString IssuerUniqueID
		{
			[Token(Token = "0x600226D")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000484")]
		public DerBitString SubjectUniqueID
		{
			[Token(Token = "0x600226E")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000485")]
		public X509Extensions Extensions
		{
			[Token(Token = "0x600226F")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002270 RID: 8816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002270")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001217 RID: 4631
		[Token(Token = "0x4001217")]
		[FieldOffset(Offset = "0x10")]
		internal Asn1Sequence seq;

		// Token: 0x04001218 RID: 4632
		[Token(Token = "0x4001218")]
		[FieldOffset(Offset = "0x18")]
		internal DerInteger version;

		// Token: 0x04001219 RID: 4633
		[Token(Token = "0x4001219")]
		[FieldOffset(Offset = "0x20")]
		internal DerInteger serialNumber;

		// Token: 0x0400121A RID: 4634
		[Token(Token = "0x400121A")]
		[FieldOffset(Offset = "0x28")]
		internal AlgorithmIdentifier signature;

		// Token: 0x0400121B RID: 4635
		[Token(Token = "0x400121B")]
		[FieldOffset(Offset = "0x30")]
		internal X509Name issuer;

		// Token: 0x0400121C RID: 4636
		[Token(Token = "0x400121C")]
		[FieldOffset(Offset = "0x38")]
		internal Time startDate;

		// Token: 0x0400121D RID: 4637
		[Token(Token = "0x400121D")]
		[FieldOffset(Offset = "0x40")]
		internal Time endDate;

		// Token: 0x0400121E RID: 4638
		[Token(Token = "0x400121E")]
		[FieldOffset(Offset = "0x48")]
		internal X509Name subject;

		// Token: 0x0400121F RID: 4639
		[Token(Token = "0x400121F")]
		[FieldOffset(Offset = "0x50")]
		internal SubjectPublicKeyInfo subjectPublicKeyInfo;

		// Token: 0x04001220 RID: 4640
		[Token(Token = "0x4001220")]
		[FieldOffset(Offset = "0x58")]
		internal DerBitString issuerUniqueID;

		// Token: 0x04001221 RID: 4641
		[Token(Token = "0x4001221")]
		[FieldOffset(Offset = "0x60")]
		internal DerBitString subjectUniqueID;

		// Token: 0x04001222 RID: 4642
		[Token(Token = "0x4001222")]
		[FieldOffset(Offset = "0x68")]
		internal X509Extensions extensions;
	}
}
