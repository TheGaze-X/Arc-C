using System;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Hubs
{
	// Token: 0x02000551 RID: 1361
	// (Invoke) Token: 0x06002D39 RID: 11577
	[Token(Token = "0x2000551")]
	public delegate void OnMethodResultDelegate(Hub hub, ClientMessage originalMessage, ResultMessage result);
}
