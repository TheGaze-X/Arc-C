using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014BC RID: 5308
	// (Invoke) Token: 0x06007A77 RID: 31351
	[Token(Token = "0x20014BC")]
	public delegate void FillRequest<Request>(Request request) where Request : Protocol, IRRPProtocol, new();
}
