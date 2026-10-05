using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	[Serializable]
	public class X509Certificate2 : X509Certificate
	{
		// Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x512BCD0", Offset = "0x512A8D0", VA = "0x18512BCD0", Slot = "7")]
		public override void Reset()
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x512CDA0", Offset = "0x512B9A0", VA = "0x18512CDA0")]
		public X509Certificate2()
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x512CC60", Offset = "0x512B860", VA = "0x18512CC60")]
		public X509Certificate2(byte[] rawData)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x512CC40", Offset = "0x512B840", VA = "0x18512CC40")]
		public X509Certificate2(byte[] rawData, string password)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x512CD90", Offset = "0x512B990", VA = "0x18512CD90")]
		internal X509Certificate2(X509Certificate2Impl impl)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x512CD80", Offset = "0x512B980", VA = "0x18512CD80")]
		public X509Certificate2(string fileName)
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x512CC50", Offset = "0x512B850", VA = "0x18512CC50")]
		public X509Certificate2(X509Certificate certificate)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x512CDB0", Offset = "0x512B9B0", VA = "0x18512CDB0")]
		protected X509Certificate2(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014F")]
		public X509ExtensionCollection Extensions
		{
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x512CE10", Offset = "0x512BA10", VA = "0x18512CE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x17000150")]
		public bool HasPrivateKey
		{
			[Token(Token = "0x6000779")]
			[Address(RVA = "0x512D190", Offset = "0x512BD90", VA = "0x18512D190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		public AsymmetricAlgorithm PrivateKey
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x512D350", Offset = "0x512BF50", VA = "0x18512D350")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600077B RID: 1915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000152")]
		public X500DistinguishedName IssuerName
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x512D290", Offset = "0x512BE90", VA = "0x18512D290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x17000153")]
		public DateTime NotAfter
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x512D330", Offset = "0x512BF30", VA = "0x18512D330")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x17000154")]
		public DateTime NotBefore
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x512D340", Offset = "0x512BF40", VA = "0x18512D340")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000155")]
		public PublicKey PublicKey
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x512D550", Offset = "0x512C150", VA = "0x18512D550")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000156")]
		public byte[] RawData
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x512D750", Offset = "0x512C350", VA = "0x18512D750")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000157")]
		public string SerialNumber
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x509D860", Offset = "0x509C460", VA = "0x18509D860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000158")]
		public Oid SignatureAlgorithm
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x512D7F0", Offset = "0x512C3F0", VA = "0x18512D7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000159")]
		public X500DistinguishedName SubjectName
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x512D9E0", Offset = "0x512C5E0", VA = "0x18512D9E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015A")]
		public string Thumbprint
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x512DA80", Offset = "0x512C680", VA = "0x18512DA80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x1700015B")]
		public int Version
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x512DAC0", Offset = "0x512C6C0", VA = "0x18512DAC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x512BBB0", Offset = "0x512A7B0", VA = "0x18512BBB0")]
		public static X509ContentType GetCertContentType(byte[] rawData)
		{
			return X509ContentType.Unknown;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x512BC60", Offset = "0x512A860", VA = "0x18512BC60")]
		public string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			return null;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x512CBD0", Offset = "0x512B7D0", VA = "0x18512CBD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x512BD90", Offset = "0x512A990", VA = "0x18512BD90", Slot = "19")]
		public override string ToString(bool verbose)
		{
			return null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x512CBE0", Offset = "0x512B7E0", VA = "0x18512CBE0")]
		public bool Verify()
		{
			return default(bool);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x512B870", Offset = "0x512A470", VA = "0x18512B870")]
		private static X509Extension CreateCustomExtensionIfAny(Oid oid)
		{
			return null;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015C")]
		internal X509Certificate2Impl Impl
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x512D1F0", Offset = "0x512BDF0", VA = "0x18512D1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x60")]
		private byte[] lazyRawData;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x68")]
		private Oid lazySignatureAlgorithm;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x70")]
		private int lazyVersion;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x78")]
		private X500DistinguishedName lazySubjectName;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x80")]
		private X500DistinguishedName lazyIssuerName;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x88")]
		private PublicKey lazyPublicKey;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x90")]
		private AsymmetricAlgorithm lazyPrivateKey;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x98")]
		private X509ExtensionCollection lazyExtensions;
	}
}
