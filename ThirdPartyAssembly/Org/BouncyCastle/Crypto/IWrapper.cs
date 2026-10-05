using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	public interface IWrapper
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001355 RID: 4949
		[Token(Token = "0x170002B0")]
		string AlgorithmName { [Token(Token = "0x6001355")] get; }

		// Token: 0x06001356 RID: 4950
		[Token(Token = "0x6001356")]
		void Init(bool forWrapping, ICipherParameters parameters);

		// Token: 0x06001357 RID: 4951
		[Token(Token = "0x6001357")]
		byte[] Wrap(byte[] input, int inOff, int length);

		// Token: 0x06001358 RID: 4952
		[Token(Token = "0x6001358")]
		byte[] Unwrap(byte[] input, int inOff, int length);
	}
}
