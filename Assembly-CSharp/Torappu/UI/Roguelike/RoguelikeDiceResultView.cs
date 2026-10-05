using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051ED RID: 20973
	[Token(Token = "0x20051ED")]
	public abstract class RoguelikeDiceResultView<ViewModel> : RoguelikeDiceResultViewBase where ViewModel : RoguelikeDiceResultViewModel, new()
	{
		// Token: 0x17004850 RID: 18512
		// (get) Token: 0x0601EF7B RID: 126843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004850")]
		public sealed override RoguelikeDiceResultViewBase.DiceResultViewModelCreator diceResultViewModelCreator
		{
			[Token(Token = "0x601EF7B")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EF7C RID: 126844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF7C")]
		public sealed override void Render(RoguelikeDiceResultViewModel model)
		{
		}

		// Token: 0x0601EF7D RID: 126845
		[Token(Token = "0x601EF7D")]
		public abstract void OnRender(ViewModel model);

		// Token: 0x0601EF7E RID: 126846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF7E")]
		protected RoguelikeDiceResultView()
		{
		}

		// Token: 0x040298F1 RID: 170225
		[Token(Token = "0x40298F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_diceResultViewModelCreator;

		// Token: 0x040298F2 RID: 170226
		[Token(Token = "0x40298F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040298F3 RID: 170227
		[Token(Token = "0x40298F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
