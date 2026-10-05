using System;
using BestHTTP.SignalR.JsonEncoders;
using BestHTTP.SignalR.Messages;
using BestHTTP.SignalR.Transports;
using Il2CppDummyDll;

namespace BestHTTP.SignalR
{
	// Token: 0x02000535 RID: 1333
	[Token(Token = "0x2000535")]
	public interface IConnection
	{
		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002C2A RID: 11306
		[Token(Token = "0x17000689")]
		ProtocolVersions Protocol { [Token(Token = "0x6002C2A")] get; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002C2B RID: 11307
		[Token(Token = "0x1700068A")]
		NegotiationData NegotiationResult { [Token(Token = "0x6002C2B")] get; }

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002C2C RID: 11308
		// (set) Token: 0x06002C2D RID: 11309
		[Token(Token = "0x1700068B")]
		IJsonEncoder JsonEncoder { [Token(Token = "0x6002C2C")] get; [Token(Token = "0x6002C2D")] set; }

		// Token: 0x06002C2E RID: 11310
		[Token(Token = "0x6002C2E")]
		void OnMessage(IServerMessage msg);

		// Token: 0x06002C2F RID: 11311
		[Token(Token = "0x6002C2F")]
		void TransportStarted();

		// Token: 0x06002C30 RID: 11312
		[Token(Token = "0x6002C30")]
		void TransportReconnected();

		// Token: 0x06002C31 RID: 11313
		[Token(Token = "0x6002C31")]
		void TransportAborted();

		// Token: 0x06002C32 RID: 11314
		[Token(Token = "0x6002C32")]
		void Error(string reason);

		// Token: 0x06002C33 RID: 11315
		[Token(Token = "0x6002C33")]
		Uri BuildUri(RequestTypes type);

		// Token: 0x06002C34 RID: 11316
		[Token(Token = "0x6002C34")]
		Uri BuildUri(RequestTypes type, TransportBase transport);

		// Token: 0x06002C35 RID: 11317
		[Token(Token = "0x6002C35")]
		HTTPRequest PrepareRequest(HTTPRequest req, RequestTypes type);

		// Token: 0x06002C36 RID: 11318
		[Token(Token = "0x6002C36")]
		string ParseResponse(string responseStr);
	}
}
