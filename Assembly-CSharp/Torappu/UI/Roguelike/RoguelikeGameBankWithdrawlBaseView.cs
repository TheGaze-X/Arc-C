using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054DC RID: 21724
	[Token(Token = "0x20054DC")]
	public abstract class RoguelikeGameBankWithdrawlBaseView<TControllerBindings> : RoguelikeGameBankWithdrawCommonView where TControllerBindings : class
	{
		// Token: 0x0601FF42 RID: 130882 RVA: 0x000B3E50 File Offset: 0x000B2050
		[Token(Token = "0x601FF42")]
		public override RoguelikeGameShopStatusEnum GetShopStatus()
		{
			return RoguelikeGameShopStatusEnum.NONE;
		}

		// Token: 0x0601FF43 RID: 130883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF43")]
		public sealed override void BindShopController(object bindings)
		{
		}

		// Token: 0x0601FF44 RID: 130884
		[Token(Token = "0x601FF44")]
		protected abstract void BindShopController(TControllerBindings bindings);

		// Token: 0x0601FF45 RID: 130885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF45")]
		protected RoguelikeGameBankWithdrawlBaseView()
		{
		}

		// Token: 0x0402B1B2 RID: 176562
		[Token(Token = "0x402B1B2")]
		[FieldOffset(Offset = "0x0")]
		protected TControllerBindings m_controllerBindings;

		// Token: 0x0402B1B3 RID: 176563
		[Token(Token = "0x402B1B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetShopStatus;

		// Token: 0x0402B1B4 RID: 176564
		[Token(Token = "0x402B1B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_BindShopController;

		// Token: 0x0402B1B5 RID: 176565
		[Token(Token = "0x402B1B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
