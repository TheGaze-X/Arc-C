using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BD7 RID: 23511
	[Token(Token = "0x2005BD7")]
	public abstract class TemplateCharSelectDetailView : TemplateCharSelectSubViewBase
	{
		// Token: 0x0602217B RID: 139643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602217B")]
		[Address(RVA = "0x1C9CB10", Offset = "0x1C9B710", VA = "0x181C9CB10", Slot = "8")]
		public sealed override void RenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x0602217C RID: 139644
		[Token(Token = "0x602217C")]
		public abstract TemplateCharSelectDetailViewModelCreator GetModelCreator();

		// Token: 0x0602217D RID: 139645
		[Token(Token = "0x602217D")]
		protected abstract void OnRenderViewModel();

		// Token: 0x0602217E RID: 139646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602217E")]
		[Address(RVA = "0x1C9CBA0", Offset = "0x1C9B7A0", VA = "0x181C9CBA0")]
		protected void SetCharAttribute(int key, ValueBundle value)
		{
		}

		// Token: 0x0602217F RID: 139647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602217F")]
		[Address(RVA = "0x1C9CED0", Offset = "0x1C9BAD0", VA = "0x181C9CED0")]
		protected TemplateCharSelectDetailView()
		{
		}

		// Token: 0x0402EC42 RID: 191554
		[Token(Token = "0x402EC42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x0402EC43 RID: 191555
		[Token(Token = "0x402EC43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCharAttribute;

		// Token: 0x0402EC44 RID: 191556
		[Token(Token = "0x402EC44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
