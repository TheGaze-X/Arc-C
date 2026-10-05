using System;
using BestHTTP.Extensions;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Transports
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	public sealed class PollingTransport : PostSendTransportBase, IHeartbeat
	{
		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x170006AA")]
		public override bool SupportsKeepAlive
		{
			[Token(Token = "0x6002CA5")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x00012B88 File Offset: 0x00010D88
		[Token(Token = "0x170006AB")]
		public override TransportTypes Type
		{
			[Token(Token = "0x6002CA6")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "5")]
			get
			{
				return TransportTypes.WebSocket;
			}
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA7")]
		[Address(RVA = "0x53F3C70", Offset = "0x53F2870", VA = "0x1853F3C70")]
		public PollingTransport(Connection connection)
		{
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA8")]
		[Address(RVA = "0x53F3010", Offset = "0x53F1C10", VA = "0x1853F3010", Slot = "6")]
		public override void Connect()
		{
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA9")]
		[Address(RVA = "0x53F3BE0", Offset = "0x53F27E0", VA = "0x1853F3BE0", Slot = "7")]
		public override void Stop()
		{
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAA")]
		[Address(RVA = "0x53F3B50", Offset = "0x53F2750", VA = "0x1853F3B50", Slot = "9")]
		protected override void Started()
		{
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAB")]
		[Address(RVA = "0x53F2D80", Offset = "0x53F1980", VA = "0x1853F2D80", Slot = "10")]
		protected override void Aborted()
		{
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAC")]
		[Address(RVA = "0x53F3210", Offset = "0x53F1E10", VA = "0x1853F3210")]
		private void OnConnectRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAD")]
		[Address(RVA = "0x53F35B0", Offset = "0x53F21B0", VA = "0x1853F35B0")]
		private void OnPollRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAE")]
		[Address(RVA = "0x53F39F0", Offset = "0x53F25F0", VA = "0x1853F39F0")]
		private void Poll()
		{
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAF")]
		[Address(RVA = "0x53F2DE0", Offset = "0x53F19E0", VA = "0x1853F2DE0", Slot = "12")]
		private void OnHeartbeatUpdate(TimeSpan dif)
		{
		}

		// Token: 0x0400194B RID: 6475
		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x38")]
		private DateTime LastPoll;

		// Token: 0x0400194C RID: 6476
		[Token(Token = "0x400194C")]
		[FieldOffset(Offset = "0x40")]
		private TimeSpan PollDelay;

		// Token: 0x0400194D RID: 6477
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x48")]
		private TimeSpan PollTimeout;

		// Token: 0x0400194E RID: 6478
		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x50")]
		private HTTPRequest pollRequest;
	}
}
