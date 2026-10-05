using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	public class X509Certificate : X509ExtensionBase
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X509Certificate()
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x5452AB0", Offset = "0x54516B0", VA = "0x185452AB0")]
		public X509Certificate(X509CertificateStructure c)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009C")]
		public virtual X509CertificateStructure CertificateStructure
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x1700009D")]
		public virtual bool IsValidNow
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x5452F10", Offset = "0x5451B10", VA = "0x185452F10", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x54519D0", Offset = "0x54505D0", VA = "0x1854519D0", Slot = "15")]
		public virtual bool IsValid(DateTime time)
		{
			return default(bool);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x5450720", Offset = "0x544F320", VA = "0x185450720", Slot = "16")]
		public virtual void CheckValidity()
		{
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x54507A0", Offset = "0x544F3A0", VA = "0x1854507A0", Slot = "17")]
		public virtual void CheckValidity(DateTime time)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x1700009E")]
		public virtual int Version
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x54531B0", Offset = "0x5451DB0", VA = "0x1854531B0", Slot = "18")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		public virtual BigInteger SerialNumber
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x5453040", Offset = "0x5451C40", VA = "0x185453040", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A0")]
		public virtual X509Name IssuerDN
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x5452F90", Offset = "0x5451B90", VA = "0x185452F90", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public virtual X509Name SubjectDN
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x5453160", Offset = "0x5451D60", VA = "0x185453160", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x170000A2")]
		public virtual DateTime NotBefore
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x5453010", Offset = "0x5451C10", VA = "0x185453010", Slot = "22")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x170000A3")]
		public virtual DateTime NotAfter
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x5452FE0", Offset = "0x5451BE0", VA = "0x185452FE0", Slot = "23")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x54517A0", Offset = "0x54503A0", VA = "0x1854517A0", Slot = "24")]
		public virtual byte[] GetTbsCertificate()
		{
			return null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x5451710", Offset = "0x5450310", VA = "0x185451710", Slot = "25")]
		public virtual byte[] GetSignature()
		{
			return null;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public virtual string SigAlgName
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x5453070", Offset = "0x5451C70", VA = "0x185453070", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A5")]
		public virtual string SigAlgOid
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x5453100", Offset = "0x5451D00", VA = "0x185453100", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x5451650", Offset = "0x5450250", VA = "0x185451650", Slot = "28")]
		public virtual byte[] GetSigAlgParams()
		{
			return null;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A6")]
		public virtual DerBitString IssuerUniqueID
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x5452FB0", Offset = "0x5451BB0", VA = "0x185452FB0", Slot = "29")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public virtual DerBitString SubjectUniqueID
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x5453180", Offset = "0x5451D80", VA = "0x185453180", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x54515A0", Offset = "0x54501A0", VA = "0x1854515A0", Slot = "31")]
		public virtual bool[] GetKeyUsage()
		{
			return null;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x5450F90", Offset = "0x544FB90", VA = "0x185450F90", Slot = "32")]
		public virtual IList GetExtendedKeyUsage()
		{
			return null;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x5450EF0", Offset = "0x544FAF0", VA = "0x185450EF0", Slot = "33")]
		public virtual int GetBasicConstraints()
		{
			return 0;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x5451730", Offset = "0x5450330", VA = "0x185451730", Slot = "34")]
		public virtual ICollection GetSubjectAlternativeNames()
		{
			return null;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x5451530", Offset = "0x5450130", VA = "0x185451530", Slot = "35")]
		public virtual ICollection GetIssuerAlternativeNames()
		{
			return null;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x5450AB0", Offset = "0x544F6B0", VA = "0x185450AB0", Slot = "36")]
		protected virtual ICollection GetAlternativeNames(string oid)
		{
			return null;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x54517D0", Offset = "0x54503D0", VA = "0x1854517D0", Slot = "8")]
		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x5451620", Offset = "0x5450220", VA = "0x185451620", Slot = "37")]
		public virtual AsymmetricKeyParameter GetPublicKey()
		{
			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x5450F70", Offset = "0x544FB70", VA = "0x185450F70", Slot = "38")]
		public virtual byte[] GetEncoded()
		{
			return null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x54509B0", Offset = "0x544F5B0", VA = "0x1854509B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x5451450", Offset = "0x5450050", VA = "0x185451450", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x5451AC0", Offset = "0x54506C0", VA = "0x185451AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x5452970", Offset = "0x5451570", VA = "0x185452970", Slot = "39")]
		public virtual void Verify(AsymmetricKeyParameter key)
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x5452A20", Offset = "0x5451620", VA = "0x185452A20", Slot = "40")]
		public virtual void Verify(IVerifierFactoryProvider verifierProvider)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x5450410", Offset = "0x544F010", VA = "0x185450410", Slot = "41")]
		protected virtual void CheckSignature(IVerifierFactory verifier)
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x5451820", Offset = "0x5450420", VA = "0x185451820")]
		private static bool IsAlgIDEqual(AlgorithmIdentifier id1, AlgorithmIdentifier id2)
		{
			return default(bool);
		}

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x10")]
		private readonly X509CertificateStructure c;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x18")]
		private readonly BasicConstraints basicConstraints;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool[] keyUsage;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x28")]
		private bool hashValueSet;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x2C")]
		private int hashValue;
	}
}
