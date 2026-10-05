using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.PlatformSupport.TcpClient.General
{
	// Token: 0x020004CA RID: 1226
	[Token(Token = "0x20004CA")]
	public class TcpClient : IDisposable
	{
		// Token: 0x0600287B RID: 10363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287B")]
		[Address(RVA = "0x53AF190", Offset = "0x53ADD90", VA = "0x1853AF190")]
		private void Init(AddressFamily family)
		{
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x53AF7F0", Offset = "0x53AE3F0", VA = "0x1853AF7F0")]
		public TcpClient()
		{
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287D")]
		[Address(RVA = "0x53AF860", Offset = "0x53AE460", VA = "0x1853AF860")]
		public TcpClient(AddressFamily family)
		{
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287E")]
		[Address(RVA = "0x53AF740", Offset = "0x53AE340", VA = "0x1853AF740")]
		public TcpClient(IPEndPoint localEP)
		{
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287F")]
		[Address(RVA = "0x53AF6B0", Offset = "0x53AE2B0", VA = "0x1853AF6B0")]
		public TcpClient(string hostname, int port)
		{
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002880 RID: 10368 RVA: 0x000113D0 File Offset: 0x0000F5D0
		// (set) Token: 0x06002881 RID: 10369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CA")]
		protected bool Active
		{
			[Token(Token = "0x6002880")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002881")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06002882 RID: 10370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002883 RID: 10371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CB")]
		public Socket Client
		{
			[Token(Token = "0x6002882")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002883")]
			[Address(RVA = "0x53AF440", Offset = "0x53AE040", VA = "0x1853AF440")]
			set
			{
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x000113E8 File Offset: 0x0000F5E8
		[Token(Token = "0x170005CC")]
		public int Available
		{
			[Token(Token = "0x6002884")]
			[Address(RVA = "0x53AF950", Offset = "0x53AE550", VA = "0x1853AF950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x00011400 File Offset: 0x0000F600
		[Token(Token = "0x170005CD")]
		public bool Connected
		{
			[Token(Token = "0x6002885")]
			[Address(RVA = "0x53AF970", Offset = "0x53AE570", VA = "0x1853AF970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x00011418 File Offset: 0x0000F618
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x53AF240", Offset = "0x53ADE40", VA = "0x1853AF240")]
		public bool IsConnected()
		{
			return default(bool);
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002887 RID: 10375 RVA: 0x00011430 File Offset: 0x0000F630
		// (set) Token: 0x06002888 RID: 10376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CE")]
		public bool ExclusiveAddressUse
		{
			[Token(Token = "0x6002887")]
			[Address(RVA = "0x53AF990", Offset = "0x53AE590", VA = "0x1853AF990")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002888")]
			[Address(RVA = "0x53AFD70", Offset = "0x53AE970", VA = "0x1853AFD70")]
			set
			{
			}
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002889")]
		[Address(RVA = "0x53AF440", Offset = "0x53AE040", VA = "0x1853AF440")]
		internal void SetTcpClient(Socket s)
		{
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600288A RID: 10378 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005CF")]
		public LingerOption LingerState
		{
			[Token(Token = "0x600288A")]
			[Address(RVA = "0x53AF9B0", Offset = "0x53AE5B0", VA = "0x1853AF9B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600288B")]
			[Address(RVA = "0x53AFD90", Offset = "0x53AE990", VA = "0x1853AFD90")]
			set
			{
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600288C RID: 10380 RVA: 0x00011448 File Offset: 0x0000F648
		// (set) Token: 0x0600288D RID: 10381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D0")]
		public bool NoDelay
		{
			[Token(Token = "0x600288C")]
			[Address(RVA = "0x53AFAA0", Offset = "0x53AE6A0", VA = "0x1853AFAA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600288D")]
			[Address(RVA = "0x53AFDF0", Offset = "0x53AE9F0", VA = "0x1853AFDF0")]
			set
			{
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x0600288E RID: 10382 RVA: 0x00011460 File Offset: 0x0000F660
		// (set) Token: 0x0600288F RID: 10383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D1")]
		public int ReceiveBufferSize
		{
			[Token(Token = "0x600288E")]
			[Address(RVA = "0x53AFB30", Offset = "0x53AE730", VA = "0x1853AFB30")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600288F")]
			[Address(RVA = "0x53AFE40", Offset = "0x53AEA40", VA = "0x1853AFE40")]
			set
			{
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x00011478 File Offset: 0x0000F678
		// (set) Token: 0x06002891 RID: 10385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D2")]
		public int ReceiveTimeout
		{
			[Token(Token = "0x6002890")]
			[Address(RVA = "0x53AFBC0", Offset = "0x53AE7C0", VA = "0x1853AFBC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002891")]
			[Address(RVA = "0x53AFE90", Offset = "0x53AEA90", VA = "0x1853AFE90")]
			set
			{
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06002892 RID: 10386 RVA: 0x00011490 File Offset: 0x0000F690
		// (set) Token: 0x06002893 RID: 10387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D3")]
		public int SendBufferSize
		{
			[Token(Token = "0x6002892")]
			[Address(RVA = "0x53AFC50", Offset = "0x53AE850", VA = "0x1853AFC50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002893")]
			[Address(RVA = "0x53AFEE0", Offset = "0x53AEAE0", VA = "0x1853AFEE0")]
			set
			{
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06002894 RID: 10388 RVA: 0x000114A8 File Offset: 0x0000F6A8
		// (set) Token: 0x06002895 RID: 10389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D4")]
		public int SendTimeout
		{
			[Token(Token = "0x6002894")]
			[Address(RVA = "0x53AFCE0", Offset = "0x53AE8E0", VA = "0x1853AFCE0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002895")]
			[Address(RVA = "0x53AFF30", Offset = "0x53AEB30", VA = "0x1853AFF30")]
			set
			{
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06002896 RID: 10390 RVA: 0x000114C0 File Offset: 0x0000F6C0
		// (set) Token: 0x06002897 RID: 10391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005D5")]
		public TimeSpan ConnectTimeout
		{
			[Token(Token = "0x6002896")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6002897")]
			[Address(RVA = "0x35378C0", Offset = "0x35364C0", VA = "0x1835378C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002898")]
		[Address(RVA = "0x53AE520", Offset = "0x53AD120", VA = "0x1853AE520")]
		public void Close()
		{
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002899")]
		[Address(RVA = "0x53AE560", Offset = "0x53AD160", VA = "0x1853AE560")]
		public void Connect(IPEndPoint remoteEP)
		{
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289A")]
		[Address(RVA = "0x53AEF60", Offset = "0x53ADB60", VA = "0x1853AEF60")]
		public void Connect(IPAddress address, int port)
		{
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289B")]
		[Address(RVA = "0x53AF2A0", Offset = "0x53ADEA0", VA = "0x1853AF2A0")]
		private void SetOptions()
		{
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600289C")]
		[Address(RVA = "0x53AF550", Offset = "0x53AE150", VA = "0x1853AF550")]
		private static IPAddress[] _OverrideDns4BestHttp(string host, int port)
		{
			return null;
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x000114D8 File Offset: 0x0000F6D8
		[Token(Token = "0x600289D")]
		[Address(RVA = "0x53AF4E0", Offset = "0x53AE0E0", VA = "0x1853AF4E0")]
		private static bool _CheckIfOverrideDns(string url)
		{
			return default(bool);
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289E")]
		[Address(RVA = "0x53AEBD0", Offset = "0x53AD7D0", VA = "0x1853AEBD0")]
		public void Connect(string hostname, int port)
		{
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600289F")]
		[Address(RVA = "0x53AE880", Offset = "0x53AD480", VA = "0x1853AE880")]
		public void Connect(IPAddress[] ipAddresses, int port)
		{
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A0")]
		[Address(RVA = "0x53AF090", Offset = "0x53ADC90", VA = "0x1853AF090")]
		public void EndConnect(IAsyncResult asyncResult)
		{
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A1")]
		[Address(RVA = "0x53AE460", Offset = "0x53AD060", VA = "0x1853AE460")]
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x53AE400", Offset = "0x53AD000", VA = "0x1853AE400")]
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x53AE430", Offset = "0x53AD030", VA = "0x1853AE430")]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x53AF470", Offset = "0x53AE070", VA = "0x1853AF470", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x53AEFF0", Offset = "0x53ADBF0", VA = "0x1853AEFF0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x53AF0B0", Offset = "0x53ADCB0", VA = "0x1853AF0B0")]
		public Stream GetStream()
		{
			return null;
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x53AE490", Offset = "0x53AD090", VA = "0x1853AE490")]
		private void CheckDisposed()
		{
		}

		// Token: 0x04001672 RID: 5746
		[Token(Token = "0x4001672")]
		[FieldOffset(Offset = "0x10")]
		private NetworkStream stream;

		// Token: 0x04001673 RID: 5747
		[Token(Token = "0x4001673")]
		[FieldOffset(Offset = "0x18")]
		private bool active;

		// Token: 0x04001674 RID: 5748
		[Token(Token = "0x4001674")]
		[FieldOffset(Offset = "0x20")]
		private Socket client;

		// Token: 0x04001675 RID: 5749
		[Token(Token = "0x4001675")]
		[FieldOffset(Offset = "0x28")]
		private bool disposed;

		// Token: 0x04001676 RID: 5750
		[Token(Token = "0x4001676")]
		[FieldOffset(Offset = "0x2C")]
		private TcpClient.Properties values;

		// Token: 0x04001677 RID: 5751
		[Token(Token = "0x4001677")]
		[FieldOffset(Offset = "0x30")]
		private int recv_timeout;

		// Token: 0x04001678 RID: 5752
		[Token(Token = "0x4001678")]
		[FieldOffset(Offset = "0x34")]
		private int send_timeout;

		// Token: 0x04001679 RID: 5753
		[Token(Token = "0x4001679")]
		[FieldOffset(Offset = "0x38")]
		private int recv_buffer_size;

		// Token: 0x0400167A RID: 5754
		[Token(Token = "0x400167A")]
		[FieldOffset(Offset = "0x3C")]
		private int send_buffer_size;

		// Token: 0x0400167B RID: 5755
		[Token(Token = "0x400167B")]
		[FieldOffset(Offset = "0x40")]
		private LingerOption linger_state;

		// Token: 0x0400167C RID: 5756
		[Token(Token = "0x400167C")]
		[FieldOffset(Offset = "0x48")]
		private bool no_delay;

		// Token: 0x0400167E RID: 5758
		[Token(Token = "0x400167E")]
		private const string SHIELD_HOST_FLAG = "localhost";

		// Token: 0x0400167F RID: 5759
		[Token(Token = "0x400167F")]
		private const string SHIELD_TARGET_IP = "127.0.0.1";

		// Token: 0x020004CB RID: 1227
		[Token(Token = "0x20004CB")]
		private enum Properties : uint
		{
			// Token: 0x04001681 RID: 5761
			[Token(Token = "0x4001681")]
			LingerState = 1U,
			// Token: 0x04001682 RID: 5762
			[Token(Token = "0x4001682")]
			NoDelay,
			// Token: 0x04001683 RID: 5763
			[Token(Token = "0x4001683")]
			ReceiveBufferSize = 4U,
			// Token: 0x04001684 RID: 5764
			[Token(Token = "0x4001684")]
			ReceiveTimeout = 8U,
			// Token: 0x04001685 RID: 5765
			[Token(Token = "0x4001685")]
			SendBufferSize = 16U,
			// Token: 0x04001686 RID: 5766
			[Token(Token = "0x4001686")]
			SendTimeout = 32U
		}
	}
}
