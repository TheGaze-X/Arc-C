using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Shop;
using XLua;

namespace Torappu.EventTrack
{
	// Token: 0x02002023 RID: 8227
	[Token(Token = "0x2002023")]
	public class EventLogShopTracerWithCache : Singleton<EventLogShopTracerWithCache>
	{
		// Token: 0x0600CAA8 RID: 51880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAA8")]
		[Address(RVA = "0x34C0230", Offset = "0x34BEE30", VA = "0x1834C0230")]
		private EventLogShopTracerWithCache()
		{
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x0600CAA9 RID: 51881 RVA: 0x000496B0 File Offset: 0x000478B0
		[Token(Token = "0x170017F6")]
		public long enterTs
		{
			[Token(Token = "0x600CAA9")]
			[Address(RVA = "0x34C0300", Offset = "0x34BEF00", VA = "0x1834C0300")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x0600CAAA RID: 51882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAAA")]
		[Address(RVA = "0x34BF770", Offset = "0x34BE370", VA = "0x1834BF770")]
		public void Clear()
		{
		}

		// Token: 0x0600CAAB RID: 51883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAAB")]
		[Address(RVA = "0x34BF830", Offset = "0x34BE430", VA = "0x1834BF830")]
		public void RecordHomeBannerClicked(ShopType shopType, string goodId)
		{
		}

		// Token: 0x0600CAAC RID: 51884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAAC")]
		[Address(RVA = "0x34BFFF0", Offset = "0x34BEBF0", VA = "0x1834BFFF0")]
		public void RecordShopTitleClicked(ShopType shopType, ShopPage.Referrer clickRef)
		{
		}

		// Token: 0x0600CAAD RID: 51885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAAD")]
		[Address(RVA = "0x34BFDF0", Offset = "0x34BE9F0", VA = "0x1834BFDF0")]
		public void RecordShopTabClicked(string viewTab, ShopPage.Referrer clickRef)
		{
		}

		// Token: 0x0600CAAE RID: 51886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAAE")]
		[Address(RVA = "0x34BFA20", Offset = "0x34BE620", VA = "0x1834BFA20")]
		public void RecordShopItemClicked(string goodId)
		{
		}

		// Token: 0x0600CAAF RID: 51887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAAF")]
		[Address(RVA = "0x34BFBB0", Offset = "0x34BE7B0", VA = "0x1834BFBB0")]
		public void RecordShopItemShowed(string goodId, int remainCount)
		{
		}

		// Token: 0x0600CAB0 RID: 51888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB0")]
		[Address(RVA = "0x34BFD30", Offset = "0x34BE930", VA = "0x1834BFD30")]
		public void RecordShopSkinBuyClicked()
		{
		}

		// Token: 0x0600CAB1 RID: 51889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CAB1")]
		[Address(RVA = "0x34BF940", Offset = "0x34BE540", VA = "0x1834BF940")]
		public void RecordShopBlindBoxItemDetailClicked(List<string> skinBoxList, bool isObtainable, string boxId)
		{
		}

		// Token: 0x0400D458 RID: 54360
		[Token(Token = "0x400D458")]
		private const string GP_SHOP_TAB_ALL = "all";

		// Token: 0x0400D459 RID: 54361
		[Token(Token = "0x400D459")]
		[FieldOffset(Offset = "0x10")]
		private ListSet<string> m_goodShowedSet;

		// Token: 0x0400D45A RID: 54362
		[Token(Token = "0x400D45A")]
		[FieldOffset(Offset = "0x18")]
		private ShopType m_shopType;

		// Token: 0x0400D45B RID: 54363
		[Token(Token = "0x400D45B")]
		[FieldOffset(Offset = "0x20")]
		private long m_enterTs;

		// Token: 0x0400D45C RID: 54364
		[Token(Token = "0x400D45C")]
		[FieldOffset(Offset = "0x28")]
		private string m_viewTab;

		// Token: 0x0400D45D RID: 54365
		[Token(Token = "0x400D45D")]
		[FieldOffset(Offset = "0x30")]
		private ShopPage.Referrer m_clickRef;

		// Token: 0x0400D45E RID: 54366
		[Token(Token = "0x400D45E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400D45F RID: 54367
		[Token(Token = "0x400D45F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enterTs;

		// Token: 0x0400D460 RID: 54368
		[Token(Token = "0x400D460")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400D461 RID: 54369
		[Token(Token = "0x400D461")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RecordHomeBannerClicked;

		// Token: 0x0400D462 RID: 54370
		[Token(Token = "0x400D462")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RecordShopTitleClicked;

		// Token: 0x0400D463 RID: 54371
		[Token(Token = "0x400D463")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RecordShopTabClicked;

		// Token: 0x0400D464 RID: 54372
		[Token(Token = "0x400D464")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RecordShopItemClicked;

		// Token: 0x0400D465 RID: 54373
		[Token(Token = "0x400D465")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RecordShopItemShowed;

		// Token: 0x0400D466 RID: 54374
		[Token(Token = "0x400D466")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RecordShopSkinBuyClicked;

		// Token: 0x0400D467 RID: 54375
		[Token(Token = "0x400D467")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RecordShopBlindBoxItemDetailClicked;
	}
}
