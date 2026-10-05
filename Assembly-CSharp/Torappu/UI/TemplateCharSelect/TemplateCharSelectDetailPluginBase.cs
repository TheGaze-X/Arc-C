using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BD8 RID: 23512
	[Token(Token = "0x2005BD8")]
	public abstract class TemplateCharSelectDetailPluginBase<T> : TemplateCharSelectDetailPlugin where T : TemplateCharSelectDetailViewModel
	{
		// Token: 0x17004FCE RID: 20430
		// (get) Token: 0x06022180 RID: 139648
		// (set) Token: 0x06022181 RID: 139649
		[Token(Token = "0x17004FCE")]
		public abstract Action<T> OnClickDetail { [Token(Token = "0x6022180")] get; [Token(Token = "0x6022181")] set; }

		// Token: 0x17004FCF RID: 20431
		// (get) Token: 0x06022182 RID: 139650
		// (set) Token: 0x06022183 RID: 139651
		[Token(Token = "0x17004FCF")]
		public abstract Action<int, ValueBundle> OnSetCharAttribute { [Token(Token = "0x6022182")] get; [Token(Token = "0x6022183")] set; }

		// Token: 0x06022184 RID: 139652
		[Token(Token = "0x6022184")]
		protected abstract void RenderPanels(T viewModel);

		// Token: 0x06022185 RID: 139653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022185")]
		protected TemplateCharSelectDetailPluginBase()
		{
		}

		// Token: 0x0402EC45 RID: 191557
		[Token(Token = "0x402EC45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
