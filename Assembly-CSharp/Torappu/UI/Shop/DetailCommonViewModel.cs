using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A81 RID: 23169
	[Token(Token = "0x2005A81")]
	public class DetailCommonViewModel : IHotfixable
	{
		// Token: 0x17004F0C RID: 20236
		// (get) Token: 0x06021B50 RID: 138064 RVA: 0x000BB1D0 File Offset: 0x000B93D0
		// (set) Token: 0x06021B51 RID: 138065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F0C")]
		public ShopDetailPriceType priceType
		{
			[Token(Token = "0x6021B50")]
			[Address(RVA = "0x1C18610", Offset = "0x1C17210", VA = "0x181C18610")]
			get
			{
				return ShopDetailPriceType.CASH;
			}
			[Token(Token = "0x6021B51")]
			[Address(RVA = "0x1C186F0", Offset = "0x1C172F0", VA = "0x181C186F0")]
			set
			{
			}
		}

		// Token: 0x17004F0D RID: 20237
		// (get) Token: 0x06021B52 RID: 138066 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021B53 RID: 138067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F0D")]
		public UIItemViewModel priceItem
		{
			[Token(Token = "0x6021B52")]
			[Address(RVA = "0x1C18550", Offset = "0x1C17150", VA = "0x181C18550")]
			get
			{
				return null;
			}
			[Token(Token = "0x6021B53")]
			[Address(RVA = "0x1C18670", Offset = "0x1C17270", VA = "0x181C18670")]
			set
			{
			}
		}

		// Token: 0x06021B54 RID: 138068 RVA: 0x000BB1E8 File Offset: 0x000B93E8
		[Token(Token = "0x6021B54")]
		[Address(RVA = "0x1C18400", Offset = "0x1C17000", VA = "0x181C18400")]
		public ShopCashInfo GetCashInfo()
		{
			return default(ShopCashInfo);
		}

		// Token: 0x06021B55 RID: 138069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B55")]
		[Address(RVA = "0x1C184F0", Offset = "0x1C170F0", VA = "0x181C184F0")]
		public DetailCommonViewModel()
		{
		}

		// Token: 0x0402E163 RID: 188771
		[Token(Token = "0x402E163")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0402E164 RID: 188772
		[Token(Token = "0x402E164")]
		[FieldOffset(Offset = "0x18")]
		public string giftPackageId;

		// Token: 0x0402E165 RID: 188773
		[Token(Token = "0x402E165")]
		[FieldOffset(Offset = "0x20")]
		public ShopType shopType;

		// Token: 0x0402E166 RID: 188774
		[Token(Token = "0x402E166")]
		[FieldOffset(Offset = "0x24")]
		public ShopDetailType type;

		// Token: 0x0402E167 RID: 188775
		[Token(Token = "0x402E167")]
		[FieldOffset(Offset = "0x28")]
		private ShopDetailPriceType m_priceType;

		// Token: 0x0402E168 RID: 188776
		[Token(Token = "0x402E168")]
		[FieldOffset(Offset = "0x30")]
		private UIItemViewModel m_priceItem;

		// Token: 0x0402E169 RID: 188777
		[Token(Token = "0x402E169")]
		[FieldOffset(Offset = "0x38")]
		public int price;

		// Token: 0x0402E16A RID: 188778
		[Token(Token = "0x402E16A")]
		[FieldOffset(Offset = "0x3C")]
		public int originPrice;

		// Token: 0x0402E16B RID: 188779
		[Token(Token = "0x402E16B")]
		[FieldOffset(Offset = "0x40")]
		public float discount;

		// Token: 0x0402E16C RID: 188780
		[Token(Token = "0x402E16C")]
		[FieldOffset(Offset = "0x48")]
		public long endTime;

		// Token: 0x0402E16D RID: 188781
		[Token(Token = "0x402E16D")]
		[FieldOffset(Offset = "0x50")]
		public int soldCount;

		// Token: 0x0402E16E RID: 188782
		[Token(Token = "0x402E16E")]
		[FieldOffset(Offset = "0x54")]
		public int ableToBuyCount;

		// Token: 0x0402E16F RID: 188783
		[Token(Token = "0x402E16F")]
		[FieldOffset(Offset = "0x58")]
		public bool disableMax;

		// Token: 0x0402E170 RID: 188784
		[Token(Token = "0x402E170")]
		[FieldOffset(Offset = "0x60")]
		public string displayName;

		// Token: 0x0402E171 RID: 188785
		[Token(Token = "0x402E171")]
		[FieldOffset(Offset = "0x68")]
		public ItemBundle soldItem;

		// Token: 0x0402E172 RID: 188786
		[Token(Token = "0x402E172")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priceType;

		// Token: 0x0402E173 RID: 188787
		[Token(Token = "0x402E173")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_priceType;

		// Token: 0x0402E174 RID: 188788
		[Token(Token = "0x402E174")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_priceItem;

		// Token: 0x0402E175 RID: 188789
		[Token(Token = "0x402E175")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_priceItem;

		// Token: 0x0402E176 RID: 188790
		[Token(Token = "0x402E176")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetCashInfo;

		// Token: 0x0402E177 RID: 188791
		[Token(Token = "0x402E177")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
