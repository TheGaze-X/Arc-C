using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	public class X509CrlParser
	{
		// Token: 0x06000630 RID: 1584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x4A7B1B0", Offset = "0x4A79DB0", VA = "0x184A7B1B0")]
		public X509CrlParser()
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x485B310", Offset = "0x4859F10", VA = "0x18485B310")]
		public X509CrlParser(bool lazyAsn1)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x5454AB0", Offset = "0x54536B0", VA = "0x185454AB0")]
		private X509Crl ReadPemCrl(Stream inStream)
		{
			return null;
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x54547D0", Offset = "0x54533D0", VA = "0x1854547D0")]
		private X509Crl ReadDerCrl(Asn1InputStream dIn)
		{
			return null;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x5453E70", Offset = "0x5452A70", VA = "0x185453E70")]
		private X509Crl GetCrl()
		{
			return null;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x5453E10", Offset = "0x5452A10", VA = "0x185453E10", Slot = "4")]
		protected virtual X509Crl CreateX509Crl(CertificateList c)
		{
			return null;
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x5453F60", Offset = "0x5452B60", VA = "0x185453F60")]
		public X509Crl ReadCrl(byte[] input)
		{
			return null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x5454470", Offset = "0x5453070", VA = "0x185454470")]
		public ICollection ReadCrls(byte[] input)
		{
			return null;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x5453FE0", Offset = "0x5452BE0", VA = "0x185453FE0")]
		public X509Crl ReadCrl(Stream inStream)
		{
			return null;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x5454640", Offset = "0x5453240", VA = "0x185454640")]
		public ICollection ReadCrls(Stream inStream)
		{
			return null;
		}

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly PemParser PemCrlParser;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x10")]
		private readonly bool lazyAsn1;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x18")]
		private Asn1Set sCrlData;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x20")]
		private int sCrlDataObjectCount;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x28")]
		private Stream currentCrlStream;
	}
}
