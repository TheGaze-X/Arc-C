using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	public class X509CrlEntry : X509ExtensionBase
	{
		// Token: 0x06000626 RID: 1574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x5453B10", Offset = "0x5452710", VA = "0x185453B10")]
		public X509CrlEntry(CrlEntry c)
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x5453B60", Offset = "0x5452760", VA = "0x185453B60")]
		public X509CrlEntry(CrlEntry c, bool isIndirect, X509Name previousCertificateIssuer)
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x5453C70", Offset = "0x5452870", VA = "0x185453C70")]
		private X509Name loadCertificateIssuer()
		{
			return null;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
		public X509Name GetCertificateIssuer()
		{
			return null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x5453270", Offset = "0x5451E70", VA = "0x185453270", Slot = "8")]
		protected override X509Extensions GetX509Extensions()
		{
			return null;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x54531D0", Offset = "0x5451DD0", VA = "0x1854531D0")]
		public byte[] GetEncoded()
		{
			return null;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		public BigInteger SerialNumber
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x5453C40", Offset = "0x5452840", VA = "0x185453C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x170000B0")]
		public DateTime RevocationDate
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x5453C10", Offset = "0x5452810", VA = "0x185453C10")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x170000B1")]
		public bool HasExtensions
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x5453BE0", Offset = "0x54527E0", VA = "0x185453BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x5453290", Offset = "0x5451E90", VA = "0x185453290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x10")]
		private CrlEntry c;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[FieldOffset(Offset = "0x18")]
		private bool isIndirect;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[FieldOffset(Offset = "0x20")]
		private X509Name previousCertificateIssuer;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[FieldOffset(Offset = "0x28")]
		private X509Name certificateIssuer;
	}
}
