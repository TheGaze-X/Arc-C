using System;
using Il2CppDummyDll;

namespace Sirenix.Serialization
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public enum ErrorHandlingPolicy
	{
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		Resilient,
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		ThrowOnErrors,
		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		ThrowOnWarningsAndErrors
	}
}
