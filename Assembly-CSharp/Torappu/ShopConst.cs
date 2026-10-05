using System;
using Il2CppDummyDll;
using Torappu.UI.Shop;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu
{
	// Token: 0x0200143F RID: 5183
	[Token(Token = "0x200143F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ShopConst
	{
		// Token: 0x060077DC RID: 30684 RVA: 0x00035C88 File Offset: 0x00033E88
		[Token(Token = "0x60077DC")]
		[Address(RVA = "0x253F2E0", Offset = "0x253DEE0", VA = "0x18253F2E0")]
		public static Color GetShopLMTGSColor(string priceItemId)
		{
			return default(Color);
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x00035CA0 File Offset: 0x00033EA0
		[Token(Token = "0x60077DD")]
		[Address(RVA = "0x253F470", Offset = "0x253E070", VA = "0x18253F470")]
		public static Color GetShopLMTGSTextColor(string priceItemId)
		{
			return default(Color);
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077DE")]
		[Address(RVA = "0x253EDC0", Offset = "0x253D9C0", VA = "0x18253EDC0")]
		public static string GetDetailEnumParam(QCShopDetailShopEnum shopType)
		{
			return null;
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x00035CB8 File Offset: 0x00033EB8
		[Token(Token = "0x60077DF")]
		[Address(RVA = "0x253EF00", Offset = "0x253DB00", VA = "0x18253EF00")]
		public static Color GetShopItemPriceColor(ShopDetailPriceType priceType)
		{
			return default(Color);
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00035CD0 File Offset: 0x00033ED0
		[Token(Token = "0x60077E0")]
		[Address(RVA = "0x253F180", Offset = "0x253DD80", VA = "0x18253F180")]
		public static Color GetShopItemPriceTextColor(ShopDetailPriceType priceType)
		{
			return default(Color);
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E1")]
		[Address(RVA = "0x253ECC0", Offset = "0x253D8C0", VA = "0x18253ECC0")]
		public static string FormatCashString(int priceInData)
		{
			return null;
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E2")]
		[Address(RVA = "0x253F970", Offset = "0x253E570", VA = "0x18253F970")]
		public static string ShopDisplayPrice(int price, ShopCurrencyUnit unit)
		{
			return null;
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E3")]
		[Address(RVA = "0x253FA30", Offset = "0x253E630", VA = "0x18253FA30")]
		public static string ShopDisplayPrice(int price, ShopDetailPriceType unit)
		{
			return null;
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077E4")]
		[Address(RVA = "0x253FAF0", Offset = "0x253E6F0", VA = "0x18253FAF0")]
		private static string _FormatCashString(int cashPrice)
		{
			return null;
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E5")]
		[Address(RVA = "0x253F630", Offset = "0x253E230", VA = "0x18253F630")]
		public static void SetComplexPriceIcon(ShopComplexPriceOptions options, Image imgIcon)
		{
		}

		// Token: 0x04007573 RID: 30067
		[Token(Token = "0x4007573")]
		public const int SHOP_COUNT = 6;

		// Token: 0x04007574 RID: 30068
		[Token(Token = "0x4007574")]
		public const int COUNT_DOWN_DAY_LIMIT = 7;

		// Token: 0x04007575 RID: 30069
		[Token(Token = "0x4007575")]
		public const int SHOP_MIN_PRIOITY = -1;

		// Token: 0x04007576 RID: 30070
		[Token(Token = "0x4007576")]
		public const string ONSHOWSHOP = "OS";

		// Token: 0x04007577 RID: 30071
		[Token(Token = "0x4007577")]
		public const string CASHSHOP = "CASH";

		// Token: 0x04007578 RID: 30072
		[Token(Token = "0x4007578")]
		public const string GPSHOP = "GP";

		// Token: 0x04007579 RID: 30073
		[Token(Token = "0x4007579")]
		public const string HIGHQCSHOP = "HS";

		// Token: 0x0400757A RID: 30074
		[Token(Token = "0x400757A")]
		public const string LOWQCSHOP = "LS";

		// Token: 0x0400757B RID: 30075
		[Token(Token = "0x400757B")]
		public const string EXTRAQCSHOP = "ES";

		// Token: 0x0400757C RID: 30076
		[Token(Token = "0x400757C")]
		public const string FURNSHOP = "FS";

		// Token: 0x0400757D RID: 30077
		[Token(Token = "0x400757D")]
		public const string SOCIALSHOP = "SOCIAL";

		// Token: 0x0400757E RID: 30078
		[Token(Token = "0x400757E")]
		public const string FURNITURE = "FURNI";

		// Token: 0x0400757F RID: 30079
		[Token(Token = "0x400757F")]
		public const string LMTGS = "LMTGS";

		// Token: 0x04007580 RID: 30080
		[Token(Token = "0x4007580")]
		public const string EPGS = "EPGS";

		// Token: 0x04007581 RID: 30081
		[Token(Token = "0x4007581")]
		public const string REP = "REP";

		// Token: 0x04007582 RID: 30082
		[Token(Token = "0x4007582")]
		public const string CLASSIC = "CLASSIC";

		// Token: 0x04007583 RID: 30083
		[Token(Token = "0x4007583")]
		public const string SKIN = "SKIN";

		// Token: 0x04007584 RID: 30084
		[Token(Token = "0x4007584")]
		public const string DEFAULT_BACK = "diamond_back_1";

		// Token: 0x04007585 RID: 30085
		[Token(Token = "0x4007585")]
		public const string DIAMOND_IMG = "diamond_{0}";

		// Token: 0x04007586 RID: 30086
		[Token(Token = "0x4007586")]
		public const string DIAMOND_IMG_DOUBLE = "diamond_{0}d";

		// Token: 0x04007587 RID: 30087
		[Token(Token = "0x4007587")]
		public const string DIAMOND_BACK = "diamond_back_{0}";

		// Token: 0x04007588 RID: 30088
		[Token(Token = "0x4007588")]
		public const float CANVAS_SOLDOUT_ALPHA = 0.4f;

		// Token: 0x04007589 RID: 30089
		[Token(Token = "0x4007589")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] SHOP_TYPE_STRING;

		// Token: 0x0400758A RID: 30090
		[Token(Token = "0x400758A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int SHOP_GG_RESCOURCE;

		// Token: 0x0400758B RID: 30091
		[Token(Token = "0x400758B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetShopLMTGSColor;

		// Token: 0x0400758C RID: 30092
		[Token(Token = "0x400758C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetShopLMTGSTextColor;

		// Token: 0x0400758D RID: 30093
		[Token(Token = "0x400758D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDetailEnumParam;

		// Token: 0x0400758E RID: 30094
		[Token(Token = "0x400758E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetShopItemPriceColor;

		// Token: 0x0400758F RID: 30095
		[Token(Token = "0x400758F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetShopItemPriceTextColor;

		// Token: 0x04007590 RID: 30096
		[Token(Token = "0x4007590")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FormatCashString;

		// Token: 0x04007591 RID: 30097
		[Token(Token = "0x4007591")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShopDisplayPrice;

		// Token: 0x04007592 RID: 30098
		[Token(Token = "0x4007592")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix1_ShopDisplayPrice;

		// Token: 0x04007593 RID: 30099
		[Token(Token = "0x4007593")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__FormatCashString;

		// Token: 0x04007594 RID: 30100
		[Token(Token = "0x4007594")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetComplexPriceIcon;
	}
}
