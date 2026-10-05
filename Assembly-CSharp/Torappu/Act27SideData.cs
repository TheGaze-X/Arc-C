using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000CF7 RID: 3319
	[Token(Token = "0x2000CF7")]
	public class Act27SideData
	{
		// Token: 0x060069D4 RID: 27092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069D4")]
		[Address(RVA = "0x1FF49F0", Offset = "0x1FF35F0", VA = "0x181FF49F0")]
		public Act27SideData()
		{
		}

		// Token: 0x04004416 RID: 17430
		[Token(Token = "0x4004416")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act27SideData.Act27SideGoodData> goodDataMap;

		// Token: 0x04004417 RID: 17431
		[Token(Token = "0x4004417")]
		[FieldOffset(Offset = "0x18")]
		public List<Act27SideData.Act27SideMileStoneData> mileStoneList;

		// Token: 0x04004418 RID: 17432
		[Token(Token = "0x4004418")]
		[FieldOffset(Offset = "0x20")]
		public List<Act27SideData.Act27SideGoodLaunchData> goodLaunchDataList;

		// Token: 0x04004419 RID: 17433
		[Token(Token = "0x4004419")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act27SideData.Act27SideShopData> shopDataMap;

		// Token: 0x0400441A RID: 17434
		[Token(Token = "0x400441A")]
		[FieldOffset(Offset = "0x30")]
		public List<Act27SideData.Act27SideInquireData> inquireDataList;

		// Token: 0x0400441B RID: 17435
		[Token(Token = "0x400441B")]
		[FieldOffset(Offset = "0x38")]
		public List<Act27SideData.Act27SideDynEntrySwitchData> dynEntrySwitchData;

		// Token: 0x0400441C RID: 17436
		[Token(Token = "0x400441C")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act27SideData.Act27sideZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x0400441D RID: 17437
		[Token(Token = "0x400441D")]
		[FieldOffset(Offset = "0x48")]
		public Act27SideData.Act27SideConstData constData;

		// Token: 0x02000CF8 RID: 3320
		[Token(Token = "0x2000CF8")]
		public class Act27SideGoodData
		{
			// Token: 0x060069D5 RID: 27093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069D5")]
			[Address(RVA = "0x1FF4D40", Offset = "0x1FF3940", VA = "0x181FF4D40")]
			public Act27SideGoodData()
			{
			}

			// Token: 0x0400441E RID: 17438
			[Token(Token = "0x400441E")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0400441F RID: 17439
			[Token(Token = "0x400441F")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04004420 RID: 17440
			[Token(Token = "0x4004420")]
			[FieldOffset(Offset = "0x20")]
			public string typeDesc;

			// Token: 0x04004421 RID: 17441
			[Token(Token = "0x4004421")]
			[FieldOffset(Offset = "0x28")]
			public string iconId;

			// Token: 0x04004422 RID: 17442
			[Token(Token = "0x4004422")]
			[FieldOffset(Offset = "0x30")]
			public string launchIconId;

			// Token: 0x04004423 RID: 17443
			[Token(Token = "0x4004423")]
			[FieldOffset(Offset = "0x38")]
			public List<int> purchasePrice;

			// Token: 0x04004424 RID: 17444
			[Token(Token = "0x4004424")]
			[FieldOffset(Offset = "0x40")]
			public List<int> sellingPriceList;

			// Token: 0x04004425 RID: 17445
			[Token(Token = "0x4004425")]
			[FieldOffset(Offset = "0x48")]
			public List<string> sellShopList;

			// Token: 0x04004426 RID: 17446
			[Token(Token = "0x4004426")]
			[FieldOffset(Offset = "0x50")]
			public bool isPermanent;
		}

		// Token: 0x02000CF9 RID: 3321
		[Token(Token = "0x2000CF9")]
		public class Act27SideMileStoneData
		{
			// Token: 0x060069D6 RID: 27094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069D6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act27SideMileStoneData()
			{
			}

			// Token: 0x04004427 RID: 17447
			[Token(Token = "0x4004427")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x04004428 RID: 17448
			[Token(Token = "0x4004428")]
			[FieldOffset(Offset = "0x18")]
			public int mileStoneLvl;

			// Token: 0x04004429 RID: 17449
			[Token(Token = "0x4004429")]
			[FieldOffset(Offset = "0x1C")]
			public int needPointCnt;

			// Token: 0x0400442A RID: 17450
			[Token(Token = "0x400442A")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle rewardItem;
		}

		// Token: 0x02000CFA RID: 3322
		[Token(Token = "0x2000CFA")]
		public class Act27SideGoodLaunchData
		{
			// Token: 0x060069D7 RID: 27095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069D7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act27SideGoodLaunchData()
			{
			}

			// Token: 0x0400442B RID: 17451
			[Token(Token = "0x400442B")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x0400442C RID: 17452
			[Token(Token = "0x400442C")]
			[FieldOffset(Offset = "0x18")]
			public long startTime;

			// Token: 0x0400442D RID: 17453
			[Token(Token = "0x400442D")]
			[FieldOffset(Offset = "0x20")]
			public string stageId;

			// Token: 0x0400442E RID: 17454
			[Token(Token = "0x400442E")]
			[FieldOffset(Offset = "0x28")]
			public string code;

			// Token: 0x0400442F RID: 17455
			[Token(Token = "0x400442F")]
			[FieldOffset(Offset = "0x30")]
			public string drinkId;

			// Token: 0x04004430 RID: 17456
			[Token(Token = "0x4004430")]
			[FieldOffset(Offset = "0x38")]
			public string foodId;

			// Token: 0x04004431 RID: 17457
			[Token(Token = "0x4004431")]
			[FieldOffset(Offset = "0x40")]
			public string souvenirId;
		}

		// Token: 0x02000CFB RID: 3323
		[Token(Token = "0x2000CFB")]
		public class Act27SideShopData
		{
			// Token: 0x060069D8 RID: 27096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069D8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act27SideShopData()
			{
			}

			// Token: 0x04004432 RID: 17458
			[Token(Token = "0x4004432")]
			[FieldOffset(Offset = "0x10")]
			public string shopId;

			// Token: 0x04004433 RID: 17459
			[Token(Token = "0x4004433")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004434 RID: 17460
			[Token(Token = "0x4004434")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x04004435 RID: 17461
			[Token(Token = "0x4004435")]
			[FieldOffset(Offset = "0x28")]
			public string iconId;
		}

		// Token: 0x02000CFC RID: 3324
		[Token(Token = "0x2000CFC")]
		public class Act27SideInquireData
		{
			// Token: 0x060069D9 RID: 27097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069D9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act27SideInquireData()
			{
			}

			// Token: 0x04004436 RID: 17462
			[Token(Token = "0x4004436")]
			[FieldOffset(Offset = "0x10")]
			public int mileStonePt;

			// Token: 0x04004437 RID: 17463
			[Token(Token = "0x4004437")]
			[FieldOffset(Offset = "0x14")]
			public int inquireCount;
		}

		// Token: 0x02000CFD RID: 3325
		[Token(Token = "0x2000CFD")]
		public class Act27SideMileStoneFurniRewardData
		{
			// Token: 0x060069DA RID: 27098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069DA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act27SideMileStoneFurniRewardData()
			{
			}

			// Token: 0x04004438 RID: 17464
			[Token(Token = "0x4004438")]
			[FieldOffset(Offset = "0x10")]
			public string furniId;

			// Token: 0x04004439 RID: 17465
			[Token(Token = "0x4004439")]
			[FieldOffset(Offset = "0x18")]
			public int pointNum;
		}

		// Token: 0x02000CFE RID: 3326
		[Token(Token = "0x2000CFE")]
		public class Act27SideConstData
		{
			// Token: 0x060069DB RID: 27099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069DB")]
			[Address(RVA = "0x1FF4920", Offset = "0x1FF3520", VA = "0x181FF4920")]
			public Act27SideConstData()
			{
			}

			// Token: 0x0400443A RID: 17466
			[Token(Token = "0x400443A")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x0400443B RID: 17467
			[Token(Token = "0x400443B")]
			[FieldOffset(Offset = "0x18")]
			public string stageCode;

			// Token: 0x0400443C RID: 17468
			[Token(Token = "0x400443C")]
			[FieldOffset(Offset = "0x20")]
			public List<string> purchasePriceName;

			// Token: 0x0400443D RID: 17469
			[Token(Token = "0x400443D")]
			[FieldOffset(Offset = "0x28")]
			public List<Act27SideData.Act27SideMileStoneFurniRewardData> furniRewardList;

			// Token: 0x0400443E RID: 17470
			[Token(Token = "0x400443E")]
			[FieldOffset(Offset = "0x30")]
			public string prizeText;

			// Token: 0x0400443F RID: 17471
			[Token(Token = "0x400443F")]
			[FieldOffset(Offset = "0x38")]
			public string playerShopId;

			// Token: 0x04004440 RID: 17472
			[Token(Token = "0x4004440")]
			[FieldOffset(Offset = "0x40")]
			public string milestonePointName;

			// Token: 0x04004441 RID: 17473
			[Token(Token = "0x4004441")]
			[FieldOffset(Offset = "0x48")]
			public string inquirePanelTitle;

			// Token: 0x04004442 RID: 17474
			[Token(Token = "0x4004442")]
			[FieldOffset(Offset = "0x50")]
			public string inquirePanelDesc;

			// Token: 0x04004443 RID: 17475
			[Token(Token = "0x4004443")]
			[FieldOffset(Offset = "0x58")]
			public List<float> gain123;

			// Token: 0x04004444 RID: 17476
			[Token(Token = "0x4004444")]
			[FieldOffset(Offset = "0x60")]
			public List<float> gain113;

			// Token: 0x04004445 RID: 17477
			[Token(Token = "0x4004445")]
			[FieldOffset(Offset = "0x68")]
			public List<float> gain122;

			// Token: 0x04004446 RID: 17478
			[Token(Token = "0x4004446")]
			[FieldOffset(Offset = "0x70")]
			public List<float> gain111;

			// Token: 0x04004447 RID: 17479
			[Token(Token = "0x4004447")]
			[FieldOffset(Offset = "0x78")]
			public List<float> gain11None;

			// Token: 0x04004448 RID: 17480
			[Token(Token = "0x4004448")]
			[FieldOffset(Offset = "0x80")]
			public List<float> gain12None;

			// Token: 0x04004449 RID: 17481
			[Token(Token = "0x4004449")]
			[FieldOffset(Offset = "0x88")]
			public int campaignEnemyCnt;
		}

		// Token: 0x02000CFF RID: 3327
		[Token(Token = "0x2000CFF")]
		public class Act27SideDynEntrySwitchData
		{
			// Token: 0x060069DC RID: 27100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069DC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act27SideDynEntrySwitchData()
			{
			}

			// Token: 0x0400444A RID: 17482
			[Token(Token = "0x400444A")]
			[FieldOffset(Offset = "0x10")]
			public string entryId;

			// Token: 0x0400444B RID: 17483
			[Token(Token = "0x400444B")]
			[FieldOffset(Offset = "0x18")]
			public int startHour;

			// Token: 0x0400444C RID: 17484
			[Token(Token = "0x400444C")]
			[FieldOffset(Offset = "0x20")]
			public string signalId;
		}

		// Token: 0x02000D00 RID: 3328
		[Token(Token = "0x2000D00")]
		public class Act27sideZoneAdditionData
		{
			// Token: 0x060069DD RID: 27101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069DD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act27sideZoneAdditionData()
			{
			}

			// Token: 0x0400444D RID: 17485
			[Token(Token = "0x400444D")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x0400444E RID: 17486
			[Token(Token = "0x400444E")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;

			// Token: 0x0400444F RID: 17487
			[Token(Token = "0x400444F")]
			[FieldOffset(Offset = "0x20")]
			public string displayTime;
		}
	}
}
