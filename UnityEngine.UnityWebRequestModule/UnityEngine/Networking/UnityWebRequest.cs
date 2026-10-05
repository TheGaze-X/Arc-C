using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Networking
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
	[StructLayout(0)]
	public class UnityWebRequest : IDisposable
	{
		// Token: 0x06000021 RID: 33
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5B997A0", Offset = "0x5B983A0", VA = "0x185B997A0")]
		[NativeConditional("ENABLE_UNITYWEBREQUEST")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern string GetWebErrorString(UnityWebRequest.UnityWebRequestError err);

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x5B99490", Offset = "0x5B98090", VA = "0x185B99490")]
		[VisibleToOtherModules]
		[MethodImpl(4096)]
		internal static extern string GetHTTPStatusString(long responseCode);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000005")]
		public bool disposeCertificateHandlerOnDispose
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000006")]
		public bool disposeDownloadHandlerOnDispose
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x4FD480", Offset = "0x4FC080", VA = "0x1804FD480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x3249520", Offset = "0x3248120", VA = "0x183249520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000007")]
		public bool disposeUploadHandlerOnDispose
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1694F60", Offset = "0x1693B60", VA = "0x181694F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000029 RID: 41
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x5B98FE0", Offset = "0x5B97BE0", VA = "0x185B98FE0")]
		[NativeThrows]
		[MethodImpl(4096)]
		internal static extern IntPtr Create();

		// Token: 0x0600002A RID: 42
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x5B99ED0", Offset = "0x5B98AD0", VA = "0x185B99ED0")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		private extern void Release();

		// Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x5B99930", Offset = "0x5B98530", VA = "0x185B99930")]
		internal void InternalDestroy()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x5B99B00", Offset = "0x5B98700", VA = "0x185B99B00")]
		private void InternalSetDefaults()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x5B9AC60", Offset = "0x5B99860", VA = "0x185B9AC60")]
		public UnityWebRequest(string url, string method)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x5B9ABB0", Offset = "0x5B997B0", VA = "0x185B9ABB0")]
		public UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x5B993E0", Offset = "0x5B97FE0", VA = "0x185B993E0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x5B99120", Offset = "0x5B97D20", VA = "0x185B99120", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x5B99010", Offset = "0x5B97C10", VA = "0x185B99010")]
		private void DisposeHandlers()
		{
		}

		// Token: 0x06000032 RID: 50
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x5B98FA0", Offset = "0x5B97BA0", VA = "0x185B98FA0")]
		[NativeThrows]
		[MethodImpl(4096)]
		internal extern UnityWebRequestAsyncOperation BeginWebRequest();

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x5B99F10", Offset = "0x5B98B10", VA = "0x185B99F10")]
		[Obsolete("Use SendWebRequest.  It returns a UnityWebRequestAsyncOperation which contains a reference to the WebRequest object.", false)]
		public AsyncOperation Send()
		{
			return null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x5B99F10", Offset = "0x5B98B10", VA = "0x185B99F10")]
		public UnityWebRequestAsyncOperation SendWebRequest()
		{
			return null;
		}

		// Token: 0x06000035 RID: 53
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x5B98F60", Offset = "0x5B97B60", VA = "0x185B98F60")]
		[NativeMethod(IsThreadSafe = true)]
		[MethodImpl(4096)]
		public extern void Abort();

		// Token: 0x06000036 RID: 54
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x5B9A060", Offset = "0x5B98C60", VA = "0x185B9A060")]
		[MethodImpl(4096)]
		private extern UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType);

		// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x5B99B10", Offset = "0x5B98710", VA = "0x185B99B10")]
		internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType)
		{
		}

		// Token: 0x06000038 RID: 56
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x5B99FC0", Offset = "0x5B98BC0", VA = "0x185B99FC0")]
		[MethodImpl(4096)]
		private extern UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName);

		// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x5B999E0", Offset = "0x5B985E0", VA = "0x185B999E0")]
		internal void InternalSetCustomMethod(string customMethodName)
		{
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000008")]
		public string method
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x5B9B210", Offset = "0x5B99E10", VA = "0x185B9B210")]
			set
			{
			}
		}

		// Token: 0x0600003B RID: 59
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x5B99450", Offset = "0x5B98050", VA = "0x185B99450")]
		[MethodImpl(4096)]
		private extern UnityWebRequest.UnityWebRequestError GetError();

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		public string error
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x5B9ACE0", Offset = "0x5B998E0", VA = "0x185B9ACE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700000A")]
		public string url
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x5B99760", Offset = "0x5B98360", VA = "0x185B99760")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x5B9B700", Offset = "0x5B9A300", VA = "0x185B9B700")]
			set
			{
			}
		}

		// Token: 0x0600003F RID: 63
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5B99760", Offset = "0x5B98360", VA = "0x185B99760")]
		[MethodImpl(4096)]
		private extern string GetUrl();

		// Token: 0x06000040 RID: 64
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x5B9A320", Offset = "0x5B98F20", VA = "0x185B9A320")]
		[MethodImpl(4096)]
		private extern UnityWebRequest.UnityWebRequestError SetUrl(string url);

		// Token: 0x06000041 RID: 65 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x5B99C90", Offset = "0x5B98890", VA = "0x185B99C90")]
		private void InternalSetUrl(string url)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000042 RID: 66
		[Token(Token = "0x1700000B")]
		public extern long responseCode { [Token(Token = "0x6000042")] [Address(RVA = "0x5B9AF50", Offset = "0x5B99B50", VA = "0x185B9AF50")] [MethodImpl(4096)] get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000043 RID: 67
		[Token(Token = "0x1700000C")]
		public extern bool isModifiable { [Token(Token = "0x6000043")] [Address(RVA = "0x5B9AED0", Offset = "0x5B99AD0", VA = "0x185B9AED0")] [NativeMethod("IsModifiable")] [MethodImpl(4096)] get; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x1700000D")]
		public bool isDone
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x5B9AE50", Offset = "0x5B99A50", VA = "0x185B9AE50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x1700000E")]
		[Obsolete("UnityWebRequest.isNetworkError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ConnectionError) instead.", false)]
		public bool isNetworkError
		{
			[Token(Token = "0x6000045")]
			[Address(RVA = "0x5B9AF10", Offset = "0x5B99B10", VA = "0x185B9AF10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x1700000F")]
		[Obsolete("UnityWebRequest.isHttpError is deprecated. Use (UnityWebRequest.result == UnityWebRequest.Result.ProtocolError) instead.", false)]
		public bool isHttpError
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x5B9AE90", Offset = "0x5B99A90", VA = "0x185B9AE90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000047 RID: 71
		[Token(Token = "0x17000010")]
		public extern UnityWebRequest.Result result { [Token(Token = "0x6000047")] [Address(RVA = "0x5B9AF90", Offset = "0x5B99B90", VA = "0x185B9AF90")] [NativeMethod("GetResult")] [MethodImpl(4096)] get; }

		// Token: 0x06000048 RID: 72
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5B99F70", Offset = "0x5B98B70", VA = "0x185B99F70")]
		[MethodImpl(4096)]
		private extern UnityWebRequest.UnityWebRequestError SetChunked(bool chunked);

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000011")]
		[Obsolete("HTTP/2 and many HTTP/1.1 servers don't support this; we recommend leaving it set to false (default).", false)]
		public bool chunkedTransfer
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x5B9AFD0", Offset = "0x5B99BD0", VA = "0x185B9AFD0")]
			set
			{
			}
		}

		// Token: 0x0600004A RID: 74
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x5B994D0", Offset = "0x5B980D0", VA = "0x185B994D0")]
		[MethodImpl(4096)]
		public extern string GetRequestHeader(string name);

		// Token: 0x0600004B RID: 75
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x5B99C30", Offset = "0x5B98830", VA = "0x185B99C30")]
		[NativeMethod("SetRequestHeader")]
		[MethodImpl(4096)]
		internal extern UnityWebRequest.UnityWebRequestError InternalSetRequestHeader(string name, string value);

		// Token: 0x0600004C RID: 76 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x5B9A0A0", Offset = "0x5B98CA0", VA = "0x185B9A0A0")]
		public void SetRequestHeader(string name, string value)
		{
		}

		// Token: 0x0600004D RID: 77
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x5B99560", Offset = "0x5B98160", VA = "0x185B99560")]
		[MethodImpl(4096)]
		public extern string GetResponseHeader(string name);

		// Token: 0x0600004E RID: 78
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x5B99520", Offset = "0x5B98120", VA = "0x185B99520")]
		[MethodImpl(4096)]
		internal extern string[] GetResponseHeaderKeys();

		// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x5B995B0", Offset = "0x5B981B0", VA = "0x185B995B0")]
		public Dictionary<string, string> GetResponseHeaders()
		{
			return null;
		}

		// Token: 0x06000050 RID: 80
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x5B9A2D0", Offset = "0x5B98ED0", VA = "0x185B9A2D0")]
		[MethodImpl(4096)]
		private extern UnityWebRequest.UnityWebRequestError SetUploadHandler(UploadHandler uh);

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000012")]
		public UploadHandler uploadHandler
		{
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x5B9B5E0", Offset = "0x5B9A1E0", VA = "0x185B9B5E0")]
			set
			{
			}
		}

		// Token: 0x06000053 RID: 83
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5B9A010", Offset = "0x5B98C10", VA = "0x185B9A010")]
		[MethodImpl(4096)]
		private extern UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh);

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000013")]
		public DownloadHandler downloadHandler
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x5B9B0F0", Offset = "0x5B99CF0", VA = "0x185B9B0F0")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public CertificateHandler certificateHandler
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x5911BD0", Offset = "0x59107D0", VA = "0x185911BD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000057 RID: 87
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5B9A290", Offset = "0x5B98E90", VA = "0x185B9A290")]
		[MethodImpl(4096)]
		private extern UnityWebRequest.UnityWebRequestError SetTimeoutMsec(int timeout);

		// Token: 0x17000015 RID: 21
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000015")]
		public int timeout
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x5B9B480", Offset = "0x5B9A080", VA = "0x185B9B480")]
			set
			{
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5B997E0", Offset = "0x5B983E0", VA = "0x185B997E0")]
		public static UnityWebRequest Get(string uri)
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x5B99E40", Offset = "0x5B98A40", VA = "0x185B99E40")]
		public static UnityWebRequest Post(string uri, string postData)
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x5B9A6C0", Offset = "0x5B992C0", VA = "0x185B9A6C0")]
		private static void SetupPost(UnityWebRequest request, string postData)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x5B99DB0", Offset = "0x5B989B0", VA = "0x185B99DB0")]
		public static UnityWebRequest Post(string uri, WWWForm formData)
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x5B9A370", Offset = "0x5B98F70", VA = "0x185B9A370")]
		private static void SetupPost(UnityWebRequest request, WWWForm formData)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x5B99180", Offset = "0x5B97D80", VA = "0x185B99180")]
		public static string EscapeURL(string s)
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x5B992B0", Offset = "0x5B97EB0", VA = "0x185B992B0")]
		public static string EscapeURL(string s, Encoding e)
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x5B9AAA0", Offset = "0x5B996A0", VA = "0x185B9AAA0")]
		public static string UnEscapeURL(string s)
		{
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x5B9A990", Offset = "0x5B99590", VA = "0x185B9A990")]
		public static string UnEscapeURL(string s, Encoding e)
		{
			return null;
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		internal DownloadHandler m_DownloadHandler;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		internal UploadHandler m_UploadHandler;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[NonSerialized]
		internal CertificateHandler m_CertificateHandler;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[NonSerialized]
		internal Uri m_Uri;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		public const string kHttpVerbGET = "GET";

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		public const string kHttpVerbHEAD = "HEAD";

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		public const string kHttpVerbPOST = "POST";

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		public const string kHttpVerbPUT = "PUT";

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		public const string kHttpVerbCREATE = "CREATE";

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		public const string kHttpVerbDELETE = "DELETE";

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		internal enum UnityWebRequestMethod
		{
			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			Get,
			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			Post,
			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			Put,
			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			Head,
			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			Custom
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		internal enum UnityWebRequestError
		{
			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			OK,
			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			Unknown,
			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			SDKError,
			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			UnsupportedProtocol,
			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			MalformattedUrl,
			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			CannotResolveProxy,
			// Token: 0x04000035 RID: 53
			[Token(Token = "0x4000035")]
			CannotResolveHost,
			// Token: 0x04000036 RID: 54
			[Token(Token = "0x4000036")]
			CannotConnectToHost,
			// Token: 0x04000037 RID: 55
			[Token(Token = "0x4000037")]
			AccessDenied,
			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			GenericHttpError,
			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			WriteError,
			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			ReadError,
			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			OutOfMemory,
			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			Timeout,
			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			HTTPPostError,
			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			SSLCannotConnect,
			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			Aborted,
			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			TooManyRedirects,
			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			ReceivedNoData,
			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			SSLNotSupported,
			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			FailedToSendData,
			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			FailedToReceiveData,
			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			SSLCertificateError,
			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			SSLCipherNotAvailable,
			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			SSLCACertError,
			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			UnrecognizedContentEncoding,
			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			LoginFailed,
			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			SSLShutdownFailed,
			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			NoInternetConnection
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public enum Result
		{
			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			InProgress,
			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			Success,
			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			ConnectionError,
			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			ProtocolError,
			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			DataProcessingError
		}
	}
}
