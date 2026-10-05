using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005717 RID: 22295
	[Token(Token = "0x2005717")]
	public class RL04ShopLineupRecycleAddonPlugin : RoguelikeShopLineupAddonPlugin
	{
		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x06020AF0 RID: 133872 RVA: 0x000B6D78 File Offset: 0x000B4F78
		[Token(Token = "0x17004CA6")]
		public override RoguelikeShopLineupView.LineupLayer layer
		{
			[Token(Token = "0x6020AF0")]
			[Address(RVA = "0x1B15E50", Offset = "0x1B14A50", VA = "0x181B15E50", Slot = "4")]
			get
			{
				return RoguelikeShopLineupView.LineupLayer.BUY;
			}
		}

		// Token: 0x06020AF1 RID: 133873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AF1")]
		[Address(RVA = "0x1B15CE0", Offset = "0x1B148E0", VA = "0x181B15CE0", Slot = "5")]
		public override void Render(RoguelikeGameShopViewModel shopViewModel)
		{
		}

		// Token: 0x06020AF2 RID: 133874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AF2")]
		[Address(RVA = "0x1B15DF0", Offset = "0x1B149F0", VA = "0x181B15DF0")]
		public RL04ShopLineupRecycleAddonPlugin()
		{
		}

		// Token: 0x0402C5B1 RID: 181681
		[Token(Token = "0x402C5B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyRecyclePanel;

		// Token: 0x0402C5B2 RID: 181682
		[Token(Token = "0x402C5B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_layer;

		// Token: 0x0402C5B3 RID: 181683
		[Token(Token = "0x402C5B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C5B4 RID: 181684
		[Token(Token = "0x402C5B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
