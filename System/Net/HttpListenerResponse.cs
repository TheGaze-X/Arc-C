using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200031A RID: 794
	[Token(Token = "0x200031A")]
	public sealed class HttpListenerResponse : IDisposable
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x5079BD0", Offset = "0x50787D0", VA = "0x185079BD0")]
		internal HttpListenerResponse(HttpListenerContext context)
		{
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x170004A7")]
		internal bool ForceCloseChunked
		{
			[Token(Token = "0x60015EA")]
			[Address(RVA = "0x9069B0", Offset = "0x9055B0", VA = "0x1809069B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A8")]
		public Encoding ContentEncoding
		{
			[Token(Token = "0x60015EB")]
			[Address(RVA = "0x5079D20", Offset = "0x5078920", VA = "0x185079D20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (set) Token: 0x060015EC RID: 5612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A9")]
		public long ContentLength64
		{
			[Token(Token = "0x60015EC")]
			[Address(RVA = "0x5079DA0", Offset = "0x50789A0", VA = "0x185079DA0")]
			set
			{
			}
		}

		// Token: 0x170004AA RID: 1194
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AA")]
		public string ContentType
		{
			[Token(Token = "0x60015ED")]
			[Address(RVA = "0x5079EF0", Offset = "0x5078AF0", VA = "0x185079EF0")]
			set
			{
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AB")]
		public WebHeaderCollection Headers
		{
			[Token(Token = "0x60015EE")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AC")]
		public Stream OutputStream
		{
			[Token(Token = "0x60015EF")]
			[Address(RVA = "0x5079D50", Offset = "0x5078950", VA = "0x185079D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x0000A170 File Offset: 0x00008370
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AD")]
		public bool SendChunked
		{
			[Token(Token = "0x60015F0")]
			[Address(RVA = "0x1692620", Offset = "0x1691220", VA = "0x181692620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60015F1")]
			[Address(RVA = "0x5079FE0", Offset = "0x5078BE0", VA = "0x185079FE0")]
			set
			{
			}
		}

		// Token: 0x170004AE RID: 1198
		// (set) Token: 0x060015F2 RID: 5618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AE")]
		public int StatusCode
		{
			[Token(Token = "0x60015F2")]
			[Address(RVA = "0x507A0C0", Offset = "0x5078CC0", VA = "0x18507A0C0")]
			set
			{
			}
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x5079B20", Offset = "0x5078720", VA = "0x185079B20", Slot = "4")]
		private void Dispose()
		{
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x50783E0", Offset = "0x5076FE0", VA = "0x1850783E0")]
		private void Close(bool force)
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x50783A0", Offset = "0x5076FA0", VA = "0x1850783A0")]
		public void Close()
		{
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x50781B0", Offset = "0x5076DB0", VA = "0x1850781B0")]
		public void Close(byte[] responseEntity, bool willBlock)
		{
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F7")]
		[Address(RVA = "0x5078B90", Offset = "0x5077790", VA = "0x185078B90")]
		public void Redirect(string url)
		{
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015F8")]
		[Address(RVA = "0x5078BD0", Offset = "0x50777D0", VA = "0x185078BD0")]
		internal void SendHeaders(bool closing, MemoryStream ms)
		{
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F9")]
		[Address(RVA = "0x50786D0", Offset = "0x50772D0", VA = "0x1850786D0")]
		private static string FormatHeaders(WebHeaderCollection headers)
		{
			return null;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FA")]
		[Address(RVA = "0x5078410", Offset = "0x5077010", VA = "0x185078410")]
		private static string CookieToClientString(Cookie cookie)
		{
			return null;
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015FB")]
		[Address(RVA = "0x5078A30", Offset = "0x5077630", VA = "0x185078A30")]
		private static string QuotedString(Cookie cookie, string value)
		{
			return null;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x60015FC")]
		[Address(RVA = "0x5078960", Offset = "0x5077560", VA = "0x185078960")]
		private static bool IsToken(string value)
		{
			return default(bool);
		}

		// Token: 0x04000C17 RID: 3095
		[Token(Token = "0x4000C17")]
		[FieldOffset(Offset = "0x10")]
		private bool disposed;

		// Token: 0x04000C18 RID: 3096
		[Token(Token = "0x4000C18")]
		[FieldOffset(Offset = "0x18")]
		private Encoding content_encoding;

		// Token: 0x04000C19 RID: 3097
		[Token(Token = "0x4000C19")]
		[FieldOffset(Offset = "0x20")]
		private long content_length;

		// Token: 0x04000C1A RID: 3098
		[Token(Token = "0x4000C1A")]
		[FieldOffset(Offset = "0x28")]
		private bool cl_set;

		// Token: 0x04000C1B RID: 3099
		[Token(Token = "0x4000C1B")]
		[FieldOffset(Offset = "0x30")]
		private string content_type;

		// Token: 0x04000C1C RID: 3100
		[Token(Token = "0x4000C1C")]
		[FieldOffset(Offset = "0x38")]
		private CookieCollection cookies;

		// Token: 0x04000C1D RID: 3101
		[Token(Token = "0x4000C1D")]
		[FieldOffset(Offset = "0x40")]
		private WebHeaderCollection headers;

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4000C1E")]
		[FieldOffset(Offset = "0x48")]
		private bool keep_alive;

		// Token: 0x04000C1F RID: 3103
		[Token(Token = "0x4000C1F")]
		[FieldOffset(Offset = "0x50")]
		private ResponseStream output_stream;

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x58")]
		private Version version;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		[FieldOffset(Offset = "0x60")]
		private string location;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		[FieldOffset(Offset = "0x68")]
		private int status_code;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x70")]
		private string status_description;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x78")]
		private bool chunked;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x80")]
		private HttpListenerContext context;

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x88")]
		internal bool HeadersSent;

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0x90")]
		internal object headers_lock;

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		[FieldOffset(Offset = "0x98")]
		private bool force_close_chunked;

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		[FieldOffset(Offset = "0x0")]
		private static string tspecials;
	}
}
