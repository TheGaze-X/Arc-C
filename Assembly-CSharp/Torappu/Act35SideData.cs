using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D0F RID: 3343
	[Token(Token = "0x2000D0F")]
	public class Act35SideData
	{
		// Token: 0x060069E9 RID: 27113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069E9")]
		[Address(RVA = "0x1FF53F0", Offset = "0x1FF3FF0", VA = "0x181FF53F0")]
		public Act35SideData()
		{
		}

		// Token: 0x040044BF RID: 17599
		[Token(Token = "0x40044BF")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act35SideData.Act35SideChallengeData> challengeDataMap;

		// Token: 0x040044C0 RID: 17600
		[Token(Token = "0x40044C0")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act35SideData.Act35SideRoundData> roundDataMap;

		// Token: 0x040044C1 RID: 17601
		[Token(Token = "0x40044C1")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act35SideData.Act35SideChallengeTaskData> taskDataMap;

		// Token: 0x040044C2 RID: 17602
		[Token(Token = "0x40044C2")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act35SideData.Act35SideCardData> cardDataMap;

		// Token: 0x040044C3 RID: 17603
		[Token(Token = "0x40044C3")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act35SideData.Act35SideMaterialData> materialDataMap;

		// Token: 0x040044C4 RID: 17604
		[Token(Token = "0x40044C4")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act35SideData.Act35SideDialogueGroupData> dialogueGroupDataMap;

		// Token: 0x040044C5 RID: 17605
		[Token(Token = "0x40044C5")]
		[FieldOffset(Offset = "0x40")]
		public Act35SideData.Act35SideConstData constData;

		// Token: 0x040044C6 RID: 17606
		[Token(Token = "0x40044C6")]
		[FieldOffset(Offset = "0x48")]
		public List<Act35SideData.Act35SideMileStoneData> mileStoneList;

		// Token: 0x040044C7 RID: 17607
		[Token(Token = "0x40044C7")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, Act35SideData.Act35SideZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x02000D10 RID: 3344
		[Token(Token = "0x2000D10")]
		public class Act35SideChallengeData
		{
			// Token: 0x060069EA RID: 27114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069EA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideChallengeData()
			{
			}

			// Token: 0x040044C8 RID: 17608
			[Token(Token = "0x40044C8")]
			[FieldOffset(Offset = "0x10")]
			public string challengeId;

			// Token: 0x040044C9 RID: 17609
			[Token(Token = "0x40044C9")]
			[FieldOffset(Offset = "0x18")]
			public string challengeName;

			// Token: 0x040044CA RID: 17610
			[Token(Token = "0x40044CA")]
			[FieldOffset(Offset = "0x20")]
			public string challengeDesc;

			// Token: 0x040044CB RID: 17611
			[Token(Token = "0x40044CB")]
			[FieldOffset(Offset = "0x28")]
			public int sortId;

			// Token: 0x040044CC RID: 17612
			[Token(Token = "0x40044CC")]
			[FieldOffset(Offset = "0x30")]
			public string challengePicId;

			// Token: 0x040044CD RID: 17613
			[Token(Token = "0x40044CD")]
			[FieldOffset(Offset = "0x38")]
			public string challengeIconId;

			// Token: 0x040044CE RID: 17614
			[Token(Token = "0x40044CE")]
			[FieldOffset(Offset = "0x40")]
			public long openTime;

			// Token: 0x040044CF RID: 17615
			[Token(Token = "0x40044CF")]
			[FieldOffset(Offset = "0x48")]
			public string preposedChallengeId;

			// Token: 0x040044D0 RID: 17616
			[Token(Token = "0x40044D0")]
			[FieldOffset(Offset = "0x50")]
			public int passRound;

			// Token: 0x040044D1 RID: 17617
			[Token(Token = "0x40044D1")]
			[FieldOffset(Offset = "0x54")]
			public int passRoundScore;

			// Token: 0x040044D2 RID: 17618
			[Token(Token = "0x40044D2")]
			[FieldOffset(Offset = "0x58")]
			public List<string> roundIdList;
		}

		// Token: 0x02000D11 RID: 3345
		[Token(Token = "0x2000D11")]
		public class Act35SideRoundData
		{
			// Token: 0x060069EB RID: 27115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069EB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideRoundData()
			{
			}

			// Token: 0x040044D3 RID: 17619
			[Token(Token = "0x40044D3")]
			[FieldOffset(Offset = "0x10")]
			public string roundId;

			// Token: 0x040044D4 RID: 17620
			[Token(Token = "0x40044D4")]
			[FieldOffset(Offset = "0x18")]
			public string challengeId;

			// Token: 0x040044D5 RID: 17621
			[Token(Token = "0x40044D5")]
			[FieldOffset(Offset = "0x20")]
			public int round;

			// Token: 0x040044D6 RID: 17622
			[Token(Token = "0x40044D6")]
			[FieldOffset(Offset = "0x24")]
			public int roundPassRating;

			// Token: 0x040044D7 RID: 17623
			[Token(Token = "0x40044D7")]
			[FieldOffset(Offset = "0x28")]
			public bool isMaterialRandom;

			// Token: 0x040044D8 RID: 17624
			[Token(Token = "0x40044D8")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, int> fixedMaterialList;

			// Token: 0x040044D9 RID: 17625
			[Token(Token = "0x40044D9")]
			[FieldOffset(Offset = "0x38")]
			public int passRoundCoin;
		}

		// Token: 0x02000D12 RID: 3346
		[Token(Token = "0x2000D12")]
		public class Act35SideChallengeTaskData
		{
			// Token: 0x060069EC RID: 27116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069EC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideChallengeTaskData()
			{
			}

			// Token: 0x040044DA RID: 17626
			[Token(Token = "0x40044DA")]
			[FieldOffset(Offset = "0x10")]
			public string taskId;

			// Token: 0x040044DB RID: 17627
			[Token(Token = "0x40044DB")]
			[FieldOffset(Offset = "0x18")]
			public string taskDesc;

			// Token: 0x040044DC RID: 17628
			[Token(Token = "0x40044DC")]
			[FieldOffset(Offset = "0x20")]
			public string materialId;

			// Token: 0x040044DD RID: 17629
			[Token(Token = "0x40044DD")]
			[FieldOffset(Offset = "0x28")]
			public int materialNum;

			// Token: 0x040044DE RID: 17630
			[Token(Token = "0x40044DE")]
			[FieldOffset(Offset = "0x2C")]
			public int passTaskCoin;
		}

		// Token: 0x02000D13 RID: 3347
		[Token(Token = "0x2000D13")]
		public class Act35SideCardData
		{
			// Token: 0x060069ED RID: 27117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069ED")]
			[Address(RVA = "0x1FF52D0", Offset = "0x1FF3ED0", VA = "0x181FF52D0")]
			public Act35SideCardData()
			{
			}

			// Token: 0x040044DF RID: 17631
			[Token(Token = "0x40044DF")]
			[FieldOffset(Offset = "0x10")]
			public string cardId;

			// Token: 0x040044E0 RID: 17632
			[Token(Token = "0x40044E0")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040044E1 RID: 17633
			[Token(Token = "0x40044E1")]
			[FieldOffset(Offset = "0x1C")]
			public int rank;

			// Token: 0x040044E2 RID: 17634
			[Token(Token = "0x40044E2")]
			[FieldOffset(Offset = "0x20")]
			public string cardFace;

			// Token: 0x040044E3 RID: 17635
			[Token(Token = "0x40044E3")]
			[FieldOffset(Offset = "0x28")]
			public string cardPic;

			// Token: 0x040044E4 RID: 17636
			[Token(Token = "0x40044E4")]
			[FieldOffset(Offset = "0x30")]
			public List<Act35SideData.Act35SideCardLevelData> levelDataList;
		}

		// Token: 0x02000D14 RID: 3348
		[Token(Token = "0x2000D14")]
		public class Act35SideCardLevelData
		{
			// Token: 0x060069EE RID: 27118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069EE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideCardLevelData()
			{
			}

			// Token: 0x040044E5 RID: 17637
			[Token(Token = "0x40044E5")]
			[FieldOffset(Offset = "0x10")]
			public int cardLevel;

			// Token: 0x040044E6 RID: 17638
			[Token(Token = "0x40044E6")]
			[FieldOffset(Offset = "0x18")]
			public string cardName;

			// Token: 0x040044E7 RID: 17639
			[Token(Token = "0x40044E7")]
			[FieldOffset(Offset = "0x20")]
			public string cardDesc;

			// Token: 0x040044E8 RID: 17640
			[Token(Token = "0x40044E8")]
			[FieldOffset(Offset = "0x28")]
			public List<Act35SideData.Act35sideCardMaterialData> inputMaterialList;

			// Token: 0x040044E9 RID: 17641
			[Token(Token = "0x40044E9")]
			[FieldOffset(Offset = "0x30")]
			public List<Act35SideData.Act35sideCardMaterialData> outputMaterialList;
		}

		// Token: 0x02000D15 RID: 3349
		[Token(Token = "0x2000D15")]
		public class Act35sideCardMaterialData
		{
			// Token: 0x060069EF RID: 27119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069EF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35sideCardMaterialData()
			{
			}

			// Token: 0x040044EA RID: 17642
			[Token(Token = "0x40044EA")]
			[FieldOffset(Offset = "0x10")]
			public string materialId;

			// Token: 0x040044EB RID: 17643
			[Token(Token = "0x40044EB")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}

		// Token: 0x02000D16 RID: 3350
		[Token(Token = "0x2000D16")]
		public class Act35SideMaterialData
		{
			// Token: 0x060069F0 RID: 27120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069F0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideMaterialData()
			{
			}

			// Token: 0x040044EC RID: 17644
			[Token(Token = "0x40044EC")]
			[FieldOffset(Offset = "0x10")]
			public string materialId;

			// Token: 0x040044ED RID: 17645
			[Token(Token = "0x40044ED")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040044EE RID: 17646
			[Token(Token = "0x40044EE")]
			[FieldOffset(Offset = "0x20")]
			public string materialIcon;

			// Token: 0x040044EF RID: 17647
			[Token(Token = "0x40044EF")]
			[FieldOffset(Offset = "0x28")]
			public string materialName;

			// Token: 0x040044F0 RID: 17648
			[Token(Token = "0x40044F0")]
			[FieldOffset(Offset = "0x30")]
			public int materialRating;
		}

		// Token: 0x02000D17 RID: 3351
		[Token(Token = "0x2000D17")]
		public class Act35SideMileStoneGrandRewardInfo
		{
			// Token: 0x060069F1 RID: 27121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069F1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideMileStoneGrandRewardInfo()
			{
			}

			// Token: 0x040044F1 RID: 17649
			[Token(Token = "0x40044F1")]
			[FieldOffset(Offset = "0x10")]
			public string itemName;

			// Token: 0x040044F2 RID: 17650
			[Token(Token = "0x40044F2")]
			[FieldOffset(Offset = "0x18")]
			public int level;
		}

		// Token: 0x02000D18 RID: 3352
		[Token(Token = "0x2000D18")]
		public class Act35SideConstData
		{
			// Token: 0x060069F2 RID: 27122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069F2")]
			[Address(RVA = "0x1FF5360", Offset = "0x1FF3F60", VA = "0x181FF5360")]
			public Act35SideConstData()
			{
			}

			// Token: 0x040044F3 RID: 17651
			[Token(Token = "0x40044F3")]
			[FieldOffset(Offset = "0x10")]
			public string campaignStageId;

			// Token: 0x040044F4 RID: 17652
			[Token(Token = "0x40044F4")]
			[FieldOffset(Offset = "0x18")]
			public int campaignEnemyCnt;

			// Token: 0x040044F5 RID: 17653
			[Token(Token = "0x40044F5")]
			[FieldOffset(Offset = "0x20")]
			public List<Act35SideData.Act35SideMileStoneGrandRewardInfo> milestoneGrandRewardInfoList;

			// Token: 0x040044F6 RID: 17654
			[Token(Token = "0x40044F6")]
			[FieldOffset(Offset = "0x28")]
			public string unlockLevelId;

			// Token: 0x040044F7 RID: 17655
			[Token(Token = "0x40044F7")]
			[FieldOffset(Offset = "0x30")]
			public float birdSpineLowRate;

			// Token: 0x040044F8 RID: 17656
			[Token(Token = "0x40044F8")]
			[FieldOffset(Offset = "0x34")]
			public float birdSpineHighRate;

			// Token: 0x040044F9 RID: 17657
			[Token(Token = "0x40044F9")]
			[FieldOffset(Offset = "0x38")]
			public int cardMaxLevel;

			// Token: 0x040044FA RID: 17658
			[Token(Token = "0x40044FA")]
			[FieldOffset(Offset = "0x3C")]
			public int maxSlotCnt;

			// Token: 0x040044FB RID: 17659
			[Token(Token = "0x40044FB")]
			[FieldOffset(Offset = "0x40")]
			public int cardRefreshNum;

			// Token: 0x040044FC RID: 17660
			[Token(Token = "0x40044FC")]
			[FieldOffset(Offset = "0x44")]
			public int initSlotCnt;

			// Token: 0x040044FD RID: 17661
			[Token(Token = "0x40044FD")]
			[FieldOffset(Offset = "0x48")]
			public string bonusMaterialId;

			// Token: 0x040044FE RID: 17662
			[Token(Token = "0x40044FE")]
			[FieldOffset(Offset = "0x50")]
			public List<string> introRoundIdList;

			// Token: 0x040044FF RID: 17663
			[Token(Token = "0x40044FF")]
			[FieldOffset(Offset = "0x58")]
			public string challengeUnlockText;

			// Token: 0x04004500 RID: 17664
			[Token(Token = "0x4004500")]
			[FieldOffset(Offset = "0x60")]
			public string slotUnlockText;

			// Token: 0x04004501 RID: 17665
			[Token(Token = "0x4004501")]
			[FieldOffset(Offset = "0x68")]
			public int estimateRatio;

			// Token: 0x04004502 RID: 17666
			[Token(Token = "0x4004502")]
			[FieldOffset(Offset = "0x70")]
			public string carvingUnlockToastText;
		}

		// Token: 0x02000D19 RID: 3353
		[Token(Token = "0x2000D19")]
		public class Act35SideZoneAdditionData
		{
			// Token: 0x060069F3 RID: 27123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069F3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideZoneAdditionData()
			{
			}

			// Token: 0x04004503 RID: 17667
			[Token(Token = "0x4004503")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004504 RID: 17668
			[Token(Token = "0x4004504")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;
		}

		// Token: 0x02000D1A RID: 3354
		[Token(Token = "0x2000D1A")]
		public class Act35SideMileStoneData
		{
			// Token: 0x060069F4 RID: 27124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069F4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideMileStoneData()
			{
			}

			// Token: 0x04004505 RID: 17669
			[Token(Token = "0x4004505")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x04004506 RID: 17670
			[Token(Token = "0x4004506")]
			[FieldOffset(Offset = "0x18")]
			public int mileStoneLvl;

			// Token: 0x04004507 RID: 17671
			[Token(Token = "0x4004507")]
			[FieldOffset(Offset = "0x1C")]
			public int needPointCnt;

			// Token: 0x04004508 RID: 17672
			[Token(Token = "0x4004508")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle rewardItem;
		}

		// Token: 0x02000D1B RID: 3355
		[Token(Token = "0x2000D1B")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DialogueType
		{
			// Token: 0x0400450A RID: 17674
			[Token(Token = "0x400450A")]
			NONE,
			// Token: 0x0400450B RID: 17675
			[Token(Token = "0x400450B")]
			ENTRY,
			// Token: 0x0400450C RID: 17676
			[Token(Token = "0x400450C")]
			BONUS,
			// Token: 0x0400450D RID: 17677
			[Token(Token = "0x400450D")]
			BUY,
			// Token: 0x0400450E RID: 17678
			[Token(Token = "0x400450E")]
			PROCESS
		}

		// Token: 0x02000D1C RID: 3356
		[Token(Token = "0x2000D1C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DialogueNameBgType
		{
			// Token: 0x04004510 RID: 17680
			[Token(Token = "0x4004510")]
			NONE,
			// Token: 0x04004511 RID: 17681
			[Token(Token = "0x4004511")]
			GREEN,
			// Token: 0x04004512 RID: 17682
			[Token(Token = "0x4004512")]
			BLUE
		}

		// Token: 0x02000D1D RID: 3357
		[Token(Token = "0x2000D1D")]
		public class Act35SideDialogueGroupData
		{
			// Token: 0x060069F5 RID: 27125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069F5")]
			[Address(RVA = "0x1FF5810", Offset = "0x1FF4410", VA = "0x181FF5810")]
			public Act35SideDialogueGroupData()
			{
			}

			// Token: 0x04004513 RID: 17683
			[Token(Token = "0x4004513")]
			[FieldOffset(Offset = "0x10")]
			public Act35SideData.DialogueType type;

			// Token: 0x04004514 RID: 17684
			[Token(Token = "0x4004514")]
			[FieldOffset(Offset = "0x18")]
			public List<Act35SideData.Act35SideDialogueData> dialogDataList;
		}

		// Token: 0x02000D1E RID: 3358
		[Token(Token = "0x2000D1E")]
		public class Act35SideDialogueData : IComparable
		{
			// Token: 0x060069F6 RID: 27126 RVA: 0x00030EE8 File Offset: 0x0002F0E8
			[Token(Token = "0x60069F6")]
			[Address(RVA = "0x1FF5740", Offset = "0x1FF4340", VA = "0x181FF5740", Slot = "4")]
			public int CompareTo(object obj)
			{
				return 0;
			}

			// Token: 0x060069F7 RID: 27127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60069F7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act35SideDialogueData()
			{
			}

			// Token: 0x04004515 RID: 17685
			[Token(Token = "0x4004515")]
			[FieldOffset(Offset = "0x10")]
			public int sortId;

			// Token: 0x04004516 RID: 17686
			[Token(Token = "0x4004516")]
			[FieldOffset(Offset = "0x18")]
			public string iconId;

			// Token: 0x04004517 RID: 17687
			[Token(Token = "0x4004517")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x04004518 RID: 17688
			[Token(Token = "0x4004518")]
			[FieldOffset(Offset = "0x28")]
			public string content;

			// Token: 0x04004519 RID: 17689
			[Token(Token = "0x4004519")]
			[FieldOffset(Offset = "0x30")]
			public Act35SideData.DialogueNameBgType bgType;
		}
	}
}
