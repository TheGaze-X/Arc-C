using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DD2 RID: 3538
	[Token(Token = "0x2000DD2")]
	public class ActivityBossRushData
	{
		// Token: 0x06006A9E RID: 27294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A9E")]
		[Address(RVA = "0x1FFAB40", Offset = "0x1FF9740", VA = "0x181FFAB40")]
		public ActivityBossRushData()
		{
		}

		// Token: 0x0400496A RID: 18794
		[Token(Token = "0x400496A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActivityBossRushData.ZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x0400496B RID: 18795
		[Token(Token = "0x400496B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActivityBossRushData.BossRushStageGroupData> stageGroupMap;

		// Token: 0x0400496C RID: 18796
		[Token(Token = "0x400496C")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ActivityBossRushData.BossRushStageAdditionData> stageAdditionDataMap;

		// Token: 0x0400496D RID: 18797
		[Token(Token = "0x400496D")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Dictionary<int, ActivityBossRushData.BossRushDropInfo>> stageDropDataMap;

		// Token: 0x0400496E RID: 18798
		[Token(Token = "0x400496E")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ActivityBossRushData.BossRushMissionAdditionData> missionAdditionDataMap;

		// Token: 0x0400496F RID: 18799
		[Token(Token = "0x400496F")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ActivityBossRushData.BossRushTeamData> teamDataMap;

		// Token: 0x04004970 RID: 18800
		[Token(Token = "0x4004970")]
		[FieldOffset(Offset = "0x40")]
		public List<ActivityBossRushData.RelicData> relicList;

		// Token: 0x04004971 RID: 18801
		[Token(Token = "0x4004971")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, ActivityBossRushData.RelicLevelInfoData> relicLevelInfoDataMap;

		// Token: 0x04004972 RID: 18802
		[Token(Token = "0x4004972")]
		[FieldOffset(Offset = "0x50")]
		public List<ActivityBossRushData.BossRushMileStoneData> mileStoneList;

		// Token: 0x04004973 RID: 18803
		[Token(Token = "0x4004973")]
		[FieldOffset(Offset = "0x58")]
		public List<RuneTable.PackedRuneData> bestWaveRuneList;

		// Token: 0x04004974 RID: 18804
		[Token(Token = "0x4004974")]
		[FieldOffset(Offset = "0x60")]
		public ActivityBossRushData.ConstData constData;

		// Token: 0x02000DD3 RID: 3539
		[Token(Token = "0x2000DD3")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum BossRushStageType
		{
			// Token: 0x04004976 RID: 18806
			[Token(Token = "0x4004976")]
			NONE,
			// Token: 0x04004977 RID: 18807
			[Token(Token = "0x4004977")]
			NORMAL,
			// Token: 0x04004978 RID: 18808
			[Token(Token = "0x4004978")]
			TEAM,
			// Token: 0x04004979 RID: 18809
			[Token(Token = "0x4004979")]
			EX,
			// Token: 0x0400497A RID: 18810
			[Token(Token = "0x400497A")]
			SP
		}

		// Token: 0x02000DD4 RID: 3540
		[Token(Token = "0x2000DD4")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum BossRushPrincipleDialogType
		{
			// Token: 0x0400497C RID: 18812
			[Token(Token = "0x400497C")]
			NONE
		}

		// Token: 0x02000DD5 RID: 3541
		[Token(Token = "0x2000DD5")]
		public class ZoneAdditionData
		{
			// Token: 0x06006A9F RID: 27295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A9F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneAdditionData()
			{
			}

			// Token: 0x0400497D RID: 18813
			[Token(Token = "0x400497D")]
			[FieldOffset(Offset = "0x10")]
			public string unlockText;

			// Token: 0x0400497E RID: 18814
			[Token(Token = "0x400497E")]
			[FieldOffset(Offset = "0x18")]
			public long displayStartTime;
		}

		// Token: 0x02000DD6 RID: 3542
		[Token(Token = "0x2000DD6")]
		public class BossRushStageGroupData
		{
			// Token: 0x06006AA0 RID: 27296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AA0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BossRushStageGroupData()
			{
			}

			// Token: 0x0400497F RID: 18815
			[Token(Token = "0x400497F")]
			[FieldOffset(Offset = "0x10")]
			public string stageGroupId;

			// Token: 0x04004980 RID: 18816
			[Token(Token = "0x4004980")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004981 RID: 18817
			[Token(Token = "0x4004981")]
			[FieldOffset(Offset = "0x20")]
			public string stageGroupName;

			// Token: 0x04004982 RID: 18818
			[Token(Token = "0x4004982")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<ActivityBossRushData.BossRushStageType, string> stageIdMap;

			// Token: 0x04004983 RID: 18819
			[Token(Token = "0x4004983")]
			[FieldOffset(Offset = "0x30")]
			public List<List<string>> waveBossInfo;

			// Token: 0x04004984 RID: 18820
			[Token(Token = "0x4004984")]
			[FieldOffset(Offset = "0x38")]
			public int normalStageCount;

			// Token: 0x04004985 RID: 18821
			[Token(Token = "0x4004985")]
			[FieldOffset(Offset = "0x3C")]
			public bool isHardStageGroup;

			// Token: 0x04004986 RID: 18822
			[Token(Token = "0x4004986")]
			[FieldOffset(Offset = "0x40")]
			public string unlockCondtion;
		}

		// Token: 0x02000DD7 RID: 3543
		[Token(Token = "0x2000DD7")]
		public class BossRushStageAdditionData
		{
			// Token: 0x06006AA1 RID: 27297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AA1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BossRushStageAdditionData()
			{
			}

			// Token: 0x04004987 RID: 18823
			[Token(Token = "0x4004987")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004988 RID: 18824
			[Token(Token = "0x4004988")]
			[FieldOffset(Offset = "0x18")]
			public ActivityBossRushData.BossRushStageType stageType;

			// Token: 0x04004989 RID: 18825
			[Token(Token = "0x4004989")]
			[FieldOffset(Offset = "0x20")]
			public string stageGroupId;

			// Token: 0x0400498A RID: 18826
			[Token(Token = "0x400498A")]
			[FieldOffset(Offset = "0x28")]
			public List<string> teamIdList;

			// Token: 0x0400498B RID: 18827
			[Token(Token = "0x400498B")]
			[FieldOffset(Offset = "0x30")]
			public string unlockText;
		}

		// Token: 0x02000DD8 RID: 3544
		[Token(Token = "0x2000DD8")]
		public class BossRushDropInfo
		{
			// Token: 0x06006AA2 RID: 27298 RVA: 0x000310B0 File Offset: 0x0002F2B0
			[Token(Token = "0x6006AA2")]
			[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60")]
			public bool ShouldSerializefirstPassRewards()
			{
				return default(bool);
			}

			// Token: 0x06006AA3 RID: 27299 RVA: 0x000310C8 File Offset: 0x0002F2C8
			[Token(Token = "0x6006AA3")]
			[Address(RVA = "0x5C59B0", Offset = "0x5C45B0", VA = "0x1805C59B0")]
			public bool ShouldSerializepassRewards()
			{
				return default(bool);
			}

			// Token: 0x06006AA4 RID: 27300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AA4")]
			[Address(RVA = "0x2005EB0", Offset = "0x2004AB0", VA = "0x182005EB0")]
			public BossRushDropInfo()
			{
			}

			// Token: 0x0400498C RID: 18828
			[Token(Token = "0x400498C")]
			[FieldOffset(Offset = "0x10")]
			public int clearWaveCount;

			// Token: 0x0400498D RID: 18829
			[Token(Token = "0x400498D")]
			[FieldOffset(Offset = "0x18")]
			public List<ActivityBossRushData.DisplayDetailRewards> displayDetailRewards;

			// Token: 0x0400498E RID: 18830
			[Token(Token = "0x400498E")]
			[FieldOffset(Offset = "0x20")]
			public List<ItemBundle> firstPassRewards;

			// Token: 0x0400498F RID: 18831
			[Token(Token = "0x400498F")]
			[FieldOffset(Offset = "0x28")]
			public List<ItemBundle> passRewards;
		}

		// Token: 0x02000DD9 RID: 3545
		[Token(Token = "0x2000DD9")]
		[Serializable]
		public class DisplayDetailRewards : StageData.DisplayRewards
		{
			// Token: 0x06006AA5 RID: 27301 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AA5")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public DisplayDetailRewards()
			{
			}

			// Token: 0x04004990 RID: 18832
			[Token(Token = "0x4004990")]
			[FieldOffset(Offset = "0x28")]
			public OccPer occPercent;

			// Token: 0x04004991 RID: 18833
			[Token(Token = "0x4004991")]
			[FieldOffset(Offset = "0x2C")]
			[JsonIgnore]
			public float GetPercent;

			// Token: 0x04004992 RID: 18834
			[Token(Token = "0x4004992")]
			[FieldOffset(Offset = "0x30")]
			[JsonIgnore]
			public float CannotGetPercent;

			// Token: 0x04004993 RID: 18835
			[Token(Token = "0x4004993")]
			[FieldOffset(Offset = "0x34")]
			public int dropCount;
		}

		// Token: 0x02000DDA RID: 3546
		[Token(Token = "0x2000DDA")]
		public class BossRushMissionAdditionData
		{
			// Token: 0x06006AA6 RID: 27302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AA6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BossRushMissionAdditionData()
			{
			}

			// Token: 0x04004994 RID: 18836
			[Token(Token = "0x4004994")]
			[FieldOffset(Offset = "0x10")]
			public string missionId;

			// Token: 0x04004995 RID: 18837
			[Token(Token = "0x4004995")]
			[FieldOffset(Offset = "0x18")]
			public bool isRelicTask;
		}

		// Token: 0x02000DDB RID: 3547
		[Token(Token = "0x2000DDB")]
		public class BossRushTeamData
		{
			// Token: 0x06006AA7 RID: 27303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AA7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BossRushTeamData()
			{
			}

			// Token: 0x04004996 RID: 18838
			[Token(Token = "0x4004996")]
			[FieldOffset(Offset = "0x10")]
			public string teamId;

			// Token: 0x04004997 RID: 18839
			[Token(Token = "0x4004997")]
			[FieldOffset(Offset = "0x18")]
			public string teamName;

			// Token: 0x04004998 RID: 18840
			[Token(Token = "0x4004998")]
			[FieldOffset(Offset = "0x20")]
			public List<string> charIdList;

			// Token: 0x04004999 RID: 18841
			[Token(Token = "0x4004999")]
			[FieldOffset(Offset = "0x28")]
			public string teamBuffName;

			// Token: 0x0400499A RID: 18842
			[Token(Token = "0x400499A")]
			[FieldOffset(Offset = "0x30")]
			public string teamBuffDes;

			// Token: 0x0400499B RID: 18843
			[Token(Token = "0x400499B")]
			[FieldOffset(Offset = "0x38")]
			public string teamBuffId;

			// Token: 0x0400499C RID: 18844
			[Token(Token = "0x400499C")]
			[FieldOffset(Offset = "0x40")]
			public int maxCharNum;

			// Token: 0x0400499D RID: 18845
			[Token(Token = "0x400499D")]
			[FieldOffset(Offset = "0x48")]
			public RuneTable.PackedRuneData runeData;
		}

		// Token: 0x02000DDC RID: 3548
		[Token(Token = "0x2000DDC")]
		public class RelicData
		{
			// Token: 0x06006AA8 RID: 27304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AA8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RelicData()
			{
			}

			// Token: 0x0400499E RID: 18846
			[Token(Token = "0x400499E")]
			[FieldOffset(Offset = "0x10")]
			public string relicId;

			// Token: 0x0400499F RID: 18847
			[Token(Token = "0x400499F")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040049A0 RID: 18848
			[Token(Token = "0x40049A0")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x040049A1 RID: 18849
			[Token(Token = "0x40049A1")]
			[FieldOffset(Offset = "0x28")]
			public string icon;

			// Token: 0x040049A2 RID: 18850
			[Token(Token = "0x40049A2")]
			[FieldOffset(Offset = "0x30")]
			public string relicTaskId;
		}

		// Token: 0x02000DDD RID: 3549
		[Token(Token = "0x2000DDD")]
		public class RelicLevelInfo
		{
			// Token: 0x06006AA9 RID: 27305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AA9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RelicLevelInfo()
			{
			}

			// Token: 0x040049A3 RID: 18851
			[Token(Token = "0x40049A3")]
			[FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x040049A4 RID: 18852
			[Token(Token = "0x40049A4")]
			[FieldOffset(Offset = "0x18")]
			public string effectDesc;

			// Token: 0x040049A5 RID: 18853
			[Token(Token = "0x40049A5")]
			[FieldOffset(Offset = "0x20")]
			public RuneTable.PackedRuneData runeData;

			// Token: 0x040049A6 RID: 18854
			[Token(Token = "0x40049A6")]
			[FieldOffset(Offset = "0x28")]
			public int needItemCount;
		}

		// Token: 0x02000DDE RID: 3550
		[Token(Token = "0x2000DDE")]
		public class RelicLevelInfoData
		{
			// Token: 0x06006AAA RID: 27306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AAA")]
			[Address(RVA = "0x200CA10", Offset = "0x200B610", VA = "0x18200CA10")]
			public RelicLevelInfoData()
			{
			}

			// Token: 0x040049A7 RID: 18855
			[Token(Token = "0x40049A7")]
			[FieldOffset(Offset = "0x10")]
			public string relicId;

			// Token: 0x040049A8 RID: 18856
			[Token(Token = "0x40049A8")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, ActivityBossRushData.RelicLevelInfo> levelInfos;
		}

		// Token: 0x02000DDF RID: 3551
		[Token(Token = "0x2000DDF")]
		public class BossRushMileStoneData
		{
			// Token: 0x06006AAB RID: 27307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AAB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BossRushMileStoneData()
			{
			}

			// Token: 0x040049A9 RID: 18857
			[Token(Token = "0x40049A9")]
			[FieldOffset(Offset = "0x10")]
			public string mileStoneId;

			// Token: 0x040049AA RID: 18858
			[Token(Token = "0x40049AA")]
			[FieldOffset(Offset = "0x18")]
			public int mileStoneLvl;

			// Token: 0x040049AB RID: 18859
			[Token(Token = "0x40049AB")]
			[FieldOffset(Offset = "0x1C")]
			public int needPointCnt;

			// Token: 0x040049AC RID: 18860
			[Token(Token = "0x40049AC")]
			[FieldOffset(Offset = "0x20")]
			public ItemBundle rewardItem;
		}

		// Token: 0x02000DE0 RID: 3552
		[Token(Token = "0x2000DE0")]
		public class ConstData
		{
			// Token: 0x06006AAC RID: 27308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006AAC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x040049AD RID: 18861
			[Token(Token = "0x40049AD")]
			[FieldOffset(Offset = "0x10")]
			public int maxProvidedCharNum;

			// Token: 0x040049AE RID: 18862
			[Token(Token = "0x40049AE")]
			[FieldOffset(Offset = "0x18")]
			public string textMilestoneItemLevelDesc;

			// Token: 0x040049AF RID: 18863
			[Token(Token = "0x40049AF")]
			[FieldOffset(Offset = "0x20")]
			public string milestonePointId;

			// Token: 0x040049B0 RID: 18864
			[Token(Token = "0x40049B0")]
			[FieldOffset(Offset = "0x28")]
			public string relicUpgradeItemId;

			// Token: 0x040049B1 RID: 18865
			[Token(Token = "0x40049B1")]
			[FieldOffset(Offset = "0x30")]
			public List<string> defaultRelictList;

			// Token: 0x040049B2 RID: 18866
			[Token(Token = "0x40049B2")]
			[FieldOffset(Offset = "0x38")]
			public string rewardSkinId;
		}
	}
}
