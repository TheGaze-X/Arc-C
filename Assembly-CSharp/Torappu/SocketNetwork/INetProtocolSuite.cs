using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork
{
	// Token: 0x020014A4 RID: 5284
	[Token(Token = "0x20014A4")]
	public interface INetProtocolSuite : IHotfixable
	{
		// Token: 0x06007A05 RID: 31237
		[Token(Token = "0x6007A05")]
		T Get<T>() where T : Protocol, new();

		// Token: 0x06007A06 RID: 31238
		[Token(Token = "0x6007A06")]
		Protocol Get(NetMsgID id);

		// Token: 0x06007A07 RID: 31239
		[Token(Token = "0x6007A07")]
		NetMsgID GetID<T>() where T : Protocol;
	}
}
