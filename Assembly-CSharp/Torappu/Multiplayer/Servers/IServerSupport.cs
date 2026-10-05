using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork;

namespace Torappu.Multiplayer.Servers
{
	// Token: 0x0200156C RID: 5484
	[Token(Token = "0x200156C")]
	public interface IServerSupport : IHotfixable
	{
		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06007D71 RID: 32113
		[Token(Token = "0x17000EF0")]
		INetProtocolSuite protocolSuite { [Token(Token = "0x6007D71")] get; }

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06007D72 RID: 32114
		[Token(Token = "0x17000EF1")]
		EventPool<MultiplayerEvent> eventPool { [Token(Token = "0x6007D72")] get; }

		// Token: 0x06007D73 RID: 32115
		[Token(Token = "0x6007D73")]
		void Alert(string content, ShowCondition condition, ProcWhenForbid proc = ProcWhenForbid.AfterBattle);
	}
}
