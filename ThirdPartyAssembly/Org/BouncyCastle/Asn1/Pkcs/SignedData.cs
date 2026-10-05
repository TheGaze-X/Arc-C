using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	public class SignedData : Asn1Encodable
	{
		// Token: 0x060023BE RID: 9150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x537D2C0", Offset = "0x537BEC0", VA = "0x18537D2C0")]
		public static SignedData GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x537DE20", Offset = "0x537CA20", VA = "0x18537DE20")]
		public SignedData(DerInteger _version, Asn1Set _digestAlgorithms, ContentInfo _contentInfo, Asn1Set _certificates, Asn1Set _crls, Asn1Set _signerInfos)
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x537D740", Offset = "0x537C340", VA = "0x18537D740")]
		private SignedData(Asn1Sequence seq)
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x060023C1 RID: 9153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AF")]
		public DerInteger Version
		{
			[Token(Token = "0x60023C1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B0")]
		public Asn1Set DigestAlgorithms
		{
			[Token(Token = "0x60023C2")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B1")]
		public ContentInfo ContentInfo
		{
			[Token(Token = "0x60023C3")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B2")]
		public Asn1Set Certificates
		{
			[Token(Token = "0x60023C4")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B3")]
		public Asn1Set Crls
		{
			[Token(Token = "0x60023C5")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B4")]
		public Asn1Set SignerInfos
		{
			[Token(Token = "0x60023C6")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x537D3A0", Offset = "0x537BFA0", VA = "0x18537D3A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040013DD RID: 5085
		[Token(Token = "0x40013DD")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerInteger version;

		// Token: 0x040013DE RID: 5086
		[Token(Token = "0x40013DE")]
		[FieldOffset(Offset = "0x18")]
		private readonly Asn1Set digestAlgorithms;

		// Token: 0x040013DF RID: 5087
		[Token(Token = "0x40013DF")]
		[FieldOffset(Offset = "0x20")]
		private readonly ContentInfo contentInfo;

		// Token: 0x040013E0 RID: 5088
		[Token(Token = "0x40013E0")]
		[FieldOffset(Offset = "0x28")]
		private readonly Asn1Set certificates;

		// Token: 0x040013E1 RID: 5089
		[Token(Token = "0x40013E1")]
		[FieldOffset(Offset = "0x30")]
		private readonly Asn1Set crls;

		// Token: 0x040013E2 RID: 5090
		[Token(Token = "0x40013E2")]
		[FieldOffset(Offset = "0x38")]
		private readonly Asn1Set signerInfos;
	}
}
