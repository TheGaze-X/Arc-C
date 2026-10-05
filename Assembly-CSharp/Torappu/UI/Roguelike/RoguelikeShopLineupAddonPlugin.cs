using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005505 RID: 21765
	[Token(Token = "0x2005505")]
	public abstract class RoguelikeShopLineupAddonPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B18 RID: 19224
		// (get) Token: 0x06020034 RID: 131124
		[Token(Token = "0x17004B18")]
		public abstract RoguelikeShopLineupView.LineupLayer layer { [Token(Token = "0x6020034")] get; }

		// Token: 0x06020035 RID: 131125
		[Token(Token = "0x6020035")]
		public abstract void Render(RoguelikeGameShopViewModel shopViewModel);

		// Token: 0x06020036 RID: 131126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020036")]
		[Address(RVA = "0x1A22E60", Offset = "0x1A21A60", VA = "0x181A22E60")]
		protected RoguelikeShopLineupAddonPlugin()
		{
		}

		// Token: 0x0402B375 RID: 177013
		[Token(Token = "0x402B375")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
