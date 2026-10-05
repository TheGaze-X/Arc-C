using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x20002F4")]
	public interface IWebProxy
	{
		// Token: 0x060014F9 RID: 5369
		[Token(Token = "0x60014F9")]
		Uri GetProxy(Uri destination);

		// Token: 0x060014FA RID: 5370
		[Token(Token = "0x60014FA")]
		bool IsBypassed(Uri host);

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060014FB RID: 5371
		[Token(Token = "0x17000472")]
		ICredentials Credentials { [Token(Token = "0x60014FB")] get; }
	}
}
