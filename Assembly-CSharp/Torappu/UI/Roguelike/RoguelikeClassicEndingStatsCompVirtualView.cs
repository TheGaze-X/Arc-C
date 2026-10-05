using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200529E RID: 21150
	[Token(Token = "0x200529E")]
	public abstract class RoguelikeClassicEndingStatsCompVirtualView<TView, TModel> : UIRecycleLayoutAdapter.VirtualView<TView> where TView : RoguelikeClassicEndingStatsViewComponent<TModel> where TModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x0601F353 RID: 127827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F353")]
		public RoguelikeClassicEndingStatsCompVirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
		{
		}

		// Token: 0x0601F354 RID: 127828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F354")]
		protected sealed override void OnViewAttached()
		{
		}

		// Token: 0x0601F355 RID: 127829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F355")]
		protected sealed override void OnViewDetached()
		{
		}

		// Token: 0x0601F356 RID: 127830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F356")]
		public sealed override GameObject GetPrefab()
		{
			return null;
		}

		// Token: 0x04029E5A RID: 171610
		[Token(Token = "0x4029E5A")]
		[FieldOffset(Offset = "0x0")]
		protected TView m_prefab;

		// Token: 0x04029E5B RID: 171611
		[Token(Token = "0x4029E5B")]
		[FieldOffset(Offset = "0x0")]
		protected TModel m_viewModel;

		// Token: 0x04029E5C RID: 171612
		[Token(Token = "0x4029E5C")]
		[FieldOffset(Offset = "0x0")]
		protected UIPage m_page;

		// Token: 0x04029E5D RID: 171613
		[Token(Token = "0x4029E5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04029E5E RID: 171614
		[Token(Token = "0x4029E5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x04029E5F RID: 171615
		[Token(Token = "0x4029E5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x04029E60 RID: 171616
		[Token(Token = "0x4029E60")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPrefab;
	}
}
