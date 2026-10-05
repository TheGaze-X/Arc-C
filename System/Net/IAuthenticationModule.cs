using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	public interface IAuthenticationModule
	{
		// Token: 0x06001348 RID: 4936
		[Token(Token = "0x6001348")]
		Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

		// Token: 0x06001349 RID: 4937
		[Token(Token = "0x6001349")]
		Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600134A RID: 4938
		[Token(Token = "0x17000403")]
		string AuthenticationType { [Token(Token = "0x600134A")] get; }
	}
}
