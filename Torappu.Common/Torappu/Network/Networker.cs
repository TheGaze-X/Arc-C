using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BestHTTP;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;
using XLua;

namespace Torappu.Network
{
	// Token: 0x02000214 RID: 532
	[Token(Token = "0x2000214")]
	public class Networker : SingletonMonoBehaviour<Networker>, ISingletonNotAutoCreate, IHotfixable
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0000827C File Offset: 0x0000647C
		[Token(Token = "0x17000130")]
		protected Networker.Configuration networkConfig
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x556FB40", Offset = "0x556E740", VA = "0x18556FB40")]
			get
			{
				return default(Networker.Configuration);
			}
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00008294 File Offset: 0x00006494
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x556BB80", Offset = "0x556A780", VA = "0x18556BB80")]
		public Networker.Configuration GetOverrideNetworkConfig()
		{
			return default(Networker.Configuration);
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x556C200", Offset = "0x556AE00", VA = "0x18556C200")]
		public void OverrideNetworkOptions(Networker.Configuration? overrideConfig, NetworkConfigPriority priorityEnum)
		{
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000131")]
		public string overrideRouterUrl
		{
			[Token(Token = "0x6000C52")]
			[Address(RVA = "0x556FC40", Offset = "0x556E840", VA = "0x18556FC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C53")]
			[Address(RVA = "0x5570240", Offset = "0x556EE40", VA = "0x185570240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x556C3C0", Offset = "0x556AFC0", VA = "0x18556C3C0")]
		public void OverrideNetworkRouterUrl(string routerUrl)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000132")]
		public JsonSerializerSettings serializeSetting
		{
			[Token(Token = "0x6000C55")]
			[Address(RVA = "0x556FF60", Offset = "0x556EB60", VA = "0x18556FF60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000133")]
		public string annouceUrl
		{
			[Token(Token = "0x6000C56")]
			[Address(RVA = "0x556F850", Offset = "0x556E450", VA = "0x18556F850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000134")]
		public string preAnnouceUrl
		{
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x556FE10", Offset = "0x556EA10", VA = "0x18556FE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000135")]
		public string preAnnouceConfigUrl
		{
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x556FCC0", Offset = "0x556E8C0", VA = "0x18556FCC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000136")]
		public string serviceLicenseUrl
		{
			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x55700B0", Offset = "0x556ECB0", VA = "0x1855700B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x000082AC File Offset: 0x000064AC
		[Token(Token = "0x17000137")]
		public bool isBusy
		{
			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x556F8E0", Offset = "0x556E4E0", VA = "0x18556F8E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x000082C4 File Offset: 0x000064C4
		[Token(Token = "0x17000138")]
		public bool isMultiFormAvail
		{
			[Token(Token = "0x6000C5B")]
			[Address(RVA = "0x556F960", Offset = "0x556E560", VA = "0x18556F960")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x556C090", Offset = "0x556AC90", VA = "0x18556C090", Slot = "5")]
		protected override void OnDuplicated()
		{
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x556C140", Offset = "0x556AD40", VA = "0x18556C140", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x556BEB0", Offset = "0x556AAB0", VA = "0x18556BEB0")]
		public void InitLoginInfo(Networker.LoginInfo loginInfo)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000139")]
		public string uid
		{
			[Token(Token = "0x6000C5F")]
			[Address(RVA = "0x55701C0", Offset = "0x556EDC0", VA = "0x1855701C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x000082DC File Offset: 0x000064DC
		[Token(Token = "0x1700013A")]
		public Networker.LoginInfo loginInfo
		{
			[Token(Token = "0x6000C60")]
			[Address(RVA = "0x556FAA0", Offset = "0x556E6A0", VA = "0x18556FAA0")]
			get
			{
				return default(Networker.LoginInfo);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000082F4 File Offset: 0x000064F4
		[Token(Token = "0x1700013B")]
		public uint loginInfoHash
		{
			[Token(Token = "0x6000C61")]
			[Address(RVA = "0x556FA20", Offset = "0x556E620", VA = "0x18556FA20")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0000830C File Offset: 0x0000650C
		[Token(Token = "0x1700013C")]
		public int serviceLicenseVersion
		{
			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x5570140", Offset = "0x556ED40", VA = "0x185570140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C63")]
		public RequestResult<ResType> SendRequest<ResType>(Request request) where ResType : class
		{
			return null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C64")]
		public RequestResult<ResType> SendMultiFormRequest<ResType>(Request request, BinaryData[] binaryDatas) where ResType : class
		{
			return null;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x556C4A0", Offset = "0x556B0A0", VA = "0x18556C4A0")]
		public WebHttpResult SendGet(string url, [Optional] string param)
		{
			return null;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x556C8B0", Offset = "0x556B4B0", VA = "0x18556C8B0")]
		public WebHttpInstruction YieldSendGet(string url, [Optional] string param)
		{
			return null;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x556C5B0", Offset = "0x556B1B0", VA = "0x18556C5B0")]
		public WebHttpResult SendPost(string url, string param, string contentType)
		{
			return null;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x556C6D0", Offset = "0x556B2D0", VA = "0x18556C6D0")]
		public WebHttpResult SendPost(string url, string param, string contentType, Dictionary<string, string> header)
		{
			return null;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x556C9E0", Offset = "0x556B5E0", VA = "0x18556C9E0")]
		public WebHttpInstruction YieldSendPost(string url, string param, [Optional] string contentType, [Optional] Dictionary<string, string> header)
		{
			return null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00008324 File Offset: 0x00006524
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x556C000", Offset = "0x556AC00", VA = "0x18556C000")]
		public static bool IsServerBusinessError(long responseCode)
		{
			return default(bool);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0000833C File Offset: 0x0000653C
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x556BF80", Offset = "0x556AB80", VA = "0x18556BF80")]
		public static bool IsServerAuthTimeout(long responseCode)
		{
			return default(bool);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x556C800", Offset = "0x556B400", VA = "0x18556C800")]
		public static void SetGlobalRequestHandler(Networker.IRequestHandler handler)
		{
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x556DEE0", Offset = "0x556CAE0", VA = "0x18556DEE0")]
		private string _ParseServiceUrl(string entry, string serviceCode)
		{
			return null;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x556F3C0", Offset = "0x556DFC0", VA = "0x18556F3C0")]
		private IEnumerator _SendGetCoroutine(string url, string param, WebHttpResult result)
		{
			return null;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x556F500", Offset = "0x556E100", VA = "0x18556F500")]
		private IEnumerator _SendPostCoroutine(string url, string param, string contentType, Dictionary<string, string> addHeader, WebHttpResult result)
		{
			return null;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C70")]
		private IEnumerator _RequestOnNextFrame<ResType>(Request request, BinaryData[] binaryDatas, RequestResult<ResType> resultHandler)
		{
			return null;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x556DAD0", Offset = "0x556C6D0", VA = "0x18556DAD0")]
		private IEnumerator _HttpGet(string url, string param, Dictionary<string, string> header, WebHttpResult result)
		{
			return null;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x556DC20", Offset = "0x556C820", VA = "0x18556DC20")]
		private IEnumerator _HttpPost(string url, string param, Dictionary<string, string> header, WebHttpResult result)
		{
			return null;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x556DD70", Offset = "0x556C970", VA = "0x18556DD70")]
		private IEnumerator _HttpRequest(string url, string text, Dictionary<string, string> header, WebHttpResponse outResponse, BinaryData[] binaryDatas)
		{
			return null;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x556E1D0", Offset = "0x556CDD0", VA = "0x18556E1D0")]
		private IEnumerator _PostImpl(string url, string text, Dictionary<string, string> header, WebHttpResponse outResponse, Func<bool> checkIfCancelled, [Optional] BinaryData[] binaryDatas)
		{
			return null;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x556E530", Offset = "0x556D130", VA = "0x18556E530")]
		private IEnumerator _PostWithProperNetworkUtil(string url, string text, Dictionary<string, string> header, WebHttpResponse outResponse, Func<bool> checkIfCancelled, BinaryData[] binaryDatas, Networker.PostRetryContext retryContext)
		{
			return null;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00008354 File Offset: 0x00006554
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x556CE90", Offset = "0x556BA90", VA = "0x18556CE90")]
		private static bool _CheckNetworkShouldRetry(WebHttpResponse httpRes)
		{
			return default(bool);
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0000836C File Offset: 0x0000656C
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x556BAB0", Offset = "0x556A6B0", VA = "0x18556BAB0")]
		public static bool CheckIfUseBestHttp(string url, bool isRetry)
		{
			return default(bool);
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x556F130", Offset = "0x556DD30", VA = "0x18556F130")]
		private static void _ResetWebResponse(WebHttpResponse outResponse)
		{
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x556E010", Offset = "0x556CC10", VA = "0x18556E010")]
		private IEnumerator _PostExtraLargeReqeust(string url, string text, Dictionary<string, string> header, WebHttpResponse outResponse, Func<bool> checkIfCancelled, BinaryData[] binaryDatas, Networker.PostRetryContext retryContext)
		{
			return null;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00008384 File Offset: 0x00006584
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x556CE00", Offset = "0x556BA00", VA = "0x18556CE00")]
		private static bool _CheckIfUseExtraLargeRequest(string url, string text)
		{
			return default(bool);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x556E6F0", Offset = "0x556D2F0", VA = "0x18556E6F0")]
		private IEnumerator _PostWithUnityWebRequest(string url, string text, Dictionary<string, string> header, WebHttpResponse outResponse, Func<bool> checkIfCancelled)
		{
			return null;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x556EC50", Offset = "0x556D850", VA = "0x18556EC50")]
		private void _ProcessHttpWebResponse(UnityWebRequest webRequest, WebHttpResponse outResponse, Networker.HttpMethod method)
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0000839C File Offset: 0x0000659C
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x556EE70", Offset = "0x556DA70", VA = "0x18556EE70")]
		private static bool _ReadWebRequestResponse(UnityWebRequest request, bool enableGZip, out string outText, out byte[] outBytes)
		{
			return default(bool);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000083B4 File Offset: 0x000065B4
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x556CB30", Offset = "0x556B730", VA = "0x18556CB30")]
		private static bool _CheckIfGZip(UnityWebRequest request, DownloadHandler downloadHandler)
		{
			return default(bool);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x556D130", Offset = "0x556BD30", VA = "0x18556D130")]
		private void _GenerateHttpPostRequest(string url, string text, Dictionary<string, string> header, BinaryData[] binaryDatas, HTTPResponse response, ref HTTPRequest request)
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x556E370", Offset = "0x556CF70", VA = "0x18556E370")]
		private IEnumerator _PostWithBestHttp(string url, string text, Dictionary<string, string> header, WebHttpResponse outResponse, Func<bool> checkIfCancelled, BinaryData[] binaryDatas, Networker.PostRetryContext retryContext)
		{
			return null;
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000083CC File Offset: 0x000065CC
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x556CD70", Offset = "0x556B970", VA = "0x18556CD70")]
		private static bool _CheckIfRequestDone(HTTPRequest request)
		{
			return default(bool);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x556E860", Offset = "0x556D460", VA = "0x18556E860")]
		private void _ProcessHttpWebResponse(HTTPRequest request, HTTPResponse response, WebHttpResponse outResponse)
		{
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x000083E4 File Offset: 0x000065E4
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x556D9C0", Offset = "0x556C5C0", VA = "0x18556D9C0")]
		private static long _GetErrorCodeFromBestHttp(HTTPRequest request)
		{
			return 0L;
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x556D680", Offset = "0x556C280", VA = "0x18556D680")]
		private Dictionary<string, string> _GenerateRequestHeader(Request request)
		{
			return null;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C85")]
		private void _HandleRequestCanceled<ResType>(RequestResult<ResType> result)
		{
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C86")]
		private void _HandleResponse<ResType>(RespMsgBundle<ResType> body, RequestResult<ResType> result)
		{
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C87")]
		private void _HandleResponseError<ResType>(long responseCode, string responseText, RequestResult<ResType> result)
		{
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C88")]
		private void _HandleTimeoutError<ResType>(RequestResult<ResType> result)
		{
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C89")]
		private void _HandleClientInternalError<ResType>(RequestResult<ResType> result, Exception e)
		{
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C8A")]
		private static void _HandleSecureSysError<ResType>(RequestResult<ResType> result, int errorCode)
		{
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x000083FC File Offset: 0x000065FC
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x556F300", Offset = "0x556DF00", VA = "0x18556F300")]
		private static bool _SecureUrl(string url, out string secureUrl, out int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x556CF40", Offset = "0x556BB40", VA = "0x18556CF40")]
		[Conditional("TEST")]
		[Conditional("UNITY_EDITOR")]
		private static void _Condition_TEST_ProfileHttpResponse(string url, Networker.HttpMethod method, WebHttpResponse response)
		{
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x556F770", Offset = "0x556E370", VA = "0x18556F770")]
		public Networker()
		{
		}

		// Token: 0x04000C19 RID: 3097
		[Token(Token = "0x4000C19")]
		public const string CONTENT_TYPE_JSON = "application/json";

		// Token: 0x04000C1A RID: 3098
		[Token(Token = "0x4000C1A")]
		public const string CONTENT_TYPE_IMG_JPEG = "image/jpeg";

		// Token: 0x04000C1B RID: 3099
		[Token(Token = "0x4000C1B")]
		public const string CONTENT_TYPE_MULTI_FORM = "multipart/form-data";

		// Token: 0x04000C1C RID: 3100
		[Token(Token = "0x4000C1C")]
		public const string CONTENT_ENCODING_GZIP = "gzip";

		// Token: 0x04000C1D RID: 3101
		[Token(Token = "0x4000C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly byte[] GZIP_MAGIC_BYTES;

		// Token: 0x04000C1E RID: 3102
		[Token(Token = "0x4000C1E")]
		public const long CUSTOM_ERROR_CODE_TIMEOUT = 10000L;

		// Token: 0x04000C1F RID: 3103
		[Token(Token = "0x4000C1F")]
		public const long CUSTOM_ERROR_CODE_CONCLOSED = 10010L;

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		private const long CUSTOM_ERROR_CODE_TLS_ERROR = 10020L;

		// Token: 0x04000C21 RID: 3105
		[Token(Token = "0x4000C21")]
		public const int CUSTOM_ERROR_CODE_SECURE_BASE = 20000;

		// Token: 0x04000C22 RID: 3106
		[Token(Token = "0x4000C22")]
		public const long CUSTOM_ERROR_CODE_CLIENT_ERROR = 30000L;

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		private const int GENERAL_TIMEOUT = 30;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		private const int LARGE_REQUEST_THRESHOLD = 61440;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		private const string PRE_ANNOUNCE_CONFIG_JSON = "api/gate/meta/{0}";

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		private const string PRE_ANNOUNCE_INFO_JSON = "api/gate/info/{0}";

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		public const string MULTI_FORM_JSON_PART_NAME = "json";

		// Token: 0x04000C28 RID: 3112
		[Token(Token = "0x4000C28")]
		public const string MULTI_FORM_JSON_PART_FILE_NAME = "json_info";

		// Token: 0x04000C29 RID: 3113
		[Token(Token = "0x4000C29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("If to show network messages in log")]
		private bool _enableProfile;

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Networker.LoginInfo m_loginInfo;

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint m_loginInfoHash;

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ListDict<int, Networker.Configuration> m_overrideNetworkConfigs;

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_serviceCount;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool m_lastSeqNumFailed;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_seqNum;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_latestSucceedSeqNum;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Networker.IRequestHandler s_requestHanlder;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate249 __Hotfix0_get_networkConfig;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate249 __Hotfix0_GetOverrideNetworkConfig;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate250 __Hotfix0_OverrideNetworkOptions;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_overrideRouterUrl;

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate0 __Hotfix0_set_overrideRouterUrl;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate0 __Hotfix0_OverrideNetworkRouterUrl;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate251 __Hotfix0_get_serializeSetting;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_annouceUrl;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_preAnnouceUrl;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_preAnnouceConfigUrl;

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_serviceLicenseUrl;

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isBusy;

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate21 __Hotfix0_get_isMultiFormAvail;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnDuplicated;

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnInit;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate252 __Hotfix0_InitLoginInfo;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate19 __Hotfix0_get_uid;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate253 __Hotfix0_get_loginInfo;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate254 __Hotfix0_get_loginInfoHash;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate25 __Hotfix0_get_serviceLicenseVersion;

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate255 __Hotfix0_SendGet;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate256 __Hotfix0_YieldSendGet;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static __XLua_Gen_Delegate257 __Hotfix0_SendPost;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static __XLua_Gen_Delegate258 __Hotfix1_SendPost;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static __XLua_Gen_Delegate259 __Hotfix0_YieldSendPost;

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static __XLua_Gen_Delegate260 __Hotfix0_IsServerBusinessError;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static __XLua_Gen_Delegate260 __Hotfix0_IsServerAuthTimeout;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_SetGlobalRequestHandler;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static __XLua_Gen_Delegate20 __Hotfix0__ParseServiceUrl;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static __XLua_Gen_Delegate212 __Hotfix0__SendGetCoroutine;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static __XLua_Gen_Delegate261 __Hotfix0__SendPostCoroutine;

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static __XLua_Gen_Delegate262 __Hotfix0__HttpGet;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static __XLua_Gen_Delegate262 __Hotfix0__HttpPost;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static __XLua_Gen_Delegate261 __Hotfix0__HttpRequest;

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static __XLua_Gen_Delegate263 __Hotfix0__PostImpl;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static __XLua_Gen_Delegate264 __Hotfix0__PostWithProperNetworkUtil;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static __XLua_Gen_Delegate21 __Hotfix0__CheckNetworkShouldRetry;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static __XLua_Gen_Delegate34 __Hotfix0_CheckIfUseBestHttp;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ResetWebResponse;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static __XLua_Gen_Delegate264 __Hotfix0__PostExtraLargeReqeust;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static __XLua_Gen_Delegate154 __Hotfix0__CheckIfUseExtraLargeRequest;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static __XLua_Gen_Delegate261 __Hotfix0__PostWithUnityWebRequest;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static __XLua_Gen_Delegate265 __Hotfix0__ReadWebRequestResponse;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static __XLua_Gen_Delegate154 __Hotfix0__CheckIfGZip;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static __XLua_Gen_Delegate266 __Hotfix0__GenerateHttpPostRequest;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static __XLua_Gen_Delegate264 __Hotfix0__PostWithBestHttp;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static __XLua_Gen_Delegate21 __Hotfix0__CheckIfRequestDone;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static __XLua_Gen_Delegate27 __Hotfix0__ProcessHttpWebResponse;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static __XLua_Gen_Delegate238 __Hotfix0__GetErrorCodeFromBestHttp;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static __XLua_Gen_Delegate267 __Hotfix0__GenerateRequestHeader;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static __XLua_Gen_Delegate268 __Hotfix0__SecureUrl;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000215 RID: 533
		[Token(Token = "0x2000215")]
		private enum HttpMethod
		{
			// Token: 0x04000C68 RID: 3176
			[Token(Token = "0x4000C68")]
			NONE,
			// Token: 0x04000C69 RID: 3177
			[Token(Token = "0x4000C69")]
			GET,
			// Token: 0x04000C6A RID: 3178
			[Token(Token = "0x4000C6A")]
			POST
		}

		// Token: 0x02000216 RID: 534
		[Token(Token = "0x2000216")]
		public interface IRequestHandler
		{
			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000C8F RID: 3215
			[Token(Token = "0x1700013D")]
			JsonSerializerSettings serializeSettings { [Token(Token = "0x6000C8F")] get; }

			// Token: 0x06000C90 RID: 3216
			[Token(Token = "0x6000C90")]
			void BeforeRequest(Request request);

			// Token: 0x06000C91 RID: 3217
			[Token(Token = "0x6000C91")]
			string SerializeRequest(Request request);

			// Token: 0x06000C92 RID: 3218
			[Token(Token = "0x6000C92")]
			void MarkRequestFinish(Request request);

			// Token: 0x06000C93 RID: 3219
			[Token(Token = "0x6000C93")]
			CustomYieldInstruction DeserializeResposne<ResType>(string responseText);

			// Token: 0x06000C94 RID: 3220
			[Token(Token = "0x6000C94")]
			RespMsgBundle<ResType> HandleResponse<ResType>(CustomYieldInstruction deserializeTask);
		}

		// Token: 0x02000217 RID: 535
		[Token(Token = "0x2000217")]
		private class EmptyRequestHandler : Networker.IRequestHandler
		{
			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x1700013E")]
			public JsonSerializerSettings serializeSettings
			{
				[Token(Token = "0x6000C95")]
				[Address(RVA = "0x5569A40", Offset = "0x5568640", VA = "0x185569A40", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x5569940", Offset = "0x5568540", VA = "0x185569940", Slot = "5")]
			public void BeforeRequest(Request request)
			{
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x5569970", Offset = "0x5568570", VA = "0x185569970", Slot = "7")]
			public void MarkRequestFinish(Request request)
			{
			}

			// Token: 0x06000C98 RID: 3224 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x55699A0", Offset = "0x55685A0", VA = "0x1855699A0", Slot = "6")]
			public string SerializeRequest(Request request)
			{
				return null;
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C99")]
			public CustomYieldInstruction DeserializeResposne<ResType>(string responseText)
			{
				return null;
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x00008414 File Offset: 0x00006614
			[Token(Token = "0x6000C9A")]
			public RespMsgBundle<ResType> HandleResponse<ResType>(CustomYieldInstruction deserializeTask)
			{
				return default(RespMsgBundle<ResType>);
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x55699D0", Offset = "0x55685D0", VA = "0x1855699D0")]
			private static Exception _NotImplemented()
			{
				return null;
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EmptyRequestHandler()
			{
			}
		}

		// Token: 0x02000218 RID: 536
		[Token(Token = "0x2000218")]
		[Serializable]
		public struct Configuration
		{
			// Token: 0x06000C9D RID: 3229 RVA: 0x0000842C File Offset: 0x0000662C
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x00008444 File Offset: 0x00006644
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x5565100", Offset = "0x5563D00", VA = "0x185565100")]
			public static Networker.Configuration FromNetConfiguration(NetworkRouterConfig.Config urlConfiguration)
			{
				return default(Networker.Configuration);
			}

			// Token: 0x04000C6B RID: 3179
			[Token(Token = "0x4000C6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[NonSerialized]
			public static readonly Networker.Configuration EMPTY;

			// Token: 0x04000C6C RID: 3180
			[Token(Token = "0x4000C6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string gameServerUrl;

			// Token: 0x04000C6D RID: 3181
			[Token(Token = "0x4000C6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string sdkServerUrl;

			// Token: 0x04000C6E RID: 3182
			[Token(Token = "0x4000C6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string u8ServerUrl;

			// Token: 0x04000C6F RID: 3183
			[Token(Token = "0x4000C6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string hotUpdateUrl;

			// Token: 0x04000C70 RID: 3184
			[Token(Token = "0x4000C70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string htUdtVerUrl;

			// Token: 0x04000C71 RID: 3185
			[Token(Token = "0x4000C71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string remoteConfigUrl;

			// Token: 0x04000C72 RID: 3186
			[Token(Token = "0x4000C72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string announceUrl;

			// Token: 0x04000C73 RID: 3187
			[Token(Token = "0x4000C73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string preAnnounceUrl;

			// Token: 0x04000C74 RID: 3188
			[Token(Token = "0x4000C74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string serviceLicenseUrl;

			// Token: 0x04000C75 RID: 3189
			[Token(Token = "0x4000C75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string officialUrl;

			// Token: 0x04000C76 RID: 3190
			[Token(Token = "0x4000C76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string packageDownloadUrlAndroid;

			// Token: 0x04000C77 RID: 3191
			[Token(Token = "0x4000C77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public string packageDownloadUrlIOS;

			// Token: 0x04000C78 RID: 3192
			[Token(Token = "0x4000C78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public bool devsdk;
		}

		// Token: 0x02000219 RID: 537
		[Token(Token = "0x2000219")]
		public struct LoginInfo
		{
			// Token: 0x06000CA0 RID: 3232 RVA: 0x0000845C File Offset: 0x0000665C
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04000C79 RID: 3193
			[Token(Token = "0x4000C79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x04000C7A RID: 3194
			[Token(Token = "0x4000C7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string secret;

			// Token: 0x04000C7B RID: 3195
			[Token(Token = "0x4000C7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int serviceLicenseVersion;

			// Token: 0x04000C7C RID: 3196
			[Token(Token = "0x4000C7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string majorVersion;
		}

		// Token: 0x0200021A RID: 538
		[Token(Token = "0x200021A")]
		private class PostRetryContext : IHotfixable
		{
			// Token: 0x06000CA1 RID: 3233 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x5573E00", Offset = "0x5572A00", VA = "0x185573E00")]
			private PostRetryContext()
			{
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x5573D60", Offset = "0x5572960", VA = "0x185573D60")]
			public static Networker.PostRetryContext Init()
			{
				return null;
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x5573C10", Offset = "0x5572810", VA = "0x185573C10")]
			public void BestHttpBeforeSendRequest(HTTPRequest request)
			{
			}

			// Token: 0x04000C7D RID: 3197
			[Token(Token = "0x4000C7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HTTPRequest lastRequest;

			// Token: 0x04000C7E RID: 3198
			[Token(Token = "0x4000C7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isRetry;

			// Token: 0x04000C7F RID: 3199
			[Token(Token = "0x4000C7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			private bool m_isPCMode;

			// Token: 0x04000C80 RID: 3200
			[Token(Token = "0x4000C80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

			// Token: 0x04000C81 RID: 3201
			[Token(Token = "0x4000C81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate0 __Hotfix0_BestHttpBeforeSendRequest;
		}
	}
}
