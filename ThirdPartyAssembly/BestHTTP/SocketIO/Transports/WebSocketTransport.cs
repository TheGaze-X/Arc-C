using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BestHTTP.WebSocket;
using Il2CppDummyDll;

namespace BestHTTP.SocketIO.Transports
{
	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	internal sealed class WebSocketTransport : ITransport
	{
		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000128D0 File Offset: 0x00010AD0
		[Token(Token = "0x1700067F")]
		public TransportTypes Type
		{
			[Token(Token = "0x6002BD4")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "4")]
			get
			{
				return TransportTypes.Polling;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x000128E8 File Offset: 0x00010AE8
		// (set) Token: 0x06002BD6 RID: 11222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000680")]
		public TransportStates State
		{
			[Token(Token = "0x6002BD5")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return TransportStates.Connecting;
			}
			[Token(Token = "0x6002BD6")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002BD7 RID: 11223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002BD8 RID: 11224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000681")]
		public SocketManager Manager
		{
			[Token(Token = "0x6002BD7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BD8")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002BD9 RID: 11225 RVA: 0x00012900 File Offset: 0x00010B00
		[Token(Token = "0x17000682")]
		public bool IsRequestInProgress
		{
			[Token(Token = "0x6002BD9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x00012918 File Offset: 0x00010B18
		[Token(Token = "0x17000683")]
		public bool IsPollingInProgress
		{
			[Token(Token = "0x6002BDA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002BDB RID: 11227 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002BDC RID: 11228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000684")]
		public WebSocket Implementation
		{
			[Token(Token = "0x6002BDB")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BDC")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x53FB4C0", Offset = "0x53FA0C0", VA = "0x1853FB4C0")]
		public WebSocketTransport(SocketManager manager)
		{
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDE")]
		[Address(RVA = "0x53FA4A0", Offset = "0x53F90A0", VA = "0x1853FA4A0", Slot = "9")]
		public void Open()
		{
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BDF")]
		[Address(RVA = "0x53F9100", Offset = "0x53F7D00", VA = "0x1853F9100", Slot = "13")]
		public void Close()
		{
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		public void Poll()
		{
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE1")]
		[Address(RVA = "0x53FA110", Offset = "0x53F8D10", VA = "0x1853FA110")]
		private void OnOpen(WebSocket ws)
		{
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE2")]
		[Address(RVA = "0x53F9F20", Offset = "0x53F8B20", VA = "0x1853F9F20")]
		private void OnMessage(WebSocket ws, string message)
		{
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE3")]
		[Address(RVA = "0x53F96E0", Offset = "0x53F82E0", VA = "0x1853F96E0")]
		private void OnBinary(WebSocket ws, byte[] data)
		{
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x53F9B10", Offset = "0x53F8710", VA = "0x1853F9B10")]
		private void OnError(WebSocket ws, Exception ex)
		{
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x53F9940", Offset = "0x53F8540", VA = "0x1853F9940")]
		private void OnClosed(WebSocket ws, ushort code, string message)
		{
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x53FAC20", Offset = "0x53F9820", VA = "0x1853FAC20", Slot = "11")]
		public void Send(Packet packet)
		{
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x53FAB60", Offset = "0x53F9760", VA = "0x1853FAB60", Slot = "12")]
		public void Send(List<Packet> packets)
		{
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x53FA260", Offset = "0x53F8E60", VA = "0x1853FA260")]
		private void OnPacket(Packet packet)
		{
		}

		// Token: 0x040018D8 RID: 6360
		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x28")]
		private Packet PacketWithAttachment;

		// Token: 0x040018D9 RID: 6361
		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0x30")]
		private byte[] Buffer;
	}
}
