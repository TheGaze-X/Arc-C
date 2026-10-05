using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Torappu.Config;
using U8.SDK;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x02001509 RID: 5385
	[Token(Token = "0x2001509")]
	public class U8ExternalTools : SDKExternalTools, IHotfixable
	{
		// Token: 0x06007BB9 RID: 31673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BB9")]
		[Address(RVA = "0x274DFC0", Offset = "0x274CBC0", VA = "0x18274DFC0", Slot = "13")]
		protected override SDKPromise<U8LoginResult> SendSDKAuthRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BBA")]
		[Address(RVA = "0x274E1F0", Offset = "0x274CDF0", VA = "0x18274E1F0", Slot = "14")]
		protected override SDKPromise<U8CaptchaResult> SendSDKGetCaptchaRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BBB")]
		[Address(RVA = "0x274DAA0", Offset = "0x274C6A0", VA = "0x18274DAA0", Slot = "16")]
		protected override SDKPromise<U8ConfirmOrderResult> SendConfirmOrderRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BBC")]
		[Address(RVA = "0x274F2F0", Offset = "0x274DEF0", VA = "0x18274F2F0")]
		private static IEnumerator _WrappedConfirmOrderCoroutine(SDKPromise<U8ConfirmOrderResult> promise, string paramStr)
		{
			return null;
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BBD")]
		[Address(RVA = "0x274DD80", Offset = "0x274C980", VA = "0x18274DD80", Slot = "17")]
		protected override SDKPromise<List<U8ProductInfo>> SendGetProductListRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BBE")]
		[Address(RVA = "0x274DC30", Offset = "0x274C830", VA = "0x18274DC30", Slot = "18")]
		protected override SDKPromise<List<U8ProductInfo>> SendGetProductListRequestV2(string paramStr)
		{
			return null;
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BBF")]
		[Address(RVA = "0x274E630", Offset = "0x274D230", VA = "0x18274E630", Slot = "19")]
		protected override SDKPromise<object> SendUpgradeGuestRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06007BC0 RID: 31680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BC0")]
		[Address(RVA = "0x274E420", Offset = "0x274D020", VA = "0x18274E420", Slot = "15")]
		protected override SDKPromise<object> SendSDKVerifyAccountRequest(string paramStr)
		{
			return null;
		}

		// Token: 0x06007BC1 RID: 31681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BC1")]
		[Address(RVA = "0x274C880", Offset = "0x274B480", VA = "0x18274C880", Slot = "11")]
		protected override string GetSignKey()
		{
			return null;
		}

		// Token: 0x06007BC2 RID: 31682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC2")]
		[Address(RVA = "0x274D3D0", Offset = "0x274BFD0", VA = "0x18274D3D0", Slot = "24")]
		protected override void Log(string content)
		{
		}

		// Token: 0x06007BC3 RID: 31683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC3")]
		[Address(RVA = "0x274D370", Offset = "0x274BF70", VA = "0x18274D370", Slot = "25")]
		protected override void LogWarning(string content)
		{
		}

		// Token: 0x06007BC4 RID: 31684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC4")]
		[Address(RVA = "0x274D2E0", Offset = "0x274BEE0", VA = "0x18274D2E0", Slot = "26")]
		protected override void LogError(string content)
		{
		}

		// Token: 0x06007BC5 RID: 31685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC5")]
		[Address(RVA = "0x274E920", Offset = "0x274D520", VA = "0x18274E920", Slot = "5")]
		public override void SwitchAccount()
		{
		}

		// Token: 0x06007BC6 RID: 31686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC6")]
		[Address(RVA = "0x274D430", Offset = "0x274C030", VA = "0x18274D430", Slot = "7")]
		public override void OnInvalidProduct(int storeId)
		{
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC7")]
		[Address(RVA = "0x274D700", Offset = "0x274C300", VA = "0x18274D700", Slot = "8")]
		public override void OnSDKExtraInfo(string jsonData)
		{
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC8")]
		[Address(RVA = "0x274D510", Offset = "0x274C110", VA = "0x18274D510", Slot = "6")]
		public override void OnSDKError(SDKError error)
		{
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BC9")]
		[Address(RVA = "0x274D010", Offset = "0x274BC10", VA = "0x18274D010")]
		protected void InvokeNextFrame(Action action)
		{
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BCA")]
		[Address(RVA = "0x274CD80", Offset = "0x274B980", VA = "0x18274CD80")]
		protected void InvokeDelay(Action action, float delay)
		{
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BCB")]
		[Address(RVA = "0x274F030", Offset = "0x274DC30", VA = "0x18274F030")]
		private IEnumerator _NextFrameCoroutine(Action action)
		{
			return null;
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BCC")]
		[Address(RVA = "0x274ECD0", Offset = "0x274D8D0", VA = "0x18274ECD0")]
		private IEnumerator _DelayCoroutine(Action action, float delay)
		{
			return null;
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BCD")]
		[Address(RVA = "0x274EA40", Offset = "0x274D640", VA = "0x18274EA40")]
		private static string _AuthUrl()
		{
			return null;
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BCE")]
		[Address(RVA = "0x274EAB0", Offset = "0x274D6B0", VA = "0x18274EAB0")]
		private static string _CaptchaUrl()
		{
			return null;
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BCF")]
		[Address(RVA = "0x274EDB0", Offset = "0x274D9B0", VA = "0x18274EDB0")]
		private static string _GetProductListUrl()
		{
			return null;
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD0")]
		[Address(RVA = "0x274EC60", Offset = "0x274D860", VA = "0x18274EC60")]
		private static string _CreateOrderUrl()
		{
			return null;
		}

		// Token: 0x06007BD1 RID: 31697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD1")]
		[Address(RVA = "0x274EBF0", Offset = "0x274D7F0", VA = "0x18274EBF0")]
		private static string _ConfirmOrderUrl()
		{
			return null;
		}

		// Token: 0x06007BD2 RID: 31698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD2")]
		[Address(RVA = "0x274F210", Offset = "0x274DE10", VA = "0x18274F210")]
		private static string _UpdateGuestUserUrl()
		{
			return null;
		}

		// Token: 0x06007BD3 RID: 31699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD3")]
		[Address(RVA = "0x274F280", Offset = "0x274DE80", VA = "0x18274F280")]
		private static string _VerifyAccountUrl()
		{
			return null;
		}

		// Token: 0x06007BD4 RID: 31700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD4")]
		[Address(RVA = "0x274F0F0", Offset = "0x274DCF0", VA = "0x18274F0F0")]
		private static string _U8Url(string routeUrl)
		{
			return null;
		}

		// Token: 0x06007BD5 RID: 31701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD5")]
		[Address(RVA = "0x274EB20", Offset = "0x274D720", VA = "0x18274EB20")]
		private static IEnumerator _ConfirmOrderCoroutine(SDKPromise<U8ConfirmOrderResult> promise, string paramStr)
		{
			return null;
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BD6")]
		private static DataType _HandleResponseFromU8<DataType>(string responseText, out string errorCode)
		{
			return null;
		}

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x06007BD7 RID: 31703 RVA: 0x00037290 File Offset: 0x00035490
		// (set) Token: 0x06007BD8 RID: 31704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EB7")]
		public static bool isSDKInited
		{
			[Token(Token = "0x6007BD7")]
			[Address(RVA = "0x274F440", Offset = "0x274E040", VA = "0x18274F440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007BD8")]
			[Address(RVA = "0x274F4F0", Offset = "0x274E0F0", VA = "0x18274F4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06007BD9 RID: 31705 RVA: 0x000372A8 File Offset: 0x000354A8
		// (set) Token: 0x06007BDA RID: 31706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000EB8")]
		public static bool isSDKInstReady
		{
			[Token(Token = "0x6007BD9")]
			[Address(RVA = "0x274F490", Offset = "0x274E090", VA = "0x18274F490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007BDA")]
			[Address(RVA = "0x274F550", Offset = "0x274E150", VA = "0x18274F550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BDB")]
		[Address(RVA = "0x274C9F0", Offset = "0x274B5F0", VA = "0x18274C9F0")]
		public static void InitSystemsWithExtConfig()
		{
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BDC")]
		[Address(RVA = "0x274C960", Offset = "0x274B560", VA = "0x18274C960")]
		public static IEnumerator InitSDKWhenRemoteConfigReady(RemoteConfig config)
		{
			return null;
		}

		// Token: 0x06007BDD RID: 31709 RVA: 0x000372C0 File Offset: 0x000354C0
		[Token(Token = "0x6007BDD")]
		[Address(RVA = "0x274EE20", Offset = "0x274DA20", VA = "0x18274EE20")]
		private static U8Config.InitExtConfig _HandleInitExtConfigs(string extConfigStr)
		{
			return default(U8Config.InitExtConfig);
		}

		// Token: 0x06007BDE RID: 31710 RVA: 0x000372D8 File Offset: 0x000354D8
		[Token(Token = "0x6007BDE")]
		[Address(RVA = "0x274D1C0", Offset = "0x274BDC0", VA = "0x18274D1C0")]
		public static bool IsRealPayOnAndroid()
		{
			return default(bool);
		}

		// Token: 0x06007BDF RID: 31711 RVA: 0x000372F0 File Offset: 0x000354F0
		[Token(Token = "0x6007BDF")]
		[Address(RVA = "0x274D240", Offset = "0x274BE40", VA = "0x18274D240")]
		public static bool IsRealPayOnIOS()
		{
			return default(bool);
		}

		// Token: 0x06007BE0 RID: 31712 RVA: 0x00037308 File Offset: 0x00035508
		[Token(Token = "0x6007BE0")]
		[Address(RVA = "0x274D290", Offset = "0x274BE90", VA = "0x18274D290")]
		public static bool IsRealPayOnWindows()
		{
			return default(bool);
		}

		// Token: 0x06007BE1 RID: 31713 RVA: 0x00037320 File Offset: 0x00035520
		[Token(Token = "0x6007BE1")]
		[Address(RVA = "0x274D160", Offset = "0x274BD60", VA = "0x18274D160")]
		public static bool IsRealPayInTest()
		{
			return default(bool);
		}

		// Token: 0x06007BE2 RID: 31714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BE2")]
		[Address(RVA = "0x274C910", Offset = "0x274B510", VA = "0x18274C910")]
		public static string GetU8DeviceID()
		{
			return null;
		}

		// Token: 0x06007BE3 RID: 31715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BE3")]
		[Address(RVA = "0x274C4F0", Offset = "0x274B0F0", VA = "0x18274C4F0", Slot = "12")]
		public override Dictionary<string, string> GetDeviceIDs()
		{
			return null;
		}

		// Token: 0x06007BE4 RID: 31716 RVA: 0x00037338 File Offset: 0x00035538
		[Token(Token = "0x6007BE4")]
		[Address(RVA = "0x274C7E0", Offset = "0x274B3E0", VA = "0x18274C7E0", Slot = "20")]
		protected override int GetPlatformKey()
		{
			return 0;
		}

		// Token: 0x06007BE5 RID: 31717 RVA: 0x00037350 File Offset: 0x00035550
		[Token(Token = "0x6007BE5")]
		[Address(RVA = "0x274D7F0", Offset = "0x274C3F0", VA = "0x18274D7F0")]
		public bool OverrideGameVersionUpgrade()
		{
			return default(bool);
		}

		// Token: 0x06007BE6 RID: 31718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE6")]
		[Address(RVA = "0x274E840", Offset = "0x274D440", VA = "0x18274E840")]
		public static void StartSceneToLogout()
		{
		}

		// Token: 0x06007BE7 RID: 31719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BE7")]
		[Address(RVA = "0x274C1D0", Offset = "0x274ADD0", VA = "0x18274C1D0", Slot = "10")]
		protected override SDKCaptchaHandler CreateCaptchaHandler()
		{
			return null;
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BE8")]
		[Address(RVA = "0x274D9A0", Offset = "0x274C5A0", VA = "0x18274D9A0", Slot = "21")]
		protected override void POSTImplementation(SDKExternalTools.POSTRequest request, Action<SDKExternalTools.POSTResult> callback)
		{
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BE9")]
		[Address(RVA = "0x274E9A0", Offset = "0x274D5A0", VA = "0x18274E9A0", Slot = "22")]
		protected override string U8RootUrl()
		{
			return null;
		}

		// Token: 0x06007BEA RID: 31722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BEA")]
		[Address(RVA = "0x274C6F0", Offset = "0x274B2F0", VA = "0x18274C6F0", Slot = "23")]
		protected override string GetErrorMessage(SDKExternalTools.ErrMsgMeta meta)
		{
			return null;
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x00037368 File Offset: 0x00035568
		[Token(Token = "0x6007BEB")]
		[Address(RVA = "0x274C230", Offset = "0x274AE30", VA = "0x18274C230")]
		public static U8MockLogin CreateMockLoginToken(string uid)
		{
			return default(U8MockLogin);
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BEC")]
		[Address(RVA = "0x274F3C0", Offset = "0x274DFC0", VA = "0x18274F3C0")]
		public U8ExternalTools()
		{
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007BED")]
		[Address(RVA = "0x24BD6D0", Offset = "0x24BC2D0", VA = "0x1824BD6D0")]
		private string <>xLuaBaseProxy_GetSignKey()
		{
			return null;
		}

		// Token: 0x06007BEE RID: 31726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BEE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private void <>xLuaBaseProxy_SwitchAccount()
		{
		}

		// Token: 0x06007BEF RID: 31727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BEF")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnInvalidProduct(int P0)
		{
		}

		// Token: 0x06007BF0 RID: 31728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF0")]
		[Address(RVA = "0x50CDF0", Offset = "0x50B9F0", VA = "0x18050CDF0")]
		private void <>xLuaBaseProxy_OnSDKExtraInfo(string P0)
		{
		}

		// Token: 0x06007BF1 RID: 31729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BF1")]
		[Address(RVA = "0x274E980", Offset = "0x274D580", VA = "0x18274E980")]
		private void <>xLuaBaseProxy_OnSDKError(SDKError P0)
		{
		}

		// Token: 0x04007A42 RID: 31298
		[Token(Token = "0x4007A42")]
		private const int RESPONSE_STATE_SUC = 1;

		// Token: 0x04007A45 RID: 31301
		[Token(Token = "0x4007A45")]
		[FieldOffset(Offset = "0x2")]
		public static bool s_realPayInTest;

		// Token: 0x04007A46 RID: 31302
		[Token(Token = "0x4007A46")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SendSDKAuthRequest;

		// Token: 0x04007A47 RID: 31303
		[Token(Token = "0x4007A47")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendSDKGetCaptchaRequest;

		// Token: 0x04007A48 RID: 31304
		[Token(Token = "0x4007A48")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendConfirmOrderRequest;

		// Token: 0x04007A49 RID: 31305
		[Token(Token = "0x4007A49")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__WrappedConfirmOrderCoroutine;

		// Token: 0x04007A4A RID: 31306
		[Token(Token = "0x4007A4A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SendGetProductListRequest;

		// Token: 0x04007A4B RID: 31307
		[Token(Token = "0x4007A4B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SendGetProductListRequestV2;

		// Token: 0x04007A4C RID: 31308
		[Token(Token = "0x4007A4C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SendUpgradeGuestRequest;

		// Token: 0x04007A4D RID: 31309
		[Token(Token = "0x4007A4D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SendSDKVerifyAccountRequest;

		// Token: 0x04007A4E RID: 31310
		[Token(Token = "0x4007A4E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSignKey;

		// Token: 0x04007A4F RID: 31311
		[Token(Token = "0x4007A4F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Log;

		// Token: 0x04007A50 RID: 31312
		[Token(Token = "0x4007A50")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LogWarning;

		// Token: 0x04007A51 RID: 31313
		[Token(Token = "0x4007A51")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LogError;

		// Token: 0x04007A52 RID: 31314
		[Token(Token = "0x4007A52")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SwitchAccount;

		// Token: 0x04007A53 RID: 31315
		[Token(Token = "0x4007A53")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnInvalidProduct;

		// Token: 0x04007A54 RID: 31316
		[Token(Token = "0x4007A54")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnSDKExtraInfo;

		// Token: 0x04007A55 RID: 31317
		[Token(Token = "0x4007A55")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnSDKError;

		// Token: 0x04007A56 RID: 31318
		[Token(Token = "0x4007A56")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_InvokeNextFrame;

		// Token: 0x04007A57 RID: 31319
		[Token(Token = "0x4007A57")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_InvokeDelay;

		// Token: 0x04007A58 RID: 31320
		[Token(Token = "0x4007A58")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__NextFrameCoroutine;

		// Token: 0x04007A59 RID: 31321
		[Token(Token = "0x4007A59")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DelayCoroutine;

		// Token: 0x04007A5A RID: 31322
		[Token(Token = "0x4007A5A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__AuthUrl;

		// Token: 0x04007A5B RID: 31323
		[Token(Token = "0x4007A5B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CaptchaUrl;

		// Token: 0x04007A5C RID: 31324
		[Token(Token = "0x4007A5C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetProductListUrl;

		// Token: 0x04007A5D RID: 31325
		[Token(Token = "0x4007A5D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__CreateOrderUrl;

		// Token: 0x04007A5E RID: 31326
		[Token(Token = "0x4007A5E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ConfirmOrderUrl;

		// Token: 0x04007A5F RID: 31327
		[Token(Token = "0x4007A5F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateGuestUserUrl;

		// Token: 0x04007A60 RID: 31328
		[Token(Token = "0x4007A60")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__VerifyAccountUrl;

		// Token: 0x04007A61 RID: 31329
		[Token(Token = "0x4007A61")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__U8Url;

		// Token: 0x04007A62 RID: 31330
		[Token(Token = "0x4007A62")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ConfirmOrderCoroutine;

		// Token: 0x04007A63 RID: 31331
		[Token(Token = "0x4007A63")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__HandleResponseFromU8;

		// Token: 0x04007A64 RID: 31332
		[Token(Token = "0x4007A64")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_isSDKInited;

		// Token: 0x04007A65 RID: 31333
		[Token(Token = "0x4007A65")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set_isSDKInited;

		// Token: 0x04007A66 RID: 31334
		[Token(Token = "0x4007A66")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_isSDKInstReady;

		// Token: 0x04007A67 RID: 31335
		[Token(Token = "0x4007A67")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_set_isSDKInstReady;

		// Token: 0x04007A68 RID: 31336
		[Token(Token = "0x4007A68")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_InitSystemsWithExtConfig;

		// Token: 0x04007A69 RID: 31337
		[Token(Token = "0x4007A69")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_InitSDKWhenRemoteConfigReady;

		// Token: 0x04007A6A RID: 31338
		[Token(Token = "0x4007A6A")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__HandleInitExtConfigs;

		// Token: 0x04007A6B RID: 31339
		[Token(Token = "0x4007A6B")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_IsRealPayOnAndroid;

		// Token: 0x04007A6C RID: 31340
		[Token(Token = "0x4007A6C")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_IsRealPayOnIOS;

		// Token: 0x04007A6D RID: 31341
		[Token(Token = "0x4007A6D")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_IsRealPayOnWindows;

		// Token: 0x04007A6E RID: 31342
		[Token(Token = "0x4007A6E")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_IsRealPayInTest;

		// Token: 0x04007A6F RID: 31343
		[Token(Token = "0x4007A6F")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetU8DeviceID;

		// Token: 0x04007A70 RID: 31344
		[Token(Token = "0x4007A70")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GetDeviceIDs;

		// Token: 0x04007A71 RID: 31345
		[Token(Token = "0x4007A71")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_GetPlatformKey;

		// Token: 0x04007A72 RID: 31346
		[Token(Token = "0x4007A72")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_OverrideGameVersionUpgrade;

		// Token: 0x04007A73 RID: 31347
		[Token(Token = "0x4007A73")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_StartSceneToLogout;

		// Token: 0x04007A74 RID: 31348
		[Token(Token = "0x4007A74")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_CreateCaptchaHandler;

		// Token: 0x04007A75 RID: 31349
		[Token(Token = "0x4007A75")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_POSTImplementation;

		// Token: 0x04007A76 RID: 31350
		[Token(Token = "0x4007A76")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_U8RootUrl;

		// Token: 0x04007A77 RID: 31351
		[Token(Token = "0x4007A77")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_GetErrorMessage;

		// Token: 0x04007A78 RID: 31352
		[Token(Token = "0x4007A78")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_CreateMockLoginToken;

		// Token: 0x04007A79 RID: 31353
		[Token(Token = "0x4007A79")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200150A RID: 5386
		[Token(Token = "0x200150A")]
		private struct U8ProductListData
		{
			// Token: 0x04007A7A RID: 31354
			[Token(Token = "0x4007A7A")]
			[FieldOffset(Offset = "0x0")]
			public List<U8ProductInfo> productList;
		}

		// Token: 0x0200150B RID: 5387
		[Token(Token = "0x200150B")]
		private struct U8UpdateGuestResponse
		{
			// Token: 0x04007A7B RID: 31355
			[Token(Token = "0x4007A7B")]
			[FieldOffset(Offset = "0x0")]
			public int result;
		}

		// Token: 0x0200150C RID: 5388
		[Token(Token = "0x200150C")]
		private struct U8VerifyAccountResponse
		{
			// Token: 0x04007A7C RID: 31356
			[Token(Token = "0x4007A7C")]
			[FieldOffset(Offset = "0x0")]
			public string uid;
		}

		// Token: 0x0200150D RID: 5389
		[Token(Token = "0x200150D")]
		protected struct U8GetCaptchaResponse
		{
			// Token: 0x04007A7D RID: 31357
			[Token(Token = "0x4007A7D")]
			[FieldOffset(Offset = "0x0")]
			public int result;

			// Token: 0x04007A7E RID: 31358
			[Token(Token = "0x4007A7E")]
			[FieldOffset(Offset = "0x8")]
			public JObject data;
		}

		// Token: 0x0200150E RID: 5390
		[Token(Token = "0x200150E")]
		private struct U8AuthResponse
		{
			// Token: 0x06007BF2 RID: 31730 RVA: 0x00037380 File Offset: 0x00035580
			[Token(Token = "0x6007BF2")]
			[Address(RVA = "0x274C140", Offset = "0x274AD40", VA = "0x18274C140")]
			public U8LoginResult ToLoginResult()
			{
				return default(U8LoginResult);
			}

			// Token: 0x04007A7F RID: 31359
			[Token(Token = "0x4007A7F")]
			[FieldOffset(Offset = "0x0")]
			public int result;

			// Token: 0x04007A80 RID: 31360
			[Token(Token = "0x4007A80")]
			[FieldOffset(Offset = "0x8")]
			public string uid;

			// Token: 0x04007A81 RID: 31361
			[Token(Token = "0x4007A81")]
			[FieldOffset(Offset = "0x10")]
			public string channelUid;

			// Token: 0x04007A82 RID: 31362
			[Token(Token = "0x4007A82")]
			[FieldOffset(Offset = "0x18")]
			public string token;

			// Token: 0x04007A83 RID: 31363
			[Token(Token = "0x4007A83")]
			[FieldOffset(Offset = "0x20")]
			public string extension;

			// Token: 0x04007A84 RID: 31364
			[Token(Token = "0x4007A84")]
			[FieldOffset(Offset = "0x28")]
			public bool isGuest;

			// Token: 0x04007A85 RID: 31365
			[Token(Token = "0x4007A85")]
			[FieldOffset(Offset = "0x30")]
			public string error;

			// Token: 0x04007A86 RID: 31366
			[Token(Token = "0x4007A86")]
			[FieldOffset(Offset = "0x38")]
			public string captchaTips;

			// Token: 0x04007A87 RID: 31367
			[Token(Token = "0x4007A87")]
			[FieldOffset(Offset = "0x40")]
			public JObject captcha;
		}

		// Token: 0x0200150F RID: 5391
		[Token(Token = "0x200150F")]
		public interface IEditorHook
		{
			// Token: 0x06007BF3 RID: 31731
			[Token(Token = "0x6007BF3")]
			string GetData(int type, string paramJson);

			// Token: 0x06007BF4 RID: 31732
			[Token(Token = "0x6007BF4")]
			void SetData(int type, string paramJson);
		}
	}
}
