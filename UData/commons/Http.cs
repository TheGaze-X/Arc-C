using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UDatasdk.LitJson;

namespace UDatasdk.commons
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	internal class Http
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private Http()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x55B0060", Offset = "0x55AEC60", VA = "0x1855B0060")]
		public static Response<JsonData> GetHttp(string url, string body)
		{
			return null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x55B0F20", Offset = "0x55AFB20", VA = "0x1855B0F20")]
		public static Response<JsonData> PostHttp(string url, Dictionary<string, object> body, PostType type = PostType.FROM)
		{
			return null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x55B0C50", Offset = "0x55AF850", VA = "0x1855B0C50")]
		private static Response<JsonData> PostForm(string url, Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x55B17A0", Offset = "0x55B03A0", VA = "0x1855B17A0")]
		private static Response<JsonData> PostJson(string url, Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x55B11B0", Offset = "0x55AFDB0", VA = "0x1855B11B0")]
		private static Response<JsonData> PostJson1(string url, Dictionary<string, object> body)
		{
			return null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x55B0190", Offset = "0x55AED90", VA = "0x1855B0190")]
		public static Response<JsonData> GetJson(string url, string paramStr, int timeout = 6000)
		{
			return null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x55AFD20", Offset = "0x55AE920", VA = "0x1855AFD20")]
		public static string GenerateAuthHeader(string parameters)
		{
			return null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000020B2 File Offset: 0x000002B2
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x55B0A60", Offset = "0x55AF660", VA = "0x1855B0A60")]
		public static string GetMd5Hash(string input)
		{
			return null;
		}
	}
}
