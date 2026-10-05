using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[Flags]
	internal enum TextGenerationError
	{
		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		None = 0,
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		CustomSizeOnNonDynamicFont = 1,
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		CustomStyleOnNonDynamicFont = 2,
		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		NoFont = 4
	}
}
