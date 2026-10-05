using System;
using Il2CppDummyDll;

namespace Torappu.MsgSubscription
{
	// Token: 0x020015DD RID: 5597
	[Token(Token = "0x20015DD")]
	public interface ISubscriptionMsg : IHotfixable
	{
		// Token: 0x06007EEF RID: 32495
		[Token(Token = "0x6007EEF")]
		void FlushData(string data);
	}
}
