using System;
using System.Security.Principal;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	public sealed class HttpListenerContext
	{
		// Token: 0x060015BF RID: 5567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x5075830", Offset = "0x5074430", VA = "0x185075830")]
		internal HttpListenerContext(HttpConnection cnc)
		{
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x0000A020 File Offset: 0x00008220
		// (set) Token: 0x060015C1 RID: 5569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000494")]
		internal int ErrorStatus
		{
			[Token(Token = "0x60015C0")]
			[Address(RVA = "0x926F70", Offset = "0x925B70", VA = "0x180926F70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60015C1")]
			[Address(RVA = "0x927040", Offset = "0x925C40", VA = "0x180927040")]
			set
			{
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060015C3 RID: 5571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000495")]
		internal string ErrorMessage
		{
			[Token(Token = "0x60015C2")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015C3")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x17000496")]
		internal bool HaveError
		{
			[Token(Token = "0x60015C4")]
			[Address(RVA = "0x1FF9050", Offset = "0x1FF7C50", VA = "0x181FF9050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060015C5 RID: 5573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000497")]
		internal HttpConnection Connection
		{
			[Token(Token = "0x60015C5")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000498")]
		public HttpListenerRequest Request
		{
			[Token(Token = "0x60015C6")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000499")]
		public HttpListenerResponse Response
		{
			[Token(Token = "0x60015C7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x5075510", Offset = "0x5074110", VA = "0x185075510")]
		internal void ParseAuthentication(AuthenticationSchemes expectedSchemes)
		{
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x5075640", Offset = "0x5074240", VA = "0x185075640")]
		internal IPrincipal ParseBasicAuthentication(string authData)
		{
			return null;
		}

		// Token: 0x04000BFB RID: 3067
		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x10")]
		private HttpListenerRequest request;

		// Token: 0x04000BFC RID: 3068
		[Token(Token = "0x4000BFC")]
		[FieldOffset(Offset = "0x18")]
		private HttpListenerResponse response;

		// Token: 0x04000BFD RID: 3069
		[Token(Token = "0x4000BFD")]
		[FieldOffset(Offset = "0x20")]
		private IPrincipal user;

		// Token: 0x04000BFE RID: 3070
		[Token(Token = "0x4000BFE")]
		[FieldOffset(Offset = "0x28")]
		private HttpConnection cnc;

		// Token: 0x04000BFF RID: 3071
		[Token(Token = "0x4000BFF")]
		[FieldOffset(Offset = "0x30")]
		private string error;

		// Token: 0x04000C00 RID: 3072
		[Token(Token = "0x4000C00")]
		[FieldOffset(Offset = "0x38")]
		private int err_status;

		// Token: 0x04000C01 RID: 3073
		[Token(Token = "0x4000C01")]
		[FieldOffset(Offset = "0x40")]
		internal HttpListener Listener;
	}
}
