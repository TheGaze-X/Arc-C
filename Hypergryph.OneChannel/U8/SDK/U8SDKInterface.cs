using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public abstract class U8SDKInterface
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000028")]
		public static U8SDKInterface Instance
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x4A29840", Offset = "0x4A28440", VA = "0x184A29840")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4A28E40", Offset = "0x4A27A40", VA = "0x184A28E40")]
		private SDKMeta _InternalSDKMeta()
		{
			return null;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x17000029")]
		public bool isNativePlugin
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x4A29AB0", Offset = "0x4A286B0", VA = "0x184A29AB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x4A24330", Offset = "0x4A22F30", VA = "0x184A24330")]
		public void CallbackInitSuc(string extConfigs)
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x4A242B0", Offset = "0x4A22EB0", VA = "0x184A242B0")]
		public void CallbackInitFail(string info)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x4A24420", Offset = "0x4A23020", VA = "0x184A24420")]
		public void CallbackLoginSuc(string extension)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x4A243A0", Offset = "0x4A22FA0", VA = "0x184A243A0")]
		public void CallbackLoginFail(string info)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x4A24490", Offset = "0x4A23090", VA = "0x184A24490")]
		public void CallbackLogout()
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x4A246C0", Offset = "0x4A232C0", VA = "0x184A246C0")]
		public void CallbackSwitchAccount()
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x4A245E0", Offset = "0x4A231E0", VA = "0x184A245E0")]
		public void CallbackPaySuc(string jsonData)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x4A24500", Offset = "0x4A23100", VA = "0x184A24500")]
		public void CallbackPayFail(string failMsg)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x1700002A")]
		public string uid
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600013D RID: 317 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x1700002B")]
		public string channel
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x4A29A20", Offset = "0x4A28620", VA = "0x184A29A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002564 File Offset: 0x00000764
		[Token(Token = "0x1700002C")]
		public int worldId
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x4A29CD0", Offset = "0x4A288D0", VA = "0x184A29CD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600013F RID: 319 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x06000140 RID: 320 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700002D")]
		public string cachedUid
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x4A299E0", Offset = "0x4A285E0", VA = "0x184A299E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x4A29E40", Offset = "0x4A28A40", VA = "0x184A29E40")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x1700002E")]
		public string token
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x1700002F")]
		public string oauth2token
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000143 RID: 323 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000030")]
		public string oauth2code
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000031")]
		public List<U8ProductInfo> productList
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x17000032")]
		public static bool isInterfaceDisabled
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x4568380", Offset = "0x4566F80", VA = "0x184568380")]
		public string PublicLoadExtraConfig()
		{
			return null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x4A274A0", Offset = "0x4A260A0", VA = "0x184A274A0")]
		public void PublicSetGameVersion(string version)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4A297F0", Offset = "0x4A283F0", VA = "0x184A297F0")]
		public U8SDKInterface.ReceiverProductListResult getOnReceiverProductlist()
		{
			return null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000149")]
		public SDKPromise<string> PublicInit<ToolType>() where ToolType : SDKExternalTools
		{
			return null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600014A")]
		public SDKPromise<string> V2PublicInit<ToolType>(string env) where ToolType : SDKExternalTools
		{
			return null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x4A266A0", Offset = "0x4A252A0", VA = "0x184A266A0")]
		public SDKPromise<string> PublicLogin()
		{
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4A28F10", Offset = "0x4A27B10", VA = "0x184A28F10")]
		private void _MarkMockLogin(U8MockLogin mockLogin)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4A25B90", Offset = "0x4A24790", VA = "0x184A25B90")]
		public SDKPromise<U8LoginResult> PublicAuth(string captcha)
		{
			return null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x4A29600", Offset = "0x4A28200", VA = "0x184A29600")]
		private void _onLoginSuc(string uid, bool isNew)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4A26410", Offset = "0x4A25010", VA = "0x184A26410")]
		public SDKPromise<List<U8ProductInfo>> PublicGetProductList()
		{
			return null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4A262B0", Offset = "0x4A24EB0", VA = "0x184A262B0")]
		public SDKPromise<U8ProductsResult> PublicGetProductListV2()
		{
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4A289B0", Offset = "0x4A275B0", VA = "0x184A289B0")]
		private SDKPromise<U8LoginResult> _DoMockLoginAuth()
		{
			return null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4A261A0", Offset = "0x4A24DA0", VA = "0x184A261A0")]
		public SDKPromise<U8CaptchaResult> PublicGetCaptcha()
		{
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x4A24740", Offset = "0x4A23340", VA = "0x184A24740")]
		public void ClearAuthStatus()
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x4A24800", Offset = "0x4A23400", VA = "0x184A24800")]
		public void ClearLoginStatus()
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x4A28810", Offset = "0x4A27410", VA = "0x184A28810")]
		private void _ConfirmAuthResult(U8SDKInterface.AuthStatus result)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x4A274F0", Offset = "0x4A260F0", VA = "0x184A274F0")]
		public SDKPromise<object> PublicVerifyAuth()
		{
			return null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4A28F30", Offset = "0x4A27B30", VA = "0x184A28F30")]
		private SDKPromise<object> _MockVerifyAccount()
		{
			return null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4A26810", Offset = "0x4A25410", VA = "0x184A26810")]
		public SDKPromise<object> PublicLogout()
		{
			return null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4A26110", Offset = "0x4A24D10", VA = "0x184A26110")]
		public SDKPromise<U8OrderInfo> PublicCreateOrder(string productId, string signParams)
		{
			return null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x4A26570", Offset = "0x4A25170", VA = "0x184A26570")]
		public SDKPromise<List<U8ServerInfo>> PublicGetServerList()
		{
			return null;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x4A276A0", Offset = "0x4A262A0", VA = "0x184A276A0")]
		public SDKPromise<U8ConfirmServerResult> PubliceConfirmServer(string serverId)
		{
			return null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x4A268B0", Offset = "0x4A254B0", VA = "0x184A268B0")]
		public SDKPromise<U8PayResult> PublicPay(int storeId, U8OrderInfo orderInfo)
		{
			return null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x4A291D0", Offset = "0x4A27DD0", VA = "0x184A291D0")]
		private void _OnNativePayFulfilled(long revenue)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4A25DF0", Offset = "0x4A249F0", VA = "0x184A25DF0")]
		public SDKPromise<U8ConfirmOrderResult> PublicConfirmOrder(string orderId, string extension)
		{
			return null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4A25B00", Offset = "0x4A24700", VA = "0x184A25B00")]
		[Obsolete]
		public SDKPromise<object> LegacyUpgradeGuest(string targetUid, string guestExt, string accountExt)
		{
			return null;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000033")]
		public string sdkUid
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x4A29B70", Offset = "0x4A28770", VA = "0x184A29B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4A292E0", Offset = "0x4A27EE0", VA = "0x184A292E0")]
		private bool _TryGetProduct(int storeId, out U8ProductInfo productInfo)
		{
			return default(bool);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4A28AD0", Offset = "0x4A276D0", VA = "0x184A28AD0")]
		private U8PayParams _GeneratePayParams(U8ProductInfo productInfo, U8OrderInfo orderInfo)
		{
			return null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4A27B80", Offset = "0x4A26780", VA = "0x184A27B80")]
		public SDKPromise<U8PayResult> Test_NativePay()
		{
			return null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x4A29050", Offset = "0x4A27C50", VA = "0x184A29050")]
		private SDKPromise<U8PayResult> _NativePay(U8PayParams payParams)
		{
			return null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000165")]
		private static T GetValueSafe<T>(Dictionary<string, object> dict, string key, [Optional] T defVal)
		{
			return null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x4A26580", Offset = "0x4A25180", VA = "0x184A26580")]
		public SDKMeta PublicLoadSDKMeta()
		{
			return null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000025AC File Offset: 0x000007AC
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x4A27BF0", Offset = "0x4A267F0", VA = "0x184A27BF0")]
		public bool TryFindInfoByProductId(string productId, out U8ProductInfo outInfo)
		{
			return default(bool);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4A24F00", Offset = "0x4A23B00", VA = "0x184A24F00")]
		public string GenU8Sign(IDictionary<string, string> signDict, string appKey)
		{
			return null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x4A286D0", Offset = "0x4A272D0", VA = "0x184A286D0")]
		private static string _BinaryToHexString(byte[] binary, int index, int length)
		{
			return null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x4A241A0", Offset = "0x4A22DA0", VA = "0x184A241A0")]
		public SDKPromise<string> AuthV2(string captcha)
		{
			return null;
		}

		// Token: 0x0600016B RID: 363
		[Token(Token = "0x600016B")]
		protected abstract string LoadExtraConfig();

		// Token: 0x0600016C RID: 364
		[Token(Token = "0x600016C")]
		protected abstract void V2Init(string env);

		// Token: 0x0600016D RID: 365
		[Token(Token = "0x600016D")]
		protected abstract void Init();

		// Token: 0x0600016E RID: 366
		[Token(Token = "0x600016E")]
		protected abstract void Login();

		// Token: 0x0600016F RID: 367
		[Token(Token = "0x600016F")]
		protected abstract void LoginCustom(string customData);

		// Token: 0x06000170 RID: 368
		[Token(Token = "0x6000170")]
		protected abstract void SwitchLogin();

		// Token: 0x06000171 RID: 369
		[Token(Token = "0x6000171")]
		protected abstract bool Logout();

		// Token: 0x06000172 RID: 370
		[Token(Token = "0x6000172")]
		public abstract bool ShowAccountCenter();

		// Token: 0x06000173 RID: 371 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x4A27950", Offset = "0x4A26550", VA = "0x184A27950")]
		public void SubmitGameData(U8ExtraGameData data)
		{
		}

		// Token: 0x06000174 RID: 372
		[Token(Token = "0x6000174")]
		public abstract void SubmitGameDataNative(U8ExtraGameData data);

		// Token: 0x06000175 RID: 373
		[Token(Token = "0x6000175")]
		public abstract bool SDKExit();

		// Token: 0x06000176 RID: 374
		[Token(Token = "0x6000176")]
		protected abstract void Pay(U8PayParams data);

		// Token: 0x06000177 RID: 375
		[Token(Token = "0x6000177")]
		public abstract bool IsSupportExit();

		// Token: 0x06000178 RID: 376
		[Token(Token = "0x6000178")]
		public abstract bool IsSupportAccountCenter();

		// Token: 0x06000179 RID: 377
		[Token(Token = "0x6000179")]
		public abstract bool IsSupportLogout();

		// Token: 0x0600017A RID: 378
		[Token(Token = "0x600017A")]
		public abstract bool IsSupportLogin();

		// Token: 0x0600017B RID: 379 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4A27720", Offset = "0x4A26320", VA = "0x184A27720")]
		public void SetData(int type, string paramJson)
		{
		}

		// Token: 0x0600017C RID: 380
		[Token(Token = "0x600017C")]
		public abstract void SetDataNative(int type, string paramJson);

		// Token: 0x0600017D RID: 381 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x4A25760", Offset = "0x4A24360", VA = "0x184A25760")]
		public string GetData(int type, string paramJson)
		{
			return null;
		}

		// Token: 0x0600017E RID: 382
		[Token(Token = "0x600017E")]
		public abstract string GetDataNative(int type, string paramJson);

		// Token: 0x0600017F RID: 383
		[Token(Token = "0x600017F")]
		protected abstract SDKMeta LoadSDKMeta();

		// Token: 0x06000180 RID: 384
		[Token(Token = "0x6000180")]
		protected abstract bool IsNativePlugin();

		// Token: 0x06000181 RID: 385
		[Token(Token = "0x6000181")]
		public abstract void SetGameVersion(string version);

		// Token: 0x06000182 RID: 386 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x4A29150", Offset = "0x4A27D50", VA = "0x184A29150")]
		private IEnumerator _NextFrameCoroutine(Action call)
		{
			return null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4A25A30", Offset = "0x4A24630", VA = "0x184A25A30")]
		protected void InvokeNextFrame(Action action)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4A259D0", Offset = "0x4A245D0", VA = "0x184A259D0")]
		protected void InvokeCoroutine(IEnumerator coroutine)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4A24830", Offset = "0x4A23430", VA = "0x184A24830")]
		protected string EncodeGameData(U8ExtraGameData data)
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4A24B40", Offset = "0x4A23740", VA = "0x184A24B40")]
		protected string EncodePayParams(U8PayParams data)
		{
			return null;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000187 RID: 391 RVA: 0x00002096 File Offset: 0x00000296
		// (remove) Token: 0x06000188 RID: 392 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x14000001")]
		private static event U8SDKInterface.ReceiverProductListResult onReceiverProductlist
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x4A296F0", Offset = "0x4A282F0", VA = "0x184A296F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x4A29D40", Offset = "0x4A28940", VA = "0x184A29D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x17000034")]
		public string sessionToken
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000035")]
		public U8SDKInterface.GameServerTimeCache serverCacheTime
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x4A29CB0", Offset = "0x4A288B0", VA = "0x184A29CB0")]
			get
			{
				return default(U8SDKInterface.GameServerTimeCache);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x4A29EA0", Offset = "0x4A28AA0", VA = "0x184A29EA0")]
			set
			{
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4A28510", Offset = "0x4A27110", VA = "0x184A28510")]
		public SDKPromise<string> V2PublicLogin()
		{
			return null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x4A282B0", Offset = "0x4A26EB0", VA = "0x184A282B0")]
		public SDKPromise<U8AuthV2Result> V2PublicAuth()
		{
			return null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x4A26110", Offset = "0x4A24D10", VA = "0x184A26110")]
		public SDKPromise<U8OrderInfo> U1PublicCreateOrder(string productId, string signParams)
		{
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4A27EB0", Offset = "0x4A26AB0", VA = "0x184A27EB0")]
		public SDKPromise<List<U8ServerInfo>> U1PublicGetServerList()
		{
			return null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x4A276A0", Offset = "0x4A262A0", VA = "0x184A276A0")]
		public SDKPromise<U8ConfirmServerResult> U1PublicConfirmServer(string serverId)
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x4A27CE0", Offset = "0x4A268E0", VA = "0x184A27CE0")]
		public SDKPromise<U8ConfirmOrderResult> U1PublicConfirmOrder(string orderId, string extension)
		{
			return null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x4A28890", Offset = "0x4A27490", VA = "0x184A28890")]
		private SDKPromise<U8AuthV2Result> _DoMockAuthV2()
		{
			return null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x4A28E80", Offset = "0x4A27A80", VA = "0x184A28E80")]
		private IEnumerator _LoginV2Coroutine(SDKPromise<string> promise)
		{
			return null;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x4A292A0", Offset = "0x4A27EA0", VA = "0x184A292A0")]
		private void _OnSessionTokenInvalid()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x4A28640", Offset = "0x4A27240", VA = "0x184A28640")]
		private IEnumerator _AuthV2Coroutine(SDKPromise<U8AuthV2Result> promise)
		{
			return null;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x4A29400", Offset = "0x4A28000", VA = "0x184A29400")]
		protected U8SDKInterface()
		{
		}

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		public const string KEYWORD_DISABLE = "U8_DISABLE";

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		private const string KEY_CACHED_UID = "u8sdk_cached_uid";

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static U8SDKInterface m_instance;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected SDKPromiseWrapper m_initPromise;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected SDKPromiseWrapper m_loginPromise;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected SDKPromiseWrapper m_logoutPromise;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected SDKPromiseWrapper m_payPromise;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private U8LoginResult m_loginResult;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private U8SDKInterface.AuthStatus m_authStatus;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string m_loginExtV1;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private U8MockLogin m_mockLogin;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<U8ProductInfo> m_productList;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool? m_isNativePlugin;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private SDKMeta m_sdkMeta;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private U8SDKInterface.V2LoginStatus m_loginStatusV2;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int U8_SDK_SET_DATA_SET_SESSION_TOKEN;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int U8_SDK_SET_DATA_GET_PRODUCT_LIST;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private U8SDKInterface.GameServerTimeCache m_gameServerTimeCache;

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		public struct AuthStatus
		{
			// Token: 0x0600019B RID: 411 RVA: 0x000025DC File Offset: 0x000007DC
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x04000145 RID: 325
			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly U8SDKInterface.AuthStatus EMPTY;

			// Token: 0x04000146 RID: 326
			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x04000147 RID: 327
			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string oauth2code;

			// Token: 0x04000148 RID: 328
			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string oauth2token;

			// Token: 0x04000149 RID: 329
			[Token(Token = "0x4000149")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string sessionToken;
		}

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		private struct V2LoginStatus
		{
			// Token: 0x0400014A RID: 330
			[Token(Token = "0x400014A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string sessionToken;
		}

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x0600019E RID: 414
		[Token(Token = "0x2000043")]
		public delegate void ReceiverProductListResult(Dictionary<string, object> msg);

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		public struct GameServerTimeCache
		{
			// Token: 0x0400014B RID: 331
			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long cacheTime;

			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long maintainEndTs;

			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public long maintainStartTs;
		}
	}
}
