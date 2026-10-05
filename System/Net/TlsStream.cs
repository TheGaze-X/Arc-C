using System;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000284 RID: 644
	[Token(Token = "0x2000284")]
	internal class TlsStream : NetworkStream
	{
		// Token: 0x06001213 RID: 4627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x51B5420", Offset = "0x51B4020", VA = "0x1851B5420")]
		public TlsStream(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates)
		{
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x51B4E90", Offset = "0x51B3A90", VA = "0x1851B4E90")]
		public void AuthenticateAsClient()
		{
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001215")]
		[Address(RVA = "0x51B4FD0", Offset = "0x51B3BD0", VA = "0x1851B4FD0")]
		public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state)
		{
			return null;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001216")]
		[Address(RVA = "0x51B5220", Offset = "0x51B3E20", VA = "0x1851B5220")]
		public void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x51B5180", Offset = "0x51B3D80", VA = "0x1851B5180", Slot = "26")]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x51B52D0", Offset = "0x51B3ED0", VA = "0x1851B52D0", Slot = "27")]
		public override void EndWrite(IAsyncResult result)
		{
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001219")]
		[Address(RVA = "0x51B53A0", Offset = "0x51B3FA0", VA = "0x1851B53A0", Slot = "35")]
		public override void Write(byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x600121A")]
		[Address(RVA = "0x51B5320", Offset = "0x51B3F20", VA = "0x1851B5320", Slot = "32")]
		public override int Read(byte[] buffer, int offset, int size)
		{
			return 0;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600121B")]
		[Address(RVA = "0x51B5130", Offset = "0x51B3D30", VA = "0x1851B5130", Slot = "22")]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x600121C")]
		[Address(RVA = "0x51B5270", Offset = "0x51B3E70", VA = "0x1851B5270", Slot = "23")]
		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600121D")]
		[Address(RVA = "0x51B51D0", Offset = "0x51B3DD0", VA = "0x1851B51D0", Slot = "18")]
		public override void Close()
		{
		}

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x40008D5")]
		[FieldOffset(Offset = "0x48")]
		private SslStream _sslStream;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x40008D6")]
		[FieldOffset(Offset = "0x50")]
		private string _host;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x40008D7")]
		[FieldOffset(Offset = "0x58")]
		private X509CertificateCollection _clientCertificates;
	}
}
