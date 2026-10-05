using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000216 RID: 534
	[Token(Token = "0x2000216")]
	public interface IAsymmetricBlockCipher
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001301 RID: 4865
		[Token(Token = "0x170002A3")]
		string AlgorithmName { [Token(Token = "0x6001301")] get; }

		// Token: 0x06001302 RID: 4866
		[Token(Token = "0x6001302")]
		void Init(bool forEncryption, ICipherParameters parameters);

		// Token: 0x06001303 RID: 4867
		[Token(Token = "0x6001303")]
		int GetInputBlockSize();

		// Token: 0x06001304 RID: 4868
		[Token(Token = "0x6001304")]
		int GetOutputBlockSize();

		// Token: 0x06001305 RID: 4869
		[Token(Token = "0x6001305")]
		byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen);
	}
}
