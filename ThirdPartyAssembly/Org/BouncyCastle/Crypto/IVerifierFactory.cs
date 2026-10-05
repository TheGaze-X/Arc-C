using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000229")]
	public interface IVerifierFactory
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06001352 RID: 4946
		[Token(Token = "0x170002AF")]
		object AlgorithmDetails { [Token(Token = "0x6001352")] get; }

		// Token: 0x06001353 RID: 4947
		[Token(Token = "0x6001353")]
		IStreamCalculator CreateCalculator();
	}
}
