using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B34 RID: 23348
	[Token(Token = "0x2005B34")]
	public class ShopRecommendTemplateNormalSkinViewModel : ShopRecommendTemplateViewModelBase, IHotfixable
	{
		// Token: 0x17004F56 RID: 20310
		// (get) Token: 0x06021E65 RID: 138853 RVA: 0x000BBB18 File Offset: 0x000B9D18
		[Token(Token = "0x17004F56")]
		public long showStartTs
		{
			[Token(Token = "0x6021E65")]
			[Address(RVA = "0x1C6B270", Offset = "0x1C69E70", VA = "0x181C6B270")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17004F57 RID: 20311
		// (get) Token: 0x06021E66 RID: 138854 RVA: 0x000BBB30 File Offset: 0x000B9D30
		[Token(Token = "0x17004F57")]
		public long showEndTs
		{
			[Token(Token = "0x6021E66")]
			[Address(RVA = "0x1C6B210", Offset = "0x1C69E10", VA = "0x181C6B210")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17004F58 RID: 20312
		// (get) Token: 0x06021E67 RID: 138855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F58")]
		public string seriesName
		{
			[Token(Token = "0x6021E67")]
			[Address(RVA = "0x1C6B1B0", Offset = "0x1C69DB0", VA = "0x181C6B1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F59 RID: 20313
		// (get) Token: 0x06021E68 RID: 138856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F59")]
		public string brandIconId
		{
			[Token(Token = "0x6021E68")]
			[Address(RVA = "0x1C6B090", Offset = "0x1C69C90", VA = "0x181C6B090")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F5A RID: 20314
		// (get) Token: 0x06021E69 RID: 138857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F5A")]
		public string colorBack
		{
			[Token(Token = "0x6021E69")]
			[Address(RVA = "0x1C6B0F0", Offset = "0x1C69CF0", VA = "0x181C6B0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F5B RID: 20315
		// (get) Token: 0x06021E6A RID: 138858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F5B")]
		public string colorText
		{
			[Token(Token = "0x6021E6A")]
			[Address(RVA = "0x1C6B150", Offset = "0x1C69D50", VA = "0x181C6B150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F5C RID: 20316
		// (get) Token: 0x06021E6B RID: 138859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F5C")]
		public string text
		{
			[Token(Token = "0x6021E6B")]
			[Address(RVA = "0x1C6B330", Offset = "0x1C69F30", VA = "0x181C6B330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F5D RID: 20317
		// (get) Token: 0x06021E6C RID: 138860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F5D")]
		public List<string> skinNames
		{
			[Token(Token = "0x6021E6C")]
			[Address(RVA = "0x1C6B2D0", Offset = "0x1C69ED0", VA = "0x181C6B2D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021E6D RID: 138861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E6D")]
		[Address(RVA = "0x1C6AC80", Offset = "0x1C69880", VA = "0x181C6AC80", Slot = "4")]
		public override void LoadData(ShopRecommendItem recommendItem)
		{
		}

		// Token: 0x06021E6E RID: 138862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E6E")]
		[Address(RVA = "0x1C6AFF0", Offset = "0x1C69BF0", VA = "0x181C6AFF0")]
		public ShopRecommendTemplateNormalSkinViewModel()
		{
		}

		// Token: 0x0402E760 RID: 190304
		[Token(Token = "0x402E760")]
		[FieldOffset(Offset = "0x18")]
		protected long m_showStartTs;

		// Token: 0x0402E761 RID: 190305
		[Token(Token = "0x402E761")]
		[FieldOffset(Offset = "0x20")]
		protected long m_showEndTs;

		// Token: 0x0402E762 RID: 190306
		[Token(Token = "0x402E762")]
		[FieldOffset(Offset = "0x28")]
		private string m_seriesName;

		// Token: 0x0402E763 RID: 190307
		[Token(Token = "0x402E763")]
		[FieldOffset(Offset = "0x30")]
		private string m_brandIconId;

		// Token: 0x0402E764 RID: 190308
		[Token(Token = "0x402E764")]
		[FieldOffset(Offset = "0x38")]
		private string m_colorBack;

		// Token: 0x0402E765 RID: 190309
		[Token(Token = "0x402E765")]
		[FieldOffset(Offset = "0x40")]
		private string m_colorText;

		// Token: 0x0402E766 RID: 190310
		[Token(Token = "0x402E766")]
		[FieldOffset(Offset = "0x48")]
		private string m_text;

		// Token: 0x0402E767 RID: 190311
		[Token(Token = "0x402E767")]
		[FieldOffset(Offset = "0x50")]
		private List<string> m_skinNames;

		// Token: 0x0402E768 RID: 190312
		[Token(Token = "0x402E768")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showStartTs;

		// Token: 0x0402E769 RID: 190313
		[Token(Token = "0x402E769")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showEndTs;

		// Token: 0x0402E76A RID: 190314
		[Token(Token = "0x402E76A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_seriesName;

		// Token: 0x0402E76B RID: 190315
		[Token(Token = "0x402E76B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_brandIconId;

		// Token: 0x0402E76C RID: 190316
		[Token(Token = "0x402E76C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_colorBack;

		// Token: 0x0402E76D RID: 190317
		[Token(Token = "0x402E76D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_colorText;

		// Token: 0x0402E76E RID: 190318
		[Token(Token = "0x402E76E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_text;

		// Token: 0x0402E76F RID: 190319
		[Token(Token = "0x402E76F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_skinNames;

		// Token: 0x0402E770 RID: 190320
		[Token(Token = "0x402E770")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402E771 RID: 190321
		[Token(Token = "0x402E771")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
