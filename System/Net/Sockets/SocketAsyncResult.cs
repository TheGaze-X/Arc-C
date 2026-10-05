using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	[StructLayout(0)]
	internal sealed class SocketAsyncResult : IOAsyncResult
	{
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x170005B5")]
		public IntPtr Handle
		{
			[Token(Token = "0x6001A1F")]
			[Address(RVA = "0x50C1B30", Offset = "0x50C0730", VA = "0x1850C1B30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SocketAsyncResult()
		{
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x50C1900", Offset = "0x50C0500", VA = "0x1850C1900")]
		public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
		{
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x50C1A30", Offset = "0x50C0630", VA = "0x1850C1A30")]
		public SocketAsyncResult(Socket socket, AsyncCallback callback, object state, SocketOperation operation)
		{
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x170005B6")]
		public SocketError ErrorCode
		{
			[Token(Token = "0x6001A23")]
			[Address(RVA = "0x50C1A80", Offset = "0x50C0680", VA = "0x1850C1A80")]
			get
			{
				return SocketError.Success;
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x50C14D0", Offset = "0x50C00D0", VA = "0x1850C14D0")]
		public void CheckIfThrowDelayedException()
		{
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x50C1580", Offset = "0x50C0180", VA = "0x1850C1580", Slot = "8")]
		internal override void CompleteDisposed()
		{
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x50C1690", Offset = "0x50C0290", VA = "0x1850C1690")]
		public void Complete()
		{
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x50C1590", Offset = "0x50C0190", VA = "0x1850C1590")]
		public void Complete(bool synch)
		{
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x50C1650", Offset = "0x50C0250", VA = "0x1850C1650")]
		public void Complete(int total)
		{
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x50C15D0", Offset = "0x50C01D0", VA = "0x1850C15D0")]
		public void Complete(Exception e, bool synch)
		{
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x50C15A0", Offset = "0x50C01A0", VA = "0x1850C15A0")]
		public void Complete(Exception e)
		{
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x50C1660", Offset = "0x50C0260", VA = "0x1850C1660")]
		public void Complete(Socket s)
		{
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x50C1610", Offset = "0x50C0210", VA = "0x1850C1610")]
		public void Complete(Socket s, int total)
		{
		}

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Socket socket;

		// Token: 0x040010E9 RID: 4329
		[Token(Token = "0x40010E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SocketOperation operation;

		// Token: 0x040010EA RID: 4330
		[Token(Token = "0x40010EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Exception DelayedException;

		// Token: 0x040010EB RID: 4331
		[Token(Token = "0x40010EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public EndPoint EndPoint;

		// Token: 0x040010EC RID: 4332
		[Token(Token = "0x40010EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Memory<byte> Buffer;

		// Token: 0x040010ED RID: 4333
		[Token(Token = "0x40010ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int Offset;

		// Token: 0x040010EE RID: 4334
		[Token(Token = "0x40010EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int Size;

		// Token: 0x040010EF RID: 4335
		[Token(Token = "0x40010EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SocketFlags SockFlags;

		// Token: 0x040010F0 RID: 4336
		[Token(Token = "0x40010F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Socket AcceptSocket;

		// Token: 0x040010F1 RID: 4337
		[Token(Token = "0x40010F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IPAddress[] Addresses;

		// Token: 0x040010F2 RID: 4338
		[Token(Token = "0x40010F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int Port;

		// Token: 0x040010F3 RID: 4339
		[Token(Token = "0x40010F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IList<ArraySegment<byte>> Buffers;

		// Token: 0x040010F4 RID: 4340
		[Token(Token = "0x40010F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool ReuseSocket;

		// Token: 0x040010F5 RID: 4341
		[Token(Token = "0x40010F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int CurrentAddress;

		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Socket AcceptedSocket;

		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int Total;

		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		internal int error;

		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int EndCalled;
	}
}
