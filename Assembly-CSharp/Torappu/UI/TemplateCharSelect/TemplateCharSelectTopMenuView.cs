using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BEC RID: 23532
	[Token(Token = "0x2005BEC")]
	public abstract class TemplateCharSelectTopMenuView : TemplateCharSelectSubViewBase
	{
		// Token: 0x060221DF RID: 139743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221DF")]
		[Address(RVA = "0x1C9F440", Offset = "0x1C9E040", VA = "0x181C9F440", Slot = "8")]
		public sealed override void RenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x060221E0 RID: 139744
		[Token(Token = "0x60221E0")]
		protected abstract void OnRenderViewModel(TemplateCharSelectMainViewModel mainViewModel);

		// Token: 0x060221E1 RID: 139745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221E1")]
		[Address(RVA = "0x1C9F4D0", Offset = "0x1C9E0D0", VA = "0x181C9F4D0")]
		protected TemplateCharSelectTopMenuView()
		{
		}

		// Token: 0x0402EC8B RID: 191627
		[Token(Token = "0x402EC8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x0402EC8C RID: 191628
		[Token(Token = "0x402EC8C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
