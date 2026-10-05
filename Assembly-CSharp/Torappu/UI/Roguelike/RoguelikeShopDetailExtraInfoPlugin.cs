using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054FB RID: 21755
	[Token(Token = "0x20054FB")]
	public abstract class RoguelikeShopDetailExtraInfoPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020002 RID: 131074
		[Token(Token = "0x6020002")]
		public abstract RoguelikeShopDetailExtraInfo GetExtraInfo(RoguelikeGoodsViewModel viewModel);

		// Token: 0x06020003 RID: 131075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020003")]
		[Address(RVA = "0x1A1FB10", Offset = "0x1A1E710", VA = "0x181A1FB10")]
		protected RoguelikeShopDetailExtraInfoPlugin()
		{
		}

		// Token: 0x0402B2FC RID: 176892
		[Token(Token = "0x402B2FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
