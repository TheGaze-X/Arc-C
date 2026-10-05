using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052B0 RID: 21168
	[Token(Token = "0x20052B0")]
	public abstract class RoguelikeClassicEndingPageView<TModel> : RoguelikeClassicEndingPageViewBase where TModel : RoguelikeClassicEndingPageViewModel, new()
	{
		// Token: 0x0601F39A RID: 127898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F39A")]
		public override RoguelikeClassicEndingPageViewModel ConstructViewModel()
		{
			return null;
		}

		// Token: 0x0601F39B RID: 127899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F39B")]
		public override void DoRender(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingPageViewModel viewModel)
		{
		}

		// Token: 0x0601F39C RID: 127900
		[Token(Token = "0x601F39C")]
		protected abstract void Render(RoguelikeEndingControllerBase controller, TModel viewModel);

		// Token: 0x0601F39D RID: 127901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F39D")]
		protected RoguelikeClassicEndingPageView()
		{
		}

		// Token: 0x04029EDA RID: 171738
		[Token(Token = "0x4029EDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ConstructViewModel;

		// Token: 0x04029EDB RID: 171739
		[Token(Token = "0x4029EDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x04029EDC RID: 171740
		[Token(Token = "0x4029EDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
