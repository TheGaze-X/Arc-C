using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu;
using Torappu.SDK;
using U8.SDK;
using UnityEngine;
using XLua;

namespace HGSDK.V2
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	public class HGSDKV2 : SDKBase<HGSDKV2>, IMsgHolderInjecter
	{
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CE")]
		public string lastUsedUserName
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x102B050", Offset = "0x1029C50", VA = "0x18102B050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x102B110", Offset = "0x1029D10", VA = "0x18102B110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x102A170", Offset = "0x1028D70", VA = "0x18102A170")]
		public HGSDKV2.SDKOptions GetSDKOptions()
		{
			return default(HGSDKV2.SDKOptions);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1029F60", Offset = "0x1028B60", VA = "0x181029F60")]
		public HGSDKV2MockLoginDialog GetMockLoginDialog()
		{
			return null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1029F00", Offset = "0x1028B00", VA = "0x181029F00")]
		public HGSDKV2LoginDialog GetLoginDialog()
		{
			return null;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x102A420", Offset = "0x1029020", VA = "0x18102A420", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1029CC0", Offset = "0x10288C0", VA = "0x181029CC0")]
		public bool CheckIfInitedAndUpdate()
		{
			return default(bool);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x102A390", Offset = "0x1028F90", VA = "0x18102A390", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x102A200", Offset = "0x1028E00", VA = "0x18102A200")]
		public bool IsHGChannel()
		{
			return default(bool);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CF")]
		public override IExternalPlugin externalPlugin
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x102AF30", Offset = "0x1029B30", VA = "0x18102AF30", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1029D70", Offset = "0x1028970", VA = "0x181029D70")]
		public HGSDKV2.GameRoleInfo GetGameRoleInfo()
		{
			return default(HGSDKV2.GameRoleInfo);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x102A5A0", Offset = "0x10291A0", VA = "0x18102A5A0")]
		public void OpenAgreementSettingView()
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x102A4C0", Offset = "0x10290C0", VA = "0x18102A4C0")]
		public void OpenAccountCenter()
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x102A7A0", Offset = "0x10293A0", VA = "0x18102A7A0")]
		public static void TryMigrateHGSDKAccount()
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x102A2C0", Offset = "0x1028EC0", VA = "0x18102A2C0")]
		public void NotifyU8LoginSucceed()
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1029FC0", Offset = "0x1028BC0", VA = "0x181029FC0")]
		public static string GetRecentLoginUserFromSDK()
		{
			return null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x102B0B0", Offset = "0x1029CB0", VA = "0x18102B0B0", Slot = "10")]
		public bool isPopupAgreement()
		{
			return default(bool);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x102A680", Offset = "0x1029280", VA = "0x18102A680", Slot = "11")]
		public void TryInjectCashShop(InjectShopOptions options)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x102A6E0", Offset = "0x10292E0", VA = "0x18102A6E0", Slot = "12")]
		public void TryInjectSettings(InjectSettingOptions options)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x102A940", Offset = "0x1029540", VA = "0x18102A940", Slot = "13")]
		public void TryShowGlobalAgreement(Action onAgree, Action backLogin)
		{
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x102A9C0", Offset = "0x10295C0", VA = "0x18102A9C0")]
		private void _InjectSettingsHGChannel(InjectSettingOptions options)
		{
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x102AC10", Offset = "0x1029810", VA = "0x18102AC10")]
		private void _InjectSettingsOtherChannel(InjectSettingOptions options)
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x102AE70", Offset = "0x1029A70", VA = "0x18102AE70")]
		public HGSDKV2()
		{
		}

		// Token: 0x0400075B RID: 1883
		[Token(Token = "0x400075B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HGSDKV2.SDKOptions _sdkOptions;

		// Token: 0x0400075C RID: 1884
		[Token(Token = "0x400075C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private HGSDKV2MockLoginDialog _mockLoginDialog;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private HGSDKV2LoginDialog _loginDialog;

		// Token: 0x0400075E RID: 1886
		[Token(Token = "0x400075E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HGV2SettingViewAccount _settingAccountPrefab;

		// Token: 0x0400075F RID: 1887
		[Token(Token = "0x400075F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private HGSDKV2GameLicenseDialog _licenseDialog;

		// Token: 0x04000760 RID: 1888
		[Token(Token = "0x4000760")]
		[FieldOffset(Offset = "0x60")]
		private HGSDKPluginV2 m_plugin;

		// Token: 0x04000761 RID: 1889
		[Token(Token = "0x4000761")]
		[FieldOffset(Offset = "0x68")]
		private HGSDKV2.InitRequestController m_initCtrl;

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lastUsedUserName;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_lastUsedUserName;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSDKOptions;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetMockLoginDialog;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetLoginDialog;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIfInitedAndUpdate;

		// Token: 0x0400076A RID: 1898
		[Token(Token = "0x400076A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400076B RID: 1899
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsHGChannel;

		// Token: 0x0400076C RID: 1900
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_externalPlugin;

		// Token: 0x0400076D RID: 1901
		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetGameRoleInfo;

		// Token: 0x0400076E RID: 1902
		[Token(Token = "0x400076E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OpenAgreementSettingView;

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OpenAccountCenter;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryMigrateHGSDKAccount;

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_NotifyU8LoginSucceed;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetRecentLoginUserFromSDK;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_isPopupAgreement;

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TryInjectCashShop;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_TryInjectSettings;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_TryShowGlobalAgreement;

		// Token: 0x04000777 RID: 1911
		[Token(Token = "0x4000777")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__InjectSettingsHGChannel;

		// Token: 0x04000778 RID: 1912
		[Token(Token = "0x4000778")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__InjectSettingsOtherChannel;

		// Token: 0x04000779 RID: 1913
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02000174 RID: 372
		[Token(Token = "0x2000174")]
		[Serializable]
		public struct SDKOptions
		{
			// Token: 0x0400077A RID: 1914
			[Token(Token = "0x400077A")]
			[FieldOffset(Offset = "0x0")]
			public string appID;

			// Token: 0x0400077B RID: 1915
			[Token(Token = "0x400077B")]
			[FieldOffset(Offset = "0x8")]
			public string appKey;

			// Token: 0x0400077C RID: 1916
			[Token(Token = "0x400077C")]
			[FieldOffset(Offset = "0x10")]
			public string channelID;

			// Token: 0x0400077D RID: 1917
			[Token(Token = "0x400077D")]
			[FieldOffset(Offset = "0x18")]
			public string worldId;

			// Token: 0x0400077E RID: 1918
			[Token(Token = "0x400077E")]
			[FieldOffset(Offset = "0x20")]
			public string appCode;
		}

		// Token: 0x02000175 RID: 373
		[Token(Token = "0x2000175")]
		public struct GameRoleInfo
		{
			// Token: 0x0400077F RID: 1919
			[Token(Token = "0x400077F")]
			[FieldOffset(Offset = "0x0")]
			public static HGSDKV2.GameRoleInfo EMPTY;

			// Token: 0x04000780 RID: 1920
			[Token(Token = "0x4000780")]
			[FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000781 RID: 1921
			[Token(Token = "0x4000781")]
			[FieldOffset(Offset = "0x8")]
			public string level;

			// Token: 0x04000782 RID: 1922
			[Token(Token = "0x4000782")]
			[FieldOffset(Offset = "0x10")]
			public DateTime createTime;

			// Token: 0x04000783 RID: 1923
			[Token(Token = "0x4000783")]
			[FieldOffset(Offset = "0x18")]
			public string serverName;
		}

		// Token: 0x02000176 RID: 374
		[Token(Token = "0x2000176")]
		private enum InitState
		{
			// Token: 0x04000785 RID: 1925
			[Token(Token = "0x4000785")]
			NONE,
			// Token: 0x04000786 RID: 1926
			[Token(Token = "0x4000786")]
			INITING,
			// Token: 0x04000787 RID: 1927
			[Token(Token = "0x4000787")]
			SUC,
			// Token: 0x04000788 RID: 1928
			[Token(Token = "0x4000788")]
			FAILED
		}

		// Token: 0x02000177 RID: 375
		[Token(Token = "0x2000177")]
		private class InitRequestController : IHotfixable, IDisposable
		{
			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00003348 File Offset: 0x00001548
			// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000D0")]
			public HGSDKV2.InitState state
			{
				[Token(Token = "0x60005D4")]
				[Address(RVA = "0x1AD3740", Offset = "0x1AD2340", VA = "0x181AD3740")]
				[CompilerGenerated]
				get
				{
					return HGSDKV2.InitState.NONE;
				}
				[Token(Token = "0x60005D5")]
				[Address(RVA = "0x1AD37F0", Offset = "0x1AD23F0", VA = "0x181AD37F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x1AD3310", Offset = "0x1AD1F10", VA = "0x181AD3310")]
			public void InvokeInit()
			{
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1AD3220", Offset = "0x1AD1E20", VA = "0x181AD3220", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x1AD35E0", Offset = "0x1AD21E0", VA = "0x181AD35E0")]
			private static string _CreateInitParam()
			{
				return null;
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x1AD3650", Offset = "0x1AD2250", VA = "0x181AD3650")]
			private void _OnInitCallback(SDKExtraInfoHandler.SDKInitMessage msg)
			{
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1AD36E0", Offset = "0x1AD22E0", VA = "0x181AD36E0")]
			public InitRequestController()
			{
			}

			// Token: 0x04000789 RID: 1929
			[Token(Token = "0x4000789")]
			[FieldOffset(Offset = "0x10")]
			private bool m_isCallbackBinded;

			// Token: 0x0400078B RID: 1931
			[Token(Token = "0x400078B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_state;

			// Token: 0x0400078C RID: 1932
			[Token(Token = "0x400078C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_state;

			// Token: 0x0400078D RID: 1933
			[Token(Token = "0x400078D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_InvokeInit;

			// Token: 0x0400078E RID: 1934
			[Token(Token = "0x400078E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x0400078F RID: 1935
			[Token(Token = "0x400078F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__CreateInitParam;

			// Token: 0x04000790 RID: 1936
			[Token(Token = "0x4000790")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__OnInitCallback;

			// Token: 0x04000791 RID: 1937
			[Token(Token = "0x4000791")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
