using System;
using System.Collections;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YoStar.SDK.Net
{
	// Token: 0x020001DE RID: 478
	[Token(Token = "0x20001DE")]
	public class HttpClient
	{
		// Token: 0x06000B78 RID: 2936 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private HttpClient()
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x5C89250", Offset = "0x5C87E50", VA = "0x185C89250")]
		public static Task<Response<object>> DoRequest(Request request)
		{
			return null;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x5C89600", Offset = "0x5C88200", VA = "0x185C89600")]
		private static Task<Response<object>> GetConnect(Request request)
		{
			return null;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x5C89340", Offset = "0x5C87F40", VA = "0x185C89340")]
		public static Task<Response<object>> DoUploadFileRequest(Request request, byte[] datas)
		{
			return null;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x5C89450", Offset = "0x5C88050", VA = "0x185C89450")]
		private static Task<Response<object>> GetConnectUploadFile(Request request, byte[] datas)
		{
			return null;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x5C88B90", Offset = "0x5C87790", VA = "0x185C88B90")]
		private static UnityWebRequest BuildUploadFileWebRequest(Request request, byte[] datas)
		{
			return null;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x5C88FF0", Offset = "0x5C87BF0", VA = "0x185C88FF0")]
		public static void DoRequest(Request request, HttpClient.ResponseResultDelegate callback)
		{
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x5C89570", Offset = "0x5C88170", VA = "0x185C89570")]
		private static IEnumerator GetConnect(Request request, HttpClient.ResponseDelegate callback)
		{
			return null;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x5C88500", Offset = "0x5C87100", VA = "0x185C88500")]
		private static Response<object> BuildResponse(UnityWebRequest webRequest, Request request)
		{
			return null;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x5C88D90", Offset = "0x5C87990", VA = "0x185C88D90")]
		private static UploadHandlerRaw BuildUploadHandlerRaw(string requestBody)
		{
			return null;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x5C88E30", Offset = "0x5C87A30", VA = "0x185C88E30")]
		private static UnityWebRequest BuildWebRequest(Request request)
		{
			return null;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x5C89700", Offset = "0x5C88300", VA = "0x185C89700")]
		private static void OutputHttpLog(Request request, Response<object> sdkResponse, string requestBody)
		{
		}

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x0")]
		private static string RequestHeaderAuthKey;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x8")]
		private static string RequestHeaderGrayTagKey;

		// Token: 0x020001DF RID: 479
		// (Invoke) Token: 0x06000B86 RID: 2950
		[Token(Token = "0x20001DF")]
		public delegate void ResponseDelegate(Response<object> response);

		// Token: 0x020001E0 RID: 480
		// (Invoke) Token: 0x06000B8A RID: 2954
		[Token(Token = "0x20001E0")]
		public delegate void ResponseResultDelegate(ResponseResult<object> responseResult);
	}
}
