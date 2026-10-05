using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	internal sealed class HttpConnection
	{
		// Token: 0x0600158F RID: 5519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600158F")]
		[Address(RVA = "0x5075020", Offset = "0x5073C20", VA = "0x185075020")]
		public HttpConnection(Socket sock, EndPointListener epl, bool secure, X509Certificate cert)
		{
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001590")]
		[Address(RVA = "0x5073F50", Offset = "0x5072B50", VA = "0x185073F50")]
		private void Init()
		{
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x1700048A")]
		public int Reuses
		{
			[Token(Token = "0x6001591")]
			[Address(RVA = "0x12905C0", Offset = "0x128F1C0", VA = "0x1812905C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048B")]
		public IPEndPoint LocalEndPoint
		{
			[Token(Token = "0x6001592")]
			[Address(RVA = "0x5075340", Offset = "0x5073F40", VA = "0x185075340")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x1700048C")]
		public bool IsSecure
		{
			[Token(Token = "0x6001593")]
			[Address(RVA = "0xE31BA0", Offset = "0xE307A0", VA = "0x180E31BA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700048D RID: 1165
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048D")]
		public ListenerPrefix Prefix
		{
			[Token(Token = "0x6001594")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30")]
			set
			{
			}
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001595")]
		[Address(RVA = "0x5074530", Offset = "0x5073130", VA = "0x185074530")]
		private void OnTimeout(object unused)
		{
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001596")]
		[Address(RVA = "0x5073600", Offset = "0x5072200", VA = "0x185073600")]
		public void BeginReadRequest()
		{
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001597")]
		[Address(RVA = "0x5073AD0", Offset = "0x50726D0", VA = "0x185073AD0")]
		public RequestStream GetRequestStream(bool chunked, long contentlength)
		{
			return null;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001598")]
		[Address(RVA = "0x5073E50", Offset = "0x5072A50", VA = "0x185073E50")]
		public ResponseStream GetResponseStream()
		{
			return null;
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001599")]
		[Address(RVA = "0x5074490", Offset = "0x5073090", VA = "0x185074490")]
		private static void OnRead(IAsyncResult ares)
		{
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159A")]
		[Address(RVA = "0x5074040", Offset = "0x5072C40", VA = "0x185074040")]
		private void OnReadInternal(IAsyncResult ares)
		{
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159B")]
		[Address(RVA = "0x5074AD0", Offset = "0x50736D0", VA = "0x185074AD0")]
		private void RemoveConnection()
		{
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x600159C")]
		[Address(RVA = "0x5074580", Offset = "0x5073180", VA = "0x185074580")]
		private bool ProcessInput(MemoryStream ms)
		{
			return default(bool);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600159D")]
		[Address(RVA = "0x5074950", Offset = "0x5073550", VA = "0x185074950")]
		private string ReadLine(byte[] buffer, int offset, int len, ref int used)
		{
			return null;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159E")]
		[Address(RVA = "0x5074B50", Offset = "0x5073750", VA = "0x185074B50")]
		public void SendError(string msg, int status)
		{
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600159F")]
		[Address(RVA = "0x5074DA0", Offset = "0x50739A0", VA = "0x185074DA0")]
		public void SendError()
		{
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A0")]
		[Address(RVA = "0x5074F30", Offset = "0x5073B30", VA = "0x185074F30")]
		private void Unbind()
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A1")]
		[Address(RVA = "0x5073780", Offset = "0x5072380", VA = "0x185073780")]
		private void CloseSocket()
		{
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015A2")]
		[Address(RVA = "0x5073840", Offset = "0x5072440", VA = "0x185073840")]
		internal void Close(bool force_close)
		{
		}

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x0")]
		private static AsyncCallback onread_cb;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x10")]
		private Socket sock;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x18")]
		private Stream stream;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x20")]
		private EndPointListener epl;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x28")]
		private MemoryStream ms;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x30")]
		private byte[] buffer;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x38")]
		private HttpListenerContext context;

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4000BCF")]
		[FieldOffset(Offset = "0x40")]
		private StringBuilder current_line;

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4000BD0")]
		[FieldOffset(Offset = "0x48")]
		private ListenerPrefix prefix;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4000BD1")]
		[FieldOffset(Offset = "0x50")]
		private RequestStream i_stream;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[FieldOffset(Offset = "0x58")]
		private ResponseStream o_stream;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4000BD3")]
		[FieldOffset(Offset = "0x60")]
		private bool chunked;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[FieldOffset(Offset = "0x64")]
		private int reuses;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[FieldOffset(Offset = "0x68")]
		private bool context_bound;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[FieldOffset(Offset = "0x69")]
		private bool secure;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[FieldOffset(Offset = "0x70")]
		private X509Certificate cert;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		[FieldOffset(Offset = "0x78")]
		private int s_timeout;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[FieldOffset(Offset = "0x80")]
		private Timer timer;

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		[FieldOffset(Offset = "0x88")]
		private IPEndPoint local_ep;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		[FieldOffset(Offset = "0x90")]
		private HttpListener last_listener;

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x98")]
		private int[] client_cert_errors;

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0xA0")]
		private X509Certificate2 client_cert;

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0xA8")]
		private SslStream ssl_stream;

		// Token: 0x04000BDF RID: 3039
		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0xB0")]
		private HttpConnection.InputState input_state;

		// Token: 0x04000BE0 RID: 3040
		[Token(Token = "0x4000BE0")]
		[FieldOffset(Offset = "0xB4")]
		private HttpConnection.LineState line_state;

		// Token: 0x04000BE1 RID: 3041
		[Token(Token = "0x4000BE1")]
		[FieldOffset(Offset = "0xB8")]
		private int position;

		// Token: 0x02000313 RID: 787
		[Token(Token = "0x2000313")]
		private enum InputState
		{
			// Token: 0x04000BE3 RID: 3043
			[Token(Token = "0x4000BE3")]
			RequestLine,
			// Token: 0x04000BE4 RID: 3044
			[Token(Token = "0x4000BE4")]
			Headers
		}

		// Token: 0x02000314 RID: 788
		[Token(Token = "0x2000314")]
		private enum LineState
		{
			// Token: 0x04000BE6 RID: 3046
			[Token(Token = "0x4000BE6")]
			None,
			// Token: 0x04000BE7 RID: 3047
			[Token(Token = "0x4000BE7")]
			CR,
			// Token: 0x04000BE8 RID: 3048
			[Token(Token = "0x4000BE8")]
			LF
		}
	}
}
