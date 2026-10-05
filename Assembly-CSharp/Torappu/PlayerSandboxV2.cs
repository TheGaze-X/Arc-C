using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000B9C RID: 2972
	[Token(Token = "0x2000B9C")]
	public class PlayerSandboxV2
	{
		// Token: 0x06006838 RID: 26680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006838")]
		[Address(RVA = "0x1EFD4C0", Offset = "0x1EFC0C0", VA = "0x181EFD4C0")]
		public PlayerSandboxV2()
		{
		}

		// Token: 0x04003D66 RID: 15718
		[Token(Token = "0x4003D66")]
		[FieldOffset(Offset = "0x10")]
		public PlayerSandboxV2.Status status;

		// Token: 0x04003D67 RID: 15719
		[Token(Token = "0x4003D67")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "base")]
		public PlayerSandboxV2.BaseInfo baseInfo;

		// Token: 0x04003D68 RID: 15720
		[Token(Token = "0x4003D68")]
		[FieldOffset(Offset = "0x20")]
		public PlayerSandboxV2.Dungeon main;

		// Token: 0x04003D69 RID: 15721
		[Token(Token = "0x4003D69")]
		[FieldOffset(Offset = "0x28")]
		public PlayerSandboxV2.Dungeon rift;

		// Token: 0x04003D6A RID: 15722
		[Token(Token = "0x4003D6A")]
		[FieldOffset(Offset = "0x30")]
		public PlayerSandboxV2.QuestGroup quest;

		// Token: 0x04003D6B RID: 15723
		[Token(Token = "0x4003D6B")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty(PropertyName = "mission")]
		public PlayerSandboxV2.Expedition expedition;

		// Token: 0x04003D6C RID: 15724
		[Token(Token = "0x4003D6C")]
		[FieldOffset(Offset = "0x40")]
		public PlayerSandboxV2.Troop troop;

		// Token: 0x04003D6D RID: 15725
		[Token(Token = "0x4003D6D")]
		[FieldOffset(Offset = "0x48")]
		public PlayerSandboxV2.Cook cook;

		// Token: 0x04003D6E RID: 15726
		[Token(Token = "0x4003D6E")]
		[FieldOffset(Offset = "0x50")]
		public PlayerSandboxV2.Build build;

		// Token: 0x04003D6F RID: 15727
		[Token(Token = "0x4003D6F")]
		[FieldOffset(Offset = "0x58")]
		public PlayerSandboxV2.Bag bag;

		// Token: 0x04003D70 RID: 15728
		[Token(Token = "0x4003D70")]
		[FieldOffset(Offset = "0x60")]
		public PlayerSandboxV2.Bank bank;

		// Token: 0x04003D71 RID: 15729
		[Token(Token = "0x4003D71")]
		[FieldOffset(Offset = "0x68")]
		public PlayerSandboxV2.Shop shop;

		// Token: 0x04003D72 RID: 15730
		[Token(Token = "0x4003D72")]
		[FieldOffset(Offset = "0x70")]
		public PlayerSandboxV2.RiftInfo riftInfo;

		// Token: 0x04003D73 RID: 15731
		[Token(Token = "0x4003D73")]
		[FieldOffset(Offset = "0x78")]
		public PlayerSandboxV2.Supply supply;

		// Token: 0x04003D74 RID: 15732
		[Token(Token = "0x4003D74")]
		[FieldOffset(Offset = "0x80")]
		public PlayerSandboxV2.Tech tech;

		// Token: 0x04003D75 RID: 15733
		[Token(Token = "0x4003D75")]
		[FieldOffset(Offset = "0x88")]
		public PlayerSandboxV2.Month month;

		// Token: 0x04003D76 RID: 15734
		[Token(Token = "0x4003D76")]
		[FieldOffset(Offset = "0x90")]
		[JsonProperty(PropertyName = "archive")]
		public PlayerSandboxV2.Archive record;

		// Token: 0x04003D77 RID: 15735
		[Token(Token = "0x4003D77")]
		[FieldOffset(Offset = "0x98")]
		[JsonProperty(PropertyName = "collect")]
		public PlayerSandboxV2.Collect archive;

		// Token: 0x04003D78 RID: 15736
		[Token(Token = "0x4003D78")]
		[FieldOffset(Offset = "0xA0")]
		public PlayerSandboxV2.Buff buff;

		// Token: 0x04003D79 RID: 15737
		[Token(Token = "0x4003D79")]
		[FieldOffset(Offset = "0xA8")]
		public PlayerSandboxV2.Racing racing;

		// Token: 0x04003D7A RID: 15738
		[Token(Token = "0x4003D7A")]
		[FieldOffset(Offset = "0xB0")]
		public PlayerSandboxV2.Challenge challenge;

		// Token: 0x02000B9D RID: 2973
		[Token(Token = "0x2000B9D")]
		public enum GameState
		{
			// Token: 0x04003D7C RID: 15740
			[Token(Token = "0x4003D7C")]
			INACTIVE,
			// Token: 0x04003D7D RID: 15741
			[Token(Token = "0x4003D7D")]
			ACTIVE,
			// Token: 0x04003D7E RID: 15742
			[Token(Token = "0x4003D7E")]
			SETTLE_DATE,
			// Token: 0x04003D7F RID: 15743
			[Token(Token = "0x4003D7F")]
			READING_ARCHIVE
		}

		// Token: 0x02000B9E RID: 2974
		[Token(Token = "0x2000B9E")]
		public enum NodeState
		{
			// Token: 0x04003D81 RID: 15745
			[Token(Token = "0x4003D81")]
			LOCKED,
			// Token: 0x04003D82 RID: 15746
			[Token(Token = "0x4003D82")]
			UNLOCKED,
			// Token: 0x04003D83 RID: 15747
			[Token(Token = "0x4003D83")]
			COMPLETED
		}

		// Token: 0x02000B9F RID: 2975
		[Token(Token = "0x2000B9F")]
		public enum StageState
		{
			// Token: 0x04003D85 RID: 15749
			[Token(Token = "0x4003D85")]
			UNEXPLORED,
			// Token: 0x04003D86 RID: 15750
			[Token(Token = "0x4003D86")]
			EXPLORED,
			// Token: 0x04003D87 RID: 15751
			[Token(Token = "0x4003D87")]
			COMPLETED
		}

		// Token: 0x02000BA0 RID: 2976
		[Token(Token = "0x2000BA0")]
		public class Status
		{
			// Token: 0x06006839 RID: 26681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006839")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Status()
			{
			}

			// Token: 0x04003D88 RID: 15752
			[Token(Token = "0x4003D88")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.GameState state;

			// Token: 0x04003D89 RID: 15753
			[Token(Token = "0x4003D89")]
			[FieldOffset(Offset = "0x18")]
			public long ts;

			// Token: 0x04003D8A RID: 15754
			[Token(Token = "0x4003D8A")]
			[FieldOffset(Offset = "0x20")]
			public bool isRift;

			// Token: 0x04003D8B RID: 15755
			[Token(Token = "0x4003D8B")]
			[FieldOffset(Offset = "0x21")]
			public bool isGuide;

			// Token: 0x04003D8C RID: 15756
			[Token(Token = "0x4003D8C")]
			[FieldOffset(Offset = "0x22")]
			public bool isChallenge;

			// Token: 0x04003D8D RID: 15757
			[Token(Token = "0x4003D8D")]
			[FieldOffset(Offset = "0x24")]
			public int mode;
		}

		// Token: 0x02000BA1 RID: 2977
		[Token(Token = "0x2000BA1")]
		public class BaseInfo
		{
			// Token: 0x0600683A RID: 26682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600683A")]
			[Address(RVA = "0x1EE68F0", Offset = "0x1EE54F0", VA = "0x181EE68F0")]
			public BaseInfo()
			{
			}

			// Token: 0x04003D8E RID: 15758
			[Token(Token = "0x4003D8E")]
			[FieldOffset(Offset = "0x10")]
			public int baseLv;

			// Token: 0x04003D8F RID: 15759
			[Token(Token = "0x4003D8F")]
			[FieldOffset(Offset = "0x14")]
			public bool portableUnlock;

			// Token: 0x04003D90 RID: 15760
			[Token(Token = "0x4003D90")]
			[FieldOffset(Offset = "0x15")]
			public bool outpostUnlock;

			// Token: 0x04003D91 RID: 15761
			[Token(Token = "0x4003D91")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> trapLimit;

			// Token: 0x04003D92 RID: 15762
			[Token(Token = "0x4003D92")]
			[FieldOffset(Offset = "0x20")]
			public List<List<int>> upgradeProgress;

			// Token: 0x04003D93 RID: 15763
			[Token(Token = "0x4003D93")]
			[FieldOffset(Offset = "0x28")]
			public int repairDiscount;

			// Token: 0x04003D94 RID: 15764
			[Token(Token = "0x4003D94")]
			[FieldOffset(Offset = "0x30")]
			public List<string> bossKill;
		}

		// Token: 0x02000BA2 RID: 2978
		[Token(Token = "0x2000BA2")]
		public class Dungeon
		{
			// Token: 0x0600683B RID: 26683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600683B")]
			[Address(RVA = "0x1EE9CE0", Offset = "0x1EE88E0", VA = "0x181EE9CE0")]
			public Dungeon()
			{
			}

			// Token: 0x04003D95 RID: 15765
			[Token(Token = "0x4003D95")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Dungeon.Game game;

			// Token: 0x04003D96 RID: 15766
			[Token(Token = "0x4003D96")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Dungeon.Map map;

			// Token: 0x04003D97 RID: 15767
			[Token(Token = "0x4003D97")]
			[FieldOffset(Offset = "0x20")]
			public PlayerSandboxV2.Dungeon.Stage stage;

			// Token: 0x04003D98 RID: 15768
			[Token(Token = "0x4003D98")]
			[FieldOffset(Offset = "0x28")]
			public PlayerSandboxV2.Dungeon.Enemy enemy;

			// Token: 0x04003D99 RID: 15769
			[Token(Token = "0x4003D99")]
			[FieldOffset(Offset = "0x30")]
			public PlayerSandboxV2.Dungeon.NpcGroup npc;

			// Token: 0x04003D9A RID: 15770
			[Token(Token = "0x4003D9A")]
			[FieldOffset(Offset = "0x38")]
			[JsonProperty(PropertyName = "event")]
			public PlayerSandboxV2.Dungeon.EventGroup events;

			// Token: 0x04003D9B RID: 15771
			[Token(Token = "0x4003D9B")]
			[FieldOffset(Offset = "0x40")]
			public PlayerSandboxV2.Dungeon.Report report;

			// Token: 0x02000BA3 RID: 2979
			[Token(Token = "0x2000BA3")]
			public class Game
			{
				// Token: 0x0600683C RID: 26684 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600683C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Game()
				{
				}

				// Token: 0x04003D9C RID: 15772
				[Token(Token = "0x4003D9C")]
				[FieldOffset(Offset = "0x10")]
				public string mapId;

				// Token: 0x04003D9D RID: 15773
				[Token(Token = "0x4003D9D")]
				[FieldOffset(Offset = "0x18")]
				public int day;

				// Token: 0x04003D9E RID: 15774
				[Token(Token = "0x4003D9E")]
				[FieldOffset(Offset = "0x1C")]
				public int maxDay;

				// Token: 0x04003D9F RID: 15775
				[Token(Token = "0x4003D9F")]
				[FieldOffset(Offset = "0x20")]
				public int ap;

				// Token: 0x04003DA0 RID: 15776
				[Token(Token = "0x4003DA0")]
				[FieldOffset(Offset = "0x24")]
				public int maxAp;
			}

			// Token: 0x02000BA4 RID: 2980
			[Token(Token = "0x2000BA4")]
			public class Zone
			{
				// Token: 0x0600683D RID: 26685 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600683D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Zone()
				{
				}

				// Token: 0x04003DA1 RID: 15777
				[Token(Token = "0x4003DA1")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty(PropertyName = "state")]
				public bool unlocked;

				// Token: 0x04003DA2 RID: 15778
				[Token(Token = "0x4003DA2")]
				[FieldOffset(Offset = "0x14")]
				public SandboxV2WeatherType weather;
			}

			// Token: 0x02000BA5 RID: 2981
			[Token(Token = "0x2000BA5")]
			public class NodeRelate
			{
				// Token: 0x0600683E RID: 26686 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600683E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public NodeRelate()
				{
				}

				// Token: 0x04003DA3 RID: 15779
				[Token(Token = "0x4003DA3")]
				[FieldOffset(Offset = "0x10")]
				public List<float> pos;

				// Token: 0x04003DA4 RID: 15780
				[Token(Token = "0x4003DA4")]
				[FieldOffset(Offset = "0x18")]
				public List<string> adj;

				// Token: 0x04003DA5 RID: 15781
				[Token(Token = "0x4003DA5")]
				[FieldOffset(Offset = "0x20")]
				public int depth;
			}

			// Token: 0x02000BA6 RID: 2982
			[Token(Token = "0x2000BA6")]
			public class Node
			{
				// Token: 0x0600683F RID: 26687 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600683F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Node()
				{
				}

				// Token: 0x04003DA6 RID: 15782
				[Token(Token = "0x4003DA6")]
				[FieldOffset(Offset = "0x10")]
				public string zone;

				// Token: 0x04003DA7 RID: 15783
				[Token(Token = "0x4003DA7")]
				[FieldOffset(Offset = "0x18")]
				public SandboxV2NodeType type;

				// Token: 0x04003DA8 RID: 15784
				[Token(Token = "0x4003DA8")]
				[FieldOffset(Offset = "0x1C")]
				public PlayerSandboxV2.NodeState state;

				// Token: 0x04003DA9 RID: 15785
				[Token(Token = "0x4003DA9")]
				[FieldOffset(Offset = "0x20")]
				public PlayerSandboxV2.Dungeon.NodeRelate relate;

				// Token: 0x04003DAA RID: 15786
				[Token(Token = "0x4003DAA")]
				[FieldOffset(Offset = "0x28")]
				public string stageId;

				// Token: 0x04003DAB RID: 15787
				[Token(Token = "0x4003DAB")]
				[FieldOffset(Offset = "0x30")]
				public int weatherLv;
			}

			// Token: 0x02000BA7 RID: 2983
			[Token(Token = "0x2000BA7")]
			public class Season
			{
				// Token: 0x06006840 RID: 26688 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006840")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Season()
				{
				}

				// Token: 0x04003DAC RID: 15788
				[Token(Token = "0x4003DAC")]
				[FieldOffset(Offset = "0x10")]
				public SandboxV2SeasonType type;

				// Token: 0x04003DAD RID: 15789
				[Token(Token = "0x4003DAD")]
				[FieldOffset(Offset = "0x14")]
				public int remain;

				// Token: 0x04003DAE RID: 15790
				[Token(Token = "0x4003DAE")]
				[FieldOffset(Offset = "0x18")]
				public int total;
			}

			// Token: 0x02000BA8 RID: 2984
			[Token(Token = "0x2000BA8")]
			public class Map
			{
				// Token: 0x06006841 RID: 26689 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006841")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Map()
				{
				}

				// Token: 0x04003DAF RID: 15791
				[Token(Token = "0x4003DAF")]
				[FieldOffset(Offset = "0x10")]
				public PlayerSandboxV2.Dungeon.Season season;

				// Token: 0x04003DB0 RID: 15792
				[Token(Token = "0x4003DB0")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerSandboxV2.Dungeon.Zone> zone;

				// Token: 0x04003DB1 RID: 15793
				[Token(Token = "0x4003DB1")]
				[FieldOffset(Offset = "0x20")]
				public Dictionary<string, PlayerSandboxV2.Dungeon.Node> node;
			}

			// Token: 0x02000BA9 RID: 2985
			[Token(Token = "0x2000BA9")]
			public class Stage
			{
				// Token: 0x06006842 RID: 26690 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006842")]
				[Address(RVA = "0x1F022B0", Offset = "0x1F00EB0", VA = "0x181F022B0")]
				public Stage()
				{
				}

				// Token: 0x04003DB2 RID: 15794
				[Token(Token = "0x4003DB2")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerSandboxV2.Dungeon.NodeStage> node;
			}

			// Token: 0x02000BAA RID: 2986
			[Token(Token = "0x2000BAA")]
			public class Report
			{
				// Token: 0x06006843 RID: 26691 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006843")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Report()
				{
				}

				// Token: 0x04003DB3 RID: 15795
				[Token(Token = "0x4003DB3")]
				[FieldOffset(Offset = "0x10")]
				public PlayerSandboxV2.Dungeon.ReportSettle settle;

				// Token: 0x04003DB4 RID: 15796
				[Token(Token = "0x4003DB4")]
				[FieldOffset(Offset = "0x18")]
				public PlayerSandboxV2.Dungeon.ReportDaily daily;
			}

			// Token: 0x02000BAB RID: 2987
			[Token(Token = "0x2000BAB")]
			public class ReportDetail
			{
				// Token: 0x06006844 RID: 26692 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006844")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ReportDetail()
				{
				}

				// Token: 0x04003DB5 RID: 15797
				[Token(Token = "0x4003DB5")]
				[FieldOffset(Offset = "0x10")]
				public int dayScore;

				// Token: 0x04003DB6 RID: 15798
				[Token(Token = "0x4003DB6")]
				[FieldOffset(Offset = "0x14")]
				public bool hasRift;

				// Token: 0x04003DB7 RID: 15799
				[Token(Token = "0x4003DB7")]
				[FieldOffset(Offset = "0x18")]
				public int riftScore;

				// Token: 0x04003DB8 RID: 15800
				[Token(Token = "0x4003DB8")]
				[FieldOffset(Offset = "0x1C")]
				public int apScore;

				// Token: 0x04003DB9 RID: 15801
				[Token(Token = "0x4003DB9")]
				[FieldOffset(Offset = "0x20")]
				public int exploreScore;

				// Token: 0x04003DBA RID: 15802
				[Token(Token = "0x4003DBA")]
				[FieldOffset(Offset = "0x28")]
				[JsonProperty("enemyRush")]
				public Dictionary<int, int[]> enemyRushInfo;

				// Token: 0x04003DBB RID: 15803
				[Token(Token = "0x4003DBB")]
				[FieldOffset(Offset = "0x30")]
				[JsonProperty("home")]
				public Dictionary<string, int> homeInfo;

				// Token: 0x04003DBC RID: 15804
				[Token(Token = "0x4003DBC")]
				[FieldOffset(Offset = "0x38")]
				public PlayerSandboxV2.Dungeon.ReportMake make;
			}

			// Token: 0x02000BAC RID: 2988
			[Token(Token = "0x2000BAC")]
			public class ReportMake
			{
				// Token: 0x06006845 RID: 26693 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006845")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ReportMake()
				{
				}

				// Token: 0x04003DBD RID: 15805
				[Token(Token = "0x4003DBD")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty("tactical")]
				public int tacticalScore;

				// Token: 0x04003DBE RID: 15806
				[Token(Token = "0x4003DBE")]
				[FieldOffset(Offset = "0x14")]
				[JsonProperty("food")]
				public int foodScore;
			}

			// Token: 0x02000BAD RID: 2989
			[Token(Token = "0x2000BAD")]
			public class ReportDaily
			{
				// Token: 0x06006846 RID: 26694 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006846")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ReportDaily()
				{
				}

				// Token: 0x04003DBF RID: 15807
				[Token(Token = "0x4003DBF")]
				[FieldOffset(Offset = "0x10")]
				public bool isLoad;

				// Token: 0x04003DC0 RID: 15808
				[Token(Token = "0x4003DC0")]
				[FieldOffset(Offset = "0x14")]
				public int fromDay;

				// Token: 0x04003DC1 RID: 15809
				[Token(Token = "0x4003DC1")]
				[FieldOffset(Offset = "0x18")]
				public bool seasonChange;

				// Token: 0x04003DC2 RID: 15810
				[Token(Token = "0x4003DC2")]
				[FieldOffset(Offset = "0x20")]
				public PlayerSandboxV2.Dungeon.ReportMission mission;

				// Token: 0x04003DC3 RID: 15811
				[Token(Token = "0x4003DC3")]
				[FieldOffset(Offset = "0x28")]
				public List<PlayerSandboxV2.Dungeon.ReportGainItem> baseProduct;
			}

			// Token: 0x02000BAE RID: 2990
			[Token(Token = "0x2000BAE")]
			public class ReportMission
			{
				// Token: 0x06006847 RID: 26695 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006847")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ReportMission()
				{
				}

				// Token: 0x04003DC4 RID: 15812
				[Token(Token = "0x4003DC4")]
				[FieldOffset(Offset = "0x10")]
				public List<List<int>> squad;

				// Token: 0x04003DC5 RID: 15813
				[Token(Token = "0x4003DC5")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerSandboxV2.Dungeon.ReportGainItem> reward;
			}

			// Token: 0x02000BAF RID: 2991
			[Token(Token = "0x2000BAF")]
			public class ReportGainItem
			{
				// Token: 0x06006848 RID: 26696 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006848")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ReportGainItem()
				{
				}

				// Token: 0x04003DC6 RID: 15814
				[Token(Token = "0x4003DC6")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty("id")]
				public string itemId;

				// Token: 0x04003DC7 RID: 15815
				[Token(Token = "0x4003DC7")]
				[FieldOffset(Offset = "0x18")]
				public int count;
			}

			// Token: 0x02000BB0 RID: 2992
			[Token(Token = "0x2000BB0")]
			public class ReportSettle
			{
				// Token: 0x06006849 RID: 26697 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006849")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ReportSettle()
				{
				}

				// Token: 0x04003DC8 RID: 15816
				[Token(Token = "0x4003DC8")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty("score")]
				public int scoreTotal;

				// Token: 0x04003DC9 RID: 15817
				[Token(Token = "0x4003DC9")]
				[FieldOffset(Offset = "0x18")]
				public string scoreRatio;

				// Token: 0x04003DCA RID: 15818
				[Token(Token = "0x4003DCA")]
				[FieldOffset(Offset = "0x20")]
				public int techToken;

				// Token: 0x04003DCB RID: 15819
				[Token(Token = "0x4003DCB")]
				[FieldOffset(Offset = "0x24")]
				public int techCent;

				// Token: 0x04003DCC RID: 15820
				[Token(Token = "0x4003DCC")]
				[FieldOffset(Offset = "0x28")]
				public int shopCoin;

				// Token: 0x04003DCD RID: 15821
				[Token(Token = "0x4003DCD")]
				[FieldOffset(Offset = "0x2C")]
				public bool shopCoinMax;

				// Token: 0x04003DCE RID: 15822
				[Token(Token = "0x4003DCE")]
				[FieldOffset(Offset = "0x30")]
				public PlayerSandboxV2.Dungeon.ReportDetail detail;
			}

			// Token: 0x02000BB1 RID: 2993
			[Token(Token = "0x2000BB1")]
			public class EntityStatus
			{
				// Token: 0x0600684A RID: 26698 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600684A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public EntityStatus()
				{
				}

				// Token: 0x04003DCF RID: 15823
				[Token(Token = "0x4003DCF")]
				[FieldOffset(Offset = "0x10")]
				public string key;

				// Token: 0x04003DD0 RID: 15824
				[Token(Token = "0x4003DD0")]
				[FieldOffset(Offset = "0x18")]
				public List<int> pos;

				// Token: 0x04003DD1 RID: 15825
				[Token(Token = "0x4003DD1")]
				[FieldOffset(Offset = "0x20")]
				public bool isDead;

				// Token: 0x04003DD2 RID: 15826
				[Token(Token = "0x4003DD2")]
				[FieldOffset(Offset = "0x24")]
				public int hpRatio;
			}

			// Token: 0x02000BB2 RID: 2994
			[Token(Token = "0x2000BB2")]
			public class BaseInfo : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x0600684B RID: 26699 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600684B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public BaseInfo()
				{
				}
			}

			// Token: 0x02000BB3 RID: 2995
			[Token(Token = "0x2000BB3")]
			public class Portable : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x0600684C RID: 26700 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600684C")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Portable()
				{
				}
			}

			// Token: 0x02000BB4 RID: 2996
			[Token(Token = "0x2000BB4")]
			public class Nest : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x0600684D RID: 26701 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600684D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Nest()
				{
				}
			}

			// Token: 0x02000BB5 RID: 2997
			[Token(Token = "0x2000BB5")]
			public class Cave : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x0600684E RID: 26702 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600684E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Cave()
				{
				}

				// Token: 0x04003DD3 RID: 15827
				[Token(Token = "0x4003DD3")]
				[FieldOffset(Offset = "0x28")]
				public int extraParam;
			}

			// Token: 0x02000BB6 RID: 2998
			[Token(Token = "0x2000BB6")]
			public class Gate : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x0600684F RID: 26703 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600684F")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Gate()
				{
				}
			}

			// Token: 0x02000BB7 RID: 2999
			[Token(Token = "0x2000BB7")]
			public class Mine : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x06006850 RID: 26704 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006850")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Mine()
				{
				}
			}

			// Token: 0x02000BB8 RID: 3000
			[Token(Token = "0x2000BB8")]
			public class Selection : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x06006851 RID: 26705 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006851")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Selection()
				{
				}

				// Token: 0x04003DD4 RID: 15828
				[Token(Token = "0x4003DD4")]
				[FieldOffset(Offset = "0x28")]
				public List<int> count;
			}

			// Token: 0x02000BB9 RID: 3001
			[Token(Token = "0x2000BB9")]
			public class Collect : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x06006852 RID: 26706 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006852")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Collect()
				{
				}

				// Token: 0x04003DD5 RID: 15829
				[Token(Token = "0x4003DD5")]
				[FieldOffset(Offset = "0x28")]
				public List<int> count;

				// Token: 0x04003DD6 RID: 15830
				[Token(Token = "0x4003DD6")]
				[FieldOffset(Offset = "0x30")]
				public int extraParam;
			}

			// Token: 0x02000BBA RID: 3002
			[Token(Token = "0x2000BBA")]
			public class Hunt
			{
				// Token: 0x06006853 RID: 26707 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006853")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Hunt()
				{
				}

				// Token: 0x04003DD7 RID: 15831
				[Token(Token = "0x4003DD7")]
				[FieldOffset(Offset = "0x10")]
				public string key;

				// Token: 0x04003DD8 RID: 15832
				[Token(Token = "0x4003DD8")]
				[FieldOffset(Offset = "0x18")]
				public List<int> count;
			}

			// Token: 0x02000BBB RID: 3003
			[Token(Token = "0x2000BBB")]
			public class Trap : PlayerSandboxV2.Dungeon.EntityStatus
			{
				// Token: 0x06006854 RID: 26708 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006854")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Trap()
				{
				}
			}

			// Token: 0x02000BBC RID: 3004
			[Token(Token = "0x2000BBC")]
			public class Building
			{
				// Token: 0x06006855 RID: 26709 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006855")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Building()
				{
				}

				// Token: 0x04003DD9 RID: 15833
				[Token(Token = "0x4003DD9")]
				[FieldOffset(Offset = "0x10")]
				public string key;

				// Token: 0x04003DDA RID: 15834
				[Token(Token = "0x4003DDA")]
				[FieldOffset(Offset = "0x18")]
				public List<int> pos;

				// Token: 0x04003DDB RID: 15835
				[Token(Token = "0x4003DDB")]
				[FieldOffset(Offset = "0x20")]
				public int hpRatio;

				// Token: 0x04003DDC RID: 15836
				[Token(Token = "0x4003DDC")]
				[FieldOffset(Offset = "0x24")]
				public int dir;
			}

			// Token: 0x02000BBD RID: 3005
			[Token(Token = "0x2000BBD")]
			public class CatchAnimal
			{
				// Token: 0x06006856 RID: 26710 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006856")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CatchAnimal()
				{
				}

				// Token: 0x04003DDD RID: 15837
				[Token(Token = "0x4003DDD")]
				[FieldOffset(Offset = "0x10")]
				public int room;

				// Token: 0x04003DDE RID: 15838
				[Token(Token = "0x4003DDE")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerSandboxV2.Dungeon.CatchAnimal.CatchAnimalInfo> enemy;

				// Token: 0x02000BBE RID: 3006
				[Token(Token = "0x2000BBE")]
				public class CatchAnimalInfo
				{
					// Token: 0x06006857 RID: 26711 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006857")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public CatchAnimalInfo()
					{
					}

					// Token: 0x04003DDF RID: 15839
					[Token(Token = "0x4003DDF")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003DE0 RID: 15840
					[Token(Token = "0x4003DE0")]
					[FieldOffset(Offset = "0x18")]
					public int count;
				}
			}

			// Token: 0x02000BBF RID: 3007
			[Token(Token = "0x2000BBF")]
			public class NodeStage
			{
				// Token: 0x06006858 RID: 26712 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006858")]
				[Address(RVA = "0x1EEC5E0", Offset = "0x1EEB1E0", VA = "0x181EEC5E0")]
				public NodeStage()
				{
				}

				// Token: 0x04003DE1 RID: 15841
				[Token(Token = "0x4003DE1")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003DE2 RID: 15842
				[Token(Token = "0x4003DE2")]
				[FieldOffset(Offset = "0x18")]
				public PlayerSandboxV2.StageState state;

				// Token: 0x04003DE3 RID: 15843
				[Token(Token = "0x4003DE3")]
				[FieldOffset(Offset = "0x20")]
				public string view;

				// Token: 0x04003DE4 RID: 15844
				[Token(Token = "0x4003DE4")]
				[FieldOffset(Offset = "0x28")]
				[JsonProperty(PropertyName = "base")]
				public List<PlayerSandboxV2.Dungeon.BaseInfo> baseInfo;

				// Token: 0x04003DE5 RID: 15845
				[Token(Token = "0x4003DE5")]
				[FieldOffset(Offset = "0x30")]
				public List<PlayerSandboxV2.Dungeon.Portable> port;

				// Token: 0x04003DE6 RID: 15846
				[Token(Token = "0x4003DE6")]
				[FieldOffset(Offset = "0x38")]
				public List<PlayerSandboxV2.Dungeon.Nest> nest;

				// Token: 0x04003DE7 RID: 15847
				[Token(Token = "0x4003DE7")]
				[FieldOffset(Offset = "0x40")]
				public List<PlayerSandboxV2.Dungeon.Cave> cave;

				// Token: 0x04003DE8 RID: 15848
				[Token(Token = "0x4003DE8")]
				[FieldOffset(Offset = "0x48")]
				public List<PlayerSandboxV2.Dungeon.Gate> gate;

				// Token: 0x04003DE9 RID: 15849
				[Token(Token = "0x4003DE9")]
				[FieldOffset(Offset = "0x50")]
				public List<PlayerSandboxV2.Dungeon.Mine> mine;

				// Token: 0x04003DEA RID: 15850
				[Token(Token = "0x4003DEA")]
				[FieldOffset(Offset = "0x58")]
				public List<PlayerSandboxV2.Dungeon.Selection> insect;

				// Token: 0x04003DEB RID: 15851
				[Token(Token = "0x4003DEB")]
				[FieldOffset(Offset = "0x60")]
				public List<PlayerSandboxV2.Dungeon.Collect> collect;

				// Token: 0x04003DEC RID: 15852
				[Token(Token = "0x4003DEC")]
				[FieldOffset(Offset = "0x68")]
				public List<PlayerSandboxV2.Dungeon.Hunt> hunt;

				// Token: 0x04003DED RID: 15853
				[Token(Token = "0x4003DED")]
				[FieldOffset(Offset = "0x70")]
				public List<PlayerSandboxV2.Dungeon.Trap> trap;

				// Token: 0x04003DEE RID: 15854
				[Token(Token = "0x4003DEE")]
				[FieldOffset(Offset = "0x78")]
				public List<PlayerSandboxV2.Dungeon.Building> building;

				// Token: 0x04003DEF RID: 15855
				[Token(Token = "0x4003DEF")]
				[FieldOffset(Offset = "0x80")]
				public List<List<int>> action;

				// Token: 0x04003DF0 RID: 15856
				[Token(Token = "0x4003DF0")]
				[FieldOffset(Offset = "0x88")]
				public List<List<int>> actionKill;

				// Token: 0x04003DF1 RID: 15857
				[Token(Token = "0x4003DF1")]
				[FieldOffset(Offset = "0x90")]
				public List<PlayerSandboxV2.Dungeon.CatchAnimal> animal;
			}

			// Token: 0x02000BC0 RID: 3008
			[Token(Token = "0x2000BC0")]
			public enum FloatSourceType
			{
				// Token: 0x04003DF3 RID: 15859
				[Token(Token = "0x4003DF3")]
				NONE,
				// Token: 0x04003DF4 RID: 15860
				[Token(Token = "0x4003DF4")]
				SRC_QUEST,
				// Token: 0x04003DF5 RID: 15861
				[Token(Token = "0x4003DF5")]
				SRC_MARKET,
				// Token: 0x04003DF6 RID: 15862
				[Token(Token = "0x4003DF6")]
				SRC_RIFT_MAIN
			}

			// Token: 0x02000BC1 RID: 3009
			[Token(Token = "0x2000BC1")]
			public class FloatSource
			{
				// Token: 0x06006859 RID: 26713 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006859")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public FloatSource()
				{
				}

				// Token: 0x04003DF7 RID: 15863
				[Token(Token = "0x4003DF7")]
				[FieldOffset(Offset = "0x10")]
				public PlayerSandboxV2.Dungeon.FloatSourceType type;

				// Token: 0x04003DF8 RID: 15864
				[Token(Token = "0x4003DF8")]
				[FieldOffset(Offset = "0x18")]
				public string id;
			}

			// Token: 0x02000BC2 RID: 3010
			[Token(Token = "0x2000BC2")]
			public class EnemyRushBossStatus
			{
				// Token: 0x0600685A RID: 26714 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600685A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public EnemyRushBossStatus()
				{
				}

				// Token: 0x04003DF9 RID: 15865
				[Token(Token = "0x4003DF9")]
				[FieldOffset(Offset = "0x10")]
				public int hpRatio;

				// Token: 0x04003DFA RID: 15866
				[Token(Token = "0x4003DFA")]
				[FieldOffset(Offset = "0x14")]
				public int modeIndex;
			}

			// Token: 0x02000BC3 RID: 3011
			[Token(Token = "0x2000BC3")]
			public class EnemyRush
			{
				// Token: 0x0600685B RID: 26715 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600685B")]
				[Address(RVA = "0x1EEA0C0", Offset = "0x1EE8CC0", VA = "0x181EEA0C0")]
				public EnemyRush()
				{
				}

				// Token: 0x04003DFB RID: 15867
				[Token(Token = "0x4003DFB")]
				[FieldOffset(Offset = "0x10")]
				public SandboxV2EnemyRushType enemyRushType;

				// Token: 0x04003DFC RID: 15868
				[Token(Token = "0x4003DFC")]
				[FieldOffset(Offset = "0x18")]
				public string groupKey;

				// Token: 0x04003DFD RID: 15869
				[Token(Token = "0x4003DFD")]
				[FieldOffset(Offset = "0x20")]
				public int state;

				// Token: 0x04003DFE RID: 15870
				[Token(Token = "0x4003DFE")]
				[FieldOffset(Offset = "0x24")]
				public int day;

				// Token: 0x04003DFF RID: 15871
				[Token(Token = "0x4003DFF")]
				[FieldOffset(Offset = "0x28")]
				public List<string> path;

				// Token: 0x04003E00 RID: 15872
				[Token(Token = "0x4003E00")]
				[FieldOffset(Offset = "0x30")]
				public List<List<int>> enemy;

				// Token: 0x04003E01 RID: 15873
				[Token(Token = "0x4003E01")]
				[FieldOffset(Offset = "0x38")]
				public Dictionary<string, PlayerSandboxV2.Dungeon.EnemyRushBossStatus> boss;

				// Token: 0x04003E02 RID: 15874
				[Token(Token = "0x4003E02")]
				[FieldOffset(Offset = "0x40")]
				public SandboxV2QuestLineBadgeType badge;

				// Token: 0x04003E03 RID: 15875
				[Token(Token = "0x4003E03")]
				[FieldOffset(Offset = "0x48")]
				public PlayerSandboxV2.Dungeon.FloatSource src;
			}

			// Token: 0x02000BC4 RID: 3012
			[Token(Token = "0x2000BC4")]
			public class RareAnimal
			{
				// Token: 0x0600685C RID: 26716 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600685C")]
				[Address(RVA = "0x1F00190", Offset = "0x1EFED90", VA = "0x181F00190")]
				public RareAnimal()
				{
				}

				// Token: 0x04003E04 RID: 15876
				[Token(Token = "0x4003E04")]
				[FieldOffset(Offset = "0x10")]
				public SandboxV2RareAnimalType rareAnimalType;

				// Token: 0x04003E05 RID: 15877
				[Token(Token = "0x4003E05")]
				[FieldOffset(Offset = "0x18")]
				public string enemyId;

				// Token: 0x04003E06 RID: 15878
				[Token(Token = "0x4003E06")]
				[FieldOffset(Offset = "0x20")]
				public string enemyGroupKey;

				// Token: 0x04003E07 RID: 15879
				[Token(Token = "0x4003E07")]
				[FieldOffset(Offset = "0x28")]
				public int day;

				// Token: 0x04003E08 RID: 15880
				[Token(Token = "0x4003E08")]
				[FieldOffset(Offset = "0x30")]
				public List<string> path;

				// Token: 0x04003E09 RID: 15881
				[Token(Token = "0x4003E09")]
				[FieldOffset(Offset = "0x38")]
				public SandboxV2QuestLineBadgeType badge;

				// Token: 0x04003E0A RID: 15882
				[Token(Token = "0x4003E0A")]
				[FieldOffset(Offset = "0x40")]
				public PlayerSandboxV2.Dungeon.FloatSource src;

				// Token: 0x04003E0B RID: 15883
				[Token(Token = "0x4003E0B")]
				[FieldOffset(Offset = "0x48")]
				public PlayerSandboxV2.Dungeon.RareAnimalExtraInfo extra;
			}

			// Token: 0x02000BC5 RID: 3013
			[Token(Token = "0x2000BC5")]
			public class RareAnimalExtraInfo
			{
				// Token: 0x0600685D RID: 26717 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600685D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RareAnimalExtraInfo()
				{
				}

				// Token: 0x04003E0C RID: 15884
				[Token(Token = "0x4003E0C")]
				[FieldOffset(Offset = "0x10")]
				public int hpRatio;

				// Token: 0x04003E0D RID: 15885
				[Token(Token = "0x4003E0D")]
				[FieldOffset(Offset = "0x14")]
				public bool found;
			}

			// Token: 0x02000BC6 RID: 3014
			[Token(Token = "0x2000BC6")]
			public class Enemy
			{
				// Token: 0x0600685E RID: 26718 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600685E")]
				[Address(RVA = "0x1EEA130", Offset = "0x1EE8D30", VA = "0x181EEA130")]
				public Enemy()
				{
				}

				// Token: 0x04003E0E RID: 15886
				[Token(Token = "0x4003E0E")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, PlayerSandboxV2.Dungeon.EnemyRush> enemyRush;

				// Token: 0x04003E0F RID: 15887
				[Token(Token = "0x4003E0F")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerSandboxV2.Dungeon.RareAnimal> rareAnimal;
			}

			// Token: 0x02000BC7 RID: 3015
			[Token(Token = "0x2000BC7")]
			public class NpcGroup
			{
				// Token: 0x0600685F RID: 26719 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600685F")]
				[Address(RVA = "0x1EECA00", Offset = "0x1EEB600", VA = "0x181EECA00")]
				public NpcGroup()
				{
				}

				// Token: 0x04003E10 RID: 15888
				[Token(Token = "0x4003E10")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, List<PlayerSandboxV2.Dungeon.NpcGroup.Npc>> node;

				// Token: 0x04003E11 RID: 15889
				[Token(Token = "0x4003E11")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> favor;

				// Token: 0x02000BC8 RID: 3016
				[Token(Token = "0x2000BC8")]
				public class Npc
				{
					// Token: 0x06006860 RID: 26720 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006860")]
					[Address(RVA = "0x1EECA90", Offset = "0x1EEB690", VA = "0x181EECA90")]
					public Npc()
					{
					}

					// Token: 0x04003E12 RID: 15890
					[Token(Token = "0x4003E12")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003E13 RID: 15891
					[Token(Token = "0x4003E13")]
					[FieldOffset(Offset = "0x18")]
					public int instId;

					// Token: 0x04003E14 RID: 15892
					[Token(Token = "0x4003E14")]
					[FieldOffset(Offset = "0x1C")]
					[JsonProperty(PropertyName = "type")]
					public bool isBlackMarketNpc;

					// Token: 0x04003E15 RID: 15893
					[Token(Token = "0x4003E15")]
					[FieldOffset(Offset = "0x1D")]
					public bool enable;

					// Token: 0x04003E16 RID: 15894
					[Token(Token = "0x4003E16")]
					[FieldOffset(Offset = "0x20")]
					public Dictionary<int, PlayerSandboxV2.Dungeon.NpcGroup.Npc.NpcMeta> dialog;

					// Token: 0x04003E17 RID: 15895
					[Token(Token = "0x4003E17")]
					[FieldOffset(Offset = "0x28")]
					public SandboxV2QuestLineBadgeType badge;

					// Token: 0x04003E18 RID: 15896
					[Token(Token = "0x4003E18")]
					[FieldOffset(Offset = "0x30")]
					public PlayerSandboxV2.Dungeon.FloatSource src;

					// Token: 0x02000BC9 RID: 3017
					[Token(Token = "0x2000BC9")]
					public class NpcMeta
					{
						// Token: 0x06006861 RID: 26721 RVA: 0x00002053 File Offset: 0x00000253
						[Token(Token = "0x6006861")]
						[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
						public NpcMeta()
						{
						}

						// Token: 0x04003E19 RID: 15897
						[Token(Token = "0x4003E19")]
						[FieldOffset(Offset = "0x10")]
						public List<PlayerSandboxV2.Dungeon.NpcGroup.Npc.NpcMeta.GachaItemPair> gacha;

						// Token: 0x02000BCA RID: 3018
						[Token(Token = "0x2000BCA")]
						public class GachaItemPair
						{
							// Token: 0x06006862 RID: 26722 RVA: 0x00002053 File Offset: 0x00000253
							[Token(Token = "0x6006862")]
							[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
							public GachaItemPair()
							{
							}

							// Token: 0x04003E1A RID: 15898
							[Token(Token = "0x4003E1A")]
							[FieldOffset(Offset = "0x10")]
							public string id;

							// Token: 0x04003E1B RID: 15899
							[Token(Token = "0x4003E1B")]
							[FieldOffset(Offset = "0x18")]
							public int count;
						}
					}
				}
			}

			// Token: 0x02000BCB RID: 3019
			[Token(Token = "0x2000BCB")]
			public class Effect
			{
				// Token: 0x06006863 RID: 26723 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006863")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Effect()
				{
				}

				// Token: 0x04003E1C RID: 15900
				[Token(Token = "0x4003E1C")]
				[FieldOffset(Offset = "0x10")]
				public int instId;

				// Token: 0x04003E1D RID: 15901
				[Token(Token = "0x4003E1D")]
				[FieldOffset(Offset = "0x18")]
				public string id;

				// Token: 0x04003E1E RID: 15902
				[Token(Token = "0x4003E1E")]
				[FieldOffset(Offset = "0x20")]
				public int day;
			}

			// Token: 0x02000BCC RID: 3020
			[Token(Token = "0x2000BCC")]
			public class EventGroup
			{
				// Token: 0x06006864 RID: 26724 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006864")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public EventGroup()
				{
				}

				// Token: 0x04003E1F RID: 15903
				[Token(Token = "0x4003E1F")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, List<PlayerSandboxV2.Dungeon.EventGroup.Event>> node;

				// Token: 0x04003E20 RID: 15904
				[Token(Token = "0x4003E20")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerSandboxV2.Dungeon.Effect> effect;

				// Token: 0x02000BCD RID: 3021
				[Token(Token = "0x2000BCD")]
				public class Event
				{
					// Token: 0x06006865 RID: 26725 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006865")]
					[Address(RVA = "0x1EEA200", Offset = "0x1EE8E00", VA = "0x181EEA200")]
					public Event()
					{
					}

					// Token: 0x04003E21 RID: 15905
					[Token(Token = "0x4003E21")]
					[FieldOffset(Offset = "0x10")]
					public string id;

					// Token: 0x04003E22 RID: 15906
					[Token(Token = "0x4003E22")]
					[FieldOffset(Offset = "0x18")]
					public int instId;

					// Token: 0x04003E23 RID: 15907
					[Token(Token = "0x4003E23")]
					[FieldOffset(Offset = "0x20")]
					public string scene;

					// Token: 0x04003E24 RID: 15908
					[Token(Token = "0x4003E24")]
					[FieldOffset(Offset = "0x28")]
					public int state;

					// Token: 0x04003E25 RID: 15909
					[Token(Token = "0x4003E25")]
					[FieldOffset(Offset = "0x2C")]
					public SandboxV2QuestLineBadgeType badge;

					// Token: 0x04003E26 RID: 15910
					[Token(Token = "0x4003E26")]
					[FieldOffset(Offset = "0x30")]
					public PlayerSandboxV2.Dungeon.FloatSource src;
				}
			}
		}

		// Token: 0x02000BCE RID: 3022
		[Token(Token = "0x2000BCE")]
		public class Troop
		{
			// Token: 0x06006866 RID: 26726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006866")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Troop()
			{
			}

			// Token: 0x04003E27 RID: 15911
			[Token(Token = "0x4003E27")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, PlayerSandboxV2.Troop.CharFood> food;

			// Token: 0x04003E28 RID: 15912
			[Token(Token = "0x4003E28")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerSandboxV2.Troop.Squad> squad;

			// Token: 0x04003E29 RID: 15913
			[Token(Token = "0x4003E29")]
			[FieldOffset(Offset = "0x20")]
			public List<int> usedChar;

			// Token: 0x02000BCF RID: 3023
			[Token(Token = "0x2000BCF")]
			public class CharFood
			{
				// Token: 0x06006867 RID: 26727 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006867")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public CharFood()
				{
				}

				// Token: 0x04003E2A RID: 15914
				[Token(Token = "0x4003E2A")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003E2B RID: 15915
				[Token(Token = "0x4003E2B")]
				[FieldOffset(Offset = "0x18")]
				public List<string> sub;

				// Token: 0x04003E2C RID: 15916
				[Token(Token = "0x4003E2C")]
				[FieldOffset(Offset = "0x20")]
				public int day;
			}

			// Token: 0x02000BD0 RID: 3024
			[Token(Token = "0x2000BD0")]
			public class Squad
			{
				// Token: 0x06006868 RID: 26728 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006868")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Squad()
				{
				}

				// Token: 0x04003E2D RID: 15917
				[Token(Token = "0x4003E2D")]
				[FieldOffset(Offset = "0x10")]
				public List<PlayerSquadItem> slots;

				// Token: 0x04003E2E RID: 15918
				[Token(Token = "0x4003E2E")]
				[FieldOffset(Offset = "0x18")]
				public List<string> tools;
			}
		}

		// Token: 0x02000BD1 RID: 3025
		[Token(Token = "0x2000BD1")]
		public class Cook
		{
			// Token: 0x06006869 RID: 26729 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006869")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Cook()
			{
			}

			// Token: 0x04003E2F RID: 15919
			[Token(Token = "0x4003E2F")]
			[FieldOffset(Offset = "0x10")]
			public int drink;

			// Token: 0x04003E30 RID: 15920
			[Token(Token = "0x4003E30")]
			[FieldOffset(Offset = "0x14")]
			public int extraDrink;

			// Token: 0x04003E31 RID: 15921
			[Token(Token = "0x4003E31")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> book;

			// Token: 0x04003E32 RID: 15922
			[Token(Token = "0x4003E32")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerSandboxV2.Cook.Food> food;

			// Token: 0x02000BD2 RID: 3026
			[Token(Token = "0x2000BD2")]
			public class Food
			{
				// Token: 0x0600686A RID: 26730 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600686A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Food()
				{
				}

				// Token: 0x04003E33 RID: 15923
				[Token(Token = "0x4003E33")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003E34 RID: 15924
				[Token(Token = "0x4003E34")]
				[FieldOffset(Offset = "0x18")]
				public List<string> sub;

				// Token: 0x04003E35 RID: 15925
				[Token(Token = "0x4003E35")]
				[FieldOffset(Offset = "0x20")]
				public int count;
			}
		}

		// Token: 0x02000BD3 RID: 3027
		[Token(Token = "0x2000BD3")]
		public class Build
		{
			// Token: 0x0600686B RID: 26731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600686B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Build()
			{
			}

			// Token: 0x04003E36 RID: 15926
			[Token(Token = "0x4003E36")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> book;

			// Token: 0x04003E37 RID: 15927
			[Token(Token = "0x4003E37")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> building;

			// Token: 0x04003E38 RID: 15928
			[Token(Token = "0x4003E38")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, int> tactical;

			// Token: 0x04003E39 RID: 15929
			[Token(Token = "0x4003E39")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, int> animal;
		}

		// Token: 0x02000BD4 RID: 3028
		[Token(Token = "0x2000BD4")]
		public class Bag
		{
			// Token: 0x0600686C RID: 26732 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600686C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Bag()
			{
			}

			// Token: 0x04003E3A RID: 15930
			[Token(Token = "0x4003E3A")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> material;

			// Token: 0x04003E3B RID: 15931
			[Token(Token = "0x4003E3B")]
			[FieldOffset(Offset = "0x18")]
			public string[] craft;
		}

		// Token: 0x02000BD5 RID: 3029
		[Token(Token = "0x2000BD5")]
		public class Bank
		{
			// Token: 0x0600686D RID: 26733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600686D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Bank()
			{
			}

			// Token: 0x04003E3C RID: 15932
			[Token(Token = "0x4003E3C")]
			[FieldOffset(Offset = "0x10")]
			public List<string> book;

			// Token: 0x04003E3D RID: 15933
			[Token(Token = "0x4003E3D")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> coin;
		}

		// Token: 0x02000BD6 RID: 3030
		[Token(Token = "0x2000BD6")]
		public class Tech
		{
			// Token: 0x0600686E RID: 26734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600686E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Tech()
			{
			}

			// Token: 0x04003E3E RID: 15934
			[Token(Token = "0x4003E3E")]
			[FieldOffset(Offset = "0x10")]
			public int token;

			// Token: 0x04003E3F RID: 15935
			[Token(Token = "0x4003E3F")]
			[FieldOffset(Offset = "0x14")]
			public int cent;

			// Token: 0x04003E40 RID: 15936
			[Token(Token = "0x4003E40")]
			[FieldOffset(Offset = "0x18")]
			public string[] unlock;
		}

		// Token: 0x02000BD7 RID: 3031
		[Token(Token = "0x2000BD7")]
		public class QuestGroup
		{
			// Token: 0x0600686F RID: 26735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600686F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public QuestGroup()
			{
			}

			// Token: 0x04003E41 RID: 15937
			[Token(Token = "0x4003E41")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "pending")]
			public List<PlayerSandboxV2.QuestGroup.Quest> quests;

			// Token: 0x04003E42 RID: 15938
			[Token(Token = "0x4003E42")]
			[FieldOffset(Offset = "0x18")]
			public List<string> complete;

			// Token: 0x02000BD8 RID: 3032
			[Token(Token = "0x2000BD8")]
			public class Quest
			{
				// Token: 0x06006870 RID: 26736 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006870")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Quest()
				{
				}

				// Token: 0x04003E43 RID: 15939
				[Token(Token = "0x4003E43")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003E44 RID: 15940
				[Token(Token = "0x4003E44")]
				[FieldOffset(Offset = "0x18")]
				[JsonProperty(PropertyName = "state")]
				public bool completed;

				// Token: 0x04003E45 RID: 15941
				[Token(Token = "0x4003E45")]
				[FieldOffset(Offset = "0x20")]
				public List<List<string>> progress;
			}
		}

		// Token: 0x02000BD9 RID: 3033
		[Token(Token = "0x2000BD9")]
		public class Shop
		{
			// Token: 0x06006871 RID: 26737 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006871")]
			[Address(RVA = "0x1F01830", Offset = "0x1F00430", VA = "0x181F01830")]
			public Shop()
			{
			}

			// Token: 0x04003E46 RID: 15942
			[Token(Token = "0x4003E46")]
			[FieldOffset(Offset = "0x10")]
			public bool unlock;

			// Token: 0x04003E47 RID: 15943
			[Token(Token = "0x4003E47")]
			[FieldOffset(Offset = "0x14")]
			public int day;

			// Token: 0x04003E48 RID: 15944
			[Token(Token = "0x4003E48")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerSandboxV2.Shop.ShopSlotData> slots;

			// Token: 0x02000BDA RID: 3034
			[Token(Token = "0x2000BDA")]
			public class ShopSlotData
			{
				// Token: 0x06006872 RID: 26738 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006872")]
				[Address(RVA = "0x1F01820", Offset = "0x1F00420", VA = "0x181F01820")]
				public ShopSlotData()
				{
				}

				// Token: 0x04003E49 RID: 15945
				[Token(Token = "0x4003E49")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty(PropertyName = "id")]
				public string goodId;

				// Token: 0x04003E4A RID: 15946
				[Token(Token = "0x4003E4A")]
				[FieldOffset(Offset = "0x18")]
				public int count;

				// Token: 0x04003E4B RID: 15947
				[Token(Token = "0x4003E4B")]
				[FieldOffset(Offset = "0x1C")]
				public int price;
			}
		}

		// Token: 0x02000BDB RID: 3035
		[Token(Token = "0x2000BDB")]
		public class Month
		{
			// Token: 0x06006873 RID: 26739 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006873")]
			[Address(RVA = "0x1EEC4E0", Offset = "0x1EEB0E0", VA = "0x181EEC4E0")]
			public Month()
			{
			}

			// Token: 0x04003E4C RID: 15948
			[Token(Token = "0x4003E4C")]
			[FieldOffset(Offset = "0x10")]
			public List<string> rushPass;
		}

		// Token: 0x02000BDC RID: 3036
		[Token(Token = "0x2000BDC")]
		public class RiftInfo
		{
			// Token: 0x06006874 RID: 26740 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006874")]
			[Address(RVA = "0x1F00FA0", Offset = "0x1EFFBA0", VA = "0x181F00FA0")]
			public RiftInfo()
			{
			}

			// Token: 0x04003E4D RID: 15949
			[Token(Token = "0x4003E4D")]
			[FieldOffset(Offset = "0x10")]
			public bool isUnlocked;

			// Token: 0x04003E4E RID: 15950
			[Token(Token = "0x4003E4E")]
			[FieldOffset(Offset = "0x14")]
			public int randomRemain;

			// Token: 0x04003E4F RID: 15951
			[Token(Token = "0x4003E4F")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "reserveTimes")]
			public Dictionary<string, int> reservedRifts;

			// Token: 0x04003E50 RID: 15952
			[Token(Token = "0x4003E50")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty(PropertyName = "difficultyLvMax")]
			public Dictionary<string, int> completedDifficultyLevel;

			// Token: 0x04003E51 RID: 15953
			[Token(Token = "0x4003E51")]
			[FieldOffset(Offset = "0x28")]
			public int teamLv;

			// Token: 0x04003E52 RID: 15954
			[Token(Token = "0x4003E52")]
			[FieldOffset(Offset = "0x30")]
			public List<string> fixFinish;

			// Token: 0x04003E53 RID: 15955
			[Token(Token = "0x4003E53")]
			[FieldOffset(Offset = "0x38")]
			public PlayerSandboxV2.RiftInfo.Reservation reservation;

			// Token: 0x04003E54 RID: 15956
			[Token(Token = "0x4003E54")]
			[FieldOffset(Offset = "0x40")]
			public PlayerSandboxV2.RiftInfo.GameInfo gameInfo;

			// Token: 0x04003E55 RID: 15957
			[Token(Token = "0x4003E55")]
			[FieldOffset(Offset = "0x48")]
			public PlayerSandboxV2.RiftInfo.SettleInfo settleInfo;

			// Token: 0x02000BDD RID: 3037
			[Token(Token = "0x2000BDD")]
			public class RewardItem
			{
				// Token: 0x06006875 RID: 26741 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006875")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RewardItem()
				{
				}

				// Token: 0x04003E56 RID: 15958
				[Token(Token = "0x4003E56")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003E57 RID: 15959
				[Token(Token = "0x4003E57")]
				[FieldOffset(Offset = "0x18")]
				public int count;
			}

			// Token: 0x02000BDE RID: 3038
			[Token(Token = "0x2000BDE")]
			public class Reservation
			{
				// Token: 0x06006876 RID: 26742 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006876")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Reservation()
				{
				}

				// Token: 0x04003E58 RID: 15960
				[Token(Token = "0x4003E58")]
				[FieldOffset(Offset = "0x10")]
				public int instId;

				// Token: 0x04003E59 RID: 15961
				[Token(Token = "0x4003E59")]
				[FieldOffset(Offset = "0x18")]
				public string rift;

				// Token: 0x04003E5A RID: 15962
				[Token(Token = "0x4003E5A")]
				[FieldOffset(Offset = "0x20")]
				public string mainTarget;

				// Token: 0x04003E5B RID: 15963
				[Token(Token = "0x4003E5B")]
				[FieldOffset(Offset = "0x28")]
				public string subTarget;

				// Token: 0x04003E5C RID: 15964
				[Token(Token = "0x4003E5C")]
				[FieldOffset(Offset = "0x30")]
				public string climate;

				// Token: 0x04003E5D RID: 15965
				[Token(Token = "0x4003E5D")]
				[FieldOffset(Offset = "0x38")]
				public string terrain;

				// Token: 0x04003E5E RID: 15966
				[Token(Token = "0x4003E5E")]
				[FieldOffset(Offset = "0x40")]
				public string map;

				// Token: 0x04003E5F RID: 15967
				[Token(Token = "0x4003E5F")]
				[FieldOffset(Offset = "0x48")]
				public string enemy;

				// Token: 0x04003E60 RID: 15968
				[Token(Token = "0x4003E60")]
				[FieldOffset(Offset = "0x50")]
				public string effect;

				// Token: 0x04003E61 RID: 15969
				[Token(Token = "0x4003E61")]
				[FieldOffset(Offset = "0x58")]
				public string difficulty;

				// Token: 0x04003E62 RID: 15970
				[Token(Token = "0x4003E62")]
				[FieldOffset(Offset = "0x60")]
				public string team;
			}

			// Token: 0x02000BDF RID: 3039
			[Token(Token = "0x2000BDF")]
			public enum RiftGameStatus
			{
				// Token: 0x04003E64 RID: 15972
				[Token(Token = "0x4003E64")]
				ACTIVE,
				// Token: 0x04003E65 RID: 15973
				[Token(Token = "0x4003E65")]
				SETTLE,
				// Token: 0x04003E66 RID: 15974
				[Token(Token = "0x4003E66")]
				INVALID = 99
			}

			// Token: 0x02000BE0 RID: 3040
			[Token(Token = "0x2000BE0")]
			public class GameInfo
			{
				// Token: 0x06006877 RID: 26743 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006877")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public GameInfo()
				{
				}

				// Token: 0x04003E67 RID: 15975
				[Token(Token = "0x4003E67")]
				[FieldOffset(Offset = "0x10")]
				public PlayerSandboxV2.RiftInfo.RiftGameStatus status;

				// Token: 0x04003E68 RID: 15976
				[Token(Token = "0x4003E68")]
				[FieldOffset(Offset = "0x18")]
				public List<int> mainProgress;

				// Token: 0x04003E69 RID: 15977
				[Token(Token = "0x4003E69")]
				[FieldOffset(Offset = "0x20")]
				public List<int> subProgress;

				// Token: 0x04003E6A RID: 15978
				[Token(Token = "0x4003E6A")]
				[FieldOffset(Offset = "0x28")]
				public bool mainFail;

				// Token: 0x04003E6B RID: 15979
				[Token(Token = "0x4003E6B")]
				[FieldOffset(Offset = "0x30")]
				public PlayerSandboxV2.RiftInfo.GameInfo.RiftFloat pin;

				// Token: 0x02000BE1 RID: 3041
				[Token(Token = "0x2000BE1")]
				public class RiftFloat
				{
					// Token: 0x06006878 RID: 26744 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006878")]
					[Address(RVA = "0x1F00F30", Offset = "0x1EFFB30", VA = "0x181F00F30")]
					public RiftFloat()
					{
					}

					// Token: 0x04003E6C RID: 15980
					[Token(Token = "0x4003E6C")]
					[FieldOffset(Offset = "0x10")]
					public string nodeId;

					// Token: 0x04003E6D RID: 15981
					[Token(Token = "0x4003E6D")]
					[FieldOffset(Offset = "0x18")]
					public SandboxV2QuestLineBadgeType badge;

					// Token: 0x04003E6E RID: 15982
					[Token(Token = "0x4003E6E")]
					[FieldOffset(Offset = "0x20")]
					public PlayerSandboxV2.Dungeon.FloatSource src;
				}
			}

			// Token: 0x02000BE2 RID: 3042
			[Token(Token = "0x2000BE2")]
			public class SettleReward
			{
				// Token: 0x06006879 RID: 26745 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006879")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SettleReward()
				{
				}

				// Token: 0x04003E6F RID: 15983
				[Token(Token = "0x4003E6F")]
				[FieldOffset(Offset = "0x10")]
				public List<PlayerSandboxV2.RiftInfo.RewardItem> main;

				// Token: 0x04003E70 RID: 15984
				[Token(Token = "0x4003E70")]
				[FieldOffset(Offset = "0x18")]
				public List<PlayerSandboxV2.RiftInfo.RewardItem> sub;
			}

			// Token: 0x02000BE3 RID: 3043
			[Token(Token = "0x2000BE3")]
			public class SettleInfo
			{
				// Token: 0x0600687A RID: 26746 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600687A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SettleInfo()
				{
				}

				// Token: 0x04003E71 RID: 15985
				[Token(Token = "0x4003E71")]
				[FieldOffset(Offset = "0x10")]
				public PlayerSandboxV2.RiftInfo.SettleReward reward;

				// Token: 0x04003E72 RID: 15986
				[Token(Token = "0x4003E72")]
				[FieldOffset(Offset = "0x18")]
				public int portHp;
			}
		}

		// Token: 0x02000BE4 RID: 3044
		[Token(Token = "0x2000BE4")]
		public class Supply
		{
			// Token: 0x0600687B RID: 26747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600687B")]
			[Address(RVA = "0x1F024D0", Offset = "0x1F010D0", VA = "0x181F024D0")]
			public Supply()
			{
			}

			// Token: 0x04003E73 RID: 15987
			[Token(Token = "0x4003E73")]
			[FieldOffset(Offset = "0x10")]
			public bool unlock;

			// Token: 0x04003E74 RID: 15988
			[Token(Token = "0x4003E74")]
			[FieldOffset(Offset = "0x11")]
			public bool enable;

			// Token: 0x04003E75 RID: 15989
			[Token(Token = "0x4003E75")]
			[FieldOffset(Offset = "0x14")]
			public int slotCnt;

			// Token: 0x04003E76 RID: 15990
			[Token(Token = "0x4003E76")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "char")]
			public List<int> charInstList;
		}

		// Token: 0x02000BE5 RID: 3045
		[Token(Token = "0x2000BE5")]
		public class Expedition
		{
			// Token: 0x0600687C RID: 26748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600687C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Expedition()
			{
			}

			// Token: 0x04003E77 RID: 15991
			[Token(Token = "0x4003E77")]
			[FieldOffset(Offset = "0x10")]
			public List<PlayerSandboxV2.Expedition.Squad> squad;

			// Token: 0x02000BE6 RID: 3046
			[Token(Token = "0x2000BE6")]
			public class Squad
			{
				// Token: 0x0600687D RID: 26749 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600687D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Squad()
				{
				}

				// Token: 0x04003E78 RID: 15992
				[Token(Token = "0x4003E78")]
				[FieldOffset(Offset = "0x10")]
				public string id;

				// Token: 0x04003E79 RID: 15993
				[Token(Token = "0x4003E79")]
				[FieldOffset(Offset = "0x18")]
				public int day;

				// Token: 0x04003E7A RID: 15994
				[Token(Token = "0x4003E7A")]
				[FieldOffset(Offset = "0x20")]
				[JsonProperty(PropertyName = "char")]
				public List<int> charInstList;
			}
		}

		// Token: 0x02000BE7 RID: 3047
		[Token(Token = "0x2000BE7")]
		public class Save
		{
			// Token: 0x0600687E RID: 26750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600687E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Save()
			{
			}

			// Token: 0x04003E7B RID: 15995
			[Token(Token = "0x4003E7B")]
			[FieldOffset(Offset = "0x10")]
			public int day;

			// Token: 0x04003E7C RID: 15996
			[Token(Token = "0x4003E7C")]
			[FieldOffset(Offset = "0x14")]
			public int maxAp;

			// Token: 0x04003E7D RID: 15997
			[Token(Token = "0x4003E7D")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Dungeon.Season season;

			// Token: 0x04003E7E RID: 15998
			[Token(Token = "0x4003E7E")]
			[FieldOffset(Offset = "0x20")]
			public long ts;
		}

		// Token: 0x02000BE8 RID: 3048
		[Token(Token = "0x2000BE8")]
		public class Archive
		{
			// Token: 0x0600687F RID: 26751 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600687F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Archive()
			{
			}

			// Token: 0x04003E7F RID: 15999
			[Token(Token = "0x4003E7F")]
			[FieldOffset(Offset = "0x10")]
			public List<PlayerSandboxV2.Save> save;

			// Token: 0x04003E80 RID: 16000
			[Token(Token = "0x4003E80")]
			[FieldOffset(Offset = "0x18")]
			public long nextLoadTs;

			// Token: 0x04003E81 RID: 16001
			[Token(Token = "0x4003E81")]
			[FieldOffset(Offset = "0x20")]
			public long loadTs;

			// Token: 0x04003E82 RID: 16002
			[Token(Token = "0x4003E82")]
			[FieldOffset(Offset = "0x28")]
			public PlayerSandboxV2.Save daily;
		}

		// Token: 0x02000BE9 RID: 3049
		[Token(Token = "0x2000BE9")]
		public class Collect
		{
			// Token: 0x06006880 RID: 26752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006880")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Collect()
			{
			}

			// Token: 0x04003E83 RID: 16003
			[Token(Token = "0x4003E83")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Collect.Pending pending;

			// Token: 0x04003E84 RID: 16004
			[Token(Token = "0x4003E84")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Collect.Complete complete;

			// Token: 0x02000BEA RID: 3050
			[Token(Token = "0x2000BEA")]
			public class Pending
			{
				// Token: 0x06006881 RID: 26753 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006881")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Pending()
				{
				}

				// Token: 0x04003E85 RID: 16005
				[Token(Token = "0x4003E85")]
				[FieldOffset(Offset = "0x10")]
				public Dictionary<string, List<int>> achievement;
			}

			// Token: 0x02000BEB RID: 3051
			[Token(Token = "0x2000BEB")]
			public class Complete
			{
				// Token: 0x06006882 RID: 26754 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006882")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Complete()
				{
				}

				// Token: 0x04003E86 RID: 16006
				[Token(Token = "0x4003E86")]
				[FieldOffset(Offset = "0x10")]
				public List<string> achievement;

				// Token: 0x04003E87 RID: 16007
				[Token(Token = "0x4003E87")]
				[FieldOffset(Offset = "0x18")]
				public List<string> quest;

				// Token: 0x04003E88 RID: 16008
				[Token(Token = "0x4003E88")]
				[FieldOffset(Offset = "0x20")]
				public List<string> music;
			}
		}

		// Token: 0x02000BEC RID: 3052
		[Token(Token = "0x2000BEC")]
		public class Buff
		{
			// Token: 0x06006883 RID: 26755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006883")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Buff()
			{
			}

			// Token: 0x04003E89 RID: 16009
			[Token(Token = "0x4003E89")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Buff.Runes rune;

			// Token: 0x02000BED RID: 3053
			[Token(Token = "0x2000BED")]
			public class Runes
			{
				// Token: 0x06006884 RID: 26756 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006884")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Runes()
				{
				}

				// Token: 0x04003E8A RID: 16010
				[Token(Token = "0x4003E8A")]
				[FieldOffset(Offset = "0x10")]
				public List<string> global;

				// Token: 0x04003E8B RID: 16011
				[Token(Token = "0x4003E8B")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, List<string>> node;

				// Token: 0x04003E8C RID: 16012
				[Token(Token = "0x4003E8C")]
				[FieldOffset(Offset = "0x20")]
				[JsonProperty(PropertyName = "char")]
				public Dictionary<string, List<string>> characters;
			}
		}

		// Token: 0x02000BEE RID: 3054
		[Token(Token = "0x2000BEE")]
		public class Racing
		{
			// Token: 0x06006885 RID: 26757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006885")]
			[Address(RVA = "0x1F00010", Offset = "0x1EFEC10", VA = "0x181F00010")]
			public Racing()
			{
			}

			// Token: 0x04003E8D RID: 16013
			[Token(Token = "0x4003E8D")]
			[FieldOffset(Offset = "0x10")]
			public bool unlock;

			// Token: 0x04003E8E RID: 16014
			[Token(Token = "0x4003E8E")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Racing.RacerBag bag;

			// Token: 0x04003E8F RID: 16015
			[Token(Token = "0x4003E8F")]
			[FieldOffset(Offset = "0x20")]
			public PlayerSandboxV2.Racing.TempRacerBag bagTmp;

			// Token: 0x04003E90 RID: 16016
			[Token(Token = "0x4003E90")]
			[FieldOffset(Offset = "0x28")]
			public int token;

			// Token: 0x02000BEF RID: 3055
			[Token(Token = "0x2000BEF")]
			public struct RacerName
			{
				// Token: 0x04003E91 RID: 16017
				[Token(Token = "0x4003E91")]
				[FieldOffset(Offset = "0x0")]
				public string prefix;

				// Token: 0x04003E92 RID: 16018
				[Token(Token = "0x4003E92")]
				[FieldOffset(Offset = "0x8")]
				public string suffix;
			}

			// Token: 0x02000BF0 RID: 3056
			[Token(Token = "0x2000BF0")]
			public struct RacerTalent
			{
				// Token: 0x04003E93 RID: 16019
				[Token(Token = "0x4003E93")]
				[FieldOffset(Offset = "0x0")]
				public string born;

				// Token: 0x04003E94 RID: 16020
				[Token(Token = "0x4003E94")]
				[FieldOffset(Offset = "0x8")]
				public string learned;
			}

			// Token: 0x02000BF1 RID: 3057
			[Token(Token = "0x2000BF1")]
			public class RacerBaseInfo
			{
				// Token: 0x06006886 RID: 26758 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006886")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RacerBaseInfo()
				{
				}

				// Token: 0x04003E95 RID: 16021
				[Token(Token = "0x4003E95")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty(PropertyName = "id")]
				public string racerId;

				// Token: 0x04003E96 RID: 16022
				[Token(Token = "0x4003E96")]
				[FieldOffset(Offset = "0x18")]
				public int inst;

				// Token: 0x04003E97 RID: 16023
				[Token(Token = "0x4003E97")]
				[FieldOffset(Offset = "0x1C")]
				public int level;

				// Token: 0x04003E98 RID: 16024
				[Token(Token = "0x4003E98")]
				[FieldOffset(Offset = "0x20")]
				[JsonProperty(PropertyName = "attrib")]
				public List<int> attribute;

				// Token: 0x04003E99 RID: 16025
				[Token(Token = "0x4003E99")]
				[FieldOffset(Offset = "0x28")]
				[JsonProperty(PropertyName = "skill")]
				public PlayerSandboxV2.Racing.RacerTalent talent;
			}

			// Token: 0x02000BF2 RID: 3058
			[Token(Token = "0x2000BF2")]
			public class TempRacerInfo : PlayerSandboxV2.Racing.RacerBaseInfo
			{
				// Token: 0x06006887 RID: 26759 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006887")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public TempRacerInfo()
				{
				}
			}

			// Token: 0x02000BF3 RID: 3059
			[Token(Token = "0x2000BF3")]
			public class RacerInfo : PlayerSandboxV2.Racing.RacerBaseInfo
			{
				// Token: 0x06006888 RID: 26760 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006888")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RacerInfo()
				{
				}

				// Token: 0x04003E9A RID: 16026
				[Token(Token = "0x4003E9A")]
				[FieldOffset(Offset = "0x38")]
				public PlayerSandboxV2.Racing.RacerName name;

				// Token: 0x04003E9B RID: 16027
				[Token(Token = "0x4003E9B")]
				[FieldOffset(Offset = "0x48")]
				public bool mark;

				// Token: 0x04003E9C RID: 16028
				[Token(Token = "0x4003E9C")]
				[FieldOffset(Offset = "0x50")]
				public List<string> medal;
			}

			// Token: 0x02000BF4 RID: 3060
			[Token(Token = "0x2000BF4")]
			public class RacerBagBase
			{
				// Token: 0x06006889 RID: 26761 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006889")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RacerBagBase()
				{
				}

				// Token: 0x04003E9D RID: 16029
				[Token(Token = "0x4003E9D")]
				[FieldOffset(Offset = "0x10")]
				[JsonProperty(PropertyName = "cap")]
				public int capacity;
			}

			// Token: 0x02000BF5 RID: 3061
			[Token(Token = "0x2000BF5")]
			public class TempRacerBag : PlayerSandboxV2.Racing.RacerBagBase
			{
				// Token: 0x0600688A RID: 26762 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600688A")]
				[Address(RVA = "0x1F026E0", Offset = "0x1F012E0", VA = "0x181F026E0")]
				public TempRacerBag()
				{
				}

				// Token: 0x04003E9E RID: 16030
				[Token(Token = "0x4003E9E")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerSandboxV2.Racing.TempRacerInfo> racer;
			}

			// Token: 0x02000BF6 RID: 3062
			[Token(Token = "0x2000BF6")]
			public class RacerBag : PlayerSandboxV2.Racing.RacerBagBase
			{
				// Token: 0x0600688B RID: 26763 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600688B")]
				[Address(RVA = "0x1EFFF80", Offset = "0x1EFEB80", VA = "0x181EFFF80")]
				public RacerBag()
				{
				}

				// Token: 0x04003E9F RID: 16031
				[Token(Token = "0x4003E9F")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, PlayerSandboxV2.Racing.RacerInfo> racer;
			}
		}

		// Token: 0x02000BF7 RID: 3063
		[Token(Token = "0x2000BF7")]
		public class Challenge
		{
			// Token: 0x0600688C RID: 26764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600688C")]
			[Address(RVA = "0x1EE75C0", Offset = "0x1EE61C0", VA = "0x181EE75C0")]
			public Challenge()
			{
			}

			// Token: 0x04003EA0 RID: 16032
			[Token(Token = "0x4003EA0")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, List<int>> unlock;

			// Token: 0x04003EA1 RID: 16033
			[Token(Token = "0x4003EA1")]
			[FieldOffset(Offset = "0x18")]
			public PlayerSandboxV2.Challenge.ChallengeStatus status;

			// Token: 0x04003EA2 RID: 16034
			[Token(Token = "0x4003EA2")]
			[FieldOffset(Offset = "0x20")]
			public PlayerSandboxV2.Challenge.Current cur;

			// Token: 0x04003EA3 RID: 16035
			[Token(Token = "0x4003EA3")]
			[FieldOffset(Offset = "0x28")]
			public PlayerSandboxV2.Challenge.History best;

			// Token: 0x04003EA4 RID: 16036
			[Token(Token = "0x4003EA4")]
			[FieldOffset(Offset = "0x30")]
			public PlayerSandboxV2.Challenge.History last;

			// Token: 0x04003EA5 RID: 16037
			[Token(Token = "0x4003EA5")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<string, int> reward;

			// Token: 0x04003EA6 RID: 16038
			[Token(Token = "0x4003EA6")]
			[FieldOffset(Offset = "0x40")]
			[JsonProperty(PropertyName = "hasSettleDayDoc")]
			public bool challengeModeActivated;

			// Token: 0x04003EA7 RID: 16039
			[Token(Token = "0x4003EA7")]
			[FieldOffset(Offset = "0x41")]
			public bool hasEnteredOnce;

			// Token: 0x02000BF8 RID: 3064
			[Token(Token = "0x2000BF8")]
			public enum ChallengeStatus
			{
				// Token: 0x04003EA9 RID: 16041
				[Token(Token = "0x4003EA9")]
				NOT_IN_CHALLENGE,
				// Token: 0x04003EAA RID: 16042
				[Token(Token = "0x4003EAA")]
				IN_CHALLENGE,
				// Token: 0x04003EAB RID: 16043
				[Token(Token = "0x4003EAB")]
				CHALLENGE_SETTLE,
				// Token: 0x04003EAC RID: 16044
				[Token(Token = "0x4003EAC")]
				UNDEFINED = 99
			}

			// Token: 0x02000BF9 RID: 3065
			[Token(Token = "0x2000BF9")]
			public class Current
			{
				// Token: 0x0600688D RID: 26765 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600688D")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public Current()
				{
				}

				// Token: 0x04003EAD RID: 16045
				[Token(Token = "0x4003EAD")]
				[FieldOffset(Offset = "0x10")]
				public int startDay;

				// Token: 0x04003EAE RID: 16046
				[Token(Token = "0x4003EAE")]
				[FieldOffset(Offset = "0x14")]
				public int startLoadTimes;

				// Token: 0x04003EAF RID: 16047
				[Token(Token = "0x4003EAF")]
				[FieldOffset(Offset = "0x18")]
				public int hardRatio;

				// Token: 0x04003EB0 RID: 16048
				[Token(Token = "0x4003EB0")]
				[FieldOffset(Offset = "0x1C")]
				public int enemyKill;
			}

			// Token: 0x02000BFA RID: 3066
			[Token(Token = "0x2000BFA")]
			public class History
			{
				// Token: 0x0600688E RID: 26766 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600688E")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public History()
				{
				}

				// Token: 0x04003EB1 RID: 16049
				[Token(Token = "0x4003EB1")]
				[FieldOffset(Offset = "0x10")]
				public int startDay;

				// Token: 0x04003EB2 RID: 16050
				[Token(Token = "0x4003EB2")]
				[FieldOffset(Offset = "0x14")]
				public int startLoadTimes;

				// Token: 0x04003EB3 RID: 16051
				[Token(Token = "0x4003EB3")]
				[FieldOffset(Offset = "0x18")]
				public long ts;

				// Token: 0x04003EB4 RID: 16052
				[Token(Token = "0x4003EB4")]
				[FieldOffset(Offset = "0x20")]
				public int day;
			}
		}
	}
}
