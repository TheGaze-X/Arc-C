using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x02000226 RID: 550
	[Token(Token = "0x2000226")]
	public interface IStreamCalculator
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001349 RID: 4937
		[Token(Token = "0x170002AD")]
		Stream Stream { [Token(Token = "0x6001349")] get; }

		// Token: 0x0600134A RID: 4938
		[Token(Token = "0x600134A")]
		object GetResult();
	}
}
