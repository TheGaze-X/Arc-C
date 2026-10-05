using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public enum EBeginAuthSessionResult
	{
		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		k_EBeginAuthSessionResultOK,
		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		k_EBeginAuthSessionResultInvalidTicket,
		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		k_EBeginAuthSessionResultDuplicateRequest,
		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		k_EBeginAuthSessionResultInvalidVersion,
		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		k_EBeginAuthSessionResultGameMismatch,
		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		k_EBeginAuthSessionResultExpiredTicket
	}
}
