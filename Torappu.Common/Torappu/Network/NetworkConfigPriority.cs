using System;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x02000213 RID: 531
	[Token(Token = "0x2000213")]
	public enum NetworkConfigPriority
	{
		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4000C13")]
		LOWEST,
		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4000C14")]
		SDK_INJECTED,
		// Token: 0x04000C15 RID: 3093
		[Token(Token = "0x4000C15")]
		NETWORK_ROUTER,
		// Token: 0x04000C16 RID: 3094
		[Token(Token = "0x4000C16")]
		FORTRESS_CONFIG,
		// Token: 0x04000C17 RID: 3095
		[Token(Token = "0x4000C17")]
		TEST_CONFIG,
		// Token: 0x04000C18 RID: 3096
		[Token(Token = "0x4000C18")]
		HIGHEST
	}
}
