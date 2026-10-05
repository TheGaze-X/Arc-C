using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B32 RID: 23346
	[Token(Token = "0x2005B32")]
	public class ShopRecommendTemplateNormalGiftViewModel : ShopRecommendTemplateViewModelBase, IHotfixable
	{
		// Token: 0x17004F4E RID: 20302
		// (get) Token: 0x06021E58 RID: 138840 RVA: 0x000BBA88 File Offset: 0x000B9C88
		[Token(Token = "0x17004F4E")]
		public long showStartTs
		{
			[Token(Token = "0x6021E58")]
			[Address(RVA = "0x1C6A290", Offset = "0x1C68E90", VA = "0x181C6A290")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17004F4F RID: 20303
		// (get) Token: 0x06021E59 RID: 138841 RVA: 0x000BBAA0 File Offset: 0x000B9CA0
		[Token(Token = "0x17004F4F")]
		public long showEndTs
		{
			[Token(Token = "0x6021E59")]
			[Address(RVA = "0x1C6A230", Offset = "0x1C68E30", VA = "0x181C6A230")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17004F50 RID: 20304
		// (get) Token: 0x06021E5A RID: 138842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F50")]
		public string packName
		{
			[Token(Token = "0x6021E5A")]
			[Address(RVA = "0x1C6A150", Offset = "0x1C68D50", VA = "0x181C6A150")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F51 RID: 20305
		// (get) Token: 0x06021E5B RID: 138843 RVA: 0x000BBAB8 File Offset: 0x000B9CB8
		[Token(Token = "0x17004F51")]
		public ShopCashInfo priceInfo
		{
			[Token(Token = "0x6021E5B")]
			[Address(RVA = "0x1C6A1B0", Offset = "0x1C68DB0", VA = "0x181C6A1B0")]
			get
			{
				return default(ShopCashInfo);
			}
		}

		// Token: 0x17004F52 RID: 20306
		// (get) Token: 0x06021E5C RID: 138844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F52")]
		public string color
		{
			[Token(Token = "0x6021E5C")]
			[Address(RVA = "0x1C6A030", Offset = "0x1C68C30", VA = "0x181C6A030")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F53 RID: 20307
		// (get) Token: 0x06021E5D RID: 138845 RVA: 0x000BBAD0 File Offset: 0x000B9CD0
		[Token(Token = "0x17004F53")]
		public bool haveMark
		{
			[Token(Token = "0x6021E5D")]
			[Address(RVA = "0x1C6A090", Offset = "0x1C68C90", VA = "0x181C6A090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004F54 RID: 20308
		// (get) Token: 0x06021E5E RID: 138846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F54")]
		public string logoId
		{
			[Token(Token = "0x6021E5E")]
			[Address(RVA = "0x1C6A0F0", Offset = "0x1C68CF0", VA = "0x181C6A0F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F55 RID: 20309
		// (get) Token: 0x06021E5F RID: 138847 RVA: 0x000BBAE8 File Offset: 0x000B9CE8
		[Token(Token = "0x17004F55")]
		public int availCount
		{
			[Token(Token = "0x6021E5F")]
			[Address(RVA = "0x1C69FD0", Offset = "0x1C68BD0", VA = "0x181C69FD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021E60 RID: 138848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E60")]
		[Address(RVA = "0x1C69DD0", Offset = "0x1C689D0", VA = "0x181C69DD0", Slot = "4")]
		public override void LoadData(ShopRecommendItem recommendItem)
		{
		}

		// Token: 0x06021E61 RID: 138849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E61")]
		[Address(RVA = "0x1C69F30", Offset = "0x1C68B30", VA = "0x181C69F30")]
		public ShopRecommendTemplateNormalGiftViewModel()
		{
		}

		// Token: 0x0402E738 RID: 190264
		[Token(Token = "0x402E738")]
		[FieldOffset(Offset = "0x18")]
		protected long m_showStartTs;

		// Token: 0x0402E739 RID: 190265
		[Token(Token = "0x402E739")]
		[FieldOffset(Offset = "0x20")]
		protected long m_showEndTs;

		// Token: 0x0402E73A RID: 190266
		[Token(Token = "0x402E73A")]
		[FieldOffset(Offset = "0x28")]
		private string m_packName;

		// Token: 0x0402E73B RID: 190267
		[Token(Token = "0x402E73B")]
		[FieldOffset(Offset = "0x30")]
		private ShopCashInfo m_priceInfo;

		// Token: 0x0402E73C RID: 190268
		[Token(Token = "0x402E73C")]
		[FieldOffset(Offset = "0x40")]
		private string m_color;

		// Token: 0x0402E73D RID: 190269
		[Token(Token = "0x402E73D")]
		[FieldOffset(Offset = "0x48")]
		private bool m_haveMark;

		// Token: 0x0402E73E RID: 190270
		[Token(Token = "0x402E73E")]
		[FieldOffset(Offset = "0x50")]
		private string m_logoId;

		// Token: 0x0402E73F RID: 190271
		[Token(Token = "0x402E73F")]
		[FieldOffset(Offset = "0x58")]
		private int m_availCount;

		// Token: 0x0402E740 RID: 190272
		[Token(Token = "0x402E740")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showStartTs;

		// Token: 0x0402E741 RID: 190273
		[Token(Token = "0x402E741")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showEndTs;

		// Token: 0x0402E742 RID: 190274
		[Token(Token = "0x402E742")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_packName;

		// Token: 0x0402E743 RID: 190275
		[Token(Token = "0x402E743")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_priceInfo;

		// Token: 0x0402E744 RID: 190276
		[Token(Token = "0x402E744")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x0402E745 RID: 190277
		[Token(Token = "0x402E745")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_haveMark;

		// Token: 0x0402E746 RID: 190278
		[Token(Token = "0x402E746")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_logoId;

		// Token: 0x0402E747 RID: 190279
		[Token(Token = "0x402E747")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_availCount;

		// Token: 0x0402E748 RID: 190280
		[Token(Token = "0x402E748")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402E749 RID: 190281
		[Token(Token = "0x402E749")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
