using System;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B4F RID: 23375
	[Token(Token = "0x2005B4F")]
	public class ShopPage : StateEnginePage, IBuildingPage, IDialogMgrHolder, IHotfixable
	{
		// Token: 0x17004F6A RID: 20330
		// (get) Token: 0x06021EEE RID: 138990 RVA: 0x000BBCE0 File Offset: 0x000B9EE0
		[Token(Token = "0x17004F6A")]
		public override AVGPageKey avgPage
		{
			[Token(Token = "0x6021EEE")]
			[Address(RVA = "0x1C72240", Offset = "0x1C70E40", VA = "0x181C72240", Slot = "20")]
			get
			{
				return AVGPageKey.NONE;
			}
		}

		// Token: 0x17004F6B RID: 20331
		// (get) Token: 0x06021EEF RID: 138991 RVA: 0x000BBCF8 File Offset: 0x000B9EF8
		[Token(Token = "0x17004F6B")]
		public override bool shouldTrigAudioSignal
		{
			[Token(Token = "0x6021EEF")]
			[Address(RVA = "0x1C722A0", Offset = "0x1C70EA0", VA = "0x181C722A0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06021EF0 RID: 138992 RVA: 0x000BBD10 File Offset: 0x000B9F10
		[Token(Token = "0x6021EF0")]
		[Address(RVA = "0x1C71570", Offset = "0x1C70170", VA = "0x181C71570")]
		public bool IsTransitting()
		{
			return default(bool);
		}

		// Token: 0x06021EF1 RID: 138993 RVA: 0x000BBD28 File Offset: 0x000B9F28
		[Token(Token = "0x6021EF1")]
		[Address(RVA = "0x1C714B0", Offset = "0x1C700B0", VA = "0x181C714B0", Slot = "29")]
		public bool CanInteractBuilding()
		{
			return default(bool);
		}

		// Token: 0x06021EF2 RID: 138994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EF2")]
		[Address(RVA = "0x1C71600", Offset = "0x1C70200", VA = "0x181C71600", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06021EF3 RID: 138995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EF3")]
		[Address(RVA = "0x1C71910", Offset = "0x1C70510", VA = "0x181C71910", Slot = "28")]
		protected override void OnStateEngineReady(bool isFromStack)
		{
		}

		// Token: 0x06021EF4 RID: 138996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EF4")]
		[Address(RVA = "0x1C717C0", Offset = "0x1C703C0", VA = "0x181C717C0", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x06021EF5 RID: 138997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EF5")]
		[Address(RVA = "0x1C71750", Offset = "0x1C70350", VA = "0x181C71750", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06021EF6 RID: 138998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021EF6")]
		[Address(RVA = "0x1C71510", Offset = "0x1C70110", VA = "0x181C71510", Slot = "30")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x06021EF7 RID: 138999 RVA: 0x000BBD40 File Offset: 0x000B9F40
		[Token(Token = "0x6021EF7")]
		[Address(RVA = "0x1C71D60", Offset = "0x1C70960", VA = "0x181C71D60")]
		private static ShopRouteTarget _PickInitShopType(ShopPage.Params pageParam)
		{
			return ShopRouteTarget.RECOMMENDSHOP;
		}

		// Token: 0x06021EF8 RID: 139000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EF8")]
		[Address(RVA = "0x1C71B70", Offset = "0x1C70770", VA = "0x181C71B70")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x06021EF9 RID: 139001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EF9")]
		[Address(RVA = "0x1C71DF0", Offset = "0x1C709F0", VA = "0x181C71DF0")]
		private void _TryUpdateStatusWhenRouted()
		{
		}

		// Token: 0x06021EFA RID: 139002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EFA")]
		[Address(RVA = "0x1C71ED0", Offset = "0x1C70AD0", VA = "0x181C71ED0")]
		private void _UpdateStatusWhenBackToShop(UIPageTransContext transContext)
		{
		}

		// Token: 0x06021EFB RID: 139003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EFB")]
		[Address(RVA = "0x1C721E0", Offset = "0x1C70DE0", VA = "0x181C721E0")]
		public ShopPage()
		{
		}

		// Token: 0x06021EFD RID: 139005 RVA: 0x000BBD58 File Offset: 0x000B9F58
		[Token(Token = "0x6021EFD")]
		[Address(RVA = "0x101CF00", Offset = "0x101BB00", VA = "0x18101CF00")]
		private AVGPageKey <>xLuaBaseProxy_get_avgPage()
		{
			return AVGPageKey.NONE;
		}

		// Token: 0x06021EFE RID: 139006 RVA: 0x000BBD70 File Offset: 0x000B9F70
		[Token(Token = "0x6021EFE")]
		[Address(RVA = "0x1C71B60", Offset = "0x1C70760", VA = "0x181C71B60")]
		private bool <>xLuaBaseProxy_get_shouldTrigAudioSignal()
		{
			return default(bool);
		}

		// Token: 0x06021EFF RID: 139007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021EFF")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06021F00 RID: 139008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F00")]
		[Address(RVA = "0x1232DA0", Offset = "0x12319A0", VA = "0x181232DA0")]
		private void <>xLuaBaseProxy_OnStateEngineReady(bool P0)
		{
		}

		// Token: 0x06021F01 RID: 139009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F01")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x06021F02 RID: 139010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F02")]
		[Address(RVA = "0x12172F0", Offset = "0x1215EF0", VA = "0x1812172F0")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402E7CB RID: 190411
		[Token(Token = "0x402E7CB")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private PrefabInstHolder _topMenuHolder;

		// Token: 0x0402E7CC RID: 190412
		[Token(Token = "0x402E7CC")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ShopStateItemContainer _controller;

		// Token: 0x0402E7CD RID: 190413
		[Token(Token = "0x402E7CD")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0402E7CE RID: 190414
		[Token(Token = "0x402E7CE")]
		[FieldOffset(Offset = "0x108")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0402E7CF RID: 190415
		[Token(Token = "0x402E7CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_avgPage;

		// Token: 0x0402E7D0 RID: 190416
		[Token(Token = "0x402E7D0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_shouldTrigAudioSignal;

		// Token: 0x0402E7D1 RID: 190417
		[Token(Token = "0x402E7D1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsTransitting;

		// Token: 0x0402E7D2 RID: 190418
		[Token(Token = "0x402E7D2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CanInteractBuilding;

		// Token: 0x0402E7D3 RID: 190419
		[Token(Token = "0x402E7D3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402E7D4 RID: 190420
		[Token(Token = "0x402E7D4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnStateEngineReady;

		// Token: 0x0402E7D5 RID: 190421
		[Token(Token = "0x402E7D5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x0402E7D6 RID: 190422
		[Token(Token = "0x402E7D6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402E7D7 RID: 190423
		[Token(Token = "0x402E7D7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0402E7D8 RID: 190424
		[Token(Token = "0x402E7D8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__PickInitShopType;

		// Token: 0x0402E7D9 RID: 190425
		[Token(Token = "0x402E7D9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x0402E7DA RID: 190426
		[Token(Token = "0x402E7DA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryUpdateStatusWhenRouted;

		// Token: 0x0402E7DB RID: 190427
		[Token(Token = "0x402E7DB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateStatusWhenBackToShop;

		// Token: 0x0402E7DC RID: 190428
		[Token(Token = "0x402E7DC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005B50 RID: 23376
		[Token(Token = "0x2005B50")]
		public class Params
		{
			// Token: 0x06021F03 RID: 139011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021F03")]
			[Address(RVA = "0x1C6F500", Offset = "0x1C6E100", VA = "0x181C6F500")]
			public Params()
			{
			}

			// Token: 0x0402E7DD RID: 190429
			[Token(Token = "0x402E7DD")]
			[FieldOffset(Offset = "0x10")]
			public ShopRouteTarget targetShop;

			// Token: 0x0402E7DE RID: 190430
			[Token(Token = "0x402E7DE")]
			[FieldOffset(Offset = "0x18")]
			public string targetGoodId;

			// Token: 0x0402E7DF RID: 190431
			[Token(Token = "0x402E7DF")]
			[FieldOffset(Offset = "0x20")]
			public int LQCShopGroup;

			// Token: 0x0402E7E0 RID: 190432
			[Token(Token = "0x402E7E0")]
			[FieldOffset(Offset = "0x24")]
			public bool isParamForBack;
		}

		// Token: 0x02005B51 RID: 23377
		[Token(Token = "0x2005B51")]
		public enum Referrer
		{
			// Token: 0x0402E7E2 RID: 190434
			[Token(Token = "0x402E7E2")]
			NONE = -1,
			// Token: 0x0402E7E3 RID: 190435
			[Token(Token = "0x402E7E3")]
			DIRECT,
			// Token: 0x0402E7E4 RID: 190436
			[Token(Token = "0x402E7E4")]
			BANNER,
			// Token: 0x0402E7E5 RID: 190437
			[Token(Token = "0x402E7E5")]
			CLOSURE,
			// Token: 0x0402E7E6 RID: 190438
			[Token(Token = "0x402E7E6")]
			BACKFLOW
		}
	}
}
