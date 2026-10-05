using System;
using System.Collections.Generic;
using System.Net;
using Il2CppDummyDll;

namespace YoStar.SDK.Help
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	public class GoogleHelper
	{
		// Token: 0x06000DBA RID: 3514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x5C87E90", Offset = "0x5C86A90", VA = "0x185C87E90")]
		public static GoogleHelper getInstance()
		{
			return null;
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BB")]
		public HttpListener HttpListener
		{
			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x5C87530", Offset = "0x5C86130", VA = "0x185C87530")]
		public void OpenURL(string clientID, string clientSecret, Action<ThirdAuthRet> callback)
		{
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x5C872E0", Offset = "0x5C85EE0", VA = "0x185C872E0")]
		public void Auth()
		{
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x5C881A0", Offset = "0x5C86DA0", VA = "0x185C881A0")]
		private void performCodeExchange(string code, string code_verifier, string redirectURI)
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x5C88430", Offset = "0x5C87030", VA = "0x185C88430")]
		private void userInfoCall(string access_token)
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x5C88190", Offset = "0x5C86D90", VA = "0x185C88190")]
		private void output(string output)
		{
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x5C882C0", Offset = "0x5C86EC0", VA = "0x185C882C0")]
		private string randomDataBase64url(uint length)
		{
			return null;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x5C88380", Offset = "0x5C86F80", VA = "0x185C88380")]
		private byte[] sha256(string inputStirng)
		{
			return null;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x5C87D90", Offset = "0x5C86990", VA = "0x185C87D90")]
		private string base64urlencodeNoPadding(byte[] buffer)
		{
			return null;
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000040F4 File Offset: 0x000022F4
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x5C87380", Offset = "0x5C85F80", VA = "0x185C87380")]
		private int GetRandomUnusedPort()
		{
			return 0;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x5C87C20", Offset = "0x5C86820", VA = "0x185C87C20")]
		public GoogleHelper()
		{
		}

		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x400090B")]
		[FieldOffset(Offset = "0x10")]
		private string redirectURI;

		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x400090C")]
		[FieldOffset(Offset = "0x18")]
		private string state;

		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x400090D")]
		[FieldOffset(Offset = "0x20")]
		private string code_verifier;

		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x28")]
		private string code_challenge;

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x30")]
		private string clientID;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x38")]
		private string clientSecret;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		private const string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		private const string tokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		private const string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x40")]
		private HttpListener httpListener;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x48")]
		private Action<ThirdAuthRet> callbackGlobal;

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, object> callbackJsonData;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x58")]
		private ThirdAuthRet thirdAuthRet;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x0")]
		private static GoogleHelper mInstance;

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x8")]
		private static object lockObj;
	}
}
