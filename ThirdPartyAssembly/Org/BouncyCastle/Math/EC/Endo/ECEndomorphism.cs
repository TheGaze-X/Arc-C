using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	public interface ECEndomorphism
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000BDA RID: 3034
		[Token(Token = "0x1700012F")]
		ECPointMap PointMap { [Token(Token = "0x6000BDA")] get; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000BDB RID: 3035
		[Token(Token = "0x17000130")]
		bool HasEfficientPointMap { [Token(Token = "0x6000BDB")] get; }
	}
}
