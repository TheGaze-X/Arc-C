using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	public class Socket : IDisposable
	{
		// Token: 0x060018EB RID: 6379 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x50AB140", Offset = "0x50A9D40", VA = "0x1850AB140")]
		internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken)
		{
			return default(ValueTask<int>);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x50AACD0", Offset = "0x50A98D0", VA = "0x1850AACD0")]
		private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags)
		{
			return null;
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x50AD700", Offset = "0x50AC300", VA = "0x1850AD700")]
		internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken)
		{
			return default(ValueTask);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x50AD260", Offset = "0x50ABE60", VA = "0x1850AD260")]
		private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags)
		{
			return null;
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x50A7320", Offset = "0x50A5F20", VA = "0x1850A7320")]
		private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x50A7520", Offset = "0x50A6120", VA = "0x1850A7520")]
		private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x50A9450", Offset = "0x50A8050", VA = "0x1850A9450")]
		private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = false)
		{
			return null;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x50AD1D0", Offset = "0x50ABDD0", VA = "0x1850AD1D0")]
		private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive)
		{
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x50AD160", Offset = "0x50ABD60", VA = "0x1850AD160")]
		private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea)
		{
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x50B0C80", Offset = "0x50AF880", VA = "0x1850B0C80")]
		public Socket(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType)
		{
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x17000584")]
		public static bool OSSupportsIPv4
		{
			[Token(Token = "0x60018F5")]
			[Address(RVA = "0x50B17B0", Offset = "0x50B03B0", VA = "0x1850B17B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x17000585")]
		public static bool OSSupportsIPv6
		{
			[Token(Token = "0x60018F6")]
			[Address(RVA = "0x50B1810", Offset = "0x50B0410", VA = "0x1850B1810")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x17000586")]
		public IntPtr Handle
		{
			[Token(Token = "0x60018F7")]
			[Address(RVA = "0x50B1480", Offset = "0x50B0080", VA = "0x1850B1480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x17000587")]
		public AddressFamily AddressFamily
		{
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return AddressFamily.Unspecified;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x17000588")]
		public SocketType SocketType
		{
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return (SocketType)0;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x17000589")]
		public ProtocolType ProtocolType
		{
			[Token(Token = "0x60018FA")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return ProtocolType.IP;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x0000B3E8 File Offset: 0x000095E8
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058A")]
		public bool ExclusiveAddressUse
		{
			[Token(Token = "0x60018FB")]
			[Address(RVA = "0x50B12D0", Offset = "0x50AFED0", VA = "0x1850B12D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60018FC")]
			[Address(RVA = "0x50B1D40", Offset = "0x50B0940", VA = "0x1850B1D40")]
			set
			{
			}
		}

		// Token: 0x1700058B RID: 1419
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058B")]
		public int ReceiveBufferSize
		{
			[Token(Token = "0x60018FD")]
			[Address(RVA = "0x50B1EA0", Offset = "0x50B0AA0", VA = "0x1850B1EA0")]
			set
			{
			}
		}

		// Token: 0x1700058C RID: 1420
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058C")]
		public int SendBufferSize
		{
			[Token(Token = "0x60018FE")]
			[Address(RVA = "0x50B1FC0", Offset = "0x50B0BC0", VA = "0x1850B1FC0")]
			set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058D")]
		public int ReceiveTimeout
		{
			[Token(Token = "0x60018FF")]
			[Address(RVA = "0x50B1F30", Offset = "0x50B0B30", VA = "0x1850B1F30")]
			set
			{
			}
		}

		// Token: 0x1700058E RID: 1422
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058E")]
		public int SendTimeout
		{
			[Token(Token = "0x6001900")]
			[Address(RVA = "0x50B2050", Offset = "0x50B0C50", VA = "0x1850B2050")]
			set
			{
			}
		}

		// Token: 0x1700058F RID: 1423
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058F")]
		public LingerOption LingerState
		{
			[Token(Token = "0x6001901")]
			[Address(RVA = "0x50B1DE0", Offset = "0x50B09E0", VA = "0x1850B1DE0")]
			set
			{
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0000B400 File Offset: 0x00009600
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000590")]
		public short Ttl
		{
			[Token(Token = "0x6001902")]
			[Address(RVA = "0x50B1970", Offset = "0x50B0570", VA = "0x1850B1970")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001903")]
			[Address(RVA = "0x50B20E0", Offset = "0x50B0CE0", VA = "0x1850B20E0")]
			set
			{
			}
		}

		// Token: 0x17000591 RID: 1425
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000591")]
		public bool DontFragment
		{
			[Token(Token = "0x6001904")]
			[Address(RVA = "0x50B1B70", Offset = "0x50B0770", VA = "0x1850B1B70")]
			set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0000B418 File Offset: 0x00009618
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000592")]
		public bool DualMode
		{
			[Token(Token = "0x6001905")]
			[Address(RVA = "0x50B11E0", Offset = "0x50AFDE0", VA = "0x1850B11E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001906")]
			[Address(RVA = "0x50B1C10", Offset = "0x50B0810", VA = "0x1850B1C10")]
			set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x17000593")]
		private bool IsDualMode
		{
			[Token(Token = "0x6001907")]
			[Address(RVA = "0x50B1590", Offset = "0x50B0190", VA = "0x1850B1590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x6001908")]
		[Address(RVA = "0x50A71F0", Offset = "0x50A5DF0", VA = "0x1850A71F0")]
		internal bool CanTryAddressFamily(AddressFamily family)
		{
			return default(bool);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x6001909")]
		[Address(RVA = "0x50AE6D0", Offset = "0x50AD2D0", VA = "0x1850AE6D0")]
		public int Send(byte[] buffer)
		{
			return 0;
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x600190A")]
		[Address(RVA = "0x50AE650", Offset = "0x50AD250", VA = "0x1850AE650")]
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return 0;
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x600190B")]
		[Address(RVA = "0x50AEF30", Offset = "0x50ADB30", VA = "0x1850AEF30")]
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			return 0;
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x600190C")]
		[Address(RVA = "0x50AE3A0", Offset = "0x50ACFA0", VA = "0x1850AE3A0")]
		public int SendTo(byte[] buffer, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return 0;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x600190D")]
		[Address(RVA = "0x50AC4F0", Offset = "0x50AB0F0", VA = "0x1850AC4F0")]
		public int Receive(byte[] buffer)
		{
			return 0;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x50AC590", Offset = "0x50AB190", VA = "0x1850AC590")]
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags)
		{
			return 0;
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x50ACED0", Offset = "0x50ABAD0", VA = "0x1850ACED0")]
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags)
		{
			return 0;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x50A9A50", Offset = "0x50A8650", VA = "0x1850A9A50")]
		public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return 0;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x50AEFC0", Offset = "0x50ADBC0", VA = "0x1850AEFC0")]
		public void SetIPProtectionLevel(IPProtectionLevel level)
		{
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x50A5090", Offset = "0x50A3C90", VA = "0x1850A5090")]
		public IAsyncResult BeginConnect(IPAddress address, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x50A6C90", Offset = "0x50A5890", VA = "0x1850A6C90")]
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x50A90A0", Offset = "0x50A7CA0", VA = "0x1850A90A0")]
		public int EndSend(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x50A5DD0", Offset = "0x50A49D0", VA = "0x1850A5DD0")]
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x50A8D80", Offset = "0x50A7980", VA = "0x1850A8D80")]
		public int EndReceive(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000594")]
		private static object InternalSyncObject
		{
			[Token(Token = "0x6001917")]
			[Address(RVA = "0x50B14A0", Offset = "0x50B00A0", VA = "0x1850B14A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x17000595")]
		internal bool CleanedUp
		{
			[Token(Token = "0x6001918")]
			[Address(RVA = "0x50B11C0", Offset = "0x50AFDC0", VA = "0x1850B11C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x50A9F60", Offset = "0x50A8B60", VA = "0x1850A9F60")]
		internal static void InitializeSockets()
		{
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x50A8730", Offset = "0x50A7330", VA = "0x1850A8730", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x50AA2B0", Offset = "0x50A8EB0", VA = "0x1850AA2B0")]
		internal void InternalShutdown(SocketShutdown how)
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x50AF790", Offset = "0x50AE390", VA = "0x1850AF790")]
		internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent)
		{
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x50B0FC0", Offset = "0x50AFBC0", VA = "0x1850B0FC0")]
		internal Socket(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle)
		{
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x50AFB70", Offset = "0x50AE770", VA = "0x1850AFB70")]
		private void SocketDefaults()
		{
		}

		// Token: 0x06001920 RID: 6432
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x50AFD60", Offset = "0x50AE960", VA = "0x1850AFD60")]
		[MethodImpl(4096)]
		private static extern IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error);

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x17000596")]
		public int Available
		{
			[Token(Token = "0x6001921")]
			[Address(RVA = "0x50B1100", Offset = "0x50AFD00", VA = "0x1850B1100")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x50A4C50", Offset = "0x50A3850", VA = "0x1850A4C50")]
		private static int Available_internal(SafeSocketHandle safeHandle, out int error)
		{
			return 0;
		}

		// Token: 0x06001923 RID: 6435
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x50A4C40", Offset = "0x50A3840", VA = "0x1850A4C40")]
		[MethodImpl(4096)]
		private static extern int Available_icall(IntPtr socket, out int error);

		// Token: 0x17000597 RID: 1431
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000597")]
		public bool EnableBroadcast
		{
			[Token(Token = "0x6001924")]
			[Address(RVA = "0x50B1CB0", Offset = "0x50B08B0", VA = "0x1850B1CB0")]
			set
			{
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x17000598")]
		public bool IsBound
		{
			[Token(Token = "0x6001925")]
			[Address(RVA = "0x150B0B0", Offset = "0x1509CB0", VA = "0x18150B0B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000599")]
		public EndPoint LocalEndPoint
		{
			[Token(Token = "0x6001926")]
			[Address(RVA = "0x50B1690", Offset = "0x50B0290", VA = "0x1850B1690")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001927")]
		[Address(RVA = "0x50AA750", Offset = "0x50A9350", VA = "0x1850AA750")]
		private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			return null;
		}

		// Token: 0x06001928 RID: 6440
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x50AA740", Offset = "0x50A9340", VA = "0x1850AA740")]
		[MethodImpl(4096)]
		private static extern SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error);

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0000B5B0 File Offset: 0x000097B0
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059A")]
		public bool Blocking
		{
			[Token(Token = "0x6001929")]
			[Address(RVA = "0x789390", Offset = "0x787F90", VA = "0x180789390")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600192A")]
			[Address(RVA = "0x50B1AA0", Offset = "0x50B06A0", VA = "0x1850B1AA0")]
			set
			{
			}
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x50A70E0", Offset = "0x50A5CE0", VA = "0x1850A70E0")]
		private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error)
		{
		}

		// Token: 0x0600192C RID: 6444
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x50A70D0", Offset = "0x50A5CD0", VA = "0x1850A70D0")]
		[MethodImpl(4096)]
		internal static extern void Blocking_icall(IntPtr socket, bool block, out int error);

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x1700059B")]
		public bool Connected
		{
			[Token(Token = "0x600192D")]
			[Address(RVA = "0x50B11D0", Offset = "0x50AFDD0", VA = "0x1850B11D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059C")]
		public bool NoDelay
		{
			[Token(Token = "0x600192E")]
			[Address(RVA = "0x50B1E10", Offset = "0x50B0A10", VA = "0x1850B1E10")]
			set
			{
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059D")]
		public EndPoint RemoteEndPoint
		{
			[Token(Token = "0x600192F")]
			[Address(RVA = "0x50B1870", Offset = "0x50B0470", VA = "0x1850B1870")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x50AD030", Offset = "0x50ABC30", VA = "0x1850AD030")]
		private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error)
		{
			return null;
		}

		// Token: 0x06001931 RID: 6449
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x50AD020", Offset = "0x50ABC20", VA = "0x1850AD020")]
		[MethodImpl(4096)]
		private static extern SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error);

		// Token: 0x06001932 RID: 6450 RVA: 0x0000B5E0 File Offset: 0x000097E0
		[Token(Token = "0x6001932")]
		[Address(RVA = "0x50AA9D0", Offset = "0x50A95D0", VA = "0x1850AA9D0")]
		public bool Poll(int microSeconds, SelectMode mode)
		{
			return default(bool);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x50AA890", Offset = "0x50A9490", VA = "0x1850AA890")]
		private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error)
		{
			return default(bool);
		}

		// Token: 0x06001934 RID: 6452
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x50AA880", Offset = "0x50A9480", VA = "0x1850AA880")]
		[MethodImpl(4096)]
		private static extern bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error);

		// Token: 0x06001935 RID: 6453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001935")]
		[Address(RVA = "0x50A48D0", Offset = "0x50A34D0", VA = "0x1850A48D0")]
		public Socket Accept()
		{
			return null;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001936")]
		[Address(RVA = "0x50A4B00", Offset = "0x50A3700", VA = "0x1850A4B00")]
		internal void Accept(Socket acceptSocket)
		{
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x6001937")]
		[Address(RVA = "0x50A4450", Offset = "0x50A3050", VA = "0x1850A4450")]
		public bool AcceptAsync(SocketAsyncEventArgs e)
		{
			return default(bool);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001938")]
		[Address(RVA = "0x50A4D60", Offset = "0x50A3960", VA = "0x1850A4D60")]
		public IAsyncResult BeginAccept(AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001939")]
		[Address(RVA = "0x50A87A0", Offset = "0x50A73A0", VA = "0x1850A87A0")]
		public Socket EndAccept(IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193A")]
		[Address(RVA = "0x50A88A0", Offset = "0x50A74A0", VA = "0x1850A88A0")]
		public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult)
		{
			return null;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193B")]
		[Address(RVA = "0x50A4790", Offset = "0x50A3390", VA = "0x1850A4790")]
		private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking)
		{
			return null;
		}

		// Token: 0x0600193C RID: 6460
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x50A4780", Offset = "0x50A3380", VA = "0x1850A4780")]
		[MethodImpl(4096)]
		private static extern IntPtr Accept_icall(IntPtr sock, out int error, bool blocking);

		// Token: 0x0600193D RID: 6461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193D")]
		[Address(RVA = "0x50A6E60", Offset = "0x50A5A60", VA = "0x1850A6E60")]
		public void Bind(EndPoint localEP)
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193E")]
		[Address(RVA = "0x50A6D50", Offset = "0x50A5950", VA = "0x1850A6D50")]
		private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error)
		{
		}

		// Token: 0x0600193F RID: 6463
		[Token(Token = "0x600193F")]
		[Address(RVA = "0x50A6D40", Offset = "0x50A5940", VA = "0x1850A6D40")]
		[MethodImpl(4096)]
		private static extern void Bind_icall(IntPtr sock, SocketAddress sa, out int error);

		// Token: 0x06001940 RID: 6464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001940")]
		[Address(RVA = "0x50AA620", Offset = "0x50A9220", VA = "0x1850AA620")]
		public void Listen(int backlog)
		{
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001941")]
		[Address(RVA = "0x50AA510", Offset = "0x50A9110", VA = "0x1850AA510")]
		private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error)
		{
		}

		// Token: 0x06001942 RID: 6466
		[Token(Token = "0x6001942")]
		[Address(RVA = "0x50AA500", Offset = "0x50A9100", VA = "0x1850AA500")]
		[MethodImpl(4096)]
		private static extern void Listen_icall(IntPtr sock, int backlog, out int error);

		// Token: 0x06001943 RID: 6467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001943")]
		[Address(RVA = "0x50A8290", Offset = "0x50A6E90", VA = "0x1850A8290")]
		public void Connect(IPAddress address, int port)
		{
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001944")]
		[Address(RVA = "0x50A7DE0", Offset = "0x50A69E0", VA = "0x1850A7DE0")]
		public void Connect(EndPoint remoteEP)
		{
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x6001945")]
		[Address(RVA = "0x50A76F0", Offset = "0x50A62F0", VA = "0x1850A76F0")]
		public bool ConnectAsync(SocketAsyncEventArgs e)
		{
			return default(bool);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001946")]
		[Address(RVA = "0x50A56F0", Offset = "0x50A42F0", VA = "0x1850A56F0")]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x50A4F00", Offset = "0x50A3B00", VA = "0x1850A4F00")]
		public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x50A5420", Offset = "0x50A4020", VA = "0x1850A5420")]
		public IAsyncResult BeginConnect(IPAddress[] addresses, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x50A5A00", Offset = "0x50A4600", VA = "0x1850A5A00")]
		private static bool BeginMConnect(SocketAsyncResult sockares)
		{
			return default(bool);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0000B658 File Offset: 0x00009858
		[Token(Token = "0x600194A")]
		[Address(RVA = "0x50A5FE0", Offset = "0x50A4BE0", VA = "0x1850A5FE0")]
		private static bool BeginSConnect(SocketAsyncResult sockares)
		{
			return default(bool);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x50A89C0", Offset = "0x50A75C0", VA = "0x1850A89C0")]
		public void EndConnect(IAsyncResult asyncResult)
		{
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x50A7CE0", Offset = "0x50A68E0", VA = "0x1850A7CE0")]
		private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking)
		{
		}

		// Token: 0x0600194D RID: 6477
		[Token(Token = "0x600194D")]
		[Address(RVA = "0x50A7CD0", Offset = "0x50A68D0", VA = "0x1850A7CD0")]
		[MethodImpl(4096)]
		private static extern void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking);

		// Token: 0x0600194E RID: 6478 RVA: 0x0000B670 File Offset: 0x00009870
		[Token(Token = "0x600194E")]
		[Address(RVA = "0x50A91E0", Offset = "0x50A7DE0", VA = "0x1850A91E0")]
		private bool GetCheckedIPs(SocketAsyncEventArgs e, out IPAddress[] addresses)
		{
			return default(bool);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194F")]
		[Address(RVA = "0x50A8440", Offset = "0x50A7040", VA = "0x1850A8440")]
		public void Disconnect(bool reuseSocket)
		{
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001950")]
		[Address(RVA = "0x50A8A90", Offset = "0x50A7690", VA = "0x1850A8A90")]
		public void EndDisconnect(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001951")]
		[Address(RVA = "0x50A8330", Offset = "0x50A6F30", VA = "0x1850A8330")]
		private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error)
		{
		}

		// Token: 0x06001952 RID: 6482
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x50A8320", Offset = "0x50A6F20", VA = "0x1850A8320")]
		[MethodImpl(4096)]
		private static extern void Disconnect_icall(IntPtr sock, bool reuse, out int error);

		// Token: 0x06001953 RID: 6483 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x50ACD60", Offset = "0x50AB960", VA = "0x1850ACD60")]
		public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x50AC620", Offset = "0x50AB220", VA = "0x1850AC620")]
		private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x50AC830", Offset = "0x50AB430", VA = "0x1850AC830")]
		[CLSCompliant(false)]
		public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x50AC3E0", Offset = "0x50AAFE0", VA = "0x1850AC3E0")]
		public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x0000B6E8 File Offset: 0x000098E8
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x50AE770", Offset = "0x50AD370", VA = "0x1850AE770")]
		public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x50AB600", Offset = "0x50AA200", VA = "0x1850AB600")]
		public bool ReceiveAsync(SocketAsyncEventArgs e)
		{
			return default(bool);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x50A5BC0", Offset = "0x50A47C0", VA = "0x1850A5BC0")]
		public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x50A8C70", Offset = "0x50A7870", VA = "0x1850A8C70")]
		public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x50AC2B0", Offset = "0x50AAEB0", VA = "0x1850AC2B0")]
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			return 0;
		}

		// Token: 0x0600195C RID: 6492
		[Token(Token = "0x600195C")]
		[Address(RVA = "0x50AC160", Offset = "0x50AAD60", VA = "0x1850AC160")]
		[MethodImpl(4096)]
		private unsafe static extern int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x0600195D RID: 6493 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x50AC180", Offset = "0x50AAD80", VA = "0x1850AC180")]
		private unsafe static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			return 0;
		}

		// Token: 0x0600195E RID: 6494
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x50AC170", Offset = "0x50AAD70", VA = "0x1850AC170")]
		[MethodImpl(4096)]
		private unsafe static extern int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x0600195F RID: 6495 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x50ABDF0", Offset = "0x50AA9F0", VA = "0x1850ABDF0")]
		public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP)
		{
			return 0;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x50ABF90", Offset = "0x50AAB90", VA = "0x1850ABF90")]
		internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x50ABB00", Offset = "0x50AA700", VA = "0x1850ABB00")]
		private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x50A8B60", Offset = "0x50A7760", VA = "0x1850A8B60")]
		private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares)
		{
			return 0;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x50AB9C0", Offset = "0x50AA5C0", VA = "0x1850AB9C0")]
		private unsafe static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking)
		{
			return 0;
		}

		// Token: 0x06001964 RID: 6500
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x50AB9B0", Offset = "0x50AA5B0", VA = "0x1850AB9B0")]
		[MethodImpl(4096)]
		private unsafe static extern int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking);

		// Token: 0x06001965 RID: 6501 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x50AED90", Offset = "0x50AD990", VA = "0x1850AED90")]
		public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x6001966")]
		[Address(RVA = "0x50AE800", Offset = "0x50AD400", VA = "0x1850AE800")]
		[CLSCompliant(false)]
		public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x6001967")]
		[Address(RVA = "0x50ADB80", Offset = "0x50AC780", VA = "0x1850ADB80")]
		public bool SendAsync(SocketAsyncEventArgs e)
		{
			return default(bool);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001968")]
		[Address(RVA = "0x50A69D0", Offset = "0x50A55D0", VA = "0x1850A69D0")]
		public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001969")]
		[Address(RVA = "0x50A6660", Offset = "0x50A5260", VA = "0x1850A6660")]
		private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far)
		{
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x600196A")]
		[Address(RVA = "0x50A8F90", Offset = "0x50A7B90", VA = "0x1850A8F90")]
		public int EndSend(IAsyncResult asyncResult, out SocketError errorCode)
		{
			return 0;
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0000B838 File Offset: 0x00009A38
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x50AE520", Offset = "0x50AD120", VA = "0x1850AE520")]
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking)
		{
			return 0;
		}

		// Token: 0x0600196C RID: 6508
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x50AE3D0", Offset = "0x50ACFD0", VA = "0x1850AE3D0")]
		[MethodImpl(4096)]
		private unsafe static extern int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x0600196D RID: 6509 RVA: 0x0000B850 File Offset: 0x00009A50
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x50AE3F0", Offset = "0x50ACFF0", VA = "0x1850AE3F0")]
		private unsafe static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking)
		{
			return 0;
		}

		// Token: 0x0600196E RID: 6510
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x50AE3E0", Offset = "0x50ACFE0", VA = "0x1850AE3E0")]
		[MethodImpl(4096)]
		private unsafe static extern int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking);

		// Token: 0x0600196F RID: 6511 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x50AE150", Offset = "0x50ACD50", VA = "0x1850AE150")]
		public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP)
		{
			return 0;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x50A8EC0", Offset = "0x50A7AC0", VA = "0x1850A8EC0")]
		public int EndSendTo(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x50AE010", Offset = "0x50ACC10", VA = "0x1850AE010")]
		private unsafe static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking)
		{
			return 0;
		}

		// Token: 0x06001972 RID: 6514
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x50AE000", Offset = "0x50ACC00", VA = "0x1850AE000")]
		[MethodImpl(4096)]
		private unsafe static extern int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking);

		// Token: 0x06001973 RID: 6515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x50A9550", Offset = "0x50A8150", VA = "0x1850A9550")]
		public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName)
		{
			return null;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x50A97C0", Offset = "0x50A83C0", VA = "0x1850A97C0")]
		private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error)
		{
		}

		// Token: 0x06001975 RID: 6517
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x50A97B0", Offset = "0x50A83B0", VA = "0x1850A97B0")]
		[MethodImpl(4096)]
		private static extern void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error);

		// Token: 0x06001976 RID: 6518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x50AF260", Offset = "0x50ADE60", VA = "0x1850AF260")]
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue)
		{
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x50AF910", Offset = "0x50AE510", VA = "0x1850AF910")]
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x50AF640", Offset = "0x50AE240", VA = "0x1850AF640")]
		public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue)
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x50AF100", Offset = "0x50ADD00", VA = "0x1850AF100")]
		private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error)
		{
		}

		// Token: 0x0600197A RID: 6522
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x50AF0F0", Offset = "0x50ADCF0", VA = "0x1850AF0F0")]
		[MethodImpl(4096)]
		private static extern void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error);

		// Token: 0x0600197B RID: 6523 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x50A9C00", Offset = "0x50A8800", VA = "0x1850A9C00")]
		public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue)
		{
			return 0;
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[Token(Token = "0x600197C")]
		[Address(RVA = "0x50A9910", Offset = "0x50A8510", VA = "0x1850A9910")]
		private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error)
		{
			return 0;
		}

		// Token: 0x0600197D RID: 6525
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x50A9900", Offset = "0x50A8500", VA = "0x1850A9900")]
		[MethodImpl(4096)]
		private static extern int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error);

		// Token: 0x0600197E RID: 6526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x50A7220", Offset = "0x50A5E20", VA = "0x1850A7220")]
		public void Close()
		{
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x50A72A0", Offset = "0x50A5EA0", VA = "0x1850A72A0")]
		public void Close(int timeout)
		{
		}

		// Token: 0x06001980 RID: 6528
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x50A7210", Offset = "0x50A5E10", VA = "0x1850A7210")]
		[MethodImpl(4096)]
		internal static extern void Close_icall(IntPtr socket, out int error);

		// Token: 0x06001981 RID: 6529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x50AFA50", Offset = "0x50AE650", VA = "0x1850AFA50")]
		public void Shutdown(SocketShutdown how)
		{
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x50AF940", Offset = "0x50AE540", VA = "0x1850AF940")]
		private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error)
		{
		}

		// Token: 0x06001983 RID: 6531
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x50AF930", Offset = "0x50AE530", VA = "0x1850AF930")]
		[MethodImpl(4096)]
		internal static extern void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error);

		// Token: 0x06001984 RID: 6532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x50A8560", Offset = "0x50A7160", VA = "0x1850A8560", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x50AA380", Offset = "0x50A8F80", VA = "0x1850AA380")]
		private void Linger(IntPtr handle)
		{
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001986")]
		[Address(RVA = "0x50AFFC0", Offset = "0x50AEBC0", VA = "0x1850AFFC0")]
		private void ThrowIfDisposedAndClosed()
		{
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001987")]
		[Address(RVA = "0x50AFD70", Offset = "0x50AE970", VA = "0x1850AFD70")]
		private void ThrowIfBufferNull(byte[] buffer)
		{
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001988")]
		[Address(RVA = "0x50AFDE0", Offset = "0x50AE9E0", VA = "0x1850AFDE0")]
		private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001989")]
		[Address(RVA = "0x50B0050", Offset = "0x50AEC50", VA = "0x1850B0050")]
		private void ThrowIfUdp()
		{
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198A")]
		[Address(RVA = "0x50B00B0", Offset = "0x50AECB0", VA = "0x1850B00B0")]
		private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName)
		{
			return null;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x50AAB80", Offset = "0x50A9780", VA = "0x1850AAB80")]
		private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job)
		{
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x50A9DB0", Offset = "0x50A89B0", VA = "0x1850A9DB0")]
		private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation)
		{
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x50AFC30", Offset = "0x50AE830", VA = "0x1850AFC30")]
		private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op)
		{
			return SocketAsyncOperation.None;
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x50ACF50", Offset = "0x50ABB50", VA = "0x1850ACF50")]
		private IPEndPoint RemapIPEndPoint(IPEndPoint input)
		{
			return null;
		}

		// Token: 0x0600198F RID: 6543
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x50B10F0", Offset = "0x50AFCF0", VA = "0x1850B10F0")]
		[MethodImpl(4096)]
		internal static extern void cancel_blocking_socket_operation(Thread thread);

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x1700059E")]
		internal static int FamilyHint
		{
			[Token(Token = "0x6001990")]
			[Address(RVA = "0x50B1350", Offset = "0x50AFF50", VA = "0x1850B1350")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001991 RID: 6545
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x4BB5150", Offset = "0x4BB3D50", VA = "0x184BB5150")]
		[MethodImpl(4096)]
		private static extern bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface);

		// Token: 0x06001992 RID: 6546 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x50AA330", Offset = "0x50A8F30", VA = "0x1850AA330")]
		private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface)
		{
			return default(bool);
		}

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler;

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x10")]
		private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x28")]
		private static readonly Task<int> s_zeroTask;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0x10")]
		private Socket.CachedEventArgs _cachedTaskEventArgs;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0x30")]
		private static object s_InternalSyncObject;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x38")]
		internal static bool s_SupportsIPv4;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x39")]
		internal static bool s_SupportsIPv6;

		// Token: 0x04000F78 RID: 3960
		[Token(Token = "0x4000F78")]
		[FieldOffset(Offset = "0x3A")]
		internal static bool s_OSSupportsIPv6;

		// Token: 0x04000F79 RID: 3961
		[Token(Token = "0x4000F79")]
		[FieldOffset(Offset = "0x3B")]
		internal static bool s_Initialized;

		// Token: 0x04000F7A RID: 3962
		[Token(Token = "0x4000F7A")]
		[FieldOffset(Offset = "0x3C")]
		private static bool s_LoggingEnabled;

		// Token: 0x04000F7B RID: 3963
		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x3D")]
		internal static bool s_PerfCountersEnabled;

		// Token: 0x04000F7C RID: 3964
		[Token(Token = "0x4000F7C")]
		internal const int DefaultCloseTimeout = -1;

		// Token: 0x04000F7D RID: 3965
		[Token(Token = "0x4000F7D")]
		private const int SOCKET_CLOSED_CODE = 10004;

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x18")]
		private bool is_closed;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x19")]
		private bool is_listening;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x1A")]
		private bool useOverlappedIO;

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x1C")]
		private int linger_timeout;

		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		[FieldOffset(Offset = "0x20")]
		private AddressFamily addressFamily;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x24")]
		private SocketType socketType;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x28")]
		private ProtocolType protocolType;

		// Token: 0x04000F86 RID: 3974
		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x30")]
		internal SafeSocketHandle m_Handle;

		// Token: 0x04000F87 RID: 3975
		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0x38")]
		internal EndPoint seed_endpoint;

		// Token: 0x04000F88 RID: 3976
		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x40")]
		internal SemaphoreSlim ReadSem;

		// Token: 0x04000F89 RID: 3977
		[Token(Token = "0x4000F89")]
		[FieldOffset(Offset = "0x48")]
		internal SemaphoreSlim WriteSem;

		// Token: 0x04000F8A RID: 3978
		[Token(Token = "0x4000F8A")]
		[FieldOffset(Offset = "0x50")]
		internal bool is_blocking;

		// Token: 0x04000F8B RID: 3979
		[Token(Token = "0x4000F8B")]
		[FieldOffset(Offset = "0x51")]
		internal bool is_bound;

		// Token: 0x04000F8C RID: 3980
		[Token(Token = "0x4000F8C")]
		[FieldOffset(Offset = "0x52")]
		internal bool is_connected;

		// Token: 0x04000F8D RID: 3981
		[Token(Token = "0x4000F8D")]
		[FieldOffset(Offset = "0x54")]
		private int m_IntCleanedUp;

		// Token: 0x04000F8E RID: 3982
		[Token(Token = "0x4000F8E")]
		[FieldOffset(Offset = "0x58")]
		internal bool connect_in_progress;

		// Token: 0x04000F8F RID: 3983
		[Token(Token = "0x4000F8F")]
		[FieldOffset(Offset = "0x5C")]
		internal readonly int ID;

		// Token: 0x04000F90 RID: 3984
		[Token(Token = "0x4000F90")]
		[FieldOffset(Offset = "0x40")]
		private static AsyncCallback AcceptAsyncCallback;

		// Token: 0x04000F91 RID: 3985
		[Token(Token = "0x4000F91")]
		[FieldOffset(Offset = "0x48")]
		private static IOAsyncCallback BeginAcceptCallback;

		// Token: 0x04000F92 RID: 3986
		[Token(Token = "0x4000F92")]
		[FieldOffset(Offset = "0x50")]
		private static IOAsyncCallback BeginAcceptReceiveCallback;

		// Token: 0x04000F93 RID: 3987
		[Token(Token = "0x4000F93")]
		[FieldOffset(Offset = "0x58")]
		private static AsyncCallback ConnectAsyncCallback;

		// Token: 0x04000F94 RID: 3988
		[Token(Token = "0x4000F94")]
		[FieldOffset(Offset = "0x60")]
		private static IOAsyncCallback BeginConnectCallback;

		// Token: 0x04000F95 RID: 3989
		[Token(Token = "0x4000F95")]
		[FieldOffset(Offset = "0x68")]
		private static AsyncCallback DisconnectAsyncCallback;

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		[FieldOffset(Offset = "0x70")]
		private static IOAsyncCallback BeginDisconnectCallback;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		[FieldOffset(Offset = "0x78")]
		private static AsyncCallback ReceiveAsyncCallback;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		[FieldOffset(Offset = "0x80")]
		private static IOAsyncCallback BeginReceiveCallback;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0x88")]
		private static IOAsyncCallback BeginReceiveGenericCallback;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x90")]
		private static AsyncCallback ReceiveFromAsyncCallback;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x98")]
		private static IOAsyncCallback BeginReceiveFromCallback;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0xA0")]
		private static AsyncCallback SendAsyncCallback;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0xA8")]
		private static IOAsyncCallback BeginSendGenericCallback;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0xB0")]
		private static AsyncCallback SendToAsyncCallback;

		// Token: 0x020003A7 RID: 935
		[Token(Token = "0x20003A7")]
		private sealed class CachedEventArgs
		{
			// Token: 0x06001994 RID: 6548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001994")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CachedEventArgs()
			{
			}

			// Token: 0x04000F9F RID: 3999
			[Token(Token = "0x4000F9F")]
			[FieldOffset(Offset = "0x10")]
			public Socket.TaskSocketAsyncEventArgs<Socket> TaskAccept;

			// Token: 0x04000FA0 RID: 4000
			[Token(Token = "0x4000FA0")]
			[FieldOffset(Offset = "0x18")]
			public Socket.Int32TaskSocketAsyncEventArgs TaskReceive;

			// Token: 0x04000FA1 RID: 4001
			[Token(Token = "0x4000FA1")]
			[FieldOffset(Offset = "0x20")]
			public Socket.Int32TaskSocketAsyncEventArgs TaskSend;

			// Token: 0x04000FA2 RID: 4002
			[Token(Token = "0x4000FA2")]
			[FieldOffset(Offset = "0x28")]
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive;

			// Token: 0x04000FA3 RID: 4003
			[Token(Token = "0x4000FA3")]
			[FieldOffset(Offset = "0x30")]
			public Socket.AwaitableSocketAsyncEventArgs ValueTaskSend;
		}

		// Token: 0x020003A8 RID: 936
		[Token(Token = "0x20003A8")]
		private class TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs
		{
			// Token: 0x06001995 RID: 6549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001995")]
			internal TaskSocketAsyncEventArgs()
			{
			}

			// Token: 0x06001996 RID: 6550 RVA: 0x0000B928 File Offset: 0x00009B28
			[Token(Token = "0x6001996")]
			internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool)
			{
				return default(AsyncTaskMethodBuilder<TResult>);
			}

			// Token: 0x04000FA4 RID: 4004
			[Token(Token = "0x4000FA4")]
			[FieldOffset(Offset = "0x0")]
			internal AsyncTaskMethodBuilder<TResult> _builder;

			// Token: 0x04000FA5 RID: 4005
			[Token(Token = "0x4000FA5")]
			[FieldOffset(Offset = "0x0")]
			internal bool _accessed;
		}

		// Token: 0x020003A9 RID: 937
		[Token(Token = "0x20003A9")]
		private sealed class Int32TaskSocketAsyncEventArgs : Socket.TaskSocketAsyncEventArgs<int>
		{
			// Token: 0x06001997 RID: 6551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001997")]
			[Address(RVA = "0x509DF40", Offset = "0x509CB40", VA = "0x18509DF40")]
			public Int32TaskSocketAsyncEventArgs()
			{
			}

			// Token: 0x04000FA6 RID: 4006
			[Token(Token = "0x4000FA6")]
			[FieldOffset(Offset = "0xD8")]
			internal bool _wrapExceptionsInIOExceptions;
		}

		// Token: 0x020003AA RID: 938
		[Token(Token = "0x20003AA")]
		internal sealed class AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int>
		{
			// Token: 0x06001998 RID: 6552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001998")]
			[Address(RVA = "0x509D2D0", Offset = "0x509BED0", VA = "0x18509D2D0")]
			public AwaitableSocketAsyncEventArgs()
			{
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x06001999 RID: 6553 RVA: 0x0000B940 File Offset: 0x00009B40
			// (set) Token: 0x0600199A RID: 6554 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700059F")]
			public bool WrapExceptionsInIOExceptions
			{
				[Token(Token = "0x6001999")]
				[Address(RVA = "0x509D340", Offset = "0x509BF40", VA = "0x18509D340")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600199A")]
				[Address(RVA = "0x509D350", Offset = "0x509BF50", VA = "0x18509D350")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600199B RID: 6555 RVA: 0x0000B958 File Offset: 0x00009B58
			[Token(Token = "0x600199B")]
			[Address(RVA = "0x509CDD0", Offset = "0x509B9D0", VA = "0x18509CDD0")]
			public bool Reserve()
			{
				return default(bool);
			}

			// Token: 0x0600199C RID: 6556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600199C")]
			[Address(RVA = "0x509CD50", Offset = "0x509B950", VA = "0x18509CD50")]
			private void Release()
			{
			}

			// Token: 0x0600199D RID: 6557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600199D")]
			[Address(RVA = "0x509C980", Offset = "0x509B580", VA = "0x18509C980", Slot = "5")]
			protected override void OnCompleted(SocketAsyncEventArgs _)
			{
			}

			// Token: 0x0600199E RID: 6558 RVA: 0x0000B970 File Offset: 0x00009B70
			[Token(Token = "0x600199E")]
			[Address(RVA = "0x509CBD0", Offset = "0x509B7D0", VA = "0x18509CBD0")]
			public ValueTask<int> ReceiveAsync(Socket socket)
			{
				return default(ValueTask<int>);
			}

			// Token: 0x0600199F RID: 6559 RVA: 0x0000B988 File Offset: 0x00009B88
			[Token(Token = "0x600199F")]
			[Address(RVA = "0x509CE50", Offset = "0x509BA50", VA = "0x18509CE50")]
			public ValueTask SendAsyncForNetworkStream(Socket socket)
			{
				return default(ValueTask);
			}

			// Token: 0x060019A0 RID: 6560 RVA: 0x0000B9A0 File Offset: 0x00009BA0
			[Token(Token = "0x60019A0")]
			[Address(RVA = "0x509C360", Offset = "0x509AF60", VA = "0x18509C360", Slot = "9")]
			public ValueTaskSourceStatus GetStatus(short token)
			{
				return ValueTaskSourceStatus.Pending;
			}

			// Token: 0x060019A1 RID: 6561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A1")]
			[Address(RVA = "0x509C760", Offset = "0x509B360", VA = "0x18509C760", Slot = "10")]
			public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
			{
			}

			// Token: 0x060019A2 RID: 6562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A2")]
			[Address(RVA = "0x509C400", Offset = "0x509B000", VA = "0x18509C400")]
			private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync)
			{
			}

			// Token: 0x060019A3 RID: 6563 RVA: 0x0000B9B8 File Offset: 0x00009BB8
			[Token(Token = "0x60019A3")]
			[Address(RVA = "0x509C300", Offset = "0x509AF00", VA = "0x18509C300", Slot = "11")]
			public int GetResult(short token)
			{
				return 0;
			}

			// Token: 0x060019A4 RID: 6564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A4")]
			[Address(RVA = "0x509CF80", Offset = "0x509BB80", VA = "0x18509CF80", Slot = "8")]
			private void GetResult(short token)
			{
			}

			// Token: 0x060019A5 RID: 6565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A5")]
			[Address(RVA = "0x509D000", Offset = "0x509BC00", VA = "0x18509D000")]
			private void ThrowIncorrectTokenException()
			{
			}

			// Token: 0x060019A6 RID: 6566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A6")]
			[Address(RVA = "0x509D060", Offset = "0x509BC60", VA = "0x18509D060")]
			private void ThrowMultipleContinuationsException()
			{
			}

			// Token: 0x060019A7 RID: 6567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A7")]
			[Address(RVA = "0x509CFD0", Offset = "0x509BBD0", VA = "0x18509CFD0")]
			private void ThrowException(SocketError error)
			{
			}

			// Token: 0x060019A8 RID: 6568 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60019A8")]
			[Address(RVA = "0x509C1F0", Offset = "0x509ADF0", VA = "0x18509C1F0")]
			private Exception CreateException(SocketError error)
			{
				return null;
			}

			// Token: 0x04000FA7 RID: 4007
			[Token(Token = "0x4000FA7")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly Socket.AwaitableSocketAsyncEventArgs Reserved;

			// Token: 0x04000FA8 RID: 4008
			[Token(Token = "0x4000FA8")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Action<object> s_completedSentinel;

			// Token: 0x04000FA9 RID: 4009
			[Token(Token = "0x4000FA9")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Action<object> s_availableSentinel;

			// Token: 0x04000FAA RID: 4010
			[Token(Token = "0x4000FAA")]
			[FieldOffset(Offset = "0xB8")]
			private Action<object> _continuation;

			// Token: 0x04000FAB RID: 4011
			[Token(Token = "0x4000FAB")]
			[FieldOffset(Offset = "0xC0")]
			private ExecutionContext _executionContext;

			// Token: 0x04000FAC RID: 4012
			[Token(Token = "0x4000FAC")]
			[FieldOffset(Offset = "0xC8")]
			private object _scheduler;

			// Token: 0x04000FAD RID: 4013
			[Token(Token = "0x4000FAD")]
			[FieldOffset(Offset = "0xD0")]
			private short _token;
		}

		// Token: 0x020003AC RID: 940
		[Token(Token = "0x20003AC")]
		private struct WSABUF
		{
			// Token: 0x04000FB2 RID: 4018
			[Token(Token = "0x4000FB2")]
			[FieldOffset(Offset = "0x0")]
			public int len;

			// Token: 0x04000FB3 RID: 4019
			[Token(Token = "0x4000FB3")]
			[FieldOffset(Offset = "0x8")]
			public IntPtr buf;
		}
	}
}
