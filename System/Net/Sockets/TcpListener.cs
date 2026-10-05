using System;
using Il2CppDummyDll;

namespace System.Net.Sockets
{
	// Token: 0x020003C4 RID: 964
	[Token(Token = "0x20003C4")]
	public class TcpListener
	{
		// Token: 0x060019F1 RID: 6641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F1")]
		[Address(RVA = "0x50C4DA0", Offset = "0x50C39A0", VA = "0x1850C4DA0")]
		public TcpListener(IPAddress localaddr, int port)
		{
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A5")]
		public EndPoint LocalEndpoint
		{
			[Token(Token = "0x60019F2")]
			[Address(RVA = "0x50C4FB0", Offset = "0x50C3BB0", VA = "0x1850C4FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F3")]
		[Address(RVA = "0x50C4B20", Offset = "0x50C3720", VA = "0x1850C4B20")]
		public void Start()
		{
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F4")]
		[Address(RVA = "0x50C4B30", Offset = "0x50C3730", VA = "0x1850C4B30")]
		public void Start(int backlog)
		{
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019F5")]
		[Address(RVA = "0x50C4C80", Offset = "0x50C3880", VA = "0x1850C4C80")]
		public void Stop()
		{
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x50C4A00", Offset = "0x50C3600", VA = "0x1850C4A00")]
		public TcpClient AcceptTcpClient()
		{
			return null;
		}

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0x10")]
		private IPEndPoint m_ServerSocketEP;

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x18")]
		private Socket m_ServerSocket;

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x20")]
		private bool m_Active;

		// Token: 0x040010C2 RID: 4290
		[Token(Token = "0x40010C2")]
		[FieldOffset(Offset = "0x21")]
		private bool m_ExclusiveAddressUse;
	}
}
