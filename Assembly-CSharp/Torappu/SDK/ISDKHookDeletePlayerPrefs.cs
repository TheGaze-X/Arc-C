using System;
using Il2CppDummyDll;

namespace Torappu.SDK
{
	// Token: 0x020014F7 RID: 5367
	[Token(Token = "0x20014F7")]
	public interface ISDKHookDeletePlayerPrefs
	{
		// Token: 0x06007B8D RID: 31629
		[Token(Token = "0x6007B8D")]
		bool TryHookDeleteAllPlayerPrefs(Action deleteFunc, Action saveFunc);
	}
}
