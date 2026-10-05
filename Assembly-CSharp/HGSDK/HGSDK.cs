using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using HGSDK.UI;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Torappu;
using Torappu.Network;
using Torappu.SDK;
using Torappu.UI;
using U8.SDK;
using UnityEngine;
using XLua;

namespace HGSDK
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public class HGSDK : SDKBase<HGSDK>, IMsgHolderInjecter, ISDKHookDeletePlayerPrefs
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x102E790", Offset = "0x102D390", VA = "0x18102E790", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x102FBE0", Offset = "0x102E7E0", VA = "0x18102FBE0", Slot = "15")]
		protected virtual void Start()
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1030AE0", Offset = "0x102F6E0", VA = "0x181030AE0", Slot = "16")]
		protected virtual void Update()
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		public string lastUsedUid
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1034020", Offset = "0x1032C20", VA = "0x181034020")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		protected string lastUsedAccountToken
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1033F00", Offset = "0x1032B00", VA = "0x181033F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x102E180", Offset = "0x102CD80", VA = "0x18102E180")]
		public static string GetLastUsedAccountToken()
		{
			return null;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		public string lastUsedGuestToken
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1033FB0", Offset = "0x1032BB0", VA = "0x181033FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x17000050")]
		public bool lastIdentityVerified
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1033E00", Offset = "0x1032A00", VA = "0x181033E00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x17000051")]
		public bool lastIsMinor
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x1033E80", Offset = "0x1032A80", VA = "0x181033E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		protected string deviceId
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x10339F0", Offset = "0x10325F0", VA = "0x1810339F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000053")]
		public string SDKUrl
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1033840", Offset = "0x1032440", VA = "0x181033840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		protected Camera sdkCamera
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1034120", Offset = "0x1032D20", VA = "0x181034120")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000055")]
		protected string appCode
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x10338E0", Offset = "0x10324E0", VA = "0x1810338E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000056")]
		public string cachedUsername
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1033940", Offset = "0x1032540", VA = "0x181033940")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x10342D0", Offset = "0x1032ED0", VA = "0x1810342D0")]
			protected set
			{
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x102DED0", Offset = "0x102CAD0", VA = "0x18102DED0")]
		public static string GetCachedUsername()
		{
			return null;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public string sdkUid
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x10341E0", Offset = "0x1032DE0", VA = "0x1810341E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public string sdkToken
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1034180", Offset = "0x1032D80", VA = "0x181034180")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x17000059")]
		public HGSDK.LoginResult loginResult
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x1034090", Offset = "0x1032C90", VA = "0x181034090")]
			get
			{
				return default(HGSDK.LoginResult);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x1700005A")]
		public bool isGuest
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x1033DA0", Offset = "0x10329A0", VA = "0x181033DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x1700005B")]
		public bool hasCachedUser
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x1033D30", Offset = "0x1032930", VA = "0x181033D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x1700005C")]
		public HGSDK.Urls urls
		{
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x1034240", Offset = "0x1032E40", VA = "0x181034240")]
			get
			{
				return default(HGSDK.Urls);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x102DA60", Offset = "0x102C660", VA = "0x18102DA60")]
		public bool CheckIfGuest()
		{
			return default(bool);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x102F490", Offset = "0x102E090", VA = "0x18102F490")]
		public void ProcessPaymentState_PayProcess(Action<HGSDK.PayResult> callback)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public override IExternalPlugin externalPlugin
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1033AF0", Offset = "0x10326F0", VA = "0x181033AF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x102F180", Offset = "0x102DD80", VA = "0x18102F180")]
		public void PreventGuestDelete(Action nextStep)
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x102DBC0", Offset = "0x102C7C0", VA = "0x18102DBC0")]
		public void ConfirmLoginInfo(HGSDK.LoginResult result, bool isGuest, bool isUpgradingDuringPay = false)
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x102FE50", Offset = "0x102EA50", VA = "0x18102FE50", Slot = "14")]
		public bool TryHookDeleteAllPlayerPrefs(Action deleteFunc, Action saveFunc)
		{
			return default(bool);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x10300F0", Offset = "0x102ECF0", VA = "0x1810300F0", Slot = "12")]
		public void TryInjectSettings(InjectSettingOptions options)
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x102FDF0", Offset = "0x102E9F0", VA = "0x18102FDF0", Slot = "10")]
		private bool isPopupAgreement()
		{
			return default(bool);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1030090", Offset = "0x102EC90", VA = "0x181030090", Slot = "11")]
		public void TryInjectCashShop(InjectShopOptions options)
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1030350", Offset = "0x102EF50", VA = "0x181030350", Slot = "13")]
		public void TryShowGlobalAgreement(Action onAgree, Action backLogin)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x102DAD0", Offset = "0x102C6D0", VA = "0x18102DAD0")]
		public void ClearLoginInfo()
		{
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x102F5A0", Offset = "0x102E1A0", VA = "0x18102F5A0")]
		public void SaveCaptchaTs(string key, long timeStamp)
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x102DF30", Offset = "0x102CB30", VA = "0x18102DF30")]
		public long GetCaptchaTs(string key)
		{
			return 0L;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x10303D0", Offset = "0x102EFD0", VA = "0x1810303D0")]
		public void TryToCallLoginoutWhenLogin()
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1030450", Offset = "0x102F050", VA = "0x181030450")]
		public void TryToCallLoginoutWhenLogout()
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x102E4D0", Offset = "0x102D0D0", VA = "0x18102E4D0")]
		public void Login(Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x102E6F0", Offset = "0x102D2F0", VA = "0x18102E6F0")]
		public void Logout(Action onSuc, Action onFail)
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x102EFF0", Offset = "0x102DBF0", VA = "0x18102EFF0")]
		public void Pay(Action<HGSDK.PayResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x102EBF0", Offset = "0x102D7F0", VA = "0x18102EBF0")]
		public void OpenChangePhoneSettingView()
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x102E9E0", Offset = "0x102D5E0", VA = "0x18102E9E0")]
		public void OpenChagePwdSettingView()
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x102E880", Offset = "0x102D480", VA = "0x18102E880")]
		public void OpenAgreementSettingView()
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x102ED80", Offset = "0x102D980", VA = "0x18102ED80")]
		public void OpenUnbindGrantView()
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x102C800", Offset = "0x102B400", VA = "0x18102C800")]
		public void CallLoginService(string username, string password, Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1031150", Offset = "0x102FD50", VA = "0x181031150")]
		private HGSDK.RequestWithMessageHandler<HGSDK.LoginResult> _CallLoginService(HGSDK.LoginParam param)
		{
			return null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x102B210", Offset = "0x1029E10", VA = "0x18102B210")]
		public void CallAuthService(string token, Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x102D270", Offset = "0x102BE70", VA = "0x18102D270")]
		public void CallSendSmsCodeWithType(string phoneNumber, HGSDK.SendSmsCodeType type, Action<UserSendSmsCodeResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1031D20", Offset = "0x1030920", VA = "0x181031D20")]
		private HGSDK.RequestWithMessageHandler<UserSendSmsCodeResponse> _CallSendSmsCode(HGSDK.SendSmsCodeParam param)
		{
			return null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x102CE40", Offset = "0x102BA40", VA = "0x18102CE40")]
		public void CallRegisterService(string account, string pwd, string smsCode, Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1031A40", Offset = "0x1030640", VA = "0x181031A40")]
		private HGSDK.RequestWithMessageHandler<HGSDK.LoginResult> _CallRegisterService(HGSDK.RegisterParam param)
		{
			return null;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x102D470", Offset = "0x102C070", VA = "0x18102D470")]
		public void CallSmsCodeLoginService(string phoneNum, string smsCode, Action<HGSDK.LoginResult> onSuc, Action onFail)
		{
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1031FB0", Offset = "0x1030BB0", VA = "0x181031FB0")]
		private HGSDK.RequestWithMessageHandler<HGSDK.LoginResult> _CallSmsCodeLoginService(HGSDK.SmsCodeLoginParam param)
		{
			return null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x102C110", Offset = "0x102AD10", VA = "0x18102C110")]
		public void CallGuestRegisterCaptcha(Action<UserGuestCaptchaResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x102BE90", Offset = "0x102AA90", VA = "0x18102BE90")]
		public HGSDK.GuestLoginHandler CallGuestLoginService(string captcha)
		{
			return null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x102CCB0", Offset = "0x102B8B0", VA = "0x18102CCB0")]
		public UISender.ResultHandler<PayCreateOrderAppstoreResponse> CallPayCreateOrderAppstore(string orderId)
		{
			return null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x102C670", Offset = "0x102B270", VA = "0x18102C670")]
		public UISender.ResultHandler<PayConfirmOrderAppstoreResponse> CallLegacyPayConfirmOrderAppstore(string orderId, string receiptData)
		{
			return null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x102CA80", Offset = "0x102B680", VA = "0x18102CA80")]
		public UISender.ResultHandler<PayConfirmOrderAppstoreNewResponse> CallPayConfirmOrderAppstore(string curOrderId, List<AppstoreOrder> infoList, string receiptData)
		{
			return null;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x102C470", Offset = "0x102B070", VA = "0x18102C470")]
		public void CallIdentityVerifyService(string realName, string cardNum, Action<UserIdentityAuthResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1030E60", Offset = "0x102FA60", VA = "0x181030E60")]
		private HGSDK.RequestWithMessageHandler<UserIdentityAuthResponse> _CallIdentityVerifyService(HGSDK.UserIdentityAuthParam param)
		{
			return null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x102BBF0", Offset = "0x102A7F0", VA = "0x18102BBF0")]
		public void CallCheckIdCardServie(string cardNum, Action<CheckIdCardResponse> onSuc, Action onFail)
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x102C3C0", Offset = "0x102AFC0", VA = "0x18102C3C0")]
		public void CallGuestUpgradeService(HGSDK.LoginResult accountResult, Action onSuc, Action onFail)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x102D920", Offset = "0x102C520", VA = "0x18102D920")]
		public void CallUpdateAgreementService(string token, Action onFinal)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x102B950", Offset = "0x102A550", VA = "0x18102B950")]
		public void CallChangePwdService(HGSDK.ChangePwdRequestParams changePwdParams, Action<ChangePwdResponse> onProceed)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x102B480", Offset = "0x102A080", VA = "0x18102B480")]
		public void CallChangePhoneCheckService(string token, Action<ChangePhoneCheckResponse> onProceed)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x102B6C0", Offset = "0x102A2C0", VA = "0x18102B6C0")]
		public void CallChangePhoneService(HGSDK.ChangePhoneRequestParams changePhoneParams, Action<ChangePhoneResponse> onProceed)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x102FCF0", Offset = "0x102E8F0", VA = "0x18102FCF0")]
		[Conditional("TEST")]
		public void TestOnlyNotifyEnterGame()
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x102B190", Offset = "0x1029D90", VA = "0x18102B190")]
		public static void Alert(string content, [Optional] Action onConfirm)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x102FD80", Offset = "0x102E980", VA = "0x18102FD80")]
		public static void Toast(string content)
		{
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x102F660", Offset = "0x102E260", VA = "0x18102F660")]
		public static void ShowReentrantLoading()
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x102E480", Offset = "0x102D080", VA = "0x18102E480")]
		public static void HideReentrantLoading()
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x102DE80", Offset = "0x102CA80", VA = "0x18102DE80")]
		public static void DoLogout()
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x10328C0", Offset = "0x10314C0", VA = "0x1810328C0")]
		private static string _GenRandomString()
		{
			return null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x102DFE0", Offset = "0x102CBE0", VA = "0x18102DFE0")]
		public HGSDK.GameRoleInfo GetGameRoleInfo()
		{
			return default(HGSDK.GameRoleInfo);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x102E1E0", Offset = "0x102CDE0", VA = "0x18102E1E0")]
		public string GetString(string key)
		{
			return null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000435")]
		private UISender.ResultHandler<RespType> _SendSDKRequest<RequestType, RespType>(string serviceCode, RequestType requestContent, bool needSign = true) where RespType : class
		{
			return null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x10333B0", Offset = "0x1031FB0", VA = "0x1810333B0")]
		private void _OnLoginSuc(HGSDK.LoginResult result, bool isGuest, Action<HGSDK.LoginResult> onSuc)
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1032AA0", Offset = "0x10316A0", VA = "0x181032AA0")]
		private void _OnAuthOrLoginFail(string alert, Action onFail)
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1033480", Offset = "0x1032080", VA = "0x181033480")]
		private void _OnRegisterFailed(string alert, Action onFail)
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1033260", Offset = "0x1031E60", VA = "0x181033260")]
		private void _OnGuestLoginFailed(long errorCode, Action onFail, string errorMsg)
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1033520", Offset = "0x1032120", VA = "0x181033520")]
		private void _ReloadPingMgrIfNeeded()
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1032940", Offset = "0x1031540", VA = "0x181032940")]
		private string _GetAvailableToken()
		{
			return null;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1031420", Offset = "0x1030020", VA = "0x181031420")]
		private void _CallLoginoutService(int type)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1032A10", Offset = "0x1031610", VA = "0x181032A10")]
		private IEnumerator _InitCloudAuthCoroutine()
		{
			return null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043E")]
		private void _SendSDKAPIV2Request<RequestType, RespDataType>(string serviceCode, RequestType requestContent, APIV2RequestCallback<RespDataType> callback) where RequestType : APIV2RequestBase where RespDataType : APIV2ResponseBase
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043F")]
		private void _APIV2RequestWithCaptchaImpl<RequestType, RespDataType>(string serviceCode, RequestType requestContent, APIV2RequestCallback<RespDataType> callback) where RequestType : APIV2RequestBase where RespDataType : APIV2ResponseBase
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1031740", Offset = "0x1030340", VA = "0x181031740")]
		private void _CallNeedCloudAuthService(HGSDK.CloudAuthContext context, Action<HGSDK.CloudAuthContext> cloudAuthNextStep)
		{
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1030B60", Offset = "0x102F760", VA = "0x181030B60")]
		private void _CallCloudAuthService(HGSDK.CloudAuthContext context, Action<HGSDK.CloudAuthContext> cloudAuthNextStep)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1032280", Offset = "0x1030E80", VA = "0x181032280")]
		private void _CallVerifyCloudAuthService(HGSDK.CloudAuthContext context)
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x102FA00", Offset = "0x102E600", VA = "0x18102FA00")]
		public void StartCloudAuth(HGSDK.LoginResult loginResult, Action onSuc, Action onFail)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1032740", Offset = "0x1031340", VA = "0x181032740")]
		private void _FetchCloudAuthInfo(HGSDK.CloudAuthContext context)
		{
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1032550", Offset = "0x1031150", VA = "0x181032550")]
		private void _DoCloudAuthWithSDK(HGSDK.CloudAuthContext context)
		{
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x102D0E0", Offset = "0x102BCE0", VA = "0x18102D0E0")]
		public void CallSendPhoneCodeWithTypeV2(string phoneNum, HGSDK.SendPhoneCodeTypeV2 type, APIV2RequestCallback<SendPhoneCodeResponse> callback)
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x102D6F0", Offset = "0x102C2F0", VA = "0x18102D6F0")]
		public void CallUnbindGrantService(string smsCode, string name, string idCard, APIV2RequestCallback<UnbindGrantResponse> callback)
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x102F6B0", Offset = "0x102E2B0", VA = "0x18102F6B0")]
		public void StartCheckGrantInfo(Action onProceed, Action onBlock)
		{
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1032C70", Offset = "0x1031870", VA = "0x181032C70")]
		private void _OnCheckGrantInfoFailed(APIV2FailResponse response, Action onProceed, Action onBlock)
		{
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1033770", Offset = "0x1032370", VA = "0x181033770")]
		public HGSDK()
		{
		}

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		public const string VERSION = "0.1.0";

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		public const int TYPE_LOGIN = 1;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		public const int TYPE_LOGOUT = 0;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HGSDK.SDKOptions _sdkOptions;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIManager.Options _options;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Pages")]
		private SDKLoginPage _loginPrefab;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Pages")]
		private SDKPayPage _payPrefab;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Pages")]
		private HGSDKPopupPage _popupPrefab;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HGSettingViewAccount _settingAccountPrefab;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextAsset _stringMap;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private HGSDK.Urls _urls;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private string m_token;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string m_uid;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HGSDK.LoginResult m_loginResult;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool m_isGuest;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		private bool m_hasLogin;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UIManager m_uiManager;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HGSDK.PingManager m_pingManager;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ListDict<string, long> m_captchaAllowNextTsMap;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private long m_Ts;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private U8Plugin m_u8Plugin;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Dictionary<string, string> m_stringMap;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_lastUsedUid;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_lastUsedAccountToken;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetLastUsedAccountToken;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_lastUsedGuestToken;

		// Token: 0x040004F1 RID: 1265
		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_lastIdentityVerified;

		// Token: 0x040004F2 RID: 1266
		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_lastIsMinor;

		// Token: 0x040004F3 RID: 1267
		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_deviceId;

		// Token: 0x040004F4 RID: 1268
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_SDKUrl;

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_sdkCamera;

		// Token: 0x040004F6 RID: 1270
		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_appCode;

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_cachedUsername;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_cachedUsername;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetCachedUsername;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_sdkUid;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_sdkToken;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_loginResult;

		// Token: 0x040004FD RID: 1277
		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_isGuest;

		// Token: 0x040004FE RID: 1278
		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_hasCachedUser;

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_urls;

		// Token: 0x04000500 RID: 1280
		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CheckIfGuest;

		// Token: 0x04000501 RID: 1281
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ProcessPaymentState_PayProcess;

		// Token: 0x04000502 RID: 1282
		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_externalPlugin;

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_PreventGuestDelete;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ConfirmLoginInfo;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_TryHookDeleteAllPlayerPrefs;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_TryInjectSettings;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge isPopupAgreement;

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_TryInjectCashShop;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_TryShowGlobalAgreement;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_ClearLoginInfo;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_SaveCaptchaTs;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetCaptchaTs;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_TryToCallLoginoutWhenLogin;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_TryToCallLoginoutWhenLogout;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_Login;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_Logout;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_Pay;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_OpenChangePhoneSettingView;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_OpenChagePwdSettingView;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_OpenAgreementSettingView;

		// Token: 0x04000515 RID: 1301
		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_OpenUnbindGrantView;

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_CallLoginService;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__CallLoginService;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_CallAuthService;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_CallSendSmsCodeWithType;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__CallSendSmsCode;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_CallRegisterService;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__CallRegisterService;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_CallSmsCodeLoginService;

		// Token: 0x0400051E RID: 1310
		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__CallSmsCodeLoginService;

		// Token: 0x0400051F RID: 1311
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_CallGuestRegisterCaptcha;

		// Token: 0x04000520 RID: 1312
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_CallGuestLoginService;

		// Token: 0x04000521 RID: 1313
		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_CallPayCreateOrderAppstore;

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_CallLegacyPayConfirmOrderAppstore;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_CallPayConfirmOrderAppstore;

		// Token: 0x04000524 RID: 1316
		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_CallIdentityVerifyService;

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__CallIdentityVerifyService;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_CallCheckIdCardServie;

		// Token: 0x04000527 RID: 1319
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_CallGuestUpgradeService;

		// Token: 0x04000528 RID: 1320
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_CallUpdateAgreementService;

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_CallChangePwdService;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_CallChangePhoneCheckService;

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_CallChangePhoneService;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_TestOnlyNotifyEnterGame;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_Alert;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_Toast;

		// Token: 0x0400052F RID: 1327
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_ShowReentrantLoading;

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_HideReentrantLoading;

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_DoLogout;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__GenRandomString;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_GetGameRoleInfo;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_GetString;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0__SendSDKRequest;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__OnLoginSuc;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__OnAuthOrLoginFail;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__OnRegisterFailed;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__OnGuestLoginFailed;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__ReloadPingMgrIfNeeded;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__GetAvailableToken;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__CallLoginoutService;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0__InitCloudAuthCoroutine;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__SendSDKAPIV2Request;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__APIV2RequestWithCaptchaImpl;

		// Token: 0x04000540 RID: 1344
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__CallNeedCloudAuthService;

		// Token: 0x04000541 RID: 1345
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__CallCloudAuthService;

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__CallVerifyCloudAuthService;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_StartCloudAuth;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0__FetchCloudAuthInfo;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__DoCloudAuthWithSDK;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_CallSendPhoneCodeWithTypeV2;

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_CallUnbindGrantService;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_StartCheckGrantInfo;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__OnCheckGrantInfoFailed;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020000FB RID: 251
		[Token(Token = "0x20000FB")]
		[RequireComponent(typeof(CanvasGroup))]
		public abstract class UIPage : MonoBehaviour, IHotfixable
		{
			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000450 RID: 1104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700005E")]
			private protected HGSDK sdk
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x103FC80", Offset = "0x103E880", VA = "0x18103FC80")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x6000450")]
				[Address(RVA = "0x103FEB0", Offset = "0x103EAB0", VA = "0x18103FEB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000452 RID: 1106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700005F")]
			private protected UIManager manager
			{
				[Token(Token = "0x6000451")]
				[Address(RVA = "0x103FB40", Offset = "0x103E740", VA = "0x18103FB40")]
				[CompilerGenerated]
				protected get
				{
					return null;
				}
				[Token(Token = "0x6000452")]
				[Address(RVA = "0x103FE30", Offset = "0x103EA30", VA = "0x18103FE30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000453 RID: 1107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000060")]
			protected Camera sdkCamera
			{
				[Token(Token = "0x6000453")]
				[Address(RVA = "0x103FBA0", Offset = "0x103E7A0", VA = "0x18103FBA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000061")]
			public string cachedUsername
			{
				[Token(Token = "0x6000454")]
				[Address(RVA = "0x103F810", Offset = "0x103E410", VA = "0x18103F810")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x103FCE0", Offset = "0x103E8E0", VA = "0x18103FCE0")]
				protected set
				{
				}
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x103F240", Offset = "0x103DE40", VA = "0x18103F240")]
			public string GetAvailableToken(out bool isGuest)
			{
				return null;
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000457 RID: 1111 RVA: 0x00002FA0 File Offset: 0x000011A0
			[Token(Token = "0x17000062")]
			protected virtual float fadeDuration
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x103FAE0", Offset = "0x103E6E0", VA = "0x18103FAE0", Slot = "4")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000063")]
			protected CanvasGroup canvasGroup
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x103F970", Offset = "0x103E570", VA = "0x18103F970")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x103F700", Offset = "0x103E300", VA = "0x18103F700")]
			public IEnumerator Open()
			{
				return null;
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x103F110", Offset = "0x103DD10", VA = "0x18103F110")]
			public IEnumerator Close()
			{
				return null;
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x103F570", Offset = "0x103E170", VA = "0x18103F570")]
			public void OnRegister(UIManager manager)
			{
			}

			// Token: 0x0600045C RID: 1116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x103EF90", Offset = "0x103DB90", VA = "0x18103EF90")]
			public void BlockRaycast(bool isBlock)
			{
			}

			// Token: 0x0600045D RID: 1117
			[Token(Token = "0x600045D")]
			protected abstract void OnInit();

			// Token: 0x0600045E RID: 1118
			[Token(Token = "0x600045E")]
			protected abstract void OnOpen();

			// Token: 0x0600045F RID: 1119
			[Token(Token = "0x600045F")]
			protected abstract void OnClose();

			// Token: 0x06000460 RID: 1120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x103F060", Offset = "0x103DC60", VA = "0x18103F060", Slot = "8")]
			protected virtual void CloseMe()
			{
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x103F4B0", Offset = "0x103E0B0", VA = "0x18103F4B0", Slot = "9")]
			protected virtual void OnDestroy()
			{
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x103F7B0", Offset = "0x103E3B0", VA = "0x18103F7B0")]
			protected UIPage()
			{
			}

			// Token: 0x0400054B RID: 1355
			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Tween m_tween;

			// Token: 0x0400054C RID: 1356
			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private CanvasGroup m_canvasGroup;

			// Token: 0x0400054F RID: 1359
			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_sdk;

			// Token: 0x04000550 RID: 1360
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_sdk;

			// Token: 0x04000551 RID: 1361
			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_manager;

			// Token: 0x04000552 RID: 1362
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_manager;

			// Token: 0x04000553 RID: 1363
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_sdkCamera;

			// Token: 0x04000554 RID: 1364
			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_get_cachedUsername;

			// Token: 0x04000555 RID: 1365
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_set_cachedUsername;

			// Token: 0x04000556 RID: 1366
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetAvailableToken;

			// Token: 0x04000557 RID: 1367
			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_fadeDuration;

			// Token: 0x04000558 RID: 1368
			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_get_canvasGroup;

			// Token: 0x04000559 RID: 1369
			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_Open;

			// Token: 0x0400055A RID: 1370
			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_Close;

			// Token: 0x0400055B RID: 1371
			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_OnRegister;

			// Token: 0x0400055C RID: 1372
			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_BlockRaycast;

			// Token: 0x0400055D RID: 1373
			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_CloseMe;

			// Token: 0x0400055E RID: 1374
			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_OnDestroy;

			// Token: 0x0400055F RID: 1375
			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020000FE RID: 254
		[Token(Token = "0x20000FE")]
		public struct LoginResult
		{
			// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x1034590", Offset = "0x1033190", VA = "0x181034590", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04000566 RID: 1382
			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string uid;

			// Token: 0x04000567 RID: 1383
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[JsonProperty(PropertyName = "access_token")]
			public string token;

			// Token: 0x04000568 RID: 1384
			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonIgnore]
			public bool isIdentityVerified;

			// Token: 0x04000569 RID: 1385
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[JsonIgnore]
			public bool isMinor;

			// Token: 0x0400056A RID: 1386
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			[JsonIgnore]
			public bool needAuthenticate;

			// Token: 0x0400056B RID: 1387
			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			[JsonIgnore]
			public bool isNeedUpdateAgreement;
		}

		// Token: 0x020000FF RID: 255
		[Token(Token = "0x20000FF")]
		public struct LoginProceedInfo
		{
			// Token: 0x0400056C RID: 1388
			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string captcha;

			// Token: 0x0400056D RID: 1389
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string captchaTips;
		}

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		public struct PayResult
		{
			// Token: 0x06000470 RID: 1136 RVA: 0x00002FE8 File Offset: 0x000011E8
			[Token(Token = "0x6000470")]
			[Address(RVA = "0xEAD120", Offset = "0xEABD20", VA = "0x180EAD120")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x1034770", Offset = "0x1033370", VA = "0x181034770", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x0400056E RID: 1390
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static HGSDK.PayResult EMPTY;

			// Token: 0x0400056F RID: 1391
			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public PayResultStatus status;

			// Token: 0x04000570 RID: 1392
			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string outTradeNo;
		}

		// Token: 0x02000101 RID: 257
		[Token(Token = "0x2000101")]
		public struct GameRoleInfo
		{
			// Token: 0x04000571 RID: 1393
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static HGSDK.GameRoleInfo EMPTY;

			// Token: 0x04000572 RID: 1394
			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000573 RID: 1395
			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string level;

			// Token: 0x04000574 RID: 1396
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DateTime createTime;

			// Token: 0x04000575 RID: 1397
			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string serverName;
		}

		// Token: 0x02000102 RID: 258
		[Token(Token = "0x2000102")]
		public struct LegacySDKRequestBundle<T> : IMsgBundle
		{
			// Token: 0x06000474 RID: 1140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000474")]
			public void Deserialize(string data, JsonSerializerSettings setting)
			{
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000475")]
			public string Serialize(JsonSerializerSettings setting)
			{
				return null;
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000476")]
			private static string _SignRequest(JObject jsonObj)
			{
				return null;
			}

			// Token: 0x04000576 RID: 1398
			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T data;

			// Token: 0x04000577 RID: 1399
			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool needSign;
		}

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		private class PingManager : IHotfixable
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000477 RID: 1143 RVA: 0x00003000 File Offset: 0x00001200
			[Token(Token = "0x17000068")]
			private int intervalSinceLastPingAsInt
			{
				[Token(Token = "0x6000477")]
				[Address(RVA = "0x1035CF0", Offset = "0x10348F0", VA = "0x181035CF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x1035BD0", Offset = "0x10347D0", VA = "0x181035BD0")]
			public PingManager(HGSDK sdk, HGSDK.PingManager.Options options)
			{
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x10349B0", Offset = "0x10335B0", VA = "0x1810349B0")]
			public void FirstPing(Action onSuc, Action onFail)
			{
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x1034DE0", Offset = "0x10339E0", VA = "0x181034DE0")]
			public void UpdatePing(float deltaTime)
			{
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x1035550", Offset = "0x1034150", VA = "0x181035550")]
			private void _DoPeriodicPing(int interval)
			{
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x10350E0", Offset = "0x1033CE0", VA = "0x1810350E0")]
			private HGSDK.PingManager.PingServiceHandler _CallPingService(int interval)
			{
				return null;
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x00003018 File Offset: 0x00001218
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1035440", Offset = "0x1034040", VA = "0x181035440")]
			private bool _CheckPingable()
			{
				return default(bool);
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x10358F0", Offset = "0x10344F0", VA = "0x1810358F0")]
			private void _SetNoPeriodicPing()
			{
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1035830", Offset = "0x1034430", VA = "0x181035830")]
			private void _SetNextPeriodicPing(int interval)
			{
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x10356A0", Offset = "0x10342A0", VA = "0x1810356A0")]
			private static void _HandleToastEvent(PingResponse response)
			{
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x1035970", Offset = "0x1034570", VA = "0x181035970")]
			private static IEnumerator _ShowToastCoroutine(string content)
			{
				return null;
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x1034D40", Offset = "0x1033940", VA = "0x181034D40")]
			private void _DoQuit()
			{
			}

			// Token: 0x04000578 RID: 1400
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly string[] PINGABLE_SCENES;

			// Token: 0x04000579 RID: 1401
			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private HGSDK m_sdk;

			// Token: 0x0400057A RID: 1402
			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private HGSDK.PingManager.Options m_options;

			// Token: 0x0400057B RID: 1403
			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_nextPingInterval;

			// Token: 0x0400057C RID: 1404
			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float m_accumTimeSinceLastPing;

			// Token: 0x0400057D RID: 1405
			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int? m_cachedLatestInterval;

			// Token: 0x0400057E RID: 1406
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_intervalSinceLastPingAsInt;

			// Token: 0x0400057F RID: 1407
			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04000580 RID: 1408
			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_FirstPing;

			// Token: 0x04000581 RID: 1409
			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdatePing;

			// Token: 0x04000582 RID: 1410
			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__DoPeriodicPing;

			// Token: 0x04000583 RID: 1411
			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__CallPingService;

			// Token: 0x04000584 RID: 1412
			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__CheckPingable;

			// Token: 0x04000585 RID: 1413
			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__SetNoPeriodicPing;

			// Token: 0x04000586 RID: 1414
			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__SetNextPeriodicPing;

			// Token: 0x04000587 RID: 1415
			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__HandleToastEvent;

			// Token: 0x04000588 RID: 1416
			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__ShowToastCoroutine;

			// Token: 0x04000589 RID: 1417
			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__DoQuit;

			// Token: 0x02000104 RID: 260
			[Token(Token = "0x2000104")]
			public struct Options
			{
				// Token: 0x0400058A RID: 1418
				[Token(Token = "0x400058A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int defaultIntervalIfFailed;

				// Token: 0x0400058B RID: 1419
				[Token(Token = "0x400058B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public bool pingInBattleScene;
			}

			// Token: 0x02000105 RID: 261
			[Token(Token = "0x2000105")]
			public class PingServiceHandler
			{
				// Token: 0x06000487 RID: 1159 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PingServiceHandler()
				{
				}

				// Token: 0x0400058C RID: 1420
				[Token(Token = "0x400058C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public Action<PingResponse> onProceed;

				// Token: 0x0400058D RID: 1421
				[Token(Token = "0x400058D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Action<ResponseError> onBlock;
			}
		}

		// Token: 0x02000109 RID: 265
		[Token(Token = "0x2000109")]
		[Serializable]
		public struct Urls
		{
			// Token: 0x04000596 RID: 1430
			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string registerLicenseUrl;

			// Token: 0x04000597 RID: 1431
			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string privacyLicenseUrl;

			// Token: 0x04000598 RID: 1432
			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string forgotPasswdUrl;

			// Token: 0x04000599 RID: 1433
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string unbindGrantLicenseUrl;
		}

		// Token: 0x0200010A RID: 266
		[Token(Token = "0x200010A")]
		[Serializable]
		public struct SDKOptions
		{
			// Token: 0x0400059A RID: 1434
			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string appID;

			// Token: 0x0400059B RID: 1435
			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string appKey;

			// Token: 0x0400059C RID: 1436
			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string channelID;

			// Token: 0x0400059D RID: 1437
			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string worldId;

			// Token: 0x0400059E RID: 1438
			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string appCode;
		}

		// Token: 0x0200010B RID: 267
		[Token(Token = "0x200010B")]
		public class GuestLoginHandler
		{
			// Token: 0x06000493 RID: 1171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GuestLoginHandler()
			{
			}

			// Token: 0x0400059F RID: 1439
			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<HGSDK.LoginResult, string> onSuc;

			// Token: 0x040005A0 RID: 1440
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onFail;

			// Token: 0x040005A1 RID: 1441
			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<HGSDK.LoginProceedInfo> onProceed;
		}

		// Token: 0x0200010C RID: 268
		[Token(Token = "0x200010C")]
		public struct ChangePwdRequestParams
		{
			// Token: 0x040005A2 RID: 1442
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string token;

			// Token: 0x040005A3 RID: 1443
			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string newPwd;

			// Token: 0x040005A4 RID: 1444
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string phoneCode;
		}

		// Token: 0x0200010D RID: 269
		[Token(Token = "0x200010D")]
		public struct ChangePhoneRequestParams
		{
			// Token: 0x040005A5 RID: 1445
			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string token;

			// Token: 0x040005A6 RID: 1446
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string phoneCode;

			// Token: 0x040005A7 RID: 1447
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string newPhone;

			// Token: 0x040005A8 RID: 1448
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string newPhoneCode;
		}

		// Token: 0x0200010E RID: 270
		[Token(Token = "0x200010E")]
		public enum SendSmsCodeType
		{
			// Token: 0x040005AA RID: 1450
			[Token(Token = "0x40005AA")]
			REGISTER,
			// Token: 0x040005AB RID: 1451
			[Token(Token = "0x40005AB")]
			LOGIN,
			// Token: 0x040005AC RID: 1452
			[Token(Token = "0x40005AC")]
			CHANGE_NEW_PHONE = 101,
			// Token: 0x040005AD RID: 1453
			[Token(Token = "0x40005AD")]
			CHAGNE_PWD,
			// Token: 0x040005AE RID: 1454
			[Token(Token = "0x40005AE")]
			CHANGE_ORI_PHONE
		}

		// Token: 0x0200010F RID: 271
		[Token(Token = "0x200010F")]
		public enum SendPhoneCodeTypeV2
		{
			// Token: 0x040005B0 RID: 1456
			[Token(Token = "0x40005B0")]
			NONE,
			// Token: 0x040005B1 RID: 1457
			[Token(Token = "0x40005B1")]
			UNBIND_GRANT = 4
		}

		// Token: 0x02000110 RID: 272
		[Token(Token = "0x2000110")]
		public class HandleCaptchaRequestV1<MessageRequest, RequestResponce> : IHotfixable where MessageRequest : HGSDK.RequestWithCaptchaParamV1
		{
			// Token: 0x06000494 RID: 1172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000494")]
			public void Request(MessageRequest param)
			{
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000495")]
			private void _CallRequest(MessageRequest param)
			{
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000496")]
			private void _HandleMessage(HGSDK.LoginProceedInfo info)
			{
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000497")]
			private void _OnGT3Message(SDKExtraInfoHandler.GT3Message msg)
			{
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000498")]
			public HandleCaptchaRequestV1()
			{
			}

			// Token: 0x040005B2 RID: 1458
			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private MessageRequest m_requestParam;

			// Token: 0x040005B3 RID: 1459
			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<MessageRequest, HGSDK.RequestWithMessageHandler<RequestResponce>> requestFuc;

			// Token: 0x040005B4 RID: 1460
			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<RequestResponce> onSuc;

			// Token: 0x040005B5 RID: 1461
			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action onFail;

			// Token: 0x040005B6 RID: 1462
			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action onMessageFail;

			// Token: 0x040005B7 RID: 1463
			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Request;

			// Token: 0x040005B8 RID: 1464
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__CallRequest;

			// Token: 0x040005B9 RID: 1465
			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__HandleMessage;

			// Token: 0x040005BA RID: 1466
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__OnGT3Message;

			// Token: 0x040005BB RID: 1467
			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02000112 RID: 274
		[Token(Token = "0x2000112")]
		public abstract class RequestWithCaptchaParamV1
		{
			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600049B RID: 1179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700006B")]
			public string message
			{
				[Token(Token = "0x600049C")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600049B")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x1034460", Offset = "0x1033060", VA = "0x181034460")]
			protected RequestWithCaptchaParamV1()
			{
			}

			// Token: 0x040005BE RID: 1470
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private string m_message;
		}

		// Token: 0x02000113 RID: 275
		[Token(Token = "0x2000113")]
		public class RequestWithMessageHandler<RequestResponce>
		{
			// Token: 0x0600049E RID: 1182 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600049E")]
			public RequestWithMessageHandler()
			{
			}

			// Token: 0x040005BF RID: 1471
			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<HGSDK.LoginProceedInfo> onNeedGT3Message;

			// Token: 0x040005C0 RID: 1472
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<RequestResponce> onSuc;

			// Token: 0x040005C1 RID: 1473
			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action onFail;
		}

		// Token: 0x02000114 RID: 276
		[Token(Token = "0x2000114")]
		public class LoginParam : HGSDK.RequestWithCaptchaParamV1
		{
			// Token: 0x0600049F RID: 1183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x1034460", Offset = "0x1033060", VA = "0x181034460")]
			public LoginParam()
			{
			}

			// Token: 0x040005C2 RID: 1474
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string accout;

			// Token: 0x040005C3 RID: 1475
			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string password;
		}

		// Token: 0x02000115 RID: 277
		[Token(Token = "0x2000115")]
		public class SendSmsCodeParam : HGSDK.RequestWithCaptchaParamV1
		{
			// Token: 0x060004A0 RID: 1184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0x1034460", Offset = "0x1033060", VA = "0x181034460")]
			public SendSmsCodeParam()
			{
			}

			// Token: 0x040005C4 RID: 1476
			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string phoneNumber;

			// Token: 0x040005C5 RID: 1477
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int act;
		}

		// Token: 0x02000116 RID: 278
		[Token(Token = "0x2000116")]
		public class RegisterParam : HGSDK.RequestWithCaptchaParamV1
		{
			// Token: 0x060004A1 RID: 1185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x1034460", Offset = "0x1033060", VA = "0x181034460")]
			public RegisterParam()
			{
			}

			// Token: 0x040005C6 RID: 1478
			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string account;

			// Token: 0x040005C7 RID: 1479
			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string password;

			// Token: 0x040005C8 RID: 1480
			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string smsCode;
		}

		// Token: 0x02000117 RID: 279
		[Token(Token = "0x2000117")]
		public class SmsCodeLoginParam : HGSDK.RequestWithCaptchaParamV1
		{
			// Token: 0x060004A2 RID: 1186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x1034460", Offset = "0x1033060", VA = "0x181034460")]
			public SmsCodeLoginParam()
			{
			}

			// Token: 0x040005C9 RID: 1481
			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string account;

			// Token: 0x040005CA RID: 1482
			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string smsCode;
		}

		// Token: 0x02000118 RID: 280
		[Token(Token = "0x2000118")]
		public class UserIdentityAuthParam : HGSDK.RequestWithCaptchaParamV1
		{
			// Token: 0x060004A3 RID: 1187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1034460", Offset = "0x1033060", VA = "0x181034460")]
			public UserIdentityAuthParam()
			{
			}

			// Token: 0x040005CB RID: 1483
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x040005CC RID: 1484
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string cardNum;
		}

		// Token: 0x02000119 RID: 281
		[Token(Token = "0x2000119")]
		private struct CloudAuthContext
		{
			// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x5134F0", Offset = "0x5120F0", VA = "0x1805134F0")]
			public void InvokeFailCallback()
			{
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x5134D0", Offset = "0x5120D0", VA = "0x1805134D0")]
			public void InvokeSucCallback()
			{
			}

			// Token: 0x040005CD RID: 1485
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HGSDK.LoginResult loginResult;

			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onSuc;

			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action onFail;

			// Token: 0x040005D0 RID: 1488
			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string sdkToken;

			// Token: 0x040005D1 RID: 1489
			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bizId;
		}
	}
}
