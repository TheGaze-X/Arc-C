using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x020057A2 RID: 22434
	[Token(Token = "0x20057A2")]
	public class RL02ShopPlugin : RoguelikeShopPlugin
	{
		// Token: 0x06020D05 RID: 134405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D05")]
		[Address(RVA = "0x1B27590", Offset = "0x1B26190", VA = "0x181B27590", Slot = "8")]
		public override List<RoguelikeGoodsObjPlugin> GetGoodObjPlugins()
		{
			return null;
		}

		// Token: 0x06020D06 RID: 134406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D06")]
		[Address(RVA = "0x1B27650", Offset = "0x1B26250", VA = "0x181B27650", Slot = "5")]
		public override RoguelikeGameShopViewModelPlugin GetShopViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020D07 RID: 134407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D07")]
		[Address(RVA = "0x1B274D0", Offset = "0x1B260D0", VA = "0x181B274D0", Slot = "13")]
		public override RoguelikeGameBankWithdrawCommonView GetBankWithDrawlViewPrefab()
		{
			return null;
		}

		// Token: 0x06020D08 RID: 134408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D08")]
		[Address(RVA = "0x1B27400", Offset = "0x1B26000", VA = "0x181B27400", Slot = "6")]
		public override RoguelikeGameBankViewModel.BankWithdrawModelPlugin GetBankViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020D09 RID: 134409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D09")]
		[Address(RVA = "0x1B27530", Offset = "0x1B26130", VA = "0x181B27530", Slot = "14")]
		public override RoguelikeGameShopBattleConfirmView GetBattleConfirmViewPrefab()
		{
			return null;
		}

		// Token: 0x06020D0A RID: 134410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D0A")]
		[Address(RVA = "0x1B27720", Offset = "0x1B26320", VA = "0x181B27720")]
		public RL02ShopPlugin()
		{
		}

		// Token: 0x06020D0B RID: 134411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D0B")]
		[Address(RVA = "0x1A7FD10", Offset = "0x1A7E910", VA = "0x181A7FD10")]
		private List<RoguelikeGoodsObjPlugin> <>xLuaBaseProxy_GetGoodObjPlugins()
		{
			return null;
		}

		// Token: 0x06020D0C RID: 134412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D0C")]
		[Address(RVA = "0x1A7FD30", Offset = "0x1A7E930", VA = "0x181A7FD30")]
		private RoguelikeGameShopViewModelPlugin <>xLuaBaseProxy_GetShopViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020D0D RID: 134413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D0D")]
		[Address(RVA = "0x1A7FCB0", Offset = "0x1A7E8B0", VA = "0x181A7FCB0")]
		private RoguelikeGameBankWithdrawCommonView <>xLuaBaseProxy_GetBankWithDrawlViewPrefab()
		{
			return null;
		}

		// Token: 0x06020D0E RID: 134414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D0E")]
		[Address(RVA = "0x1A7FCA0", Offset = "0x1A7E8A0", VA = "0x181A7FCA0")]
		private RoguelikeGameBankViewModel.BankWithdrawModelPlugin <>xLuaBaseProxy_GetBankViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020D0F RID: 134415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D0F")]
		[Address(RVA = "0x1A7FCC0", Offset = "0x1A7E8C0", VA = "0x181A7FCC0")]
		private RoguelikeGameShopBattleConfirmView <>xLuaBaseProxy_GetBattleConfirmViewPrefab()
		{
			return null;
		}

		// Token: 0x0402C963 RID: 182627
		[Token(Token = "0x402C963")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeGoodsObjPlugin _goodDiscountViewPrefab;

		// Token: 0x0402C964 RID: 182628
		[Token(Token = "0x402C964")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeGameBankConsumeWithdrawView _bankWithdrawalViewPrefab;

		// Token: 0x0402C965 RID: 182629
		[Token(Token = "0x402C965")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeGameShopBattleConfirmView _battleConfirmViewPrefab;

		// Token: 0x0402C966 RID: 182630
		[Token(Token = "0x402C966")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetGoodObjPlugins;

		// Token: 0x0402C967 RID: 182631
		[Token(Token = "0x402C967")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShopViewModelPlugin;

		// Token: 0x0402C968 RID: 182632
		[Token(Token = "0x402C968")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBankWithDrawlViewPrefab;

		// Token: 0x0402C969 RID: 182633
		[Token(Token = "0x402C969")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBankViewModelPlugin;

		// Token: 0x0402C96A RID: 182634
		[Token(Token = "0x402C96A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetBattleConfirmViewPrefab;

		// Token: 0x0402C96B RID: 182635
		[Token(Token = "0x402C96B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
