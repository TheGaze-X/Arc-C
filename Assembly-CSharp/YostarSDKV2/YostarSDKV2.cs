using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu;
using Torappu.SDK;
using U8.SDK;
using UnityEngine;
using XLua;

namespace YostarSDKV2
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	public class YostarSDKV2 : SDKBase<YostarSDKV2>, IMsgHolderInjecter, ISDKHookDeletePlayerPrefs
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		private YostarSDKV2Plugin sdkPlugin
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x522D20", Offset = "0x521920", VA = "0x180522D20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public override IExternalPlugin externalPlugin
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x522CC0", Offset = "0x5218C0", VA = "0x180522CC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x521B30", Offset = "0x520730", VA = "0x180521B30")]
		public YostarSDKV2.SDKOptions GetSDKOptions()
		{
			return default(YostarSDKV2.SDKOptions);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x521BE0", Offset = "0x5207E0", VA = "0x180521BE0")]
		public YostarV2LoginTempDialog GetTempLoginDialog()
		{
			return null;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x521A70", Offset = "0x520670", VA = "0x180521A70")]
		public YostarV2LoginJPDialog GetJPLoginDialog()
		{
			return null;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x521AD0", Offset = "0x5206D0", VA = "0x180521AD0")]
		public YostarV2LoginMockDialog GetMockLoginDialog()
		{
			return null;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x521A10", Offset = "0x520610", VA = "0x180521A10")]
		public YostarV2DiamondDetailDialog GetDiamondDetailDialog()
		{
			return null;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x521D80", Offset = "0x520980", VA = "0x180521D80", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x521EF0", Offset = "0x520AF0", VA = "0x180521EF0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x522E60", Offset = "0x521A60", VA = "0x180522E60", Slot = "10")]
		public bool isPopupAgreement()
		{
			return default(bool);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x5225B0", Offset = "0x5211B0", VA = "0x1805225B0", Slot = "11")]
		public void TryInjectCashShop(InjectShopOptions options)
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x5227D0", Offset = "0x5213D0", VA = "0x1805227D0", Slot = "12")]
		public void TryInjectSettings(InjectSettingOptions options)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x522B10", Offset = "0x521710", VA = "0x180522B10", Slot = "13")]
		public void TryShowGlobalAgreement(Action onAgree, Action backLogin)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x521CC0", Offset = "0x5208C0", VA = "0x180521CC0")]
		public bool IsNativePlugin()
		{
			return default(bool);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x5218E0", Offset = "0x5204E0", VA = "0x1805218E0")]
		public bool CheckIfInitAndUpdate()
		{
			return default(bool);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x521C40", Offset = "0x520840", VA = "0x180521C40")]
		public bool IsInitControllerReady()
		{
			return default(bool);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x521FC0", Offset = "0x520BC0", VA = "0x180521FC0")]
		public void OpenAgreements(List<string> agreements)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x521840", Offset = "0x520440", VA = "0x180521840")]
		public bool CheckIfHasCachedUser()
		{
			return default(bool);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x522300", Offset = "0x520F00", VA = "0x180522300")]
		public void OpenUserCenter()
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5223A0", Offset = "0x520FA0", VA = "0x1805223A0")]
		public void SwitchAccount()
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x522260", Offset = "0x520E60", VA = "0x180522260")]
		public void OpenFeedback()
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x522070", Offset = "0x520C70", VA = "0x180522070")]
		public void OpenDiamondDetail()
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x522440", Offset = "0x521040", VA = "0x180522440", Slot = "14")]
		public bool TryHookDeleteAllPlayerPrefs(Action deleteFunc, Action saveFunc)
		{
			return default(bool);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x522BC0", Offset = "0x5217C0", VA = "0x180522BC0")]
		public YostarSDKV2()
		{
		}

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private YostarV2LoginMockDialog _mockLoginDialog;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private YostarV2LoginTempDialog _tempLoginDialog;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private YostarV2LoginJPDialog _jpLoginDialog;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private YostarV2DiamondDetailDialog _diamondDetailDialog;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private YostarSDKV2.SDKOptions _sdkOptions;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private YostarV2SettingViewAccount _settingAccount;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private YostarV2SettingViewOthers _settingOthers;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private YostarV2PayCashShopPlugin _cashShopPlugin;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0xA0")]
		private YostarSDKV2Plugin m_plugin;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0xA8")]
		private YostarSDKV2.InitRequestController m_initCtrl;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sdkPlugin;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_externalPlugin;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSDKOptions;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTempLoginDialog;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetJPLoginDialog;

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetMockLoginDialog;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDiamondDetailDialog;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400028C RID: 652
		[Token(Token = "0x400028C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400028D RID: 653
		[Token(Token = "0x400028D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_isPopupAgreement;

		// Token: 0x0400028E RID: 654
		[Token(Token = "0x400028E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_TryInjectCashShop;

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x400028F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryInjectSettings;

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryShowGlobalAgreement;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_IsNativePlugin;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckIfInitAndUpdate;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_IsInitControllerReady;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OpenAgreements;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckIfHasCachedUser;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OpenUserCenter;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SwitchAccount;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OpenFeedback;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OpenDiamondDetail;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TryHookDeleteAllPlayerPrefs;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000087 RID: 135
		[Token(Token = "0x2000087")]
		[Serializable]
		public struct SDKOptions
		{
			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			[FieldOffset(Offset = "0x0")]
			public string appID;

			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			[FieldOffset(Offset = "0x8")]
			public string appKey;

			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			[FieldOffset(Offset = "0x10")]
			public string channelID;

			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			[FieldOffset(Offset = "0x18")]
			public string worldId;

			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			[FieldOffset(Offset = "0x20")]
			public string enYostarAccountCenterURL;

			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x28")]
			public string krYostarAccountCenterURL;

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x30")]
			public string jpYostarAccountMigrateURL;

			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			[FieldOffset(Offset = "0x38")]
			public string krYostarAccountMigrateURL_Android;

			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0x40")]
			public string krYostarAccountMigrateURL_IOS;

			// Token: 0x040002A5 RID: 677
			[Token(Token = "0x40002A5")]
			[FieldOffset(Offset = "0x48")]
			public string krYostarAccountMigrateURL_PC;
		}

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x2000088")]
		public struct AccountInfo
		{
			// Token: 0x040002A6 RID: 678
			[Token(Token = "0x40002A6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly YostarSDKV2.AccountInfo EMPTY;

			// Token: 0x040002A7 RID: 679
			[Token(Token = "0x40002A7")]
			[FieldOffset(Offset = "0x0")]
			public YostarSDKV2.LoginUserType platform;

			// Token: 0x040002A8 RID: 680
			[Token(Token = "0x40002A8")]
			[FieldOffset(Offset = "0x8")]
			public string uid;

			// Token: 0x040002A9 RID: 681
			[Token(Token = "0x40002A9")]
			[FieldOffset(Offset = "0x10")]
			public string uid_2;

			// Token: 0x040002AA RID: 682
			[Token(Token = "0x40002AA")]
			[FieldOffset(Offset = "0x18")]
			public string sdk_pid;

			// Token: 0x040002AB RID: 683
			[Token(Token = "0x40002AB")]
			[FieldOffset(Offset = "0x20")]
			public string name;
		}

		// Token: 0x02000089 RID: 137
		[Token(Token = "0x2000089")]
		public enum LoginUserType
		{
			// Token: 0x040002AD RID: 685
			[Token(Token = "0x40002AD")]
			NONE = -1,
			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			QUEST,
			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			MIGRATE,
			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			TWITTER,
			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			FACEBOOK,
			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			EMAIL,
			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			GOOGLE,
			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x40002B4")]
			APPLE,
			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x40002B5")]
			YOSTAR,
			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			AMAZON
		}

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		public struct YostarAgreementName
		{
			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			public const string USER_AGREEMENT = "user_agreement";

			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			public const string PRIVACY_AGREEMENT = "privacy_agreement";

			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			public const string FUND_SETTLEMENT_ALGORITHM = "fund_settlement_algorithm";

			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			public const string SPECIFIC_COMMERCIAL_TRANSACTION_ACT = "specific_commercial_transaction_act";

			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			public const string CREDIT_INVESTIGATION = "credit_investigation";

			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			public const string REFUND_AGREEMENT = "refund_agreement";

			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			public const string MINORS_SHOP_AGREEMENT = "minors_shop_agreement";

			// Token: 0x040002BE RID: 702
			[Token(Token = "0x40002BE")]
			public const string PERSONAL_INFORMATION_HANDLING_POLICY = "personal_information_handling_policy";

			// Token: 0x040002BF RID: 703
			[Token(Token = "0x40002BF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HashSet<string> YOSTAR_AGREEMENT_SET;
		}

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200008B")]
		private enum InitState
		{
			// Token: 0x040002C1 RID: 705
			[Token(Token = "0x40002C1")]
			NONE,
			// Token: 0x040002C2 RID: 706
			[Token(Token = "0x40002C2")]
			INITING,
			// Token: 0x040002C3 RID: 707
			[Token(Token = "0x40002C3")]
			SUC,
			// Token: 0x040002C4 RID: 708
			[Token(Token = "0x40002C4")]
			FAILED
		}

		// Token: 0x0200008C RID: 140
		[Token(Token = "0x200008C")]
		private class InitRequestController : IHotfixable, IDisposable
		{
			// Token: 0x1700002F RID: 47
			// (get) Token: 0x0600023A RID: 570 RVA: 0x00002988 File Offset: 0x00000B88
			// (set) Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700002F")]
			public YostarSDKV2.InitState state
			{
				[Token(Token = "0x600023A")]
				[Address(RVA = "0x5130B0", Offset = "0x511CB0", VA = "0x1805130B0")]
				[CompilerGenerated]
				get
				{
					return YostarSDKV2.InitState.NONE;
				}
				[Token(Token = "0x600023B")]
				[Address(RVA = "0x513160", Offset = "0x511D60", VA = "0x180513160")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x512D50", Offset = "0x511950", VA = "0x180512D50")]
			public void InvokeInit()
			{
			}

			// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x512FC0", Offset = "0x511BC0", VA = "0x180512FC0")]
			private void _OnSDKInit(SDKExtraInfoHandler.SDKInitMessage message)
			{
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x512C60", Offset = "0x511860", VA = "0x180512C60", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0600023F RID: 575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x512F50", Offset = "0x511B50", VA = "0x180512F50")]
			public void ReInit()
			{
			}

			// Token: 0x06000240 RID: 576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x513050", Offset = "0x511C50", VA = "0x180513050")]
			public InitRequestController()
			{
			}

			// Token: 0x040002C5 RID: 709
			[Token(Token = "0x40002C5")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isCallbackBinded;

			// Token: 0x040002C7 RID: 711
			[Token(Token = "0x40002C7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_state;

			// Token: 0x040002C8 RID: 712
			[Token(Token = "0x40002C8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_state;

			// Token: 0x040002C9 RID: 713
			[Token(Token = "0x40002C9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_InvokeInit;

			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__OnSDKInit;

			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x040002CC RID: 716
			[Token(Token = "0x40002CC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ReInit;

			// Token: 0x040002CD RID: 717
			[Token(Token = "0x40002CD")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
