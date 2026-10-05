using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x0200021F RID: 543
	[Token(Token = "0x200021F")]
	public interface IDigest
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06001328 RID: 4904
		[Token(Token = "0x170002A8")]
		string AlgorithmName { [Token(Token = "0x6001328")] get; }

		// Token: 0x06001329 RID: 4905
		[Token(Token = "0x6001329")]
		int GetDigestSize();

		// Token: 0x0600132A RID: 4906
		[Token(Token = "0x600132A")]
		int GetByteLength();

		// Token: 0x0600132B RID: 4907
		[Token(Token = "0x600132B")]
		void Update(byte input);

		// Token: 0x0600132C RID: 4908
		[Token(Token = "0x600132C")]
		void BlockUpdate(byte[] input, int inOff, int length);

		// Token: 0x0600132D RID: 4909
		[Token(Token = "0x600132D")]
		int DoFinal(byte[] output, int outOff);

		// Token: 0x0600132E RID: 4910
		[Token(Token = "0x600132E")]
		void Reset();
	}
}
