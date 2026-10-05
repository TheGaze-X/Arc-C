using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005616 RID: 22038
	[Token(Token = "0x2005616")]
	public class RL05ShopDetailConfirmPlugin : RoguelikeShopDetailConfirmPlugin
	{
		// Token: 0x06020550 RID: 132432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020550")]
		[Address(RVA = "0x1A7EF30", Offset = "0x1A7DB30", VA = "0x181A7EF30", Slot = "4")]
		public override string OverrideConfirmText(RoguelikeGoodsViewModel viewModel)
		{
			return null;
		}

		// Token: 0x06020551 RID: 132433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020551")]
		[Address(RVA = "0x1A7F000", Offset = "0x1A7DC00", VA = "0x181A7F000")]
		public RL05ShopDetailConfirmPlugin()
		{
		}

		// Token: 0x0402BC34 RID: 179252
		[Token(Token = "0x402BC34")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideConfirmText;

		// Token: 0x0402BC35 RID: 179253
		[Token(Token = "0x402BC35")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
