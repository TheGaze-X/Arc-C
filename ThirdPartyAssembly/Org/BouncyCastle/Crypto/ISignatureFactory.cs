using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000223")]
	public interface ISignatureFactory
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600133D RID: 4925
		[Token(Token = "0x170002AB")]
		object AlgorithmDetails { [Token(Token = "0x600133D")] get; }

		// Token: 0x0600133E RID: 4926
		[Token(Token = "0x600133E")]
		IStreamCalculator CreateCalculator();
	}
}
