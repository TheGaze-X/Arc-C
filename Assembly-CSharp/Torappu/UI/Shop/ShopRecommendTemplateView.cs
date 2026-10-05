using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B2D RID: 23341
	[Token(Token = "0x2005B2D")]
	public abstract class ShopRecommendTemplateView<TModel> : ShopRecommendTemplateViewBase, IHotfixable where TModel : ShopRecommendTemplateViewModelBase
	{
		// Token: 0x06021E3F RID: 138815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E3F")]
		public sealed override void DoRender(ShopRecommendTemplateViewModelBase model)
		{
		}

		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x06021E40 RID: 138816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F41")]
		public override Type templateType
		{
			[Token(Token = "0x6021E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021E41 RID: 138817
		[Token(Token = "0x6021E41")]
		public abstract void Render(TModel viewModel);

		// Token: 0x06021E42 RID: 138818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E42")]
		protected ShopRecommendTemplateView()
		{
		}

		// Token: 0x0402E6F6 RID: 190198
		[Token(Token = "0x402E6F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoRender;

		// Token: 0x0402E6F7 RID: 190199
		[Token(Token = "0x402E6F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_templateType;

		// Token: 0x0402E6F8 RID: 190200
		[Token(Token = "0x402E6F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
