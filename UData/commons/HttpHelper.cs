using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Il2CppDummyDll;
using UDatasdk.LitJson;

namespace UDatasdk.commons
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal class HttpHelper
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x55AFBB0", Offset = "0x55AE7B0", VA = "0x1855AFBB0")]
		public HttpHelper()
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x55AF9F0", Offset = "0x55AE5F0", VA = "0x1855AF9F0")]
		public void InitCookie()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
		public void SetEncoding(Encoding en)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
		public void SetUserAgent(string ua)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
		public void SetTimeOut(int msec)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
		public void SetContentType(string type)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
		public void SetAccept(string accept)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x55ADF00", Offset = "0x55ACB00", VA = "0x1855ADF00")]
		public void AddHeader(string key, string ctx)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x55ADF70", Offset = "0x55ACB70", VA = "0x1855ADF70")]
		public void ClearHeader()
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x55AE2B0", Offset = "0x55ACEB0", VA = "0x1855AE2B0")]
		private string GetStringFromResponse(HttpWebResponse response)
		{
			return null;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
		private bool CheckCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
		{
			return default(bool);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x55AEAA0", Offset = "0x55AD6A0", VA = "0x1855AEAA0")]
		public Response<JsonData> HttpGet(string url)
		{
			return null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x55AEAB0", Offset = "0x55AD6B0", VA = "0x1855AEAB0")]
		public Response<JsonData> HttpGet(string url, string refer)
		{
			return null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x55AE410", Offset = "0x55AD010", VA = "0x1855AE410")]
		public byte[] HttpGetMine(string url)
		{
			return null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x55AF9D0", Offset = "0x55AE5D0", VA = "0x1855AF9D0")]
		public Response<JsonData> HttpPost(string url, string data)
		{
			return null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x55AF180", Offset = "0x55ADD80", VA = "0x1855AF180")]
		public Response<JsonData> HttpPost(string url, string data, string refer)
		{
			return null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x55AFA40", Offset = "0x55AE640", VA = "0x1855AFA40")]
		public string UrlEncode(string str)
		{
			return null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x55ADFC0", Offset = "0x55ACBC0", VA = "0x1855ADFC0")]
		private CookieCollection ConvertCookieString(string ck)
		{
			return null;
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		private const int ConnectionLimit = 100;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x10")]
		private Encoding _encoding;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x18")]
		private string _useragent;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x20")]
		private string _accept;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x28")]
		private int _timeout;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x30")]
		private string _contenttype;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _headers;
	}
}
