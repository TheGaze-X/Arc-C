using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BE6 RID: 23526
	[Token(Token = "0x2005BE6")]
	public abstract class TemplateCharSelectShuffleView : TemplateCharSelectSubViewBase
	{
		// Token: 0x060221BD RID: 139709
		[Token(Token = "0x60221BD")]
		public abstract TemplateCharSelectShuffleViewModelCreator GetModelCreator();

		// Token: 0x060221BE RID: 139710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221BE")]
		[Address(RVA = "0x1C9EE00", Offset = "0x1C9DA00", VA = "0x181C9EE00", Slot = "8")]
		public sealed override void RenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x060221BF RID: 139711
		[Token(Token = "0x60221BF")]
		protected abstract void OnRenderViewModel(TemplateCharSelectMainViewModel mainViewModel);

		// Token: 0x060221C0 RID: 139712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221C0")]
		[Address(RVA = "0x1C9EE90", Offset = "0x1C9DA90", VA = "0x181C9EE90")]
		protected TemplateCharSelectShuffleView()
		{
		}

		// Token: 0x0402EC73 RID: 191603
		[Token(Token = "0x402EC73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x0402EC74 RID: 191604
		[Token(Token = "0x402EC74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
