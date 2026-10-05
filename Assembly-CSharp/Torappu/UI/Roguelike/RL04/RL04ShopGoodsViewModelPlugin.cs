using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005716 RID: 22294
	[Token(Token = "0x2005716")]
	public class RL04ShopGoodsViewModelPlugin : RoguelikeGameShopViewModelPlugin
	{
		// Token: 0x17004CA2 RID: 19618
		// (get) Token: 0x06020ADD RID: 133853 RVA: 0x000B6CE8 File Offset: 0x000B4EE8
		[Token(Token = "0x17004CA2")]
		public override bool canRefresh
		{
			[Token(Token = "0x6020ADD")]
			[Address(RVA = "0x1B15B20", Offset = "0x1B14720", VA = "0x181B15B20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004CA3 RID: 19619
		// (get) Token: 0x06020ADE RID: 133854 RVA: 0x000B6D00 File Offset: 0x000B4F00
		[Token(Token = "0x17004CA3")]
		public override bool showRefreshBtn
		{
			[Token(Token = "0x6020ADE")]
			[Address(RVA = "0x1B15C70", Offset = "0x1B14870", VA = "0x181B15C70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004CA4 RID: 19620
		// (get) Token: 0x06020ADF RID: 133855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CA4")]
		public override Dictionary<string, RoguelikeGoodsViewModel> preloadedRecycleGoods
		{
			[Token(Token = "0x6020ADF")]
			[Address(RVA = "0x1B15B90", Offset = "0x1B14790", VA = "0x181B15B90", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x06020AE0 RID: 133856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CA5")]
		public override string refreshConfirmTipWithoutCost
		{
			[Token(Token = "0x6020AE0")]
			[Address(RVA = "0x1B15BF0", Offset = "0x1B147F0", VA = "0x181B15BF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020AE1 RID: 133857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AE1")]
		[Address(RVA = "0x1B14F20", Offset = "0x1B13B20", VA = "0x181B14F20", Slot = "11")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.ShopContent shopPlayerData, PlayerRoguelikeV2.CurrentData current)
		{
		}

		// Token: 0x06020AE2 RID: 133858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AE2")]
		[Address(RVA = "0x1B15000", Offset = "0x1B13C00", VA = "0x181B15000", Slot = "14")]
		public override void OnShopRefreshed(RoguelikeShopStateBean stateBean)
		{
		}

		// Token: 0x06020AE3 RID: 133859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AE3")]
		[Address(RVA = "0x1B150A0", Offset = "0x1B13CA0", VA = "0x181B150A0", Slot = "16")]
		public override void PostProcessRecycleGoods(List<RoguelikeGoodsViewModel> recycleGoodsList)
		{
		}

		// Token: 0x06020AE4 RID: 133860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AE4")]
		[Address(RVA = "0x1B15760", Offset = "0x1B14360", VA = "0x181B15760")]
		private void _LoadFragments(string topicId, PlayerRoguelikePendingEvent.ShopContent shopPlayerData, PlayerRoguelikeV2.CurrentData current)
		{
		}

		// Token: 0x06020AE5 RID: 133861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AE5")]
		[Address(RVA = "0x1B153A0", Offset = "0x1B13FA0", VA = "0x181B153A0")]
		private void _LoadFragment(string topicId, PlayerRoguelikePendingEvent.ShopContent.Goods goods, RoguelikeTopicDetail detailData, Dictionary<string, RoguelikeFragmentData> fragmentDataDict, Dictionary<string, PlayerRoguelikeV2.CurrentData.Module.InventoryFragment> fragmentsInInventory)
		{
		}

		// Token: 0x06020AE6 RID: 133862 RVA: 0x000B6D18 File Offset: 0x000B4F18
		[Token(Token = "0x6020AE6")]
		[Address(RVA = "0x1B151A0", Offset = "0x1B13DA0", VA = "0x181B151A0")]
		private static int _GoodsSort(RoguelikeGoodsViewModel x, RoguelikeGoodsViewModel y)
		{
			return 0;
		}

		// Token: 0x06020AE7 RID: 133863 RVA: 0x000B6D30 File Offset: 0x000B4F30
		[Token(Token = "0x6020AE7")]
		[Address(RVA = "0x1B159C0", Offset = "0x1B145C0", VA = "0x181B159C0")]
		private static int _TypeComparison(RoguelikeFragmentType x, RoguelikeFragmentType y)
		{
			return 0;
		}

		// Token: 0x06020AE8 RID: 133864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AE8")]
		[Address(RVA = "0x1B15A70", Offset = "0x1B14670", VA = "0x181B15A70")]
		public RL04ShopGoodsViewModelPlugin()
		{
		}

		// Token: 0x06020AE9 RID: 133865 RVA: 0x000B6D48 File Offset: 0x000B4F48
		[Token(Token = "0x6020AE9")]
		[Address(RVA = "0x1A7F520", Offset = "0x1A7E120", VA = "0x181A7F520")]
		private bool <>xLuaBaseProxy_get_canRefresh()
		{
			return default(bool);
		}

		// Token: 0x06020AEA RID: 133866 RVA: 0x000B6D60 File Offset: 0x000B4F60
		[Token(Token = "0x6020AEA")]
		[Address(RVA = "0x1A7F530", Offset = "0x1A7E130", VA = "0x181A7F530")]
		private bool <>xLuaBaseProxy_get_showRefreshBtn()
		{
			return default(bool);
		}

		// Token: 0x06020AEB RID: 133867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020AEB")]
		[Address(RVA = "0x1B15180", Offset = "0x1B13D80", VA = "0x181B15180")]
		private Dictionary<string, RoguelikeGoodsViewModel> <>xLuaBaseProxy_get_preloadedRecycleGoods()
		{
			return null;
		}

		// Token: 0x06020AEC RID: 133868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020AEC")]
		[Address(RVA = "0x1B15190", Offset = "0x1B13D90", VA = "0x181B15190")]
		private string <>xLuaBaseProxy_get_refreshConfirmTipWithoutCost()
		{
			return null;
		}

		// Token: 0x06020AED RID: 133869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AED")]
		[Address(RVA = "0x1A7F4F0", Offset = "0x1A7E0F0", VA = "0x181A7F4F0")]
		private void <>xLuaBaseProxy_LoadData(string P0, PlayerRoguelikePendingEvent.ShopContent P1, PlayerRoguelikeV2.CurrentData P2)
		{
		}

		// Token: 0x06020AEE RID: 133870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AEE")]
		[Address(RVA = "0x1A7F500", Offset = "0x1A7E100", VA = "0x181A7F500")]
		private void <>xLuaBaseProxy_OnShopRefreshed(RoguelikeShopStateBean P0)
		{
		}

		// Token: 0x06020AEF RID: 133871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AEF")]
		[Address(RVA = "0x1B15170", Offset = "0x1B13D70", VA = "0x181B15170")]
		private void <>xLuaBaseProxy_PostProcessRecycleGoods(List<RoguelikeGoodsViewModel> P0)
		{
		}

		// Token: 0x0402C5A2 RID: 181666
		[Token(Token = "0x402C5A2")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasBoss;

		// Token: 0x0402C5A3 RID: 181667
		[Token(Token = "0x402C5A3")]
		[FieldOffset(Offset = "0x39")]
		private bool m_hasRefreshBuffUnlock;

		// Token: 0x0402C5A4 RID: 181668
		[Token(Token = "0x402C5A4")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<string, RoguelikeGoodsViewModel> m_fragments;

		// Token: 0x0402C5A5 RID: 181669
		[Token(Token = "0x402C5A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canRefresh;

		// Token: 0x0402C5A6 RID: 181670
		[Token(Token = "0x402C5A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showRefreshBtn;

		// Token: 0x0402C5A7 RID: 181671
		[Token(Token = "0x402C5A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_preloadedRecycleGoods;

		// Token: 0x0402C5A8 RID: 181672
		[Token(Token = "0x402C5A8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_refreshConfirmTipWithoutCost;

		// Token: 0x0402C5A9 RID: 181673
		[Token(Token = "0x402C5A9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C5AA RID: 181674
		[Token(Token = "0x402C5AA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnShopRefreshed;

		// Token: 0x0402C5AB RID: 181675
		[Token(Token = "0x402C5AB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PostProcessRecycleGoods;

		// Token: 0x0402C5AC RID: 181676
		[Token(Token = "0x402C5AC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadFragments;

		// Token: 0x0402C5AD RID: 181677
		[Token(Token = "0x402C5AD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadFragment;

		// Token: 0x0402C5AE RID: 181678
		[Token(Token = "0x402C5AE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GoodsSort;

		// Token: 0x0402C5AF RID: 181679
		[Token(Token = "0x402C5AF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TypeComparison;

		// Token: 0x0402C5B0 RID: 181680
		[Token(Token = "0x402C5B0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
