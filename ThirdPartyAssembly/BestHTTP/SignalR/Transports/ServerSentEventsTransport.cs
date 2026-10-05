using System;
using BestHTTP.ServerSentEvents;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Transports
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	public sealed class ServerSentEventsTransport : PostSendTransportBase
	{
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[Token(Token = "0x170006AC")]
		public override bool SupportsKeepAlive
		{
			[Token(Token = "0x6002CB3")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x00012BB8 File Offset: 0x00010DB8
		[Token(Token = "0x170006AD")]
		public override TransportTypes Type
		{
			[Token(Token = "0x6002CB4")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "5")]
			get
			{
				return TransportTypes.WebSocket;
			}
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB5")]
		[Address(RVA = "0x53F5CC0", Offset = "0x53F48C0", VA = "0x1853F5CC0")]
		public ServerSentEventsTransport(Connection con)
		{
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB6")]
		[Address(RVA = "0x53F51D0", Offset = "0x53F3DD0", VA = "0x1853F51D0", Slot = "6")]
		public override void Connect()
		{
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB7")]
		[Address(RVA = "0x53F5AF0", Offset = "0x53F46F0", VA = "0x1853F5AF0", Slot = "7")]
		public override void Stop()
		{
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		protected override void Started()
		{
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB9")]
		[Address(RVA = "0x53F4FD0", Offset = "0x53F3BD0", VA = "0x1853F4FD0", Slot = "11")]
		public override void Abort()
		{
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBA")]
		[Address(RVA = "0x53F5190", Offset = "0x53F3D90", VA = "0x1853F5190", Slot = "10")]
		protected override void Aborted()
		{
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBB")]
		[Address(RVA = "0x53F5A30", Offset = "0x53F4630", VA = "0x1853F5A30")]
		private void OnEventSourceOpen(EventSource eventSource)
		{
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBC")]
		[Address(RVA = "0x53F5960", Offset = "0x53F4560", VA = "0x1853F5960")]
		private void OnEventSourceMessage(EventSource eventSource, Message message)
		{
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBD")]
		[Address(RVA = "0x53F57E0", Offset = "0x53F43E0", VA = "0x1853F57E0")]
		private void OnEventSourceError(EventSource eventSource, string error)
		{
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBE")]
		[Address(RVA = "0x53F55B0", Offset = "0x53F41B0", VA = "0x1853F55B0")]
		private void OnEventSourceClosed(EventSource eventSource)
		{
		}

		// Token: 0x04001950 RID: 6480
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x38")]
		private EventSource EventSource;
	}
}
