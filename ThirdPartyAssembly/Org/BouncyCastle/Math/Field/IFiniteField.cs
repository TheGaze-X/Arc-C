using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public interface IFiniteField
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000A2D RID: 2605
		[Token(Token = "0x170000EB")]
		BigInteger Characteristic { [Token(Token = "0x6000A2D")] get; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000A2E RID: 2606
		[Token(Token = "0x170000EC")]
		int Dimension { [Token(Token = "0x6000A2E")] get; }
	}
}
