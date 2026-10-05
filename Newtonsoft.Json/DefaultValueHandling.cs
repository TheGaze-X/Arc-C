using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[Flags]
	[Preserve]
	public enum DefaultValueHandling
	{
		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		Include = 0,
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		Ignore = 1,
		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		Populate = 2,
		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		IgnoreAndPopulate = 3
	}
}
