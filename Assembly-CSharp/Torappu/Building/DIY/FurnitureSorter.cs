using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018B9 RID: 6329
	[Token(Token = "0x20018B9")]
	public class FurnitureSorter
	{
		// Token: 0x06009FE0 RID: 40928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FE0")]
		[Address(RVA = "0x31B2B20", Offset = "0x31B1720", VA = "0x1831B2B20")]
		public void CacheFurnitureStorage()
		{
		}

		// Token: 0x06009FE1 RID: 40929 RVA: 0x0003E4F0 File Offset: 0x0003C6F0
		[Token(Token = "0x6009FE1")]
		[Address(RVA = "0x31B4CD0", Offset = "0x31B38D0", VA = "0x1831B4CD0")]
		private static int _SortingKeyComfort(IDIYItem diyItem)
		{
			return 0;
		}

		// Token: 0x06009FE2 RID: 40930 RVA: 0x0003E508 File Offset: 0x0003C708
		[Token(Token = "0x6009FE2")]
		[Address(RVA = "0x31B4DB0", Offset = "0x31B39B0", VA = "0x1831B4DB0")]
		private static int _SortingKeyRarity(IDIYItem diyItem)
		{
			return 0;
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x0003E520 File Offset: 0x0003C720
		[Token(Token = "0x6009FE3")]
		[Address(RVA = "0x31B4D20", Offset = "0x31B3920", VA = "0x1831B4D20")]
		private int _SortingKeyCount(IDIYItem diyItem)
		{
			return 0;
		}

		// Token: 0x06009FE4 RID: 40932 RVA: 0x0003E538 File Offset: 0x0003C738
		[Token(Token = "0x6009FE4")]
		[Address(RVA = "0x31B41A0", Offset = "0x31B2DA0", VA = "0x1831B41A0")]
		private static int _ShopCompareAscent(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x0003E550 File Offset: 0x0003C750
		[Token(Token = "0x6009FE5")]
		[Address(RVA = "0x31B4340", Offset = "0x31B2F40", VA = "0x1831B4340")]
		private static int _ShopCompareDescent(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FE6")]
		[Address(RVA = "0x31B40E0", Offset = "0x31B2CE0", VA = "0x1831B40E0")]
		private static Func<IDIYItem, IDIYItem, int> _GetSortingFunctionBySortingKeyFunction(FurnitureSorter.SortingMethod method, params Func<IDIYItem, int>[] keyFunctions)
		{
			return null;
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FE7")]
		[Address(RVA = "0x31B3BC0", Offset = "0x31B27C0", VA = "0x1831B3BC0")]
		public Func<IDIYItem, IDIYItem, int> GetSortingFunction(FurnitureSorter.FurnitureSortingOption option, FurnitureSorter.SortingMethod method)
		{
			return null;
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x0003E568 File Offset: 0x0003C768
		[Token(Token = "0x6009FE8")]
		[Address(RVA = "0x31B4790", Offset = "0x31B3390", VA = "0x1831B4790")]
		private int _ShopItemCompareFuncEndTime(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x0003E580 File Offset: 0x0003C780
		[Token(Token = "0x6009FE9")]
		[Address(RVA = "0x31B4710", Offset = "0x31B3310", VA = "0x1831B4710")]
		private int _ShopItemCompareFuncDiscount(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FEA RID: 40938 RVA: 0x0003E598 File Offset: 0x0003C798
		[Token(Token = "0x6009FEA")]
		[Address(RVA = "0x31B48F0", Offset = "0x31B34F0", VA = "0x1831B48F0")]
		private int _ShopItemCompareFuncPriceAscent(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FEB RID: 40939 RVA: 0x0003E5B0 File Offset: 0x0003C7B0
		[Token(Token = "0x6009FEB")]
		[Address(RVA = "0x31B49C0", Offset = "0x31B35C0", VA = "0x1831B49C0")]
		private int _ShopItemCompareFuncPriceDescent(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x0003E5C8 File Offset: 0x0003C7C8
		[Token(Token = "0x6009FEC")]
		[Address(RVA = "0x31B4A90", Offset = "0x31B3690", VA = "0x1831B4A90")]
		private int _ShopItemCompareFuncRarity(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x0003E5E0 File Offset: 0x0003C7E0
		[Token(Token = "0x6009FED")]
		[Address(RVA = "0x31B4590", Offset = "0x31B3190", VA = "0x1831B4590")]
		private int _ShopItemCompareFuncComfortAscent(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x0003E5F8 File Offset: 0x0003C7F8
		[Token(Token = "0x6009FEE")]
		[Address(RVA = "0x31B4650", Offset = "0x31B3250", VA = "0x1831B4650")]
		private int _ShopItemCompareFuncComfortDescent(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x0003E610 File Offset: 0x0003C810
		[Token(Token = "0x6009FEF")]
		[Address(RVA = "0x31B4B50", Offset = "0x31B3750", VA = "0x1831B4B50")]
		private int _ShopItemCompareFuncStorageCount(IDIYShopItem lhs, IDIYShopItem rhs)
		{
			return 0;
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FF0")]
		[Address(RVA = "0x31B44E0", Offset = "0x31B30E0", VA = "0x1831B44E0")]
		private Func<IDIYShopItem, IDIYShopItem, int> _ShopItemCompareFuncCombination(params Func<IDIYShopItem, IDIYShopItem, int>[] functions)
		{
			return null;
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FF1")]
		[Address(RVA = "0x31B2D70", Offset = "0x31B1970", VA = "0x1831B2D70")]
		public Func<IDIYShopItem, IDIYShopItem, int> GetShopSortingFunction(FurnitureSorter.FurnitureSortingOption option, FurnitureSorter.SortingMethod method)
		{
			return null;
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FF2")]
		[Address(RVA = "0x31B4E00", Offset = "0x31B3A00", VA = "0x1831B4E00")]
		public FurnitureSorter()
		{
		}

		// Token: 0x0400964A RID: 38474
		[Token(Token = "0x400964A")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, int> m_furnitureStorageItemCache;

		// Token: 0x0400964B RID: 38475
		[Token(Token = "0x400964B")]
		[FieldOffset(Offset = "0x18")]
		private List<FurnitureSorter.CacheItem<IDIYItem>> m_cacheList;

		// Token: 0x0400964C RID: 38476
		[Token(Token = "0x400964C")]
		[FieldOffset(Offset = "0x20")]
		private List<FurnitureSorter.CacheItem<IDIYShopItem>> m_shopCacheList;

		// Token: 0x020018BA RID: 6330
		[Token(Token = "0x20018BA")]
		public enum FurnitureSortingOption
		{
			// Token: 0x0400964E RID: 38478
			[Token(Token = "0x400964E")]
			COMFORT,
			// Token: 0x0400964F RID: 38479
			[Token(Token = "0x400964F")]
			RARITY,
			// Token: 0x04009650 RID: 38480
			[Token(Token = "0x4009650")]
			COUNT,
			// Token: 0x04009651 RID: 38481
			[Token(Token = "0x4009651")]
			PRICE,
			// Token: 0x04009652 RID: 38482
			[Token(Token = "0x4009652")]
			SHOP_DEFAULT,
			// Token: 0x04009653 RID: 38483
			[Token(Token = "0x4009653")]
			ENUM_COUNT
		}

		// Token: 0x020018BB RID: 6331
		[Token(Token = "0x20018BB")]
		public enum SortingMethod
		{
			// Token: 0x04009655 RID: 38485
			[Token(Token = "0x4009655")]
			ASCENT,
			// Token: 0x04009656 RID: 38486
			[Token(Token = "0x4009656")]
			DESCENT,
			// Token: 0x04009657 RID: 38487
			[Token(Token = "0x4009657")]
			ENUM_COUNT
		}

		// Token: 0x020018BC RID: 6332
		[Token(Token = "0x20018BC")]
		private class CacheItem<T>
		{
			// Token: 0x06009FF4 RID: 40948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009FF4")]
			public CacheItem()
			{
			}

			// Token: 0x04009658 RID: 38488
			[Token(Token = "0x4009658")]
			[FieldOffset(Offset = "0x0")]
			public FurnitureSorter.FurnitureSortingOption option;

			// Token: 0x04009659 RID: 38489
			[Token(Token = "0x4009659")]
			[FieldOffset(Offset = "0x0")]
			public FurnitureSorter.SortingMethod method;

			// Token: 0x0400965A RID: 38490
			[Token(Token = "0x400965A")]
			[FieldOffset(Offset = "0x0")]
			public Func<T, T, int> func;
		}
	}
}
