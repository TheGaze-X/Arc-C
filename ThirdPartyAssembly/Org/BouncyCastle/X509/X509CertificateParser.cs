using System;
using System.Collections;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	public class X509CertificateParser
	{
		// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x544FFD0", Offset = "0x544EBD0", VA = "0x18544FFD0")]
		private X509Certificate ReadDerCertificate(Asn1InputStream dIn)
		{
			return null;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x544F600", Offset = "0x544E200", VA = "0x18544F600")]
		private X509Certificate GetCertificate()
		{
			return null;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x54502B0", Offset = "0x544EEB0", VA = "0x1854502B0")]
		private X509Certificate ReadPemCertificate(Stream inStream)
		{
			return null;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x544F5A0", Offset = "0x544E1A0", VA = "0x18544F5A0", Slot = "4")]
		protected virtual X509Certificate CreateX509Certificate(X509CertificateStructure c)
		{
			return null;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x544FBF0", Offset = "0x544E7F0", VA = "0x18544FBF0")]
		public X509Certificate ReadCertificate(byte[] input)
		{
			return null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x544FE00", Offset = "0x544EA00", VA = "0x18544FE00")]
		public ICollection ReadCertificates(byte[] input)
		{
			return null;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x544F760", Offset = "0x544E360", VA = "0x18544F760")]
		public X509Certificate ReadCertificate(Stream inStream)
		{
			return null;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x544FC70", Offset = "0x544E870", VA = "0x18544FC70")]
		public ICollection ReadCertificates(Stream inStream)
		{
			return null;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public X509CertificateParser()
		{
		}

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x0")]
		private static readonly PemParser PemCertParser;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x10")]
		private Asn1Set sData;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x18")]
		private int sDataObjectCount;

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x20")]
		private Stream currentStream;
	}
}
