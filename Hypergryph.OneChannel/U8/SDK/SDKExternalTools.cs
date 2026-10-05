using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public abstract class SDKExternalTools
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000020CC File Offset: 0x000002CC
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000004")]
		private protected bool inited
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000005")]
		protected IExternalPlugin plugin
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x4A146F0", Offset = "0x4A132F0", VA = "0x184A146F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000006")]
		private protected SDKExternalTools.CaptchaMgr captchaMgr
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000007")]
		public string subChannel
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x6000021")]
		public static bool SDKInterfaceInitExternalTools<ConcreteType>() where ConcreteType : SDKExternalTools
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4A0ECB0", Offset = "0x4A0D8B0", VA = "0x184A0ECB0")]
		public static SDKExternalTools GetInstance()
		{
			return null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x4A0ED80", Offset = "0x4A0D980", VA = "0x184A0ED80")]
		public static bool HasInstance()
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x4A0FC40", Offset = "0x4A0E840", VA = "0x184A0FC40")]
		public string PublicServiceSignKey()
		{
			return null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x4A114C0", Offset = "0x4A100C0", VA = "0x184A114C0")]
		public SDKPromise<U8LoginResult> SDKInterfaceSDKAuth(string extension, string captcha)
		{
			return null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x4A10A30", Offset = "0x4A0F630", VA = "0x184A10A30")]
		public SDKPromise<U8CaptchaResult> SDKInterfaceGetCaptcha()
		{
			return null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4A119E0", Offset = "0x4A105E0", VA = "0x184A119E0")]
		public SDKPromise<object> SDKInterfaceVerifyAccount(string uid, string token)
		{
			return null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x4A10BB0", Offset = "0x4A0F7B0", VA = "0x184A10BB0")]
		public SDKPromise<List<U8ProductInfo>> SDKInterfaceGetProductList(int worldId)
		{
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x4A112D0", Offset = "0x4A0FED0", VA = "0x184A112D0")]
		public SDKPromise<List<U8ProductInfo>> SDKInterfaceProductListV2()
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x4A0FAC0", Offset = "0x4A0E6C0", VA = "0x184A0FAC0")]
		public void NotifyProductListUpdated(List<U8ProductInfo> productList)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x4A11C10", Offset = "0x4A10810", VA = "0x184A11C10")]
		public SDKPromise<U8ConfirmOrderResult> SDKLegacyConfirmOrder(string uid, string orderId, string extension)
		{
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x4A11790", Offset = "0x4A10390", VA = "0x184A11790")]
		public SDKPromise<object> SDKInterfaceUpgradeGuest(string targetUid, string guestExt, string accountExt)
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4A115B0", Offset = "0x4A101B0", VA = "0x184A115B0")]
		public string SDKInterfaceSDKToken()
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4A116A0", Offset = "0x4A102A0", VA = "0x184A116A0")]
		public string SDKInterfaceSDKUid()
		{
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4A0FAB0", Offset = "0x4A0E6B0", VA = "0x184A0FAB0")]
		public static string MakeHttpPostParam(Dictionary<string, object> param)
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x4A0F8A0", Offset = "0x4A0E4A0", VA = "0x184A0F8A0")]
		public static string MakeHttpGetParam(Dictionary<string, string> param)
		{
			return null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x4A12530", Offset = "0x4A11130", VA = "0x184A12530")]
		public bool TrySetDataWithPlugin(int type, string paramJson)
		{
			return default(bool);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x4A123A0", Offset = "0x4A10FA0", VA = "0x184A123A0")]
		public bool TryGetDataWithPlugin(int type, string paramJson, out string data)
		{
			return default(bool);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x4A12690", Offset = "0x4A11290", VA = "0x184A12690")]
		public bool TrySubmitGameDataWithPlugin(U8ExtraGameData data)
		{
			return default(bool);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x4A0F200", Offset = "0x4A0DE00", VA = "0x184A0F200")]
		public void LoginWithPlugin(Action nativeLogin, Action<string> nativeLoginCustom, Action<U8MockLogin> markMockLogin)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x4A0F590", Offset = "0x4A0E190", VA = "0x184A0F590")]
		public void LogoutWithPlugin(Action nativeLogout)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x4A10E10", Offset = "0x4A0FA10", VA = "0x184A10E10")]
		public void SDKInterfacePayWithPlugin(U8PayParams payParams, Func<U8PayParams, SDKPromise<U8PayResult>> nativePay, Action<U8PayResult> onSuc, Action<object> onFail)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x4A10B00", Offset = "0x4A0F700", VA = "0x184A10B00")]
		public string SDKInterfaceGetPayAddition()
		{
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x4A12280", Offset = "0x4A10E80", VA = "0x184A12280")]
		public static void StaticLog(string content)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x4A12160", Offset = "0x4A10D60", VA = "0x184A12160")]
		public static void StaticLogWarning(string content)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4A12040", Offset = "0x4A10C40", VA = "0x184A12040")]
		public static void StaticLogError(string content)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4A0FCB0", Offset = "0x4A0E8B0", VA = "0x184A0FCB0")]
		public static void RegisterPlugin(IExternalPlugin plugin)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4A129B0", Offset = "0x4A115B0", VA = "0x184A129B0")]
		public static void UnregisterPlugin(IExternalPlugin plugin)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4A0EB40", Offset = "0x4A0D740", VA = "0x184A0EB40")]
		public static string GenerateRandomString(int min, int max)
		{
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600003E")]
		protected static T GetValueSafe<T>(Dictionary<string, object> dict, string key, [Optional] T defVal)
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x4A127E0", Offset = "0x4A113E0", VA = "0x184A127E0")]
		protected string U8Url(string routeUrl)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4A128A0", Offset = "0x4A114A0", VA = "0x184A128A0")]
		protected string U8urlWithoutU8(string routeUrl)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000041")]
		protected static SDKExternalTools.ErrMsgMeta HandleResponseFromU8<TResp>(SDKExternalTools.BusType busType, SDKExternalTools.POSTResult postRet, out TResp resp) where TResp : SDKExternalTools.IFromJSON, new()
		{
			return default(SDKExternalTools.ErrMsgMeta);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x4A0EAB0", Offset = "0x4A0D6B0", VA = "0x184A0EAB0")]
		protected static Dictionary<string, object> FromMiniJSON(string json)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x4A0EA20", Offset = "0x4A0D620", VA = "0x184A0EA20")]
		protected static List<object> FromMiniJSONArray(string data)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4A0EF00", Offset = "0x4A0DB00", VA = "0x184A0EF00")]
		protected static void InternalInvokeCoroutine(IEnumerator coroutine)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4A0EF70", Offset = "0x4A0DB70", VA = "0x184A0EF70")]
		protected static void InternalInvokeNextFrame(Action action)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4A14050", Offset = "0x4A12C50", VA = "0x184A14050")]
		private static IEnumerator _NextFrameCoroutine(Action action)
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4A0EDE0", Offset = "0x4A0D9E0", VA = "0x184A0EDE0")]
		public void InitIfNot()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		protected virtual void Init()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public virtual void SwitchAccount()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public virtual void OnSDKError(SDKError error)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public virtual void OnInvalidProduct(int storeId)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
		public virtual void OnSDKExtraInfo(string jsonData)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4A0F070", Offset = "0x4A0DC70", VA = "0x184A0F070", Slot = "9")]
		public virtual SDKMeta LoadSDKMetaFromPlugin(Func<SDKMeta> nativeLoadMeta)
		{
			return null;
		}

		// Token: 0x0600004E RID: 78
		[Token(Token = "0x600004E")]
		protected abstract SDKCaptchaHandler CreateCaptchaHandler();

		// Token: 0x0600004F RID: 79 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "11")]
		protected virtual string GetSignKey()
		{
			return null;
		}

		// Token: 0x06000050 RID: 80
		[Token(Token = "0x6000050")]
		public abstract Dictionary<string, string> GetDeviceIDs();

		// Token: 0x06000051 RID: 81
		[Token(Token = "0x6000051")]
		protected abstract SDKPromise<U8LoginResult> SendSDKAuthRequest(string paramStr);

		// Token: 0x06000052 RID: 82
		[Token(Token = "0x6000052")]
		protected abstract SDKPromise<U8CaptchaResult> SendSDKGetCaptchaRequest(string paramStr);

		// Token: 0x06000053 RID: 83
		[Token(Token = "0x6000053")]
		protected abstract SDKPromise<object> SendSDKVerifyAccountRequest(string paramStr);

		// Token: 0x06000054 RID: 84
		[Token(Token = "0x6000054")]
		protected abstract SDKPromise<U8ConfirmOrderResult> SendConfirmOrderRequest(string paramStr);

		// Token: 0x06000055 RID: 85
		[Token(Token = "0x6000055")]
		protected abstract SDKPromise<List<U8ProductInfo>> SendGetProductListRequest(string paramStr);

		// Token: 0x06000056 RID: 86
		[Token(Token = "0x6000056")]
		protected abstract SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr);

		// Token: 0x06000057 RID: 87
		[Token(Token = "0x6000057")]
		protected abstract SDKPromise<object> SendUpgradeGuestRequest(string paramStr);

		// Token: 0x06000058 RID: 88
		[Token(Token = "0x6000058")]
		protected abstract int GetPlatformKey();

		// Token: 0x06000059 RID: 89
		[Token(Token = "0x6000059")]
		protected abstract void POSTImplementation(SDKExternalTools.POSTRequest request, Action<SDKExternalTools.POSTResult> callback);

		// Token: 0x0600005A RID: 90
		[Token(Token = "0x600005A")]
		protected abstract string U8RootUrl();

		// Token: 0x0600005B RID: 91
		[Token(Token = "0x600005B")]
		protected abstract string GetErrorMessage(SDKExternalTools.ErrMsgMeta meta);

		// Token: 0x0600005C RID: 92
		[Token(Token = "0x600005C")]
		protected abstract void Log(string content);

		// Token: 0x0600005D RID: 93
		[Token(Token = "0x600005D")]
		protected abstract void LogWarning(string content);

		// Token: 0x0600005E RID: 94
		[Token(Token = "0x600005E")]
		protected abstract void LogError(string content);

		// Token: 0x0600005F RID: 95 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4A14500", Offset = "0x4A13100", VA = "0x184A14500")]
		private bool _ValidatePlugin()
		{
			return default(bool);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4A12A50", Offset = "0x4A11650", VA = "0x184A12A50")]
		private static void _AddAppIdOrAppCode(Dictionary<string, object> paramDict, SDKMeta meta)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4A12FA0", Offset = "0x4A11BA0", VA = "0x184A12FA0")]
		private static string _MakeAuthParam(SDKMeta meta, string extension, string captcha)
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4A13410", Offset = "0x4A12010", VA = "0x184A13410")]
		private static string _MakeGetCaptchaParam(SDKMeta meta)
		{
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4A13E90", Offset = "0x4A12A90", VA = "0x184A13E90")]
		private static string _MakeVerifyAccountParam(string uid, string token)
		{
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x4A13670", Offset = "0x4A12270", VA = "0x184A13670")]
		private static string _MakeGetProductListParam(SDKMeta meta, int worldId)
		{
			return null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x4A13820", Offset = "0x4A12420", VA = "0x184A13820")]
		private static string _MakeGetProductListV2Param(SDKMeta meta)
		{
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x4A13B50", Offset = "0x4A12750", VA = "0x184A13B50")]
		private static string _MakeLegacyConfirmOrderParam(string uid, string orderId, string extension)
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4A13CA0", Offset = "0x4A128A0", VA = "0x184A13CA0")]
		private static string _MakeUpgradeGuestParam(string uid, string accountExt, string guestExt)
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x4A142B0", Offset = "0x4A12EB0", VA = "0x184A142B0")]
		private static string _SignRequest(Dictionary<string, object> param)
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4A12B00", Offset = "0x4A11700", VA = "0x184A12B00")]
		private static void _AddDeviceIDsToRequest(Dictionary<string, object> paramDict)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x4A102A0", Offset = "0x4A0EEA0", VA = "0x184A102A0")]
		public IEnumerator SDKInterfaceAuthV2SessionToken(SDKMeta meta, string channelToken, SDKPromiseWithResult<U8LoginV2Result> promise)
		{
			return null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x4A101D0", Offset = "0x4A0EDD0", VA = "0x184A101D0")]
		public IEnumerator SDKInterfaceAuthV2OAuth2Code(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid)
		{
			return null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x4A10370", Offset = "0x4A0EF70", VA = "0x184A10370")]
		public SDKPromise<U8ConfirmOrderResult> SDKInterfaceConfirmOrderU1(string orderId, string extension)
		{
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4A0FFE0", Offset = "0x4A0EBE0", VA = "0x184A0FFE0")]
		public SDKPromise<List<U8ServerInfo>> SDKInterFaceGetServerList(string sessionToken)
		{
			return null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4A0FDB0", Offset = "0x4A0E9B0", VA = "0x184A0FDB0")]
		public SDKPromise<U8ConfirmServerResult> SDKInterFaceConfirmServer(string sessionToken, string serverId)
		{
			return null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4A10500", Offset = "0x4A0F100", VA = "0x184A10500")]
		public SDKPromise<U8OrderInfo> SDKInterfaceCreateOrderU1(string sessionToken, string productId, string signParams)
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x4A13960", Offset = "0x4A12560", VA = "0x184A13960")]
		private static string _MakeGrantParam(string sessionToken, int type, string captcha)
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4A12C80", Offset = "0x4A11880", VA = "0x184A12C80")]
		private IEnumerator _AuthV2GrantImpl(string sessionToken, SDKPromiseWithResult<U8GrantResult> promise, Action onSessionInvalid)
		{
			return null;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x4A13230", Offset = "0x4A11E30", VA = "0x184A13230")]
		private static string _MakeCheckOrderV1Param(string orderId, string extension)
		{
			return null;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4A13340", Offset = "0x4A11F40", VA = "0x184A13340")]
		private static string _MakeConfirmOrderV1Param(string orderId)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4A12D50", Offset = "0x4A11950", VA = "0x184A12D50")]
		private IEnumerator _ConfirmOrderU1Coroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise)
		{
			return null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4A140D0", Offset = "0x4A12CD0", VA = "0x184A140D0")]
		private IEnumerator _PollOrderStatusCoroutine(string orderId, string extension, SDKPromise<U8ConfirmOrderResult> promise)
		{
			return null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4A12EF0", Offset = "0x4A11AF0", VA = "0x184A12EF0")]
		private IEnumerator _GetServerListCoroutine(string paramStr, SDKPromise<List<U8ServerInfo>> promise)
		{
			return null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4A12E20", Offset = "0x4A11A20", VA = "0x184A12E20")]
		private IEnumerator _ConfirmServerListCoroutine(string paramStr, string serverId, SDKPromise<U8ConfirmServerResult> promise)
		{
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4A14200", Offset = "0x4A12E00", VA = "0x184A14200")]
		private IEnumerator _SendCreateOrderU1Coroutine(string paramStr, SDKPromise<U8OrderInfo> promise)
		{
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4A14180", Offset = "0x4A12D80", VA = "0x184A14180")]
		private IEnumerator _SendCreateOrderFailCoroutine(SDKPromise<U8OrderInfo> promise)
		{
			return null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected SDKExternalTools()
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] RANDOM_CHAR_MAP;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		protected const string CONTENT_TYPE_JSON = "application/json";

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly int[] PAY_CONFIRM_RETRY_INTERVALS;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static SDKExternalTools s_instance;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IExternalPlugin s_plugin;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		protected const string AUTHV2_SESSION_TOKEN_PATH = "user/auth/v2/token_by_channel_token";

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		protected const string AUTHV2_GRANT_PATH = "user/auth/v2/grant";

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		protected const string GAME_SERVER_LIST = "game/server/v1/server_list";

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		protected const string GAME_CONFIRM_SERVER = "game/role/v1/confirm_server";

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		protected const string ORDERV1_CHECK_PATH = "pay/order/v1/check";

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		protected const string ORDERV1_CONFIRM_PATH = "pay/order/v1/state";

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		protected const string ORDERV1_CREATE_PATH = "pay/order/v1/create";

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		public const int GRANT_TYPE_OAUTH2CODE = 0;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int U8_SDK_SET_DATA_SET_SERVER;

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		protected interface IFromJSON
		{
			// Token: 0x0600007C RID: 124
			[Token(Token = "0x600007C")]
			bool LoadFromJSON(string json);
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		protected enum POSTStatus
		{
			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			NONE,
			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			SUC,
			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			TIMEOUT,
			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			ERROR
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		protected enum BusType
		{
			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			NONE,
			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			GET_TOKEN,
			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			GET_CAPTCHA,
			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			CREATE_ORDER,
			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			CONFIRM_ORDER,
			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			VERIFY_ACCOUNT,
			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			GET_PRODUCT_LIST,
			// Token: 0x04000035 RID: 53
			[Token(Token = "0x4000035")]
			AUTHV2_SESSION_TOKEN,
			// Token: 0x04000036 RID: 54
			[Token(Token = "0x4000036")]
			AUTHV2_OAUTH2CODE,
			// Token: 0x04000037 RID: 55
			[Token(Token = "0x4000037")]
			AUTHV2_OAUTH2TOKEN,
			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			SERVER_LIST,
			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			CONFIRM_SERVER
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		protected enum ErrorType
		{
			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			NONE,
			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			TIMEOUT,
			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			NETWORK_ERROR,
			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			DESERIALIZE_FAILED,
			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			BUSINESS_ERROR
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		protected struct POSTRequest
		{
			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string url;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string body;

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string contentType;

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, string> nullableHeaders;
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		protected struct POSTResult
		{
			// Token: 0x0600007D RID: 125 RVA: 0x0000218C File Offset: 0x0000038C
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x4A0D3B0", Offset = "0x4A0BFB0", VA = "0x184A0D3B0")]
			public bool ServiceFailed()
			{
				return default(bool);
			}

			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SDKExternalTools.POSTStatus status;

			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int httpCode;

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string response;

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string error;
		}

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		protected struct ErrMsgMeta
		{
			// Token: 0x0600007E RID: 126 RVA: 0x000021A4 File Offset: 0x000003A4
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x2114460", Offset = "0x2113060", VA = "0x182114460")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0600007F RID: 127 RVA: 0x000021BC File Offset: 0x000003BC
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x4A0B350", Offset = "0x4A09F50", VA = "0x184A0B350")]
			public static SDKExternalTools.ErrMsgMeta FromPOSTResult(SDKExternalTools.BusType busType, SDKExternalTools.POSTResult postRet)
			{
				return default(SDKExternalTools.ErrMsgMeta);
			}

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly SDKExternalTools.ErrMsgMeta EMPTY;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SDKExternalTools.BusType busType;

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public SDKExternalTools.ErrorType errorType;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int errorCode;

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string alertFromServer;

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object meta;
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		protected class CaptchaMgr
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000081 RID: 129 RVA: 0x000020C6 File Offset: 0x000002C6
			// (set) Token: 0x06000082 RID: 130 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x17000008")]
			public SDKCaptchaHandler activeHandler
			{
				[Token(Token = "0x6000081")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000082")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000083 RID: 131 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public CaptchaMgr(SDKExternalTools host)
			{
			}

			// Token: 0x06000084 RID: 132 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x4A0A830", Offset = "0x4A09430", VA = "0x184A0A830")]
			public IEnumerator FetchCaptchaCoroutine(Dictionary<string, object> captchaParams, SDKCaptchaHandler.Result outResult)
			{
				return null;
			}

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private SDKExternalTools m_host;
		}

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		protected class POSTProcedure
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600008C RID: 140 RVA: 0x000021EC File Offset: 0x000003EC
			// (set) Token: 0x0600008D RID: 141 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x1700000B")]
			private protected SDKExternalTools.POSTProcedure.Builder builder
			{
				[Token(Token = "0x600008C")]
				[Address(RVA = "0x3104AE0", Offset = "0x31036E0", VA = "0x183104AE0")]
				[CompilerGenerated]
				protected get
				{
					return default(SDKExternalTools.POSTProcedure.Builder);
				}
				[Token(Token = "0x600008D")]
				[Address(RVA = "0x3104B00", Offset = "0x3103700", VA = "0x183104B00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600008E RID: 142 RVA: 0x00002204 File Offset: 0x00000404
			// (set) Token: 0x0600008F RID: 143 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x1700000C")]
			public bool isServiceFinished
			{
				[Token(Token = "0x600008E")]
				[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600008F")]
				[Address(RVA = "0x14D9990", Offset = "0x14D8590", VA = "0x1814D9990")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000090 RID: 144 RVA: 0x0000221C File Offset: 0x0000041C
			// (set) Token: 0x06000091 RID: 145 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x1700000D")]
			public SDKExternalTools.ErrMsgMeta serviceError
			{
				[Token(Token = "0x6000090")]
				[Address(RVA = "0x4A0D370", Offset = "0x4A0BF70", VA = "0x184A0D370")]
				[CompilerGenerated]
				get
				{
					return default(SDKExternalTools.ErrMsgMeta);
				}
				[Token(Token = "0x6000091")]
				[Address(RVA = "0x4A0D390", Offset = "0x4A0BF90", VA = "0x184A0D390")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000092 RID: 146 RVA: 0x000020C6 File Offset: 0x000002C6
			// (set) Token: 0x06000093 RID: 147 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x1700000E")]
			public string rawResponse
			{
				[Token(Token = "0x6000092")]
				[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000093")]
				[Address(RVA = "0x103EF20", Offset = "0x103DB20", VA = "0x18103EF20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002234 File Offset: 0x00000434
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4A0D160", Offset = "0x4A0BD60", VA = "0x184A0D160")]
			public SDKExternalTools.ErrMsgMeta MakeBusinessError(int errorCode)
			{
				return default(SDKExternalTools.ErrMsgMeta);
			}

			// Token: 0x06000095 RID: 149 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x4A0D1A0", Offset = "0x4A0BDA0", VA = "0x184A0D1A0")]
			public IEnumerator POST(SDKExternalTools host)
			{
				return null;
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x4A0D230", Offset = "0x4A0BE30", VA = "0x184A0D230")]
			private void _OnServiceFinished(SDKExternalTools.POSTResult postRet)
			{
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
			protected virtual void HandleServiceResponse(SDKExternalTools.POSTResult postRet)
			{
			}

			// Token: 0x06000098 RID: 152 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public POSTProcedure()
			{
			}

			// Token: 0x02000014 RID: 20
			[Token(Token = "0x2000014")]
			public struct Builder
			{
				// Token: 0x06000099 RID: 153 RVA: 0x000020C6 File Offset: 0x000002C6
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x4A0A7B0", Offset = "0x4A093B0", VA = "0x184A0A7B0")]
				public SDKExternalTools.POSTProcedure Build()
				{
					return null;
				}

				// Token: 0x0600009A RID: 154 RVA: 0x000020C6 File Offset: 0x000002C6
				[Token(Token = "0x600009A")]
				public SDKExternalTools.POSTProcedure<TResp> TypedBuild<TResp>() where TResp : class, SDKExternalTools.IFromJSON, new()
				{
					return null;
				}

				// Token: 0x04000059 RID: 89
				[Token(Token = "0x4000059")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public SDKExternalTools.POSTRequest request;

				// Token: 0x0400005A RID: 90
				[Token(Token = "0x400005A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public SDKExternalTools.BusType busType;
			}
		}

		// Token: 0x02000016 RID: 22
		[Token(Token = "0x2000016")]
		protected class POSTProcedure<TResp> : SDKExternalTools.POSTProcedure where TResp : class, SDKExternalTools.IFromJSON, new()
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x000020C6 File Offset: 0x000002C6
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x17000011")]
			public TResp response
			{
				[Token(Token = "0x60000A1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60000A2")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000A3")]
			protected override void HandleServiceResponse(SDKExternalTools.POSTResult postRet)
			{
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000A4")]
			public POSTProcedure()
			{
			}
		}

		// Token: 0x02000017 RID: 23
		[Token(Token = "0x2000017")]
		protected class AuthV2SessionTokenResp : SDKExternalTools.IFromJSON
		{
			// Token: 0x060000A5 RID: 165 RVA: 0x00002264 File Offset: 0x00000464
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x4A0A580", Offset = "0x4A09180", VA = "0x184A0A580", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AuthV2SessionTokenResp()
			{
			}

			// Token: 0x04000060 RID: 96
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int status;

			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;

			// Token: 0x04000062 RID: 98
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string type;

			// Token: 0x04000063 RID: 99
			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string token;

			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string uid;

			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool isNew;
		}

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		public class GetProductLsitResp : SDKExternalTools.IFromJSON
		{
			// Token: 0x060000A7 RID: 167 RVA: 0x0000227C File Offset: 0x0000047C
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x4A0B390", Offset = "0x4A09F90", VA = "0x184A0B390")]
			public bool LoadFromDictionary(Dictionary<string, object> dict)
			{
				return default(bool);
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00002294 File Offset: 0x00000494
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x4A0B5E0", Offset = "0x4A0A1E0", VA = "0x184A0B5E0", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GetProductLsitResp()
			{
			}

			// Token: 0x04000066 RID: 102
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int flag;

			// Token: 0x04000067 RID: 103
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, object> desc;
		}

		// Token: 0x02000019 RID: 25
		[Token(Token = "0x2000019")]
		protected class AuthV2GrantResp : SDKExternalTools.IFromJSON
		{
			// Token: 0x060000AA RID: 170 RVA: 0x000022AC File Offset: 0x000004AC
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x4A0A280", Offset = "0x4A08E80", VA = "0x184A0A280", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AuthV2GrantResp()
			{
			}

			// Token: 0x04000068 RID: 104
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int status;

			// Token: 0x04000069 RID: 105
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;

			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string type;

			// Token: 0x0400006B RID: 107
			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string uid;

			// Token: 0x0400006C RID: 108
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string code;

			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string token;

			// Token: 0x0400006E RID: 110
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public long banStartTs;

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public long banEndTs;

			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public long maintainStartTs;

			// Token: 0x04000071 RID: 113
			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public long maintainEndTs;

			// Token: 0x04000072 RID: 114
			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Dictionary<string, object> captcha;
		}

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		protected class ServerListResp : SDKExternalTools.IFromJSON
		{
			// Token: 0x060000AC RID: 172 RVA: 0x000022C4 File Offset: 0x000004C4
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x4A183E0", Offset = "0x4A16FE0", VA = "0x184A183E0", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x060000AD RID: 173 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x4A189A0", Offset = "0x4A175A0", VA = "0x184A189A0")]
			public List<U8ServerInfo> ToServerInfo()
			{
				return null;
			}

			// Token: 0x060000AE RID: 174 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ServerListResp()
			{
			}

			// Token: 0x04000073 RID: 115
			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int status;

			// Token: 0x04000074 RID: 116
			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;

			// Token: 0x04000075 RID: 117
			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<SDKExternalTools.ServerListResp.ServerData> data;

			// Token: 0x0200001B RID: 27
			[Token(Token = "0x200001B")]
			public struct ServerData
			{
				// Token: 0x04000076 RID: 118
				[Token(Token = "0x4000076")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string serverId;

				// Token: 0x04000077 RID: 119
				[Token(Token = "0x4000077")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string serverName;

				// Token: 0x04000078 RID: 120
				[Token(Token = "0x4000078")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string serverDomain;

				// Token: 0x04000079 RID: 121
				[Token(Token = "0x4000079")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public bool defaultChoose;

				// Token: 0x0400007A RID: 122
				[Token(Token = "0x400007A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public string roleId;

				// Token: 0x0400007B RID: 123
				[Token(Token = "0x400007B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public string nickName;

				// Token: 0x0400007C RID: 124
				[Token(Token = "0x400007C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public long level;

				// Token: 0x0400007D RID: 125
				[Token(Token = "0x400007D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public string extension;
			}
		}

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		protected class ConfirmServerResp : SDKExternalTools.IFromJSON
		{
			// Token: 0x060000AF RID: 175 RVA: 0x000022DC File Offset: 0x000004DC
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x4A0ADC0", Offset = "0x4A099C0", VA = "0x184A0ADC0", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConfirmServerResp()
			{
			}

			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			public const int SERVER_NOT_EXIST = 100;

			// Token: 0x0400007F RID: 127
			[Token(Token = "0x400007F")]
			public const int ACCOUNT_NOT_EXIST = 100;

			// Token: 0x04000080 RID: 128
			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int status;

			// Token: 0x04000081 RID: 129
			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;
		}

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		protected class ConfirmOrderU1Resp : SDKExternalTools.IFromJSON
		{
			// Token: 0x060000B1 RID: 177 RVA: 0x000022F4 File Offset: 0x000004F4
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x4A0AD00", Offset = "0x4A09900", VA = "0x184A0AD00", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConfirmOrderU1Resp()
			{
			}

			// Token: 0x04000082 RID: 130
			[Token(Token = "0x4000082")]
			public const int STATUS_ORDER_NOT_EXIST = 100;

			// Token: 0x04000083 RID: 131
			[Token(Token = "0x4000083")]
			public const int STATUS_THIRD_PARTY_PENDING = 101;

			// Token: 0x04000084 RID: 132
			[Token(Token = "0x4000084")]
			public const int STATUS_GAME_SERVER_PENDING = 102;

			// Token: 0x04000085 RID: 133
			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int status;
		}

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		protected class CreateOrderU1Resp : SDKExternalTools.IFromJSON
		{
			// Token: 0x060000B3 RID: 179 RVA: 0x0000230C File Offset: 0x0000050C
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x4A0AEC0", Offset = "0x4A09AC0", VA = "0x184A0AEC0", Slot = "4")]
			public bool LoadFromJSON(string json)
			{
				return default(bool);
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000020C6 File Offset: 0x000002C6
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x4A0B190", Offset = "0x4A09D90", VA = "0x184A0B190")]
			public U8OrderInfo ToOrderInfo()
			{
				return null;
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x00002096 File Offset: 0x00000296
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CreateOrderU1Resp()
			{
			}

			// Token: 0x04000086 RID: 134
			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int status;

			// Token: 0x04000087 RID: 135
			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string msg;

			// Token: 0x04000088 RID: 136
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string type;

			// Token: 0x04000089 RID: 137
			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SDKExternalTools.CreateOrderU1Resp.Data data;

			// Token: 0x0200001F RID: 31
			[Token(Token = "0x200001F")]
			public struct Data
			{
				// Token: 0x0400008A RID: 138
				[Token(Token = "0x400008A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string orderId;

				// Token: 0x0400008B RID: 139
				[Token(Token = "0x400008B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public string channelProductCode;

				// Token: 0x0400008C RID: 140
				[Token(Token = "0x400008C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public string productName;

				// Token: 0x0400008D RID: 141
				[Token(Token = "0x400008D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public string productDesc;

				// Token: 0x0400008E RID: 142
				[Token(Token = "0x400008E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public long amount;

				// Token: 0x0400008F RID: 143
				[Token(Token = "0x400008F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public Dictionary<string, object> extension;
			}
		}
	}
}
