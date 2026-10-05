using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using FlyingWormConsole3.LiteNetLib.Layers;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public class NetManager : IEnumerable<NetPeer>, IEnumerable
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x1700000A")]
		public bool IsRunning
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x36A5570", Offset = "0x36A4170", VA = "0x1836A5570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000AF RID: 175 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x1700000B")]
		public int LocalPort
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1C4A630", Offset = "0x1C49230", VA = "0x181C4A630")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700000C")]
		public NetPeer FirstPeer
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x36A5550", Offset = "0x36A4150", VA = "0x1836A5550")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		public byte ChannelsCount
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x51CBE0", Offset = "0x51B7E0", VA = "0x18051CBE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x36A55A0", Offset = "0x36A41A0", VA = "0x1836A55A0")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x1700000E")]
		public List<NetPeer> ConnectedPeerList
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x36A5420", Offset = "0x36A4020", VA = "0x1836A5420")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x36A1780", Offset = "0x36A0380", VA = "0x1836A1780")]
		public NetPeer GetPeerById(int id)
		{
			return null;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x1700000F")]
		public int ConnectedPeersCount
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x36A5510", Offset = "0x36A4110", VA = "0x1836A5510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000010")]
		public int ExtraPacketSizeForLayer
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x36A5530", Offset = "0x36A4130", VA = "0x1836A5530")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x36A4B20", Offset = "0x36A3720", VA = "0x1836A4B20")]
		private bool TryGetPeer(IPEndPoint endPoint, out NetPeer peer)
		{
			return default(bool);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x369F4F0", Offset = "0x369E0F0", VA = "0x18369F4F0")]
		private void AddPeer(NetPeer peer)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x36A34B0", Offset = "0x36A20B0", VA = "0x1836A34B0")]
		private void RemovePeer(NetPeer peer)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x36A32C0", Offset = "0x36A1EC0", VA = "0x1836A32C0")]
		private void RemovePeerInternal(NetPeer peer)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x36A4E20", Offset = "0x36A3A20", VA = "0x1836A4E20")]
		public NetManager(INetEventListener listener, [Optional] PacketLayerBase extraPacketLayer)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x369FAD0", Offset = "0x369E6D0", VA = "0x18369FAD0")]
		internal void ConnectionLatencyUpdated(NetPeer fromPeer, int latency)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x36A1A30", Offset = "0x36A0630", VA = "0x1836A1A30")]
		internal void MessageDelivered(NetPeer fromPeer, object userData)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x36A37C0", Offset = "0x36A23C0", VA = "0x1836A37C0")]
		internal int SendRawAndRecycle(NetPacket packet, IPEndPoint remoteEndPoint)
		{
			return 0;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x36A3B60", Offset = "0x36A2760", VA = "0x1836A3B60")]
		internal int SendRaw(NetPacket packet, IPEndPoint remoteEndPoint)
		{
			return 0;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x36A3830", Offset = "0x36A2430", VA = "0x1836A3830")]
		internal int SendRaw(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
		{
			return 0;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x36A1180", Offset = "0x369FD80", VA = "0x1836A1180")]
		internal void DisconnectPeerForce(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, NetPacket eventData)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x36A13C0", Offset = "0x369FFC0", VA = "0x1836A13C0")]
		private void DisconnectPeer(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, bool force, byte[] data, int start, int count, NetPacket eventData)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x369FB10", Offset = "0x369E710", VA = "0x18369FB10")]
		private void CreateEvent(NetEvent.EType type, [Optional] NetPeer peer, [Optional] IPEndPoint remoteEndPoint, SocketError errorCode = SocketError.Success, int latency = 0, DisconnectReason disconnectReason = DisconnectReason.ConnectionFailed, [Optional] ConnectionRequest connectionRequest, DeliveryMethod deliveryMethod = DeliveryMethod.Unreliable, [Optional] NetPacket readerSource, [Optional] object userData)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x36A2890", Offset = "0x36A1490", VA = "0x1836A2890")]
		private void ProcessEvent(NetEvent evt)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x36A31C0", Offset = "0x36A1DC0", VA = "0x1836A31C0")]
		internal void RecycleEvent(NetEvent evt)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x36A4BB0", Offset = "0x36A37B0", VA = "0x1836A4BB0")]
		private void UpdateLogic()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("DEBUG")]
		private void ProcessDelayedPackets()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x36A2EA0", Offset = "0x36A1AA0", VA = "0x1836A2EA0")]
		private void ProcessNtpRequests(int elapsedMilliseconds)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x36A19A0", Offset = "0x36A05A0", VA = "0x1836A19A0")]
		public void ManualUpdate(int elapsedMilliseconds)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x36A1930", Offset = "0x36A0530", VA = "0x1836A1930")]
		public void ManualReceive()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x36A2020", Offset = "0x36A0C20", VA = "0x1836A2020")]
		internal void OnMessageReceived(NetPacket packet, SocketError errorCode, IPEndPoint remoteEndPoint)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x36A1A80", Offset = "0x36A0680", VA = "0x1836A1A80")]
		internal NetPeer OnConnectionSolved(ConnectionRequest request, byte[] rejectData, int start, int length)
		{
			return null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x36A1680", Offset = "0x36A0280", VA = "0x1836A1680")]
		private int GetNextPeerId()
		{
			return 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x36A2480", Offset = "0x36A1080", VA = "0x1836A2480")]
		private void ProcessConnectRequest(IPEndPoint remoteEndPoint, NetPeer netPeer, NetConnectRequestPacket connRequest)
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x36A03C0", Offset = "0x369EFC0", VA = "0x1836A03C0")]
		private void DataReceived(NetPacket packet, IPEndPoint remoteEndPoint)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x36A0110", Offset = "0x369ED10", VA = "0x1836A0110")]
		internal void CreateReceiveEvent(NetPacket packet, DeliveryMethod method, int headerSize, NetPeer fromPeer)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x36A3C30", Offset = "0x36A2830", VA = "0x1836A3C30")]
		public void SendToAll(NetDataWriter writer, DeliveryMethod options)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x36A4010", Offset = "0x36A2C10", VA = "0x1836A4010")]
		public void SendToAll(byte[] data, DeliveryMethod options)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x36A3FE0", Offset = "0x36A2BE0", VA = "0x1836A3FE0")]
		public void SendToAll(byte[] data, int start, int length, DeliveryMethod options)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x36A3BA0", Offset = "0x36A27A0", VA = "0x1836A3BA0")]
		public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x36A3DE0", Offset = "0x36A29E0", VA = "0x1836A3DE0")]
		public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x36A3EA0", Offset = "0x36A2AA0", VA = "0x1836A3EA0")]
		public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x36A3E60", Offset = "0x36A2A60", VA = "0x1836A3E60")]
		public void SendToAll(NetDataWriter writer, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x36A3C70", Offset = "0x36A2870", VA = "0x1836A3C70")]
		public void SendToAll(byte[] data, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x36A3FB0", Offset = "0x36A2BB0", VA = "0x1836A3FB0")]
		public void SendToAll(byte[] data, int start, int length, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x36A3BE0", Offset = "0x36A27E0", VA = "0x1836A3BE0")]
		public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x36A3E20", Offset = "0x36A2A20", VA = "0x1836A3E20")]
		public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x36A3CB0", Offset = "0x36A28B0", VA = "0x1836A3CB0")]
		public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options, NetPeer excludePeer)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x36A4330", Offset = "0x36A2F30", VA = "0x1836A4330")]
		public bool Start()
		{
			return default(bool);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x36A44C0", Offset = "0x36A30C0", VA = "0x1836A44C0")]
		public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x36A4420", Offset = "0x36A3020", VA = "0x1836A4420")]
		public bool Start(string addressIPv4, string addressIPv6, int port)
		{
			return default(bool);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x36A43A0", Offset = "0x36A2FA0", VA = "0x1836A43A0")]
		public bool Start(int port)
		{
			return default(bool);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x36A4160", Offset = "0x36A2D60", VA = "0x1836A4160")]
		public bool StartInManualMode(IPAddress addressIPv4, IPAddress addressIPv6, int port)
		{
			return default(bool);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x36A4260", Offset = "0x36A2E60", VA = "0x1836A4260")]
		public bool StartInManualMode(string addressIPv4, string addressIPv6, int port)
		{
			return default(bool);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x36A41B0", Offset = "0x36A2DB0", VA = "0x1836A41B0")]
		public bool StartInManualMode(int port)
		{
			return default(bool);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x36A40F0", Offset = "0x36A2CF0", VA = "0x1836A40F0")]
		public bool SendUnconnectedMessage(byte[] message, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x36A4120", Offset = "0x36A2D20", VA = "0x1836A4120")]
		public bool SendUnconnectedMessage(NetDataWriter writer, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x36A4050", Offset = "0x36A2C50", VA = "0x1836A4050")]
		public bool SendUnconnectedMessage(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
		{
			return default(bool);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x36A3500", Offset = "0x36A2100", VA = "0x1836A3500")]
		public bool SendBroadcast(NetDataWriter writer, int port)
		{
			return default(bool);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x36A3540", Offset = "0x36A2140", VA = "0x1836A3540")]
		public bool SendBroadcast(byte[] data, int port)
		{
			return default(bool);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x36A3570", Offset = "0x36A2170", VA = "0x1836A3570")]
		public bool SendBroadcast(byte[] data, int start, int length, int port)
		{
			return default(bool);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x36A4B00", Offset = "0x36A3700", VA = "0x1836A4B00")]
		public void TriggerUpdate()
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x36A2280", Offset = "0x36A0E80", VA = "0x1836A2280")]
		public void PollEvents()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x369FA80", Offset = "0x369E680", VA = "0x18369FA80")]
		public NetPeer Connect(string address, int port, string key)
		{
			return null;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x369F960", Offset = "0x369E560", VA = "0x18369F960")]
		public NetPeer Connect(string address, int port, NetDataWriter connectionData)
		{
			return null;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x369FA40", Offset = "0x369E640", VA = "0x18369FA40")]
		public NetPeer Connect(IPEndPoint target, string key)
		{
			return null;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x369F6B0", Offset = "0x369E2B0", VA = "0x18369F6B0")]
		public NetPeer Connect(IPEndPoint target, NetDataWriter connectionData)
		{
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x36A49F0", Offset = "0x36A35F0", VA = "0x1836A49F0")]
		public void Stop()
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x36A4620", Offset = "0x36A3220", VA = "0x1836A4620")]
		public void Stop(bool sendDisconnectMessages)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x36A17B0", Offset = "0x36A03B0", VA = "0x1836A17B0")]
		public int GetPeersCount(ConnectionState peerState)
		{
			return 0;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x36A1840", Offset = "0x36A0440", VA = "0x1836A1840")]
		public void GetPeersNonAlloc(List<NetPeer> peers, ConnectionState peerState)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x36A0EB0", Offset = "0x369FAB0", VA = "0x1836A0EB0")]
		public void DisconnectAll()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x36A0FA0", Offset = "0x369FBA0", VA = "0x1836A0FA0")]
		public void DisconnectAll(byte[] data, int start, int count)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x36A10D0", Offset = "0x369FCD0", VA = "0x1836A10D0")]
		public void DisconnectPeerForce(NetPeer peer)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x36A1310", Offset = "0x369FF10", VA = "0x1836A1310")]
		public void DisconnectPeer(NetPeer peer)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x36A14B0", Offset = "0x36A00B0", VA = "0x1836A14B0")]
		public void DisconnectPeer(NetPeer peer, byte[] data)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x36A1570", Offset = "0x36A0170", VA = "0x1836A1570")]
		public void DisconnectPeer(NetPeer peer, NetDataWriter writer)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x36A1250", Offset = "0x369FE50", VA = "0x1836A1250")]
		public void DisconnectPeer(NetPeer peer, byte[] data, int start, int count)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x369FED0", Offset = "0x369EAD0", VA = "0x18369FED0")]
		public void CreateNtpRequest(IPEndPoint endPoint)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x369FF70", Offset = "0x369EB70", VA = "0x18369FF70")]
		public void CreateNtpRequest(string ntpServerAddress, int port)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x36A0040", Offset = "0x369EC40", VA = "0x1836A0040")]
		public void CreateNtpRequest(string ntpServerAddress)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x36A1630", Offset = "0x36A0230", VA = "0x1836A1630")]
		public NetManager.NetPeerEnumerator GetEnumerator()
		{
			return default(NetManager.NetPeerEnumerator);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x36A4A00", Offset = "0x36A3600", VA = "0x1836A4A00", Slot = "4")]
		private IEnumerator<NetPeer> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x36A4A80", Offset = "0x36A3680", VA = "0x1836A4A80", Slot = "5")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly NetSocket _socket;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Thread _logicThread;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _manualMode;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly AutoResetEvent _updateTriggerEvent;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Queue<NetEvent> _netEventsQueue;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private NetEvent _netEventPoolHead;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly INetEventListener _netEventListener;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly IDeliveryEventListener _deliveryEventListener;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly INtpEventListener _ntpEventListener;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<IPEndPoint, NetPeer> _peersDict;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly Dictionary<IPEndPoint, ConnectionRequest> _requestsDict;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Dictionary<IPEndPoint, NtpRequest> _ntpRequests;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly ReaderWriterLockSlim _peersLock;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NetPeer _headPeer;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _connectedPeersCount;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<NetPeer> _connectedPeerListCache;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private NetPeer[] _peersArray;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly PacketLayerBase _extraPacketLayer;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastPeerId;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Queue<int> _peerIds;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private byte _channelsCount;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly object _eventLock;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal readonly NetPacketPool NetPacketPool;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool UnconnectedMessagesEnabled;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool NatPunchEnabled;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public int UpdateTime;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public int PingInterval;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int DisconnectTimeout;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool SimulatePacketLoss;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool SimulateLatency;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int SimulationPacketLossChance;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public int SimulationMinLatency;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int SimulationMaxLatency;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool UnsyncedEvents;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		public bool UnsyncedReceiveEvent;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		public bool UnsyncedDeliveryEvent;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		public bool BroadcastReceiveEnabled;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public int ReconnectDelay;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int MaxConnectAttempts;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool ReuseAddress;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly NetStatistics Statistics;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public bool EnableStatistics;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public readonly NatPunchModule NatPunchModule;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool AutoRecycle;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public IPv6Mode IPv6Enabled;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int MtuOverride;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool UseSafeMtu;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
		public bool DisconnectOnUnreachable;

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		private class IPEndPointComparer : IEqualityComparer<IPEndPoint>
		{
			// Token: 0x06000101 RID: 257 RVA: 0x00002328 File Offset: 0x00000528
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x3699B90", Offset = "0x3698790", VA = "0x183699B90", Slot = "4")]
			public bool Equals(IPEndPoint x, IPEndPoint y)
			{
				return default(bool);
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00002340 File Offset: 0x00000540
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x3699C20", Offset = "0x3698820", VA = "0x183699C20", Slot = "5")]
			public int GetHashCode(IPEndPoint obj)
			{
				return 0;
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IPEndPointComparer()
			{
			}
		}

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public struct NetPeerEnumerator : IEnumerator<NetPeer>, IEnumerator, IDisposable
		{
			// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000104")]
			[Address(RVA = "0xF5A710", Offset = "0xF59310", VA = "0x180F5A710")]
			public NetPeerEnumerator(NetPeer p)
			{
			}

			// Token: 0x06000105 RID: 261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public void Dispose()
			{
			}

			// Token: 0x06000106 RID: 262 RVA: 0x00002358 File Offset: 0x00000558
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x36A6900", Offset = "0x36A5500", VA = "0x1836A6900", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000107 RID: 263 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x36A6950", Offset = "0x36A5550", VA = "0x1836A6950", Slot = "8")]
			public void Reset()
			{
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000108 RID: 264 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x17000011")]
			public NetPeer Current
			{
				[Token(Token = "0x6000108")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000109 RID: 265 RVA: 0x000020B2 File Offset: 0x000002B2
			[Token(Token = "0x17000012")]
			private object Current
			{
				[Token(Token = "0x6000109")]
				[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x040000AF RID: 175
			[Token(Token = "0x40000AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly NetPeer _initialPeer;

			// Token: 0x040000B0 RID: 176
			[Token(Token = "0x40000B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private NetPeer _p;
		}
	}
}
