using System;
using BestHTTP.WebSocket.Frames;
using Il2CppDummyDll;

namespace BestHTTP.WebSocket
{
	// Token: 0x020004B5 RID: 1205
	// (Invoke) Token: 0x060027B6 RID: 10166
	[Token(Token = "0x20004B5")]
	public delegate void OnWebSocketIncompleteFrameDelegate(WebSocket webSocket, WebSocketFrameReader frame);
}
