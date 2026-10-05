using System;
using BestHTTP.SocketIO.Transports;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x02000518 RID: 1304
	[Token(Token = "0x2000518")]
	public interface IManager
	{
		// Token: 0x06002B17 RID: 11031
		[Token(Token = "0x6002B17")]
		void Remove(Socket socket);

		// Token: 0x06002B18 RID: 11032
		[Token(Token = "0x6002B18")]
		void Close(bool removeSockets = true);

		// Token: 0x06002B19 RID: 11033
		[Token(Token = "0x6002B19")]
		void TryToReconnect();

		// Token: 0x06002B1A RID: 11034
		[Token(Token = "0x6002B1A")]
		bool OnTransportConnected(ITransport transport);

		// Token: 0x06002B1B RID: 11035
		[Token(Token = "0x6002B1B")]
		void OnTransportError(ITransport trans, string err);

		// Token: 0x06002B1C RID: 11036
		[Token(Token = "0x6002B1C")]
		void OnTransportProbed(ITransport trans);

		// Token: 0x06002B1D RID: 11037
		[Token(Token = "0x6002B1D")]
		void SendPacket(Packet packet);

		// Token: 0x06002B1E RID: 11038
		[Token(Token = "0x6002B1E")]
		void OnPacket(Packet packet);

		// Token: 0x06002B1F RID: 11039
		[Token(Token = "0x6002B1F")]
		void EmitEvent(string eventName, params object[] args);

		// Token: 0x06002B20 RID: 11040
		[Token(Token = "0x6002B20")]
		void EmitEvent(SocketIOEventTypes type, params object[] args);

		// Token: 0x06002B21 RID: 11041
		[Token(Token = "0x6002B21")]
		void EmitError(SocketIOErrors errCode, string msg);

		// Token: 0x06002B22 RID: 11042
		[Token(Token = "0x6002B22")]
		void EmitAll(string eventName, params object[] args);
	}
}
