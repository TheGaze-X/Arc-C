using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Torappu.Network;
using Torappu.SDK;
using Torappu.UI;
using U8.SDK;
using UnityEngine;
using XLua;

namespace XDSDK
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	public class XDSDK : SDKBase<XDSDK>, IMsgHolderInjecter
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public string lastUsedUid
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x519C70", Offset = "0x518870", VA = "0x180519C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		protected string lastUsedAccountToken
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x519B50", Offset = "0x518750", VA = "0x180519B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public string lastUsedGuestToken
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x519BE0", Offset = "0x5187E0", VA = "0x180519BE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x17000035")]
		public bool lastIdentityVerified
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x519A30", Offset = "0x518630", VA = "0x180519A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x17000036")]
		public bool lastIsMinor
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x519AC0", Offset = "0x5186C0", VA = "0x180519AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000037")]
		protected string deviceId
		{
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x519660", Offset = "0x518260", VA = "0x180519660")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000038")]
		public string SDKUrl
		{
			[Token(Token = "0x6000321")]
			[Address(RVA = "0x519510", Offset = "0x518110", VA = "0x180519510")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000039")]
		public string cachedUsername
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x5195D0", Offset = "0x5181D0", VA = "0x1805195D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x519DE0", Offset = "0x5189E0", VA = "0x180519DE0")]
			protected set
			{
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public string sdkUid
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x519D70", Offset = "0x518970", VA = "0x180519D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public string sdkToken
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x519D00", Offset = "0x518900", VA = "0x180519D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x1700003C")]
		public bool hasCachedUser
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x5199A0", Offset = "0x5185A0", VA = "0x1805199A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x517410", Offset = "0x516010", VA = "0x180517410")]
		public bool CheckIfGuest()
		{
			return default(bool);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x517CC0", Offset = "0x5168C0", VA = "0x180517CC0")]
		public void ProcessPaymentState_PayProcess(Action<XDSDK.PayResult> callback)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public override IExternalPlugin externalPlugin
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x519780", Offset = "0x518380", VA = "0x180519780", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x518610", Offset = "0x517210", VA = "0x180518610")]
		public void TryInjectSwitchAccount(InjectSwitchAccountOptions options)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x5179F0", Offset = "0x5165F0", VA = "0x1805179F0")]
		public void PreventGuestDelete(Action nextStep)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x517EE0", Offset = "0x516AE0", VA = "0x180517EE0", Slot = "10")]
		private bool isPopupAgreement()
		{
			return default(bool);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x5182F0", Offset = "0x516EF0", VA = "0x1805182F0", Slot = "11")]
		public void TryInjectCashShop(InjectShopOptions options)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x518770", Offset = "0x517370", VA = "0x180518770", Slot = "13")]
		public void TryShowGlobalAgreement(Action onAgree, Action backLogin)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x518370", Offset = "0x516F70", VA = "0x180518370", Slot = "12")]
		public void TryInjectSettings(InjectSettingOptions options)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x517500", Offset = "0x516100", VA = "0x180517500")]
		public void ConfirmLoginInfo(XDSDK.LoginResult result, bool isGuest, bool isUpgradingDuringPay = false)
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x517820", Offset = "0x516420", VA = "0x180517820")]
		public void Login(Action<XDSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x5178B0", Offset = "0x5164B0", VA = "0x1805178B0")]
		public void Logout(Action onSuc, Action onFail)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x517960", Offset = "0x516560", VA = "0x180517960")]
		public void Pay(Action<XDSDK.PayResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x517F50", Offset = "0x516B50", VA = "0x180517F50")]
		public void TryFetchCashProductInfo(Action<List<SDKCashProduct>> onSuc, Action<string> onFail)
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x519020", Offset = "0x517C20", VA = "0x180519020")]
		private void _QuerySkuDetailsCallBack(JObject querySkuDetailsRet)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x516740", Offset = "0x515340", VA = "0x180516740")]
		public void CallLoginService(string username, string password, Action<XDSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x515A90", Offset = "0x514690", VA = "0x180515A90")]
		public void CallAuthService(string token, Action<XDSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x516FF0", Offset = "0x515BF0", VA = "0x180516FF0")]
		public void CallSendSmsCodeForLogin(string phoneNumber, Action<UserSendSmsCodeResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x5170A0", Offset = "0x515CA0", VA = "0x1805170A0")]
		public void CallSendSmsCodeForRegister(string phoneNumber, Action<UserSendSmsCodeResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x518800", Offset = "0x517400", VA = "0x180518800")]
		private void _CallSendSmsCode(string phoneNumber, int act, Action<UserSendSmsCodeResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x516D00", Offset = "0x515900", VA = "0x180516D00")]
		public void CallRegisterService(string account, string pwd, string smsCode, Action<XDSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x517150", Offset = "0x515D50", VA = "0x180517150")]
		public void CallSmsCodeLoginService(string phoneNum, string smsCode, Action<XDSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x515FA0", Offset = "0x514BA0", VA = "0x180515FA0")]
		public void CallGuestRegisterCaptcha(Action<UserGuestCaptchaResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x515D10", Offset = "0x514910", VA = "0x180515D10")]
		public void CallGuestLoginService(string captcha, Action<XDSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x516B90", Offset = "0x515790", VA = "0x180516B90")]
		public UISender.ResultHandler<PayCreateOrderAppstoreResponse> CallPayCreateOrderAppstore(string orderId)
		{
			return null;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x5165D0", Offset = "0x5151D0", VA = "0x1805165D0")]
		public UISender.ResultHandler<PayConfirmOrderAppstoreResponse> CallLegacyPayConfirmOrderAppstore(string orderId, string receiptData)
		{
			return null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x516A00", Offset = "0x515600", VA = "0x180516A00")]
		public UISender.ResultHandler<PayConfirmOrderAppstoreNewResponse> CallPayConfirmOrderAppstore(string curOrderId, List<AppstoreOrder> infoList, string receiptData)
		{
			return null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x516340", Offset = "0x514F40", VA = "0x180516340")]
		public void CallIdentityVerifyService(string realName, string cardNum, Action<UserIdentityAuthResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x515A00", Offset = "0x514600", VA = "0x180515A00")]
		public static void Alert(string content, [Optional] Action onConfirm)
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x517E60", Offset = "0x516A60", VA = "0x180517E60")]
		public static void Toast(string content)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x517DF0", Offset = "0x5169F0", VA = "0x180517DF0")]
		public static void ShowReentrantLoading()
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x5177B0", Offset = "0x5163B0", VA = "0x1805177B0")]
		public static void HideReentrantLoading()
		{
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x518A70", Offset = "0x517670", VA = "0x180518A70")]
		private static string _GenRandomString()
		{
			return null;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000348")]
		private UISender.ResultHandler<RespType> _SendSDKRequest<RequestType, RespType>(string serviceCode, RequestType requestContent, bool needSign = true) where RespType : class
		{
			return null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x518E80", Offset = "0x517A80", VA = "0x180518E80")]
		private void _OnLoginSuc(XDSDK.LoginResult result, bool isGuest, Action<XDSDK.LoginResult> onSuc)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x518BB0", Offset = "0x5177B0", VA = "0x180518BB0")]
		private void _OnAuthOrLoginFail(string alert, Action onFail)
		{
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x518F60", Offset = "0x517B60", VA = "0x180518F60")]
		private void _OnRegisterFailed(string alert, Action onFail)
		{
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x518D70", Offset = "0x517970", VA = "0x180518D70")]
		private void _OnGuestLoginFailed(long errorCode, Action onFail)
		{
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x519480", Offset = "0x518080", VA = "0x180519480")]
		public XDSDK()
		{
		}

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		public const string VERSION = "0.1.0";

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] RANDOM_CHAR_MAP;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<JObject> QuerySkuDetailsEvent;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<List<SDKCashProduct>> QuerySkuDetailsOnSuc;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private XDSDK.SDKOptions _sdkOptions;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private XDLoginSwitchAccountPlugin _switchAccountPrefab;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private XDAccountSetting _accountSettingPrefab;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string m_token;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string m_uid;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private U8Plugin m_u8Plugin;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action<XDSDK.LoginResult> m_editorLoginCallback;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_lastUsedUid;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lastUsedAccountToken;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_lastUsedGuestToken;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_lastIdentityVerified;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_lastIsMinor;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_deviceId;

		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_SDKUrl;

		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_cachedUsername;

		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_cachedUsername;

		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_sdkUid;

		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_sdkToken;

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_hasCachedUser;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckIfGuest;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ProcessPaymentState_PayProcess;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_externalPlugin;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_TryInjectSwitchAccount;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_PreventGuestDelete;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge isPopupAgreement;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_TryInjectCashShop;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_TryShowGlobalAgreement;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_TryInjectSettings;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ConfirmLoginInfo;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_Login;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Logout;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_Pay;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TryFetchCashProductInfo;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__QuerySkuDetailsCallBack;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CallLoginService;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CallAuthService;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CallSendSmsCodeForLogin;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CallSendSmsCodeForRegister;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CallSendSmsCode;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CallRegisterService;

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_CallSmsCodeLoginService;

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CallGuestRegisterCaptcha;

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CallGuestLoginService;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CallPayCreateOrderAppstore;

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CallLegacyPayConfirmOrderAppstore;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CallPayConfirmOrderAppstore;

		// Token: 0x040003F7 RID: 1015
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_CallIdentityVerifyService;

		// Token: 0x040003F8 RID: 1016
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_Alert;

		// Token: 0x040003F9 RID: 1017
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_Toast;

		// Token: 0x040003FA RID: 1018
		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_ShowReentrantLoading;

		// Token: 0x040003FB RID: 1019
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_HideReentrantLoading;

		// Token: 0x040003FC RID: 1020
		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__GenRandomString;

		// Token: 0x040003FD RID: 1021
		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__SendSDKRequest;

		// Token: 0x040003FE RID: 1022
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__OnLoginSuc;

		// Token: 0x040003FF RID: 1023
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__OnAuthOrLoginFail;

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__OnRegisterFailed;

		// Token: 0x04000401 RID: 1025
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__OnGuestLoginFailed;

		// Token: 0x04000402 RID: 1026
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020000BA RID: 186
		[Token(Token = "0x20000BA")]
		private class queryResult
		{
			// Token: 0x1700003E RID: 62
			// (get) Token: 0x0600034F RID: 847 RVA: 0x00002D00 File Offset: 0x00000F00
			// (set) Token: 0x06000350 RID: 848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700003E")]
			public int flag
			{
				[Token(Token = "0x600034F")]
				[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000350")]
				[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000352 RID: 850 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700003F")]
			public JObject desc
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000352")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000353 RID: 851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public queryResult()
			{
			}
		}

		// Token: 0x020000BB RID: 187
		[Token(Token = "0x20000BB")]
		private class SkuDetail
		{
			// Token: 0x17000040 RID: 64
			// (get) Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000355 RID: 853 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000040")]
			public string amount
			{
				[Token(Token = "0x6000354")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000356 RID: 854 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000357 RID: 855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000041")]
			public string cur
			{
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000357")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000358 RID: 856 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000359 RID: 857 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000042")]
			public string displayPrice
			{
				[Token(Token = "0x6000358")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000359")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600035A RID: 858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SkuDetail()
			{
			}
		}

		// Token: 0x020000BC RID: 188
		[Token(Token = "0x20000BC")]
		[RequireComponent(typeof(CanvasGroup))]
		public abstract class UIPage : MonoBehaviour
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x0600035B RID: 859 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600035C RID: 860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000043")]
			private protected XDSDK sdk
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000044")]
			public string cachedUsername
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x103F950", Offset = "0x103E550", VA = "0x18103F950")]
				get
				{
					return null;
				}
				[Token(Token = "0x600035E")]
				[Address(RVA = "0x103FE10", Offset = "0x103EA10", VA = "0x18103FE10")]
				protected set
				{
				}
			}

			// Token: 0x0600035F RID: 863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x103F3E0", Offset = "0x103DFE0", VA = "0x18103F3E0")]
			public string GetAvailableToken(out bool isGuest)
			{
				return null;
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000360 RID: 864 RVA: 0x00002D18 File Offset: 0x00000F18
			[Token(Token = "0x17000045")]
			protected virtual float fadeDuration
			{
				[Token(Token = "0x6000360")]
				[Address(RVA = "0x738E20", Offset = "0x737A20", VA = "0x180738E20", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000046")]
			protected CanvasGroup canvasGroup
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x103FA40", Offset = "0x103E640", VA = "0x18103FA40")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x103F680", Offset = "0x103E280", VA = "0x18103F680")]
			public IEnumerator Open()
			{
				return null;
			}

			// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x103F1C0", Offset = "0x103DDC0", VA = "0x18103F1C0")]
			public IEnumerator Close()
			{
				return null;
			}

			// Token: 0x06000364 RID: 868
			[Token(Token = "0x6000364")]
			protected abstract void OnInit();

			// Token: 0x06000365 RID: 869
			[Token(Token = "0x6000365")]
			protected abstract void OnOpen();

			// Token: 0x06000366 RID: 870
			[Token(Token = "0x6000366")]
			protected abstract void OnClose();

			// Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x103F530", Offset = "0x103E130", VA = "0x18103F530", Slot = "8")]
			protected virtual void OnDestroy()
			{
			}

			// Token: 0x06000368 RID: 872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
			protected UIPage()
			{
			}

			// Token: 0x04000408 RID: 1032
			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Tween m_tween;

			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private CanvasGroup m_canvasGroup;
		}

		// Token: 0x020000BF RID: 191
		[Token(Token = "0x20000BF")]
		public struct LoginResult
		{
			// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x10344D0", Offset = "0x10330D0", VA = "0x1810344D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000411 RID: 1041
			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x04000412 RID: 1042
			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[JsonProperty(PropertyName = "access_token")]
			public string token;

			// Token: 0x04000413 RID: 1043
			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonIgnore]
			public bool isIdentityVerified;

			// Token: 0x04000414 RID: 1044
			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[JsonIgnore]
			public bool isMinor;
		}

		// Token: 0x020000C0 RID: 192
		[Token(Token = "0x20000C0")]
		public struct PayResult
		{
			// Token: 0x06000376 RID: 886 RVA: 0x00002D60 File Offset: 0x00000F60
			[Token(Token = "0x6000376")]
			[Address(RVA = "0xEAD120", Offset = "0xEABD20", VA = "0x180EAD120")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x1034820", Offset = "0x1033420", VA = "0x181034820", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000415 RID: 1045
			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static XDSDK.PayResult EMPTY;

			// Token: 0x04000416 RID: 1046
			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PayResultStatus status;

			// Token: 0x04000417 RID: 1047
			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string outTradeNo;
		}

		// Token: 0x020000C1 RID: 193
		[Token(Token = "0x20000C1")]
		public struct SDKRequestBundle<T> : IMsgBundle
		{
			// Token: 0x06000379 RID: 889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000379")]
			public void Deserialize(string data, JsonSerializerSettings setting)
			{
			}

			// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600037A")]
			public string Serialize(JsonSerializerSettings setting)
			{
				return null;
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600037B")]
			private static string _SignRequest(JObject jsonObj)
			{
				return null;
			}

			// Token: 0x04000418 RID: 1048
			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T data;

			// Token: 0x04000419 RID: 1049
			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool needSign;
		}

		// Token: 0x020000C2 RID: 194
		[Token(Token = "0x20000C2")]
		[Serializable]
		public struct SDKOptions
		{
			// Token: 0x0400041A RID: 1050
			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string appID;

			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string appKey;

			// Token: 0x0400041C RID: 1052
			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string channelID;

			// Token: 0x0400041D RID: 1053
			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string worldId;
		}
	}
}
