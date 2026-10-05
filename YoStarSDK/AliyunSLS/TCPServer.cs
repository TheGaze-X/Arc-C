using System;
using System.Net.Sockets;
using System.Threading;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	public sealed class TCPServer
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x5BE3DC0", Offset = "0x5BE29C0", VA = "0x185BE3DC0")]
		public void Start()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
		public int getLocalPort()
		{
			return 0;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
		public void setCallback(log_callback cb)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x5BE38D0", Offset = "0x5BE24D0", VA = "0x185BE38D0")]
		private void RunServer()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x5BE3D80", Offset = "0x5BE2980", VA = "0x185BE3D80")]
		public void Shut()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TCPServer()
		{
		}

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x10")]
		private Thread tcpServerThread;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		private TcpListener tcpListener;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		private int port;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		private log_callback callback;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x30")]
		private bool quit;
	}
}
