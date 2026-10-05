using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000227 RID: 551
	[Token(Token = "0x2000227")]
	public interface IStreamCipher
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600134B RID: 4939
		[Token(Token = "0x170002AE")]
		string AlgorithmName { [Token(Token = "0x600134B")] get; }

		// Token: 0x0600134C RID: 4940
		[Token(Token = "0x600134C")]
		void Init(bool forEncryption, ICipherParameters parameters);

		// Token: 0x0600134D RID: 4941
		[Token(Token = "0x600134D")]
		byte ReturnByte(byte input);

		// Token: 0x0600134E RID: 4942
		[Token(Token = "0x600134E")]
		void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff);

		// Token: 0x0600134F RID: 4943
		[Token(Token = "0x600134F")]
		void Reset();
	}
}
