using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000EDE RID: 3806
	[Token(Token = "0x2000EDE")]
	[Serializable]
	public class BuildingData
	{
		// Token: 0x06006BF9 RID: 27641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF9")]
		[Address(RVA = "0x2006B20", Offset = "0x2005720", VA = "0x182006B20")]
		public BuildingData()
		{
		}

		// Token: 0x040050C7 RID: 20679
		[Token(Token = "0x40050C7")]
		public const string CONTROL_STOREY_ID = "1F";

		// Token: 0x040050C8 RID: 20680
		[Token(Token = "0x40050C8")]
		[FieldOffset(Offset = "0x10")]
		public string controlSlotId;

		// Token: 0x040050C9 RID: 20681
		[Token(Token = "0x40050C9")]
		[FieldOffset(Offset = "0x18")]
		public string meetingSlotId;

		// Token: 0x040050CA RID: 20682
		[Token(Token = "0x40050CA")]
		[FieldOffset(Offset = "0x20")]
		public int initMaxLabor;

		// Token: 0x040050CB RID: 20683
		[Token(Token = "0x40050CB")]
		[FieldOffset(Offset = "0x24")]
		public int laborRecoverTime;

		// Token: 0x040050CC RID: 20684
		[Token(Token = "0x40050CC")]
		[FieldOffset(Offset = "0x28")]
		public int manufactInputCapacity;

		// Token: 0x040050CD RID: 20685
		[Token(Token = "0x40050CD")]
		[FieldOffset(Offset = "0x2C")]
		public int shopCounterCapacity;

		// Token: 0x040050CE RID: 20686
		[Token(Token = "0x40050CE")]
		[FieldOffset(Offset = "0x30")]
		public int comfortLimit;

		// Token: 0x040050CF RID: 20687
		[Token(Token = "0x40050CF")]
		[FieldOffset(Offset = "0x34")]
		public int creditInitiativeLimit;

		// Token: 0x040050D0 RID: 20688
		[Token(Token = "0x40050D0")]
		[FieldOffset(Offset = "0x38")]
		public int creditPassiveLimit;

		// Token: 0x040050D1 RID: 20689
		[Token(Token = "0x40050D1")]
		[FieldOffset(Offset = "0x3C")]
		public int creditComfortFactor;

		// Token: 0x040050D2 RID: 20690
		[Token(Token = "0x40050D2")]
		[FieldOffset(Offset = "0x40")]
		public int creditGuaranteed;

		// Token: 0x040050D3 RID: 20691
		[Token(Token = "0x40050D3")]
		[FieldOffset(Offset = "0x44")]
		public int creditCeiling;

		// Token: 0x040050D4 RID: 20692
		[Token(Token = "0x40050D4")]
		[FieldOffset(Offset = "0x48")]
		public string manufactUnlockTips;

		// Token: 0x040050D5 RID: 20693
		[Token(Token = "0x40050D5")]
		[FieldOffset(Offset = "0x50")]
		public string shopUnlockTips;

		// Token: 0x040050D6 RID: 20694
		[Token(Token = "0x40050D6")]
		[FieldOffset(Offset = "0x58")]
		public float manufactStationBuff;

		// Token: 0x040050D7 RID: 20695
		[Token(Token = "0x40050D7")]
		[FieldOffset(Offset = "0x5C")]
		public int comfortManpowerRecoverFactor;

		// Token: 0x040050D8 RID: 20696
		[Token(Token = "0x40050D8")]
		[FieldOffset(Offset = "0x60")]
		public int manpowerDisplayFactor;

		// Token: 0x040050D9 RID: 20697
		[Token(Token = "0x40050D9")]
		[FieldOffset(Offset = "0x68")]
		public ListDict<string, int> shopOutputRatio;

		// Token: 0x040050DA RID: 20698
		[Token(Token = "0x40050DA")]
		[FieldOffset(Offset = "0x70")]
		public ListDict<string, int> shopStackRatio;

		// Token: 0x040050DB RID: 20699
		[Token(Token = "0x40050DB")]
		[FieldOffset(Offset = "0x78")]
		public int basicFavorPerDay;

		// Token: 0x040050DC RID: 20700
		[Token(Token = "0x40050DC")]
		[FieldOffset(Offset = "0x7C")]
		public int humanResourceLimit;

		// Token: 0x040050DD RID: 20701
		[Token(Token = "0x40050DD")]
		[FieldOffset(Offset = "0x80")]
		public long tiredApThreshold;

		// Token: 0x040050DE RID: 20702
		[Token(Token = "0x40050DE")]
		[FieldOffset(Offset = "0x88")]
		public int processedCountRatio;

		// Token: 0x040050DF RID: 20703
		[Token(Token = "0x40050DF")]
		[FieldOffset(Offset = "0x8C")]
		public int tradingStrategyUnlockLevel;

		// Token: 0x040050E0 RID: 20704
		[Token(Token = "0x40050E0")]
		[FieldOffset(Offset = "0x90")]
		public int tradingReduceTimeUnit;

		// Token: 0x040050E1 RID: 20705
		[Token(Token = "0x40050E1")]
		[FieldOffset(Offset = "0x94")]
		public int tradingLaborCostUnit;

		// Token: 0x040050E2 RID: 20706
		[Token(Token = "0x40050E2")]
		[FieldOffset(Offset = "0x98")]
		public int manufactReduceTimeUnit;

		// Token: 0x040050E3 RID: 20707
		[Token(Token = "0x40050E3")]
		[FieldOffset(Offset = "0x9C")]
		public int manufactLaborCostUnit;

		// Token: 0x040050E4 RID: 20708
		[Token(Token = "0x40050E4")]
		[FieldOffset(Offset = "0xA0")]
		public int laborAssistUnlockLevel;

		// Token: 0x040050E5 RID: 20709
		[Token(Token = "0x40050E5")]
		[FieldOffset(Offset = "0xA4")]
		public int apToLaborUnlockLevel;

		// Token: 0x040050E6 RID: 20710
		[Token(Token = "0x40050E6")]
		[FieldOffset(Offset = "0xA8")]
		public int apToLaborRatio;

		// Token: 0x040050E7 RID: 20711
		[Token(Token = "0x40050E7")]
		[FieldOffset(Offset = "0xAC")]
		public int socialResourceLimit;

		// Token: 0x040050E8 RID: 20712
		[Token(Token = "0x40050E8")]
		[FieldOffset(Offset = "0xB0")]
		public int socialSlotNum;

		// Token: 0x040050E9 RID: 20713
		[Token(Token = "0x40050E9")]
		[FieldOffset(Offset = "0xB4")]
		public int furniDuplicationLimit;

		// Token: 0x040050EA RID: 20714
		[Token(Token = "0x40050EA")]
		[FieldOffset(Offset = "0xB8")]
		public long assistFavorReport;

		// Token: 0x040050EB RID: 20715
		[Token(Token = "0x40050EB")]
		[FieldOffset(Offset = "0xC0")]
		public int[] manufactManpowerCostByNum;

		// Token: 0x040050EC RID: 20716
		[Token(Token = "0x40050EC")]
		[FieldOffset(Offset = "0xC8")]
		public int[] tradingManpowerCostByNum;

		// Token: 0x040050ED RID: 20717
		[Token(Token = "0x40050ED")]
		[FieldOffset(Offset = "0xD0")]
		public int trainingBonusMax;

		// Token: 0x040050EE RID: 20718
		[Token(Token = "0x40050EE")]
		[FieldOffset(Offset = "0xD8")]
		public long betaRemoveTime;

		// Token: 0x040050EF RID: 20719
		[Token(Token = "0x40050EF")]
		[FieldOffset(Offset = "0xE0")]
		public float furniHighlightTime;

		// Token: 0x040050F0 RID: 20720
		[Token(Token = "0x40050F0")]
		[FieldOffset(Offset = "0xE8")]
		public string canNotVisitToast;

		// Token: 0x040050F1 RID: 20721
		[Token(Token = "0x40050F1")]
		[FieldOffset(Offset = "0xF0")]
		public long musicPlayerOpenTime;

		// Token: 0x040050F2 RID: 20722
		[Token(Token = "0x40050F2")]
		[FieldOffset(Offset = "0xF8")]
		public List<string> roomsWithoutRemoveStaff;

		// Token: 0x040050F3 RID: 20723
		[Token(Token = "0x40050F3")]
		[FieldOffset(Offset = "0x100")]
		public List<int> privateFavorLevelThresholds;

		// Token: 0x040050F4 RID: 20724
		[Token(Token = "0x40050F4")]
		[FieldOffset(Offset = "0x108")]
		public Dictionary<string, BuildingData.RoomUnlockCond> roomUnlockConds;

		// Token: 0x040050F5 RID: 20725
		[Token(Token = "0x40050F5")]
		[FieldOffset(Offset = "0x110")]
		public Dictionary<string, BuildingData.RoomData> rooms;

		// Token: 0x040050F6 RID: 20726
		[Token(Token = "0x40050F6")]
		[FieldOffset(Offset = "0x118")]
		public Dictionary<string, BuildingData.LayoutData> layouts;

		// Token: 0x040050F7 RID: 20727
		[Token(Token = "0x40050F7")]
		[FieldOffset(Offset = "0x120")]
		public Dictionary<string, BuildingData.PrefabInfo> prefabs;

		// Token: 0x040050F8 RID: 20728
		[Token(Token = "0x40050F8")]
		[FieldOffset(Offset = "0x128")]
		public BuildingData.ControlRoomBean controlData;

		// Token: 0x040050F9 RID: 20729
		[Token(Token = "0x40050F9")]
		[FieldOffset(Offset = "0x130")]
		public BuildingData.ManufactRoomBean manufactData;

		// Token: 0x040050FA RID: 20730
		[Token(Token = "0x40050FA")]
		[FieldOffset(Offset = "0x138")]
		public BuildingData.RoomBean<BuildingData.ShopPhase> shopData;

		// Token: 0x040050FB RID: 20731
		[Token(Token = "0x40050FB")]
		[FieldOffset(Offset = "0x140")]
		public BuildingData.HireRoomBean hireData;

		// Token: 0x040050FC RID: 20732
		[Token(Token = "0x40050FC")]
		[FieldOffset(Offset = "0x148")]
		public BuildingData.RoomBean<BuildingData.DormPhase> dormData;

		// Token: 0x040050FD RID: 20733
		[Token(Token = "0x40050FD")]
		[FieldOffset(Offset = "0x150")]
		public BuildingData.RoomBean<BuildingData.PrivatePhase> privateRoomData;

		// Token: 0x040050FE RID: 20734
		[Token(Token = "0x40050FE")]
		[FieldOffset(Offset = "0x158")]
		public BuildingData.MeetingRoomBean meetingData;

		// Token: 0x040050FF RID: 20735
		[Token(Token = "0x40050FF")]
		[FieldOffset(Offset = "0x160")]
		public BuildingData.TradingRoomBean tradingData;

		// Token: 0x04005100 RID: 20736
		[Token(Token = "0x4005100")]
		[FieldOffset(Offset = "0x168")]
		public BuildingData.RoomBean<BuildingData.WorkshopPhase> workshopData;

		// Token: 0x04005101 RID: 20737
		[Token(Token = "0x4005101")]
		[FieldOffset(Offset = "0x170")]
		public BuildingData.TrainingBean trainingData;

		// Token: 0x04005102 RID: 20738
		[Token(Token = "0x4005102")]
		[FieldOffset(Offset = "0x178")]
		public BuildingData.PowerRoomBean powerData;

		// Token: 0x04005103 RID: 20739
		[Token(Token = "0x4005103")]
		[FieldOffset(Offset = "0x180")]
		public Dictionary<string, BuildingData.BuildingCharacter> chars;

		// Token: 0x04005104 RID: 20740
		[Token(Token = "0x4005104")]
		[FieldOffset(Offset = "0x188")]
		public Dictionary<string, BuildingData.BuildingBuff> buffs;

		// Token: 0x04005105 RID: 20741
		[Token(Token = "0x4005105")]
		[FieldOffset(Offset = "0x190")]
		public Dictionary<string, List<string>> workshopBonus;

		// Token: 0x04005106 RID: 20742
		[Token(Token = "0x4005106")]
		[FieldOffset(Offset = "0x198")]
		public BuildingData.CustomData customData;

		// Token: 0x04005107 RID: 20743
		[Token(Token = "0x4005107")]
		[FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, BuildingData.ManufactFormula> manufactFormulas;

		// Token: 0x04005108 RID: 20744
		[Token(Token = "0x4005108")]
		[FieldOffset(Offset = "0x1A8")]
		public Dictionary<string, BuildingData.ShopFormula> shopFormulas;

		// Token: 0x04005109 RID: 20745
		[Token(Token = "0x4005109")]
		[FieldOffset(Offset = "0x1B0")]
		public Dictionary<string, BuildingData.WorkshopFormula> workshopFormulas;

		// Token: 0x0400510A RID: 20746
		[Token(Token = "0x400510A")]
		[FieldOffset(Offset = "0x1B8")]
		public BuildingData.CreditFormula creditFormula;

		// Token: 0x0400510B RID: 20747
		[Token(Token = "0x400510B")]
		[FieldOffset(Offset = "0x1C0")]
		public Dictionary<string, int> goldItems;

		// Token: 0x0400510C RID: 20748
		[Token(Token = "0x400510C")]
		[FieldOffset(Offset = "0x1C8")]
		public List<int> assistantUnlock;

		// Token: 0x0400510D RID: 20749
		[Token(Token = "0x400510D")]
		[FieldOffset(Offset = "0x1D0")]
		public List<BuildingData.WorkshopRarityInfo> workshopRarities;

		// Token: 0x0400510E RID: 20750
		[Token(Token = "0x400510E")]
		[FieldOffset(Offset = "0x1D8")]
		public Dictionary<string, int> todoItemSortPriorityDict;

		// Token: 0x0400510F RID: 20751
		[Token(Token = "0x400510F")]
		[FieldOffset(Offset = "0x1E0")]
		public ListDict<string, BuildingData.SlotPrequeData> slotPrequeDatas;

		// Token: 0x04005110 RID: 20752
		[Token(Token = "0x4005110")]
		[FieldOffset(Offset = "0x1E8")]
		public ListDict<string, BuildingData.DormitoryPrequeData> dormitoryPrequeDatas;

		// Token: 0x04005111 RID: 20753
		[Token(Token = "0x4005111")]
		[FieldOffset(Offset = "0x1F0")]
		public Dictionary<string, string> workshopTargetDesDict;

		// Token: 0x04005112 RID: 20754
		[Token(Token = "0x4005112")]
		[FieldOffset(Offset = "0x1F8")]
		public Dictionary<string, string> tradingOrderDesDict;

		// Token: 0x04005113 RID: 20755
		[Token(Token = "0x4005113")]
		[FieldOffset(Offset = "0x200")]
		public BuildingData.StationManageConstData stationManageConstData;

		// Token: 0x04005114 RID: 20756
		[Token(Token = "0x4005114")]
		[FieldOffset(Offset = "0x208")]
		public Dictionary<int, BuildingData.StationManageFilterInfo> stationManageFilterInfos;

		// Token: 0x04005115 RID: 20757
		[Token(Token = "0x4005115")]
		[FieldOffset(Offset = "0x210")]
		public BuildingData.MusicData musicData;

		// Token: 0x04005116 RID: 20758
		[Token(Token = "0x4005116")]
		[FieldOffset(Offset = "0x218")]
		public List<string> emojis;

		// Token: 0x04005117 RID: 20759
		[Token(Token = "0x4005117")]
		[FieldOffset(Offset = "0x220")]
		public Dictionary<string, string> categoryNames;

		// Token: 0x04005118 RID: 20760
		[Token(Token = "0x4005118")]
		[FieldOffset(Offset = "0x228")]
		public Dictionary<string, BuildingData.BuildingRoomTypeBuffSortData> buffSortData;

		// Token: 0x02000EDF RID: 3807
		[Token(Token = "0x2000EDF")]
		public enum RoomCategory
		{
			// Token: 0x0400511A RID: 20762
			[Token(Token = "0x400511A")]
			NONE,
			// Token: 0x0400511B RID: 20763
			[Token(Token = "0x400511B")]
			FUNCTION,
			// Token: 0x0400511C RID: 20764
			[Token(Token = "0x400511C")]
			OUTPUT,
			// Token: 0x0400511D RID: 20765
			[Token(Token = "0x400511D")]
			CUSTOM = 4,
			// Token: 0x0400511E RID: 20766
			[Token(Token = "0x400511E")]
			ELEVATOR = 8,
			// Token: 0x0400511F RID: 20767
			[Token(Token = "0x400511F")]
			CORRIDOR = 16,
			// Token: 0x04005120 RID: 20768
			[Token(Token = "0x4005120")]
			SPECIAL = 32,
			// Token: 0x04005121 RID: 20769
			[Token(Token = "0x4005121")]
			CUSTOM_P = 64,
			// Token: 0x04005122 RID: 20770
			[Token(Token = "0x4005122")]
			ELEVATOR_P = 128,
			// Token: 0x04005123 RID: 20771
			[Token(Token = "0x4005123")]
			CORRIDOR_P = 256,
			// Token: 0x04005124 RID: 20772
			[Token(Token = "0x4005124")]
			ALL = 511
		}

		// Token: 0x02000EE0 RID: 3808
		[Token(Token = "0x2000EE0")]
		public static class RoomTypeString
		{
			// Token: 0x04005125 RID: 20773
			[Token(Token = "0x4005125")]
			public const string CONTROL = "CONTROL";

			// Token: 0x04005126 RID: 20774
			[Token(Token = "0x4005126")]
			public const string POWER = "POWER";

			// Token: 0x04005127 RID: 20775
			[Token(Token = "0x4005127")]
			public const string MANUFACTURE = "MANUFACTURE";

			// Token: 0x04005128 RID: 20776
			[Token(Token = "0x4005128")]
			public const string SHOP = "SHOP";

			// Token: 0x04005129 RID: 20777
			[Token(Token = "0x4005129")]
			public const string DORMITORY = "DORMITORY";

			// Token: 0x0400512A RID: 20778
			[Token(Token = "0x400512A")]
			public const string MEETING = "MEETING";

			// Token: 0x0400512B RID: 20779
			[Token(Token = "0x400512B")]
			public const string HIRE = "HIRE";

			// Token: 0x0400512C RID: 20780
			[Token(Token = "0x400512C")]
			public const string ELEVATOR = "ELEVATOR";

			// Token: 0x0400512D RID: 20781
			[Token(Token = "0x400512D")]
			public const string CORRIDOR = "CORRIDOR";

			// Token: 0x0400512E RID: 20782
			[Token(Token = "0x400512E")]
			public const string TRADING = "TRADING";

			// Token: 0x0400512F RID: 20783
			[Token(Token = "0x400512F")]
			public const string WORKSHOP = "WORKSHOP";

			// Token: 0x04005130 RID: 20784
			[Token(Token = "0x4005130")]
			public const string TRAINING = "TRAINING";

			// Token: 0x04005131 RID: 20785
			[Token(Token = "0x4005131")]
			public const string PRIVATE = "PRIVATE";
		}

		// Token: 0x02000EE1 RID: 3809
		[Token(Token = "0x2000EE1")]
		public enum RoomType
		{
			// Token: 0x04005133 RID: 20787
			[Token(Token = "0x4005133")]
			NONE,
			// Token: 0x04005134 RID: 20788
			[Token(Token = "0x4005134")]
			CONTROL,
			// Token: 0x04005135 RID: 20789
			[Token(Token = "0x4005135")]
			POWER,
			// Token: 0x04005136 RID: 20790
			[Token(Token = "0x4005136")]
			MANUFACTURE = 4,
			// Token: 0x04005137 RID: 20791
			[Token(Token = "0x4005137")]
			SHOP = 8,
			// Token: 0x04005138 RID: 20792
			[Token(Token = "0x4005138")]
			DORMITORY = 16,
			// Token: 0x04005139 RID: 20793
			[Token(Token = "0x4005139")]
			MEETING = 32,
			// Token: 0x0400513A RID: 20794
			[Token(Token = "0x400513A")]
			HIRE = 64,
			// Token: 0x0400513B RID: 20795
			[Token(Token = "0x400513B")]
			ELEVATOR = 128,
			// Token: 0x0400513C RID: 20796
			[Token(Token = "0x400513C")]
			CORRIDOR = 256,
			// Token: 0x0400513D RID: 20797
			[Token(Token = "0x400513D")]
			TRADING = 512,
			// Token: 0x0400513E RID: 20798
			[Token(Token = "0x400513E")]
			WORKSHOP = 1024,
			// Token: 0x0400513F RID: 20799
			[Token(Token = "0x400513F")]
			TRAINING = 2048,
			// Token: 0x04005140 RID: 20800
			[Token(Token = "0x4005140")]
			PRIVATE = 4096,
			// Token: 0x04005141 RID: 20801
			[Token(Token = "0x4005141")]
			FUNCTIONAL = 3710,
			// Token: 0x04005142 RID: 20802
			[Token(Token = "0x4005142")]
			ALL = 8191
		}

		// Token: 0x02000EE2 RID: 3810
		[Token(Token = "0x2000EE2")]
		public enum OrderType
		{
			// Token: 0x04005144 RID: 20804
			[Token(Token = "0x4005144")]
			O_COMPOUND,
			// Token: 0x04005145 RID: 20805
			[Token(Token = "0x4005145")]
			O_GOLD,
			// Token: 0x04005146 RID: 20806
			[Token(Token = "0x4005146")]
			O_DIAMOND
		}

		// Token: 0x02000EE3 RID: 3811
		[Token(Token = "0x2000EE3")]
		public enum FurnitureCategory
		{
			// Token: 0x04005148 RID: 20808
			[Token(Token = "0x4005148")]
			FURNITURE,
			// Token: 0x04005149 RID: 20809
			[Token(Token = "0x4005149")]
			WALL,
			// Token: 0x0400514A RID: 20810
			[Token(Token = "0x400514A")]
			FLOOR
		}

		// Token: 0x02000EE4 RID: 3812
		[Token(Token = "0x2000EE4")]
		public enum BuildingToDoType
		{
			// Token: 0x0400514C RID: 20812
			[Token(Token = "0x400514C")]
			NONE,
			// Token: 0x0400514D RID: 20813
			[Token(Token = "0x400514D")]
			MANUF_STOP,
			// Token: 0x0400514E RID: 20814
			[Token(Token = "0x400514E")]
			TRADE_STOP,
			// Token: 0x0400514F RID: 20815
			[Token(Token = "0x400514F")]
			HIRE_EMPTY,
			// Token: 0x04005150 RID: 20816
			[Token(Token = "0x4005150")]
			MEETING_EMPTY,
			// Token: 0x04005151 RID: 20817
			[Token(Token = "0x4005151")]
			NEW_PRODUCTS,
			// Token: 0x04005152 RID: 20818
			[Token(Token = "0x4005152")]
			HAS_ORDERS,
			// Token: 0x04005153 RID: 20819
			[Token(Token = "0x4005153")]
			CHAR_TIRED,
			// Token: 0x04005154 RID: 20820
			[Token(Token = "0x4005154")]
			TRAIN_FINISH,
			// Token: 0x04005155 RID: 20821
			[Token(Token = "0x4005155")]
			HIRE_REFRESHED,
			// Token: 0x04005156 RID: 20822
			[Token(Token = "0x4005156")]
			NEW_CLUES,
			// Token: 0x04005157 RID: 20823
			[Token(Token = "0x4005157")]
			NEW_FAVOR,
			// Token: 0x04005158 RID: 20824
			[Token(Token = "0x4005158")]
			NEW_FAVOR_MAX,
			// Token: 0x04005159 RID: 20825
			[Token(Token = "0x4005159")]
			BATCH_WORK,
			// Token: 0x0400515A RID: 20826
			[Token(Token = "0x400515A")]
			BATCH_REST,
			// Token: 0x0400515B RID: 20827
			[Token(Token = "0x400515B")]
			MESSAGE_BOARD
		}

		// Token: 0x02000EE5 RID: 3813
		[Token(Token = "0x2000EE5")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum FurnitureType
		{
			// Token: 0x0400515D RID: 20829
			[Token(Token = "0x400515D")]
			FLOOR,
			// Token: 0x0400515E RID: 20830
			[Token(Token = "0x400515E")]
			CARPET,
			// Token: 0x0400515F RID: 20831
			[Token(Token = "0x400515F")]
			SEATING,
			// Token: 0x04005160 RID: 20832
			[Token(Token = "0x4005160")]
			BEDDING,
			// Token: 0x04005161 RID: 20833
			[Token(Token = "0x4005161")]
			TABLE,
			// Token: 0x04005162 RID: 20834
			[Token(Token = "0x4005162")]
			CABINET,
			// Token: 0x04005163 RID: 20835
			[Token(Token = "0x4005163")]
			DECORATION,
			// Token: 0x04005164 RID: 20836
			[Token(Token = "0x4005164")]
			WALLPAPER,
			// Token: 0x04005165 RID: 20837
			[Token(Token = "0x4005165")]
			WALLDECO,
			// Token: 0x04005166 RID: 20838
			[Token(Token = "0x4005166")]
			WALLLAMP,
			// Token: 0x04005167 RID: 20839
			[Token(Token = "0x4005167")]
			CEILING,
			// Token: 0x04005168 RID: 20840
			[Token(Token = "0x4005168")]
			CEILINGLAMP,
			// Token: 0x04005169 RID: 20841
			[Token(Token = "0x4005169")]
			FUNCTION,
			// Token: 0x0400516A RID: 20842
			[Token(Token = "0x400516A")]
			INTERACT
		}

		// Token: 0x02000EE6 RID: 3814
		[Token(Token = "0x2000EE6")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum FurnitureSubType
		{
			// Token: 0x0400516C RID: 20844
			[Token(Token = "0x400516C")]
			NONE,
			// Token: 0x0400516D RID: 20845
			[Token(Token = "0x400516D")]
			CHAIR,
			// Token: 0x0400516E RID: 20846
			[Token(Token = "0x400516E")]
			SOFA,
			// Token: 0x0400516F RID: 20847
			[Token(Token = "0x400516F")]
			BARSTOOL,
			// Token: 0x04005170 RID: 20848
			[Token(Token = "0x4005170")]
			STOOL,
			// Token: 0x04005171 RID: 20849
			[Token(Token = "0x4005171")]
			BENCH,
			// Token: 0x04005172 RID: 20850
			[Token(Token = "0x4005172")]
			ORTHER_S,
			// Token: 0x04005173 RID: 20851
			[Token(Token = "0x4005173")]
			POSTER,
			// Token: 0x04005174 RID: 20852
			[Token(Token = "0x4005174")]
			CURTAIN,
			// Token: 0x04005175 RID: 20853
			[Token(Token = "0x4005175")]
			BOARD_WD,
			// Token: 0x04005176 RID: 20854
			[Token(Token = "0x4005176")]
			SHELF,
			// Token: 0x04005177 RID: 20855
			[Token(Token = "0x4005177")]
			INSTRUMENT_WD,
			// Token: 0x04005178 RID: 20856
			[Token(Token = "0x4005178")]
			ART_WD,
			// Token: 0x04005179 RID: 20857
			[Token(Token = "0x4005179")]
			PLAQUE,
			// Token: 0x0400517A RID: 20858
			[Token(Token = "0x400517A")]
			CONTRACT,
			// Token: 0x0400517B RID: 20859
			[Token(Token = "0x400517B")]
			ANNIHILATION,
			// Token: 0x0400517C RID: 20860
			[Token(Token = "0x400517C")]
			ORTHER_WD,
			// Token: 0x0400517D RID: 20861
			[Token(Token = "0x400517D")]
			FLOORLAMP,
			// Token: 0x0400517E RID: 20862
			[Token(Token = "0x400517E")]
			PLANT,
			// Token: 0x0400517F RID: 20863
			[Token(Token = "0x400517F")]
			PARTITION,
			// Token: 0x04005180 RID: 20864
			[Token(Token = "0x4005180")]
			COOKING,
			// Token: 0x04005181 RID: 20865
			[Token(Token = "0x4005181")]
			CATERING,
			// Token: 0x04005182 RID: 20866
			[Token(Token = "0x4005182")]
			DEVICE,
			// Token: 0x04005183 RID: 20867
			[Token(Token = "0x4005183")]
			INSTRUMENT_D,
			// Token: 0x04005184 RID: 20868
			[Token(Token = "0x4005184")]
			ART_D,
			// Token: 0x04005185 RID: 20869
			[Token(Token = "0x4005185")]
			BOARD_D,
			// Token: 0x04005186 RID: 20870
			[Token(Token = "0x4005186")]
			ENTERTAINMENT,
			// Token: 0x04005187 RID: 20871
			[Token(Token = "0x4005187")]
			STORAGE,
			// Token: 0x04005188 RID: 20872
			[Token(Token = "0x4005188")]
			DRESSING,
			// Token: 0x04005189 RID: 20873
			[Token(Token = "0x4005189")]
			WARM,
			// Token: 0x0400518A RID: 20874
			[Token(Token = "0x400518A")]
			WASH,
			// Token: 0x0400518B RID: 20875
			[Token(Token = "0x400518B")]
			ORTHER_D,
			// Token: 0x0400518C RID: 20876
			[Token(Token = "0x400518C")]
			COLUMN,
			// Token: 0x0400518D RID: 20877
			[Token(Token = "0x400518D")]
			DECORATION_C,
			// Token: 0x0400518E RID: 20878
			[Token(Token = "0x400518E")]
			CURTAIN_C,
			// Token: 0x0400518F RID: 20879
			[Token(Token = "0x400518F")]
			DEVICE_C,
			// Token: 0x04005190 RID: 20880
			[Token(Token = "0x4005190")]
			CONTRACT_2,
			// Token: 0x04005191 RID: 20881
			[Token(Token = "0x4005191")]
			LIGHT,
			// Token: 0x04005192 RID: 20882
			[Token(Token = "0x4005192")]
			ORTHER_C,
			// Token: 0x04005193 RID: 20883
			[Token(Token = "0x4005193")]
			VISITOR,
			// Token: 0x04005194 RID: 20884
			[Token(Token = "0x4005194")]
			MUSIC
		}

		// Token: 0x02000EE7 RID: 3815
		[Token(Token = "0x2000EE7")]
		public interface IRoomBean
		{
			// Token: 0x06006BFA RID: 27642
			[Token(Token = "0x6006BFA")]
			object GetPhaseParam(int phase);
		}

		// Token: 0x02000EE8 RID: 3816
		[Token(Token = "0x2000EE8")]
		public enum FurnitureLocation
		{
			// Token: 0x04005196 RID: 20886
			[Token(Token = "0x4005196")]
			NONE,
			// Token: 0x04005197 RID: 20887
			[Token(Token = "0x4005197")]
			WALL,
			// Token: 0x04005198 RID: 20888
			[Token(Token = "0x4005198")]
			FLOOR,
			// Token: 0x04005199 RID: 20889
			[Token(Token = "0x4005199")]
			CARPET,
			// Token: 0x0400519A RID: 20890
			[Token(Token = "0x400519A")]
			CEILING,
			// Token: 0x0400519B RID: 20891
			[Token(Token = "0x400519B")]
			POSTER,
			// Token: 0x0400519C RID: 20892
			[Token(Token = "0x400519C")]
			CEILINGDECAL
		}

		// Token: 0x02000EE9 RID: 3817
		[Token(Token = "0x2000EE9")]
		public enum FurnitureInteract
		{
			// Token: 0x0400519E RID: 20894
			[Token(Token = "0x400519E")]
			NONE,
			// Token: 0x0400519F RID: 20895
			[Token(Token = "0x400519F")]
			ANIMATOR,
			// Token: 0x040051A0 RID: 20896
			[Token(Token = "0x40051A0")]
			MUSIC,
			// Token: 0x040051A1 RID: 20897
			[Token(Token = "0x40051A1")]
			FUNCTION
		}

		// Token: 0x02000EEA RID: 3818
		[Token(Token = "0x2000EEA")]
		[Serializable]
		public struct ObstaclePoint
		{
			// Token: 0x040051A2 RID: 20898
			[Token(Token = "0x40051A2")]
			[FieldOffset(Offset = "0x0")]
			public GridPosition offset;

			// Token: 0x040051A3 RID: 20899
			[Token(Token = "0x40051A3")]
			[FieldOffset(Offset = "0x8")]
			public byte edgeWalkableMask;
		}

		// Token: 0x02000EEB RID: 3819
		[Token(Token = "0x2000EEB")]
		[Serializable]
		public struct ObstacleRect
		{
			// Token: 0x040051A4 RID: 20900
			[Token(Token = "0x40051A4")]
			[FieldOffset(Offset = "0x0")]
			public GridPosition pos;

			// Token: 0x040051A5 RID: 20901
			[Token(Token = "0x40051A5")]
			[FieldOffset(Offset = "0x8")]
			public GridPosition size;

			// Token: 0x040051A6 RID: 20902
			[Token(Token = "0x40051A6")]
			[FieldOffset(Offset = "0x10")]
			public byte edgeWalkableMask;
		}

		// Token: 0x02000EEC RID: 3820
		[Token(Token = "0x2000EEC")]
		[Serializable]
		public class ObstacleData
		{
			// Token: 0x06006BFB RID: 27643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BFB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ObstacleData()
			{
			}

			// Token: 0x040051A7 RID: 20903
			[Token(Token = "0x40051A7")]
			[FieldOffset(Offset = "0x10")]
			public List<BuildingData.ObstaclePoint> floorObstacles;

			// Token: 0x040051A8 RID: 20904
			[Token(Token = "0x40051A8")]
			[FieldOffset(Offset = "0x18")]
			public List<BuildingData.ObstaclePoint> backwallObstacles;
		}

		// Token: 0x02000EED RID: 3821
		[Token(Token = "0x2000EED")]
		[Serializable]
		public class BuildingLocalData
		{
			// Token: 0x06006BFC RID: 27644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BFC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuildingLocalData()
			{
			}

			// Token: 0x040051A9 RID: 20905
			[Token(Token = "0x40051A9")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, BuildingData.ObstacleData> furnitureObstacleData;

			// Token: 0x040051AA RID: 20906
			[Token(Token = "0x40051AA")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, BuildingData.ObstacleData> roomObstacleData;

			// Token: 0x040051AB RID: 20907
			[Token(Token = "0x40051AB")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, BuildingData.FurnitureLODConfig> furnitureLODConfig;
		}

		// Token: 0x02000EEE RID: 3822
		[Token(Token = "0x2000EEE")]
		[Serializable]
		public class FurnitureLODConfig
		{
			// Token: 0x06006BFD RID: 27645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BFD")]
			[Address(RVA = "0x2009EF0", Offset = "0x2008AF0", VA = "0x182009EF0")]
			public FurnitureLODConfig()
			{
			}

			// Token: 0x040051AC RID: 20908
			[Token(Token = "0x40051AC")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<BuildingData.LODLEVEL, List<string>> showedObjNames;

			// Token: 0x040051AD RID: 20909
			[Token(Token = "0x40051AD")]
			[FieldOffset(Offset = "0x18")]
			public bool isOverWrite;
		}

		// Token: 0x02000EEF RID: 3823
		[Token(Token = "0x2000EEF")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum LODLEVEL
		{
			// Token: 0x040051AF RID: 20911
			[Token(Token = "0x40051AF")]
			HIGHEST,
			// Token: 0x040051B0 RID: 20912
			[Token(Token = "0x40051B0")]
			HIGH,
			// Token: 0x040051B1 RID: 20913
			[Token(Token = "0x40051B1")]
			LOW,
			// Token: 0x040051B2 RID: 20914
			[Token(Token = "0x40051B2")]
			LOWEST,
			// Token: 0x040051B3 RID: 20915
			[Token(Token = "0x40051B3")]
			COUNT
		}

		// Token: 0x02000EF0 RID: 3824
		[Token(Token = "0x2000EF0")]
		public enum FormulaItemType
		{
			// Token: 0x040051B5 RID: 20917
			[Token(Token = "0x40051B5")]
			NONE,
			// Token: 0x040051B6 RID: 20918
			[Token(Token = "0x40051B6")]
			F_EVOLVE,
			// Token: 0x040051B7 RID: 20919
			[Token(Token = "0x40051B7")]
			F_BUILDING,
			// Token: 0x040051B8 RID: 20920
			[Token(Token = "0x40051B8")]
			F_GOLD,
			// Token: 0x040051B9 RID: 20921
			[Token(Token = "0x40051B9")]
			F_DIAMOND,
			// Token: 0x040051BA RID: 20922
			[Token(Token = "0x40051BA")]
			F_FURNITURE,
			// Token: 0x040051BB RID: 20923
			[Token(Token = "0x40051BB")]
			F_EXP,
			// Token: 0x040051BC RID: 20924
			[Token(Token = "0x40051BC")]
			F_ASC,
			// Token: 0x040051BD RID: 20925
			[Token(Token = "0x40051BD")]
			F_SKILL
		}

		// Token: 0x02000EF1 RID: 3825
		[Token(Token = "0x2000EF1")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DiySortType
		{
			// Token: 0x040051BF RID: 20927
			[Token(Token = "0x40051BF")]
			NONE,
			// Token: 0x040051C0 RID: 20928
			[Token(Token = "0x40051C0")]
			THEME,
			// Token: 0x040051C1 RID: 20929
			[Token(Token = "0x40051C1")]
			FURNITURE,
			// Token: 0x040051C2 RID: 20930
			[Token(Token = "0x40051C2")]
			FURNITURE_IN_THEME,
			// Token: 0x040051C3 RID: 20931
			[Token(Token = "0x40051C3")]
			RECENT_THEME,
			// Token: 0x040051C4 RID: 20932
			[Token(Token = "0x40051C4")]
			RECENT_FURNITURE,
			// Token: 0x040051C5 RID: 20933
			[Token(Token = "0x40051C5")]
			MEETING_THEME,
			// Token: 0x040051C6 RID: 20934
			[Token(Token = "0x40051C6")]
			MEETING_FURNITURE,
			// Token: 0x040051C7 RID: 20935
			[Token(Token = "0x40051C7")]
			MEETING_FURNITURE_IN_THEME,
			// Token: 0x040051C8 RID: 20936
			[Token(Token = "0x40051C8")]
			MEETING_RECENT_THEME,
			// Token: 0x040051C9 RID: 20937
			[Token(Token = "0x40051C9")]
			MEETING_RECENT_FURNITURE
		}

		// Token: 0x02000EF2 RID: 3826
		[Token(Token = "0x2000EF2")]
		public enum DiyUIType
		{
			// Token: 0x040051CB RID: 20939
			[Token(Token = "0x40051CB")]
			MENU,
			// Token: 0x040051CC RID: 20940
			[Token(Token = "0x40051CC")]
			THEME,
			// Token: 0x040051CD RID: 20941
			[Token(Token = "0x40051CD")]
			FURNITURE,
			// Token: 0x040051CE RID: 20942
			[Token(Token = "0x40051CE")]
			FURNITURE_IN_THEME,
			// Token: 0x040051CF RID: 20943
			[Token(Token = "0x40051CF")]
			RECENT_THEME,
			// Token: 0x040051D0 RID: 20944
			[Token(Token = "0x40051D0")]
			RECENT_FURNITURE,
			// Token: 0x040051D1 RID: 20945
			[Token(Token = "0x40051D1")]
			PRESET
		}

		// Token: 0x02000EF3 RID: 3827
		[Token(Token = "0x2000EF3")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DiyUISortOrder
		{
			// Token: 0x040051D3 RID: 20947
			[Token(Token = "0x40051D3")]
			DESC,
			// Token: 0x040051D4 RID: 20948
			[Token(Token = "0x40051D4")]
			ASC
		}

		// Token: 0x02000EF4 RID: 3828
		[Token(Token = "0x2000EF4")]
		public class PrefabInfo
		{
			// Token: 0x06006BFE RID: 27646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BFE")]
			[Address(RVA = "0x200C860", Offset = "0x200B460", VA = "0x18200C860")]
			public PrefabInfo()
			{
			}

			// Token: 0x040051D5 RID: 20949
			[Token(Token = "0x40051D5")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040051D6 RID: 20950
			[Token(Token = "0x40051D6")]
			[FieldOffset(Offset = "0x18")]
			public string blueprintRoomOverrideId;

			// Token: 0x040051D7 RID: 20951
			[Token(Token = "0x40051D7")]
			[FieldOffset(Offset = "0x20")]
			public GridPosition size;

			// Token: 0x040051D8 RID: 20952
			[Token(Token = "0x40051D8")]
			[FieldOffset(Offset = "0x28")]
			public GridPosition floorGridSize;

			// Token: 0x040051D9 RID: 20953
			[Token(Token = "0x40051D9")]
			[FieldOffset(Offset = "0x30")]
			public GridPosition backWallGridSize;

			// Token: 0x040051DA RID: 20954
			[Token(Token = "0x40051DA")]
			[FieldOffset(Offset = "0x38")]
			public string obstacleId;
		}

		// Token: 0x02000EF5 RID: 3829
		[Token(Token = "0x2000EF5")]
		[Serializable]
		public class RoomUnlockCond
		{
			// Token: 0x06006BFF RID: 27647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BFF")]
			[Address(RVA = "0x200CB90", Offset = "0x200B790", VA = "0x18200CB90")]
			public RoomUnlockCond()
			{
			}

			// Token: 0x040051DB RID: 20955
			[Token(Token = "0x40051DB")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040051DC RID: 20956
			[Token(Token = "0x40051DC")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, BuildingData.RoomUnlockCond.CondItem> number;

			// Token: 0x02000EF6 RID: 3830
			[Token(Token = "0x2000EF6")]
			public class CondItem
			{
				// Token: 0x06006C00 RID: 27648 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C00")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CondItem()
				{
				}

				// Token: 0x040051DD RID: 20957
				[Token(Token = "0x40051DD")]
				[FieldOffset(Offset = "0x10")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.RoomType type;

				// Token: 0x040051DE RID: 20958
				[Token(Token = "0x40051DE")]
				[FieldOffset(Offset = "0x14")]
				public int level;

				// Token: 0x040051DF RID: 20959
				[Token(Token = "0x40051DF")]
				[FieldOffset(Offset = "0x18")]
				public int count;
			}
		}

		// Token: 0x02000EF7 RID: 3831
		[Token(Token = "0x2000EF7")]
		[Serializable]
		public class RoomData
		{
			// Token: 0x06006C01 RID: 27649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C01")]
			[Address(RVA = "0x200CB30", Offset = "0x200B730", VA = "0x18200CB30")]
			public RoomData()
			{
			}

			// Token: 0x040051E0 RID: 20960
			[Token(Token = "0x40051E0")]
			[FieldOffset(Offset = "0x10")]
			[JsonConverter(typeof(StringEnumConverter))]
			public BuildingData.RoomType id;

			// Token: 0x040051E1 RID: 20961
			[Token(Token = "0x40051E1")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x040051E2 RID: 20962
			[Token(Token = "0x40051E2")]
			[FieldOffset(Offset = "0x20")]
			public string description;

			// Token: 0x040051E3 RID: 20963
			[Token(Token = "0x40051E3")]
			[FieldOffset(Offset = "0x28")]
			public string defaultPrefabId;

			// Token: 0x040051E4 RID: 20964
			[Token(Token = "0x40051E4")]
			[FieldOffset(Offset = "0x30")]
			public bool canLevelDown;

			// Token: 0x040051E5 RID: 20965
			[Token(Token = "0x40051E5")]
			[FieldOffset(Offset = "0x34")]
			public int maxCount;

			// Token: 0x040051E6 RID: 20966
			[Token(Token = "0x40051E6")]
			[FieldOffset(Offset = "0x38")]
			[JsonConverter(typeof(StringEnumConverter))]
			public BuildingData.RoomCategory category;

			// Token: 0x040051E7 RID: 20967
			[Token(Token = "0x40051E7")]
			[FieldOffset(Offset = "0x3C")]
			public GridPosition size;

			// Token: 0x040051E8 RID: 20968
			[Token(Token = "0x40051E8")]
			[FieldOffset(Offset = "0x48")]
			public BuildingData.RoomData.PhaseData[] phases;

			// Token: 0x02000EF8 RID: 3832
			[Token(Token = "0x2000EF8")]
			[Serializable]
			public class BuildCost
			{
				// Token: 0x06006C02 RID: 27650 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C02")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BuildCost()
				{
				}

				// Token: 0x040051E9 RID: 20969
				[Token(Token = "0x40051E9")]
				[FieldOffset(Offset = "0x10")]
				public ItemBundle[] items;

				// Token: 0x040051EA RID: 20970
				[Token(Token = "0x40051EA")]
				[FieldOffset(Offset = "0x18")]
				public long time;

				// Token: 0x040051EB RID: 20971
				[Token(Token = "0x40051EB")]
				[FieldOffset(Offset = "0x20")]
				public int labor;
			}

			// Token: 0x02000EF9 RID: 3833
			[Token(Token = "0x2000EF9")]
			[Serializable]
			public class PhaseData
			{
				// Token: 0x06006C03 RID: 27651 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C03")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public PhaseData()
				{
				}

				// Token: 0x040051EC RID: 20972
				[Token(Token = "0x40051EC")]
				[FieldOffset(Offset = "0x10")]
				public string overrideName;

				// Token: 0x040051ED RID: 20973
				[Token(Token = "0x40051ED")]
				[FieldOffset(Offset = "0x18")]
				public string overridePrefabId;

				// Token: 0x040051EE RID: 20974
				[Token(Token = "0x40051EE")]
				[FieldOffset(Offset = "0x20")]
				public string unlockCondId;

				// Token: 0x040051EF RID: 20975
				[Token(Token = "0x40051EF")]
				[FieldOffset(Offset = "0x28")]
				public BuildingData.RoomData.BuildCost buildCost;

				// Token: 0x040051F0 RID: 20976
				[Token(Token = "0x40051F0")]
				[FieldOffset(Offset = "0x30")]
				public int electricity;

				// Token: 0x040051F1 RID: 20977
				[Token(Token = "0x40051F1")]
				[FieldOffset(Offset = "0x34")]
				public int maxStationedNum;

				// Token: 0x040051F2 RID: 20978
				[Token(Token = "0x40051F2")]
				[FieldOffset(Offset = "0x38")]
				public long manpowerCost;
			}
		}

		// Token: 0x02000EFA RID: 3834
		[Token(Token = "0x2000EFA")]
		[Serializable]
		public class LayoutData
		{
			// Token: 0x06006C04 RID: 27652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C04")]
			[Address(RVA = "0x200B610", Offset = "0x200A210", VA = "0x18200B610")]
			public LayoutData()
			{
			}

			// Token: 0x040051F3 RID: 20979
			[Token(Token = "0x40051F3")]
			public const string DEFAULT_LAYOUT_ID = "v0";

			// Token: 0x040051F4 RID: 20980
			[Token(Token = "0x40051F4")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040051F5 RID: 20981
			[Token(Token = "0x40051F5")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, BuildingData.LayoutData.RoomSlot> slots;

			// Token: 0x040051F6 RID: 20982
			[Token(Token = "0x40051F6")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, BuildingData.LayoutData.SlotCleanCost> cleanCosts;

			// Token: 0x040051F7 RID: 20983
			[Token(Token = "0x40051F7")]
			[FieldOffset(Offset = "0x28")]
			public ListDict<string, BuildingData.LayoutData.StoreyData> storeys;

			// Token: 0x02000EFB RID: 3835
			[Token(Token = "0x2000EFB")]
			[Serializable]
			public class RoomSlot
			{
				// Token: 0x06006C05 RID: 27653 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C05")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RoomSlot()
				{
				}

				// Token: 0x040051F8 RID: 20984
				[Token(Token = "0x40051F8")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x040051F9 RID: 20985
				[Token(Token = "0x40051F9")]
				[FieldOffset(Offset = "0x18")]
				public string cleanCostId;

				// Token: 0x040051FA RID: 20986
				[Token(Token = "0x40051FA")]
				[FieldOffset(Offset = "0x20")]
				public int costLabor;

				// Token: 0x040051FB RID: 20987
				[Token(Token = "0x40051FB")]
				[FieldOffset(Offset = "0x24")]
				public int provideLabor;

				// Token: 0x040051FC RID: 20988
				[Token(Token = "0x40051FC")]
				[FieldOffset(Offset = "0x28")]
				public GridPosition size;

				// Token: 0x040051FD RID: 20989
				[Token(Token = "0x40051FD")]
				[FieldOffset(Offset = "0x30")]
				public GridPosition offset;

				// Token: 0x040051FE RID: 20990
				[Token(Token = "0x40051FE")]
				[FieldOffset(Offset = "0x38")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.RoomCategory category;

				// Token: 0x040051FF RID: 20991
				[Token(Token = "0x40051FF")]
				[FieldOffset(Offset = "0x40")]
				public string storeyId;
			}

			// Token: 0x02000EFC RID: 3836
			[Token(Token = "0x2000EFC")]
			[Serializable]
			public class SlotCleanCost
			{
				// Token: 0x06006C06 RID: 27654 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C06")]
				[Address(RVA = "0x200D3B0", Offset = "0x200BFB0", VA = "0x18200D3B0")]
				public SlotCleanCost()
				{
				}

				// Token: 0x04005200 RID: 20992
				[Token(Token = "0x4005200")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04005201 RID: 20993
				[Token(Token = "0x4005201")]
				[FieldOffset(Offset = "0x18")]
				public ListDict<int, BuildingData.LayoutData.SlotCleanCost.CountCost> number;

				// Token: 0x02000EFD RID: 3837
				[Token(Token = "0x2000EFD")]
				[Serializable]
				public class CountCost
				{
					// Token: 0x06006C07 RID: 27655 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006C07")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public CountCost()
					{
					}

					// Token: 0x04005202 RID: 20994
					[Token(Token = "0x4005202")]
					[FieldOffset(Offset = "0x10")]
					public ItemBundle[] items;
				}
			}

			// Token: 0x02000EFE RID: 3838
			[Token(Token = "0x2000EFE")]
			public class StoreyData
			{
				// Token: 0x06006C08 RID: 27656 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C08")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public StoreyData()
				{
				}

				// Token: 0x04005203 RID: 20995
				[Token(Token = "0x4005203")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04005204 RID: 20996
				[Token(Token = "0x4005204")]
				[FieldOffset(Offset = "0x18")]
				public int yOffset;

				// Token: 0x04005205 RID: 20997
				[Token(Token = "0x4005205")]
				[FieldOffset(Offset = "0x1C")]
				public int unlockControlLevel;

				// Token: 0x04005206 RID: 20998
				[Token(Token = "0x4005206")]
				[FieldOffset(Offset = "0x20")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.LayoutData.StoreyData.Type type;

				// Token: 0x02000EFF RID: 3839
				[Token(Token = "0x2000EFF")]
				public enum Type
				{
					// Token: 0x04005208 RID: 21000
					[Token(Token = "0x4005208")]
					UPGROUND,
					// Token: 0x04005209 RID: 21001
					[Token(Token = "0x4005209")]
					DOWNGROUND
				}
			}
		}

		// Token: 0x02000F00 RID: 3840
		[Token(Token = "0x2000F00")]
		public enum BuffCategory
		{
			// Token: 0x0400520B RID: 21003
			[Token(Token = "0x400520B")]
			NONE,
			// Token: 0x0400520C RID: 21004
			[Token(Token = "0x400520C")]
			FUNCTION,
			// Token: 0x0400520D RID: 21005
			[Token(Token = "0x400520D")]
			OUTPUT,
			// Token: 0x0400520E RID: 21006
			[Token(Token = "0x400520E")]
			RECOVERY
		}

		// Token: 0x02000F01 RID: 3841
		[Token(Token = "0x2000F01")]
		public class BuildingCharacter
		{
			// Token: 0x06006C09 RID: 27657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C09")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BuildingCharacter()
			{
			}

			// Token: 0x0400520F RID: 21007
			[Token(Token = "0x400520F")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04005210 RID: 21008
			[Token(Token = "0x4005210")]
			[FieldOffset(Offset = "0x18")]
			public long maxManpower;

			// Token: 0x04005211 RID: 21009
			[Token(Token = "0x4005211")]
			[FieldOffset(Offset = "0x20")]
			public List<BuildingData.BuildingBuffCharSlot> buffChar;
		}

		// Token: 0x02000F02 RID: 3842
		[Token(Token = "0x2000F02")]
		public class BuildingBuffCharSlot
		{
			// Token: 0x06006C0A RID: 27658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C0A")]
			[Address(RVA = "0x2006A00", Offset = "0x2005600", VA = "0x182006A00")]
			public BuildingBuffCharSlot()
			{
			}

			// Token: 0x04005212 RID: 21010
			[Token(Token = "0x4005212")]
			[FieldOffset(Offset = "0x10")]
			public List<BuildingData.BuildingBuffCharSlot.SlotItem> buffData;

			// Token: 0x02000F03 RID: 3843
			[Token(Token = "0x2000F03")]
			public class SlotItem
			{
				// Token: 0x06006C0B RID: 27659 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C0B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SlotItem()
				{
				}

				// Token: 0x04005213 RID: 21011
				[Token(Token = "0x4005213")]
				[FieldOffset(Offset = "0x10")]
				public string buffId;

				// Token: 0x04005214 RID: 21012
				[Token(Token = "0x4005214")]
				[FieldOffset(Offset = "0x18")]
				public CharacterData.UnlockCondition cond;
			}
		}

		// Token: 0x02000F04 RID: 3844
		[Token(Token = "0x2000F04")]
		public class BuildingBuff
		{
			// Token: 0x06006C0C RID: 27660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C0C")]
			[Address(RVA = "0x2006A90", Offset = "0x2005690", VA = "0x182006A90")]
			public BuildingBuff()
			{
			}

			// Token: 0x04005215 RID: 21013
			[Token(Token = "0x4005215")]
			[FieldOffset(Offset = "0x10")]
			public string buffId;

			// Token: 0x04005216 RID: 21014
			[Token(Token = "0x4005216")]
			[FieldOffset(Offset = "0x18")]
			public string buffName;

			// Token: 0x04005217 RID: 21015
			[Token(Token = "0x4005217")]
			[FieldOffset(Offset = "0x20")]
			public string buffIcon;

			// Token: 0x04005218 RID: 21016
			[Token(Token = "0x4005218")]
			[FieldOffset(Offset = "0x28")]
			public string skillIcon;

			// Token: 0x04005219 RID: 21017
			[Token(Token = "0x4005219")]
			[FieldOffset(Offset = "0x30")]
			public int sortId;

			// Token: 0x0400521A RID: 21018
			[Token(Token = "0x400521A")]
			[FieldOffset(Offset = "0x38")]
			public string buffColor;

			// Token: 0x0400521B RID: 21019
			[Token(Token = "0x400521B")]
			[FieldOffset(Offset = "0x40")]
			public string textColor;

			// Token: 0x0400521C RID: 21020
			[Token(Token = "0x400521C")]
			[FieldOffset(Offset = "0x48")]
			[JsonConverter(typeof(StringEnumConverter))]
			public BuildingData.BuffCategory buffCategory;

			// Token: 0x0400521D RID: 21021
			[Token(Token = "0x400521D")]
			[FieldOffset(Offset = "0x4C")]
			[JsonConverter(typeof(StringEnumConverter))]
			public BuildingData.RoomType roomType;

			// Token: 0x0400521E RID: 21022
			[Token(Token = "0x400521E")]
			[FieldOffset(Offset = "0x50")]
			public string description;

			// Token: 0x0400521F RID: 21023
			[Token(Token = "0x400521F")]
			[FieldOffset(Offset = "0x58")]
			public int efficiency;

			// Token: 0x04005220 RID: 21024
			[Token(Token = "0x4005220")]
			[FieldOffset(Offset = "0x5C")]
			public int targetGroupSortId;

			// Token: 0x04005221 RID: 21025
			[Token(Token = "0x4005221")]
			[FieldOffset(Offset = "0x60")]
			public HashSet<string> targets;
		}

		// Token: 0x02000F05 RID: 3845
		[Token(Token = "0x2000F05")]
		public class BuildingRoomTypeBuffSortData
		{
			// Token: 0x06006C0D RID: 27661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C0D")]
			[Address(RVA = "0x2007760", Offset = "0x2006360", VA = "0x182007760")]
			public BuildingRoomTypeBuffSortData()
			{
			}

			// Token: 0x04005222 RID: 21026
			[Token(Token = "0x4005222")]
			[FieldOffset(Offset = "0x10")]
			public bool hasEfficiencySort;

			// Token: 0x04005223 RID: 21027
			[Token(Token = "0x4005223")]
			[FieldOffset(Offset = "0x14")]
			public int defaultGroupSortId;

			// Token: 0x04005224 RID: 21028
			[Token(Token = "0x4005224")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, BuildingData.BuildingRoomTypeBuffSortData.buffGroupInfo> efficiencyTargetDict;

			// Token: 0x02000F06 RID: 3846
			[Token(Token = "0x2000F06")]
			public struct buffGroupInfo
			{
				// Token: 0x04005225 RID: 21029
				[Token(Token = "0x4005225")]
				[FieldOffset(Offset = "0x0")]
				public HashSet<string> targets;

				// Token: 0x04005226 RID: 21030
				[Token(Token = "0x4005226")]
				[FieldOffset(Offset = "0x8")]
				public int sortId;
			}
		}

		// Token: 0x02000F07 RID: 3847
		[Token(Token = "0x2000F07")]
		public abstract class RoomBeanParam
		{
			// Token: 0x06006C0E RID: 27662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C0E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected RoomBeanParam()
			{
			}
		}

		// Token: 0x02000F08 RID: 3848
		[Token(Token = "0x2000F08")]
		public class RoomBean<TParam> : BuildingData.IRoomBean where TParam : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C0F RID: 27663 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006C0F")]
			public object GetPhaseParam(int level)
			{
				return null;
			}

			// Token: 0x06006C10 RID: 27664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C10")]
			public RoomBean()
			{
			}

			// Token: 0x04005227 RID: 21031
			[Token(Token = "0x4005227")]
			[FieldOffset(Offset = "0x0")]
			public List<TParam> phases;
		}

		// Token: 0x02000F09 RID: 3849
		[Token(Token = "0x2000F09")]
		public class ControlRoomBean : BuildingData.RoomBean<BuildingData.ControlRoomPhase>
		{
			// Token: 0x06006C11 RID: 27665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C11")]
			[Address(RVA = "0x20086D0", Offset = "0x20072D0", VA = "0x1820086D0")]
			public ControlRoomBean()
			{
			}

			// Token: 0x04005228 RID: 21032
			[Token(Token = "0x4005228")]
			[FieldOffset(Offset = "0x18")]
			public int basicCostBuff;
		}

		// Token: 0x02000F0A RID: 3850
		[Token(Token = "0x2000F0A")]
		public class ControlRoomPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C12 RID: 27666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C12")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ControlRoomPhase()
			{
			}
		}

		// Token: 0x02000F0B RID: 3851
		[Token(Token = "0x2000F0B")]
		public class ManufactRoomBean : BuildingData.RoomBean<BuildingData.ManufactPhase>
		{
			// Token: 0x06006C13 RID: 27667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C13")]
			[Address(RVA = "0x200B7C0", Offset = "0x200A3C0", VA = "0x18200B7C0")]
			public ManufactRoomBean()
			{
			}

			// Token: 0x04005229 RID: 21033
			[Token(Token = "0x4005229")]
			[FieldOffset(Offset = "0x18")]
			public float basicSpeedBuff;
		}

		// Token: 0x02000F0C RID: 3852
		[Token(Token = "0x2000F0C")]
		public class ManufactPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C14 RID: 27668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C14")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ManufactPhase()
			{
			}

			// Token: 0x0400522A RID: 21034
			[Token(Token = "0x400522A")]
			[FieldOffset(Offset = "0x10")]
			public float speed;

			// Token: 0x0400522B RID: 21035
			[Token(Token = "0x400522B")]
			[FieldOffset(Offset = "0x14")]
			public int outputCapacity;
		}

		// Token: 0x02000F0D RID: 3853
		[Token(Token = "0x2000F0D")]
		public class ShopPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C15 RID: 27669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C15")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopPhase()
			{
			}

			// Token: 0x0400522C RID: 21036
			[Token(Token = "0x400522C")]
			[FieldOffset(Offset = "0x10")]
			public int counterNum;

			// Token: 0x0400522D RID: 21037
			[Token(Token = "0x400522D")]
			[FieldOffset(Offset = "0x14")]
			public float speed;

			// Token: 0x0400522E RID: 21038
			[Token(Token = "0x400522E")]
			[FieldOffset(Offset = "0x18")]
			public int moneyCapacity;
		}

		// Token: 0x02000F0E RID: 3854
		[Token(Token = "0x2000F0E")]
		public class HireRoomBean : BuildingData.RoomBean<BuildingData.HirePhase>
		{
			// Token: 0x06006C16 RID: 27670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C16")]
			[Address(RVA = "0x200A0B0", Offset = "0x2008CB0", VA = "0x18200A0B0")]
			public HireRoomBean()
			{
			}

			// Token: 0x0400522F RID: 21039
			[Token(Token = "0x400522F")]
			[FieldOffset(Offset = "0x18")]
			public float basicSpeedBuff;
		}

		// Token: 0x02000F0F RID: 3855
		[Token(Token = "0x2000F0F")]
		public class HirePhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C17 RID: 27671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C17")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HirePhase()
			{
			}

			// Token: 0x04005230 RID: 21040
			[Token(Token = "0x4005230")]
			[FieldOffset(Offset = "0x10")]
			public float economizeRate;

			// Token: 0x04005231 RID: 21041
			[Token(Token = "0x4005231")]
			[FieldOffset(Offset = "0x14")]
			public int resSpeed;

			// Token: 0x04005232 RID: 21042
			[Token(Token = "0x4005232")]
			[FieldOffset(Offset = "0x18")]
			public int refreshTimes;
		}

		// Token: 0x02000F10 RID: 3856
		[Token(Token = "0x2000F10")]
		public class DormPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C18 RID: 27672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C18")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DormPhase()
			{
			}

			// Token: 0x04005233 RID: 21043
			[Token(Token = "0x4005233")]
			[FieldOffset(Offset = "0x10")]
			public int manpowerRecover;

			// Token: 0x04005234 RID: 21044
			[Token(Token = "0x4005234")]
			[FieldOffset(Offset = "0x14")]
			public int decorationLimit;
		}

		// Token: 0x02000F11 RID: 3857
		[Token(Token = "0x2000F11")]
		public class PrivatePhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C19 RID: 27673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C19")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PrivatePhase()
			{
			}

			// Token: 0x04005235 RID: 21045
			[Token(Token = "0x4005235")]
			[FieldOffset(Offset = "0x10")]
			public int decorationLimit;
		}

		// Token: 0x02000F12 RID: 3858
		[Token(Token = "0x2000F12")]
		public class MeetingRoomBean : BuildingData.RoomBean<BuildingData.MeetingPhase>
		{
			// Token: 0x06006C1A RID: 27674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C1A")]
			[Address(RVA = "0x200B800", Offset = "0x200A400", VA = "0x18200B800")]
			public MeetingRoomBean()
			{
			}

			// Token: 0x04005236 RID: 21046
			[Token(Token = "0x4005236")]
			[FieldOffset(Offset = "0x18")]
			public float basicSpeedBuff;
		}

		// Token: 0x02000F13 RID: 3859
		[Token(Token = "0x2000F13")]
		public class MeetingPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C1B RID: 27675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C1B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MeetingPhase()
			{
			}

			// Token: 0x04005237 RID: 21047
			[Token(Token = "0x4005237")]
			[FieldOffset(Offset = "0x10")]
			public int friendSlotInc;

			// Token: 0x04005238 RID: 21048
			[Token(Token = "0x4005238")]
			[FieldOffset(Offset = "0x14")]
			public int maxVisitorNum;

			// Token: 0x04005239 RID: 21049
			[Token(Token = "0x4005239")]
			[FieldOffset(Offset = "0x18")]
			public int gatheringSpeed;
		}

		// Token: 0x02000F14 RID: 3860
		[Token(Token = "0x2000F14")]
		public class TradingRoomBean : BuildingData.RoomBean<BuildingData.TradingPhase>
		{
			// Token: 0x06006C1C RID: 27676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C1C")]
			[Address(RVA = "0x200E300", Offset = "0x200CF00", VA = "0x18200E300")]
			public TradingRoomBean()
			{
			}

			// Token: 0x0400523A RID: 21050
			[Token(Token = "0x400523A")]
			[FieldOffset(Offset = "0x18")]
			public float basicSpeedBuff;
		}

		// Token: 0x02000F15 RID: 3861
		[Token(Token = "0x2000F15")]
		public class TradingPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C1D RID: 27677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C1D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TradingPhase()
			{
			}

			// Token: 0x0400523B RID: 21051
			[Token(Token = "0x400523B")]
			[FieldOffset(Offset = "0x10")]
			public float orderSpeed;

			// Token: 0x0400523C RID: 21052
			[Token(Token = "0x400523C")]
			[FieldOffset(Offset = "0x14")]
			public int orderLimit;

			// Token: 0x0400523D RID: 21053
			[Token(Token = "0x400523D")]
			[FieldOffset(Offset = "0x18")]
			public int orderRarity;
		}

		// Token: 0x02000F16 RID: 3862
		[Token(Token = "0x2000F16")]
		public class WorkshopPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C1E RID: 27678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C1E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WorkshopPhase()
			{
			}

			// Token: 0x0400523E RID: 21054
			[Token(Token = "0x400523E")]
			[FieldOffset(Offset = "0x10")]
			public float manpowerFactor;
		}

		// Token: 0x02000F17 RID: 3863
		[Token(Token = "0x2000F17")]
		public class TrainingBean : BuildingData.RoomBean<BuildingData.TrainingPhase>
		{
			// Token: 0x06006C1F RID: 27679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C1F")]
			[Address(RVA = "0x200E340", Offset = "0x200CF40", VA = "0x18200E340")]
			public TrainingBean()
			{
			}

			// Token: 0x0400523F RID: 21055
			[Token(Token = "0x400523F")]
			[FieldOffset(Offset = "0x18")]
			public float basicSpeedBuff;
		}

		// Token: 0x02000F18 RID: 3864
		[Token(Token = "0x2000F18")]
		public class TrainingPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C20 RID: 27680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C20")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TrainingPhase()
			{
			}

			// Token: 0x04005240 RID: 21056
			[Token(Token = "0x4005240")]
			[FieldOffset(Offset = "0x10")]
			public int specSkillLvlLimit;
		}

		// Token: 0x02000F19 RID: 3865
		[Token(Token = "0x2000F19")]
		public class PowerRoomBean : BuildingData.RoomBean<BuildingData.PowerPhase>
		{
			// Token: 0x06006C21 RID: 27681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C21")]
			[Address(RVA = "0x200C820", Offset = "0x200B420", VA = "0x18200C820")]
			public PowerRoomBean()
			{
			}

			// Token: 0x04005241 RID: 21057
			[Token(Token = "0x4005241")]
			[FieldOffset(Offset = "0x18")]
			public float basicSpeedBuff;
		}

		// Token: 0x02000F1A RID: 3866
		[Token(Token = "0x2000F1A")]
		public class PowerPhase : BuildingData.RoomBeanParam
		{
			// Token: 0x06006C22 RID: 27682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C22")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PowerPhase()
			{
			}
		}

		// Token: 0x02000F1B RID: 3867
		[Token(Token = "0x2000F1B")]
		public class CustomData
		{
			// Token: 0x06006C23 RID: 27683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C23")]
			[Address(RVA = "0x20087D0", Offset = "0x20073D0", VA = "0x1820087D0")]
			public CustomData()
			{
			}

			// Token: 0x04005242 RID: 21058
			[Token(Token = "0x4005242")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, BuildingData.CustomData.FurnitureData> furnitures;

			// Token: 0x04005243 RID: 21059
			[Token(Token = "0x4005243")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<string, BuildingData.CustomData.ThemeData> themes;

			// Token: 0x04005244 RID: 21060
			[Token(Token = "0x4005244")]
			[FieldOffset(Offset = "0x20")]
			public ListDict<string, BuildingData.CustomData.GroupData> groups;

			// Token: 0x04005245 RID: 21061
			[Token(Token = "0x4005245")]
			[FieldOffset(Offset = "0x28")]
			public ListDict<BuildingData.FurnitureType, BuildingData.CustomData.FurnitureTypeData> types;

			// Token: 0x04005246 RID: 21062
			[Token(Token = "0x4005246")]
			[FieldOffset(Offset = "0x30")]
			public ListDict<BuildingData.FurnitureSubType, BuildingData.CustomData.FurnitureSubTypeData> subTypes;

			// Token: 0x04005247 RID: 21063
			[Token(Token = "0x4005247")]
			[FieldOffset(Offset = "0x38")]
			public ListDict<string, List<BuildingData.CustomData.DormitoryDefaultFurnitureItem>> defaultFurnitures;

			// Token: 0x04005248 RID: 21064
			[Token(Token = "0x4005248")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, List<BuildingData.CustomData.InteractItem>> interactGroups;

			// Token: 0x04005249 RID: 21065
			[Token(Token = "0x4005249")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<BuildingData.DiySortType, Dictionary<string, BuildingData.CustomData.DiyUISortTemplateListData>> diyUISortTemplates;

			// Token: 0x02000F1C RID: 3868
			[Token(Token = "0x2000F1C")]
			public class FurnitureData
			{
				// Token: 0x06006C24 RID: 27684 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C24")]
				[Address(RVA = "0x2009E80", Offset = "0x2008A80", VA = "0x182009E80")]
				public FurnitureData()
				{
				}

				// Token: 0x0400524A RID: 21066
				[Token(Token = "0x400524A")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x0400524B RID: 21067
				[Token(Token = "0x400524B")]
				[FieldOffset(Offset = "0x18")]
				public int sortId;

				// Token: 0x0400524C RID: 21068
				[Token(Token = "0x400524C")]
				[FieldOffset(Offset = "0x20")]
				public string name;

				// Token: 0x0400524D RID: 21069
				[Token(Token = "0x400524D")]
				[FieldOffset(Offset = "0x28")]
				public string iconId;

				// Token: 0x0400524E RID: 21070
				[Token(Token = "0x400524E")]
				[FieldOffset(Offset = "0x30")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.FurnitureInteract interactType;

				// Token: 0x0400524F RID: 21071
				[Token(Token = "0x400524F")]
				[FieldOffset(Offset = "0x38")]
				public string musicId;

				// Token: 0x04005250 RID: 21072
				[Token(Token = "0x4005250")]
				[FieldOffset(Offset = "0x40")]
				public BuildingData.FurnitureType type;

				// Token: 0x04005251 RID: 21073
				[Token(Token = "0x4005251")]
				[FieldOffset(Offset = "0x44")]
				public BuildingData.FurnitureSubType subType;

				// Token: 0x04005252 RID: 21074
				[Token(Token = "0x4005252")]
				[FieldOffset(Offset = "0x48")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.FurnitureLocation location;

				// Token: 0x04005253 RID: 21075
				[Token(Token = "0x4005253")]
				[FieldOffset(Offset = "0x4C")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.FurnitureCategory category;

				// Token: 0x04005254 RID: 21076
				[Token(Token = "0x4005254")]
				[FieldOffset(Offset = "0x50")]
				public bool validOnRotate;

				// Token: 0x04005255 RID: 21077
				[Token(Token = "0x4005255")]
				[FieldOffset(Offset = "0x51")]
				public bool enableRotate;

				// Token: 0x04005256 RID: 21078
				[Token(Token = "0x4005256")]
				[FieldOffset(Offset = "0x54")]
				public int rarity;

				// Token: 0x04005257 RID: 21079
				[Token(Token = "0x4005257")]
				[FieldOffset(Offset = "0x58")]
				public string themeId;

				// Token: 0x04005258 RID: 21080
				[Token(Token = "0x4005258")]
				[FieldOffset(Offset = "0x60")]
				public string groupId;

				// Token: 0x04005259 RID: 21081
				[Token(Token = "0x4005259")]
				[FieldOffset(Offset = "0x68")]
				public int width;

				// Token: 0x0400525A RID: 21082
				[Token(Token = "0x400525A")]
				[FieldOffset(Offset = "0x6C")]
				public int depth;

				// Token: 0x0400525B RID: 21083
				[Token(Token = "0x400525B")]
				[FieldOffset(Offset = "0x70")]
				public int height;

				// Token: 0x0400525C RID: 21084
				[Token(Token = "0x400525C")]
				[FieldOffset(Offset = "0x74")]
				public int comfort;

				// Token: 0x0400525D RID: 21085
				[Token(Token = "0x400525D")]
				[FieldOffset(Offset = "0x78")]
				public string usage;

				// Token: 0x0400525E RID: 21086
				[Token(Token = "0x400525E")]
				[FieldOffset(Offset = "0x80")]
				public string description;

				// Token: 0x0400525F RID: 21087
				[Token(Token = "0x400525F")]
				[FieldOffset(Offset = "0x88")]
				public string obtainApproach;

				// Token: 0x04005260 RID: 21088
				[Token(Token = "0x4005260")]
				[FieldOffset(Offset = "0x90")]
				public string processedProductId;

				// Token: 0x04005261 RID: 21089
				[Token(Token = "0x4005261")]
				[FieldOffset(Offset = "0x98")]
				public int processedProductCount;

				// Token: 0x04005262 RID: 21090
				[Token(Token = "0x4005262")]
				[FieldOffset(Offset = "0x9C")]
				public int processedByProductPercentage;

				// Token: 0x04005263 RID: 21091
				[Token(Token = "0x4005263")]
				[FieldOffset(Offset = "0xA0")]
				public List<BuildingData.WorkshopExtraWeightItem> processedByProductGroup;

				// Token: 0x04005264 RID: 21092
				[Token(Token = "0x4005264")]
				[FieldOffset(Offset = "0xA8")]
				public bool canBeDestroy;

				// Token: 0x04005265 RID: 21093
				[Token(Token = "0x4005265")]
				[FieldOffset(Offset = "0xAC")]
				public int isOnly;

				// Token: 0x04005266 RID: 21094
				[Token(Token = "0x4005266")]
				[FieldOffset(Offset = "0xB0")]
				public int enableRoomType;

				// Token: 0x04005267 RID: 21095
				[Token(Token = "0x4005267")]
				[FieldOffset(Offset = "0xB4")]
				public int quantity;
			}

			// Token: 0x02000F1D RID: 3869
			[Token(Token = "0x2000F1D")]
			public class ThemeData
			{
				// Token: 0x06006C25 RID: 27685 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C25")]
				[Address(RVA = "0x200E240", Offset = "0x200CE40", VA = "0x18200E240")]
				public ThemeData()
				{
				}

				// Token: 0x04005268 RID: 21096
				[Token(Token = "0x4005268")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04005269 RID: 21097
				[Token(Token = "0x4005269")]
				[FieldOffset(Offset = "0x18")]
				public int enableRoomType;

				// Token: 0x0400526A RID: 21098
				[Token(Token = "0x400526A")]
				[FieldOffset(Offset = "0x1C")]
				public int sortId;

				// Token: 0x0400526B RID: 21099
				[Token(Token = "0x400526B")]
				[FieldOffset(Offset = "0x20")]
				public string name;

				// Token: 0x0400526C RID: 21100
				[Token(Token = "0x400526C")]
				[FieldOffset(Offset = "0x28")]
				public string themeType;

				// Token: 0x0400526D RID: 21101
				[Token(Token = "0x400526D")]
				[FieldOffset(Offset = "0x30")]
				public string desc;

				// Token: 0x0400526E RID: 21102
				[Token(Token = "0x400526E")]
				[FieldOffset(Offset = "0x38")]
				public List<BuildingData.CustomData.ThemeQuickSetupItem> quickSetup;

				// Token: 0x0400526F RID: 21103
				[Token(Token = "0x400526F")]
				[FieldOffset(Offset = "0x40")]
				public List<string> groups;

				// Token: 0x04005270 RID: 21104
				[Token(Token = "0x4005270")]
				[FieldOffset(Offset = "0x48")]
				public List<string> furnitures;
			}

			// Token: 0x02000F1E RID: 3870
			[Token(Token = "0x2000F1E")]
			public class GroupData
			{
				// Token: 0x06006C26 RID: 27686 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C26")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public GroupData()
				{
				}

				// Token: 0x04005271 RID: 21105
				[Token(Token = "0x4005271")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04005272 RID: 21106
				[Token(Token = "0x4005272")]
				[FieldOffset(Offset = "0x18")]
				public int sortId;

				// Token: 0x04005273 RID: 21107
				[Token(Token = "0x4005273")]
				[FieldOffset(Offset = "0x20")]
				public string name;

				// Token: 0x04005274 RID: 21108
				[Token(Token = "0x4005274")]
				[FieldOffset(Offset = "0x28")]
				public string themeId;

				// Token: 0x04005275 RID: 21109
				[Token(Token = "0x4005275")]
				[FieldOffset(Offset = "0x30")]
				public int comfort;

				// Token: 0x04005276 RID: 21110
				[Token(Token = "0x4005276")]
				[FieldOffset(Offset = "0x34")]
				public int count;

				// Token: 0x04005277 RID: 21111
				[Token(Token = "0x4005277")]
				[FieldOffset(Offset = "0x38")]
				public List<string> furniture;
			}

			// Token: 0x02000F1F RID: 3871
			[Token(Token = "0x2000F1F")]
			public class ThemeQuickSetupItem
			{
				// Token: 0x06006C27 RID: 27687 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C27")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ThemeQuickSetupItem()
				{
				}

				// Token: 0x04005278 RID: 21112
				[Token(Token = "0x4005278")]
				[FieldOffset(Offset = "0x10")]
				public string furnitureId;

				// Token: 0x04005279 RID: 21113
				[Token(Token = "0x4005279")]
				[FieldOffset(Offset = "0x18")]
				public int pos0;

				// Token: 0x0400527A RID: 21114
				[Token(Token = "0x400527A")]
				[FieldOffset(Offset = "0x1C")]
				public int pos1;

				// Token: 0x0400527B RID: 21115
				[Token(Token = "0x400527B")]
				[FieldOffset(Offset = "0x20")]
				public int dir;
			}

			// Token: 0x02000F20 RID: 3872
			[Token(Token = "0x2000F20")]
			public class FurnitureTypeData
			{
				// Token: 0x06006C28 RID: 27688 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C28")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public FurnitureTypeData()
				{
				}

				// Token: 0x0400527C RID: 21116
				[Token(Token = "0x400527C")]
				[FieldOffset(Offset = "0x10")]
				public BuildingData.FurnitureType type;

				// Token: 0x0400527D RID: 21117
				[Token(Token = "0x400527D")]
				[FieldOffset(Offset = "0x18")]
				public string name;

				// Token: 0x0400527E RID: 21118
				[Token(Token = "0x400527E")]
				[FieldOffset(Offset = "0x20")]
				public int enableRoomType;
			}

			// Token: 0x02000F21 RID: 3873
			[Token(Token = "0x2000F21")]
			public class FurnitureSubTypeData
			{
				// Token: 0x06006C29 RID: 27689 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C29")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public FurnitureSubTypeData()
				{
				}

				// Token: 0x0400527F RID: 21119
				[Token(Token = "0x400527F")]
				[FieldOffset(Offset = "0x10")]
				public BuildingData.FurnitureSubType subType;

				// Token: 0x04005280 RID: 21120
				[Token(Token = "0x4005280")]
				[FieldOffset(Offset = "0x18")]
				public string name;

				// Token: 0x04005281 RID: 21121
				[Token(Token = "0x4005281")]
				[FieldOffset(Offset = "0x20")]
				public BuildingData.FurnitureType type;

				// Token: 0x04005282 RID: 21122
				[Token(Token = "0x4005282")]
				[FieldOffset(Offset = "0x24")]
				public int sortId;

				// Token: 0x04005283 RID: 21123
				[Token(Token = "0x4005283")]
				[FieldOffset(Offset = "0x28")]
				public int countLimit;

				// Token: 0x04005284 RID: 21124
				[Token(Token = "0x4005284")]
				[FieldOffset(Offset = "0x2C")]
				public int enableRoomType;
			}

			// Token: 0x02000F22 RID: 3874
			[Token(Token = "0x2000F22")]
			public class DormitoryDefaultFurnitureItem
			{
				// Token: 0x06006C2A RID: 27690 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C2A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DormitoryDefaultFurnitureItem()
				{
				}

				// Token: 0x04005285 RID: 21125
				[Token(Token = "0x4005285")]
				[FieldOffset(Offset = "0x10")]
				public string furnitureId;

				// Token: 0x04005286 RID: 21126
				[Token(Token = "0x4005286")]
				[FieldOffset(Offset = "0x18")]
				public int xOffset;

				// Token: 0x04005287 RID: 21127
				[Token(Token = "0x4005287")]
				[FieldOffset(Offset = "0x1C")]
				public int yOffset;

				// Token: 0x04005288 RID: 21128
				[Token(Token = "0x4005288")]
				[FieldOffset(Offset = "0x20")]
				public string defaultPrefabId;
			}

			// Token: 0x02000F23 RID: 3875
			[Token(Token = "0x2000F23")]
			public class InteractItem
			{
				// Token: 0x06006C2B RID: 27691 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C2B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public InteractItem()
				{
				}

				// Token: 0x04005289 RID: 21129
				[Token(Token = "0x4005289")]
				[FieldOffset(Offset = "0x10")]
				public string skinId;
			}

			// Token: 0x02000F24 RID: 3876
			[Token(Token = "0x2000F24")]
			public class DiyUISortTemplateListData
			{
				// Token: 0x06006C2C RID: 27692 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C2C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public DiyUISortTemplateListData()
				{
				}

				// Token: 0x0400528A RID: 21130
				[Token(Token = "0x400528A")]
				[FieldOffset(Offset = "0x10")]
				public BuildingData.DiySortType diySortType;

				// Token: 0x0400528B RID: 21131
				[Token(Token = "0x400528B")]
				[FieldOffset(Offset = "0x18")]
				public string expandState;

				// Token: 0x0400528C RID: 21132
				[Token(Token = "0x400528C")]
				[FieldOffset(Offset = "0x20")]
				public int defaultTemplateIndex;

				// Token: 0x0400528D RID: 21133
				[Token(Token = "0x400528D")]
				[FieldOffset(Offset = "0x24")]
				public BuildingData.DiyUISortOrder defaultTemplateOrder;

				// Token: 0x0400528E RID: 21134
				[Token(Token = "0x400528E")]
				[FieldOffset(Offset = "0x28")]
				public List<BuildingData.CustomData.DiyUISortTemplateListData.DiyUISortTemplateData> templates;

				// Token: 0x02000F25 RID: 3877
				[Token(Token = "0x2000F25")]
				public class DiyUISortTemplateData
				{
					// Token: 0x06006C2D RID: 27693 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006C2D")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public DiyUISortTemplateData()
					{
					}

					// Token: 0x0400528F RID: 21135
					[Token(Token = "0x400528F")]
					[FieldOffset(Offset = "0x10")]
					public string name;

					// Token: 0x04005290 RID: 21136
					[Token(Token = "0x4005290")]
					[FieldOffset(Offset = "0x18")]
					public List<string> sequences;

					// Token: 0x04005291 RID: 21137
					[Token(Token = "0x4005291")]
					[FieldOffset(Offset = "0x20")]
					public string stableSequence;

					// Token: 0x04005292 RID: 21138
					[Token(Token = "0x4005292")]
					[FieldOffset(Offset = "0x28")]
					public BuildingData.DiyUISortOrder stableSequenceOrder;
				}
			}
		}

		// Token: 0x02000F26 RID: 3878
		[Token(Token = "0x2000F26")]
		public class ManufactFormula
		{
			// Token: 0x06006C2E RID: 27694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C2E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ManufactFormula()
			{
			}

			// Token: 0x04005293 RID: 21139
			[Token(Token = "0x4005293")]
			[FieldOffset(Offset = "0x10")]
			public string formulaId;

			// Token: 0x04005294 RID: 21140
			[Token(Token = "0x4005294")]
			[FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x04005295 RID: 21141
			[Token(Token = "0x4005295")]
			[FieldOffset(Offset = "0x20")]
			public int count;

			// Token: 0x04005296 RID: 21142
			[Token(Token = "0x4005296")]
			[FieldOffset(Offset = "0x24")]
			public int weight;

			// Token: 0x04005297 RID: 21143
			[Token(Token = "0x4005297")]
			[FieldOffset(Offset = "0x28")]
			public long costPoint;

			// Token: 0x04005298 RID: 21144
			[Token(Token = "0x4005298")]
			[FieldOffset(Offset = "0x30")]
			[JsonConverter(typeof(StringEnumConverter))]
			public BuildingData.FormulaItemType formulaType;

			// Token: 0x04005299 RID: 21145
			[Token(Token = "0x4005299")]
			[FieldOffset(Offset = "0x38")]
			public string buffType;

			// Token: 0x0400529A RID: 21146
			[Token(Token = "0x400529A")]
			[FieldOffset(Offset = "0x40")]
			public List<ItemBundle> costs;

			// Token: 0x0400529B RID: 21147
			[Token(Token = "0x400529B")]
			[FieldOffset(Offset = "0x48")]
			public List<BuildingData.ManufactFormula.UnlockRoom> requireRooms;

			// Token: 0x0400529C RID: 21148
			[Token(Token = "0x400529C")]
			[FieldOffset(Offset = "0x50")]
			public List<BuildingData.ManufactFormula.UnlockStage> requireStages;

			// Token: 0x02000F27 RID: 3879
			[Token(Token = "0x2000F27")]
			public class UnlockRoom
			{
				// Token: 0x06006C2F RID: 27695 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C2F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UnlockRoom()
				{
				}

				// Token: 0x0400529D RID: 21149
				[Token(Token = "0x400529D")]
				[FieldOffset(Offset = "0x10")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.RoomType roomId;

				// Token: 0x0400529E RID: 21150
				[Token(Token = "0x400529E")]
				[FieldOffset(Offset = "0x14")]
				public int roomLevel;

				// Token: 0x0400529F RID: 21151
				[Token(Token = "0x400529F")]
				[FieldOffset(Offset = "0x18")]
				public int roomCount;
			}

			// Token: 0x02000F28 RID: 3880
			[Token(Token = "0x2000F28")]
			public class UnlockStage
			{
				// Token: 0x06006C30 RID: 27696 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C30")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UnlockStage()
				{
				}

				// Token: 0x040052A0 RID: 21152
				[Token(Token = "0x40052A0")]
				[FieldOffset(Offset = "0x10")]
				public string stageId;

				// Token: 0x040052A1 RID: 21153
				[Token(Token = "0x40052A1")]
				[FieldOffset(Offset = "0x18")]
				public int rank;
			}
		}

		// Token: 0x02000F29 RID: 3881
		[Token(Token = "0x2000F29")]
		public class WorkshopExtraWeightItem
		{
			// Token: 0x06006C31 RID: 27697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C31")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WorkshopExtraWeightItem()
			{
			}

			// Token: 0x040052A2 RID: 21154
			[Token(Token = "0x40052A2")]
			[FieldOffset(Offset = "0x10")]
			public int weight;

			// Token: 0x040052A3 RID: 21155
			[Token(Token = "0x40052A3")]
			[FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x040052A4 RID: 21156
			[Token(Token = "0x40052A4")]
			[FieldOffset(Offset = "0x20")]
			public int itemCount;
		}

		// Token: 0x02000F2A RID: 3882
		[Token(Token = "0x2000F2A")]
		public class WorkshopFormula
		{
			// Token: 0x06006C32 RID: 27698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C32")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WorkshopFormula()
			{
			}

			// Token: 0x040052A5 RID: 21157
			[Token(Token = "0x40052A5")]
			[FieldOffset(Offset = "0x10")]
			public int sortId;

			// Token: 0x040052A6 RID: 21158
			[Token(Token = "0x40052A6")]
			[FieldOffset(Offset = "0x18")]
			public string formulaId;

			// Token: 0x040052A7 RID: 21159
			[Token(Token = "0x40052A7")]
			[FieldOffset(Offset = "0x20")]
			public int rarity;

			// Token: 0x040052A8 RID: 21160
			[Token(Token = "0x40052A8")]
			[FieldOffset(Offset = "0x28")]
			public string itemId;

			// Token: 0x040052A9 RID: 21161
			[Token(Token = "0x40052A9")]
			[FieldOffset(Offset = "0x30")]
			public int count;

			// Token: 0x040052AA RID: 21162
			[Token(Token = "0x40052AA")]
			[FieldOffset(Offset = "0x38")]
			public long goldCost;

			// Token: 0x040052AB RID: 21163
			[Token(Token = "0x40052AB")]
			[FieldOffset(Offset = "0x40")]
			public long apCost;

			// Token: 0x040052AC RID: 21164
			[Token(Token = "0x40052AC")]
			[FieldOffset(Offset = "0x48")]
			[JsonConverter(typeof(StringEnumConverter))]
			public BuildingData.FormulaItemType formulaType;

			// Token: 0x040052AD RID: 21165
			[Token(Token = "0x40052AD")]
			[FieldOffset(Offset = "0x50")]
			public string buffType;

			// Token: 0x040052AE RID: 21166
			[Token(Token = "0x40052AE")]
			[FieldOffset(Offset = "0x58")]
			public float extraOutcomeRate;

			// Token: 0x040052AF RID: 21167
			[Token(Token = "0x40052AF")]
			[FieldOffset(Offset = "0x60")]
			public List<BuildingData.WorkshopExtraWeightItem> extraOutcomeGroup;

			// Token: 0x040052B0 RID: 21168
			[Token(Token = "0x40052B0")]
			[FieldOffset(Offset = "0x68")]
			public List<ItemBundle> costs;

			// Token: 0x040052B1 RID: 21169
			[Token(Token = "0x40052B1")]
			[FieldOffset(Offset = "0x70")]
			public List<BuildingData.WorkshopFormula.UnlockRoom> requireRooms;

			// Token: 0x040052B2 RID: 21170
			[Token(Token = "0x40052B2")]
			[FieldOffset(Offset = "0x78")]
			public List<BuildingData.WorkshopFormula.UnlockStage> requireStages;

			// Token: 0x02000F2B RID: 3883
			[Token(Token = "0x2000F2B")]
			public class UnlockRoom
			{
				// Token: 0x06006C33 RID: 27699 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C33")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UnlockRoom()
				{
				}

				// Token: 0x040052B3 RID: 21171
				[Token(Token = "0x40052B3")]
				[FieldOffset(Offset = "0x10")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.RoomType roomId;

				// Token: 0x040052B4 RID: 21172
				[Token(Token = "0x40052B4")]
				[FieldOffset(Offset = "0x14")]
				public int roomLevel;

				// Token: 0x040052B5 RID: 21173
				[Token(Token = "0x40052B5")]
				[FieldOffset(Offset = "0x18")]
				public int roomCount;
			}

			// Token: 0x02000F2C RID: 3884
			[Token(Token = "0x2000F2C")]
			public class UnlockStage
			{
				// Token: 0x06006C34 RID: 27700 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C34")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UnlockStage()
				{
				}

				// Token: 0x040052B6 RID: 21174
				[Token(Token = "0x40052B6")]
				[FieldOffset(Offset = "0x10")]
				public string stageId;

				// Token: 0x040052B7 RID: 21175
				[Token(Token = "0x40052B7")]
				[FieldOffset(Offset = "0x18")]
				public int rank;
			}
		}

		// Token: 0x02000F2D RID: 3885
		[Token(Token = "0x2000F2D")]
		public class ShopFormula
		{
			// Token: 0x06006C35 RID: 27701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C35")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ShopFormula()
			{
			}

			// Token: 0x040052B8 RID: 21176
			[Token(Token = "0x40052B8")]
			[FieldOffset(Offset = "0x10")]
			public string formulaId;

			// Token: 0x040052B9 RID: 21177
			[Token(Token = "0x40052B9")]
			[FieldOffset(Offset = "0x18")]
			public string itemId;

			// Token: 0x040052BA RID: 21178
			[Token(Token = "0x40052BA")]
			[FieldOffset(Offset = "0x20")]
			[JsonConverter(typeof(StringEnumConverter))]
			public BuildingData.FormulaItemType formulaType;

			// Token: 0x040052BB RID: 21179
			[Token(Token = "0x40052BB")]
			[FieldOffset(Offset = "0x28")]
			public long costPoint;

			// Token: 0x040052BC RID: 21180
			[Token(Token = "0x40052BC")]
			[FieldOffset(Offset = "0x30")]
			public ItemBundle gainItem;

			// Token: 0x040052BD RID: 21181
			[Token(Token = "0x40052BD")]
			[FieldOffset(Offset = "0x38")]
			public List<BuildingData.ShopFormula.UnlockRoom> requireRooms;

			// Token: 0x02000F2E RID: 3886
			[Token(Token = "0x2000F2E")]
			public class UnlockRoom
			{
				// Token: 0x06006C36 RID: 27702 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C36")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public UnlockRoom()
				{
				}

				// Token: 0x040052BE RID: 21182
				[Token(Token = "0x40052BE")]
				[FieldOffset(Offset = "0x10")]
				[JsonConverter(typeof(StringEnumConverter))]
				public BuildingData.RoomType roomId;

				// Token: 0x040052BF RID: 21183
				[Token(Token = "0x40052BF")]
				[FieldOffset(Offset = "0x14")]
				public int roomLevel;
			}
		}

		// Token: 0x02000F2F RID: 3887
		[Token(Token = "0x2000F2F")]
		public class CreditFormula
		{
			// Token: 0x06006C37 RID: 27703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C37")]
			[Address(RVA = "0x2008710", Offset = "0x2007310", VA = "0x182008710")]
			public CreditFormula()
			{
			}

			// Token: 0x040052C0 RID: 21184
			[Token(Token = "0x40052C0")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<int, BuildingData.CreditFormula.ValueModel> initiative;

			// Token: 0x040052C1 RID: 21185
			[Token(Token = "0x40052C1")]
			[FieldOffset(Offset = "0x18")]
			public ListDict<int, BuildingData.CreditFormula.ValueModel> passive;

			// Token: 0x02000F30 RID: 3888
			[Token(Token = "0x2000F30")]
			public class ValueModel
			{
				// Token: 0x06006C38 RID: 27704 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006C38")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ValueModel()
				{
				}

				// Token: 0x040052C2 RID: 21186
				[Token(Token = "0x40052C2")]
				[FieldOffset(Offset = "0x10")]
				public int basic;

				// Token: 0x040052C3 RID: 21187
				[Token(Token = "0x40052C3")]
				[FieldOffset(Offset = "0x14")]
				public int addition;
			}
		}

		// Token: 0x02000F31 RID: 3889
		[Token(Token = "0x2000F31")]
		public class SlotPrequeData
		{
			// Token: 0x06006C39 RID: 27705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C39")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SlotPrequeData()
			{
			}

			// Token: 0x040052C4 RID: 21188
			[Token(Token = "0x40052C4")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomType;

			// Token: 0x040052C5 RID: 21189
			[Token(Token = "0x40052C5")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			// Token: 0x040052C6 RID: 21190
			[Token(Token = "0x40052C6")]
			[FieldOffset(Offset = "0x20")]
			public int typeSortId;

			// Token: 0x040052C7 RID: 21191
			[Token(Token = "0x40052C7")]
			[FieldOffset(Offset = "0x24")]
			public bool isPreque;

			// Token: 0x040052C8 RID: 21192
			[Token(Token = "0x40052C8")]
			[FieldOffset(Offset = "0x28")]
			public int prequeNum;
		}

		// Token: 0x02000F32 RID: 3890
		[Token(Token = "0x2000F32")]
		public class DormitoryPrequeData
		{
			// Token: 0x06006C3A RID: 27706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C3A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DormitoryPrequeData()
			{
			}

			// Token: 0x040052C9 RID: 21193
			[Token(Token = "0x40052C9")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomType;

			// Token: 0x040052CA RID: 21194
			[Token(Token = "0x40052CA")]
			[FieldOffset(Offset = "0x18")]
			public string name;
		}

		// Token: 0x02000F33 RID: 3891
		[Token(Token = "0x2000F33")]
		public class StationManageConstData
		{
			// Token: 0x06006C3B RID: 27707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C3B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StationManageConstData()
			{
			}

			// Token: 0x040052CB RID: 21195
			[Token(Token = "0x40052CB")]
			[FieldOffset(Offset = "0x10")]
			public string cantWorkToastNoTiredChar;

			// Token: 0x040052CC RID: 21196
			[Token(Token = "0x40052CC")]
			[FieldOffset(Offset = "0x18")]
			public string cantWorkToastNoAvailQueue;

			// Token: 0x040052CD RID: 21197
			[Token(Token = "0x40052CD")]
			[FieldOffset(Offset = "0x20")]
			public string cantWorkToastNoNeed;

			// Token: 0x040052CE RID: 21198
			[Token(Token = "0x40052CE")]
			[FieldOffset(Offset = "0x28")]
			public string cantRestToastNoTiredChar;

			// Token: 0x040052CF RID: 21199
			[Token(Token = "0x40052CF")]
			[FieldOffset(Offset = "0x30")]
			public string cantRestToastNoAvailDorm;

			// Token: 0x040052D0 RID: 21200
			[Token(Token = "0x40052D0")]
			[FieldOffset(Offset = "0x38")]
			public string workBatchToast;

			// Token: 0x040052D1 RID: 21201
			[Token(Token = "0x40052D1")]
			[FieldOffset(Offset = "0x40")]
			public string restBatchToast;

			// Token: 0x040052D2 RID: 21202
			[Token(Token = "0x40052D2")]
			[FieldOffset(Offset = "0x48")]
			public string roomNoAvailQueueToast;

			// Token: 0x040052D3 RID: 21203
			[Token(Token = "0x40052D3")]
			[FieldOffset(Offset = "0x50")]
			public string cantUseNoPerson;

			// Token: 0x040052D4 RID: 21204
			[Token(Token = "0x40052D4")]
			[FieldOffset(Offset = "0x58")]
			public string cantUseWorking;

			// Token: 0x040052D5 RID: 21205
			[Token(Token = "0x40052D5")]
			[FieldOffset(Offset = "0x60")]
			public string queueCleared;

			// Token: 0x040052D6 RID: 21206
			[Token(Token = "0x40052D6")]
			[FieldOffset(Offset = "0x68")]
			public long updateTime;

			// Token: 0x040052D7 RID: 21207
			[Token(Token = "0x40052D7")]
			[FieldOffset(Offset = "0x70")]
			public long dormLockUpdateTime;
		}

		// Token: 0x02000F34 RID: 3892
		[Token(Token = "0x2000F34")]
		public class WorkshopRarityInfo
		{
			// Token: 0x06006C3C RID: 27708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C3C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WorkshopRarityInfo()
			{
			}

			// Token: 0x040052D8 RID: 21208
			[Token(Token = "0x40052D8")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x040052D9 RID: 21209
			[Token(Token = "0x40052D9")]
			[FieldOffset(Offset = "0x18")]
			public int order;

			// Token: 0x040052DA RID: 21210
			[Token(Token = "0x40052DA")]
			[FieldOffset(Offset = "0x20")]
			public List<ItemRarity> rarityList;

			// Token: 0x040052DB RID: 21211
			[Token(Token = "0x40052DB")]
			[FieldOffset(Offset = "0x28")]
			public string color;
		}

		// Token: 0x02000F35 RID: 3893
		[Token(Token = "0x2000F35")]
		public class StationManageFilterInfo
		{
			// Token: 0x06006C3D RID: 27709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C3D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StationManageFilterInfo()
			{
			}

			// Token: 0x040052DC RID: 21212
			[Token(Token = "0x40052DC")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.CharStationFilterType charStationFilterType;

			// Token: 0x040052DD RID: 21213
			[Token(Token = "0x40052DD")]
			[FieldOffset(Offset = "0x18")]
			public string name;
		}

		// Token: 0x02000F36 RID: 3894
		[Token(Token = "0x2000F36")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum CharStationFilterType
		{
			// Token: 0x040052DF RID: 21215
			[Token(Token = "0x40052DF")]
			All,
			// Token: 0x040052E0 RID: 21216
			[Token(Token = "0x40052E0")]
			DormLock,
			// Token: 0x040052E1 RID: 21217
			[Token(Token = "0x40052E1")]
			NotStationed
		}

		// Token: 0x02000F37 RID: 3895
		[Token(Token = "0x2000F37")]
		public class MusicData
		{
			// Token: 0x06006C3E RID: 27710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C3E")]
			[Address(RVA = "0x200B900", Offset = "0x200A500", VA = "0x18200B900")]
			public MusicData()
			{
			}

			// Token: 0x040052E2 RID: 21218
			[Token(Token = "0x40052E2")]
			[FieldOffset(Offset = "0x10")]
			public string defaultMusic;

			// Token: 0x040052E3 RID: 21219
			[Token(Token = "0x40052E3")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, BuildingData.MusicSingleData> musicDatas;
		}

		// Token: 0x02000F38 RID: 3896
		[Token(Token = "0x2000F38")]
		public class MusicSingleData
		{
			// Token: 0x06006C3F RID: 27711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006C3F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MusicSingleData()
			{
			}

			// Token: 0x040052E4 RID: 21220
			[Token(Token = "0x40052E4")]
			[FieldOffset(Offset = "0x10")]
			public string bgmId;

			// Token: 0x040052E5 RID: 21221
			[Token(Token = "0x40052E5")]
			[FieldOffset(Offset = "0x18")]
			public int bgmSortId;

			// Token: 0x040052E6 RID: 21222
			[Token(Token = "0x40052E6")]
			[FieldOffset(Offset = "0x20")]
			public long bgmStartTime;

			// Token: 0x040052E7 RID: 21223
			[Token(Token = "0x40052E7")]
			[FieldOffset(Offset = "0x28")]
			public string bgmName;

			// Token: 0x040052E8 RID: 21224
			[Token(Token = "0x40052E8")]
			[FieldOffset(Offset = "0x30")]
			public string gameMusicId;

			// Token: 0x040052E9 RID: 21225
			[Token(Token = "0x40052E9")]
			[FieldOffset(Offset = "0x38")]
			public string obtainApproach;

			// Token: 0x040052EA RID: 21226
			[Token(Token = "0x40052EA")]
			[FieldOffset(Offset = "0x40")]
			public string bgmDescUnlocked;

			// Token: 0x040052EB RID: 21227
			[Token(Token = "0x40052EB")]
			[FieldOffset(Offset = "0x48")]
			public string unlockType;

			// Token: 0x040052EC RID: 21228
			[Token(Token = "0x40052EC")]
			[FieldOffset(Offset = "0x50")]
			public List<string> unlockParams;
		}
	}
}
