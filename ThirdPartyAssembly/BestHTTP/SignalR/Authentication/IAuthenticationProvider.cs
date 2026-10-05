using System;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Authentication
{
	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x200055E")]
	public interface IAuthenticationProvider
	{
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002D93 RID: 11667
		[Token(Token = "0x170006E0")]
		bool IsPreAuthRequired { [Token(Token = "0x6002D93")] get; }

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06002D94 RID: 11668
		// (remove) Token: 0x06002D95 RID: 11669
		[Token(Token = "0x1400001A")]
		event OnAuthenticationSuccededDelegate OnAuthenticationSucceded;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06002D96 RID: 11670
		// (remove) Token: 0x06002D97 RID: 11671
		[Token(Token = "0x1400001B")]
		event OnAuthenticationFailedDelegate OnAuthenticationFailed;

		// Token: 0x06002D98 RID: 11672
		[Token(Token = "0x6002D98")]
		void StartAuthentication();

		// Token: 0x06002D99 RID: 11673
		[Token(Token = "0x6002D99")]
		void PrepareRequest(HTTPRequest request, RequestTypes type);
	}
}
