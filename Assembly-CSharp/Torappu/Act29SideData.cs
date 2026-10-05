using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D01 RID: 3329
	[Token(Token = "0x2000D01")]
	public class Act29SideData
	{
		// Token: 0x060069DE RID: 27102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069DE")]
		[Address(RVA = "0x1FF4E50", Offset = "0x1FF3A50", VA = "0x181FF4E50")]
		public Act29SideData()
		{
		}

		// Token: 0x04004450 RID: 17488
		[Token(Token = "0x4004450")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act29SideData.Act29SideFragData> fragDataMap;

		// Token: 0x04004451 RID: 17489
		[Token(Token = "0x4004451")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act29SideData.Act29SideOrcheData> orcheDataMap;

		// Token: 0x04004452 RID: 17490
		[Token(Token = "0x4004452")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act29SideData.Act29SideProductGroupData> productGroupDataMap;

		// Token: 0x04004453 RID: 17491
		[Token(Token = "0x4004453")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act29SideData.Act29SideProductData> productDataMap;

		// Token: 0x04004454 RID: 17492
		[Token(Token = "0x4004454")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act29SideData.Act29SideFormData> formDataMap;

		// Token: 0x04004455 RID: 17493
		[Token(Token = "0x4004455")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act29SideData.Act29SideInvestResultData> investResultDataMap;

		// Token: 0x04004456 RID: 17494
		[Token(Token = "0x4004456")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act29SideData.Act29SideInvestData> investDataMap;

		// Token: 0x04004457 RID: 17495
		[Token(Token = "0x4004457")]
		[FieldOffset(Offset = "0x48")]
		public List<string> majorInvestIdList;

		// Token: 0x04004458 RID: 17496
		[Token(Token = "0x4004458")]
		[FieldOffset(Offset = "0x50")]
		public List<string> rareInvestIdList;

		// Token: 0x04004459 RID: 17497
		[Token(Token = "0x4004459")]
		[FieldOffset(Offset = "0x58")]
		public Act29SideData.Act29SideConstData constData;

		// Token: 0x0400445A RID: 17498
		[Token(Token = "0x400445A")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, Act29SideData.Act29SideZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x0400445B RID: 17499
		[Token(Token = "0x400445B")]
		[FieldOffset(Offset = "0x68")]
		public List<Act29SideData.Act29SideMusicData> musicDataMap;

		// Token: 0x02000D02 RID: 3330
		[Token(Token = "0x2000D02")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Act29SideInvestType
		{
			// Token: 0x0400445D RID: 17501
			[Token(Token = "0x400445D")]
			MAJOR,
			// Token: 0x0400445E RID: 17502
			[Token(Token = "0x400445E")]
			RARE,
			// Token: 0x0400445F RID: 17503
			[Token(Token = "0x400445F")]
			NORMAL
		}

		// Token: 0x02000D03 RID: 3331
		[Token(Token = "0x2000D03")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Act29SideProductType
		{
			// Token: 0x04004461 RID: 17505
			[Token(Token = "0x4004461")]
			PRODUCT_TYPE_1,
			// Token: 0x04004462 RID: 17506
			[Token(Token = "0x4004462")]
			PRODUCT_TYPE_2,
			// Token: 0x04004463 RID: 17507
			[Token(Token = "0x4004463")]
			PRODUCT_TYPE_3,
			// Token: 0x04004464 RID: 17508
			[Token(Token = "0x4004464")]
			PRODUCT_TYPE_4,
			// Token: 0x04004465 RID: 17509
			[Token(Token = "0x4004465")]
			PRODUCT_TYPE_5,
			// Token: 0x04004466 RID: 17510
			[Token(Token = "0x4004466")]
			ENUM
		}

		// Token: 0x02000D04 RID: 3332
		[Token(Token = "0x2000D04")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum Act29SideOrcheType
		{
			// Token: 0x04004468 RID: 17512
			[Token(Token = "0x4004468")]
			ORCHE_1,
			// Token: 0x04004469 RID: 17513
			[Token(Token = "0x4004469")]
			ORCHE_2,
			// Token: 0x0400446A RID: 17514
			[Token(Token = "0x400446A")]
			ORCHE_3,
			// Token: 0x0400446B RID: 17515
			[Token(Token = "0x400446B")]
			ENUM
		}

		// Token: 0x02000D05 RID: 3333
		[Token(Token = "0x2000D05")]
		public class Act29SideFragData
		{
			// Token: 0x060069DF RID: 27103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069DF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideFragData()
			{
			}

			// Token: 0x0400446C RID: 17516
			[Token(Token = "0x400446C")]
			[FieldOffset(Offset = "0x10")]
			public string fragId;

			// Token: 0x0400446D RID: 17517
			[Token(Token = "0x400446D")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0400446E RID: 17518
			[Token(Token = "0x400446E")]
			[FieldOffset(Offset = "0x20")]
			public string fragName;

			// Token: 0x0400446F RID: 17519
			[Token(Token = "0x400446F")]
			[FieldOffset(Offset = "0x28")]
			public string fragIcon;

			// Token: 0x04004470 RID: 17520
			[Token(Token = "0x4004470")]
			[FieldOffset(Offset = "0x30")]
			public string fragStoreIcon;
		}

		// Token: 0x02000D06 RID: 3334
		[Token(Token = "0x2000D06")]
		public class Act29SideOrcheData
		{
			// Token: 0x060069E0 RID: 27104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideOrcheData()
			{
			}

			// Token: 0x04004471 RID: 17521
			[Token(Token = "0x4004471")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004472 RID: 17522
			[Token(Token = "0x4004472")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x04004473 RID: 17523
			[Token(Token = "0x4004473")]
			[FieldOffset(Offset = "0x20")]
			public string desc;

			// Token: 0x04004474 RID: 17524
			[Token(Token = "0x4004474")]
			[FieldOffset(Offset = "0x28")]
			public string icon;

			// Token: 0x04004475 RID: 17525
			[Token(Token = "0x4004475")]
			[FieldOffset(Offset = "0x30")]
			public int sortId;

			// Token: 0x04004476 RID: 17526
			[Token(Token = "0x4004476")]
			[FieldOffset(Offset = "0x34")]
			public Act29SideData.Act29SideOrcheType orcheType;
		}

		// Token: 0x02000D07 RID: 3335
		[Token(Token = "0x2000D07")]
		public class Act29SideProductGroupData
		{
			// Token: 0x060069E1 RID: 27105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E1")]
			[Address(RVA = "0x1FF5210", Offset = "0x1FF3E10", VA = "0x181FF5210")]
			public Act29SideProductGroupData()
			{
			}

			// Token: 0x04004477 RID: 17527
			[Token(Token = "0x4004477")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04004478 RID: 17528
			[Token(Token = "0x4004478")]
			[FieldOffset(Offset = "0x18")]
			public string groupName;

			// Token: 0x04004479 RID: 17529
			[Token(Token = "0x4004479")]
			[FieldOffset(Offset = "0x20")]
			public string groupIcon;

			// Token: 0x0400447A RID: 17530
			[Token(Token = "0x400447A")]
			[FieldOffset(Offset = "0x28")]
			public string groupDesc;

			// Token: 0x0400447B RID: 17531
			[Token(Token = "0x400447B")]
			[FieldOffset(Offset = "0x30")]
			public string defaultBgmSignal;

			// Token: 0x0400447C RID: 17532
			[Token(Token = "0x400447C")]
			[FieldOffset(Offset = "0x38")]
			public List<string> productList;

			// Token: 0x0400447D RID: 17533
			[Token(Token = "0x400447D")]
			[FieldOffset(Offset = "0x40")]
			public string groupEngName;

			// Token: 0x0400447E RID: 17534
			[Token(Token = "0x400447E")]
			[FieldOffset(Offset = "0x48")]
			public string groupSmallName;

			// Token: 0x0400447F RID: 17535
			[Token(Token = "0x400447F")]
			[FieldOffset(Offset = "0x50")]
			public string groupTypeIcon;

			// Token: 0x04004480 RID: 17536
			[Token(Token = "0x4004480")]
			[FieldOffset(Offset = "0x58")]
			public string groupStoreIconId;

			// Token: 0x04004481 RID: 17537
			[Token(Token = "0x4004481")]
			[FieldOffset(Offset = "0x60")]
			public string groupTypeBasePic;

			// Token: 0x04004482 RID: 17538
			[Token(Token = "0x4004482")]
			[FieldOffset(Offset = "0x68")]
			public string groupTypeEyeIcon;

			// Token: 0x04004483 RID: 17539
			[Token(Token = "0x4004483")]
			[FieldOffset(Offset = "0x70")]
			public int groupSortId;

			// Token: 0x04004484 RID: 17540
			[Token(Token = "0x4004484")]
			[FieldOffset(Offset = "0x78")]
			public List<string> formList;

			// Token: 0x04004485 RID: 17541
			[Token(Token = "0x4004485")]
			[FieldOffset(Offset = "0x80")]
			public string sheetId;

			// Token: 0x04004486 RID: 17542
			[Token(Token = "0x4004486")]
			[FieldOffset(Offset = "0x88")]
			public int sheetNum;

			// Token: 0x04004487 RID: 17543
			[Token(Token = "0x4004487")]
			[FieldOffset(Offset = "0x8C")]
			public float sheetRotateSpd;

			// Token: 0x04004488 RID: 17544
			[Token(Token = "0x4004488")]
			[FieldOffset(Offset = "0x90")]
			public Act29SideData.Act29SideProductType productType;

			// Token: 0x04004489 RID: 17545
			[Token(Token = "0x4004489")]
			[FieldOffset(Offset = "0x98")]
			public string productDescColor;

			// Token: 0x0400448A RID: 17546
			[Token(Token = "0x400448A")]
			[FieldOffset(Offset = "0xA0")]
			public string playTintColor;

			// Token: 0x0400448B RID: 17547
			[Token(Token = "0x400448B")]
			[FieldOffset(Offset = "0xA8")]
			public string confirmTintColor;

			// Token: 0x0400448C RID: 17548
			[Token(Token = "0x400448C")]
			[FieldOffset(Offset = "0xB0")]
			public string confirmDescColor;

			// Token: 0x0400448D RID: 17549
			[Token(Token = "0x400448D")]
			[FieldOffset(Offset = "0xB8")]
			public string bagThemeColor;
		}

		// Token: 0x02000D08 RID: 3336
		[Token(Token = "0x2000D08")]
		public class Act29SideProductData
		{
			// Token: 0x060069E2 RID: 27106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideProductData()
			{
			}

			// Token: 0x0400448E RID: 17550
			[Token(Token = "0x400448E")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x0400448F RID: 17551
			[Token(Token = "0x400448F")]
			[FieldOffset(Offset = "0x18")]
			public string orcheId;

			// Token: 0x04004490 RID: 17552
			[Token(Token = "0x4004490")]
			[FieldOffset(Offset = "0x20")]
			public string groupId;

			// Token: 0x04004491 RID: 17553
			[Token(Token = "0x4004491")]
			[FieldOffset(Offset = "0x28")]
			public string formId;

			// Token: 0x04004492 RID: 17554
			[Token(Token = "0x4004492")]
			[FieldOffset(Offset = "0x30")]
			public string musicId;
		}

		// Token: 0x02000D09 RID: 3337
		[Token(Token = "0x2000D09")]
		public class Act29SideFormData
		{
			// Token: 0x060069E3 RID: 27107 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideFormData()
			{
			}

			// Token: 0x04004493 RID: 17555
			[Token(Token = "0x4004493")]
			[FieldOffset(Offset = "0x10")]
			public string formId;

			// Token: 0x04004494 RID: 17556
			[Token(Token = "0x4004494")]
			[FieldOffset(Offset = "0x18")]
			public List<string> fragIdList;

			// Token: 0x04004495 RID: 17557
			[Token(Token = "0x4004495")]
			[FieldOffset(Offset = "0x20")]
			public string formDesc;

			// Token: 0x04004496 RID: 17558
			[Token(Token = "0x4004496")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, string> productIdDict;

			// Token: 0x04004497 RID: 17559
			[Token(Token = "0x4004497")]
			[FieldOffset(Offset = "0x30")]
			public string withoutOrcheProductId;

			// Token: 0x04004498 RID: 17560
			[Token(Token = "0x4004498")]
			[FieldOffset(Offset = "0x38")]
			public string groupId;

			// Token: 0x04004499 RID: 17561
			[Token(Token = "0x4004499")]
			[FieldOffset(Offset = "0x40")]
			public int formSortId;
		}

		// Token: 0x02000D0A RID: 3338
		[Token(Token = "0x2000D0A")]
		public class Act29SideInvestResultData
		{
			// Token: 0x060069E4 RID: 27108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideInvestResultData()
			{
			}

			// Token: 0x0400449A RID: 17562
			[Token(Token = "0x400449A")]
			[FieldOffset(Offset = "0x10")]
			public string resultId;

			// Token: 0x0400449B RID: 17563
			[Token(Token = "0x400449B")]
			[FieldOffset(Offset = "0x18")]
			public string resultTitle;

			// Token: 0x0400449C RID: 17564
			[Token(Token = "0x400449C")]
			[FieldOffset(Offset = "0x20")]
			public string resultDesc1;

			// Token: 0x0400449D RID: 17565
			[Token(Token = "0x400449D")]
			[FieldOffset(Offset = "0x28")]
			public string resultDesc2;
		}

		// Token: 0x02000D0B RID: 3339
		[Token(Token = "0x2000D0B")]
		public class Act29SideInvestData
		{
			// Token: 0x060069E5 RID: 27109 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideInvestData()
			{
			}

			// Token: 0x0400449E RID: 17566
			[Token(Token = "0x400449E")]
			[FieldOffset(Offset = "0x10")]
			public string investId;

			// Token: 0x0400449F RID: 17567
			[Token(Token = "0x400449F")]
			[FieldOffset(Offset = "0x18")]
			public Act29SideData.Act29SideInvestType investType;

			// Token: 0x040044A0 RID: 17568
			[Token(Token = "0x40044A0")]
			[FieldOffset(Offset = "0x20")]
			public string investNpcName;

			// Token: 0x040044A1 RID: 17569
			[Token(Token = "0x40044A1")]
			[FieldOffset(Offset = "0x28")]
			public string storyId;

			// Token: 0x040044A2 RID: 17570
			[Token(Token = "0x40044A2")]
			[FieldOffset(Offset = "0x30")]
			public string investNpcPic;

			// Token: 0x040044A3 RID: 17571
			[Token(Token = "0x40044A3")]
			[FieldOffset(Offset = "0x38")]
			public string investNpcAvatarPic;

			// Token: 0x040044A4 RID: 17572
			[Token(Token = "0x40044A4")]
			[FieldOffset(Offset = "0x40")]
			public string majorNpcPic;

			// Token: 0x040044A5 RID: 17573
			[Token(Token = "0x40044A5")]
			[FieldOffset(Offset = "0x48")]
			public string majorNpcBlackPic;

			// Token: 0x040044A6 RID: 17574
			[Token(Token = "0x40044A6")]
			[FieldOffset(Offset = "0x50")]
			public ItemBundle reward;

			// Token: 0x040044A7 RID: 17575
			[Token(Token = "0x40044A7")]
			[FieldOffset(Offset = "0x58")]
			public string investSucResultId;

			// Token: 0x040044A8 RID: 17576
			[Token(Token = "0x40044A8")]
			[FieldOffset(Offset = "0x60")]
			public string investFailResultId;

			// Token: 0x040044A9 RID: 17577
			[Token(Token = "0x40044A9")]
			[FieldOffset(Offset = "0x68")]
			public string investRareResultId;
		}

		// Token: 0x02000D0C RID: 3340
		[Token(Token = "0x2000D0C")]
		public class Act29SideConstData
		{
			// Token: 0x060069E6 RID: 27110 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideConstData()
			{
			}

			// Token: 0x040044AA RID: 17578
			[Token(Token = "0x40044AA")]
			[FieldOffset(Offset = "0x10")]
			public string majorInvestUnlockItemName;

			// Token: 0x040044AB RID: 17579
			[Token(Token = "0x40044AB")]
			[FieldOffset(Offset = "0x18")]
			public int wrongTipsTriggerTime;

			// Token: 0x040044AC RID: 17580
			[Token(Token = "0x40044AC")]
			[FieldOffset(Offset = "0x20")]
			public string majorInvestCompleteImgId;

			// Token: 0x040044AD RID: 17581
			[Token(Token = "0x40044AD")]
			[FieldOffset(Offset = "0x28")]
			public string majorInvestUnknownAvatarId;

			// Token: 0x040044AE RID: 17582
			[Token(Token = "0x40044AE")]
			[FieldOffset(Offset = "0x30")]
			public string majorInvestDetailDesc1;

			// Token: 0x040044AF RID: 17583
			[Token(Token = "0x40044AF")]
			[FieldOffset(Offset = "0x38")]
			public string majorInvestDetailDesc2;

			// Token: 0x040044B0 RID: 17584
			[Token(Token = "0x40044B0")]
			[FieldOffset(Offset = "0x40")]
			public string majorInvestDetailDesc3;

			// Token: 0x040044B1 RID: 17585
			[Token(Token = "0x40044B1")]
			[FieldOffset(Offset = "0x48")]
			public string majorInvestDetailDesc4;

			// Token: 0x040044B2 RID: 17586
			[Token(Token = "0x40044B2")]
			[FieldOffset(Offset = "0x50")]
			public string hiddenInvestImgId;

			// Token: 0x040044B3 RID: 17587
			[Token(Token = "0x40044B3")]
			[FieldOffset(Offset = "0x58")]
			public string hiddenInvestHeadImgId;

			// Token: 0x040044B4 RID: 17588
			[Token(Token = "0x40044B4")]
			[FieldOffset(Offset = "0x60")]
			public string hiddenInvestNpcName;

			// Token: 0x040044B5 RID: 17589
			[Token(Token = "0x40044B5")]
			[FieldOffset(Offset = "0x68")]
			public string unlockLevelId;

			// Token: 0x040044B6 RID: 17590
			[Token(Token = "0x40044B6")]
			[FieldOffset(Offset = "0x70")]
			public string investResultHint;

			// Token: 0x040044B7 RID: 17591
			[Token(Token = "0x40044B7")]
			[FieldOffset(Offset = "0x78")]
			public string investUnlockText;

			// Token: 0x040044B8 RID: 17592
			[Token(Token = "0x40044B8")]
			[FieldOffset(Offset = "0x80")]
			public string noOrcheDesc;

			// Token: 0x040044B9 RID: 17593
			[Token(Token = "0x40044B9")]
			[FieldOffset(Offset = "0x88")]
			public string investTrackId;
		}

		// Token: 0x02000D0D RID: 3341
		[Token(Token = "0x2000D0D")]
		public class Act29SideZoneAdditionData
		{
			// Token: 0x060069E7 RID: 27111 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideZoneAdditionData()
			{
			}

			// Token: 0x040044BA RID: 17594
			[Token(Token = "0x40044BA")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x040044BB RID: 17595
			[Token(Token = "0x40044BB")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;
		}

		// Token: 0x02000D0E RID: 3342
		[Token(Token = "0x2000D0E")]
		public class Act29SideMusicData
		{
			// Token: 0x060069E8 RID: 27112 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069E8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act29SideMusicData()
			{
			}

			// Token: 0x040044BC RID: 17596
			[Token(Token = "0x40044BC")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x040044BD RID: 17597
			[Token(Token = "0x40044BD")]
			[FieldOffset(Offset = "0x18")]
			public string orcheId;

			// Token: 0x040044BE RID: 17598
			[Token(Token = "0x40044BE")]
			[FieldOffset(Offset = "0x20")]
			public string musicId;
		}
	}
}
