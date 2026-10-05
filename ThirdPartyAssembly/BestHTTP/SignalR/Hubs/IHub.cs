using System;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Hubs
{
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	public interface IHub
	{
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06002D5B RID: 11611
		// (set) Token: 0x06002D5C RID: 11612
		[Token(Token = "0x170006D7")]
		Connection Connection { [Token(Token = "0x6002D5B")] get; [Token(Token = "0x6002D5C")] set; }

		// Token: 0x06002D5D RID: 11613
		[Token(Token = "0x6002D5D")]
		bool Call(ClientMessage msg);

		// Token: 0x06002D5E RID: 11614
		[Token(Token = "0x6002D5E")]
		bool HasSentMessageId(ulong id);

		// Token: 0x06002D5F RID: 11615
		[Token(Token = "0x6002D5F")]
		void Close();

		// Token: 0x06002D60 RID: 11616
		[Token(Token = "0x6002D60")]
		void OnMethod(MethodCallMessage msg);

		// Token: 0x06002D61 RID: 11617
		[Token(Token = "0x6002D61")]
		void OnMessage(IServerMessage msg);
	}
}
