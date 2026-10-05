using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.Extensions;
using BestHTTP.SocketIO.JsonEncoders;
using BestHTTP.SocketIO.Transports;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO
{
	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	public sealed class SocketManager : IHeartbeat, IManager
	{
		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000126F0 File Offset: 0x000108F0
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065D")]
		public SocketManager.States State
		{
			[Token(Token = "0x6002B73")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return SocketManager.States.Initial;
			}
			[Token(Token = "0x6002B74")]
			[Address(RVA = "0x53DA840", Offset = "0x53D9440", VA = "0x1853DA840")]
			private set
			{
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B76 RID: 11126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065E")]
		public SocketOptions Options
		{
			[Token(Token = "0x6002B75")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B76")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B78 RID: 11128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065F")]
		public Uri Uri
		{
			[Token(Token = "0x6002B77")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B78")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B7A RID: 11130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000660")]
		public HandshakeData Handshake
		{
			[Token(Token = "0x6002B79")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B7A")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B7C RID: 11132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000661")]
		public ITransport Transport
		{
			[Token(Token = "0x6002B7B")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B7C")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x00012708 File Offset: 0x00010908
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000662")]
		public ulong RequestCounter
		{
			[Token(Token = "0x6002B7D")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002B7E")]
			[Address(RVA = "0x1796DB0", Offset = "0x17959B0", VA = "0x181796DB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000663")]
		public Socket Socket
		{
			[Token(Token = "0x6002B7F")]
			[Address(RVA = "0x53D9CE0", Offset = "0x53D88E0", VA = "0x1853D9CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000664 RID: 1636
		[Token(Token = "0x17000664")]
		public Socket this[string nsp]
		{
			[Token(Token = "0x6002B80")]
			[Address(RVA = "0x53DA740", Offset = "0x53D9340", VA = "0x1853DA740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x00012720 File Offset: 0x00010920
		// (set) Token: 0x06002B82 RID: 11138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000665")]
		public int ReconnectAttempts
		{
			[Token(Token = "0x6002B81")]
			[Address(RVA = "0x6DF220", Offset = "0x6DDE20", VA = "0x1806DF220")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002B82")]
			[Address(RVA = "0xE30780", Offset = "0xE2F380", VA = "0x180E30780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000666")]
		public IJsonEncoder Encoder
		{
			[Token(Token = "0x6002B83")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B84")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x00012738 File Offset: 0x00010938
		[Token(Token = "0x17000667")]
		internal uint Timestamp
		{
			[Token(Token = "0x6002B85")]
			[Address(RVA = "0x53DA760", Offset = "0x53D9360", VA = "0x1853DA760")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x17000668")]
		internal int NextAckId
		{
			[Token(Token = "0x6002B86")]
			[Address(RVA = "0x53DA750", Offset = "0x53D9350", VA = "0x1853DA750")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x00012768 File Offset: 0x00010968
		// (set) Token: 0x06002B88 RID: 11144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000669")]
		internal SocketManager.States PreviousState
		{
			[Token(Token = "0x6002B87")]
			[Address(RVA = "0x4FA5A00", Offset = "0x4FA4600", VA = "0x184FA5A00")]
			[CompilerGenerated]
			get
			{
				return SocketManager.States.Initial;
			}
			[Token(Token = "0x6002B88")]
			[Address(RVA = "0x53DA830", Offset = "0x53D9430", VA = "0x1853DA830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700066A")]
		internal ITransport UpgradingTransport
		{
			[Token(Token = "0x6002B89")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B8A")]
			[Address(RVA = "0x514D10", Offset = "0x513910", VA = "0x180514D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8B")]
		[Address(RVA = "0x53DA2C0", Offset = "0x53D8EC0", VA = "0x1853DA2C0")]
		public SocketManager(Uri uri)
		{
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x53DA590", Offset = "0x53D9190", VA = "0x1853DA590")]
		public SocketManager(Uri uri, SocketOptions options)
		{
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x53D9CE0", Offset = "0x53D88E0", VA = "0x1853D9CE0")]
		public Socket GetSocket()
		{
			return null;
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B8E")]
		[Address(RVA = "0x53D9A80", Offset = "0x53D8680", VA = "0x1853D9A80")]
		public Socket GetSocket(string nsp)
		{
			return null;
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8F")]
		[Address(RVA = "0x53D91B0", Offset = "0x53D7DB0", VA = "0x1853D91B0", Slot = "5")]
		private void Remove(Socket socket)
		{
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B90")]
		[Address(RVA = "0x53D9D20", Offset = "0x53D8920", VA = "0x1853D9D20")]
		public void Open()
		{
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B91")]
		[Address(RVA = "0x53D9960", Offset = "0x53D8560", VA = "0x1853D9960")]
		public void Close()
		{
		}

		// Token: 0x06002B92 RID: 11154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B92")]
		[Address(RVA = "0x53D8230", Offset = "0x53D6E30", VA = "0x1853D8230", Slot = "6")]
		private void Close(bool removeSockets)
		{
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B93")]
		[Address(RVA = "0x53D9510", Offset = "0x53D8110", VA = "0x1853D9510", Slot = "7")]
		private void TryToReconnect()
		{
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00012780 File Offset: 0x00010980
		[Token(Token = "0x6002B94")]
		[Address(RVA = "0x53D8DF0", Offset = "0x53D79F0", VA = "0x1853D8DF0", Slot = "8")]
		private bool OnTransportConnected(ITransport trans)
		{
			return default(bool);
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B95")]
		[Address(RVA = "0x53D9020", Offset = "0x53D7C20", VA = "0x1853D9020", Slot = "9")]
		private void OnTransportError(ITransport trans, string err)
		{
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B96")]
		[Address(RVA = "0x53D90C0", Offset = "0x53D7CC0", VA = "0x1853D90C0", Slot = "10")]
		private void OnTransportProbed(ITransport trans)
		{
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B97")]
		[Address(RVA = "0x53DA030", Offset = "0x53D8C30", VA = "0x1853DA030")]
		private ITransport SelectTransport()
		{
			return null;
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B98")]
		[Address(RVA = "0x53DA0A0", Offset = "0x53D8CA0", VA = "0x1853DA0A0")]
		private void SendOfflinePackets()
		{
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B99")]
		[Address(RVA = "0x53D9280", Offset = "0x53D7E80", VA = "0x1853D9280", Slot = "11")]
		private void SendPacket(Packet packet)
		{
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9A")]
		[Address(RVA = "0x53D8A10", Offset = "0x53D7610", VA = "0x1853D8A10", Slot = "12")]
		private void OnPacket(Packet packet)
		{
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9B")]
		[Address(RVA = "0x53D99B0", Offset = "0x53D85B0", VA = "0x1853D99B0")]
		public void EmitAll(string eventName, params object[] args)
		{
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9C")]
		[Address(RVA = "0x53D8950", Offset = "0x53D7550", VA = "0x1853D8950", Slot = "13")]
		private void EmitEvent(string eventName, params object[] args)
		{
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9D")]
		[Address(RVA = "0x53D88C0", Offset = "0x53D74C0", VA = "0x1853D88C0", Slot = "14")]
		private void EmitEvent(SocketIOEventTypes type, params object[] args)
		{
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9E")]
		[Address(RVA = "0x53D87A0", Offset = "0x53D73A0", VA = "0x1853D87A0", Slot = "15")]
		private void EmitError(SocketIOErrors errCode, string msg)
		{
		}

		// Token: 0x06002B9F RID: 11167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B9F")]
		[Address(RVA = "0x53D8630", Offset = "0x53D7230", VA = "0x1853D8630", Slot = "16")]
		private void EmitAll(string eventName, params object[] args)
		{
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA0")]
		[Address(RVA = "0x53D7BC0", Offset = "0x53D67C0", VA = "0x1853D7BC0", Slot = "4")]
		private void OnHeartbeatUpdate(TimeSpan dif)
		{
		}

		// Token: 0x0400189C RID: 6300
		[Token(Token = "0x400189C")]
		[FieldOffset(Offset = "0x0")]
		public static IJsonEncoder DefaultEncoder;

		// Token: 0x0400189D RID: 6301
		[Token(Token = "0x400189D")]
		public const int MinProtocolVersion = 4;

		// Token: 0x0400189E RID: 6302
		[Token(Token = "0x400189E")]
		[FieldOffset(Offset = "0x10")]
		private SocketManager.States state;

		// Token: 0x040018A6 RID: 6310
		[Token(Token = "0x40018A6")]
		[FieldOffset(Offset = "0x50")]
		private int nextAckId;

		// Token: 0x040018A9 RID: 6313
		[Token(Token = "0x40018A9")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, Socket> Namespaces;

		// Token: 0x040018AA RID: 6314
		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x68")]
		private List<Socket> Sockets;

		// Token: 0x040018AB RID: 6315
		[Token(Token = "0x40018AB")]
		[FieldOffset(Offset = "0x70")]
		private List<Packet> OfflinePackets;

		// Token: 0x040018AC RID: 6316
		[Token(Token = "0x40018AC")]
		[FieldOffset(Offset = "0x78")]
		private DateTime LastHeartbeat;

		// Token: 0x040018AD RID: 6317
		[Token(Token = "0x40018AD")]
		[FieldOffset(Offset = "0x80")]
		private DateTime LastPongReceived;

		// Token: 0x040018AE RID: 6318
		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x88")]
		private DateTime ReconnectAt;

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x90")]
		private DateTime ConnectionStarted;

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x98")]
		private bool closing;

		// Token: 0x0200051E RID: 1310
		[Token(Token = "0x200051E")]
		public enum States
		{
			// Token: 0x040018B2 RID: 6322
			[Token(Token = "0x40018B2")]
			Initial,
			// Token: 0x040018B3 RID: 6323
			[Token(Token = "0x40018B3")]
			Closed,
			// Token: 0x040018B4 RID: 6324
			[Token(Token = "0x40018B4")]
			Opening,
			// Token: 0x040018B5 RID: 6325
			[Token(Token = "0x40018B5")]
			Open,
			// Token: 0x040018B6 RID: 6326
			[Token(Token = "0x40018B6")]
			Paused,
			// Token: 0x040018B7 RID: 6327
			[Token(Token = "0x40018B7")]
			Reconnecting
		}
	}
}
