using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000224 RID: 548
	[Token(Token = "0x2000224")]
	public interface ISigner
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600133F RID: 4927
		[Token(Token = "0x170002AC")]
		string AlgorithmName { [Token(Token = "0x600133F")] get; }

		// Token: 0x06001340 RID: 4928
		[Token(Token = "0x6001340")]
		void Init(bool forSigning, ICipherParameters parameters);

		// Token: 0x06001341 RID: 4929
		[Token(Token = "0x6001341")]
		void Update(byte input);

		// Token: 0x06001342 RID: 4930
		[Token(Token = "0x6001342")]
		void BlockUpdate(byte[] input, int inOff, int length);

		// Token: 0x06001343 RID: 4931
		[Token(Token = "0x6001343")]
		byte[] GenerateSignature();

		// Token: 0x06001344 RID: 4932
		[Token(Token = "0x6001344")]
		bool VerifySignature(byte[] signature);

		// Token: 0x06001345 RID: 4933
		[Token(Token = "0x6001345")]
		void Reset();
	}
}
