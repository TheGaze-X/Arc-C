using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000633 RID: 1587
	[Token(Token = "0x2000633")]
	public class BuildingGetFurnitureGoodListResponse : PlayerDeltaResponse, IShopGetResposne
	{
		// Token: 0x06006263 RID: 25187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006263")]
		[Address(RVA = "0x1DE9860", Offset = "0x1DE8460", VA = "0x181DE9860")]
		public BuildingGetFurnitureGoodListResponse()
		{
		}

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildingGetFurnitureGoodListResponse.Good> goods;

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x30")]
		public List<BuildingGetFurnitureGoodListResponse.Group> groups;

		// Token: 0x02000634 RID: 1588
		[Token(Token = "0x2000634")]
		public enum FurnShopDisplayPlace
		{
			// Token: 0x04002DC5 RID: 11717
			[Token(Token = "0x4002DC5")]
			BUILDING,
			// Token: 0x04002DC6 RID: 11718
			[Token(Token = "0x4002DC6")]
			ALL
		}

		// Token: 0x02000635 RID: 1589
		[Token(Token = "0x2000635")]
		public class EventGoodData
		{
			// Token: 0x06006264 RID: 25188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006264")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EventGoodData()
			{
			}

			// Token: 0x04002DC7 RID: 11719
			[Token(Token = "0x4002DC7")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04002DC8 RID: 11720
			[Token(Token = "0x4002DC8")]
			[FieldOffset(Offset = "0x18")]
			public int count;

			// Token: 0x04002DC9 RID: 11721
			[Token(Token = "0x4002DC9")]
			[FieldOffset(Offset = "0x20")]
			public string furniId;

			// Token: 0x04002DCA RID: 11722
			[Token(Token = "0x4002DCA")]
			[FieldOffset(Offset = "0x28")]
			public string set;

			// Token: 0x04002DCB RID: 11723
			[Token(Token = "0x4002DCB")]
			[FieldOffset(Offset = "0x30")]
			public int sequence;
		}

		// Token: 0x02000636 RID: 1590
		[Token(Token = "0x2000636")]
		public class Good
		{
			// Token: 0x06006265 RID: 25189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006265")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Good()
			{
			}

			// Token: 0x04002DCC RID: 11724
			[Token(Token = "0x4002DCC")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x04002DCD RID: 11725
			[Token(Token = "0x4002DCD")]
			[FieldOffset(Offset = "0x18")]
			public string furniId;

			// Token: 0x04002DCE RID: 11726
			[Token(Token = "0x4002DCE")]
			[FieldOffset(Offset = "0x20")]
			public string displayName;

			// Token: 0x04002DCF RID: 11727
			[Token(Token = "0x4002DCF")]
			[FieldOffset(Offset = "0x28")]
			public BuildingGetFurnitureGoodListResponse.FurnShopDisplayPlace shopDisplay;

			// Token: 0x04002DD0 RID: 11728
			[Token(Token = "0x4002DD0")]
			[FieldOffset(Offset = "0x2C")]
			public int priceCoin;

			// Token: 0x04002DD1 RID: 11729
			[Token(Token = "0x4002DD1")]
			[FieldOffset(Offset = "0x30")]
			public int priceDia;

			// Token: 0x04002DD2 RID: 11730
			[Token(Token = "0x4002DD2")]
			[FieldOffset(Offset = "0x34")]
			public int discount;

			// Token: 0x04002DD3 RID: 11731
			[Token(Token = "0x4002DD3")]
			[FieldOffset(Offset = "0x38")]
			public int originPriceCoin;

			// Token: 0x04002DD4 RID: 11732
			[Token(Token = "0x4002DD4")]
			[FieldOffset(Offset = "0x3C")]
			public int originPriceDia;

			// Token: 0x04002DD5 RID: 11733
			[Token(Token = "0x4002DD5")]
			[FieldOffset(Offset = "0x40")]
			public long begin;

			// Token: 0x04002DD6 RID: 11734
			[Token(Token = "0x4002DD6")]
			[FieldOffset(Offset = "0x48")]
			public long end;

			// Token: 0x04002DD7 RID: 11735
			[Token(Token = "0x4002DD7")]
			[FieldOffset(Offset = "0x50")]
			public int count;

			// Token: 0x04002DD8 RID: 11736
			[Token(Token = "0x4002DD8")]
			[FieldOffset(Offset = "0x54")]
			public int sequence;
		}

		// Token: 0x02000637 RID: 1591
		[Token(Token = "0x2000637")]
		public class GoodData
		{
			// Token: 0x06006266 RID: 25190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006266")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GoodData()
			{
			}

			// Token: 0x04002DD9 RID: 11737
			[Token(Token = "0x4002DD9")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x04002DDA RID: 11738
			[Token(Token = "0x4002DDA")]
			[FieldOffset(Offset = "0x18")]
			public int count;

			// Token: 0x04002DDB RID: 11739
			[Token(Token = "0x4002DDB")]
			[FieldOffset(Offset = "0x20")]
			public string set;

			// Token: 0x04002DDC RID: 11740
			[Token(Token = "0x4002DDC")]
			[FieldOffset(Offset = "0x28")]
			public int sequence;
		}

		// Token: 0x02000638 RID: 1592
		[Token(Token = "0x2000638")]
		public class Group
		{
			// Token: 0x06006267 RID: 25191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006267")]
			[Address(RVA = "0x1DED5D0", Offset = "0x1DEC1D0", VA = "0x181DED5D0")]
			public Group()
			{
			}

			// Token: 0x04002DDD RID: 11741
			[Token(Token = "0x4002DDD")]
			[FieldOffset(Offset = "0x10")]
			public string packageId;

			// Token: 0x04002DDE RID: 11742
			[Token(Token = "0x4002DDE")]
			[FieldOffset(Offset = "0x18")]
			public string icon;

			// Token: 0x04002DDF RID: 11743
			[Token(Token = "0x4002DDF")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x04002DE0 RID: 11744
			[Token(Token = "0x4002DE0")]
			[FieldOffset(Offset = "0x28")]
			public string description;

			// Token: 0x04002DE1 RID: 11745
			[Token(Token = "0x4002DE1")]
			[FieldOffset(Offset = "0x30")]
			public int sequence;

			// Token: 0x04002DE2 RID: 11746
			[Token(Token = "0x4002DE2")]
			[FieldOffset(Offset = "0x38")]
			public long saleBegin;

			// Token: 0x04002DE3 RID: 11747
			[Token(Token = "0x4002DE3")]
			[FieldOffset(Offset = "0x40")]
			public long saleEnd;

			// Token: 0x04002DE4 RID: 11748
			[Token(Token = "0x4002DE4")]
			[FieldOffset(Offset = "0x48")]
			public int decoration;

			// Token: 0x04002DE5 RID: 11749
			[Token(Token = "0x4002DE5")]
			[FieldOffset(Offset = "0x50")]
			public List<BuildingGetFurnitureGoodListResponse.GoodData> goodList;

			// Token: 0x04002DE6 RID: 11750
			[Token(Token = "0x4002DE6")]
			[FieldOffset(Offset = "0x58")]
			public List<BuildingGetFurnitureGoodListResponse.EventGoodData> eventGoodList;

			// Token: 0x04002DE7 RID: 11751
			[Token(Token = "0x4002DE7")]
			[FieldOffset(Offset = "0x60")]
			public List<PackageImgDisplayData> imageList;
		}
	}
}
