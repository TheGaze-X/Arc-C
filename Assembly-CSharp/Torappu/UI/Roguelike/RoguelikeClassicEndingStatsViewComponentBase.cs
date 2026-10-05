using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200529F RID: 21151
	[Token(Token = "0x200529F")]
	public abstract class RoguelikeClassicEndingStatsViewComponentBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x0601F357 RID: 127831
		[Token(Token = "0x1700492F")]
		public abstract Type viewModelType { [Token(Token = "0x601F357")] get; }

		// Token: 0x0601F358 RID: 127832
		[Token(Token = "0x601F358")]
		public abstract UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page);

		// Token: 0x0601F359 RID: 127833
		[Token(Token = "0x601F359")]
		public abstract void DoRender(UIPage page, RoguelikeClassicEndingStatsViewComponentModel viewModel);

		// Token: 0x0601F35A RID: 127834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F35A")]
		[Address(RVA = "0x18E5260", Offset = "0x18E3E60", VA = "0x1818E5260")]
		protected RoguelikeClassicEndingStatsViewComponentBase()
		{
		}

		// Token: 0x04029E61 RID: 171617
		[Token(Token = "0x4029E61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
