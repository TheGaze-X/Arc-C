using System;
using BestHTTP.WebSocket;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Transports
{
	// Token: 0x02000544 RID: 1348
	[Token(Token = "0x2000544")]
	public sealed class WebSocketTransport : TransportBase
	{
		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x00012C00 File Offset: 0x00010E00
		[Token(Token = "0x170006B3")]
		public override bool SupportsKeepAlive
		{
			[Token(Token = "0x6002CDF")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x00012C18 File Offset: 0x00010E18
		[Token(Token = "0x170006B4")]
		public override TransportTypes Type
		{
			[Token(Token = "0x6002CE0")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return TransportTypes.WebSocket;
			}
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE1")]
		[Address(RVA = "0x53FB500", Offset = "0x53FA100", VA = "0x1853FB500")]
		public WebSocketTransport(Connection connection)
		{
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE2")]
		[Address(RVA = "0x53F91E0", Offset = "0x53F7DE0", VA = "0x1853F91E0", Slot = "6")]
		public override void Connect()
		{
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE3")]
		[Address(RVA = "0x53FAB10", Offset = "0x53F9710", VA = "0x1853FAB10", Slot = "8")]
		protected override void SendImpl(string json)
		{
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE4")]
		[Address(RVA = "0x53FB020", Offset = "0x53F9C20", VA = "0x1853FB020", Slot = "7")]
		public override void Stop()
		{
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected override void Started()
		{
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE6")]
		[Address(RVA = "0x53F90B0", Offset = "0x53F7CB0", VA = "0x1853F90B0", Slot = "10")]
		protected override void Aborted()
		{
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE7")]
		[Address(RVA = "0x53FB400", Offset = "0x53FA000", VA = "0x1853FB400")]
		private void WSocket_OnOpen(WebSocket webSocket)
		{
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE8")]
		[Address(RVA = "0x53FB360", Offset = "0x53F9F60", VA = "0x1853FB360")]
		private void WSocket_OnMessage(WebSocket webSocket, string message)
		{
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x53FB0C0", Offset = "0x53F9CC0", VA = "0x1853FB0C0")]
		private void WSocket_OnClosed(WebSocket webSocket, ushort code, string message)
		{
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0x53FB240", Offset = "0x53F9E40", VA = "0x1853FB240")]
		private void WSocket_OnError(WebSocket webSocket, string reason)
		{
		}

		// Token: 0x04001958 RID: 6488
		[Token(Token = "0x4001958")]
		[FieldOffset(Offset = "0x30")]
		private WebSocket wSocket;
	}
}
