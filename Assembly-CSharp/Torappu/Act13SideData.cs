using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C5B RID: 3163
	[Token(Token = "0x2000C5B")]
	public class Act13SideData
	{
		// Token: 0x0600693C RID: 26940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600693C")]
		[Address(RVA = "0x1FF2410", Offset = "0x1FF1010", VA = "0x181FF2410")]
		public Act13SideData()
		{
		}

		// Token: 0x04004071 RID: 16497
		[Token(Token = "0x4004071")]
		[FieldOffset(Offset = "0x10")]
		public Act13SideData.ConstData constData;

		// Token: 0x04004072 RID: 16498
		[Token(Token = "0x4004072")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act13SideData.OrgData> orgDataMap;

		// Token: 0x04004073 RID: 16499
		[Token(Token = "0x4004073")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act13SideData.PrincipalData> principalDataMap;

		// Token: 0x04004074 RID: 16500
		[Token(Token = "0x4004074")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act13SideData.LongTermMissionData> longTermMissionDataMap;

		// Token: 0x04004075 RID: 16501
		[Token(Token = "0x4004075")]
		[FieldOffset(Offset = "0x30")]
		public List<Act13SideData.DailyMissionData> dailyMissionDataList;

		// Token: 0x04004076 RID: 16502
		[Token(Token = "0x4004076")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act13SideData.DailyMissionRewardGroupData> dailyRewardGroupDataMap;

		// Token: 0x04004077 RID: 16503
		[Token(Token = "0x4004077")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act13SideData.ArchiveItemUnlockData> archiveItemUnlockData;

		// Token: 0x04004078 RID: 16504
		[Token(Token = "0x4004078")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, ActivityTable.ActivityHiddenAreaData> hiddenAreaData;

		// Token: 0x04004079 RID: 16505
		[Token(Token = "0x4004079")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, Act13SideData.ZoneAdditionData> zoneAddtionDataMap;

		// Token: 0x02000C5C RID: 3164
		[Token(Token = "0x2000C5C")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum PrestigeRank
		{
			// Token: 0x0400407B RID: 16507
			[Token(Token = "0x400407B")]
			D,
			// Token: 0x0400407C RID: 16508
			[Token(Token = "0x400407C")]
			C,
			// Token: 0x0400407D RID: 16509
			[Token(Token = "0x400407D")]
			B,
			// Token: 0x0400407E RID: 16510
			[Token(Token = "0x400407E")]
			A,
			// Token: 0x0400407F RID: 16511
			[Token(Token = "0x400407F")]
			S
		}

		// Token: 0x02000C5D RID: 3165
		[Token(Token = "0x2000C5D")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ActZoneClass
		{
			// Token: 0x04004081 RID: 16513
			[Token(Token = "0x4004081")]
			NONE,
			// Token: 0x04004082 RID: 16514
			[Token(Token = "0x4004082")]
			NORMAL,
			// Token: 0x04004083 RID: 16515
			[Token(Token = "0x4004083")]
			HIGHLEVEL,
			// Token: 0x04004084 RID: 16516
			[Token(Token = "0x4004084")]
			SUB
		}

		// Token: 0x02000C5E RID: 3166
		[Token(Token = "0x2000C5E")]
		public class ZoneAdditionData
		{
			// Token: 0x0600693D RID: 26941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600693D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneAdditionData()
			{
			}

			// Token: 0x04004085 RID: 16517
			[Token(Token = "0x4004085")]
			[FieldOffset(Offset = "0x10")]
			public string unlockText;

			// Token: 0x04004086 RID: 16518
			[Token(Token = "0x4004086")]
			[FieldOffset(Offset = "0x18")]
			public Act13SideData.ActZoneClass zoneClass;
		}

		// Token: 0x02000C5F RID: 3167
		[Token(Token = "0x2000C5F")]
		public class ConstData
		{
			// Token: 0x0600693E RID: 26942 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600693E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004087 RID: 16519
			[Token(Token = "0x4004087")]
			[FieldOffset(Offset = "0x10")]
			public List<string> prestigeDescList;

			// Token: 0x04004088 RID: 16520
			[Token(Token = "0x4004088")]
			[FieldOffset(Offset = "0x18")]
			public List<List<int>> dailyRandomCount;

			// Token: 0x04004089 RID: 16521
			[Token(Token = "0x4004089")]
			[FieldOffset(Offset = "0x20")]
			public int dailyWeightInitial;

			// Token: 0x0400408A RID: 16522
			[Token(Token = "0x400408A")]
			[FieldOffset(Offset = "0x24")]
			public int dailyWeightComplete;

			// Token: 0x0400408B RID: 16523
			[Token(Token = "0x400408B")]
			[FieldOffset(Offset = "0x28")]
			public int agendaRecover;

			// Token: 0x0400408C RID: 16524
			[Token(Token = "0x400408C")]
			[FieldOffset(Offset = "0x2C")]
			public int agendaMax;

			// Token: 0x0400408D RID: 16525
			[Token(Token = "0x400408D")]
			[FieldOffset(Offset = "0x30")]
			public int agendaHint;

			// Token: 0x0400408E RID: 16526
			[Token(Token = "0x400408E")]
			[FieldOffset(Offset = "0x34")]
			public int missionPoolMax;

			// Token: 0x0400408F RID: 16527
			[Token(Token = "0x400408F")]
			[FieldOffset(Offset = "0x38")]
			public int missionBoardMax;

			// Token: 0x04004090 RID: 16528
			[Token(Token = "0x4004090")]
			[FieldOffset(Offset = "0x40")]
			public List<ItemBundle> itemRandomList;

			// Token: 0x04004091 RID: 16529
			[Token(Token = "0x4004091")]
			[FieldOffset(Offset = "0x48")]
			public string unlockPrestigeCond;

			// Token: 0x04004092 RID: 16530
			[Token(Token = "0x4004092")]
			[FieldOffset(Offset = "0x50")]
			public long hotSpotShowFlag;
		}

		// Token: 0x02000C60 RID: 3168
		[Token(Token = "0x2000C60")]
		public class OrgData
		{
			// Token: 0x0600693F RID: 26943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600693F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OrgData()
			{
			}

			// Token: 0x04004093 RID: 16531
			[Token(Token = "0x4004093")]
			[FieldOffset(Offset = "0x10")]
			public string orgId;

			// Token: 0x04004094 RID: 16532
			[Token(Token = "0x4004094")]
			[FieldOffset(Offset = "0x18")]
			public string orgName;

			// Token: 0x04004095 RID: 16533
			[Token(Token = "0x4004095")]
			[FieldOffset(Offset = "0x20")]
			public string orgEnName;

			// Token: 0x04004096 RID: 16534
			[Token(Token = "0x4004096")]
			[FieldOffset(Offset = "0x28")]
			public long openTime;

			// Token: 0x04004097 RID: 16535
			[Token(Token = "0x4004097")]
			[FieldOffset(Offset = "0x30")]
			public List<string> principalIdList;

			// Token: 0x04004098 RID: 16536
			[Token(Token = "0x4004098")]
			[FieldOffset(Offset = "0x38")]
			public List<Act13SideData.PrestigeData> prestigeList;

			// Token: 0x04004099 RID: 16537
			[Token(Token = "0x4004099")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<int, ItemBundle> agendaCount2PrestigeItemMap;

			// Token: 0x0400409A RID: 16538
			[Token(Token = "0x400409A")]
			[FieldOffset(Offset = "0x48")]
			public List<Act13SideData.OrgSectionData> orgSectionList;

			// Token: 0x0400409B RID: 16539
			[Token(Token = "0x400409B")]
			[FieldOffset(Offset = "0x50")]
			public ItemBundle prestigeItem;
		}

		// Token: 0x02000C61 RID: 3169
		[Token(Token = "0x2000C61")]
		public class PrincipalData
		{
			// Token: 0x06006940 RID: 26944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006940")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PrincipalData()
			{
			}

			// Token: 0x0400409C RID: 16540
			[Token(Token = "0x400409C")]
			[FieldOffset(Offset = "0x10")]
			public string principalId;

			// Token: 0x0400409D RID: 16541
			[Token(Token = "0x400409D")]
			[FieldOffset(Offset = "0x18")]
			public string principalName;

			// Token: 0x0400409E RID: 16542
			[Token(Token = "0x400409E")]
			[FieldOffset(Offset = "0x20")]
			public string principalEnName;

			// Token: 0x0400409F RID: 16543
			[Token(Token = "0x400409F")]
			[FieldOffset(Offset = "0x28")]
			public string avgCharId;

			// Token: 0x040040A0 RID: 16544
			[Token(Token = "0x40040A0")]
			[FieldOffset(Offset = "0x30")]
			public List<string> principalDescList;
		}

		// Token: 0x02000C62 RID: 3170
		[Token(Token = "0x2000C62")]
		public class PrestigeData
		{
			// Token: 0x06006941 RID: 26945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006941")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PrestigeData()
			{
			}

			// Token: 0x040040A1 RID: 16545
			[Token(Token = "0x40040A1")]
			[FieldOffset(Offset = "0x10")]
			public Act13SideData.PrestigeRank rank;

			// Token: 0x040040A2 RID: 16546
			[Token(Token = "0x40040A2")]
			[FieldOffset(Offset = "0x14")]
			public int threshold;

			// Token: 0x040040A3 RID: 16547
			[Token(Token = "0x40040A3")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle reward;

			// Token: 0x040040A4 RID: 16548
			[Token(Token = "0x40040A4")]
			[FieldOffset(Offset = "0x20")]
			public int newsCount;

			// Token: 0x040040A5 RID: 16549
			[Token(Token = "0x40040A5")]
			[FieldOffset(Offset = "0x24")]
			public int archiveCount;

			// Token: 0x040040A6 RID: 16550
			[Token(Token = "0x40040A6")]
			[FieldOffset(Offset = "0x28")]
			public int avgCount;
		}

		// Token: 0x02000C63 RID: 3171
		[Token(Token = "0x2000C63")]
		public class OrgSectionData
		{
			// Token: 0x06006942 RID: 26946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006942")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public OrgSectionData()
			{
			}

			// Token: 0x040040A7 RID: 16551
			[Token(Token = "0x40040A7")]
			[FieldOffset(Offset = "0x10")]
			public string sectionName;

			// Token: 0x040040A8 RID: 16552
			[Token(Token = "0x40040A8")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040040A9 RID: 16553
			[Token(Token = "0x40040A9")]
			[FieldOffset(Offset = "0x20")]
			public Act13SideData.LongTermMissionGroupData groupData;
		}

		// Token: 0x02000C64 RID: 3172
		[Token(Token = "0x2000C64")]
		public class LongTermMissionGroupData
		{
			// Token: 0x06006943 RID: 26947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006943")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LongTermMissionGroupData()
			{
			}

			// Token: 0x040040AA RID: 16554
			[Token(Token = "0x40040AA")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x040040AB RID: 16555
			[Token(Token = "0x40040AB")]
			[FieldOffset(Offset = "0x18")]
			public string groupName;

			// Token: 0x040040AC RID: 16556
			[Token(Token = "0x40040AC")]
			[FieldOffset(Offset = "0x20")]
			public string orgId;

			// Token: 0x040040AD RID: 16557
			[Token(Token = "0x40040AD")]
			[FieldOffset(Offset = "0x28")]
			public List<string> missionList;
		}

		// Token: 0x02000C65 RID: 3173
		[Token(Token = "0x2000C65")]
		public class LongTermMissionData
		{
			// Token: 0x06006944 RID: 26948 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006944")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LongTermMissionData()
			{
			}

			// Token: 0x040040AE RID: 16558
			[Token(Token = "0x40040AE")]
			[FieldOffset(Offset = "0x10")]
			public string missionName;

			// Token: 0x040040AF RID: 16559
			[Token(Token = "0x40040AF")]
			[FieldOffset(Offset = "0x18")]
			public string groupId;

			// Token: 0x040040B0 RID: 16560
			[Token(Token = "0x40040B0")]
			[FieldOffset(Offset = "0x20")]
			public string principalId;

			// Token: 0x040040B1 RID: 16561
			[Token(Token = "0x40040B1")]
			[FieldOffset(Offset = "0x28")]
			public string finishedDesc;

			// Token: 0x040040B2 RID: 16562
			[Token(Token = "0x40040B2")]
			[FieldOffset(Offset = "0x30")]
			public int sectionSortId;

			// Token: 0x040040B3 RID: 16563
			[Token(Token = "0x40040B3")]
			[FieldOffset(Offset = "0x34")]
			public bool haveStageBtn;

			// Token: 0x040040B4 RID: 16564
			[Token(Token = "0x40040B4")]
			[FieldOffset(Offset = "0x38")]
			public string jumpStageId;
		}

		// Token: 0x02000C66 RID: 3174
		[Token(Token = "0x2000C66")]
		public class DailyMissionData
		{
			// Token: 0x06006945 RID: 26949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006945")]
			[Address(RVA = "0x2008C10", Offset = "0x2007810", VA = "0x182008C10")]
			public DailyMissionData()
			{
			}

			// Token: 0x040040B5 RID: 16565
			[Token(Token = "0x40040B5")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040040B6 RID: 16566
			[Token(Token = "0x40040B6")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040040B7 RID: 16567
			[Token(Token = "0x40040B7")]
			[FieldOffset(Offset = "0x20")]
			public string description;

			// Token: 0x040040B8 RID: 16568
			[Token(Token = "0x40040B8")]
			[FieldOffset(Offset = "0x28")]
			public string missionName;

			// Token: 0x040040B9 RID: 16569
			[Token(Token = "0x40040B9")]
			[FieldOffset(Offset = "0x30")]
			public string template;

			// Token: 0x040040BA RID: 16570
			[Token(Token = "0x40040BA")]
			[FieldOffset(Offset = "0x38")]
			public string templateType;

			// Token: 0x040040BB RID: 16571
			[Token(Token = "0x40040BB")]
			[FieldOffset(Offset = "0x40")]
			public string[] param;

			// Token: 0x040040BC RID: 16572
			[Token(Token = "0x40040BC")]
			[FieldOffset(Offset = "0x48")]
			public List<MissionDisplayRewards> rewards;

			// Token: 0x040040BD RID: 16573
			[Token(Token = "0x40040BD")]
			[FieldOffset(Offset = "0x50")]
			public List<string> orgPool;

			// Token: 0x040040BE RID: 16574
			[Token(Token = "0x40040BE")]
			[FieldOffset(Offset = "0x58")]
			public List<string> rewardPool;

			// Token: 0x040040BF RID: 16575
			[Token(Token = "0x40040BF")]
			[FieldOffset(Offset = "0x60")]
			public string jumpStageId;

			// Token: 0x040040C0 RID: 16576
			[Token(Token = "0x40040C0")]
			[FieldOffset(Offset = "0x68")]
			public int agendaCount;
		}

		// Token: 0x02000C67 RID: 3175
		[Token(Token = "0x2000C67")]
		public class DailyMissionRewardGroupData
		{
			// Token: 0x06006946 RID: 26950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006946")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DailyMissionRewardGroupData()
			{
			}

			// Token: 0x040040C1 RID: 16577
			[Token(Token = "0x40040C1")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x040040C2 RID: 16578
			[Token(Token = "0x40040C2")]
			[FieldOffset(Offset = "0x18")]
			public List<ItemBundle> rewards;
		}

		// Token: 0x02000C68 RID: 3176
		[Token(Token = "0x2000C68")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum UnlockCondition
		{
			// Token: 0x040040C4 RID: 16580
			[Token(Token = "0x40040C4")]
			NONE,
			// Token: 0x040040C5 RID: 16581
			[Token(Token = "0x40040C5")]
			PRESTIGE,
			// Token: 0x040040C6 RID: 16582
			[Token(Token = "0x40040C6")]
			STAGE
		}

		// Token: 0x02000C69 RID: 3177
		[Token(Token = "0x2000C69")]
		public class ArchiveItemUnlockData
		{
			// Token: 0x06006947 RID: 26951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006947")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArchiveItemUnlockData()
			{
			}

			// Token: 0x040040C7 RID: 16583
			[Token(Token = "0x40040C7")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x040040C8 RID: 16584
			[Token(Token = "0x40040C8")]
			[FieldOffset(Offset = "0x18")]
			public ActArchiveType itemType;

			// Token: 0x040040C9 RID: 16585
			[Token(Token = "0x40040C9")]
			[FieldOffset(Offset = "0x1C")]
			public Act13SideData.UnlockCondition unlockCondition;

			// Token: 0x040040CA RID: 16586
			[Token(Token = "0x40040CA")]
			[FieldOffset(Offset = "0x20")]
			public string param1;

			// Token: 0x040040CB RID: 16587
			[Token(Token = "0x40040CB")]
			[FieldOffset(Offset = "0x28")]
			public string param2;
		}
	}
}
