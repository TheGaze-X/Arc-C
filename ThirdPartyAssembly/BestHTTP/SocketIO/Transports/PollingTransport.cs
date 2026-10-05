using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO.Transports
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	internal sealed class PollingTransport : ITransport
	{
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x00012870 File Offset: 0x00010A70
		[Token(Token = "0x1700067A")]
		public TransportTypes Type
		{
			[Token(Token = "0x6002BC3")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return TransportTypes.Polling;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x00012888 File Offset: 0x00010A88
		// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067B")]
		public TransportStates State
		{
			[Token(Token = "0x6002BC4")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return TransportStates.Connecting;
			}
			[Token(Token = "0x6002BC5")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067C")]
		public SocketManager Manager
		{
			[Token(Token = "0x6002BC6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BC7")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x000128A0 File Offset: 0x00010AA0
		[Token(Token = "0x1700067D")]
		public bool IsRequestInProgress
		{
			[Token(Token = "0x6002BC8")]
			[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x000128B8 File Offset: 0x00010AB8
		[Token(Token = "0x1700067E")]
		public bool IsPollingInProgress
		{
			[Token(Token = "0x6002BC9")]
			[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCA")]
		[Address(RVA = "0x53D7B10", Offset = "0x53D6710", VA = "0x1853D7B10")]
		public PollingTransport(SocketManager manager)
		{
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x53D6490", Offset = "0x53D5090", VA = "0x1853D6490", Slot = "9")]
		public void Open()
		{
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x53D59A0", Offset = "0x53D45A0", VA = "0x1853D59A0", Slot = "13")]
		public void Close()
		{
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCD")]
		[Address(RVA = "0x53D72D0", Offset = "0x53D5ED0", VA = "0x1853D72D0", Slot = "11")]
		public void Send(Packet packet)
		{
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCE")]
		[Address(RVA = "0x53D73E0", Offset = "0x53D5FE0", VA = "0x1853D73E0", Slot = "12")]
		public void Send(List<Packet> packets)
		{
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCF")]
		[Address(RVA = "0x53D6000", Offset = "0x53D4C00", VA = "0x1853D6000")]
		private void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD0")]
		[Address(RVA = "0x53D6E40", Offset = "0x53D5A40", VA = "0x1853D6E40", Slot = "10")]
		public void Poll()
		{
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD1")]
		[Address(RVA = "0x53D5B70", Offset = "0x53D4770", VA = "0x1853D5B70")]
		private void OnPollRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0x53D59B0", Offset = "0x53D45B0", VA = "0x1853D59B0")]
		private void OnPacket(Packet packet)
		{
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD3")]
		[Address(RVA = "0x53D6940", Offset = "0x53D5540", VA = "0x1853D6940")]
		private void ParseResponse(HTTPResponse resp)
		{
		}

		// Token: 0x040018CE RID: 6350
		[Token(Token = "0x40018CE")]
		[FieldOffset(Offset = "0x20")]
		private HTTPRequest LastRequest;

		// Token: 0x040018CF RID: 6351
		[Token(Token = "0x40018CF")]
		[FieldOffset(Offset = "0x28")]
		private HTTPRequest PollRequest;

		// Token: 0x040018D0 RID: 6352
		[Token(Token = "0x40018D0")]
		[FieldOffset(Offset = "0x30")]
		private Packet PacketWithAttachment;

		// Token: 0x040018D1 RID: 6353
		[Token(Token = "0x40018D1")]
		[FieldOffset(Offset = "0x38")]
		private List<Packet> lonelyPacketList;

		// Token: 0x02000524 RID: 1316
		[Token(Token = "0x2000524")]
		private enum PayloadTypes : byte
		{
			// Token: 0x040018D3 RID: 6355
			[Token(Token = "0x40018D3")]
			Text,
			// Token: 0x040018D4 RID: 6356
			[Token(Token = "0x40018D4")]
			Binary
		}
	}
}
