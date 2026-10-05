using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public interface IPolynomial
	{
		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000A2F RID: 2607
		[Token(Token = "0x170000ED")]
		int Degree { [Token(Token = "0x6000A2F")] get; }

		// Token: 0x06000A30 RID: 2608
		[Token(Token = "0x6000A30")]
		int[] GetExponentsPresent();
	}
}
