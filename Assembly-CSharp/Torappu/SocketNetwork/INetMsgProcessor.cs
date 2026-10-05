using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork
{
	// Token: 0x020014A2 RID: 5282
	[Token(Token = "0x20014A2")]
	public interface INetMsgProcessor : IHotfixable
	{
		// Token: 0x06007A00 RID: 31232
		[Token(Token = "0x6007A00")]
		bool ProcMsg(NetMsg msg);
	}
}
