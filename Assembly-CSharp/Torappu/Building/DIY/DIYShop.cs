using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018D7 RID: 6359
	[Token(Token = "0x20018D7")]
	public class DIYShop : IDIYShop
	{
		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x0600A058 RID: 41048 RVA: 0x0003E838 File Offset: 0x0003CA38
		[Token(Token = "0x17001248")]
		public int currentCash
		{
			[Token(Token = "0x600A058")]
			[Address(RVA = "0x31AAE30", Offset = "0x31A9A30", VA = "0x1831AAE30", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x0600A059 RID: 41049 RVA: 0x0003E850 File Offset: 0x0003CA50
		[Token(Token = "0x17001249")]
		public int currentFurnitureCoin
		{
			[Token(Token = "0x600A059")]
			[Address(RVA = "0x31AAE90", Offset = "0x31A9A90", VA = "0x1831AAE90", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600A05A RID: 41050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A05A")]
		[Address(RVA = "0x31AA7C0", Offset = "0x31A93C0", VA = "0x1831AA7C0", Slot = "4")]
		public void RefreshData(Action<int> resultHandler)
		{
		}

		// Token: 0x0600A05B RID: 41051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A05B")]
		[Address(RVA = "0x31AA740", Offset = "0x31A9340", VA = "0x1831AA740", Slot = "5")]
		public IEnumerable<IDIYShopItem> EnumShopItems()
		{
			return null;
		}

		// Token: 0x0600A05C RID: 41052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A05C")]
		[Address(RVA = "0x31AAA20", Offset = "0x31A9620", VA = "0x1831AAA20", Slot = "8")]
		public void TryBuyShopItem(IDIYShopItem item, int cashBuyCount, int furnitureCoinBuyCount, Action<int> resultHandler)
		{
		}

		// Token: 0x0600A05D RID: 41053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A05D")]
		[Address(RVA = "0x31AADA0", Offset = "0x31A99A0", VA = "0x1831AADA0")]
		public DIYShop()
		{
		}

		// Token: 0x0400969B RID: 38555
		[Token(Token = "0x400969B")]
		[FieldOffset(Offset = "0x10")]
		private List<DIYShop.Item> m_items;

		// Token: 0x020018D8 RID: 6360
		[Token(Token = "0x20018D8")]
		private class Item : IDIYShopItem
		{
			// Token: 0x1700124A RID: 4682
			// (get) Token: 0x0600A05E RID: 41054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700124A")]
			public string shopItemId
			{
				[Token(Token = "0x600A05E")]
				[Address(RVA = "0x319C1D0", Offset = "0x319ADD0", VA = "0x18319C1D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700124B RID: 4683
			// (get) Token: 0x0600A05F RID: 41055 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600A060 RID: 41056 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700124B")]
			public IDIYItem diyItem
			{
				[Token(Token = "0x600A05F")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600A060")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700124C RID: 4684
			// (get) Token: 0x0600A061 RID: 41057 RVA: 0x0003E868 File Offset: 0x0003CA68
			[Token(Token = "0x1700124C")]
			public int cashCost
			{
				[Token(Token = "0x600A061")]
				[Address(RVA = "0x31B7670", Offset = "0x31B6270", VA = "0x1831B7670", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700124D RID: 4685
			// (get) Token: 0x0600A062 RID: 41058 RVA: 0x0003E880 File Offset: 0x0003CA80
			[Token(Token = "0x1700124D")]
			public int furnitureCoinCost
			{
				[Token(Token = "0x600A062")]
				[Address(RVA = "0x31B76D0", Offset = "0x31B62D0", VA = "0x1831B76D0", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700124E RID: 4686
			// (get) Token: 0x0600A063 RID: 41059 RVA: 0x0003E898 File Offset: 0x0003CA98
			[Token(Token = "0x1700124E")]
			public int cashDiscount
			{
				[Token(Token = "0x600A063")]
				[Address(RVA = "0x31B7690", Offset = "0x31B6290", VA = "0x1831B7690", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700124F RID: 4687
			// (get) Token: 0x0600A064 RID: 41060 RVA: 0x0003E8B0 File Offset: 0x0003CAB0
			[Token(Token = "0x1700124F")]
			public int furnitureCoinDiscount
			{
				[Token(Token = "0x600A064")]
				[Address(RVA = "0x31B7690", Offset = "0x31B6290", VA = "0x1831B7690", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001250 RID: 4688
			// (get) Token: 0x0600A065 RID: 41061 RVA: 0x0003E8C8 File Offset: 0x0003CAC8
			[Token(Token = "0x17001250")]
			public int cashOriginCost
			{
				[Token(Token = "0x600A065")]
				[Address(RVA = "0x31B76B0", Offset = "0x31B62B0", VA = "0x1831B76B0", Slot = "10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001251 RID: 4689
			// (get) Token: 0x0600A066 RID: 41062 RVA: 0x0003E8E0 File Offset: 0x0003CAE0
			[Token(Token = "0x17001251")]
			public int furnitureCoinOriginCost
			{
				[Token(Token = "0x600A066")]
				[Address(RVA = "0x31B76F0", Offset = "0x31B62F0", VA = "0x1831B76F0", Slot = "11")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001252 RID: 4690
			// (get) Token: 0x0600A067 RID: 41063 RVA: 0x0003E8F8 File Offset: 0x0003CAF8
			[Token(Token = "0x17001252")]
			public int buyLimit
			{
				[Token(Token = "0x600A067")]
				[Address(RVA = "0x31B7530", Offset = "0x31B6130", VA = "0x1831B7530", Slot = "12")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001253 RID: 4691
			// (get) Token: 0x0600A068 RID: 41064 RVA: 0x0003E910 File Offset: 0x0003CB10
			[Token(Token = "0x17001253")]
			public long startTime
			{
				[Token(Token = "0x600A068")]
				[Address(RVA = "0x1CA1D80", Offset = "0x1CA0980", VA = "0x181CA1D80", Slot = "13")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17001254 RID: 4692
			// (get) Token: 0x0600A069 RID: 41065 RVA: 0x0003E928 File Offset: 0x0003CB28
			[Token(Token = "0x17001254")]
			public long endTime
			{
				[Token(Token = "0x600A069")]
				[Address(RVA = "0xFEE8C0", Offset = "0xFED4C0", VA = "0x180FEE8C0", Slot = "14")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x0600A06A RID: 41066 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A06A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x0400969C RID: 38556
			[Token(Token = "0x400969C")]
			[FieldOffset(Offset = "0x10")]
			public BuildingGetFurnitureGoodListResponse.Good good;

			// Token: 0x0400969D RID: 38557
			[Token(Token = "0x400969D")]
			[FieldOffset(Offset = "0x18")]
			public PlayerGoodItemData playerGoodItemData;
		}
	}
}
