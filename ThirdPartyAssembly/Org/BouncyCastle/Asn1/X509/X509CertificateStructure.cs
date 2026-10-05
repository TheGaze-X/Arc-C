using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000419 RID: 1049
	[Token(Token = "0x2000419")]
	public class X509CertificateStructure : Asn1Encodable
	{
		// Token: 0x06002291 RID: 8849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002291")]
		[Address(RVA = "0x53456C0", Offset = "0x53442C0", VA = "0x1853456C0")]
		public static X509CertificateStructure GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002292")]
		[Address(RVA = "0x5345810", Offset = "0x5344410", VA = "0x185345810")]
		public static X509CertificateStructure GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002293")]
		[Address(RVA = "0x5345CD0", Offset = "0x53448D0", VA = "0x185345CD0")]
		public X509CertificateStructure(TbsCertificateStructure tbsCert, AlgorithmIdentifier sigAlgID, DerBitString sig)
		{
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002294")]
		[Address(RVA = "0x5345B00", Offset = "0x5344700", VA = "0x185345B00")]
		private X509CertificateStructure(Asn1Sequence seq)
		{
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000491")]
		public TbsCertificateStructure TbsCertificate
		{
			[Token(Token = "0x6002295")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		[Token(Token = "0x17000492")]
		public int Version
		{
			[Token(Token = "0x6002296")]
			[Address(RVA = "0x532E940", Offset = "0x532D540", VA = "0x18532E940")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000493")]
		public DerInteger SerialNumber
		{
			[Token(Token = "0x6002297")]
			[Address(RVA = "0x111CB60", Offset = "0x111B760", VA = "0x18111CB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000494")]
		public X509Name Issuer
		{
			[Token(Token = "0x6002298")]
			[Address(RVA = "0x532E920", Offset = "0x532D520", VA = "0x18532E920")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000495")]
		public Time StartDate
		{
			[Token(Token = "0x6002299")]
			[Address(RVA = "0x4BDD0B0", Offset = "0x4BDBCB0", VA = "0x184BDD0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000496")]
		public Time EndDate
		{
			[Token(Token = "0x600229A")]
			[Address(RVA = "0x1CA1D80", Offset = "0x1CA0980", VA = "0x181CA1D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000497")]
		public X509Name Subject
		{
			[Token(Token = "0x600229B")]
			[Address(RVA = "0xFEE8C0", Offset = "0xFED4C0", VA = "0x180FEE8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000498")]
		public SubjectPublicKeyInfo SubjectPublicKeyInfo
		{
			[Token(Token = "0x600229C")]
			[Address(RVA = "0x5345E50", Offset = "0x5344A50", VA = "0x185345E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000499")]
		public AlgorithmIdentifier SignatureAlgorithm
		{
			[Token(Token = "0x600229D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049A")]
		public DerBitString Signature
		{
			[Token(Token = "0x600229E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600229F")]
		[Address(RVA = "0x532E550", Offset = "0x532D150", VA = "0x18532E550")]
		public byte[] GetSignatureOctets()
		{
			return null;
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A0")]
		[Address(RVA = "0x5345950", Offset = "0x5344550", VA = "0x185345950", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001232 RID: 4658
		[Token(Token = "0x4001232")]
		[FieldOffset(Offset = "0x10")]
		private readonly TbsCertificateStructure tbsCert;

		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4001233")]
		[FieldOffset(Offset = "0x18")]
		private readonly AlgorithmIdentifier sigAlgID;

		// Token: 0x04001234 RID: 4660
		[Token(Token = "0x4001234")]
		[FieldOffset(Offset = "0x20")]
		private readonly DerBitString sig;
	}
}
