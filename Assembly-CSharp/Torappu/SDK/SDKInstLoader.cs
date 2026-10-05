using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Torappu.Config;
using UnityEngine;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020014F8 RID: 5368
	[Token(Token = "0x20014F8")]
	[DisallowMultipleComponent]
	public class SDKInstLoader : SingletonMonoBehaviour<SDKInstLoader>, ISingletonNotAutoCreate, IHotfixable
	{
		// Token: 0x06007B8E RID: 31630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B8E")]
		[Address(RVA = "0x2743B70", Offset = "0x2742770", VA = "0x182743B70")]
		public void InitSDKInstIfNeeded(RemoteConfig remoteConfig)
		{
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06007B8F RID: 31631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB4")]
		public ISDKBase sdkInst
		{
			[Token(Token = "0x6007B8F")]
			[Address(RVA = "0x2744B30", Offset = "0x2743730", VA = "0x182744B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x000371B8 File Offset: 0x000353B8
		[Token(Token = "0x6007B90")]
		[Address(RVA = "0x27443F0", Offset = "0x2742FF0", VA = "0x1827443F0")]
		public bool TryHookDeleteAllPlayerPrefs(Action deleteFunc, Action saveFunc)
		{
			return default(bool);
		}

		// Token: 0x06007B91 RID: 31633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B91")]
		[Address(RVA = "0x27440A0", Offset = "0x2742CA0", VA = "0x1827440A0")]
		public void ShowGlobalAgreement(Action onAgree)
		{
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B92")]
		[Address(RVA = "0x2744710", Offset = "0x2743310", VA = "0x182744710")]
		public void TryInjectSettings(InjectSettingOptions options)
		{
		}

		// Token: 0x06007B93 RID: 31635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B93")]
		[Address(RVA = "0x2744550", Offset = "0x2743150", VA = "0x182744550")]
		public void TryInjectCashShop(InjectShopOptions options)
		{
		}

		// Token: 0x06007B94 RID: 31636 RVA: 0x000371D0 File Offset: 0x000353D0
		[Token(Token = "0x6007B94")]
		[Address(RVA = "0x2744680", Offset = "0x2743280", VA = "0x182744680")]
		public bool TryInjectPopupAgreement()
		{
			return default(bool);
		}

		// Token: 0x06007B95 RID: 31637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B95")]
		[Address(RVA = "0x2744230", Offset = "0x2742E30", VA = "0x182744230")]
		[Conditional("TEST")]
		public void TestOnlyNotifyEnterGame()
		{
		}

		// Token: 0x06007B96 RID: 31638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B96")]
		[Address(RVA = "0x2744320", Offset = "0x2742F20", VA = "0x182744320")]
		public void TryFetchCashProductInfo(Action<List<SDKCashProduct>> onSuc, Action<string> onFail)
		{
		}

		// Token: 0x06007B97 RID: 31639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B97")]
		[Address(RVA = "0x2743EE0", Offset = "0x2742AE0", VA = "0x182743EE0")]
		public void QuerySkuDetailsCallBack(JObject msg)
		{
		}

		// Token: 0x06007B98 RID: 31640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B98")]
		[Address(RVA = "0x2744870", Offset = "0x2743470", VA = "0x182744870")]
		public void TryInjectSwitchAccount(InjectSwitchAccountOptions options)
		{
		}

		// Token: 0x06007B99 RID: 31641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B99")]
		[Address(RVA = "0x2743DD0", Offset = "0x27429D0", VA = "0x182743DD0")]
		public void NotifyU8LoginSucceed()
		{
		}

		// Token: 0x06007B9A RID: 31642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B9A")]
		[Address(RVA = "0x2744A10", Offset = "0x2743610", VA = "0x182744A10")]
		private void _BackToLogin()
		{
		}

		// Token: 0x06007B9B RID: 31643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B9B")]
		[Address(RVA = "0x2744AC0", Offset = "0x27436C0", VA = "0x182744AC0")]
		public SDKInstLoader()
		{
		}

		// Token: 0x040079F0 RID: 31216
		[Token(Token = "0x40079F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SDKHolder _sdkHolder;

		// Token: 0x040079F1 RID: 31217
		[Token(Token = "0x40079F1")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_sdkGameObj;

		// Token: 0x040079F2 RID: 31218
		[Token(Token = "0x40079F2")]
		[FieldOffset(Offset = "0x28")]
		private ISDKBase m_sdkInst;

		// Token: 0x040079F3 RID: 31219
		[Token(Token = "0x40079F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitSDKInstIfNeeded;

		// Token: 0x040079F4 RID: 31220
		[Token(Token = "0x40079F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sdkInst;

		// Token: 0x040079F5 RID: 31221
		[Token(Token = "0x40079F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryHookDeleteAllPlayerPrefs;

		// Token: 0x040079F6 RID: 31222
		[Token(Token = "0x40079F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowGlobalAgreement;

		// Token: 0x040079F7 RID: 31223
		[Token(Token = "0x40079F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryInjectSettings;

		// Token: 0x040079F8 RID: 31224
		[Token(Token = "0x40079F8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TryInjectCashShop;

		// Token: 0x040079F9 RID: 31225
		[Token(Token = "0x40079F9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryInjectPopupAgreement;

		// Token: 0x040079FA RID: 31226
		[Token(Token = "0x40079FA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TestOnlyNotifyEnterGame;

		// Token: 0x040079FB RID: 31227
		[Token(Token = "0x40079FB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryFetchCashProductInfo;

		// Token: 0x040079FC RID: 31228
		[Token(Token = "0x40079FC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_QuerySkuDetailsCallBack;

		// Token: 0x040079FD RID: 31229
		[Token(Token = "0x40079FD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryInjectSwitchAccount;

		// Token: 0x040079FE RID: 31230
		[Token(Token = "0x40079FE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_NotifyU8LoginSucceed;

		// Token: 0x040079FF RID: 31231
		[Token(Token = "0x40079FF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__BackToLogin;

		// Token: 0x04007A00 RID: 31232
		[Token(Token = "0x4007A00")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
