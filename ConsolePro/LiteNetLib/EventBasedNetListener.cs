using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class EventBasedNetListener : INetEventListener, IDeliveryEventListener, INtpEventListener
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event EventBasedNetListener.OnPeerConnected PeerConnectedEvent
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x3699290", Offset = "0x3697E90", VA = "0x183699290")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x3699830", Offset = "0x3698430", VA = "0x183699830")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event EventBasedNetListener.OnPeerDisconnected PeerDisconnectedEvent
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x3699330", Offset = "0x3697F30", VA = "0x183699330")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x36998D0", Offset = "0x36984D0", VA = "0x1836998D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public event EventBasedNetListener.OnNetworkError NetworkErrorEvent
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x3698F70", Offset = "0x3697B70", VA = "0x183698F70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x3699510", Offset = "0x3698110", VA = "0x183699510")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000004")]
		public event EventBasedNetListener.OnNetworkReceive NetworkReceiveEvent
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x36990B0", Offset = "0x3697CB0", VA = "0x1836990B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x3699650", Offset = "0x3698250", VA = "0x183699650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000005")]
		public event EventBasedNetListener.OnNetworkReceiveUnconnected NetworkReceiveUnconnectedEvent
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x3699150", Offset = "0x3697D50", VA = "0x183699150")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x36996F0", Offset = "0x36982F0", VA = "0x1836996F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public event EventBasedNetListener.OnNetworkLatencyUpdate NetworkLatencyUpdateEvent
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x3699010", Offset = "0x3697C10", VA = "0x183699010")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x36995B0", Offset = "0x36981B0", VA = "0x1836995B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		public event EventBasedNetListener.OnConnectionRequest ConnectionRequestEvent
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x3698E30", Offset = "0x3697A30", VA = "0x183698E30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x36993D0", Offset = "0x3697FD0", VA = "0x1836993D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		public event EventBasedNetListener.OnDeliveryEvent DeliveryEvent
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x3698ED0", Offset = "0x3697AD0", VA = "0x183698ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x3699470", Offset = "0x3698070", VA = "0x183699470")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public event EventBasedNetListener.OnNtpResponseEvent NtpResponseEvent
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x36991F0", Offset = "0x3697DF0", VA = "0x1836991F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x3699790", Offset = "0x3698390", VA = "0x183699790")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1DEED20", Offset = "0x1DED920", VA = "0x181DEED20")]
		public void ClearPeerConnectedEvent()
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x3698D80", Offset = "0x3697980", VA = "0x183698D80")]
		public void ClearPeerDisconnectedEvent()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003C")]
		[Address(RVA = "0xC96C40", Offset = "0xC95840", VA = "0x180C96C40")]
		public void ClearNetworkErrorEvent()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x22F73B0", Offset = "0x22F5FB0", VA = "0x1822F73B0")]
		public void ClearNetworkReceiveEvent()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003E")]
		[Address(RVA = "0xFB1430", Offset = "0xFB0030", VA = "0x180FB1430")]
		public void ClearNetworkReceiveUnconnectedEvent()
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3698D40", Offset = "0x3697940", VA = "0x183698D40")]
		public void ClearNetworkLatencyUpdateEvent()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x3698D20", Offset = "0x3697920", VA = "0x183698D20")]
		public void ClearConnectionRequestEvent()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		[Address(RVA = "0xFD6420", Offset = "0xFD5020", VA = "0x180FD6420")]
		public void ClearDeliveryEvent()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x3698D60", Offset = "0x3697960", VA = "0x183698D60")]
		public void ClearNtpResponseEvent()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x103A620", Offset = "0x1039220", VA = "0x18103A620", Slot = "4")]
		private void OnPeerConnected(NetPeer peer)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3698E00", Offset = "0x3697A00", VA = "0x183698E00", Slot = "5")]
		private void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x926B20", Offset = "0x925720", VA = "0x180926B20", Slot = "6")]
		private void OnNetworkError(IPEndPoint endPoint, SocketError socketErrorCode)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x3698DE0", Offset = "0x36979E0", VA = "0x183698DE0", Slot = "7")]
		private void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x3698DC0", Offset = "0x36979C0", VA = "0x183698DC0", Slot = "8")]
		private void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3698DA0", Offset = "0x36979A0", VA = "0x183698DA0", Slot = "9")]
		private void OnNetworkLatencyUpdate(NetPeer peer, int latency)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2585D60", Offset = "0x2584960", VA = "0x182585D60", Slot = "10")]
		private void OnConnectionRequest(ConnectionRequest request)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x337C150", Offset = "0x337AD50", VA = "0x18337C150", Slot = "11")]
		private void OnMessageDelivered(NetPeer peer, object userData)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x31E52E0", Offset = "0x31E3EE0", VA = "0x1831E52E0", Slot = "12")]
		private void OnNtpResponse(NtpPacket packet)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EventBasedNetListener()
		{
		}

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600004E RID: 78
		[Token(Token = "0x200000E")]
		public delegate void OnPeerConnected(NetPeer peer);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x06000052 RID: 82
		[Token(Token = "0x200000F")]
		public delegate void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000056 RID: 86
		[Token(Token = "0x2000010")]
		public delegate void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x0600005A RID: 90
		[Token(Token = "0x2000011")]
		public delegate void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x0600005E RID: 94
		[Token(Token = "0x2000012")]
		public delegate void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x06000062 RID: 98
		[Token(Token = "0x2000013")]
		public delegate void OnNetworkLatencyUpdate(NetPeer peer, int latency);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000066 RID: 102
		[Token(Token = "0x2000014")]
		public delegate void OnConnectionRequest(ConnectionRequest request);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x0600006A RID: 106
		[Token(Token = "0x2000015")]
		public delegate void OnDeliveryEvent(NetPeer peer, object userData);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x0600006E RID: 110
		[Token(Token = "0x2000016")]
		public delegate void OnNtpResponseEvent(NtpPacket packet);
	}
}
