using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	[Flags]
	public enum InputUpdateType
	{
		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		None = 0,
		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		Dynamic = 1,
		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		Fixed = 2,
		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		BeforeRender = 4,
		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		Editor = 8,
		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		Manual = 16,
		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		Default = 11
	}
}
