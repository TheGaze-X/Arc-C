using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BDF RID: 23519
	[Token(Token = "0x2005BDF")]
	public abstract class TemplateCharSelectEnsureView : TemplateCharSelectSubViewBase
	{
		// Token: 0x06022194 RID: 139668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022194")]
		[Address(RVA = "0x1C9CFE0", Offset = "0x1C9BBE0", VA = "0x181C9CFE0", Slot = "8")]
		public sealed override void RenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x06022195 RID: 139669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022195")]
		[Address(RVA = "0x1C9CF80", Offset = "0x1C9BB80", VA = "0x181C9CF80", Slot = "10")]
		protected virtual void OnRenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x06022196 RID: 139670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022196")]
		[Address(RVA = "0x1C9D070", Offset = "0x1C9BC70", VA = "0x181C9D070")]
		protected TemplateCharSelectEnsureView()
		{
		}

		// Token: 0x0402EC56 RID: 191574
		[Token(Token = "0x402EC56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderViewModel;

		// Token: 0x0402EC57 RID: 191575
		[Token(Token = "0x402EC57")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0402EC58 RID: 191576
		[Token(Token = "0x402EC58")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
