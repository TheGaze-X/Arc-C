using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D71 RID: 15729
	[Token(Token = "0x2003D71")]
	public class TemplateShopData
	{
		// Token: 0x060187CE RID: 100302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187CE")]
		[Address(RVA = "0x111A1F0", Offset = "0x1118DF0", VA = "0x18111A1F0")]
		public TemplateShopData()
		{
		}

		// Token: 0x0401DFFB RID: 122875
		[Token(Token = "0x401DFFB")]
		[FieldOffset(Offset = "0x10")]
		public string shopId;

		// Token: 0x0401DFFC RID: 122876
		[Token(Token = "0x401DFFC")]
		[FieldOffset(Offset = "0x18")]
		public string shopName;

		// Token: 0x0401DFFD RID: 122877
		[Token(Token = "0x401DFFD")]
		[FieldOffset(Offset = "0x20")]
		public TemplateShopData.TShopType type;

		// Token: 0x0401DFFE RID: 122878
		[Token(Token = "0x401DFFE")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle price;

		// Token: 0x0401DFFF RID: 122879
		[Token(Token = "0x401DFFF")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, TemplateShopData.TShopGroup> shopGroup;

		// Token: 0x0401E000 RID: 122880
		[Token(Token = "0x401E000")]
		[FieldOffset(Offset = "0x38")]
		public string iconColorCodes;

		// Token: 0x0401E001 RID: 122881
		[Token(Token = "0x401E001")]
		[FieldOffset(Offset = "0x40")]
		public string buttonColorCodes;

		// Token: 0x0401E002 RID: 122882
		[Token(Token = "0x401E002")]
		[FieldOffset(Offset = "0x48")]
		public long startTime;

		// Token: 0x0401E003 RID: 122883
		[Token(Token = "0x401E003")]
		[FieldOffset(Offset = "0x50")]
		public long endTime;

		// Token: 0x0401E004 RID: 122884
		[Token(Token = "0x401E004")]
		[FieldOffset(Offset = "0x58")]
		public TemplateShopData.GroupShopExtraData groupExtraData;

		// Token: 0x02003D72 RID: 15730
		[Token(Token = "0x2003D72")]
		public class GroupShopExtraData
		{
			// Token: 0x060187CF RID: 100303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60187CF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GroupShopExtraData()
			{
			}

			// Token: 0x0401E005 RID: 122885
			[Token(Token = "0x401E005")]
			[FieldOffset(Offset = "0x10")]
			public string inTimeText;

			// Token: 0x0401E006 RID: 122886
			[Token(Token = "0x401E006")]
			[FieldOffset(Offset = "0x18")]
			public string allEndText;
		}

		// Token: 0x02003D73 RID: 15731
		[Token(Token = "0x2003D73")]
		public enum TShopType
		{
			// Token: 0x0401E008 RID: 122888
			[Token(Token = "0x401E008")]
			NORMAL,
			// Token: 0x0401E009 RID: 122889
			[Token(Token = "0x401E009")]
			SHOP_RARITY_GROUP,
			// Token: 0x0401E00A RID: 122890
			[Token(Token = "0x401E00A")]
			SHOP_PERIOD_UNLOCK
		}

		// Token: 0x02003D74 RID: 15732
		[Token(Token = "0x2003D74")]
		public enum GoodType
		{
			// Token: 0x0401E00C RID: 122892
			[Token(Token = "0x401E00C")]
			NORMAL,
			// Token: 0x0401E00D RID: 122893
			[Token(Token = "0x401E00D")]
			PROGRESS
		}

		// Token: 0x02003D75 RID: 15733
		[Token(Token = "0x2003D75")]
		public class TShopGroup
		{
			// Token: 0x060187D0 RID: 100304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60187D0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TShopGroup()
			{
			}

			// Token: 0x0401E00E RID: 122894
			[Token(Token = "0x401E00E")]
			[FieldOffset(Offset = "0x10")]
			public string shopGroupId;

			// Token: 0x0401E00F RID: 122895
			[Token(Token = "0x401E00F")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0401E010 RID: 122896
			[Token(Token = "0x401E010")]
			[FieldOffset(Offset = "0x20")]
			public string preGroup;

			// Token: 0x0401E011 RID: 122897
			[Token(Token = "0x401E011")]
			[FieldOffset(Offset = "0x28")]
			public string bkgIconId;

			// Token: 0x0401E012 RID: 122898
			[Token(Token = "0x401E012")]
			[FieldOffset(Offset = "0x30")]
			public string lockDesc;

			// Token: 0x0401E013 RID: 122899
			[Token(Token = "0x401E013")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, TemplateShopData.ShopGood> shopGood;

			// Token: 0x0401E014 RID: 122900
			[Token(Token = "0x401E014")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, List<TemplateShopData.ProgessGoodItem>> progressGoods;
		}

		// Token: 0x02003D76 RID: 15734
		[Token(Token = "0x2003D76")]
		public class ProgessGoodItem
		{
			// Token: 0x060187D1 RID: 100305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60187D1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ProgessGoodItem()
			{
			}

			// Token: 0x0401E015 RID: 122901
			[Token(Token = "0x401E015")]
			[FieldOffset(Offset = "0x10")]
			public int order;

			// Token: 0x0401E016 RID: 122902
			[Token(Token = "0x401E016")]
			[FieldOffset(Offset = "0x14")]
			public int price;

			// Token: 0x0401E017 RID: 122903
			[Token(Token = "0x401E017")]
			[FieldOffset(Offset = "0x18")]
			public string displayName;

			// Token: 0x0401E018 RID: 122904
			[Token(Token = "0x401E018")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle item;
		}

		// Token: 0x02003D77 RID: 15735
		[Token(Token = "0x2003D77")]
		public class ShopGood
		{
			// Token: 0x060187D2 RID: 100306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60187D2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopGood()
			{
			}

			// Token: 0x0401E019 RID: 122905
			[Token(Token = "0x401E019")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x0401E01A RID: 122906
			[Token(Token = "0x401E01A")]
			[FieldOffset(Offset = "0x18")]
			public string displayName;

			// Token: 0x0401E01B RID: 122907
			[Token(Token = "0x401E01B")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x0401E01C RID: 122908
			[Token(Token = "0x401E01C")]
			[FieldOffset(Offset = "0x24")]
			public TemplateShopData.GoodType goodType;

			// Token: 0x0401E01D RID: 122909
			[Token(Token = "0x401E01D")]
			[FieldOffset(Offset = "0x28")]
			public ItemBundle item;

			// Token: 0x0401E01E RID: 122910
			[Token(Token = "0x401E01E")]
			[FieldOffset(Offset = "0x30")]
			public string progressGoodId;

			// Token: 0x0401E01F RID: 122911
			[Token(Token = "0x401E01F")]
			[FieldOffset(Offset = "0x38")]
			public int price;

			// Token: 0x0401E020 RID: 122912
			[Token(Token = "0x401E020")]
			[FieldOffset(Offset = "0x3C")]
			public int availCount;
		}
	}
}
