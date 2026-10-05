using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054F2 RID: 21746
	[Token(Token = "0x20054F2")]
	public abstract class RoguelikeGoodsObjPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004AFC RID: 19196
		// (get) Token: 0x0601FFC2 RID: 131010
		[Token(Token = "0x17004AFC")]
		public abstract RoguelikeShopGoodPluginType pluginType { [Token(Token = "0x601FFC2")] get; }

		// Token: 0x0601FFC3 RID: 131011
		[Token(Token = "0x601FFC3")]
		public abstract bool NeedShowPlugin(RoguelikeGoodsViewModel viewModel);

		// Token: 0x0601FFC4 RID: 131012
		[Token(Token = "0x601FFC4")]
		public abstract void Render(RoguelikeGoodsViewModel viewModel);

		// Token: 0x0601FFC5 RID: 131013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFC5")]
		[Address(RVA = "0x1A1BDB0", Offset = "0x1A1A9B0", VA = "0x181A1BDB0")]
		protected RoguelikeGoodsObjPlugin()
		{
		}

		// Token: 0x0402B285 RID: 176773
		[Token(Token = "0x402B285")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
