using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B36 RID: 23350
	[Token(Token = "0x2005B36")]
	public class ShopRecommendTemplateReturnSkinViewModel : ShopRecommendTemplateViewModelBase
	{
		// Token: 0x17004F5E RID: 20318
		// (get) Token: 0x06021E71 RID: 138865 RVA: 0x000BBB48 File Offset: 0x000B9D48
		[Token(Token = "0x17004F5E")]
		public long showStartTs
		{
			[Token(Token = "0x6021E71")]
			[Address(RVA = "0x1C6C150", Offset = "0x1C6AD50", VA = "0x181C6C150")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17004F5F RID: 20319
		// (get) Token: 0x06021E72 RID: 138866 RVA: 0x000BBB60 File Offset: 0x000B9D60
		[Token(Token = "0x17004F5F")]
		public long showEndTs
		{
			[Token(Token = "0x6021E72")]
			[Address(RVA = "0x1C6C0F0", Offset = "0x1C6ACF0", VA = "0x181C6C0F0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06021E73 RID: 138867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E73")]
		[Address(RVA = "0x1C6BF90", Offset = "0x1C6AB90", VA = "0x181C6BF90", Slot = "4")]
		public override void LoadData(ShopRecommendItem recommendItem)
		{
		}

		// Token: 0x06021E74 RID: 138868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E74")]
		[Address(RVA = "0x1C6C050", Offset = "0x1C6AC50", VA = "0x181C6C050")]
		public ShopRecommendTemplateReturnSkinViewModel()
		{
		}

		// Token: 0x0402E77A RID: 190330
		[Token(Token = "0x402E77A")]
		[FieldOffset(Offset = "0x18")]
		protected long m_showStartTs;

		// Token: 0x0402E77B RID: 190331
		[Token(Token = "0x402E77B")]
		[FieldOffset(Offset = "0x20")]
		protected long m_showEndTs;

		// Token: 0x0402E77C RID: 190332
		[Token(Token = "0x402E77C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showStartTs;

		// Token: 0x0402E77D RID: 190333
		[Token(Token = "0x402E77D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showEndTs;

		// Token: 0x0402E77E RID: 190334
		[Token(Token = "0x402E77E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402E77F RID: 190335
		[Token(Token = "0x402E77F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
