using System;
using Il2CppDummyDll;

namespace Torappu.MsgSubscription
{
	// Token: 0x020015DE RID: 5598
	[Token(Token = "0x20015DE")]
	public interface ISubMsgCenter : IHotfixable
	{
		// Token: 0x06007EF0 RID: 32496
		[Token(Token = "0x6007EF0")]
		void Start();

		// Token: 0x06007EF1 RID: 32497
		[Token(Token = "0x6007EF1")]
		void Stop();

		// Token: 0x06007EF2 RID: 32498
		[Token(Token = "0x6007EF2")]
		string GetMsgType();

		// Token: 0x06007EF3 RID: 32499
		[Token(Token = "0x6007EF3")]
		void HandleMsg(string msgConent);
	}
}
