using System;
using System.Collections.Specialized;
using System.IO;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	public sealed class HttpListenerRequest
	{
		// Token: 0x060015D4 RID: 5588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x5077C40", Offset = "0x5076840", VA = "0x185077C40")]
		internal HttpListenerRequest(HttpListenerContext context)
		{
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D5")]
		[Address(RVA = "0x50777A0", Offset = "0x50763A0", VA = "0x1850777A0")]
		internal void SetRequestLine(string req)
		{
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015D6")]
		[Address(RVA = "0x50768A0", Offset = "0x50754A0", VA = "0x1850768A0")]
		private void CreateQueryString(string query)
		{
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x60015D7")]
		[Address(RVA = "0x5077710", Offset = "0x5076310", VA = "0x185077710")]
		private static bool MaybeUri(string s)
		{
			return default(bool);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x60015D8")]
		[Address(RVA = "0x5077550", Offset = "0x5076150", VA = "0x185077550")]
		private static bool IsPredefinedScheme(string scheme)
		{
			return default(bool);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x60015D9")]
		[Address(RVA = "0x5076AC0", Offset = "0x50756C0", VA = "0x185076AC0")]
		internal bool FinishInitialization()
		{
			return default(bool);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DA")]
		[Address(RVA = "0x5077AB0", Offset = "0x50766B0", VA = "0x185077AB0")]
		internal static string Unquote(string str)
		{
			return null;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015DB")]
		[Address(RVA = "0x50760A0", Offset = "0x5074CA0", VA = "0x1850760A0")]
		internal void AddHeader(string header)
		{
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x60015DC")]
		[Address(RVA = "0x5077230", Offset = "0x5075E30", VA = "0x185077230")]
		internal bool FlushInput()
		{
			return default(bool);
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x1700049C")]
		public bool HasEntityBody
		{
			[Token(Token = "0x60015DD")]
			[Address(RVA = "0x5077D10", Offset = "0x5076910", VA = "0x185077D10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049D")]
		public NameValueCollection Headers
		{
			[Token(Token = "0x60015DE")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049E")]
		public Stream InputStream
		{
			[Token(Token = "0x60015DF")]
			[Address(RVA = "0x5077D30", Offset = "0x5076930", VA = "0x185077D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x1700049F")]
		public bool IsSecureConnection
		{
			[Token(Token = "0x60015E0")]
			[Address(RVA = "0x5077DF0", Offset = "0x50769F0", VA = "0x185077DF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x170004A0")]
		public bool KeepAlive
		{
			[Token(Token = "0x60015E1")]
			[Address(RVA = "0x5077E20", Offset = "0x5076A20", VA = "0x185077E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A1")]
		public IPEndPoint LocalEndPoint
		{
			[Token(Token = "0x60015E2")]
			[Address(RVA = "0x5077FA0", Offset = "0x5076BA0", VA = "0x185077FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A2")]
		public Version ProtocolVersion
		{
			[Token(Token = "0x60015E3")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A3")]
		public NameValueCollection QueryString
		{
			[Token(Token = "0x60015E4")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A4")]
		public Uri Url
		{
			[Token(Token = "0x60015E5")]
			[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A5")]
		public string UserHostAddress
		{
			[Token(Token = "0x60015E6")]
			[Address(RVA = "0x5078110", Offset = "0x5076D10", VA = "0x185078110")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A6")]
		public string UserHostName
		{
			[Token(Token = "0x60015E7")]
			[Address(RVA = "0x5078160", Offset = "0x5076D60", VA = "0x185078160")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x10")]
		private string[] accept_types;

		// Token: 0x04000C05 RID: 3077
		[Token(Token = "0x4000C05")]
		[FieldOffset(Offset = "0x18")]
		private long content_length;

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x20")]
		private bool cl_set;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x28")]
		private CookieCollection cookies;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x30")]
		private WebHeaderCollection headers;

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x38")]
		private string method;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x40")]
		private Stream input_stream;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x48")]
		private Version version;

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x50")]
		private NameValueCollection query_string;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x58")]
		private string raw_url;

		// Token: 0x04000C0E RID: 3086
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x60")]
		private Uri url;

		// Token: 0x04000C0F RID: 3087
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x68")]
		private Uri referrer;

		// Token: 0x04000C10 RID: 3088
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x70")]
		private string[] user_languages;

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x78")]
		private HttpListenerContext context;

		// Token: 0x04000C12 RID: 3090
		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0x80")]
		private bool is_chunked;

		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0x81")]
		private bool ka_set;

		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0x82")]
		private bool keep_alive;

		// Token: 0x04000C15 RID: 3093
		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] _100continue;

		// Token: 0x04000C16 RID: 3094
		[Token(Token = "0x4000C16")]
		[FieldOffset(Offset = "0x8")]
		private static char[] separators;
	}
}
