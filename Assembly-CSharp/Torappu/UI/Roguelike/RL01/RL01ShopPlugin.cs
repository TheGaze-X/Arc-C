using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057C0 RID: 22464
	[Token(Token = "0x20057C0")]
	public class RL01ShopPlugin : RoguelikeShopPlugin
	{
		// Token: 0x06020DB1 RID: 134577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DB1")]
		[Address(RVA = "0x1B1D6E0", Offset = "0x1B1C2E0", VA = "0x181B1D6E0", Slot = "5")]
		public override RoguelikeGameShopViewModelPlugin GetShopViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020DB2 RID: 134578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DB2")]
		[Address(RVA = "0x1B1D680", Offset = "0x1B1C280", VA = "0x181B1D680", Slot = "13")]
		public override RoguelikeGameBankWithdrawCommonView GetBankWithDrawlViewPrefab()
		{
			return null;
		}

		// Token: 0x06020DB3 RID: 134579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DB3")]
		[Address(RVA = "0x1B1D5B0", Offset = "0x1B1C1B0", VA = "0x181B1D5B0", Slot = "6")]
		public override RoguelikeGameBankViewModel.BankWithdrawModelPlugin GetBankViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020DB4 RID: 134580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DB4")]
		[Address(RVA = "0x1B1D7B0", Offset = "0x1B1C3B0", VA = "0x181B1D7B0")]
		public RL01ShopPlugin()
		{
		}

		// Token: 0x06020DB5 RID: 134581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DB5")]
		[Address(RVA = "0x1A7FD30", Offset = "0x1A7E930", VA = "0x181A7FD30")]
		private RoguelikeGameShopViewModelPlugin <>xLuaBaseProxy_GetShopViewModelPlugin()
		{
			return null;
		}

		// Token: 0x06020DB6 RID: 134582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DB6")]
		[Address(RVA = "0x1A7FCB0", Offset = "0x1A7E8B0", VA = "0x181A7FCB0")]
		private RoguelikeGameBankWithdrawCommonView <>xLuaBaseProxy_GetBankWithDrawlViewPrefab()
		{
			return null;
		}

		// Token: 0x06020DB7 RID: 134583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020DB7")]
		[Address(RVA = "0x1A7FCA0", Offset = "0x1A7E8A0", VA = "0x181A7FCA0")]
		private RoguelikeGameBankViewModel.BankWithdrawModelPlugin <>xLuaBaseProxy_GetBankViewModelPlugin()
		{
			return null;
		}

		// Token: 0x0402CA4E RID: 182862
		[Token(Token = "0x402CA4E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeGameBankSimpleWithdrawView _bankWithdrawalPrefab;

		// Token: 0x0402CA4F RID: 182863
		[Token(Token = "0x402CA4F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetShopViewModelPlugin;

		// Token: 0x0402CA50 RID: 182864
		[Token(Token = "0x402CA50")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBankWithDrawlViewPrefab;

		// Token: 0x0402CA51 RID: 182865
		[Token(Token = "0x402CA51")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBankViewModelPlugin;

		// Token: 0x0402CA52 RID: 182866
		[Token(Token = "0x402CA52")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
