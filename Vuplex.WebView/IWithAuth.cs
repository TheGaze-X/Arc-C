using System;
using Il2CppDummyDll;

namespace Vuplex.WebView
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public interface IWithAuth
	{
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06000141 RID: 321
		// (remove) Token: 0x06000142 RID: 322
		[Token(Token = "0x14000027")]
		event EventHandler<AuthRequestedEventArgs> AuthRequested;
	}
}
