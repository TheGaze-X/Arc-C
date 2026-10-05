using System;
using System.Net;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public interface INetEventListener
	{
		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		void OnPeerConnected(NetPeer peer);

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		void OnPeerDisconnected(NetPeer peer, DisconnectInfo disconnectInfo);

		// Token: 0x06000021 RID: 33
		[Token(Token = "0x6000021")]
		void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		void OnNetworkReceive(NetPeer peer, NetPacketReader reader, DeliveryMethod deliveryMethod);

		// Token: 0x06000023 RID: 35
		[Token(Token = "0x6000023")]
		void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, NetPacketReader reader, UnconnectedMessageType messageType);

		// Token: 0x06000024 RID: 36
		[Token(Token = "0x6000024")]
		void OnNetworkLatencyUpdate(NetPeer peer, int latency);

		// Token: 0x06000025 RID: 37
		[Token(Token = "0x6000025")]
		void OnConnectionRequest(ConnectionRequest request);
	}
}
