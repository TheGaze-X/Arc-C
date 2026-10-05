using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200029D RID: 669
	[Token(Token = "0x200029D")]
	public class TlsNullCompression : TlsCompression
	{
		// Token: 0x06001679 RID: 5753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001679")]
		[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "6")]
		public virtual Stream Compress(Stream output)
		{
			return null;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "7")]
		public virtual Stream Decompress(Stream output)
		{
			return null;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TlsNullCompression()
		{
		}
	}
}
