using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02001308 RID: 4872
	[Token(Token = "0x2001308")]
	public class ShopClientData
	{
		// Token: 0x06007281 RID: 29313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007281")]
		[Address(RVA = "0x2211230", Offset = "0x220FE30", VA = "0x182211230")]
		public ShopClientData()
		{
		}

		// Token: 0x04006BF6 RID: 27638
		[Token(Token = "0x4006BF6")]
		[FieldOffset(Offset = "0x10")]
		public List<ShopRecommendItem> recommendList;

		// Token: 0x04006BF7 RID: 27639
		[Token(Token = "0x4006BF7")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ShopCreditUnlockGroup> creditUnlockGroup;

		// Token: 0x04006BF8 RID: 27640
		[Token(Token = "0x4006BF8")]
		[FieldOffset(Offset = "0x20")]
		public ShopClientData.ShopKeeperData shopKeeperData;

		// Token: 0x04006BF9 RID: 27641
		[Token(Token = "0x4006BF9")]
		[FieldOffset(Offset = "0x28")]
		public List<ShopCarouselData> carousels;

		// Token: 0x04006BFA RID: 27642
		[Token(Token = "0x4006BFA")]
		[FieldOffset(Offset = "0x30")]
		public List<ChooseShopRelation> chooseShopRelations;

		// Token: 0x04006BFB RID: 27643
		[Token(Token = "0x4006BFB")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ShopUnlockType> shopUnlockDict;

		// Token: 0x04006BFC RID: 27644
		[Token(Token = "0x4006BFC")]
		[FieldOffset(Offset = "0x40")]
		public List<string> extraQCShopRule;

		// Token: 0x04006BFD RID: 27645
		[Token(Token = "0x4006BFD")]
		[FieldOffset(Offset = "0x48")]
		public List<string> repQCShopRule;

		// Token: 0x04006BFE RID: 27646
		[Token(Token = "0x4006BFE")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, ShopClientGPData> shopGPDataDict;

		// Token: 0x04006BFF RID: 27647
		[Token(Token = "0x4006BFF")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, ShopGPTabDisplayData> tabDisplayData;

		// Token: 0x04006C00 RID: 27648
		[Token(Token = "0x4006C00")]
		[FieldOffset(Offset = "0x60")]
		public string shopMonthlySubGoodId;

		// Token: 0x04006C01 RID: 27649
		[Token(Token = "0x4006C01")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("ls")]
		public List<LMTGSShopSchedule> limitedShopSchedule;

		// Token: 0x04006C02 RID: 27650
		[Token(Token = "0x4006C02")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("os")]
		public List<LMTGSShopOverlaySchedule> overlaySchedule;

		// Token: 0x02001309 RID: 4873
		[Token(Token = "0x2001309")]
		public class ShopKeeperData
		{
			// Token: 0x06007282 RID: 29314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007282")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopKeeperData()
			{
			}

			// Token: 0x04006C03 RID: 27651
			[Token(Token = "0x4006C03")]
			[FieldOffset(Offset = "0x10")]
			public List<ShopKeeperWord> welcomeWords;

			// Token: 0x04006C04 RID: 27652
			[Token(Token = "0x4006C04")]
			[FieldOffset(Offset = "0x18")]
			public List<ShopKeeperWord> clickWords;
		}
	}
}
