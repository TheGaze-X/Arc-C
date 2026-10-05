using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	public class TcpClient : IDisposable
	{
		// Token: 0x060019E1 RID: 6625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x50C46E0", Offset = "0x50C32E0", VA = "0x1850C46E0")]
		public TcpClient()
		{
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E2")]
		[Address(RVA = "0x50C47F0", Offset = "0x50C33F0", VA = "0x1850C47F0")]
		public TcpClient(AddressFamily family)
		{
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x50C47A0", Offset = "0x50C33A0", VA = "0x1850C47A0")]
		internal TcpClient(Socket acceptedSocket)
		{
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A4")]
		public Socket Client
		{
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019E5")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E6")]
		[Address(RVA = "0x50C3CE0", Offset = "0x50C28E0", VA = "0x1850C3CE0")]
		public void Connect(string hostname, int port)
		{
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x50C3BC0", Offset = "0x50C27C0", VA = "0x1850C3BC0")]
		public void Connect(IPEndPoint remoteEP)
		{
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019E8")]
		[Address(RVA = "0x50C3970", Offset = "0x50C2570", VA = "0x1850C3970")]
		public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state)
		{
			return null;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E9")]
		[Address(RVA = "0x50C4510", Offset = "0x50C3110", VA = "0x1850C4510")]
		public void EndConnect(IAsyncResult asyncResult)
		{
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019EA")]
		[Address(RVA = "0x50C3A40", Offset = "0x50C2640", VA = "0x1850C3A40")]
		public Task ConnectAsync(string host, int port)
		{
			return null;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019EB")]
		[Address(RVA = "0x50C4560", Offset = "0x50C3160", VA = "0x1850C4560")]
		public NetworkStream GetStream()
		{
			return null;
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EC")]
		[Address(RVA = "0x50C39F0", Offset = "0x50C25F0", VA = "0x1850C39F0")]
		public void Close()
		{
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019ED")]
		[Address(RVA = "0x50C43A0", Offset = "0x50C2FA0", VA = "0x1850C43A0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x50C4360", Offset = "0x50C2F60", VA = "0x1850C4360", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x50C4970", Offset = "0x50C3570", VA = "0x1850C4970")]
		private void initialize()
		{
		}

		// Token: 0x040010BA RID: 4282
		[Token(Token = "0x40010BA")]
		[FieldOffset(Offset = "0x10")]
		private Socket m_ClientSocket;

		// Token: 0x040010BB RID: 4283
		[Token(Token = "0x40010BB")]
		[FieldOffset(Offset = "0x18")]
		private bool m_Active;

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		[FieldOffset(Offset = "0x20")]
		private NetworkStream m_DataStream;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x28")]
		private AddressFamily m_Family;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_CleanedUp;
	}
}
