using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public class PemReader
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x54678D0", Offset = "0x54664D0", VA = "0x1854678D0")]
		public PemReader(TextReader reader)
		{
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CE")]
		public TextReader Reader
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x54677A0", Offset = "0x54663A0", VA = "0x1854677A0")]
		public PemObject ReadPemObject()
		{
			return null;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x54673A0", Offset = "0x5465FA0", VA = "0x1854673A0")]
		private PemObject LoadObject(string type)
		{
			return null;
		}

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		private const string BeginString = "-----BEGIN ";

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		private const string EndString = "-----END ";

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0x10")]
		private readonly TextReader reader;
	}
}
