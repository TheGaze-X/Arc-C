using System;
using Il2CppDummyDll;
using U8.SDK;

namespace Torappu.SDK
{
	// Token: 0x020014D7 RID: 5335
	[Token(Token = "0x20014D7")]
	public interface ISDKBase : IHotfixable
	{
		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06007B1B RID: 31515
		[Token(Token = "0x17000EAB")]
		IExternalPlugin externalPlugin { [Token(Token = "0x6007B1B")] get; }
	}
}
