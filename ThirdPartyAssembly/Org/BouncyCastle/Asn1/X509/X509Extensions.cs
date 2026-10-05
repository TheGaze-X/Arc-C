using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	public class X509Extensions : Asn1Encodable
	{
		// Token: 0x060022AB RID: 8875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AB")]
		[Address(RVA = "0x53472A0", Offset = "0x5345EA0", VA = "0x1853472A0")]
		public static X509Extensions GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AC")]
		[Address(RVA = "0x5346FE0", Offset = "0x5345BE0", VA = "0x185346FE0")]
		public static X509Extensions GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x5349600", Offset = "0x5348200", VA = "0x185349600")]
		private X509Extensions(Asn1Sequence seq)
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x53495F0", Offset = "0x53481F0", VA = "0x1853495F0")]
		public X509Extensions(IDictionary extensions)
		{
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x5348810", Offset = "0x5347410", VA = "0x185348810")]
		public X509Extensions(IList ordering, IDictionary extensions)
		{
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x5349BE0", Offset = "0x53487E0", VA = "0x185349BE0")]
		public X509Extensions(IList oids, IList values)
		{
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x5348800", Offset = "0x5347400", VA = "0x185348800")]
		[Obsolete]
		public X509Extensions(Hashtable extensions)
		{
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x5348CF0", Offset = "0x53478F0", VA = "0x185348CF0")]
		[Obsolete]
		public X509Extensions(ArrayList ordering, Hashtable extensions)
		{
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B3")]
		[Address(RVA = "0x5349190", Offset = "0x5347D90", VA = "0x185349190")]
		[Obsolete]
		public X509Extensions(ArrayList oids, ArrayList values)
		{
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x5347320", Offset = "0x5345F20", VA = "0x185347320")]
		[Obsolete("Use ExtensionOids IEnumerable property")]
		public IEnumerator Oids()
		{
			return null;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049D")]
		public IEnumerable ExtensionOids
		{
			[Token(Token = "0x60022B5")]
			[Address(RVA = "0x534A0A0", Offset = "0x5348CA0", VA = "0x18534A0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x5346F00", Offset = "0x5345B00", VA = "0x185346F00")]
		public X509Extension GetExtension(DerObjectIdentifier oid)
		{
			return null;
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x53473B0", Offset = "0x5345FB0", VA = "0x1853473B0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0000F930 File Offset: 0x0000DB30
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x53466A0", Offset = "0x53452A0", VA = "0x1853466A0")]
		public bool Equivalent(X509Extensions other)
		{
			return default(bool);
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x5346A00", Offset = "0x5345600", VA = "0x185346A00")]
		public DerObjectIdentifier[] GetExtensionOids()
		{
			return null;
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0x5347310", Offset = "0x5345F10", VA = "0x185347310")]
		public DerObjectIdentifier[] GetNonCriticalExtensionOids()
		{
			return null;
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BB")]
		[Address(RVA = "0x53469F0", Offset = "0x53455F0", VA = "0x1853469F0")]
		public DerObjectIdentifier[] GetCriticalExtensionOids()
		{
			return null;
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BC")]
		[Address(RVA = "0x5346A50", Offset = "0x5345650", VA = "0x185346A50")]
		private DerObjectIdentifier[] GetExtensionOids(bool isCritical)
		{
			return null;
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022BD")]
		[Address(RVA = "0x5347A80", Offset = "0x5346680", VA = "0x185347A80")]
		private static DerObjectIdentifier[] ToOidArray(IList oids)
		{
			return null;
		}

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerObjectIdentifier SubjectDirectoryAttributes;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DerObjectIdentifier SubjectKeyIdentifier;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DerObjectIdentifier KeyUsage;

		// Token: 0x0400123A RID: 4666
		[Token(Token = "0x400123A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DerObjectIdentifier PrivateKeyUsagePeriod;

		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x400123B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly DerObjectIdentifier SubjectAlternativeName;

		// Token: 0x0400123C RID: 4668
		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0x28")]
		public static readonly DerObjectIdentifier IssuerAlternativeName;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x30")]
		public static readonly DerObjectIdentifier BasicConstraints;

		// Token: 0x0400123E RID: 4670
		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x38")]
		public static readonly DerObjectIdentifier CrlNumber;

		// Token: 0x0400123F RID: 4671
		[Token(Token = "0x400123F")]
		[FieldOffset(Offset = "0x40")]
		public static readonly DerObjectIdentifier ReasonCode;

		// Token: 0x04001240 RID: 4672
		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0x48")]
		public static readonly DerObjectIdentifier InstructionCode;

		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0x50")]
		public static readonly DerObjectIdentifier InvalidityDate;

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0x58")]
		public static readonly DerObjectIdentifier DeltaCrlIndicator;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0x60")]
		public static readonly DerObjectIdentifier IssuingDistributionPoint;

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0x68")]
		public static readonly DerObjectIdentifier CertificateIssuer;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0x70")]
		public static readonly DerObjectIdentifier NameConstraints;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0x78")]
		public static readonly DerObjectIdentifier CrlDistributionPoints;

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0x80")]
		public static readonly DerObjectIdentifier CertificatePolicies;

		// Token: 0x04001248 RID: 4680
		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0x88")]
		public static readonly DerObjectIdentifier PolicyMappings;

		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0x90")]
		public static readonly DerObjectIdentifier AuthorityKeyIdentifier;

		// Token: 0x0400124A RID: 4682
		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0x98")]
		public static readonly DerObjectIdentifier PolicyConstraints;

		// Token: 0x0400124B RID: 4683
		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly DerObjectIdentifier ExtendedKeyUsage;

		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly DerObjectIdentifier FreshestCrl;

		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly DerObjectIdentifier InhibitAnyPolicy;

		// Token: 0x0400124E RID: 4686
		[Token(Token = "0x400124E")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly DerObjectIdentifier AuthorityInfoAccess;

		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly DerObjectIdentifier SubjectInfoAccess;

		// Token: 0x04001250 RID: 4688
		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly DerObjectIdentifier LogoType;

		// Token: 0x04001251 RID: 4689
		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly DerObjectIdentifier BiometricInfo;

		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly DerObjectIdentifier QCStatements;

		// Token: 0x04001253 RID: 4691
		[Token(Token = "0x4001253")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly DerObjectIdentifier AuditIdentity;

		// Token: 0x04001254 RID: 4692
		[Token(Token = "0x4001254")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly DerObjectIdentifier NoRevAvail;

		// Token: 0x04001255 RID: 4693
		[Token(Token = "0x4001255")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly DerObjectIdentifier TargetInformation;

		// Token: 0x04001256 RID: 4694
		[Token(Token = "0x4001256")]
		[FieldOffset(Offset = "0x10")]
		private readonly IDictionary extensions;

		// Token: 0x04001257 RID: 4695
		[Token(Token = "0x4001257")]
		[FieldOffset(Offset = "0x18")]
		private readonly IList ordering;
	}
}
