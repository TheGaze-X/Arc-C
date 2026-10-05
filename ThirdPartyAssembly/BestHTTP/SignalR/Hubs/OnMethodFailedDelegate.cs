using System;
using BestHTTP.SignalR.Messages;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Hubs
{
	// Token: 0x02000552 RID: 1362
	// (Invoke) Token: 0x06002D3D RID: 11581
	[Token(Token = "0x2000552")]
	public delegate void OnMethodFailedDelegate(Hub hub, ClientMessage originalMessage, FailureMessage error);
}
