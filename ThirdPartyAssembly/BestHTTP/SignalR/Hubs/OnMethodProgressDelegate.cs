using System;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Hubs
{
	// Token: 0x02000553 RID: 1363
	// (Invoke) Token: 0x06002D41 RID: 11585
	[Token(Token = "0x2000553")]
	public delegate void OnMethodProgressDelegate(Hub hub, ClientMessage originialMessage, ProgressMessage progress);
}
