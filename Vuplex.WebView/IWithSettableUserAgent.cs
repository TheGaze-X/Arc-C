using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public interface IWithSettableUserAgent
	{
		// Token: 0x06000172 RID: 370
		[Token(Token = "0x6000172")]
		void SetUserAgent(bool mobile);

		// Token: 0x06000173 RID: 371
		[Token(Token = "0x6000173")]
		void SetUserAgent(string userAgent);
	}
}
