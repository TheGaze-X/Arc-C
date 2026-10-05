using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public static class SteamHTTP
	{
		// Token: 0x06000238 RID: 568 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x4EC2610", Offset = "0x4EC1210", VA = "0x184EC2610")]
		public static HTTPRequestHandle CreateHTTPRequest(EHTTPMethod eHTTPRequestMethod, string pchAbsoluteURL)
		{
			return default(HTTPRequestHandle);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x4EC3110", Offset = "0x4EC1D10", VA = "0x184EC3110")]
		public static bool SetHTTPRequestContextValue(HTTPRequestHandle hRequest, ulong ulContextValue)
		{
			return default(bool);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x4EC3570", Offset = "0x4EC2170", VA = "0x184EC3570")]
		public static bool SetHTTPRequestNetworkActivityTimeout(HTTPRequestHandle hRequest, uint unTimeoutSeconds)
		{
			return default(bool);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x4EC33A0", Offset = "0x4EC1FA0", VA = "0x184EC33A0")]
		public static bool SetHTTPRequestHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, string pchHeaderValue)
		{
			return default(bool);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x4EC31D0", Offset = "0x4EC1DD0", VA = "0x184EC31D0")]
		public static bool SetHTTPRequestGetOrPostParameter(HTTPRequestHandle hRequest, string pchParamName, string pchParamValue)
		{
			return default(bool);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00004B2C File Offset: 0x00002D2C
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x4EC2DD0", Offset = "0x4EC19D0", VA = "0x184EC2DD0")]
		public static bool SendHTTPRequest(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x4EC2D70", Offset = "0x4EC1970", VA = "0x184EC2D70")]
		public static bool SendHTTPRequestAndStreamResponse(HTTPRequestHandle hRequest, out SteamAPICall_t pCallHandle)
		{
			return default(bool);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x4EC2770", Offset = "0x4EC1370", VA = "0x184EC2770")]
		public static bool DeferHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00004B74 File Offset: 0x00002D74
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x4EC2C80", Offset = "0x4EC1880", VA = "0x184EC2C80")]
		public static bool PrioritizeHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x4EC2960", Offset = "0x4EC1560", VA = "0x184EC2960")]
		public static bool GetHTTPResponseHeaderSize(HTTPRequestHandle hRequest, string pchHeaderName, out uint unResponseHeaderSize)
		{
			return default(bool);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x4EC2AA0", Offset = "0x4EC16A0", VA = "0x184EC2AA0")]
		public static bool GetHTTPResponseHeaderValue(HTTPRequestHandle hRequest, string pchHeaderName, byte[] pHeaderValueBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x4EC2900", Offset = "0x4EC1500", VA = "0x184EC2900")]
		public static bool GetHTTPResponseBodySize(HTTPRequestHandle hRequest, out uint unBodySize)
		{
			return default(bool);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x4EC2880", Offset = "0x4EC1480", VA = "0x184EC2880")]
		public static bool GetHTTPResponseBodyData(HTTPRequestHandle hRequest, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x4EC2BF0", Offset = "0x4EC17F0", VA = "0x184EC2BF0")]
		public static bool GetHTTPStreamingResponseBodyData(HTTPRequestHandle hRequest, uint cOffset, byte[] pBodyDataBuffer, uint unBufferSize)
		{
			return default(bool);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x4EC2D20", Offset = "0x4EC1920", VA = "0x184EC2D20")]
		public static bool ReleaseHTTPRequest(HTTPRequestHandle hRequest)
		{
			return default(bool);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x4EC27C0", Offset = "0x4EC13C0", VA = "0x184EC27C0")]
		public static bool GetHTTPDownloadProgressPct(HTTPRequestHandle hRequest, out float pflPercentOut)
		{
			return default(bool);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x4EC35D0", Offset = "0x4EC21D0", VA = "0x184EC35D0")]
		public static bool SetHTTPRequestRawPostBody(HTTPRequestHandle hRequest, string pchContentType, byte[] pubBody, uint unBodyLen)
		{
			return default(bool);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x4EC2580", Offset = "0x4EC1180", VA = "0x184EC2580")]
		public static HTTPCookieContainerHandle CreateCookieContainer(bool bAllowResponsesToModify)
		{
			return default(HTTPCookieContainerHandle);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x4EC2CD0", Offset = "0x4EC18D0", VA = "0x184EC2CD0")]
		public static bool ReleaseCookieContainer(HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x4EC2E30", Offset = "0x4EC1A30", VA = "0x184EC2E30")]
		public static bool SetCookie(HTTPCookieContainerHandle hCookieContainer, string pchHost, string pchUrl, string pchCookie)
		{
			return default(bool);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x4EC3170", Offset = "0x4EC1D70", VA = "0x184EC3170")]
		public static bool SetHTTPRequestCookieContainer(HTTPRequestHandle hRequest, HTTPCookieContainerHandle hCookieContainer)
		{
			return default(bool);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x4EC3780", Offset = "0x4EC2380", VA = "0x184EC3780")]
		public static bool SetHTTPRequestUserAgentInfo(HTTPRequestHandle hRequest, string pchUserAgentInfo)
		{
			return default(bool);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x4EC3720", Offset = "0x4EC2320", VA = "0x184EC3720")]
		public static bool SetHTTPRequestRequiresVerifiedCertificate(HTTPRequestHandle hRequest, bool bRequireVerifiedCertificate)
		{
			return default(bool);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00004CDC File Offset: 0x00002EDC
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x4EC30B0", Offset = "0x4EC1CB0", VA = "0x184EC30B0")]
		public static bool SetHTTPRequestAbsoluteTimeoutMS(HTTPRequestHandle hRequest, uint unMilliseconds)
		{
			return default(bool);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x4EC2820", Offset = "0x4EC1420", VA = "0x184EC2820")]
		public static bool GetHTTPRequestWasTimedOut(HTTPRequestHandle hRequest, out bool pbWasTimedOut)
		{
			return default(bool);
		}
	}
}
