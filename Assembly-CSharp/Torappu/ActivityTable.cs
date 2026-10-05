using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Torappu
{
	// Token: 0x02000E83 RID: 3715
	[Token(Token = "0x2000E83")]
	public class ActivityTable
	{
		// Token: 0x06006B4F RID: 27471 RVA: 0x000312C0 File Offset: 0x0002F4C0
		[Token(Token = "0x6006B4F")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
		public virtual bool ShouldSerializeactThemes()
		{
			return default(bool);
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x000312D8 File Offset: 0x0002F4D8
		[Token(Token = "0x6006B50")]
		[Address(RVA = "0x1FFCDE0", Offset = "0x1FFB9E0", VA = "0x181FFCDE0")]
		public bool ShouldSerializeactFunData()
		{
			return default(bool);
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x000312F0 File Offset: 0x0002F4F0
		[Token(Token = "0x6006B51")]
		[Address(RVA = "0x1FFCE50", Offset = "0x1FFBA50", VA = "0x181FFCE50", Slot = "5")]
		public virtual bool ShouldSerializefireworkData()
		{
			return default(bool);
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00031308 File Offset: 0x0002F508
		[Token(Token = "0x6006B52")]
		[Address(RVA = "0x1FFCE60", Offset = "0x1FFBA60", VA = "0x181FFCE60", Slot = "6")]
		public virtual bool ShouldSerializehalfIdleData()
		{
			return default(bool);
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x00031320 File Offset: 0x0002F520
		[Token(Token = "0x6006B53")]
		[Address(RVA = "0x1FFCE40", Offset = "0x1FFBA40", VA = "0x181FFCE40", Slot = "7")]
		public virtual bool ShouldSerializeautoChessData()
		{
			return default(bool);
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B54")]
		[Address(RVA = "0x1FFCEC0", Offset = "0x1FFBAC0", VA = "0x181FFCEC0")]
		public ActivityTable()
		{
		}

		// Token: 0x04004E31 RID: 20017
		[Token(Token = "0x4004E31")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActivityTable.BasicData> basicInfo;

		// Token: 0x04004E32 RID: 20018
		[Token(Token = "0x4004E32")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ActivityTable.HomeActivityConfig> homeActConfig;

		// Token: 0x04004E33 RID: 20019
		[Token(Token = "0x4004E33")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> zoneToActivity;

		// Token: 0x04004E34 RID: 20020
		[Token(Token = "0x4004E34")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, long> actTimeTrackPoint;

		// Token: 0x04004E35 RID: 20021
		[Token(Token = "0x4004E35")]
		[FieldOffset(Offset = "0x30")]
		public List<MissionData> missionData;

		// Token: 0x04004E36 RID: 20022
		[Token(Token = "0x4004E36")]
		[FieldOffset(Offset = "0x38")]
		public List<MissionGroup> missionGroup;

		// Token: 0x04004E37 RID: 20023
		[Token(Token = "0x4004E37")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, string> replicateMissions;

		// Token: 0x04004E38 RID: 20024
		[Token(Token = "0x4004E38")]
		[FieldOffset(Offset = "0x48")]
		public ActivityTable.ActivityDetailTable activity;

		// Token: 0x04004E39 RID: 20025
		[Token(Token = "0x4004E39")]
		[FieldOffset(Offset = "0x50")]
		public ActivityTable.ActivityExtraData extraData;

		// Token: 0x04004E3A RID: 20026
		[Token(Token = "0x4004E3A")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, List<string>> activityItems;

		// Token: 0x04004E3B RID: 20027
		[Token(Token = "0x4004E3B")]
		[FieldOffset(Offset = "0x60")]
		public ListDict<string, List<long>> syncPoints;

		// Token: 0x04004E3C RID: 20028
		[Token(Token = "0x4004E3C")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, JObject> dynActs;

		// Token: 0x04004E3D RID: 20029
		[Token(Token = "0x4004E3D")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, ActivityStageRewardData> stageRewardsData;

		// Token: 0x04004E3E RID: 20030
		[Token(Token = "0x4004E3E")]
		[FieldOffset(Offset = "0x78")]
		public List<ActivityThemeData> actThemes;

		// Token: 0x04004E3F RID: 20031
		[Token(Token = "0x4004E3F")]
		[FieldOffset(Offset = "0x80")]
		public AprilFoolTable actFunData;

		// Token: 0x04004E40 RID: 20032
		[Token(Token = "0x4004E40")]
		[FieldOffset(Offset = "0x88")]
		public CartData carData;

		// Token: 0x04004E41 RID: 20033
		[Token(Token = "0x4004E41")]
		[FieldOffset(Offset = "0x90")]
		public SiracusaData siracusaData;

		// Token: 0x04004E42 RID: 20034
		[Token(Token = "0x4004E42")]
		[FieldOffset(Offset = "0x98")]
		public FireworkData fireworkData;

		// Token: 0x04004E43 RID: 20035
		[Token(Token = "0x4004E43")]
		[FieldOffset(Offset = "0xA0")]
		public HalfIdleData halfIdleData;

		// Token: 0x04004E44 RID: 20036
		[Token(Token = "0x4004E44")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<string, ActivityKVSwitchData> kvSwitchData;

		// Token: 0x04004E45 RID: 20037
		[Token(Token = "0x4004E45")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<string, ActivityDynEntrySwitchData> dynEntrySwitchData;

		// Token: 0x04004E46 RID: 20038
		[Token(Token = "0x4004E46")]
		[FieldOffset(Offset = "0xB8")]
		public List<ActivityTable.ActivityHiddenStageData> hiddenStageData;

		// Token: 0x04004E47 RID: 20039
		[Token(Token = "0x4004E47")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<string, MissionArchiveData> missionArchives;

		// Token: 0x04004E48 RID: 20040
		[Token(Token = "0x4004E48")]
		[FieldOffset(Offset = "0xC8")]
		public FifthAnnivExploreData fifthAnnivExploreData;

		// Token: 0x04004E49 RID: 20041
		[Token(Token = "0x4004E49")]
		[FieldOffset(Offset = "0xD0")]
		public AutoChessData autoChessData;

		// Token: 0x04004E4A RID: 20042
		[Token(Token = "0x4004E4A")]
		[FieldOffset(Offset = "0xD8")]
		public Dictionary<string, Dictionary<string, string>> stringRes;

		// Token: 0x04004E4B RID: 20043
		[Token(Token = "0x4004E4B")]
		[FieldOffset(Offset = "0xE0")]
		public Dictionary<string, ActivityTable.ActivityTrapsData> activityTraps;

		// Token: 0x04004E4C RID: 20044
		[Token(Token = "0x4004E4C")]
		[FieldOffset(Offset = "0xE8")]
		public Dictionary<string, ActivityTable.ActivityTrapMissionsData> activityTrapMissions;

		// Token: 0x04004E4D RID: 20045
		[Token(Token = "0x4004E4D")]
		[FieldOffset(Offset = "0xF0")]
		public Dictionary<string, RuneTable.PackedRuneData> trapRuneDataDict;

		// Token: 0x04004E4E RID: 20046
		[Token(Token = "0x4004E4E")]
		[FieldOffset(Offset = "0xF8")]
		public Dictionary<string, TemplateMissionStyleData> activityTemplateMissionStyles;

		// Token: 0x04004E4F RID: 20047
		[Token(Token = "0x4004E4F")]
		[FieldOffset(Offset = "0x100")]
		public Dictionary<string, CrossDayTrackTypeData> activityCrossDayTrackTypeDataDict;

		// Token: 0x04004E50 RID: 20048
		[Token(Token = "0x4004E50")]
		[FieldOffset(Offset = "0x108")]
		public Dictionary<string, List<string>> activityCrossDayTrackTypeMap;

		// Token: 0x04004E51 RID: 20049
		[Token(Token = "0x4004E51")]
		[FieldOffset(Offset = "0x110")]
		public Dictionary<string, StoryReadTipsData> activityStoryReadTipsDatas;

		// Token: 0x02000E84 RID: 3716
		[Token(Token = "0x2000E84")]
		public class PicGroup
		{
			// Token: 0x06006B55 RID: 27477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B55")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PicGroup()
			{
			}

			// Token: 0x04004E52 RID: 20050
			[Token(Token = "0x4004E52")]
			[FieldOffset(Offset = "0x10")]
			public int sortIndex;

			// Token: 0x04004E53 RID: 20051
			[Token(Token = "0x4004E53")]
			[FieldOffset(Offset = "0x18")]
			public string picId;

			// Token: 0x04004E54 RID: 20052
			[Token(Token = "0x4004E54")]
			[FieldOffset(Offset = "0x20")]
			public CommonAvailCheck availCheck;
		}

		// Token: 0x02000E85 RID: 3717
		[Token(Token = "0x2000E85")]
		public class BasicData
		{
			// Token: 0x06006B56 RID: 27478 RVA: 0x00031338 File Offset: 0x0002F538
			[Token(Token = "0x6006B56")]
			[Address(RVA = "0x1FF9BE0", Offset = "0x1FF87E0", VA = "0x181FF9BE0")]
			public bool ShouldSerializedisplayType()
			{
				return default(bool);
			}

			// Token: 0x06006B57 RID: 27479 RVA: 0x00031350 File Offset: 0x0002F550
			[Token(Token = "0x6006B57")]
			[Address(RVA = "0x2001930", Offset = "0x2000530", VA = "0x182001930")]
			public bool ShouldSerializeungroupedMedalIds()
			{
				return default(bool);
			}

			// Token: 0x06006B58 RID: 27480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B58")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BasicData()
			{
			}

			// Token: 0x04004E55 RID: 20053
			[Token(Token = "0x4004E55")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004E56 RID: 20054
			[Token(Token = "0x4004E56")]
			[FieldOffset(Offset = "0x18")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ActivityType type;

			// Token: 0x04004E57 RID: 20055
			[Token(Token = "0x4004E57")]
			[FieldOffset(Offset = "0x1C")]
			[JsonConverter(typeof(StringEnumConverter))]
			public ActivityDisplayType displayType;

			// Token: 0x04004E58 RID: 20056
			[Token(Token = "0x4004E58")]
			[FieldOffset(Offset = "0x20")]
			public string name;

			// Token: 0x04004E59 RID: 20057
			[Token(Token = "0x4004E59")]
			[FieldOffset(Offset = "0x28")]
			public long startTime;

			// Token: 0x04004E5A RID: 20058
			[Token(Token = "0x4004E5A")]
			[FieldOffset(Offset = "0x30")]
			public long endTime;

			// Token: 0x04004E5B RID: 20059
			[Token(Token = "0x4004E5B")]
			[FieldOffset(Offset = "0x38")]
			public long rewardEndTime;

			// Token: 0x04004E5C RID: 20060
			[Token(Token = "0x4004E5C")]
			[FieldOffset(Offset = "0x40")]
			public bool displayOnHome;

			// Token: 0x04004E5D RID: 20061
			[Token(Token = "0x4004E5D")]
			[FieldOffset(Offset = "0x41")]
			public bool hasStage;

			// Token: 0x04004E5E RID: 20062
			[Token(Token = "0x4004E5E")]
			[FieldOffset(Offset = "0x48")]
			public string templateShopId;

			// Token: 0x04004E5F RID: 20063
			[Token(Token = "0x4004E5F")]
			[FieldOffset(Offset = "0x50")]
			public string medalGroupId;

			// Token: 0x04004E60 RID: 20064
			[Token(Token = "0x4004E60")]
			[FieldOffset(Offset = "0x58")]
			public List<string> ungroupedMedalIds;

			// Token: 0x04004E61 RID: 20065
			[Token(Token = "0x4004E61")]
			[FieldOffset(Offset = "0x60")]
			public bool isReplicate;

			// Token: 0x04004E62 RID: 20066
			[Token(Token = "0x4004E62")]
			[FieldOffset(Offset = "0x61")]
			public bool needFixedSync;

			// Token: 0x04004E63 RID: 20067
			[Token(Token = "0x4004E63")]
			[FieldOffset(Offset = "0x68")]
			public string trapDomainId;

			// Token: 0x04004E64 RID: 20068
			[Token(Token = "0x4004E64")]
			[FieldOffset(Offset = "0x70")]
			public ActivityCompleteType recType;

			// Token: 0x04004E65 RID: 20069
			[Token(Token = "0x4004E65")]
			[FieldOffset(Offset = "0x74")]
			public bool isPageEntry;

			// Token: 0x04004E66 RID: 20070
			[Token(Token = "0x4004E66")]
			[FieldOffset(Offset = "0x75")]
			public bool isMagnify;

			// Token: 0x04004E67 RID: 20071
			[Token(Token = "0x4004E67")]
			[FieldOffset(Offset = "0x78")]
			public List<ActivityTable.PicGroup> picGroup;

			// Token: 0x04004E68 RID: 20072
			[Token(Token = "0x4004E68")]
			[FieldOffset(Offset = "0x80")]
			public bool usePicGroup;
		}

		// Token: 0x02000E86 RID: 3718
		[Token(Token = "0x2000E86")]
		public class HomeActivityConfig
		{
			// Token: 0x06006B59 RID: 27481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B59")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HomeActivityConfig()
			{
			}

			// Token: 0x04004E69 RID: 20073
			[Token(Token = "0x4004E69")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04004E6A RID: 20074
			[Token(Token = "0x4004E6A")]
			[FieldOffset(Offset = "0x18")]
			public bool isPopupAfterCheckin;

			// Token: 0x04004E6B RID: 20075
			[Token(Token = "0x4004E6B")]
			[FieldOffset(Offset = "0x19")]
			public bool showTopBarMenu;

			// Token: 0x04004E6C RID: 20076
			[Token(Token = "0x4004E6C")]
			[FieldOffset(Offset = "0x20")]
			public string actTopBarColor;

			// Token: 0x04004E6D RID: 20077
			[Token(Token = "0x4004E6D")]
			[FieldOffset(Offset = "0x28")]
			public string actTopBarText;
		}

		// Token: 0x02000E87 RID: 3719
		[Token(Token = "0x2000E87")]
		public class CustomUnlockCond
		{
			// Token: 0x06006B5A RID: 27482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B5A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CustomUnlockCond()
			{
			}

			// Token: 0x04004E6E RID: 20078
			[Token(Token = "0x4004E6E")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x04004E6F RID: 20079
			[Token(Token = "0x4004E6F")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;
		}

		// Token: 0x02000E88 RID: 3720
		[Token(Token = "0x2000E88")]
		[Serializable]
		public class ActivityDetailTable
		{
			// Token: 0x06006B5B RID: 27483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B5B")]
			[Address(RVA = "0x1FFAFD0", Offset = "0x1FF9BD0", VA = "0x181FFAFD0")]
			public ActivityDetailTable()
			{
			}

			// Token: 0x04004E70 RID: 20080
			[Token(Token = "0x4004E70")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("DEFAULT")]
			public Dictionary<string, DefaultFirstData> defaultActivityData;

			// Token: 0x04004E71 RID: 20081
			[Token(Token = "0x4004E71")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty("CHECKIN_ONLY")]
			public Dictionary<string, DefaultCheckInData> defaultCheckinData;

			// Token: 0x04004E72 RID: 20082
			[Token(Token = "0x4004E72")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty("CHECKIN_ALL_PLAYER")]
			public Dictionary<string, AllPlayerCheckinData> allPlayerCheckinData;

			// Token: 0x04004E73 RID: 20083
			[Token(Token = "0x4004E73")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty("CHECKIN_VS")]
			public Dictionary<string, VersusCheckInData> versusCheckInData;

			// Token: 0x04004E74 RID: 20084
			[Token(Token = "0x4004E74")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty("TYPE_ACT3D0")]
			public Dictionary<string, Act3D0Data> typeAct3d0Data;

			// Token: 0x04004E75 RID: 20085
			[Token(Token = "0x4004E75")]
			[FieldOffset(Offset = "0x38")]
			[JsonProperty("TYPE_ACT4D0")]
			public Dictionary<string, Act4D0Data> typeAct4d0Data;

			// Token: 0x04004E76 RID: 20086
			[Token(Token = "0x4004E76")]
			[FieldOffset(Offset = "0x40")]
			[JsonProperty("TYPE_ACT5D0")]
			public Dictionary<string, Act5D0Data> typeAct5d0Data;

			// Token: 0x04004E77 RID: 20087
			[Token(Token = "0x4004E77")]
			[FieldOffset(Offset = "0x48")]
			[JsonProperty("TYPE_ACT5D1")]
			public Dictionary<string, Act5D1Data> typeAct5d1Data;

			// Token: 0x04004E78 RID: 20088
			[Token(Token = "0x4004E78")]
			[FieldOffset(Offset = "0x50")]
			[JsonProperty("COLLECTION")]
			public Dictionary<string, ActivityCollectionData> defaultCollectionData;

			// Token: 0x04004E79 RID: 20089
			[Token(Token = "0x4004E79")]
			[FieldOffset(Offset = "0x58")]
			[JsonProperty("TYPE_ACT9D0")]
			public Dictionary<string, Act9D0Data> typeAct9d0Data;

			// Token: 0x04004E7A RID: 20090
			[Token(Token = "0x4004E7A")]
			[FieldOffset(Offset = "0x60")]
			[JsonProperty("TYPE_ACT12SIDE")]
			public Dictionary<string, Act12SideData> typeAct12SideData;

			// Token: 0x04004E7B RID: 20091
			[Token(Token = "0x4004E7B")]
			[FieldOffset(Offset = "0x68")]
			[JsonProperty("TYPE_ACT13SIDE")]
			public Dictionary<string, Act13SideData> typeAct13SideData;

			// Token: 0x04004E7C RID: 20092
			[Token(Token = "0x4004E7C")]
			[FieldOffset(Offset = "0x70")]
			[JsonProperty("TYPE_ACT17SIDE")]
			public Dictionary<string, Act17sideData> typeAct17sideData;

			// Token: 0x04004E7D RID: 20093
			[Token(Token = "0x4004E7D")]
			[FieldOffset(Offset = "0x78")]
			[JsonProperty("TYPE_ACT20SIDE")]
			public Dictionary<string, Act20SideData> typeAct20SideData;

			// Token: 0x04004E7E RID: 20094
			[Token(Token = "0x4004E7E")]
			[FieldOffset(Offset = "0x80")]
			[JsonProperty("TYPE_ACT21SIDE")]
			public Dictionary<string, Act21SideData> typeAct21SideData;

			// Token: 0x04004E7F RID: 20095
			[Token(Token = "0x4004E7F")]
			[FieldOffset(Offset = "0x88")]
			[JsonProperty("LOGIN_ONLY")]
			public Dictionary<string, ActivityLoginData> defaultLoginData;

			// Token: 0x04004E80 RID: 20096
			[Token(Token = "0x4004E80")]
			[FieldOffset(Offset = "0x90")]
			[JsonProperty("SWITCH_ONLY")]
			public Dictionary<string, ActivitySwitchCheckinData> switchCheckinData;

			// Token: 0x04004E81 RID: 20097
			[Token(Token = "0x4004E81")]
			[FieldOffset(Offset = "0x98")]
			[JsonProperty("MINISTORY")]
			public Dictionary<string, ActivityMiniStoryData> defaultMiniStoryData;

			// Token: 0x04004E82 RID: 20098
			[Token(Token = "0x4004E82")]
			[FieldOffset(Offset = "0xA0")]
			[JsonProperty("ROGUELIKE")]
			public Dictionary<string, ActivityRoguelikeData> defaultRoguelikeData;

			// Token: 0x04004E83 RID: 20099
			[Token(Token = "0x4004E83")]
			[FieldOffset(Offset = "0xA8")]
			[JsonProperty("INTERLOCK")]
			public Dictionary<string, ActivityInterlockData> defaultInterlockData;

			// Token: 0x04004E84 RID: 20100
			[Token(Token = "0x4004E84")]
			[FieldOffset(Offset = "0xB0")]
			[JsonProperty("BOSS_RUSH")]
			public Dictionary<string, ActivityBossRushData> defaultBossRushData;

			// Token: 0x04004E85 RID: 20101
			[Token(Token = "0x4004E85")]
			[FieldOffset(Offset = "0xB8")]
			[JsonProperty("FLOAT_PARADE")]
			public Dictionary<string, ActivityFloatParadeData> floatParadeData;

			// Token: 0x04004E86 RID: 20102
			[Token(Token = "0x4004E86")]
			[FieldOffset(Offset = "0xC0")]
			[JsonProperty("MAIN_BUFF")]
			public Dictionary<string, ActivityMainlineBuffData> mainlineBuffData;

			// Token: 0x04004E87 RID: 20103
			[Token(Token = "0x4004E87")]
			[FieldOffset(Offset = "0xC8")]
			[JsonProperty("TYPE_ACT24SIDE")]
			public Dictionary<string, Act24SideData> typeAct24SideData;

			// Token: 0x04004E88 RID: 20104
			[Token(Token = "0x4004E88")]
			[FieldOffset(Offset = "0xD0")]
			[JsonProperty("TYPE_ACT25SIDE")]
			public Dictionary<string, Act25SideData> typeAct25SideData;

			// Token: 0x04004E89 RID: 20105
			[Token(Token = "0x4004E89")]
			[FieldOffset(Offset = "0xD8")]
			[JsonProperty("TYPE_ACT27SIDE")]
			public Dictionary<string, Act27SideData> typeAct27SideData;

			// Token: 0x04004E8A RID: 20106
			[Token(Token = "0x4004E8A")]
			[FieldOffset(Offset = "0xE0")]
			[JsonProperty("TYPE_ACT42D0")]
			public Dictionary<string, Act42D0Data> typeAct42D0Data;

			// Token: 0x04004E8B RID: 20107
			[Token(Token = "0x4004E8B")]
			[FieldOffset(Offset = "0xE8")]
			[JsonProperty("TYPE_ACT29SIDE")]
			public Dictionary<string, Act29SideData> typeAct29SideData;

			// Token: 0x04004E8C RID: 20108
			[Token(Token = "0x4004E8C")]
			[FieldOffset(Offset = "0xF0")]
			[JsonProperty("YEAR_5_GENERAL")]
			public Dictionary<string, ActivityYear5GeneralData> year5GeneralData;

			// Token: 0x04004E8D RID: 20109
			[Token(Token = "0x4004E8D")]
			[FieldOffset(Offset = "0xF8")]
			[JsonProperty("TYPE_ACT35SIDE")]
			public Dictionary<string, Act35SideData> typeAct35SideData;

			// Token: 0x04004E8E RID: 20110
			[Token(Token = "0x4004E8E")]
			[FieldOffset(Offset = "0x100")]
			[JsonProperty("VEC_BREAK_V2")]
			public Dictionary<string, ActVecBreakV2Data> typeActVecBreakV2Data;

			// Token: 0x04004E8F RID: 20111
			[Token(Token = "0x4004E8F")]
			[FieldOffset(Offset = "0x108")]
			[JsonProperty("TYPE_ACT36SIDE")]
			public Dictionary<string, Act36SideData> typeAct36SideData;

			// Token: 0x04004E90 RID: 20112
			[Token(Token = "0x4004E90")]
			[FieldOffset(Offset = "0x110")]
			[JsonProperty("TYPE_ACT38SIDE")]
			public Dictionary<string, Act38SideData> typeAct38SideData;

			// Token: 0x04004E91 RID: 20113
			[Token(Token = "0x4004E91")]
			[FieldOffset(Offset = "0x118")]
			[JsonProperty("ARCADE")]
			public Dictionary<string, ActArcadeData> typeActArcadeData;

			// Token: 0x04004E92 RID: 20114
			[Token(Token = "0x4004E92")]
			[FieldOffset(Offset = "0x120")]
			[JsonProperty("MULTIPLAY_V3")]
			public Dictionary<string, ActMultiV3Data> typeActMultiV3Data;

			// Token: 0x04004E93 RID: 20115
			[Token(Token = "0x4004E93")]
			[FieldOffset(Offset = "0x128")]
			[JsonProperty("TYPE_MAINSS")]
			public Dictionary<string, ActMainSSData> typeActMainSSData;

			// Token: 0x04004E94 RID: 20116
			[Token(Token = "0x4004E94")]
			[FieldOffset(Offset = "0x130")]
			[JsonProperty("ENEMY_DUEL")]
			public Dictionary<string, ActivityEnemyDuelData> typeActEnemyDuelData;

			// Token: 0x04004E95 RID: 20117
			[Token(Token = "0x4004E95")]
			[FieldOffset(Offset = "0x138")]
			[JsonProperty("TYPE_ACT42SIDE")]
			public Dictionary<string, Act42SideData> typeAct42SideData;

			// Token: 0x04004E96 RID: 20118
			[Token(Token = "0x4004E96")]
			[FieldOffset(Offset = "0x140")]
			[JsonProperty("TYPE_ACT44SIDE")]
			public Dictionary<string, Act44SideData> typeAct44SideData;

			// Token: 0x04004E97 RID: 20119
			[Token(Token = "0x4004E97")]
			[FieldOffset(Offset = "0x148")]
			[JsonProperty("HALFIDLE_VERIFY1")]
			public Dictionary<string, Act1VHalfIdleData> typeAct1VHalfIdleData;

			// Token: 0x04004E98 RID: 20120
			[Token(Token = "0x4004E98")]
			[FieldOffset(Offset = "0x150")]
			[JsonProperty("TYPE_ACT45SIDE")]
			public Dictionary<string, Act45SideData> typeAct45SideData;

			// Token: 0x04004E99 RID: 20121
			[Token(Token = "0x4004E99")]
			[FieldOffset(Offset = "0x158")]
			[JsonProperty("RECRUIT_ONLY")]
			public Dictionary<string, ActRecruitOnlyData> recruitOnlyData;

			// Token: 0x04004E9A RID: 20122
			[Token(Token = "0x4004E9A")]
			[FieldOffset(Offset = "0x160")]
			[JsonProperty("TYPE_ACT46SIDE")]
			public Dictionary<string, Act46SideData> typeAct46SideData;

			// Token: 0x04004E9B RID: 20123
			[Token(Token = "0x4004E9B")]
			[FieldOffset(Offset = "0x168")]
			[JsonProperty("AUTOCHESS_SEASON")]
			public Dictionary<string, ActAutoChessData> defaultAutoChessData;
		}

		// Token: 0x02000E89 RID: 3721
		[Token(Token = "0x2000E89")]
		[Serializable]
		public class ActivityExtraData
		{
			// Token: 0x06006B5C RID: 27484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B5C")]
			[Address(RVA = "0x1FFC2F0", Offset = "0x1FFAEF0", VA = "0x181FFC2F0")]
			public ActivityExtraData()
			{
			}

			// Token: 0x04004E9C RID: 20124
			[Token(Token = "0x4004E9C")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("MAINLINE_BP")]
			public Dictionary<string, ActMainlineBpExtraData> typeMainlineBpData;
		}

		// Token: 0x02000E8A RID: 3722
		[Token(Token = "0x2000E8A")]
		[Serializable]
		public class ActivityHiddenAreaData
		{
			// Token: 0x06006B5D RID: 27485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B5D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityHiddenAreaData()
			{
			}

			// Token: 0x04004E9D RID: 20125
			[Token(Token = "0x4004E9D")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04004E9E RID: 20126
			[Token(Token = "0x4004E9E")]
			[FieldOffset(Offset = "0x18")]
			public string desc;

			// Token: 0x04004E9F RID: 20127
			[Token(Token = "0x4004E9F")]
			[FieldOffset(Offset = "0x20")]
			public List<ActivityTable.ActHiddenAreaPreposeStageData> preposedStage;

			// Token: 0x04004EA0 RID: 20128
			[Token(Token = "0x4004EA0")]
			[FieldOffset(Offset = "0x28")]
			public long preposedTime;
		}

		// Token: 0x02000E8B RID: 3723
		[Token(Token = "0x2000E8B")]
		[Serializable]
		public class ActHiddenAreaPreposeStageData
		{
			// Token: 0x06006B5E RID: 27486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B5E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActHiddenAreaPreposeStageData()
			{
			}

			// Token: 0x04004EA1 RID: 20129
			[Token(Token = "0x4004EA1")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004EA2 RID: 20130
			[Token(Token = "0x4004EA2")]
			[FieldOffset(Offset = "0x18")]
			public PlayerBattleRank unlockRank;
		}

		// Token: 0x02000E8C RID: 3724
		[Token(Token = "0x2000E8C")]
		[Serializable]
		public class ActivityHiddenStageUnlockConditionData
		{
			// Token: 0x06006B5F RID: 27487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B5F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityHiddenStageUnlockConditionData()
			{
			}

			// Token: 0x04004EA3 RID: 20131
			[Token(Token = "0x4004EA3")]
			[FieldOffset(Offset = "0x10")]
			public string unlockStageId;

			// Token: 0x04004EA4 RID: 20132
			[Token(Token = "0x4004EA4")]
			[FieldOffset(Offset = "0x18")]
			public string unlockTemplate;

			// Token: 0x04004EA5 RID: 20133
			[Token(Token = "0x4004EA5")]
			[FieldOffset(Offset = "0x20")]
			public string[] unlockParams;

			// Token: 0x04004EA6 RID: 20134
			[Token(Token = "0x4004EA6")]
			[FieldOffset(Offset = "0x28")]
			public string missionStageId;

			// Token: 0x04004EA7 RID: 20135
			[Token(Token = "0x4004EA7")]
			[FieldOffset(Offset = "0x30")]
			public string unlockedName;

			// Token: 0x04004EA8 RID: 20136
			[Token(Token = "0x4004EA8")]
			[FieldOffset(Offset = "0x38")]
			public string lockedName;

			// Token: 0x04004EA9 RID: 20137
			[Token(Token = "0x4004EA9")]
			[FieldOffset(Offset = "0x40")]
			public string lockCode;

			// Token: 0x04004EAA RID: 20138
			[Token(Token = "0x4004EAA")]
			[FieldOffset(Offset = "0x48")]
			public string unlockedDes;

			// Token: 0x04004EAB RID: 20139
			[Token(Token = "0x4004EAB")]
			[FieldOffset(Offset = "0x50")]
			public string templateDesc;

			// Token: 0x04004EAC RID: 20140
			[Token(Token = "0x4004EAC")]
			[FieldOffset(Offset = "0x58")]
			public string desc;

			// Token: 0x04004EAD RID: 20141
			[Token(Token = "0x4004EAD")]
			[FieldOffset(Offset = "0x60")]
			public string riddle;
		}

		// Token: 0x02000E8D RID: 3725
		[Token(Token = "0x2000E8D")]
		[Serializable]
		public class ActivityHiddenStageData
		{
			// Token: 0x06006B60 RID: 27488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B60")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityHiddenStageData()
			{
			}

			// Token: 0x04004EAE RID: 20142
			[Token(Token = "0x4004EAE")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04004EAF RID: 20143
			[Token(Token = "0x4004EAF")]
			[FieldOffset(Offset = "0x18")]
			public string encodedName;

			// Token: 0x04004EB0 RID: 20144
			[Token(Token = "0x4004EB0")]
			[FieldOffset(Offset = "0x20")]
			public string showStageId;

			// Token: 0x04004EB1 RID: 20145
			[Token(Token = "0x4004EB1")]
			[FieldOffset(Offset = "0x28")]
			public bool rewardDiamond;

			// Token: 0x04004EB2 RID: 20146
			[Token(Token = "0x4004EB2")]
			[FieldOffset(Offset = "0x30")]
			public ActivityTable.ActivityHiddenStageUnlockConditionData[] missions;
		}

		// Token: 0x02000E8E RID: 3726
		[Token(Token = "0x2000E8E")]
		[Serializable]
		public class ActivityTrapsData
		{
			// Token: 0x06006B61 RID: 27489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B61")]
			[Address(RVA = "0x1FFDAC0", Offset = "0x1FFC6C0", VA = "0x181FFDAC0")]
			public ActivityTrapsData()
			{
			}

			// Token: 0x04004EB3 RID: 20147
			[Token(Token = "0x4004EB3")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, ActivityTable.TemplateTrapData> templateTraps;

			// Token: 0x04004EB4 RID: 20148
			[Token(Token = "0x4004EB4")]
			[FieldOffset(Offset = "0x18")]
			public ActivityTable.ActivityTrapConstData trapConstData;
		}

		// Token: 0x02000E8F RID: 3727
		[Token(Token = "0x2000E8F")]
		[Serializable]
		public class ActivityTrapMissionsData
		{
			// Token: 0x06006B62 RID: 27490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B62")]
			[Address(RVA = "0x1FFDA30", Offset = "0x1FFC630", VA = "0x181FFDA30")]
			public ActivityTrapMissionsData()
			{
			}

			// Token: 0x04004EB5 RID: 20149
			[Token(Token = "0x4004EB5")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, ActivityTable.TrapMissionData> trapMissions;
		}

		// Token: 0x02000E90 RID: 3728
		[Token(Token = "0x2000E90")]
		[Serializable]
		public class TemplateTrapData
		{
			// Token: 0x06006B63 RID: 27491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B63")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TemplateTrapData()
			{
			}

			// Token: 0x04004EB6 RID: 20150
			[Token(Token = "0x4004EB6")]
			[FieldOffset(Offset = "0x10")]
			public string trapId;

			// Token: 0x04004EB7 RID: 20151
			[Token(Token = "0x4004EB7")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004EB8 RID: 20152
			[Token(Token = "0x4004EB8")]
			[FieldOffset(Offset = "0x20")]
			public string trapName;

			// Token: 0x04004EB9 RID: 20153
			[Token(Token = "0x4004EB9")]
			[FieldOffset(Offset = "0x28")]
			public string trapDesc;

			// Token: 0x04004EBA RID: 20154
			[Token(Token = "0x4004EBA")]
			[FieldOffset(Offset = "0x30")]
			public string trapText;

			// Token: 0x04004EBB RID: 20155
			[Token(Token = "0x4004EBB")]
			[FieldOffset(Offset = "0x38")]
			public string trapTaskId;

			// Token: 0x04004EBC RID: 20156
			[Token(Token = "0x4004EBC")]
			[FieldOffset(Offset = "0x40")]
			public string trapUnlockDesc;

			// Token: 0x04004EBD RID: 20157
			[Token(Token = "0x4004EBD")]
			[FieldOffset(Offset = "0x48")]
			public string trapBuffId;

			// Token: 0x04004EBE RID: 20158
			[Token(Token = "0x4004EBE")]
			[FieldOffset(Offset = "0x50")]
			public int availableCount;
		}

		// Token: 0x02000E91 RID: 3729
		[Token(Token = "0x2000E91")]
		[Serializable]
		public class TrapMissionData
		{
			// Token: 0x06006B64 RID: 27492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B64")]
			[Address(RVA = "0x200E380", Offset = "0x200CF80", VA = "0x18200E380")]
			public TrapMissionData()
			{
			}

			// Token: 0x04004EBF RID: 20159
			[Token(Token = "0x4004EBF")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004EC0 RID: 20160
			[Token(Token = "0x4004EC0")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x04004EC1 RID: 20161
			[Token(Token = "0x4004EC1")]
			[FieldOffset(Offset = "0x20")]
			[JsonConverter(typeof(StringEnumConverter))]
			public MissionType type;

			// Token: 0x04004EC2 RID: 20162
			[Token(Token = "0x4004EC2")]
			[FieldOffset(Offset = "0x28")]
			public List<MissionDisplayRewards> rewards;
		}

		// Token: 0x02000E92 RID: 3730
		[Token(Token = "0x2000E92")]
		public class ActivityTrapConstData
		{
			// Token: 0x06006B65 RID: 27493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006B65")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActivityTrapConstData()
			{
			}

			// Token: 0x04004EC3 RID: 20163
			[Token(Token = "0x4004EC3")]
			[FieldOffset(Offset = "0x10")]
			public string stageUnlockTrapDesc;

			// Token: 0x04004EC4 RID: 20164
			[Token(Token = "0x4004EC4")]
			[FieldOffset(Offset = "0x18")]
			public int trapMaximum;

			// Token: 0x04004EC5 RID: 20165
			[Token(Token = "0x4004EC5")]
			[FieldOffset(Offset = "0x20")]
			public List<string> stageCanNotUseTrap;

			// Token: 0x04004EC6 RID: 20166
			[Token(Token = "0x4004EC6")]
			[FieldOffset(Offset = "0x28")]
			public bool mustSelectTrap;

			// Token: 0x04004EC7 RID: 20167
			[Token(Token = "0x4004EC7")]
			[FieldOffset(Offset = "0x30")]
			public string systemUnlockToast;

			// Token: 0x04004EC8 RID: 20168
			[Token(Token = "0x4004EC8")]
			[FieldOffset(Offset = "0x38")]
			public string squadSaveSuccessToast;

			// Token: 0x04004EC9 RID: 20169
			[Token(Token = "0x4004EC9")]
			[FieldOffset(Offset = "0x40")]
			public string lockedToast;

			// Token: 0x04004ECA RID: 20170
			[Token(Token = "0x4004ECA")]
			[FieldOffset(Offset = "0x48")]
			public bool showBtnBack;
		}
	}
}
