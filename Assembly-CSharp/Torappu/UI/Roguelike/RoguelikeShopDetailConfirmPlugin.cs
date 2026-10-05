using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054FA RID: 21754
	[Token(Token = "0x20054FA")]
	public abstract class RoguelikeShopDetailConfirmPlugin : IHotfixable
	{
		// Token: 0x06020000 RID: 131072
		[Token(Token = "0x6020000")]
		public abstract string OverrideConfirmText(RoguelikeGoodsViewModel viewModel);

		// Token: 0x06020001 RID: 131073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020001")]
		[Address(RVA = "0x1A1F850", Offset = "0x1A1E450", VA = "0x181A1F850")]
		protected RoguelikeShopDetailConfirmPlugin()
		{
		}

		// Token: 0x0402B2FB RID: 176891
		[Token(Token = "0x402B2FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
