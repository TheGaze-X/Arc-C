using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	public class X509Crl : X509ExtensionBase
	{
		// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x5456DA0", Offset = "0x54559A0", VA = "0x185456DA0")]
		public X509Crl(CertificateList c)
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x5455600", Offset = "0x5454200", VA = "0x185455600", Slot = "8")]
		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x5455040", Offset = "0x5453C40", VA = "0x185455040", Slot = "13")]
		public virtual byte[] GetEncoded()
		{
			return null;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x5456D10", Offset = "0x5455910", VA = "0x185456D10", Slot = "14")]
		public virtual void Verify(AsymmetricKeyParameter publicKey)
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x5456C80", Offset = "0x5455880", VA = "0x185456C80", Slot = "15")]
		public virtual void Verify(IVerifierFactoryProvider verifierProvider)
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x5454C10", Offset = "0x5453810", VA = "0x185454C10", Slot = "16")]
		protected virtual void CheckSignature(IVerifierFactory verifier)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x170000A8")]
		public virtual int Version
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x54531B0", Offset = "0x5451DB0", VA = "0x1854531B0", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A9")]
		public virtual X509Name IssuerDN
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x5457160", Offset = "0x5455D60", VA = "0x185457160", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x170000AA")]
		public virtual DateTime ThisUpdate
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x5457230", Offset = "0x5455E30", VA = "0x185457230", Slot = "19")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public virtual DateTimeObject NextUpdate
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x5457180", Offset = "0x5455D80", VA = "0x185457180", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x5455750", Offset = "0x5454350", VA = "0x185455750")]
		private ISet LoadCrlEntries()
		{
			return null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x54550E0", Offset = "0x5453CE0", VA = "0x1854550E0", Slot = "21")]
		public virtual X509CrlEntry GetRevokedCertificate(BigInteger serialNumber)
		{
			return null;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x5455450", Offset = "0x5454050", VA = "0x185455450", Slot = "22")]
		public virtual ISet GetRevokedCertificates()
		{
			return null;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x5455540", Offset = "0x5454140", VA = "0x185455540", Slot = "23")]
		public virtual byte[] GetTbsCertList()
		{
			return null;
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x5451710", Offset = "0x5450310", VA = "0x185451710", Slot = "24")]
		public virtual byte[] GetSignature()
		{
			return null;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		public virtual string SigAlgName
		{
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		public virtual string SigAlgOid
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x5453100", Offset = "0x5451D00", VA = "0x185453100", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x54554C0", Offset = "0x54540C0", VA = "0x1854554C0", Slot = "27")]
		public virtual byte[] GetSigAlgParams()
		{
			return null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x5454F40", Offset = "0x5453B40", VA = "0x185454F40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x2824310", Offset = "0x2822F10", VA = "0x182824310", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x5455B60", Offset = "0x5454760", VA = "0x185455B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x5455650", Offset = "0x5454250", VA = "0x185455650", Slot = "28")]
		public virtual bool IsRevoked(X509Certificate cert)
		{
			return default(bool);
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x170000AE")]
		protected virtual bool IsIndirectCrl
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x5456FD0", Offset = "0x5455BD0", VA = "0x185456FD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x10")]
		private readonly CertificateList c;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x18")]
		private readonly string sigAlgName;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x20")]
		private readonly byte[] sigAlgParams;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool isIndirect;
	}
}
