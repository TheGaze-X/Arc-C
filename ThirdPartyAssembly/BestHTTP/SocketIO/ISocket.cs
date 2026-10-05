using System;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	public interface ISocket
	{
		// Token: 0x06002B23 RID: 11043
		[Token(Token = "0x6002B23")]
		void Open();

		// Token: 0x06002B24 RID: 11044
		[Token(Token = "0x6002B24")]
		void Disconnect(bool remove);

		// Token: 0x06002B25 RID: 11045
		[Token(Token = "0x6002B25")]
		void OnPacket(Packet packet);

		// Token: 0x06002B26 RID: 11046
		[Token(Token = "0x6002B26")]
		void EmitEvent(SocketIOEventTypes type, params object[] args);

		// Token: 0x06002B27 RID: 11047
		[Token(Token = "0x6002B27")]
		void EmitEvent(string eventName, params object[] args);

		// Token: 0x06002B28 RID: 11048
		[Token(Token = "0x6002B28")]
		void EmitError(SocketIOErrors errCode, string msg);
	}
}
