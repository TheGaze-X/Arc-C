using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[Flags]
	[Preserve]
	public enum PreserveReferencesHandling
	{
		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		None = 0,
		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		Objects = 1,
		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		Arrays = 2,
		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		All = 3
	}
}
