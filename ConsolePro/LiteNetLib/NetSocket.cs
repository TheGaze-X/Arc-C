using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;

namespace FlyingWormConsole3.LiteNetLib
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	internal sealed class NetSocket
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600015D RID: 349 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public int LocalPort
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public short Ttl
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x36AC870", Offset = "0x36AB470", VA = "0x1836AC870")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x36AC900", Offset = "0x36AB500", VA = "0x1836AC900")]
			set
			{
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x36AC840", Offset = "0x36AB440", VA = "0x1836AC840")]
		public NetSocket(NetManager listener)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x36ABAE0", Offset = "0x36AA6E0", VA = "0x1836ABAE0")]
		private bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x36ABD70", Offset = "0x36AA970", VA = "0x1836ABD70")]
		private bool ProcessError(SocketException ex, EndPoint bufferEndPoint)
		{
			return default(bool);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x36ABB00", Offset = "0x36AA700", VA = "0x1836ABB00")]
		public void ManualReceive()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x36ABB50", Offset = "0x36AA750", VA = "0x1836ABB50")]
		private bool ManualReceive(Socket socket, EndPoint bufferEndPoint)
		{
			return default(bool);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x36ABFB0", Offset = "0x36AABB0", VA = "0x1836ABFB0")]
		private void ReceiveLogic(object state)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x36AB3B0", Offset = "0x36A9FB0", VA = "0x1836AB3B0")]
		public bool Bind(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool reuseAddress, IPv6Mode ipv6Mode, bool manualMode)
		{
			return default(bool);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x36AAC90", Offset = "0x36A9890", VA = "0x1836AAC90")]
		private bool BindSocket(Socket socket, IPEndPoint ep, bool reuseAddress, IPv6Mode ipv6Mode)
		{
			return default(bool);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x36AC280", Offset = "0x36AAE80", VA = "0x1836AC280")]
		public bool SendBroadcast(byte[] data, int offset, int size, int port)
		{
			return default(bool);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x36AC4F0", Offset = "0x36AB0F0", VA = "0x1836AC4F0")]
		public int SendTo(byte[] data, int offset, int size, IPEndPoint remoteEndPoint, ref SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x36AB9E0", Offset = "0x36AA5E0", VA = "0x1836AB9E0")]
		public void Close(bool suspend)
		{
		}

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		public const int ReceivePollingTime = 500000;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		private Socket _udpSocketv4;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		private Socket _udpSocketv6;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x20")]
		private Thread _threadv4;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x28")]
		private Thread _threadv6;

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0x30")]
		private IPEndPoint _bufferEndPointv4;

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x38")]
		private IPEndPoint _bufferEndPointv6;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x40")]
		private readonly NetManager _listener;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		private const int SioUdpConnreset = -1744830452;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IPAddress MulticastAddressV6;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly bool IPv6Support;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x4C")]
		public bool IsRunning;
	}
}
