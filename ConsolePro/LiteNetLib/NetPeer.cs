using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using FlyingWormConsole3.LiteNetLib.Utils;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	public class NetPeer
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		internal byte ConnectionNum
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x36AAB40", Offset = "0x36A9740", VA = "0x1836AAB40")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x36AABF0", Offset = "0x36A97F0", VA = "0x1836AABF0")]
			private set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x1700001C")]
		public ConnectionState ConnectionState
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x36AAB50", Offset = "0x36A9750", VA = "0x1836AAB50")]
			get
			{
				return (ConnectionState)0;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x1700001D")]
		internal long ConnectTime
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x1700001E")]
		public int Ping
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x36AAB60", Offset = "0x36A9760", VA = "0x1836AAB60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x1700001F")]
		public int Mtu
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x21E8010", Offset = "0x21E6C10", VA = "0x1821E8010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x17000020")]
		public long RemoteTimeDelta
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x17000021")]
		public DateTime RemoteUtcTime
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x36AAB70", Offset = "0x36A9770", VA = "0x1836AAB70")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x17000022")]
		public int TimeSinceLastPacket
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x17000023")]
		internal double ResendDelay
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x161D230", Offset = "0x161BE30", VA = "0x18161D230")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x36AA280", Offset = "0x36A8E80", VA = "0x1836AA280")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x36A9540", Offset = "0x36A8140", VA = "0x1836A9540")]
		private void SetMtu(int mtuIdx)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x36A7870", Offset = "0x36A6470", VA = "0x1836A7870")]
		private void OverrideMtu(int mtuValue)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x36A7790", Offset = "0x36A6390", VA = "0x1836A7790")]
		public int GetPacketsCountInReliableQueue(byte channelNumber, bool ordered)
		{
			return 0;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x36A7230", Offset = "0x36A5E30", VA = "0x1836A7230")]
		private BaseChannel CreateChannel(byte idx)
		{
			return null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x36AA860", Offset = "0x36A9460", VA = "0x1836AA860")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, byte connectNum, NetDataWriter connectData)
		{
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x36AA710", Offset = "0x36A9310", VA = "0x1836AA710")]
		internal NetPeer(NetManager netManager, IPEndPoint remoteEndPoint, int id, long connectId, byte connectNum)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x36A89C0", Offset = "0x36A75C0", VA = "0x1836A89C0")]
		internal void Reject(long connectionId, byte connectionNumber, byte[] data, int start, int length)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x36A7880", Offset = "0x36A6480", VA = "0x1836A7880")]
		internal bool ProcessConnectAccept(NetConnectAcceptPacket packet)
		{
			return default(bool);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x36A76C0", Offset = "0x36A62C0", VA = "0x1836A76C0")]
		public int GetMaxSinglePacketSize(DeliveryMethod options)
		{
			return 0;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x36A9280", Offset = "0x36A7E80", VA = "0x1836A9280")]
		public void SendWithDeliveryEvent(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x36A91F0", Offset = "0x36A7DF0", VA = "0x1836A91F0")]
		public void SendWithDeliveryEvent(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x36A9330", Offset = "0x36A7F30", VA = "0x1836A9330")]
		public void SendWithDeliveryEvent(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x36A93E0", Offset = "0x36A7FE0", VA = "0x1836A93E0")]
		public void Send(byte[] data, DeliveryMethod deliveryMethod)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x36A94D0", Offset = "0x36A80D0", VA = "0x1836A94D0")]
		public void Send(NetDataWriter dataWriter, DeliveryMethod deliveryMethod)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x36A9510", Offset = "0x36A8110", VA = "0x1836A9510")]
		public void Send(byte[] data, int start, int length, DeliveryMethod options)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x36A9450", Offset = "0x36A8050", VA = "0x1836A9450")]
		public void Send(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x36A9490", Offset = "0x36A8090", VA = "0x1836A9490")]
		public void Send(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x36A9420", Offset = "0x36A8020", VA = "0x1836A9420")]
		public void Send(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x36A8A00", Offset = "0x36A7600", VA = "0x1836A8A00")]
		private void SendInternal(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x36A7550", Offset = "0x36A6150", VA = "0x1836A7550")]
		public void Disconnect(byte[] data)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x36A7490", Offset = "0x36A6090", VA = "0x1836A7490")]
		public void Disconnect(NetDataWriter writer)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x36A7610", Offset = "0x36A6210", VA = "0x1836A7610")]
		public void Disconnect(byte[] data, int start, int count)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x36A73E0", Offset = "0x36A5FE0", VA = "0x1836A73E0")]
		public void Disconnect()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x36A7A80", Offset = "0x36A6680", VA = "0x1836A7A80")]
		internal DisconnectResult ProcessDisconnect(NetPacket packet)
		{
			return DisconnectResult.None;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x36A7160", Offset = "0x36A5D60", VA = "0x1836A7160")]
		internal void AddToReliableChannelSendQueue(BaseChannel channel)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x36A9600", Offset = "0x36A8200", VA = "0x1836A9600")]
		internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force)
		{
			return ShutdownResult.None;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x36A9C90", Offset = "0x36A8890", VA = "0x1836A9C90")]
		private void UpdateRoundTripTime(int roundTripTime)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x36A69A0", Offset = "0x36A55A0", VA = "0x1836A69A0")]
		internal void AddReliablePacket(DeliveryMethod method, NetPacket p)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x36A7B60", Offset = "0x36A6760", VA = "0x1836A7B60")]
		private void ProcessMtuPacket(NetPacket packet)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x36A98F0", Offset = "0x36A84F0", VA = "0x1836A98F0")]
		private void UpdateMtuLogic(int deltaTime)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x36A78E0", Offset = "0x36A64E0", VA = "0x1836A78E0")]
		internal ConnectRequestResult ProcessConnectRequest(NetConnectRequestPacket connRequest)
		{
			return ConnectRequestResult.None;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x36A8070", Offset = "0x36A6C70", VA = "0x1836A8070")]
		internal void ProcessPacket(NetPacket packet)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x36A8F40", Offset = "0x36A7B40", VA = "0x1836A8F40")]
		private void SendMerged()
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x36A9040", Offset = "0x36A7C40", VA = "0x1836A9040")]
		internal void SendUserData(NetPacket packet)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x36A9CC0", Offset = "0x36A88C0", VA = "0x1836A9CC0")]
		internal void Update(int deltaTime)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x36A8700", Offset = "0x36A7300", VA = "0x1836A8700")]
		internal void RecycleAndDeliver(NetPacket packet)
		{
		}

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x10")]
		private int _rtt;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x14")]
		private int _avgRtt;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18")]
		private int _rttCount;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x20")]
		private double _resendDelay;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x28")]
		private int _pingSendTimer;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x2C")]
		private int _rttResetTimer;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x30")]
		private readonly Stopwatch _pingTimer;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x38")]
		private int _timeSinceLastPacket;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x40")]
		private long _remoteDelta;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x48")]
		private readonly NetPacketPool _packetPool;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x50")]
		private readonly object _shutdownLock;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x58")]
		internal NetPeer NextPeer;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x60")]
		internal NetPeer PrevPeer;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x68")]
		private readonly Queue<NetPacket> _unreliableChannel;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x70")]
		private readonly Queue<BaseChannel> _channelSendQueue;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x78")]
		private readonly BaseChannel[] _channels;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x80")]
		private int _mtu;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x84")]
		private int _mtuIdx;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x88")]
		private bool _finishMtu;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x8C")]
		private int _mtuCheckTimer;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x90")]
		private int _mtuCheckAttempts;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		private const int MtuCheckDelay = 1000;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		private const int MaxMtuCheckAttempts = 4;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x98")]
		private readonly object _mtuMutex;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xA0")]
		private int _fragmentId;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xA8")]
		private readonly Dictionary<ushort, NetPeer.IncomingFragments> _holdedFragments;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<ushort, ushort> _deliveredFragments;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xB8")]
		private readonly NetPacket _mergeData;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xC0")]
		private int _mergePos;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xC4")]
		private int _mergeCount;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xC8")]
		private int _connectAttempts;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xCC")]
		private int _connectTimer;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0xD0")]
		private long _connectTime;

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0xD8")]
		private byte _connectNum;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0xD9")]
		private ConnectionState _connectionState;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0xE0")]
		private NetPacket _shutdownPacket;

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		private const int ShutdownDelay = 300;

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0xE8")]
		private int _shutdownTimer;

		// Token: 0x0400010F RID: 271
		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0xF0")]
		private readonly NetPacket _pingPacket;

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0xF8")]
		private readonly NetPacket _pongPacket;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x100")]
		private readonly NetPacket _connectRequestPacket;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x108")]
		private readonly NetPacket _connectAcceptPacket;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x110")]
		public readonly IPEndPoint EndPoint;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[FieldOffset(Offset = "0x118")]
		public readonly NetManager NetManager;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[FieldOffset(Offset = "0x120")]
		public readonly int Id;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[FieldOffset(Offset = "0x128")]
		public object Tag;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x130")]
		public readonly NetStatistics Statistics;

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		private class IncomingFragments
		{
			// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IncomingFragments()
			{
			}

			// Token: 0x04000118 RID: 280
			[Token(Token = "0x4000118")]
			[FieldOffset(Offset = "0x10")]
			public NetPacket[] Fragments;

			// Token: 0x04000119 RID: 281
			[Token(Token = "0x4000119")]
			[FieldOffset(Offset = "0x18")]
			public int ReceivedCount;

			// Token: 0x0400011A RID: 282
			[Token(Token = "0x400011A")]
			[FieldOffset(Offset = "0x1C")]
			public int TotalSize;

			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			[FieldOffset(Offset = "0x20")]
			public byte ChannelId;
		}
	}
}
