using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001915 RID: 6421
	[Token(Token = "0x2001915")]
	public class MockDIYShop : MonoBehaviour, IDIYShop
	{
		// Token: 0x0600A1AB RID: 41387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1AB")]
		[Address(RVA = "0x31CE070", Offset = "0x31CCC70", VA = "0x1831CE070")]
		private void Update()
		{
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1AC")]
		[Address(RVA = "0x31CDA10", Offset = "0x31CC610", VA = "0x1831CDA10", Slot = "4")]
		public void RefreshData(Action<int> resultHandler)
		{
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A1AD")]
		[Address(RVA = "0x31CD990", Offset = "0x31CC590", VA = "0x1831CD990", Slot = "5")]
		public IEnumerable<IDIYShopItem> EnumShopItems()
		{
			return null;
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1AE")]
		[Address(RVA = "0x31CDA40", Offset = "0x31CC640", VA = "0x1831CDA40")]
		public void Setup(IFurnitureDataProvider furnitureDataProvider, IDIYRoomModifierDataProvider modifierDataProvider)
		{
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x0600A1AF RID: 41391 RVA: 0x0003EF58 File Offset: 0x0003D158
		[Token(Token = "0x170012A2")]
		public int currentCash
		{
			[Token(Token = "0x600A1AF")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x0600A1B0 RID: 41392 RVA: 0x0003EF70 File Offset: 0x0003D170
		[Token(Token = "0x170012A3")]
		public int currentFurnitureCoin
		{
			[Token(Token = "0x600A1B0")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200", Slot = "7")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1B1")]
		[Address(RVA = "0x31CE0E0", Offset = "0x31CCCE0", VA = "0x1831CE0E0")]
		private void _StartResultHandleCountDown(Action<int> handler, int resultCode)
		{
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1B2")]
		[Address(RVA = "0x31CDC80", Offset = "0x31CC880", VA = "0x1831CDC80", Slot = "8")]
		public void TryBuyShopItem(IDIYShopItem item, int cashBuyCount, int furnitureCoinBuyCount, Action<int> resultHandler)
		{
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1B3")]
		[Address(RVA = "0x31CE110", Offset = "0x31CCD10", VA = "0x1831CE110")]
		public MockDIYShop()
		{
		}

		// Token: 0x040097F9 RID: 38905
		[Token(Token = "0x40097F9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MockDIYShop.Item[] _items;

		// Token: 0x040097FA RID: 38906
		[Token(Token = "0x40097FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _cash;

		// Token: 0x040097FB RID: 38907
		[Token(Token = "0x40097FB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _furnitureCoin;

		// Token: 0x040097FC RID: 38908
		[Token(Token = "0x40097FC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MockFurnitureStorage _furnitureStorage;

		// Token: 0x040097FD RID: 38909
		[Token(Token = "0x40097FD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fakeDelayTime;

		// Token: 0x040097FE RID: 38910
		[Token(Token = "0x40097FE")]
		[FieldOffset(Offset = "0x34")]
		private float m_timeCnt;

		// Token: 0x040097FF RID: 38911
		[Token(Token = "0x40097FF")]
		[FieldOffset(Offset = "0x38")]
		private int m_resultCode;

		// Token: 0x04009800 RID: 38912
		[Token(Token = "0x4009800")]
		[FieldOffset(Offset = "0x40")]
		private Action<int> m_handler;

		// Token: 0x02001916 RID: 6422
		[Token(Token = "0x2001916")]
		[Serializable]
		public class Item : IDIYShopItem
		{
			// Token: 0x0600A1B4 RID: 41396 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A1B4")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			public IEnumerable<ItemBundle> EnumCosts()
			{
				return null;
			}

			// Token: 0x170012A4 RID: 4772
			// (get) Token: 0x0600A1B5 RID: 41397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012A4")]
			public string shopItemId
			{
				[Token(Token = "0x600A1B5")]
				[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012A5 RID: 4773
			// (get) Token: 0x0600A1B6 RID: 41398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170012A5")]
			public IDIYItem diyItem
			{
				[Token(Token = "0x600A1B6")]
				[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170012A6 RID: 4774
			// (get) Token: 0x0600A1B7 RID: 41399 RVA: 0x0003EF88 File Offset: 0x0003D188
			[Token(Token = "0x170012A6")]
			public int cashCost
			{
				[Token(Token = "0x600A1B7")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "6")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012A7 RID: 4775
			// (get) Token: 0x0600A1B8 RID: 41400 RVA: 0x0003EFA0 File Offset: 0x0003D1A0
			[Token(Token = "0x170012A7")]
			public int furnitureCoinCost
			{
				[Token(Token = "0x600A1B8")]
				[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "7")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012A8 RID: 4776
			// (get) Token: 0x0600A1B9 RID: 41401 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
			[Token(Token = "0x170012A8")]
			public int cashDiscount
			{
				[Token(Token = "0x600A1B9")]
				[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "8")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012A9 RID: 4777
			// (get) Token: 0x0600A1BA RID: 41402 RVA: 0x0003EFD0 File Offset: 0x0003D1D0
			[Token(Token = "0x170012A9")]
			public int furnitureCoinDiscount
			{
				[Token(Token = "0x600A1BA")]
				[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012AA RID: 4778
			// (get) Token: 0x0600A1BB RID: 41403 RVA: 0x0003EFE8 File Offset: 0x0003D1E8
			[Token(Token = "0x170012AA")]
			public int cashOriginCost
			{
				[Token(Token = "0x600A1BB")]
				[Address(RVA = "0x31CB890", Offset = "0x31CA490", VA = "0x1831CB890", Slot = "10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012AB RID: 4779
			// (get) Token: 0x0600A1BC RID: 41404 RVA: 0x0003F000 File Offset: 0x0003D200
			[Token(Token = "0x170012AB")]
			public int furnitureCoinOriginCost
			{
				[Token(Token = "0x600A1BC")]
				[Address(RVA = "0x31CB8B0", Offset = "0x31CA4B0", VA = "0x1831CB8B0", Slot = "11")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012AC RID: 4780
			// (get) Token: 0x0600A1BD RID: 41405 RVA: 0x0003F018 File Offset: 0x0003D218
			[Token(Token = "0x170012AC")]
			public int buyLimit
			{
				[Token(Token = "0x600A1BD")]
				[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610", Slot = "12")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170012AD RID: 4781
			// (get) Token: 0x0600A1BE RID: 41406 RVA: 0x0003F030 File Offset: 0x0003D230
			[Token(Token = "0x170012AD")]
			public long startTime
			{
				[Token(Token = "0x600A1BE")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "13")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x170012AE RID: 4782
			// (get) Token: 0x0600A1BF RID: 41407 RVA: 0x0003F048 File Offset: 0x0003D248
			[Token(Token = "0x170012AE")]
			public long endTime
			{
				[Token(Token = "0x600A1BF")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "14")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x0600A1C0 RID: 41408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1C0")]
			[Address(RVA = "0x31CB500", Offset = "0x31CA100", VA = "0x1831CB500")]
			public void Setup(string id, IFurnitureDataProvider furnitureDataProvider, IDIYRoomModifierDataProvider modifierDataProvider)
			{
			}

			// Token: 0x0600A1C1 RID: 41409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1C1")]
			[Address(RVA = "0x31CB7C0", Offset = "0x31CA3C0", VA = "0x1831CB7C0")]
			public Item()
			{
			}

			// Token: 0x04009801 RID: 38913
			[Token(Token = "0x4009801")]
			[FieldOffset(Offset = "0x10")]
			public string furnitureId;

			// Token: 0x04009802 RID: 38914
			[Token(Token = "0x4009802")]
			[FieldOffset(Offset = "0x18")]
			public int cashCostNumber;

			// Token: 0x04009803 RID: 38915
			[Token(Token = "0x4009803")]
			[FieldOffset(Offset = "0x1C")]
			public int furnitureCoinCostNumber;

			// Token: 0x04009804 RID: 38916
			[Token(Token = "0x4009804")]
			[FieldOffset(Offset = "0x20")]
			public int cashDiscountNumber;

			// Token: 0x04009805 RID: 38917
			[Token(Token = "0x4009805")]
			[FieldOffset(Offset = "0x24")]
			public int furnitureCoinDiscountNumber;

			// Token: 0x04009806 RID: 38918
			[Token(Token = "0x4009806")]
			[FieldOffset(Offset = "0x28")]
			public int buyLimitNumber;

			// Token: 0x04009807 RID: 38919
			[Token(Token = "0x4009807")]
			[FieldOffset(Offset = "0x30")]
			public long startTimeNumber;

			// Token: 0x04009808 RID: 38920
			[Token(Token = "0x4009808")]
			[FieldOffset(Offset = "0x38")]
			public long endTimeNumber;

			// Token: 0x04009809 RID: 38921
			[Token(Token = "0x4009809")]
			[FieldOffset(Offset = "0x40")]
			private string m_shopItemId;

			// Token: 0x0400980A RID: 38922
			[Token(Token = "0x400980A")]
			[FieldOffset(Offset = "0x48")]
			private IDIYItem m_diyItem;

			// Token: 0x0400980B RID: 38923
			[Token(Token = "0x400980B")]
			[FieldOffset(Offset = "0x50")]
			private List<ItemBundle> m_costs;
		}
	}
}
