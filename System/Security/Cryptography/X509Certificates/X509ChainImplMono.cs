using System;
using Il2CppDummyDll;
using Mono.Security.X509;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	internal class X509ChainImplMono : X509ChainImpl
	{
		// Token: 0x06000818 RID: 2072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x5133190", Offset = "0x5131D90", VA = "0x185133190")]
		public X509ChainImplMono(bool useMachineContext)
		{
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x17000190")]
		public override bool IsValid
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000191")]
		public override X509ChainElementCollection ChainElements
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000192")]
		public override X509ChainPolicy ChainPolicy
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public override void AddStatus(X509ChainStatusFlags error)
		{
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x5130220", Offset = "0x512EE20", VA = "0x185130220", Slot = "8")]
		[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
		public override bool Build(X509Certificate2 certificate)
		{
			return default(bool);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x51328B0", Offset = "0x51314B0", VA = "0x1851328B0", Slot = "10")]
		public override void Reset()
		{
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000193")]
		private X509Certificate2Collection Roots
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x51339C0", Offset = "0x51325C0", VA = "0x1851339C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		private X509Certificate2Collection CertificateAuthorities
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x51333B0", Offset = "0x5131FB0", VA = "0x1851333B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000195")]
		private X509Store LMRootStore
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x5133910", Offset = "0x5132510", VA = "0x185133910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000196")]
		private X509Store UserRootStore
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x5133C70", Offset = "0x5132870", VA = "0x185133C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000197")]
		private X509Store LMCAStore
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x5133860", Offset = "0x5132460", VA = "0x185133860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000198")]
		private X509Store UserCAStore
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x5133BC0", Offset = "0x51327C0", VA = "0x185133BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000199")]
		private X509Certificate2Collection CertificateCollection
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x51335B0", Offset = "0x51321B0", VA = "0x1851335B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x5130030", Offset = "0x512EC30", VA = "0x185130030")]
		private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate)
		{
			return X509ChainStatusFlags.NoError;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x5132AB0", Offset = "0x51316B0", VA = "0x185132AB0")]
		private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c)
		{
			return null;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x5131500", Offset = "0x5130100", VA = "0x185131500")]
		private X509Certificate2 FindParent(X509Certificate2 certificate)
		{
			return null;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x5131A20", Offset = "0x5130620", VA = "0x185131A20")]
		private bool IsChainComplete(X509Certificate2 certificate)
		{
			return default(bool);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x5131B30", Offset = "0x5130730", VA = "0x185131B30")]
		private bool IsSelfIssued(X509Certificate2 certificate)
		{
			return default(bool);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x5132DC0", Offset = "0x51319C0", VA = "0x185132DC0")]
		private void ValidateChain(X509ChainStatusFlags flag)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x51324B0", Offset = "0x51310B0", VA = "0x1851324B0")]
		private void Process(int n)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x5131BD0", Offset = "0x51307D0", VA = "0x185131BD0")]
		private void PrepareForNextCertificate(int n)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x5133010", Offset = "0x5131C10", VA = "0x185133010")]
		private void WrapUp()
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x5131ED0", Offset = "0x5130AD0", VA = "0x185131ED0")]
		private void ProcessCertificateExtensions(X509ChainElement element)
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x5131B80", Offset = "0x5130780", VA = "0x185131B80")]
		private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey)
		{
			return default(bool);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x5131970", Offset = "0x5130570", VA = "0x185131970")]
		private string GetSubjectKeyIdentifier(X509Certificate2 certificate)
		{
			return null;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x51316E0", Offset = "0x51302E0", VA = "0x1851316E0")]
		private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate)
		{
			return null;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x5131770", Offset = "0x5130370", VA = "0x185131770")]
		private static string GetAuthorityKeyIdentifier(X509Crl crl)
		{
			return null;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x51317F0", Offset = "0x51303F0", VA = "0x1851317F0")]
		private static string GetAuthorityKeyIdentifier(X509Extension ext)
		{
			return null;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x5130C90", Offset = "0x512F890", VA = "0x185130C90")]
		private void CheckRevocationOnChain(X509ChainStatusFlags flag)
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x5131110", Offset = "0x512FD10", VA = "0x185131110")]
		private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online)
		{
			return X509ChainStatusFlags.NoError;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x5130F10", Offset = "0x512FB10", VA = "0x185130F10")]
		private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online)
		{
			return X509ChainStatusFlags.NoError;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x5130950", Offset = "0x512F550", VA = "0x185130950")]
		private static X509Crl CheckCrls(string subject, string ski, X509Store store)
		{
			return null;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x5131270", Offset = "0x512FE70", VA = "0x185131270")]
		private X509Crl FindCrl(X509Certificate2 caCertificate)
		{
			return null;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x5132240", Offset = "0x5130E40", VA = "0x185132240")]
		private bool ProcessCrlExtensions(X509Crl crl)
		{
			return default(bool);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x5132000", Offset = "0x5130C00", VA = "0x185132000")]
		private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry)
		{
			return default(bool);
		}

		// Token: 0x040005C7 RID: 1479
		[Token(Token = "0x40005C7")]
		[FieldOffset(Offset = "0x10")]
		private StoreLocation location;

		// Token: 0x040005C8 RID: 1480
		[Token(Token = "0x40005C8")]
		[FieldOffset(Offset = "0x18")]
		private X509ChainElementCollection elements;

		// Token: 0x040005C9 RID: 1481
		[Token(Token = "0x40005C9")]
		[FieldOffset(Offset = "0x20")]
		private X509ChainPolicy policy;

		// Token: 0x040005CA RID: 1482
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x28")]
		private X509ChainStatus[] status;

		// Token: 0x040005CB RID: 1483
		[Token(Token = "0x40005CB")]
		[FieldOffset(Offset = "0x0")]
		private static X509ChainStatus[] Empty;

		// Token: 0x040005CC RID: 1484
		[Token(Token = "0x40005CC")]
		[FieldOffset(Offset = "0x30")]
		private int max_path_length;

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x38")]
		private X500DistinguishedName working_issuer_name;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x40")]
		private AsymmetricAlgorithm working_public_key;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x48")]
		private X509ChainElement bce_restriction;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x50")]
		private X509Certificate2Collection roots;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x58")]
		private X509Certificate2Collection cas;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x60")]
		private X509Store root_store;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x68")]
		private X509Store ca_store;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x70")]
		private X509Store user_root_store;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x78")]
		private X509Store user_ca_store;

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x80")]
		private X509Certificate2Collection collection;
	}
}
