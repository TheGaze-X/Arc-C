using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2000404")]
	public class CertificateList : Asn1Encodable
	{
		// Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x532E060", Offset = "0x532CC60", VA = "0x18532E060")]
		public static CertificateList GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E8")]
		[Address(RVA = "0x532E1B0", Offset = "0x532CDB0", VA = "0x18532E1B0")]
		public static CertificateList GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021E9")]
		[Address(RVA = "0x532E750", Offset = "0x532D350", VA = "0x18532E750")]
		private CertificateList(Asn1Sequence seq)
		{
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		public TbsCertificateList TbsCertList
		{
			[Token(Token = "0x60021EA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EB")]
		[Address(RVA = "0x532E3B0", Offset = "0x532CFB0", VA = "0x18532E3B0")]
		public CrlEntry[] GetRevokedCertificates()
		{
			return null;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EC")]
		[Address(RVA = "0x532E2F0", Offset = "0x532CEF0", VA = "0x18532E2F0")]
		public IEnumerable GetRevokedCertificateEnumeration()
		{
			return null;
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060021ED RID: 8685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045E")]
		public AlgorithmIdentifier SignatureAlgorithm
		{
			[Token(Token = "0x60021ED")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060021EE RID: 8686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045F")]
		public DerBitString Signature
		{
			[Token(Token = "0x60021EE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EF")]
		[Address(RVA = "0x532E550", Offset = "0x532D150", VA = "0x18532E550")]
		public byte[] GetSignatureOctets()
		{
			return null;
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		[Token(Token = "0x17000460")]
		public int Version
		{
			[Token(Token = "0x60021F0")]
			[Address(RVA = "0x532E940", Offset = "0x532D540", VA = "0x18532E940")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000461")]
		public X509Name Issuer
		{
			[Token(Token = "0x60021F1")]
			[Address(RVA = "0x1CA1D60", Offset = "0x1CA0960", VA = "0x181CA1D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000462")]
		public Time ThisUpdate
		{
			[Token(Token = "0x60021F2")]
			[Address(RVA = "0x532E920", Offset = "0x532D520", VA = "0x18532E920")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060021F3 RID: 8691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000463")]
		public Time NextUpdate
		{
			[Token(Token = "0x60021F3")]
			[Address(RVA = "0x4BDD0B0", Offset = "0x4BDBCB0", VA = "0x184BDD0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021F4")]
		[Address(RVA = "0x532E5A0", Offset = "0x532D1A0", VA = "0x18532E5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040011D3 RID: 4563
		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x10")]
		private readonly TbsCertificateList tbsCertList;

		// Token: 0x040011D4 RID: 4564
		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0x18")]
		private readonly AlgorithmIdentifier sigAlgID;

		// Token: 0x040011D5 RID: 4565
		[Token(Token = "0x40011D5")]
		[FieldOffset(Offset = "0x20")]
		private readonly DerBitString sig;
	}
}
