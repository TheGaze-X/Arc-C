using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B54 RID: 23380
	[Token(Token = "0x2005B54")]
	public class ShopStateItemContainer : PageSingleComponent, IHotfixable
	{
		// Token: 0x17004F6C RID: 20332
		// (get) Token: 0x06021F0B RID: 139019 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021F0C RID: 139020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F6C")]
		public static string openItemGoodId
		{
			[Token(Token = "0x6021F0B")]
			[Address(RVA = "0x1C79500", Offset = "0x1C78100", VA = "0x181C79500")]
			get
			{
				return null;
			}
			[Token(Token = "0x6021F0C")]
			[Address(RVA = "0x1C79790", Offset = "0x1C78390", VA = "0x181C79790")]
			set
			{
			}
		}

		// Token: 0x17004F6D RID: 20333
		// (get) Token: 0x06021F0D RID: 139021 RVA: 0x000BBDA0 File Offset: 0x000B9FA0
		// (set) Token: 0x06021F0E RID: 139022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F6D")]
		public static QCShopDetailShopEnum qcDetail
		{
			[Token(Token = "0x6021F0D")]
			[Address(RVA = "0x1C795F0", Offset = "0x1C781F0", VA = "0x181C795F0")]
			get
			{
				return QCShopDetailShopEnum.LOW;
			}
			[Token(Token = "0x6021F0E")]
			[Address(RVA = "0x1C79870", Offset = "0x1C78470", VA = "0x181C79870")]
			set
			{
			}
		}

		// Token: 0x17004F6E RID: 20334
		// (get) Token: 0x06021F0F RID: 139023 RVA: 0x000BBDB8 File Offset: 0x000B9FB8
		// (set) Token: 0x06021F10 RID: 139024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F6E")]
		public static int LQCShopGroup
		{
			[Token(Token = "0x6021F0F")]
			[Address(RVA = "0x1C79430", Offset = "0x1C78030", VA = "0x181C79430")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6021F10")]
			[Address(RVA = "0x1C796C0", Offset = "0x1C782C0", VA = "0x181C796C0")]
			set
			{
			}
		}

		// Token: 0x06021F11 RID: 139025 RVA: 0x000BBDD0 File Offset: 0x000B9FD0
		[Token(Token = "0x6021F11")]
		[Address(RVA = "0x1C78910", Offset = "0x1C77510", VA = "0x181C78910")]
		public ShopType ShopPage_ConsumeOverrideBackPressed()
		{
			return ShopType.RECOMMENDSHOP;
		}

		// Token: 0x06021F12 RID: 139026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F12")]
		[Address(RVA = "0x1C78490", Offset = "0x1C77090", VA = "0x181C78490")]
		public void InitData(ShopRouteTarget defaultRouteState, [Optional] string defaultGood, int defaultLQCGroup = -1)
		{
		}

		// Token: 0x06021F13 RID: 139027 RVA: 0x000BBDE8 File Offset: 0x000B9FE8
		[Token(Token = "0x6021F13")]
		[Address(RVA = "0x1C78E10", Offset = "0x1C77A10", VA = "0x181C78E10")]
		public bool SwitchShopTypeWithService(ShopType shopType, ShopStateItemContainer.SwitchStateOptions options)
		{
			return default(bool);
		}

		// Token: 0x06021F14 RID: 139028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021F14")]
		private IEnumerator _RemoveTopAndReplaceTop<T>() where T : State
		{
			return null;
		}

		// Token: 0x06021F15 RID: 139029 RVA: 0x000BBE00 File Offset: 0x000BA000
		[Token(Token = "0x6021F15")]
		private bool _ReplaceTop<T>() where T : State
		{
			return default(bool);
		}

		// Token: 0x06021F16 RID: 139030 RVA: 0x000BBE18 File Offset: 0x000BA018
		[Token(Token = "0x6021F16")]
		[Address(RVA = "0x1C78D60", Offset = "0x1C77960", VA = "0x181C78D60")]
		public bool SwitchShopTypeWithService(ShopType shopType)
		{
			return default(bool);
		}

		// Token: 0x06021F17 RID: 139031 RVA: 0x000BBE30 File Offset: 0x000BA030
		[Token(Token = "0x6021F17")]
		[Address(RVA = "0x1C78A70", Offset = "0x1C77670", VA = "0x181C78A70")]
		public bool SwitchShopTypeWithItem(ShopRouteTarget allShopType, string goodId, ShopStateItemContainer.SwitchStateOptions options, int LQCShopGroupId)
		{
			return default(bool);
		}

		// Token: 0x06021F18 RID: 139032 RVA: 0x000BBE48 File Offset: 0x000BA048
		[Token(Token = "0x6021F18")]
		[Address(RVA = "0x1C78970", Offset = "0x1C77570", VA = "0x181C78970")]
		public bool SwitchShopTypeWithItem(ShopRouteTarget allShopType, [Optional] string goodId, int LQCShopGroupId = -1)
		{
			return default(bool);
		}

		// Token: 0x06021F19 RID: 139033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F19")]
		[Address(RVA = "0x1C78860", Offset = "0x1C77460", VA = "0x181C78860")]
		public void OnClick(ShopType shopType)
		{
		}

		// Token: 0x06021F1A RID: 139034 RVA: 0x000BBE60 File Offset: 0x000BA060
		[Token(Token = "0x6021F1A")]
		[Address(RVA = "0x1C783B0", Offset = "0x1C76FB0", VA = "0x181C783B0")]
		public static bool CheckIfShopUnlocked(ShopType shopType)
		{
			return default(bool);
		}

		// Token: 0x06021F1B RID: 139035 RVA: 0x000BBE78 File Offset: 0x000BA078
		[Token(Token = "0x6021F1B")]
		[Address(RVA = "0x1C782C0", Offset = "0x1C76EC0", VA = "0x181C782C0")]
		public static bool CheckIfShopRouteTargetUnlocked(ShopRouteTarget shopRouteTarget)
		{
			return default(bool);
		}

		// Token: 0x06021F1C RID: 139036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F1C")]
		[Address(RVA = "0x1C79240", Offset = "0x1C77E40", VA = "0x181C79240")]
		private void _TrySendService(ShopType targetShop)
		{
		}

		// Token: 0x06021F1D RID: 139037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F1D")]
		[Address(RVA = "0x1C79340", Offset = "0x1C77F40", VA = "0x181C79340")]
		public ShopStateItemContainer()
		{
		}

		// Token: 0x0402E7EC RID: 190444
		[Token(Token = "0x402E7EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ShopStateItemButton> _buttonList;

		// Token: 0x0402E7ED RID: 190445
		[Token(Token = "0x402E7ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x0402E7EE RID: 190446
		[Token(Token = "0x402E7EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _socialTrackPoint;

		// Token: 0x0402E7EF RID: 190447
		[Token(Token = "0x402E7EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _freeLevelGPTrackPoint;

		// Token: 0x0402E7F0 RID: 190448
		[Token(Token = "0x402E7F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TrackPointViewProperty m_socialShopTrackProp;

		// Token: 0x0402E7F1 RID: 190449
		[Token(Token = "0x402E7F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TrackPointViewProperty m_freeGPTrackProp;

		// Token: 0x0402E7F2 RID: 190450
		[Token(Token = "0x402E7F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string m_openItemGoodId;

		// Token: 0x0402E7F3 RID: 190451
		[Token(Token = "0x402E7F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private QCShopDetailShopEnum m_qcDetail;

		// Token: 0x0402E7F4 RID: 190452
		[Token(Token = "0x402E7F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_LQCGroup;

		// Token: 0x0402E7F5 RID: 190453
		[Token(Token = "0x402E7F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0402E7F6 RID: 190454
		[Token(Token = "0x402E7F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ShopType m_cacheShopType;

		// Token: 0x0402E7F7 RID: 190455
		[Token(Token = "0x402E7F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ShopType m_overrideBackPressedShop;

		// Token: 0x0402E7F8 RID: 190456
		[Token(Token = "0x402E7F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_openItemGoodId;

		// Token: 0x0402E7F9 RID: 190457
		[Token(Token = "0x402E7F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_openItemGoodId;

		// Token: 0x0402E7FA RID: 190458
		[Token(Token = "0x402E7FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_qcDetail;

		// Token: 0x0402E7FB RID: 190459
		[Token(Token = "0x402E7FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_qcDetail;

		// Token: 0x0402E7FC RID: 190460
		[Token(Token = "0x402E7FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_LQCShopGroup;

		// Token: 0x0402E7FD RID: 190461
		[Token(Token = "0x402E7FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_LQCShopGroup;

		// Token: 0x0402E7FE RID: 190462
		[Token(Token = "0x402E7FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShopPage_ConsumeOverrideBackPressed;

		// Token: 0x0402E7FF RID: 190463
		[Token(Token = "0x402E7FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402E800 RID: 190464
		[Token(Token = "0x402E800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SwitchShopTypeWithService;

		// Token: 0x0402E801 RID: 190465
		[Token(Token = "0x402E801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RemoveTopAndReplaceTop;

		// Token: 0x0402E802 RID: 190466
		[Token(Token = "0x402E802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ReplaceTop;

		// Token: 0x0402E803 RID: 190467
		[Token(Token = "0x402E803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_SwitchShopTypeWithService;

		// Token: 0x0402E804 RID: 190468
		[Token(Token = "0x402E804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SwitchShopTypeWithItem;

		// Token: 0x0402E805 RID: 190469
		[Token(Token = "0x402E805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix1_SwitchShopTypeWithItem;

		// Token: 0x0402E806 RID: 190470
		[Token(Token = "0x402E806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402E807 RID: 190471
		[Token(Token = "0x402E807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckIfShopUnlocked;

		// Token: 0x0402E808 RID: 190472
		[Token(Token = "0x402E808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckIfShopRouteTargetUnlocked;

		// Token: 0x0402E809 RID: 190473
		[Token(Token = "0x402E809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__TrySendService;

		// Token: 0x0402E80A RID: 190474
		[Token(Token = "0x402E80A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005B55 RID: 23381
		[Token(Token = "0x2005B55")]
		public struct SwitchStateOptions
		{
			// Token: 0x0402E80B RID: 190475
			[Token(Token = "0x402E80B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static ShopStateItemContainer.SwitchStateOptions EMPTY;

			// Token: 0x0402E80C RID: 190476
			[Token(Token = "0x402E80C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ShopType overrideBackPressed;

			// Token: 0x0402E80D RID: 190477
			[Token(Token = "0x402E80D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool isLMTGSFlag;

			// Token: 0x0402E80E RID: 190478
			[Token(Token = "0x402E80E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
			public bool isEPGSFlag;
		}
	}
}
