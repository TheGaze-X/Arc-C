using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	public interface IDerivationFunction
	{
		// Token: 0x06001325 RID: 4901
		[Token(Token = "0x6001325")]
		void Init(IDerivationParameters parameters);

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001326 RID: 4902
		[Token(Token = "0x170002A7")]
		IDigest Digest { [Token(Token = "0x6001326")] get; }

		// Token: 0x06001327 RID: 4903
		[Token(Token = "0x6001327")]
		int GenerateBytes(byte[] output, int outOff, int length);
	}
}
