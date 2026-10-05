using System;
using BestHTTP.WebSocket.Frames;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket.Extensions
{
	// Token: 0x020004BC RID: 1212
	[Token(Token = "0x20004BC")]
	public interface IExtension
	{
		// Token: 0x06002810 RID: 10256
		[Token(Token = "0x6002810")]
		void AddNegotiation(HTTPRequest request);

		// Token: 0x06002811 RID: 10257
		[Token(Token = "0x6002811")]
		bool ParseNegotiation(WebSocketResponse resp);

		// Token: 0x06002812 RID: 10258
		[Token(Token = "0x6002812")]
		byte GetFrameHeader(WebSocketFrame writer, byte inFlag);

		// Token: 0x06002813 RID: 10259
		[Token(Token = "0x6002813")]
		byte[] Encode(WebSocketFrame writer);

		// Token: 0x06002814 RID: 10260
		[Token(Token = "0x6002814")]
		byte[] Decode(byte header, byte[] data);
	}
}
