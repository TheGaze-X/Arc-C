using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x020057A1 RID: 22433
	[Token(Token = "0x20057A1")]
	public class RL02ShopGoodsViewModelPlugin : RoguelikeGameShopViewModelPlugin
	{
		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x06020CF8 RID: 134392 RVA: 0x000B7678 File Offset: 0x000B5878
		[Token(Token = "0x17004CE9")]
		public override bool canRefresh
		{
			[Token(Token = "0x6020CF8")]
			[Address(RVA = "0x1B272B0", Offset = "0x1B25EB0", VA = "0x181B272B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004CEA RID: 19690
		// (get) Token: 0x06020CF9 RID: 134393 RVA: 0x000B7690 File Offset: 0x000B5890
		[Token(Token = "0x17004CEA")]
		public override bool showRefreshBtn
		{
			[Token(Token = "0x6020CF9")]
			[Address(RVA = "0x1B273A0", Offset = "0x1B25FA0", VA = "0x181B273A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004CEB RID: 19691
		// (get) Token: 0x06020CFA RID: 134394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004CEB")]
		public override string refreshConfirmTipWithoutCost
		{
			[Token(Token = "0x6020CFA")]
			[Address(RVA = "0x1B27320", Offset = "0x1B25F20", VA = "0x181B27320", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020CFB RID: 134395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CFB")]
		[Address(RVA = "0x1B270B0", Offset = "0x1B25CB0", VA = "0x181B270B0", Slot = "11")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.ShopContent shopPlayerData, PlayerRoguelikeV2.CurrentData current)
		{
		}

		// Token: 0x06020CFC RID: 134396 RVA: 0x000B76A8 File Offset: 0x000B58A8
		[Token(Token = "0x6020CFC")]
		[Address(RVA = "0x1B26FF0", Offset = "0x1B25BF0", VA = "0x181B26FF0", Slot = "12")]
		public override bool GetCannotRefreshToast(out string cantToast)
		{
			return default(bool);
		}

		// Token: 0x06020CFD RID: 134397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CFD")]
		[Address(RVA = "0x1B271A0", Offset = "0x1B25DA0", VA = "0x181B271A0", Slot = "14")]
		public override void OnShopRefreshed(RoguelikeShopStateBean stateBean)
		{
		}

		// Token: 0x06020CFE RID: 134398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020CFE")]
		[Address(RVA = "0x1B27250", Offset = "0x1B25E50", VA = "0x181B27250")]
		public RL02ShopGoodsViewModelPlugin()
		{
		}

		// Token: 0x06020CFF RID: 134399 RVA: 0x000B76C0 File Offset: 0x000B58C0
		[Token(Token = "0x6020CFF")]
		[Address(RVA = "0x1A7F520", Offset = "0x1A7E120", VA = "0x181A7F520")]
		private bool <>xLuaBaseProxy_get_canRefresh()
		{
			return default(bool);
		}

		// Token: 0x06020D00 RID: 134400 RVA: 0x000B76D8 File Offset: 0x000B58D8
		[Token(Token = "0x6020D00")]
		[Address(RVA = "0x1A7F530", Offset = "0x1A7E130", VA = "0x181A7F530")]
		private bool <>xLuaBaseProxy_get_showRefreshBtn()
		{
			return default(bool);
		}

		// Token: 0x06020D01 RID: 134401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D01")]
		[Address(RVA = "0x1B15190", Offset = "0x1B13D90", VA = "0x181B15190")]
		private string <>xLuaBaseProxy_get_refreshConfirmTipWithoutCost()
		{
			return null;
		}

		// Token: 0x06020D02 RID: 134402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D02")]
		[Address(RVA = "0x1A7F4F0", Offset = "0x1A7E0F0", VA = "0x181A7F4F0")]
		private void <>xLuaBaseProxy_LoadData(string P0, PlayerRoguelikePendingEvent.ShopContent P1, PlayerRoguelikeV2.CurrentData P2)
		{
		}

		// Token: 0x06020D03 RID: 134403 RVA: 0x000B76F0 File Offset: 0x000B58F0
		[Token(Token = "0x6020D03")]
		[Address(RVA = "0x1B27240", Offset = "0x1B25E40", VA = "0x181B27240")]
		private bool <>xLuaBaseProxy_GetCannotRefreshToast(out string P0)
		{
			return default(bool);
		}

		// Token: 0x06020D04 RID: 134404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D04")]
		[Address(RVA = "0x1A7F500", Offset = "0x1A7E100", VA = "0x181A7F500")]
		private void <>xLuaBaseProxy_OnShopRefreshed(RoguelikeShopStateBean P0)
		{
		}

		// Token: 0x0402C95A RID: 182618
		[Token(Token = "0x402C95A")]
		[FieldOffset(Offset = "0x38")]
		private bool m_diceCountLack;

		// Token: 0x0402C95B RID: 182619
		[Token(Token = "0x402C95B")]
		[FieldOffset(Offset = "0x39")]
		private bool m_hasBoss;

		// Token: 0x0402C95C RID: 182620
		[Token(Token = "0x402C95C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canRefresh;

		// Token: 0x0402C95D RID: 182621
		[Token(Token = "0x402C95D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showRefreshBtn;

		// Token: 0x0402C95E RID: 182622
		[Token(Token = "0x402C95E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_refreshConfirmTipWithoutCost;

		// Token: 0x0402C95F RID: 182623
		[Token(Token = "0x402C95F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402C960 RID: 182624
		[Token(Token = "0x402C960")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCannotRefreshToast;

		// Token: 0x0402C961 RID: 182625
		[Token(Token = "0x402C961")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnShopRefreshed;

		// Token: 0x0402C962 RID: 182626
		[Token(Token = "0x402C962")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
