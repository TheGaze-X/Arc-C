using System;
using BestHTTP.SignalR.Hubs;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Messages
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	public struct ClientMessage
	{
		// Token: 0x06002CEB RID: 11499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0x53E2A90", Offset = "0x53E1690", VA = "0x1853E2A90")]
		public ClientMessage(Hub hub, string method, object[] args, ulong callIdx, OnMethodResultDelegate resultCallback, OnMethodFailedDelegate resultErrorCallback, OnMethodProgressDelegate progressCallback)
		{
		}

		// Token: 0x04001959 RID: 6489
		[Token(Token = "0x4001959")]
		[FieldOffset(Offset = "0x0")]
		public readonly Hub Hub;

		// Token: 0x0400195A RID: 6490
		[Token(Token = "0x400195A")]
		[FieldOffset(Offset = "0x8")]
		public readonly string Method;

		// Token: 0x0400195B RID: 6491
		[Token(Token = "0x400195B")]
		[FieldOffset(Offset = "0x10")]
		public readonly object[] Args;

		// Token: 0x0400195C RID: 6492
		[Token(Token = "0x400195C")]
		[FieldOffset(Offset = "0x18")]
		public readonly ulong CallIdx;

		// Token: 0x0400195D RID: 6493
		[Token(Token = "0x400195D")]
		[FieldOffset(Offset = "0x20")]
		public readonly OnMethodResultDelegate ResultCallback;

		// Token: 0x0400195E RID: 6494
		[Token(Token = "0x400195E")]
		[FieldOffset(Offset = "0x28")]
		public readonly OnMethodFailedDelegate ResultErrorCallback;

		// Token: 0x0400195F RID: 6495
		[Token(Token = "0x400195F")]
		[FieldOffset(Offset = "0x30")]
		public readonly OnMethodProgressDelegate ProgressCallback;
	}
}
