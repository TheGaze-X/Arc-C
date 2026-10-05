using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200550B RID: 21771
	[Token(Token = "0x200550B")]
	public class RoguelikeShopLineupControllerBindings : IHotfixable
	{
		// Token: 0x17004B1B RID: 19227
		// (get) Token: 0x0602004E RID: 131150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B1B")]
		public List<RoguelikeGoodsObjPlugin> goodPlugins
		{
			[Token(Token = "0x602004E")]
			[Address(RVA = "0x1A24180", Offset = "0x1A22D80", VA = "0x181A24180")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x0602004F RID: 131151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B1C")]
		public List<RoguelikeShopLineupAddonPlugin> addonPlugins
		{
			[Token(Token = "0x602004F")]
			[Address(RVA = "0x1A24120", Offset = "0x1A22D20", VA = "0x181A24120")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020050 RID: 131152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020050")]
		[Address(RVA = "0x1A240C0", Offset = "0x1A22CC0", VA = "0x181A240C0")]
		private RoguelikeShopLineupControllerBindings()
		{
		}

		// Token: 0x06020051 RID: 131153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020051")]
		[Address(RVA = "0x1A23F50", Offset = "0x1A22B50", VA = "0x181A23F50")]
		public void OnGoodsClicked(RoguelikeGoodsViewModel model)
		{
		}

		// Token: 0x06020052 RID: 131154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020052")]
		[Address(RVA = "0x1A23EE0", Offset = "0x1A22AE0", VA = "0x181A23EE0")]
		public void OnBankClicked()
		{
		}

		// Token: 0x06020053 RID: 131155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020053")]
		[Address(RVA = "0x1A23FD0", Offset = "0x1A22BD0", VA = "0x181A23FD0")]
		public void OnLockSlotClicked(RoguelikeGoodsViewModel model)
		{
		}

		// Token: 0x06020054 RID: 131156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020054")]
		[Address(RVA = "0x1A24050", Offset = "0x1A22C50", VA = "0x181A24050")]
		public void OnRefresh()
		{
		}

		// Token: 0x0402B3A9 RID: 177065
		[Token(Token = "0x402B3A9")]
		[FieldOffset(Offset = "0x10")]
		private Action<RoguelikeGoodsViewModel> m_onGoodsClicked;

		// Token: 0x0402B3AA RID: 177066
		[Token(Token = "0x402B3AA")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onBankClicked;

		// Token: 0x0402B3AB RID: 177067
		[Token(Token = "0x402B3AB")]
		[FieldOffset(Offset = "0x20")]
		private Action<RoguelikeGoodsViewModel> m_onLockSlotClicked;

		// Token: 0x0402B3AC RID: 177068
		[Token(Token = "0x402B3AC")]
		[FieldOffset(Offset = "0x28")]
		private List<RoguelikeGoodsObjPlugin> m_goodPlugins;

		// Token: 0x0402B3AD RID: 177069
		[Token(Token = "0x402B3AD")]
		[FieldOffset(Offset = "0x30")]
		private List<RoguelikeShopLineupAddonPlugin> m_addonPlugins;

		// Token: 0x0402B3AE RID: 177070
		[Token(Token = "0x402B3AE")]
		[FieldOffset(Offset = "0x38")]
		private Action m_onRefresh;

		// Token: 0x0402B3AF RID: 177071
		[Token(Token = "0x402B3AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_goodPlugins;

		// Token: 0x0402B3B0 RID: 177072
		[Token(Token = "0x402B3B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_addonPlugins;

		// Token: 0x0402B3B1 RID: 177073
		[Token(Token = "0x402B3B1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B3B2 RID: 177074
		[Token(Token = "0x402B3B2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGoodsClicked;

		// Token: 0x0402B3B3 RID: 177075
		[Token(Token = "0x402B3B3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBankClicked;

		// Token: 0x0402B3B4 RID: 177076
		[Token(Token = "0x402B3B4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnLockSlotClicked;

		// Token: 0x0402B3B5 RID: 177077
		[Token(Token = "0x402B3B5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRefresh;

		// Token: 0x0200550C RID: 21772
		[Token(Token = "0x200550C")]
		public struct Builder
		{
			// Token: 0x06020055 RID: 131157 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020055")]
			[Address(RVA = "0x1A163D0", Offset = "0x1A14FD0", VA = "0x181A163D0")]
			public RoguelikeShopLineupControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B3B6 RID: 177078
			[Token(Token = "0x402B3B6")]
			[FieldOffset(Offset = "0x0")]
			public Action<RoguelikeGoodsViewModel> onGoodsClicked;

			// Token: 0x0402B3B7 RID: 177079
			[Token(Token = "0x402B3B7")]
			[FieldOffset(Offset = "0x8")]
			public Action onBankClicked;

			// Token: 0x0402B3B8 RID: 177080
			[Token(Token = "0x402B3B8")]
			[FieldOffset(Offset = "0x10")]
			public Action<RoguelikeGoodsViewModel> onLockSlotClicked;

			// Token: 0x0402B3B9 RID: 177081
			[Token(Token = "0x402B3B9")]
			[FieldOffset(Offset = "0x18")]
			public List<RoguelikeGoodsObjPlugin> goodPlugins;

			// Token: 0x0402B3BA RID: 177082
			[Token(Token = "0x402B3BA")]
			[FieldOffset(Offset = "0x20")]
			public List<RoguelikeShopLineupAddonPlugin> addonPlugins;

			// Token: 0x0402B3BB RID: 177083
			[Token(Token = "0x402B3BB")]
			[FieldOffset(Offset = "0x28")]
			public Action onRefresh;
		}
	}
}
