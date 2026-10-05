using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200021A RID: 538
	[Token(Token = "0x200021A")]
	public interface IBlockResult
	{
		// Token: 0x06001311 RID: 4881
		[Token(Token = "0x6001311")]
		byte[] Collect();

		// Token: 0x06001312 RID: 4882
		[Token(Token = "0x6001312")]
		int Collect(byte[] destination, int offset);
	}
}
