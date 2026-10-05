using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	internal class PemParser
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x544D720", Offset = "0x544C320", VA = "0x18544D720")]
		internal PemParser(string type)
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x544D3A0", Offset = "0x544BFA0", VA = "0x18544D3A0")]
		private string ReadLine(Stream inStream)
		{
			return null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x544D4B0", Offset = "0x544C0B0", VA = "0x18544D4B0")]
		internal Asn1Sequence ReadPemObject(Stream inStream)
		{
			return null;
		}

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _header1;

		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		[FieldOffset(Offset = "0x18")]
		private readonly string _header2;

		// Token: 0x04000629 RID: 1577
		[Token(Token = "0x4000629")]
		[FieldOffset(Offset = "0x20")]
		private readonly string _footer1;

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x28")]
		private readonly string _footer2;
	}
}
