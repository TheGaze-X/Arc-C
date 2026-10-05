using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D2C RID: 3372
	[Token(Token = "0x2000D2C")]
	public class Act3D0Data
	{
		// Token: 0x06006A03 RID: 27139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A03")]
		[Address(RVA = "0x1FF5BB0", Offset = "0x1FF47B0", VA = "0x181FF5BB0")]
		public Act3D0Data()
		{
		}

		// Token: 0x0400454F RID: 17743
		[Token(Token = "0x400454F")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, Act3D0Data.CampBasicInfo> campBasicInfo;

		// Token: 0x04004550 RID: 17744
		[Token(Token = "0x4004550")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act3D0Data.LimitedPoolDetailInfo> limitedPoolList;

		// Token: 0x04004551 RID: 17745
		[Token(Token = "0x4004551")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act3D0Data.InfinitePoolDetailInfo> infinitePoolList;

		// Token: 0x04004552 RID: 17746
		[Token(Token = "0x4004552")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act3D0Data.InfinitePoolPercent> infinitePercent;

		// Token: 0x04004553 RID: 17747
		[Token(Token = "0x4004553")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act3D0Data.CampItemMapInfo> campItemMapInfo;

		// Token: 0x04004554 RID: 17748
		[Token(Token = "0x4004554")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act3D0Data.ClueInfo> clueInfo;

		// Token: 0x04004555 RID: 17749
		[Token(Token = "0x4004555")]
		[FieldOffset(Offset = "0x40")]
		public List<Act3D0Data.MileStoneInfo> mileStoneInfo;

		// Token: 0x04004556 RID: 17750
		[Token(Token = "0x4004556")]
		[FieldOffset(Offset = "0x48")]
		public string mileStoneTokenId;

		// Token: 0x04004557 RID: 17751
		[Token(Token = "0x4004557")]
		[FieldOffset(Offset = "0x50")]
		public string coinTokenId;

		// Token: 0x04004558 RID: 17752
		[Token(Token = "0x4004558")]
		[FieldOffset(Offset = "0x58")]
		public string etTokenId;

		// Token: 0x04004559 RID: 17753
		[Token(Token = "0x4004559")]
		[FieldOffset(Offset = "0x60")]
		public List<Act3D0Data.GachaBoxInfo> gachaBoxInfo;

		// Token: 0x0400455A RID: 17754
		[Token(Token = "0x400455A")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, Act3D0Data.CampInfo> campInfo;

		// Token: 0x0400455B RID: 17755
		[Token(Token = "0x400455B")]
		[FieldOffset(Offset = "0x70")]
		public ListDict<string, Act3D0Data.ZoneDescInfo> zoneDesc;

		// Token: 0x0400455C RID: 17756
		[Token(Token = "0x400455C")]
		[FieldOffset(Offset = "0x78")]
		public ListDict<string, CommonFavorUpInfo> favorUpList;

		// Token: 0x02000D2D RID: 3373
		[Token(Token = "0x2000D2D")]
		public enum GoodType
		{
			// Token: 0x0400455E RID: 17758
			[Token(Token = "0x400455E")]
			NORMAL,
			// Token: 0x0400455F RID: 17759
			[Token(Token = "0x400455F")]
			SPECIAL
		}

		// Token: 0x02000D2E RID: 3374
		[Token(Token = "0x2000D2E")]
		public enum GachaBoxType
		{
			// Token: 0x04004561 RID: 17761
			[Token(Token = "0x4004561")]
			LIMITED,
			// Token: 0x04004562 RID: 17762
			[Token(Token = "0x4004562")]
			UNLIMITED
		}

		// Token: 0x02000D2F RID: 3375
		[Token(Token = "0x2000D2F")]
		public class CampBasicInfo
		{
			// Token: 0x06006A04 RID: 27140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A04")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CampBasicInfo()
			{
			}

			// Token: 0x04004563 RID: 17763
			[Token(Token = "0x4004563")]
			[FieldOffset(Offset = "0x10")]
			public string campId;

			// Token: 0x04004564 RID: 17764
			[Token(Token = "0x4004564")]
			[FieldOffset(Offset = "0x18")]
			public string campName;

			// Token: 0x04004565 RID: 17765
			[Token(Token = "0x4004565")]
			[FieldOffset(Offset = "0x20")]
			public string campDesc;

			// Token: 0x04004566 RID: 17766
			[Token(Token = "0x4004566")]
			[FieldOffset(Offset = "0x28")]
			public string rewardDesc;
		}

		// Token: 0x02000D30 RID: 3376
		[Token(Token = "0x2000D30")]
		public class InfinitePoolDetailInfo
		{
			// Token: 0x06006A05 RID: 27141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A05")]
			[Address(RVA = "0x200B4F0", Offset = "0x200A0F0", VA = "0x18200B4F0")]
			public InfinitePoolDetailInfo()
			{
			}

			// Token: 0x04004567 RID: 17767
			[Token(Token = "0x4004567")]
			[FieldOffset(Offset = "0x10")]
			public string poolId;

			// Token: 0x04004568 RID: 17768
			[Token(Token = "0x4004568")]
			[FieldOffset(Offset = "0x18")]
			public List<Act3D0Data.InfinitePoolDetailInfo.PoolItemInfo> poolItemInfo;

			// Token: 0x02000D31 RID: 3377
			[Token(Token = "0x2000D31")]
			public class PoolItemInfo
			{
				// Token: 0x06006A06 RID: 27142 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006A06")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PoolItemInfo()
				{
				}

				// Token: 0x04004569 RID: 17769
				[Token(Token = "0x4004569")]
				[FieldOffset(Offset = "0x10")]
				public string goodId;

				// Token: 0x0400456A RID: 17770
				[Token(Token = "0x400456A")]
				[FieldOffset(Offset = "0x18")]
				[JsonConverter(typeof(StringEnumConverter))]
				public Act3D0Data.GoodType goodType;

				// Token: 0x0400456B RID: 17771
				[Token(Token = "0x400456B")]
				[FieldOffset(Offset = "0x20")]
				public ItemBundle itemInfo;

				// Token: 0x0400456C RID: 17772
				[Token(Token = "0x400456C")]
				[FieldOffset(Offset = "0x28")]
				public int perCount;

				// Token: 0x0400456D RID: 17773
				[Token(Token = "0x400456D")]
				[FieldOffset(Offset = "0x2C")]
				public int weight;

				// Token: 0x0400456E RID: 17774
				[Token(Token = "0x400456E")]
				[FieldOffset(Offset = "0x30")]
				public string type;

				// Token: 0x0400456F RID: 17775
				[Token(Token = "0x400456F")]
				[FieldOffset(Offset = "0x38")]
				public int orderId;
			}
		}

		// Token: 0x02000D32 RID: 3378
		[Token(Token = "0x2000D32")]
		public class LimitedPoolDetailInfo
		{
			// Token: 0x06006A07 RID: 27143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A07")]
			[Address(RVA = "0x200B730", Offset = "0x200A330", VA = "0x18200B730")]
			public LimitedPoolDetailInfo()
			{
			}

			// Token: 0x04004570 RID: 17776
			[Token(Token = "0x4004570")]
			[FieldOffset(Offset = "0x10")]
			public string poolId;

			// Token: 0x04004571 RID: 17777
			[Token(Token = "0x4004571")]
			[FieldOffset(Offset = "0x18")]
			public List<Act3D0Data.LimitedPoolDetailInfo.PoolItemInfo> poolItemInfo;

			// Token: 0x02000D33 RID: 3379
			[Token(Token = "0x2000D33")]
			public class PoolItemInfo
			{
				// Token: 0x06006A08 RID: 27144 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006A08")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PoolItemInfo()
				{
				}

				// Token: 0x04004572 RID: 17778
				[Token(Token = "0x4004572")]
				[FieldOffset(Offset = "0x10")]
				public string goodId;

				// Token: 0x04004573 RID: 17779
				[Token(Token = "0x4004573")]
				[FieldOffset(Offset = "0x18")]
				public ItemBundle itemInfo;

				// Token: 0x04004574 RID: 17780
				[Token(Token = "0x4004574")]
				[FieldOffset(Offset = "0x20")]
				[JsonConverter(typeof(StringEnumConverter))]
				public Act3D0Data.GoodType goodType;

				// Token: 0x04004575 RID: 17781
				[Token(Token = "0x4004575")]
				[FieldOffset(Offset = "0x24")]
				public int perCount;

				// Token: 0x04004576 RID: 17782
				[Token(Token = "0x4004576")]
				[FieldOffset(Offset = "0x28")]
				public int totalCount;

				// Token: 0x04004577 RID: 17783
				[Token(Token = "0x4004577")]
				[FieldOffset(Offset = "0x2C")]
				public int weight;

				// Token: 0x04004578 RID: 17784
				[Token(Token = "0x4004578")]
				[FieldOffset(Offset = "0x30")]
				public string type;

				// Token: 0x04004579 RID: 17785
				[Token(Token = "0x4004579")]
				[FieldOffset(Offset = "0x38")]
				public int orderId;
			}
		}

		// Token: 0x02000D34 RID: 3380
		[Token(Token = "0x2000D34")]
		public class InfinitePoolPercent
		{
			// Token: 0x06006A09 RID: 27145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A09")]
			[Address(RVA = "0x200B580", Offset = "0x200A180", VA = "0x18200B580")]
			public InfinitePoolPercent()
			{
			}

			// Token: 0x0400457A RID: 17786
			[Token(Token = "0x400457A")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> percentDict;
		}

		// Token: 0x02000D35 RID: 3381
		[Token(Token = "0x2000D35")]
		public class GachaBoxInfo
		{
			// Token: 0x06006A0A RID: 27146 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GachaBoxInfo()
			{
			}

			// Token: 0x0400457B RID: 17787
			[Token(Token = "0x400457B")]
			[FieldOffset(Offset = "0x10")]
			public string gachaBoxId;

			// Token: 0x0400457C RID: 17788
			[Token(Token = "0x400457C")]
			[FieldOffset(Offset = "0x18")]
			[JsonConverter(typeof(StringEnumConverter))]
			public Act3D0Data.GachaBoxType boxType;

			// Token: 0x0400457D RID: 17789
			[Token(Token = "0x400457D")]
			[FieldOffset(Offset = "0x20")]
			public string keyGoodId;

			// Token: 0x0400457E RID: 17790
			[Token(Token = "0x400457E")]
			[FieldOffset(Offset = "0x28")]
			public ItemBundle tokenId;

			// Token: 0x0400457F RID: 17791
			[Token(Token = "0x400457F")]
			[FieldOffset(Offset = "0x30")]
			public int tokenNumOnce;

			// Token: 0x04004580 RID: 17792
			[Token(Token = "0x4004580")]
			[FieldOffset(Offset = "0x38")]
			public string unlockImg;

			// Token: 0x04004581 RID: 17793
			[Token(Token = "0x4004581")]
			[FieldOffset(Offset = "0x40")]
			public string nextGachaBoxInfoId;
		}

		// Token: 0x02000D36 RID: 3382
		[Token(Token = "0x2000D36")]
		public class CampItemMapInfo
		{
			// Token: 0x06006A0B RID: 27147 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0B")]
			[Address(RVA = "0x2007810", Offset = "0x2006410", VA = "0x182007810")]
			public CampItemMapInfo()
			{
			}

			// Token: 0x04004582 RID: 17794
			[Token(Token = "0x4004582")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x04004583 RID: 17795
			[Token(Token = "0x4004583")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, ItemBundle> itemDict;
		}

		// Token: 0x02000D37 RID: 3383
		[Token(Token = "0x2000D37")]
		public class ZoneDescInfo
		{
			// Token: 0x06006A0C RID: 27148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneDescInfo()
			{
			}

			// Token: 0x04004584 RID: 17796
			[Token(Token = "0x4004584")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004585 RID: 17797
			[Token(Token = "0x4004585")]
			[FieldOffset(Offset = "0x18")]
			public string lockedText;
		}

		// Token: 0x02000D38 RID: 3384
		[Token(Token = "0x2000D38")]
		public class CampInfo
		{
			// Token: 0x06006A0D RID: 27149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CampInfo()
			{
			}

			// Token: 0x04004586 RID: 17798
			[Token(Token = "0x4004586")]
			[FieldOffset(Offset = "0x10")]
			public string campId;

			// Token: 0x04004587 RID: 17799
			[Token(Token = "0x4004587")]
			[FieldOffset(Offset = "0x18")]
			public string campChineseName;
		}

		// Token: 0x02000D39 RID: 3385
		[Token(Token = "0x2000D39")]
		public class ClueInfo
		{
			// Token: 0x06006A0E RID: 27150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClueInfo()
			{
			}

			// Token: 0x04004588 RID: 17800
			[Token(Token = "0x4004588")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04004589 RID: 17801
			[Token(Token = "0x4004589")]
			[FieldOffset(Offset = "0x18")]
			public string campId;

			// Token: 0x0400458A RID: 17802
			[Token(Token = "0x400458A")]
			[FieldOffset(Offset = "0x20")]
			public int orderId;

			// Token: 0x0400458B RID: 17803
			[Token(Token = "0x400458B")]
			[FieldOffset(Offset = "0x28")]
			public string imageId;
		}

		// Token: 0x02000D3A RID: 3386
		[Token(Token = "0x2000D3A")]
		public class MileStoneInfo
		{
			// Token: 0x06006A0F RID: 27151 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A0F")]
			[Address(RVA = "0x200B870", Offset = "0x200A470", VA = "0x18200B870")]
			public MileStoneInfo()
			{
			}

			// Token: 0x0400458C RID: 17804
			[Token(Token = "0x400458C")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x0400458D RID: 17805
			[Token(Token = "0x400458D")]
			[FieldOffset(Offset = "0x18")]
			public int orderId;

			// Token: 0x0400458E RID: 17806
			[Token(Token = "0x400458E")]
			[FieldOffset(Offset = "0x1C")]
			public Act3D0Data.GoodType mileStoneType;

			// Token: 0x0400458F RID: 17807
			[Token(Token = "0x400458F")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle normalItem;

			// Token: 0x04004590 RID: 17808
			[Token(Token = "0x4004590")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, ItemBundle> specialItemDict;

			// Token: 0x04004591 RID: 17809
			[Token(Token = "0x4004591")]
			[FieldOffset(Offset = "0x30")]
			public int tokenNum;
		}
	}
}
