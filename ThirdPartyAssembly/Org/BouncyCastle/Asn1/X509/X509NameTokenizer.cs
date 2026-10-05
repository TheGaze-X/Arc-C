using System;
using System.Text;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200041F RID: 1055
	[Token(Token = "0x200041F")]
	public class X509NameTokenizer
	{
		// Token: 0x060022E2 RID: 8930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x5380440", Offset = "0x537F040", VA = "0x185380440")]
		public X509NameTokenizer(string oid)
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x5380390", Offset = "0x537EF90", VA = "0x185380390")]
		public X509NameTokenizer(string oid, char separator)
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x5380160", Offset = "0x537ED60", VA = "0x185380160")]
		public bool HasMoreTokens()
		{
			return default(bool);
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x5380190", Offset = "0x537ED90", VA = "0x185380190")]
		public string NextToken()
		{
			return null;
		}

		// Token: 0x04001284 RID: 4740
		[Token(Token = "0x4001284")]
		[FieldOffset(Offset = "0x10")]
		private string value;

		// Token: 0x04001285 RID: 4741
		[Token(Token = "0x4001285")]
		[FieldOffset(Offset = "0x18")]
		private int index;

		// Token: 0x04001286 RID: 4742
		[Token(Token = "0x4001286")]
		[FieldOffset(Offset = "0x1C")]
		private char separator;

		// Token: 0x04001287 RID: 4743
		[Token(Token = "0x4001287")]
		[FieldOffset(Offset = "0x20")]
		private StringBuilder buffer;
	}
}
