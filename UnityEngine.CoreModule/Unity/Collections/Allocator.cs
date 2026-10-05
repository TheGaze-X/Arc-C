using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Unity.Collections
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[UsedByNativeCode]
	public enum Allocator
	{
		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		Invalid,
		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		None,
		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		Temp,
		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		TempJob,
		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		Persistent,
		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		AudioKernel
	}
}
