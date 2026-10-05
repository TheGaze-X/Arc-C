using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020010B3 RID: 4275
	[Token(Token = "0x20010B3")]
	[Serializable]
	public class ItemData
	{
		// Token: 0x06006E3D RID: 28221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemData()
		{
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E3E")]
		[Address(RVA = "0x21062E0", Offset = "0x2104EE0", VA = "0x1821062E0")]
		public ItemData(string itemId_, string name_, string description_, ItemType type_, ItemRarity rarity_, string iconId_, string overrideBkg_, string stackIconId_, int sortId_, string usage_, string obtainApproach_, ItemClassifyType classifyType_, bool hideInItemGet_)
		{
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x00031FE0 File Offset: 0x000301E0
		[Token(Token = "0x6006E3F")]
		[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
		public bool ShouldSerializehideInItemGet()
		{
			return default(bool);
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x00031FF8 File Offset: 0x000301F8
		[Token(Token = "0x6006E40")]
		[Address(RVA = "0x2106290", Offset = "0x2104E90", VA = "0x182106290")]
		public bool ShouldSerializevoucherRelateList()
		{
			return default(bool);
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x00032010 File Offset: 0x00030210
		[Token(Token = "0x6006E41")]
		[Address(RVA = "0x2106240", Offset = "0x2104E40", VA = "0x182106240")]
		public bool ShouldSerializeshopRelateInfoList()
		{
			return default(bool);
		}

		// Token: 0x04005B84 RID: 23428
		[Token(Token = "0x4005B84")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04005B85 RID: 23429
		[Token(Token = "0x4005B85")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04005B86 RID: 23430
		[Token(Token = "0x4005B86")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04005B87 RID: 23431
		[Token(Token = "0x4005B87")]
		[FieldOffset(Offset = "0x28")]
		public ItemRarity rarity;

		// Token: 0x04005B88 RID: 23432
		[Token(Token = "0x4005B88")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x04005B89 RID: 23433
		[Token(Token = "0x4005B89")]
		[FieldOffset(Offset = "0x38")]
		public string overrideBkg;

		// Token: 0x04005B8A RID: 23434
		[Token(Token = "0x4005B8A")]
		[FieldOffset(Offset = "0x40")]
		public string stackIconId;

		// Token: 0x04005B8B RID: 23435
		[Token(Token = "0x4005B8B")]
		[FieldOffset(Offset = "0x48")]
		public int sortId;

		// Token: 0x04005B8C RID: 23436
		[Token(Token = "0x4005B8C")]
		[FieldOffset(Offset = "0x50")]
		public string usage;

		// Token: 0x04005B8D RID: 23437
		[Token(Token = "0x4005B8D")]
		[FieldOffset(Offset = "0x58")]
		public string obtainApproach;

		// Token: 0x04005B8E RID: 23438
		[Token(Token = "0x4005B8E")]
		[FieldOffset(Offset = "0x60")]
		public bool hideInItemGet;

		// Token: 0x04005B8F RID: 23439
		[Token(Token = "0x4005B8F")]
		[FieldOffset(Offset = "0x64")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemClassifyType classifyType;

		// Token: 0x04005B90 RID: 23440
		[Token(Token = "0x4005B90")]
		[FieldOffset(Offset = "0x68")]
		[JsonConverter(typeof(StringEnumConverter))]
		public ItemType itemType;

		// Token: 0x04005B91 RID: 23441
		[Token(Token = "0x4005B91")]
		[FieldOffset(Offset = "0x70")]
		public List<ItemData.StageDropInfo> stageDropList;

		// Token: 0x04005B92 RID: 23442
		[Token(Token = "0x4005B92")]
		[FieldOffset(Offset = "0x78")]
		public List<ItemData.BuildingProductInfo> buildingProductList;

		// Token: 0x04005B93 RID: 23443
		[Token(Token = "0x4005B93")]
		[FieldOffset(Offset = "0x80")]
		public List<ItemData.VoucherRelateInfo> voucherRelateList;

		// Token: 0x04005B94 RID: 23444
		[Token(Token = "0x4005B94")]
		[FieldOffset(Offset = "0x88")]
		public List<ItemData.ShopRelateInfo> shopRelateInfoList;

		// Token: 0x020010B4 RID: 4276
		[Token(Token = "0x20010B4")]
		[Serializable]
		public class StageDropInfo
		{
			// Token: 0x06006E42 RID: 28226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E42")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StageDropInfo()
			{
			}

			// Token: 0x04005B95 RID: 23445
			[Token(Token = "0x4005B95")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04005B96 RID: 23446
			[Token(Token = "0x4005B96")]
			[FieldOffset(Offset = "0x18")]
			[JsonConverter(typeof(StringEnumConverter))]
			public OccPer occPer;

			// Token: 0x04005B97 RID: 23447
			[Token(Token = "0x4005B97")]
			[FieldOffset(Offset = "0x1C")]
			public int sortId;

			// Token: 0x04005B98 RID: 23448
			[Token(Token = "0x4005B98")]
			[FieldOffset(Offset = "0x20")]
			[JsonIgnore]
			public float ExpectPerAp;
		}

		// Token: 0x020010B5 RID: 4277
		[Token(Token = "0x20010B5")]
		[Serializable]
		public class BuildingProductInfo
		{
			// Token: 0x06006E43 RID: 28227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E43")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuildingProductInfo()
			{
			}

			// Token: 0x04005B99 RID: 23449
			[Token(Token = "0x4005B99")]
			[FieldOffset(Offset = "0x10")]
			[JsonConverter(typeof(StringEnumConverter))]
			public BuildingData.RoomType roomType;

			// Token: 0x04005B9A RID: 23450
			[Token(Token = "0x4005B9A")]
			[FieldOffset(Offset = "0x18")]
			public string formulaId;
		}

		// Token: 0x020010B6 RID: 4278
		[Token(Token = "0x20010B6")]
		[Serializable]
		public class VoucherRelateInfo
		{
			// Token: 0x06006E44 RID: 28228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E44")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public VoucherRelateInfo()
			{
			}

			// Token: 0x04005B9B RID: 23451
			[Token(Token = "0x4005B9B")]
			[FieldOffset(Offset = "0x10")]
			public string voucherId;

			// Token: 0x04005B9C RID: 23452
			[Token(Token = "0x4005B9C")]
			[FieldOffset(Offset = "0x18")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ItemType voucherItemType;
		}

		// Token: 0x020010B7 RID: 4279
		[Token(Token = "0x20010B7")]
		[Serializable]
		public class ShopRelateInfo
		{
			// Token: 0x06006E45 RID: 28229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E45")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopRelateInfo()
			{
			}

			// Token: 0x04005B9D RID: 23453
			[Token(Token = "0x4005B9D")]
			[FieldOffset(Offset = "0x10")]
			public ItemDropShopType shopType;

			// Token: 0x04005B9E RID: 23454
			[Token(Token = "0x4005B9E")]
			[FieldOffset(Offset = "0x14")]
			public int shopGroup;

			// Token: 0x04005B9F RID: 23455
			[Token(Token = "0x4005B9F")]
			[FieldOffset(Offset = "0x18")]
			public long startTs;
		}
	}
}
