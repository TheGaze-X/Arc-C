using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO.Transports
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	public interface ITransport
	{
		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06002BB9 RID: 11193
		[Token(Token = "0x17000675")]
		TransportTypes Type { [Token(Token = "0x6002BB9")] get; }

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06002BBA RID: 11194
		[Token(Token = "0x17000676")]
		TransportStates State { [Token(Token = "0x6002BBA")] get; }

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06002BBB RID: 11195
		[Token(Token = "0x17000677")]
		SocketManager Manager { [Token(Token = "0x6002BBB")] get; }

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06002BBC RID: 11196
		[Token(Token = "0x17000678")]
		bool IsRequestInProgress { [Token(Token = "0x6002BBC")] get; }

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06002BBD RID: 11197
		[Token(Token = "0x17000679")]
		bool IsPollingInProgress { [Token(Token = "0x6002BBD")] get; }

		// Token: 0x06002BBE RID: 11198
		[Token(Token = "0x6002BBE")]
		void Open();

		// Token: 0x06002BBF RID: 11199
		[Token(Token = "0x6002BBF")]
		void Poll();

		// Token: 0x06002BC0 RID: 11200
		[Token(Token = "0x6002BC0")]
		void Send(Packet packet);

		// Token: 0x06002BC1 RID: 11201
		[Token(Token = "0x6002BC1")]
		void Send(List<Packet> packets);

		// Token: 0x06002BC2 RID: 11202
		[Token(Token = "0x6002BC2")]
		void Close();
	}
}
