using System;
using Il2CppDummyDll;

namespace Torappu.SocketNetwork.ServerBase
{
	// Token: 0x020014BD RID: 5309
	// (Invoke) Token: 0x06007A7B RID: 31355
	[Token(Token = "0x20014BD")]
	public delegate void ProcResponse<Response>(RRPRespCode code, Response resp) where Response : Protocol, IRRPProtocol;
}
