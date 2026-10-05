using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005508 RID: 21768
	[Token(Token = "0x2005508")]
	public class RoguelikeShopLineupRecycleAddonView : RoguelikeShopLineupAddonView
	{
		// Token: 0x06020044 RID: 131140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020044")]
		[Address(RVA = "0x1A241E0", Offset = "0x1A22DE0", VA = "0x181A241E0", Slot = "4")]
		protected override void OnDataChange(RoguelikeGameShopViewModel model)
		{
		}

		// Token: 0x06020045 RID: 131141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020045")]
		[Address(RVA = "0x1A24300", Offset = "0x1A22F00", VA = "0x181A24300")]
		public RoguelikeShopLineupRecycleAddonView()
		{
		}

		// Token: 0x0402B394 RID: 177044
		[Token(Token = "0x402B394")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _recycleCountText;

		// Token: 0x0402B395 RID: 177045
		[Token(Token = "0x402B395")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDataChange;

		// Token: 0x0402B396 RID: 177046
		[Token(Token = "0x402B396")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
