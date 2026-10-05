using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	public interface IValueMsgReceiver
	{
		// Token: 0x0600050A RID: 1290
		[Token(Token = "0x600050A")]
		void OnMessage(int key, ValueBundle msg);
	}
}
