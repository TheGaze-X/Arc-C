using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B2E RID: 23342
	[Token(Token = "0x2005B2E")]
	public abstract class ShopRecommendTemplateViewModelBase : IHotfixable
	{
		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x06021E43 RID: 138819 RVA: 0x000BB9E0 File Offset: 0x000B9BE0
		[Token(Token = "0x17004F42")]
		public ShopRecommendTemplateType templateType
		{
			[Token(Token = "0x6021E43")]
			[Address(RVA = "0x1C6C740", Offset = "0x1C6B340", VA = "0x181C6C740")]
			get
			{
				return ShopRecommendTemplateType.DEFAULT;
			}
		}

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x06021E44 RID: 138820 RVA: 0x000BB9F8 File Offset: 0x000B9BF8
		[Token(Token = "0x17004F43")]
		public int sortId
		{
			[Token(Token = "0x6021E44")]
			[Address(RVA = "0x1C6C6E0", Offset = "0x1C6B2E0", VA = "0x181C6C6E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021E45 RID: 138821
		[Token(Token = "0x6021E45")]
		public abstract void LoadData(ShopRecommendItem recommendItem);

		// Token: 0x06021E46 RID: 138822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E46")]
		[Address(RVA = "0x1C6C680", Offset = "0x1C6B280", VA = "0x181C6C680")]
		protected ShopRecommendTemplateViewModelBase()
		{
		}

		// Token: 0x0402E6F9 RID: 190201
		[Token(Token = "0x402E6F9")]
		[FieldOffset(Offset = "0x10")]
		protected ShopRecommendTemplateType m_templateType;

		// Token: 0x0402E6FA RID: 190202
		[Token(Token = "0x402E6FA")]
		[FieldOffset(Offset = "0x14")]
		protected int m_sortId;

		// Token: 0x0402E6FB RID: 190203
		[Token(Token = "0x402E6FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_templateType;

		// Token: 0x0402E6FC RID: 190204
		[Token(Token = "0x402E6FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402E6FD RID: 190205
		[Token(Token = "0x402E6FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
