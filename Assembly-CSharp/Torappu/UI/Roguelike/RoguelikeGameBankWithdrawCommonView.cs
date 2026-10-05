using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054DD RID: 21725
	[Token(Token = "0x20054DD")]
	public abstract class RoguelikeGameBankWithdrawCommonView : RoguelikeGameShopBaseView
	{
		// Token: 0x17004AD8 RID: 19160
		// (get) Token: 0x0601FF46 RID: 130886 RVA: 0x000B3E68 File Offset: 0x000B2068
		[Token(Token = "0x17004AD8")]
		public virtual RoguelikeGameBankWithdrawlViewType viewType
		{
			[Token(Token = "0x601FF46")]
			[Address(RVA = "0x1A0BDB0", Offset = "0x1A0A9B0", VA = "0x181A0BDB0", Slot = "10")]
			get
			{
				return RoguelikeGameBankWithdrawlViewType.NONE;
			}
		}

		// Token: 0x0601FF47 RID: 130887
		[Token(Token = "0x601FF47")]
		public abstract void BindShopController(object bindings);

		// Token: 0x0601FF48 RID: 130888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF48")]
		[Address(RVA = "0x1A0ED60", Offset = "0x1A0D960", VA = "0x181A0ED60")]
		protected RoguelikeGameBankWithdrawCommonView()
		{
		}

		// Token: 0x0402B1B6 RID: 176566
		[Token(Token = "0x402B1B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0402B1B7 RID: 176567
		[Token(Token = "0x402B1B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
