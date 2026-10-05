using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004F3 RID: 1267
	[Token(Token = "0x20004F3")]
	[System.Flags]
	public enum CallingConventions
	{
		// Token: 0x040014B1 RID: 5297
		[Token(Token = "0x40014B1")]
		Standard = 1,
		// Token: 0x040014B2 RID: 5298
		[Token(Token = "0x40014B2")]
		VarArgs = 2,
		// Token: 0x040014B3 RID: 5299
		[Token(Token = "0x40014B3")]
		Any = 3,
		// Token: 0x040014B4 RID: 5300
		[Token(Token = "0x40014B4")]
		HasThis = 32,
		// Token: 0x040014B5 RID: 5301
		[Token(Token = "0x40014B5")]
		ExplicitThis = 64
	}
}
