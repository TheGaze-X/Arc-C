using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C6B RID: 3179
	[Token(Token = "0x2000C6B")]
	public class Act17sideData
	{
		// Token: 0x06006949 RID: 26953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006949")]
		[Address(RVA = "0x1FF26F0", Offset = "0x1FF12F0", VA = "0x181FF26F0")]
		public Act17sideData()
		{
		}

		// Token: 0x040040CD RID: 16589
		[Token(Token = "0x40040CD")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act17sideData.PlaceData> placeDataMap;

		// Token: 0x040040CE RID: 16590
		[Token(Token = "0x40040CE")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act17sideData.NodeInfoData> nodeInfoDataMap;

		// Token: 0x040040CF RID: 16591
		[Token(Token = "0x40040CF")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act17sideData.LandmarkNodeData> landmarkNodeDataMap;

		// Token: 0x040040D0 RID: 16592
		[Token(Token = "0x40040D0")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act17sideData.StoryNodeData> storyNodeDataMap;

		// Token: 0x040040D1 RID: 16593
		[Token(Token = "0x40040D1")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act17sideData.BattleNodeData> battleNodeDataMap;

		// Token: 0x040040D2 RID: 16594
		[Token(Token = "0x40040D2")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act17sideData.TreasureNodeData> treasureNodeDataMap;

		// Token: 0x040040D3 RID: 16595
		[Token(Token = "0x40040D3")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act17sideData.EventNodeData> eventNodeDataMap;

		// Token: 0x040040D4 RID: 16596
		[Token(Token = "0x40040D4")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, Act17sideData.TechNodeData> techNodeDataMap;

		// Token: 0x040040D5 RID: 16597
		[Token(Token = "0x40040D5")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, Act17sideData.ChoiceNodeData> choiceNodeDataMap;

		// Token: 0x040040D6 RID: 16598
		[Token(Token = "0x40040D6")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, Act17sideData.EventData> eventDataMap;

		// Token: 0x040040D7 RID: 16599
		[Token(Token = "0x40040D7")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, Act17sideData.ArchiveItemUnlockData> archiveItemUnlockDataMap;

		// Token: 0x040040D8 RID: 16600
		[Token(Token = "0x40040D8")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, Act17sideData.TechTreeData> techTreeDataMap;

		// Token: 0x040040D9 RID: 16601
		[Token(Token = "0x40040D9")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, Act17sideData.TechTreeBranchData> techTreeBranchDataMap;

		// Token: 0x040040DA RID: 16602
		[Token(Token = "0x40040DA")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, Act17sideData.MainlineChapterData> mainlineChapterDataMap;

		// Token: 0x040040DB RID: 16603
		[Token(Token = "0x40040DB")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, Act17sideData.MainlineData> mainlineDataMap;

		// Token: 0x040040DC RID: 16604
		[Token(Token = "0x40040DC")]
		[FieldOffset(Offset = "0x88")]
		public List<Act17sideData.ZoneData> zoneDataList;

		// Token: 0x040040DD RID: 16605
		[Token(Token = "0x40040DD")]
		[FieldOffset(Offset = "0x90")]
		public Act17sideData.ConstData constData;

		// Token: 0x02000C6C RID: 3180
		[Token(Token = "0x2000C6C")]
		public class PlaceData
		{
			// Token: 0x0600694A RID: 26954 RVA: 0x00030C78 File Offset: 0x0002EE78
			[Token(Token = "0x600694A")]
			[Address(RVA = "0x1FF9050", Offset = "0x1FF7C50", VA = "0x181FF9050", Slot = "4")]
			public virtual bool ShouldSerializevisibleCondType()
			{
				return default(bool);
			}

			// Token: 0x0600694B RID: 26955 RVA: 0x00030C90 File Offset: 0x0002EE90
			[Token(Token = "0x600694B")]
			[Address(RVA = "0x200BAF0", Offset = "0x200A6F0", VA = "0x18200BAF0", Slot = "5")]
			public virtual bool ShouldSerializevisibleParams()
			{
				return default(bool);
			}

			// Token: 0x0600694C RID: 26956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600694C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlaceData()
			{
			}

			// Token: 0x040040DE RID: 16606
			[Token(Token = "0x40040DE")]
			[FieldOffset(Offset = "0x10")]
			public string placeId;

			// Token: 0x040040DF RID: 16607
			[Token(Token = "0x40040DF")]
			[FieldOffset(Offset = "0x18")]
			public string placeDesc;

			// Token: 0x040040E0 RID: 16608
			[Token(Token = "0x40040E0")]
			[FieldOffset(Offset = "0x20")]
			public string lockEventId;

			// Token: 0x040040E1 RID: 16609
			[Token(Token = "0x40040E1")]
			[FieldOffset(Offset = "0x28")]
			public string zoneId;

			// Token: 0x040040E2 RID: 16610
			[Token(Token = "0x40040E2")]
			[FieldOffset(Offset = "0x30")]
			public string visibleCondType;

			// Token: 0x040040E3 RID: 16611
			[Token(Token = "0x40040E3")]
			[FieldOffset(Offset = "0x38")]
			public List<string> visibleParams;
		}

		// Token: 0x02000C6D RID: 3181
		[Token(Token = "0x2000C6D")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum NodeType
		{
			// Token: 0x040040E5 RID: 16613
			[Token(Token = "0x40040E5")]
			LANDMARK,
			// Token: 0x040040E6 RID: 16614
			[Token(Token = "0x40040E6")]
			STORY,
			// Token: 0x040040E7 RID: 16615
			[Token(Token = "0x40040E7")]
			BATTLE,
			// Token: 0x040040E8 RID: 16616
			[Token(Token = "0x40040E8")]
			ENDING,
			// Token: 0x040040E9 RID: 16617
			[Token(Token = "0x40040E9")]
			TREASURE,
			// Token: 0x040040EA RID: 16618
			[Token(Token = "0x40040EA")]
			EVENT,
			// Token: 0x040040EB RID: 16619
			[Token(Token = "0x40040EB")]
			TECH,
			// Token: 0x040040EC RID: 16620
			[Token(Token = "0x40040EC")]
			CHOICE
		}

		// Token: 0x02000C6E RID: 3182
		[Token(Token = "0x2000C6E")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TreasureType
		{
			// Token: 0x040040EE RID: 16622
			[Token(Token = "0x40040EE")]
			SMALL,
			// Token: 0x040040EF RID: 16623
			[Token(Token = "0x40040EF")]
			SPECIAL
		}

		// Token: 0x02000C6F RID: 3183
		[Token(Token = "0x2000C6F")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TrackPointType
		{
			// Token: 0x040040F1 RID: 16625
			[Token(Token = "0x40040F1")]
			NONE,
			// Token: 0x040040F2 RID: 16626
			[Token(Token = "0x40040F2")]
			MAIN,
			// Token: 0x040040F3 RID: 16627
			[Token(Token = "0x40040F3")]
			SUB
		}

		// Token: 0x02000C70 RID: 3184
		[Token(Token = "0x2000C70")]
		public class NodeInfoData
		{
			// Token: 0x0600694D RID: 26957 RVA: 0x00030CA8 File Offset: 0x0002EEA8
			[Token(Token = "0x600694D")]
			[Address(RVA = "0x1FF9030", Offset = "0x1FF7C30", VA = "0x181FF9030", Slot = "4")]
			public virtual bool ShouldSerializeunlockCondType()
			{
				return default(bool);
			}

			// Token: 0x0600694E RID: 26958 RVA: 0x00030CC0 File Offset: 0x0002EEC0
			[Token(Token = "0x600694E")]
			[Address(RVA = "0x200B990", Offset = "0x200A590", VA = "0x18200B990", Slot = "5")]
			public virtual bool ShouldSerializeunlockParams()
			{
				return default(bool);
			}

			// Token: 0x0600694F RID: 26959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600694F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NodeInfoData()
			{
			}

			// Token: 0x040040F4 RID: 16628
			[Token(Token = "0x40040F4")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x040040F5 RID: 16629
			[Token(Token = "0x40040F5")]
			[FieldOffset(Offset = "0x18")]
			public Act17sideData.NodeType nodeType;

			// Token: 0x040040F6 RID: 16630
			[Token(Token = "0x40040F6")]
			[FieldOffset(Offset = "0x1C")]
			public int sortId;

			// Token: 0x040040F7 RID: 16631
			[Token(Token = "0x40040F7")]
			[FieldOffset(Offset = "0x20")]
			public string placeId;

			// Token: 0x040040F8 RID: 16632
			[Token(Token = "0x40040F8")]
			[FieldOffset(Offset = "0x28")]
			public bool isPointPlace;

			// Token: 0x040040F9 RID: 16633
			[Token(Token = "0x40040F9")]
			[FieldOffset(Offset = "0x30")]
			public string chapterId;

			// Token: 0x040040FA RID: 16634
			[Token(Token = "0x40040FA")]
			[FieldOffset(Offset = "0x38")]
			public Act17sideData.TrackPointType trackPointType;

			// Token: 0x040040FB RID: 16635
			[Token(Token = "0x40040FB")]
			[FieldOffset(Offset = "0x40")]
			public string unlockCondType;

			// Token: 0x040040FC RID: 16636
			[Token(Token = "0x40040FC")]
			[FieldOffset(Offset = "0x48")]
			public List<string> unlockParams;
		}

		// Token: 0x02000C71 RID: 3185
		[Token(Token = "0x2000C71")]
		public class LandmarkNodeData
		{
			// Token: 0x06006950 RID: 26960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006950")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LandmarkNodeData()
			{
			}

			// Token: 0x040040FD RID: 16637
			[Token(Token = "0x40040FD")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x040040FE RID: 16638
			[Token(Token = "0x40040FE")]
			[FieldOffset(Offset = "0x18")]
			public string landmarkId;

			// Token: 0x040040FF RID: 16639
			[Token(Token = "0x40040FF")]
			[FieldOffset(Offset = "0x20")]
			public string landmarkName;

			// Token: 0x04004100 RID: 16640
			[Token(Token = "0x4004100")]
			[FieldOffset(Offset = "0x28")]
			public string landmarkPic;

			// Token: 0x04004101 RID: 16641
			[Token(Token = "0x4004101")]
			[FieldOffset(Offset = "0x30")]
			public string landmarkSpecialPic;

			// Token: 0x04004102 RID: 16642
			[Token(Token = "0x4004102")]
			[FieldOffset(Offset = "0x38")]
			public List<string> landmarkDesList;
		}

		// Token: 0x02000C72 RID: 3186
		[Token(Token = "0x2000C72")]
		public class StoryNodeData
		{
			// Token: 0x06006951 RID: 26961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006951")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StoryNodeData()
			{
			}

			// Token: 0x04004103 RID: 16643
			[Token(Token = "0x4004103")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x04004104 RID: 16644
			[Token(Token = "0x4004104")]
			[FieldOffset(Offset = "0x18")]
			public string storyId;

			// Token: 0x04004105 RID: 16645
			[Token(Token = "0x4004105")]
			[FieldOffset(Offset = "0x20")]
			public string storyKey;

			// Token: 0x04004106 RID: 16646
			[Token(Token = "0x4004106")]
			[FieldOffset(Offset = "0x28")]
			public string storyName;

			// Token: 0x04004107 RID: 16647
			[Token(Token = "0x4004107")]
			[FieldOffset(Offset = "0x30")]
			public string storyPic;

			// Token: 0x04004108 RID: 16648
			[Token(Token = "0x4004108")]
			[FieldOffset(Offset = "0x38")]
			public string confirmDes;

			// Token: 0x04004109 RID: 16649
			[Token(Token = "0x4004109")]
			[FieldOffset(Offset = "0x40")]
			public List<string> storyDesList;
		}

		// Token: 0x02000C73 RID: 3187
		[Token(Token = "0x2000C73")]
		public class BattleNodeData
		{
			// Token: 0x06006952 RID: 26962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006952")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleNodeData()
			{
			}

			// Token: 0x0400410A RID: 16650
			[Token(Token = "0x400410A")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x0400410B RID: 16651
			[Token(Token = "0x400410B")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;
		}

		// Token: 0x02000C74 RID: 3188
		[Token(Token = "0x2000C74")]
		public class TreasureNodeData
		{
			// Token: 0x06006953 RID: 26963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006953")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TreasureNodeData()
			{
			}

			// Token: 0x0400410C RID: 16652
			[Token(Token = "0x400410C")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x0400410D RID: 16653
			[Token(Token = "0x400410D")]
			[FieldOffset(Offset = "0x18")]
			public string treasureId;

			// Token: 0x0400410E RID: 16654
			[Token(Token = "0x400410E")]
			[FieldOffset(Offset = "0x20")]
			public string treasureName;

			// Token: 0x0400410F RID: 16655
			[Token(Token = "0x400410F")]
			[FieldOffset(Offset = "0x28")]
			public string treasurePic;

			// Token: 0x04004110 RID: 16656
			[Token(Token = "0x4004110")]
			[FieldOffset(Offset = "0x30")]
			public string treasureSpecialPic;

			// Token: 0x04004111 RID: 16657
			[Token(Token = "0x4004111")]
			[FieldOffset(Offset = "0x38")]
			public string endEventId;

			// Token: 0x04004112 RID: 16658
			[Token(Token = "0x4004112")]
			[FieldOffset(Offset = "0x40")]
			public string confirmDes;

			// Token: 0x04004113 RID: 16659
			[Token(Token = "0x4004113")]
			[FieldOffset(Offset = "0x48")]
			public List<string> treasureDesList;

			// Token: 0x04004114 RID: 16660
			[Token(Token = "0x4004114")]
			[FieldOffset(Offset = "0x50")]
			public List<string> missionIdList;

			// Token: 0x04004115 RID: 16661
			[Token(Token = "0x4004115")]
			[FieldOffset(Offset = "0x58")]
			public List<ItemBundle> rewardList;

			// Token: 0x04004116 RID: 16662
			[Token(Token = "0x4004116")]
			[FieldOffset(Offset = "0x60")]
			public Act17sideData.TreasureType treasureType;
		}

		// Token: 0x02000C75 RID: 3189
		[Token(Token = "0x2000C75")]
		public class EventNodeData
		{
			// Token: 0x06006954 RID: 26964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006954")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EventNodeData()
			{
			}

			// Token: 0x04004117 RID: 16663
			[Token(Token = "0x4004117")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x04004118 RID: 16664
			[Token(Token = "0x4004118")]
			[FieldOffset(Offset = "0x18")]
			public string eventId;

			// Token: 0x04004119 RID: 16665
			[Token(Token = "0x4004119")]
			[FieldOffset(Offset = "0x20")]
			public string endEventId;
		}

		// Token: 0x02000C76 RID: 3190
		[Token(Token = "0x2000C76")]
		public class TechNodeData
		{
			// Token: 0x06006955 RID: 26965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006955")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TechNodeData()
			{
			}

			// Token: 0x0400411A RID: 16666
			[Token(Token = "0x400411A")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x0400411B RID: 16667
			[Token(Token = "0x400411B")]
			[FieldOffset(Offset = "0x18")]
			public string techTreeId;

			// Token: 0x0400411C RID: 16668
			[Token(Token = "0x400411C")]
			[FieldOffset(Offset = "0x20")]
			public string techTreeName;

			// Token: 0x0400411D RID: 16669
			[Token(Token = "0x400411D")]
			[FieldOffset(Offset = "0x28")]
			public string techPic;

			// Token: 0x0400411E RID: 16670
			[Token(Token = "0x400411E")]
			[FieldOffset(Offset = "0x30")]
			public string techSpecialPic;

			// Token: 0x0400411F RID: 16671
			[Token(Token = "0x400411F")]
			[FieldOffset(Offset = "0x38")]
			public string endEventId;

			// Token: 0x04004120 RID: 16672
			[Token(Token = "0x4004120")]
			[FieldOffset(Offset = "0x40")]
			public string confirmDes;

			// Token: 0x04004121 RID: 16673
			[Token(Token = "0x4004121")]
			[FieldOffset(Offset = "0x48")]
			public List<string> techDesList;

			// Token: 0x04004122 RID: 16674
			[Token(Token = "0x4004122")]
			[FieldOffset(Offset = "0x50")]
			public List<string> missionIdList;
		}

		// Token: 0x02000C77 RID: 3191
		[Token(Token = "0x2000C77")]
		public class ChoiceNodeData
		{
			// Token: 0x06006956 RID: 26966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006956")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ChoiceNodeData()
			{
			}

			// Token: 0x04004123 RID: 16675
			[Token(Token = "0x4004123")]
			[FieldOffset(Offset = "0x10")]
			public string nodeId;

			// Token: 0x04004124 RID: 16676
			[Token(Token = "0x4004124")]
			[FieldOffset(Offset = "0x18")]
			public string choicePic;

			// Token: 0x04004125 RID: 16677
			[Token(Token = "0x4004125")]
			[FieldOffset(Offset = "0x20")]
			public bool isDisposable;

			// Token: 0x04004126 RID: 16678
			[Token(Token = "0x4004126")]
			[FieldOffset(Offset = "0x28")]
			public string choiceSpecialPic;

			// Token: 0x04004127 RID: 16679
			[Token(Token = "0x4004127")]
			[FieldOffset(Offset = "0x30")]
			public string choiceName;

			// Token: 0x04004128 RID: 16680
			[Token(Token = "0x4004128")]
			[FieldOffset(Offset = "0x38")]
			public List<string> choiceDesList;

			// Token: 0x04004129 RID: 16681
			[Token(Token = "0x4004129")]
			[FieldOffset(Offset = "0x40")]
			public string cancelDes;

			// Token: 0x0400412A RID: 16682
			[Token(Token = "0x400412A")]
			[FieldOffset(Offset = "0x48")]
			public int choiceNum;

			// Token: 0x0400412B RID: 16683
			[Token(Token = "0x400412B")]
			[FieldOffset(Offset = "0x50")]
			public List<Act17sideData.ChoiceNodeOptionData> optionList;
		}

		// Token: 0x02000C78 RID: 3192
		[Token(Token = "0x2000C78")]
		public class ChoiceNodeOptionData
		{
			// Token: 0x06006957 RID: 26967 RVA: 0x00030CD8 File Offset: 0x0002EED8
			[Token(Token = "0x6006957")]
			[Address(RVA = "0x1FF9050", Offset = "0x1FF7C50", VA = "0x181FF9050", Slot = "4")]
			public virtual bool ShouldSerializeunlockCondType()
			{
				return default(bool);
			}

			// Token: 0x06006958 RID: 26968 RVA: 0x00030CF0 File Offset: 0x0002EEF0
			[Token(Token = "0x6006958")]
			[Address(RVA = "0x2008620", Offset = "0x2007220", VA = "0x182008620", Slot = "5")]
			public virtual bool ShouldSerializeunlockParams()
			{
				return default(bool);
			}

			// Token: 0x06006959 RID: 26969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006959")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ChoiceNodeOptionData()
			{
			}

			// Token: 0x0400412C RID: 16684
			[Token(Token = "0x400412C")]
			[FieldOffset(Offset = "0x10")]
			public bool canRepeat;

			// Token: 0x0400412D RID: 16685
			[Token(Token = "0x400412D")]
			[FieldOffset(Offset = "0x18")]
			public string eventId;

			// Token: 0x0400412E RID: 16686
			[Token(Token = "0x400412E")]
			[FieldOffset(Offset = "0x20")]
			public string des;

			// Token: 0x0400412F RID: 16687
			[Token(Token = "0x400412F")]
			[FieldOffset(Offset = "0x28")]
			public string unlockDes;

			// Token: 0x04004130 RID: 16688
			[Token(Token = "0x4004130")]
			[FieldOffset(Offset = "0x30")]
			public string unlockCondType;

			// Token: 0x04004131 RID: 16689
			[Token(Token = "0x4004131")]
			[FieldOffset(Offset = "0x38")]
			public List<string> unlockParams;
		}

		// Token: 0x02000C79 RID: 3193
		[Token(Token = "0x2000C79")]
		public class EventData
		{
			// Token: 0x0600695A RID: 26970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600695A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EventData()
			{
			}

			// Token: 0x04004132 RID: 16690
			[Token(Token = "0x4004132")]
			[FieldOffset(Offset = "0x10")]
			public string eventId;

			// Token: 0x04004133 RID: 16691
			[Token(Token = "0x4004133")]
			[FieldOffset(Offset = "0x18")]
			public string eventPic;

			// Token: 0x04004134 RID: 16692
			[Token(Token = "0x4004134")]
			[FieldOffset(Offset = "0x20")]
			public string eventSpecialPic;

			// Token: 0x04004135 RID: 16693
			[Token(Token = "0x4004135")]
			[FieldOffset(Offset = "0x28")]
			public string eventTitle;

			// Token: 0x04004136 RID: 16694
			[Token(Token = "0x4004136")]
			[FieldOffset(Offset = "0x30")]
			public List<string> eventDesList;
		}

		// Token: 0x02000C7A RID: 3194
		[Token(Token = "0x2000C7A")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ArchiveItemUnlockCondition
		{
			// Token: 0x04004138 RID: 16696
			[Token(Token = "0x4004138")]
			NONE,
			// Token: 0x04004139 RID: 16697
			[Token(Token = "0x4004139")]
			STAGE,
			// Token: 0x0400413A RID: 16698
			[Token(Token = "0x400413A")]
			NODE
		}

		// Token: 0x02000C7B RID: 3195
		[Token(Token = "0x2000C7B")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ArchiveItemStageUnlockParam
		{
			// Token: 0x0400413C RID: 16700
			[Token(Token = "0x400413C")]
			NONE,
			// Token: 0x0400413D RID: 16701
			[Token(Token = "0x400413D")]
			PLAYED,
			// Token: 0x0400413E RID: 16702
			[Token(Token = "0x400413E")]
			PASS,
			// Token: 0x0400413F RID: 16703
			[Token(Token = "0x400413F")]
			COMPLETE
		}

		// Token: 0x02000C7C RID: 3196
		[Token(Token = "0x2000C7C")]
		public class ArchiveItemUnlockData
		{
			// Token: 0x0600695B RID: 26971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600695B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ArchiveItemUnlockData()
			{
			}

			// Token: 0x04004140 RID: 16704
			[Token(Token = "0x4004140")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x04004141 RID: 16705
			[Token(Token = "0x4004141")]
			[FieldOffset(Offset = "0x18")]
			public ActArchiveType itemType;

			// Token: 0x04004142 RID: 16706
			[Token(Token = "0x4004142")]
			[FieldOffset(Offset = "0x1C")]
			public Act17sideData.ArchiveItemUnlockCondition unlockCondition;

			// Token: 0x04004143 RID: 16707
			[Token(Token = "0x4004143")]
			[FieldOffset(Offset = "0x20")]
			public string nodeId;

			// Token: 0x04004144 RID: 16708
			[Token(Token = "0x4004144")]
			[FieldOffset(Offset = "0x28")]
			public Act17sideData.ArchiveItemStageUnlockParam stageParam;

			// Token: 0x04004145 RID: 16709
			[Token(Token = "0x4004145")]
			[FieldOffset(Offset = "0x30")]
			public string chapterId;
		}

		// Token: 0x02000C7D RID: 3197
		[Token(Token = "0x2000C7D")]
		public class TechTreeData
		{
			// Token: 0x0600695C RID: 26972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600695C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TechTreeData()
			{
			}

			// Token: 0x04004146 RID: 16710
			[Token(Token = "0x4004146")]
			[FieldOffset(Offset = "0x10")]
			public string techTreeId;

			// Token: 0x04004147 RID: 16711
			[Token(Token = "0x4004147")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04004148 RID: 16712
			[Token(Token = "0x4004148")]
			[FieldOffset(Offset = "0x20")]
			public string techTreeName;

			// Token: 0x04004149 RID: 16713
			[Token(Token = "0x4004149")]
			[FieldOffset(Offset = "0x28")]
			public string defaultBranchId;

			// Token: 0x0400414A RID: 16714
			[Token(Token = "0x400414A")]
			[FieldOffset(Offset = "0x30")]
			public string lockDes;
		}

		// Token: 0x02000C7E RID: 3198
		[Token(Token = "0x2000C7E")]
		public class TechTreeBranchData
		{
			// Token: 0x0600695D RID: 26973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600695D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TechTreeBranchData()
			{
			}

			// Token: 0x0400414B RID: 16715
			[Token(Token = "0x400414B")]
			[FieldOffset(Offset = "0x10")]
			public string techTreeBranchId;

			// Token: 0x0400414C RID: 16716
			[Token(Token = "0x400414C")]
			[FieldOffset(Offset = "0x18")]
			public string techTreeId;

			// Token: 0x0400414D RID: 16717
			[Token(Token = "0x400414D")]
			[FieldOffset(Offset = "0x20")]
			public string techTreeBranchName;

			// Token: 0x0400414E RID: 16718
			[Token(Token = "0x400414E")]
			[FieldOffset(Offset = "0x28")]
			public string techTreeBranchIcon;

			// Token: 0x0400414F RID: 16719
			[Token(Token = "0x400414F")]
			[FieldOffset(Offset = "0x30")]
			public string techTreeBranchDesc;

			// Token: 0x04004150 RID: 16720
			[Token(Token = "0x4004150")]
			[FieldOffset(Offset = "0x38")]
			public RuneTable.PackedRuneData runeData;
		}

		// Token: 0x02000C7F RID: 3199
		[Token(Token = "0x2000C7F")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ChapterIconType
		{
			// Token: 0x04004152 RID: 16722
			[Token(Token = "0x4004152")]
			NORMAL,
			// Token: 0x04004153 RID: 16723
			[Token(Token = "0x4004153")]
			EX,
			// Token: 0x04004154 RID: 16724
			[Token(Token = "0x4004154")]
			HARD
		}

		// Token: 0x02000C80 RID: 3200
		[Token(Token = "0x2000C80")]
		public class MainlineChapterData
		{
			// Token: 0x0600695E RID: 26974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600695E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MainlineChapterData()
			{
			}

			// Token: 0x04004155 RID: 16725
			[Token(Token = "0x4004155")]
			[FieldOffset(Offset = "0x10")]
			public string chapterId;

			// Token: 0x04004156 RID: 16726
			[Token(Token = "0x4004156")]
			[FieldOffset(Offset = "0x18")]
			public string chapterDes;

			// Token: 0x04004157 RID: 16727
			[Token(Token = "0x4004157")]
			[FieldOffset(Offset = "0x20")]
			public Act17sideData.ChapterIconType chapterIcon;

			// Token: 0x04004158 RID: 16728
			[Token(Token = "0x4004158")]
			[FieldOffset(Offset = "0x28")]
			public string unlockDes;

			// Token: 0x04004159 RID: 16729
			[Token(Token = "0x4004159")]
			[FieldOffset(Offset = "0x30")]
			public string id;
		}

		// Token: 0x02000C81 RID: 3201
		[Token(Token = "0x2000C81")]
		public class MainlineData
		{
			// Token: 0x0600695F RID: 26975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600695F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MainlineData()
			{
			}

			// Token: 0x0400415A RID: 16730
			[Token(Token = "0x400415A")]
			[FieldOffset(Offset = "0x10")]
			public string mainlineId;

			// Token: 0x0400415B RID: 16731
			[Token(Token = "0x400415B")]
			[FieldOffset(Offset = "0x18")]
			public string nodeId;

			// Token: 0x0400415C RID: 16732
			[Token(Token = "0x400415C")]
			[FieldOffset(Offset = "0x20")]
			public int sortId;

			// Token: 0x0400415D RID: 16733
			[Token(Token = "0x400415D")]
			[FieldOffset(Offset = "0x28")]
			public string missionSort;

			// Token: 0x0400415E RID: 16734
			[Token(Token = "0x400415E")]
			[FieldOffset(Offset = "0x30")]
			public string zoneId;

			// Token: 0x0400415F RID: 16735
			[Token(Token = "0x400415F")]
			[FieldOffset(Offset = "0x38")]
			public string mainlineDes;

			// Token: 0x04004160 RID: 16736
			[Token(Token = "0x4004160")]
			[FieldOffset(Offset = "0x40")]
			public string focusNodeId;
		}

		// Token: 0x02000C82 RID: 3202
		[Token(Token = "0x2000C82")]
		public class ZoneData
		{
			// Token: 0x06006960 RID: 26976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006960")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ZoneData()
			{
			}

			// Token: 0x04004161 RID: 16737
			[Token(Token = "0x4004161")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004162 RID: 16738
			[Token(Token = "0x4004162")]
			[FieldOffset(Offset = "0x18")]
			public string unlockPlaceId;

			// Token: 0x04004163 RID: 16739
			[Token(Token = "0x4004163")]
			[FieldOffset(Offset = "0x20")]
			public string unlockText;
		}

		// Token: 0x02000C83 RID: 3203
		[Token(Token = "0x2000C83")]
		public class ConstData
		{
			// Token: 0x06006961 RID: 26977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006961")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConstData()
			{
			}

			// Token: 0x04004164 RID: 16740
			[Token(Token = "0x4004164")]
			[FieldOffset(Offset = "0x10")]
			public string techTreeUnlockEventId;
		}
	}
}
