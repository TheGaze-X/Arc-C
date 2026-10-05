using System;
using Il2CppDummyDll;
using UDatasdk.LitJson;

namespace UDatasdk.commons
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	internal class HttpClient
	{
		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private HttpClient()
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x55AD350", Offset = "0x55ABF50", VA = "0x1855AD350")]
		public static void DoSyncRequest(HttpMethod method, Request request, HttpClient.ResponseDelegate callback)
		{
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x55ACE70", Offset = "0x55ABA70", VA = "0x1855ACE70")]
		public static void DoAsyncRequest(HttpMethod method, Request request, HttpClient.ResponseDelegate callback)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x55AD1D0", Offset = "0x55ABDD0", VA = "0x1855AD1D0")]
		public static void DoPostRequestAsync(Request request, HttpClient.ResponseDelegate callback)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x55AD2E0", Offset = "0x55ABEE0", VA = "0x1855AD2E0")]
		public static void DoPostRequest(Request request, HttpClient.ResponseDelegate callback)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x55ADBE0", Offset = "0x55AC7E0", VA = "0x1855ADBE0")]
		private static Response<JsonData> PostHttpRequest(Request request)
		{
			return null;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x55AD050", Offset = "0x55ABC50", VA = "0x1855AD050")]
		public static void DoGetRequestAsync(Request request, HttpClient.ResponseDelegate callback)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x55AD160", Offset = "0x55ABD60", VA = "0x1855AD160")]
		public static void DoGetRequest(Request request, HttpClient.ResponseDelegate callback)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x55AD3F0", Offset = "0x55ABFF0", VA = "0x1855AD3F0")]
		private static Response<JsonData> GetHttpRequest(Request request)
		{
			return null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x55ADAE0", Offset = "0x55AC6E0", VA = "0x1855ADAE0")]
		private static void MainThreadCall(HttpClient.ResponseDelegate callBack, Response<JsonData> ret)
		{
		}

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000213 RID: 531
		[Token(Token = "0x200003D")]
		public delegate void ResponseDelegate(Response<JsonData> response);
	}
}
