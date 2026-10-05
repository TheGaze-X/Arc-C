using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005851 RID: 22609
	[Token(Token = "0x2005851")]
	public class RL03ShopGoodsViewModelPlugin : RoguelikeGameShopViewModelPlugin
	{
		// Token: 0x17004D7C RID: 19836
		// (get) Token: 0x06021068 RID: 135272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D7C")]
		public override string refreshConfirmTipWithoutCost
		{
			[Token(Token = "0x6021068")]
			[Address(RVA = "0x1B5E280", Offset = "0x1B5CE80", VA = "0x181B5E280", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D7D RID: 19837
		// (get) Token: 0x06021069 RID: 135273 RVA: 0x000B83C8 File Offset: 0x000B65C8
		[Token(Token = "0x17004D7D")]
		public override bool canRefresh
		{
			[Token(Token = "0x6021069")]
			[Address(RVA = "0x1B5E210", Offset = "0x1B5CE10", VA = "0x181B5E210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004D7E RID: 19838
		// (get) Token: 0x0602106A RID: 135274 RVA: 0x000B83E0 File Offset: 0x000B65E0
		[Token(Token = "0x17004D7E")]
		public override bool showRefreshBtn
		{
			[Token(Token = "0x602106A")]
			[Address(RVA = "0x1B5E300", Offset = "0x1B5CF00", VA = "0x181B5E300", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602106B RID: 135275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602106B")]
		[Address(RVA = "0x1B5E050", Offset = "0x1B5CC50", VA = "0x181B5E050", Slot = "11")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.ShopContent shopPlayerData, PlayerRoguelikeV2.CurrentData current)
		{
		}

		// Token: 0x0602106C RID: 135276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602106C")]
		[Address(RVA = "0x1B5E110", Offset = "0x1B5CD10", VA = "0x181B5E110", Slot = "14")]
		public override void OnShopRefreshed(RoguelikeShopStateBean stateBean)
		{
		}

		// Token: 0x0602106D RID: 135277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602106D")]
		[Address(RVA = "0x1B5E1B0", Offset = "0x1B5CDB0", VA = "0x181B5E1B0")]
		public RL03ShopGoodsViewModelPlugin()
		{
		}

		// Token: 0x0602106E RID: 135278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602106E")]
		[Address(RVA = "0x1B15190", Offset = "0x1B13D90", VA = "0x181B15190")]
		private string <>xLuaBaseProxy_get_refreshConfirmTipWithoutCost()
		{
			return null;
		}

		// Token: 0x0602106F RID: 135279 RVA: 0x000B83F8 File Offset: 0x000B65F8
		[Token(Token = "0x602106F")]
		[Address(RVA = "0x1A7F520", Offset = "0x1A7E120", VA = "0x181A7F520")]
		private bool <>xLuaBaseProxy_get_canRefresh()
		{
			return default(bool);
		}

		// Token: 0x06021070 RID: 135280 RVA: 0x000B8410 File Offset: 0x000B6610
		[Token(Token = "0x6021070")]
		[Address(RVA = "0x1A7F530", Offset = "0x1A7E130", VA = "0x181A7F530")]
		private bool <>xLuaBaseProxy_get_showRefreshBtn()
		{
			return default(bool);
		}

		// Token: 0x06021071 RID: 135281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021071")]
		[Address(RVA = "0x1A7F4F0", Offset = "0x1A7E0F0", VA = "0x181A7F4F0")]
		private void <>xLuaBaseProxy_LoadData(string P0, PlayerRoguelikePendingEvent.ShopContent P1, PlayerRoguelikeV2.CurrentData P2)
		{
		}

		// Token: 0x06021072 RID: 135282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021072")]
		[Address(RVA = "0x1A7F500", Offset = "0x1A7E100", VA = "0x181A7F500")]
		private void <>xLuaBaseProxy_OnShopRefreshed(RoguelikeShopStateBean P0)
		{
		}

		// Token: 0x0402CEBB RID: 183995
		[Token(Token = "0x402CEBB")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasBoss;

		// Token: 0x0402CEBC RID: 183996
		[Token(Token = "0x402CEBC")]
		[FieldOffset(Offset = "0x39")]
		private bool m_hasBuffUnlock;

		// Token: 0x0402CEBD RID: 183997
		[Token(Token = "0x402CEBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_refreshConfirmTipWithoutCost;

		// Token: 0x0402CEBE RID: 183998
		[Token(Token = "0x402CEBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_canRefresh;

		// Token: 0x0402CEBF RID: 183999
		[Token(Token = "0x402CEBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showRefreshBtn;

		// Token: 0x0402CEC0 RID: 184000
		[Token(Token = "0x402CEC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CEC1 RID: 184001
		[Token(Token = "0x402CEC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnShopRefreshed;

		// Token: 0x0402CEC2 RID: 184002
		[Token(Token = "0x402CEC2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
