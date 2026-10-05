using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AA3 RID: 23203
	[Token(Token = "0x2005AA3")]
	public class ShopDetailDataCache : PageSingleComponent, IDataBindWrapper, IPlayerDataListener, IHotfixable
	{
		// Token: 0x06021BCF RID: 138191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BCF")]
		[Address(RVA = "0x1C36F30", Offset = "0x1C35B30", VA = "0x181C36F30")]
		private UIExclusiveCoroutineInPage _EnsureHost()
		{
			return null;
		}

		// Token: 0x17004F11 RID: 20241
		// (get) Token: 0x06021BD0 RID: 138192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F11")]
		public static DetailCommonViewModel detailItem
		{
			[Token(Token = "0x6021BD0")]
			[Address(RVA = "0x1C37120", Offset = "0x1C35D20", VA = "0x181C37120")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F12 RID: 20242
		// (get) Token: 0x06021BD1 RID: 138193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F12")]
		public static FurnGroupViewModel furnGroup
		{
			[Token(Token = "0x6021BD1")]
			[Address(RVA = "0x1C371D0", Offset = "0x1C35DD0", VA = "0x181C371D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021BD2 RID: 138194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BD2")]
		[Address(RVA = "0x1C34CB0", Offset = "0x1C338B0", VA = "0x181C34CB0")]
		public static void ApplyLMTGSItem(LMTGSViewModel limitViewModel)
		{
		}

		// Token: 0x06021BD3 RID: 138195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BD3")]
		[Address(RVA = "0x1C34AB0", Offset = "0x1C336B0", VA = "0x181C34AB0")]
		public static void ApplyEPGSItem(EPGSViewModel epGSViewModel)
		{
		}

		// Token: 0x06021BD4 RID: 138196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BD4")]
		[Address(RVA = "0x1C356A0", Offset = "0x1C342A0", VA = "0x181C356A0")]
		public static void ApplyREPItem(QCShopREPGood repViewModel)
		{
		}

		// Token: 0x06021BD5 RID: 138197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BD5")]
		[Address(RVA = "0x1C343B0", Offset = "0x1C32FB0", VA = "0x181C343B0")]
		public static void ApplyDetailItem(ShopDetailPriceType priceType, QCCommonObj obj)
		{
		}

		// Token: 0x06021BD6 RID: 138198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BD6")]
		[Address(RVA = "0x1C34020", Offset = "0x1C32C20", VA = "0x181C34020")]
		public static void ApplyDetailItem(ShopDetailPriceType priceType, QCShopObjProgressViewModel item)
		{
		}

		// Token: 0x06021BD7 RID: 138199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BD7")]
		[Address(RVA = "0x1C34EF0", Offset = "0x1C33AF0", VA = "0x181C34EF0")]
		public static void ApplyQCExtraItem(ShopDetailPriceType priceType, QCShopExtraObj obj)
		{
		}

		// Token: 0x06021BD8 RID: 138200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BD8")]
		[Address(RVA = "0x1C368D0", Offset = "0x1C354D0", VA = "0x181C368D0")]
		private static void _ApplyGPDetailItem(ShopType shopType, ShopDetailPriceType priceType, NormalGPItem item, PlayerGoodItemData playerInfo, long endTime = -1L)
		{
		}

		// Token: 0x06021BD9 RID: 138201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BD9")]
		[Address(RVA = "0x1C32260", Offset = "0x1C30E60", VA = "0x181C32260")]
		public static void ApplyDetailItemChoose(ShopType shopType, ShopDetailPriceType priceType, ChooseGPItem item, ShopGPCommonItemViewModel itemModel)
		{
		}

		// Token: 0x06021BDA RID: 138202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BDA")]
		[Address(RVA = "0x1C33300", Offset = "0x1C31F00", VA = "0x181C33300")]
		public static void ApplyDetailItem(ShopGPCondTrigItemViewModel itemModel)
		{
		}

		// Token: 0x06021BDB RID: 138203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BDB")]
		[Address(RVA = "0x1C331F0", Offset = "0x1C31DF0", VA = "0x181C331F0")]
		public static void ApplyDetailItem(ShopType shopType, ShopDetailPriceType priceType, NormalGPItem item, PlayerGoodItemData playerInfo, long endTime = -1L)
		{
		}

		// Token: 0x06021BDC RID: 138204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BDC")]
		[Address(RVA = "0x1C32800", Offset = "0x1C31400", VA = "0x181C32800")]
		public static void ApplyDetailItem(ShopGPMonthlySubItemViewModel subItem)
		{
		}

		// Token: 0x06021BDD RID: 138205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BDD")]
		[Address(RVA = "0x1C32640", Offset = "0x1C31240", VA = "0x181C32640")]
		public static void ApplyDetailItem(FurnGroupViewModel viewModel)
		{
		}

		// Token: 0x06021BDE RID: 138206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BDE")]
		[Address(RVA = "0x1C335A0", Offset = "0x1C321A0", VA = "0x181C335A0")]
		public static void ApplyDetailItem(BuildingGetFurnitureGoodListResponse.Good good)
		{
		}

		// Token: 0x06021BDF RID: 138207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BDF")]
		[Address(RVA = "0x1C32B60", Offset = "0x1C31760", VA = "0x181C32B60")]
		public static void ApplyDetailItem(ShopCreditViewModel viewModel)
		{
		}

		// Token: 0x06021BE0 RID: 138208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BE0")]
		[Address(RVA = "0x1C33A70", Offset = "0x1C32670", VA = "0x181C33A70")]
		public static void ApplyDetailItem(SkinShopBlindBoxViewModel viewModel)
		{
		}

		// Token: 0x06021BE1 RID: 138209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BE1")]
		[Address(RVA = "0x1C36790", Offset = "0x1C35390", VA = "0x181C36790")]
		public static UIItemViewModel ReturnItemByType(ShopDetailPriceType priceType)
		{
			return null;
		}

		// Token: 0x06021BE2 RID: 138210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BE2")]
		[Address(RVA = "0x1C358A0", Offset = "0x1C344A0", VA = "0x181C358A0")]
		public void ApplyResourceShopType(ShopType shopType)
		{
		}

		// Token: 0x06021BE3 RID: 138211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BE3")]
		[Address(RVA = "0x1C354B0", Offset = "0x1C340B0", VA = "0x181C354B0")]
		public void ApplyQCShopType(QCShopDetailShopEnum type)
		{
		}

		// Token: 0x06021BE4 RID: 138212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BE4")]
		[Address(RVA = "0x1C35A20", Offset = "0x1C34620", VA = "0x181C35A20")]
		public static ResourceBarViewModel GetResourceShowType(QCShopDetailShopEnum type)
		{
			return null;
		}

		// Token: 0x06021BE5 RID: 138213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BE5")]
		[Address(RVA = "0x1C35B20", Offset = "0x1C34720", VA = "0x181C35B20")]
		public static ResourceBarViewModel GetResourceShowType(ShopType shopType)
		{
			return null;
		}

		// Token: 0x06021BE6 RID: 138214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BE6")]
		[Address(RVA = "0x1C321F0", Offset = "0x1C30DF0", VA = "0x181C321F0")]
		public void ApplyCreditUnlockState()
		{
		}

		// Token: 0x06021BE7 RID: 138215 RVA: 0x000BB2F0 File Offset: 0x000B94F0
		[Token(Token = "0x6021BE7")]
		[Address(RVA = "0x1C35C90", Offset = "0x1C34890", VA = "0x181C35C90")]
		public static int GetShopBuyCount(ShopRouteTarget shopType, string goodId)
		{
			return 0;
		}

		// Token: 0x06021BE8 RID: 138216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BE8")]
		private void _StateEngineAddDetailSecured<StateType>() where StateType : State, IShopDetailLayer
		{
		}

		// Token: 0x06021BE9 RID: 138217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BE9")]
		private IEnumerator _WaitForAddTopCoroutine<StateType>() where StateType : State, IShopDetailLayer
		{
			return null;
		}

		// Token: 0x06021BEA RID: 138218 RVA: 0x000BB308 File Offset: 0x000B9508
		[Token(Token = "0x6021BEA")]
		private bool _DetailLayerAddTop<StateType>() where StateType : State, IShopDetailLayer
		{
			return default(bool);
		}

		// Token: 0x06021BEB RID: 138219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BEB")]
		[Address(RVA = "0x1C36FF0", Offset = "0x1C35BF0", VA = "0x181C36FF0")]
		private static ShopDetailDataCache _SingleCompOnShopPage()
		{
			return null;
		}

		// Token: 0x06021BEC RID: 138220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BEC")]
		[Address(RVA = "0x1C365F0", Offset = "0x1C351F0", VA = "0x181C365F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06021BED RID: 138221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BED")]
		[Address(RVA = "0x1C36660", Offset = "0x1C35260", VA = "0x181C36660", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06021BEE RID: 138222 RVA: 0x000BB320 File Offset: 0x000B9520
		[Token(Token = "0x6021BEE")]
		[Address(RVA = "0x1C35980", Offset = "0x1C34580", VA = "0x181C35980", Slot = "12")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06021BEF RID: 138223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BEF")]
		[Address(RVA = "0x1C366D0", Offset = "0x1C352D0", VA = "0x181C366D0", Slot = "13")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x06021BF0 RID: 138224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BF0")]
		[Address(RVA = "0x1C37070", Offset = "0x1C35C70", VA = "0x181C37070")]
		public ShopDetailDataCache()
		{
		}

		// Token: 0x06021BF1 RID: 138225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BF1")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x06021BF2 RID: 138226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BF2")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x0402E287 RID: 189063
		[Token(Token = "0x402E287")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ResourceBarViewProperty _resourceBarProperty;

		// Token: 0x0402E288 RID: 189064
		[Token(Token = "0x402E288")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LMTGSResourceBar _lmtgsResBar;

		// Token: 0x0402E289 RID: 189065
		[Token(Token = "0x402E289")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x0402E28A RID: 189066
		[Token(Token = "0x402E28A")]
		[FieldOffset(Offset = "0x38")]
		private DetailCommonViewModel m_detailItem;

		// Token: 0x0402E28B RID: 189067
		[Token(Token = "0x402E28B")]
		[FieldOffset(Offset = "0x40")]
		private FurnGroupViewModel m_furnGroup;

		// Token: 0x0402E28C RID: 189068
		[Token(Token = "0x402E28C")]
		[FieldOffset(Offset = "0x48")]
		private UIExclusiveCoroutineInPage m_host;

		// Token: 0x0402E28D RID: 189069
		[Token(Token = "0x402E28D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isDetailTransiting;

		// Token: 0x0402E28E RID: 189070
		[Token(Token = "0x402E28E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__EnsureHost;

		// Token: 0x0402E28F RID: 189071
		[Token(Token = "0x402E28F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_detailItem;

		// Token: 0x0402E290 RID: 189072
		[Token(Token = "0x402E290")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_furnGroup;

		// Token: 0x0402E291 RID: 189073
		[Token(Token = "0x402E291")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplyLMTGSItem;

		// Token: 0x0402E292 RID: 189074
		[Token(Token = "0x402E292")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyEPGSItem;

		// Token: 0x0402E293 RID: 189075
		[Token(Token = "0x402E293")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ApplyREPItem;

		// Token: 0x0402E294 RID: 189076
		[Token(Token = "0x402E294")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyDetailItem;

		// Token: 0x0402E295 RID: 189077
		[Token(Token = "0x402E295")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix1_ApplyDetailItem;

		// Token: 0x0402E296 RID: 189078
		[Token(Token = "0x402E296")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ApplyQCExtraItem;

		// Token: 0x0402E297 RID: 189079
		[Token(Token = "0x402E297")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ApplyGPDetailItem;

		// Token: 0x0402E298 RID: 189080
		[Token(Token = "0x402E298")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ApplyDetailItemChoose;

		// Token: 0x0402E299 RID: 189081
		[Token(Token = "0x402E299")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix2_ApplyDetailItem;

		// Token: 0x0402E29A RID: 189082
		[Token(Token = "0x402E29A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix3_ApplyDetailItem;

		// Token: 0x0402E29B RID: 189083
		[Token(Token = "0x402E29B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix4_ApplyDetailItem;

		// Token: 0x0402E29C RID: 189084
		[Token(Token = "0x402E29C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix5_ApplyDetailItem;

		// Token: 0x0402E29D RID: 189085
		[Token(Token = "0x402E29D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix6_ApplyDetailItem;

		// Token: 0x0402E29E RID: 189086
		[Token(Token = "0x402E29E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix7_ApplyDetailItem;

		// Token: 0x0402E29F RID: 189087
		[Token(Token = "0x402E29F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix8_ApplyDetailItem;

		// Token: 0x0402E2A0 RID: 189088
		[Token(Token = "0x402E2A0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ReturnItemByType;

		// Token: 0x0402E2A1 RID: 189089
		[Token(Token = "0x402E2A1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ApplyResourceShopType;

		// Token: 0x0402E2A2 RID: 189090
		[Token(Token = "0x402E2A2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ApplyQCShopType;

		// Token: 0x0402E2A3 RID: 189091
		[Token(Token = "0x402E2A3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetResourceShowType;

		// Token: 0x0402E2A4 RID: 189092
		[Token(Token = "0x402E2A4")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix1_GetResourceShowType;

		// Token: 0x0402E2A5 RID: 189093
		[Token(Token = "0x402E2A5")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ApplyCreditUnlockState;

		// Token: 0x0402E2A6 RID: 189094
		[Token(Token = "0x402E2A6")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetShopBuyCount;

		// Token: 0x0402E2A7 RID: 189095
		[Token(Token = "0x402E2A7")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__StateEngineAddDetailSecured;

		// Token: 0x0402E2A8 RID: 189096
		[Token(Token = "0x402E2A8")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__WaitForAddTopCoroutine;

		// Token: 0x0402E2A9 RID: 189097
		[Token(Token = "0x402E2A9")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__DetailLayerAddTop;

		// Token: 0x0402E2AA RID: 189098
		[Token(Token = "0x402E2AA")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__SingleCompOnShopPage;

		// Token: 0x0402E2AB RID: 189099
		[Token(Token = "0x402E2AB")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402E2AC RID: 189100
		[Token(Token = "0x402E2AC")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402E2AD RID: 189101
		[Token(Token = "0x402E2AD")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0402E2AE RID: 189102
		[Token(Token = "0x402E2AE")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0402E2AF RID: 189103
		[Token(Token = "0x402E2AF")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
