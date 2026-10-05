using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000B84 RID: 2948
	[Token(Token = "0x2000B84")]
	public class PlayerMainlineExplore
	{
		// Token: 0x06006823 RID: 26659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006823")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerMainlineExplore()
		{
		}

		// Token: 0x04003D1B RID: 15643
		[Token(Token = "0x4003D1B")]
		[FieldOffset(Offset = "0x10")]
		public PlayerMainlineExplore.PlayerExploreGameContext game;

		// Token: 0x04003D1C RID: 15644
		[Token(Token = "0x4003D1C")]
		[FieldOffset(Offset = "0x18")]
		public PlayerMainlineExplore.PlayerExploreOuterContext outer;

		// Token: 0x02000B85 RID: 2949
		[Token(Token = "0x2000B85")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum DecisionNodeType
		{
			// Token: 0x04003D1E RID: 15646
			[Token(Token = "0x4003D1E")]
			NONE,
			// Token: 0x04003D1F RID: 15647
			[Token(Token = "0x4003D1F")]
			CHECK,
			// Token: 0x04003D20 RID: 15648
			[Token(Token = "0x4003D20")]
			EVENT
		}

		// Token: 0x02000B86 RID: 2950
		[Token(Token = "0x2000B86")]
		public class PlayerExploreGameContext
		{
			// Token: 0x06006824 RID: 26660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006824")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContext()
			{
			}

			// Token: 0x04003D21 RID: 15649
			[Token(Token = "0x4003D21")]
			[FieldOffset(Offset = "0x10")]
			public PlayerMainlineExplore.PlayerExploreGameContextState state;

			// Token: 0x04003D22 RID: 15650
			[Token(Token = "0x4003D22")]
			[FieldOffset(Offset = "0x18")]
			public PlayerMainlineExplore.PlayerExploreGameContextNode node;

			// Token: 0x04003D23 RID: 15651
			[Token(Token = "0x4003D23")]
			[FieldOffset(Offset = "0x20")]
			public PlayerMainlineExplore.PlayerExploreGameContextMap map;

			// Token: 0x04003D24 RID: 15652
			[Token(Token = "0x4003D24")]
			[FieldOffset(Offset = "0x28")]
			public PlayerMainlineExplore.PlayerExploreGameContextLog log;
		}

		// Token: 0x02000B87 RID: 2951
		[Token(Token = "0x2000B87")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum GameState
		{
			// Token: 0x04003D26 RID: 15654
			[Token(Token = "0x4003D26")]
			NONE,
			// Token: 0x04003D27 RID: 15655
			[Token(Token = "0x4003D27")]
			WIN,
			// Token: 0x04003D28 RID: 15656
			[Token(Token = "0x4003D28")]
			FINISH_NODE,
			// Token: 0x04003D29 RID: 15657
			[Token(Token = "0x4003D29")]
			BLOCKING,
			// Token: 0x04003D2A RID: 15658
			[Token(Token = "0x4003D2A")]
			WAIT_CONFIRM,
			// Token: 0x04003D2B RID: 15659
			[Token(Token = "0x4003D2B")]
			FAIL
		}

		// Token: 0x02000B88 RID: 2952
		[Token(Token = "0x2000B88")]
		public class PlayerExploreGameContextState
		{
			// Token: 0x06006825 RID: 26661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006825")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContextState()
			{
			}

			// Token: 0x04003D2C RID: 15660
			[Token(Token = "0x4003D2C")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> abilities;

			// Token: 0x04003D2D RID: 15661
			[Token(Token = "0x4003D2D")]
			[FieldOffset(Offset = "0x18")]
			public string groupId;

			// Token: 0x04003D2E RID: 15662
			[Token(Token = "0x4003D2E")]
			[FieldOffset(Offset = "0x20")]
			public string groupCode;

			// Token: 0x04003D2F RID: 15663
			[Token(Token = "0x4003D2F")]
			[FieldOffset(Offset = "0x28")]
			public PlayerMainlineExplore.GameState state;

			// Token: 0x04003D30 RID: 15664
			[Token(Token = "0x4003D30")]
			[FieldOffset(Offset = "0x30")]
			public List<string> targets;

			// Token: 0x04003D31 RID: 15665
			[Token(Token = "0x4003D31")]
			[FieldOffset(Offset = "0x38")]
			public string stageId;

			// Token: 0x04003D32 RID: 15666
			[Token(Token = "0x4003D32")]
			[FieldOffset(Offset = "0x40")]
			public string nextStageId;

			// Token: 0x04003D33 RID: 15667
			[Token(Token = "0x4003D33")]
			[FieldOffset(Offset = "0x48")]
			public int stageNodeIndex;

			// Token: 0x04003D34 RID: 15668
			[Token(Token = "0x4003D34")]
			[FieldOffset(Offset = "0x50")]
			public string blockStageId;

			// Token: 0x04003D35 RID: 15669
			[Token(Token = "0x4003D35")]
			[FieldOffset(Offset = "0x58")]
			public List<string> broadCast;

			// Token: 0x04003D36 RID: 15670
			[Token(Token = "0x4003D36")]
			[FieldOffset(Offset = "0x60")]
			public long startTs;
		}

		// Token: 0x02000B89 RID: 2953
		[Token(Token = "0x2000B89")]
		public class PlayerExploreGameContextNode
		{
			// Token: 0x06006826 RID: 26662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006826")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContextNode()
			{
			}

			// Token: 0x04003D37 RID: 15671
			[Token(Token = "0x4003D37")]
			[FieldOffset(Offset = "0x10")]
			public PlayerMainlineExplore.DecisionNodeType type;

			// Token: 0x04003D38 RID: 15672
			[Token(Token = "0x4003D38")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty("event")]
			public PlayerMainlineExplore.PlayerExploreGameContextNodeEvent nodeEvent;
		}

		// Token: 0x02000B8A RID: 2954
		[Token(Token = "0x2000B8A")]
		public class PlayerExploreGameContextNodeEvent
		{
			// Token: 0x06006827 RID: 26663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006827")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContextNodeEvent()
			{
			}

			// Token: 0x04003D39 RID: 15673
			[Token(Token = "0x4003D39")]
			[FieldOffset(Offset = "0x10")]
			public List<string> events;

			// Token: 0x04003D3A RID: 15674
			[Token(Token = "0x4003D3A")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerMainlineExplore.PlayerExploreGameContextNodeEventChoice> choices;
		}

		// Token: 0x02000B8B RID: 2955
		[Token(Token = "0x2000B8B")]
		public class PlayerExploreGameContextNodeEventChoice
		{
			// Token: 0x06006828 RID: 26664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006828")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContextNodeEventChoice()
			{
			}

			// Token: 0x04003D3B RID: 15675
			[Token(Token = "0x4003D3B")]
			[FieldOffset(Offset = "0x10")]
			public string eventId;

			// Token: 0x04003D3C RID: 15676
			[Token(Token = "0x4003D3C")]
			[FieldOffset(Offset = "0x18")]
			public string choiceId;

			// Token: 0x04003D3D RID: 15677
			[Token(Token = "0x4003D3D")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, int> abilitiesDelta;

			// Token: 0x04003D3E RID: 15678
			[Token(Token = "0x4003D3E")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, int> abilitiesCondition;

			// Token: 0x04003D3F RID: 15679
			[Token(Token = "0x4003D3F")]
			[FieldOffset(Offset = "0x30")]
			public float successRate;
		}

		// Token: 0x02000B8C RID: 2956
		[Token(Token = "0x2000B8C")]
		public class PlayerExploreGameContextMap
		{
			// Token: 0x06006829 RID: 26665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006829")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContextMap()
			{
			}

			// Token: 0x04003D40 RID: 15680
			[Token(Token = "0x4003D40")]
			[FieldOffset(Offset = "0x10")]
			public PlayerMainlineExplore.PlayerExploreGameContextMapDisplay display;
		}

		// Token: 0x02000B8D RID: 2957
		[Token(Token = "0x2000B8D")]
		public class PlayerExploreGameContextMapDisplay
		{
			// Token: 0x0600682A RID: 26666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600682A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContextMapDisplay()
			{
			}

			// Token: 0x04003D41 RID: 15681
			[Token(Token = "0x4003D41")]
			[FieldOffset(Offset = "0x10")]
			public int nodeSeed;

			// Token: 0x04003D42 RID: 15682
			[Token(Token = "0x4003D42")]
			[FieldOffset(Offset = "0x14")]
			public int pathSeed;

			// Token: 0x04003D43 RID: 15683
			[Token(Token = "0x4003D43")]
			[FieldOffset(Offset = "0x18")]
			public List<PlayerMainlineExplore.PlayerExploreGameContextMapControlPoint> controlPoints;
		}

		// Token: 0x02000B8E RID: 2958
		[Token(Token = "0x2000B8E")]
		public class PlayerExploreGameContextMapControlPoint
		{
			// Token: 0x0600682B RID: 26667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600682B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContextMapControlPoint()
			{
			}

			// Token: 0x04003D44 RID: 15684
			[Token(Token = "0x4003D44")]
			[FieldOffset(Offset = "0x10")]
			public string stageId;

			// Token: 0x04003D45 RID: 15685
			[Token(Token = "0x4003D45")]
			[FieldOffset(Offset = "0x18")]
			public PlayerMainlineExplore.PlayerPosition pos;
		}

		// Token: 0x02000B8F RID: 2959
		[Token(Token = "0x2000B8F")]
		public class PlayerPosition
		{
			// Token: 0x0600682C RID: 26668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600682C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerPosition()
			{
			}

			// Token: 0x04003D46 RID: 15686
			[Token(Token = "0x4003D46")]
			[FieldOffset(Offset = "0x10")]
			public int x;

			// Token: 0x04003D47 RID: 15687
			[Token(Token = "0x4003D47")]
			[FieldOffset(Offset = "0x14")]
			public int y;
		}

		// Token: 0x02000B90 RID: 2960
		[Token(Token = "0x2000B90")]
		public class PlayerExploreGameContextLog
		{
			// Token: 0x0600682D RID: 26669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600682D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameContextLog()
			{
			}

			// Token: 0x04003D48 RID: 15688
			[Token(Token = "0x4003D48")]
			[FieldOffset(Offset = "0x10")]
			public List<string> passEvents;

			// Token: 0x04003D49 RID: 15689
			[Token(Token = "0x4003D49")]
			[FieldOffset(Offset = "0x18")]
			public List<string> passTargets;
		}

		// Token: 0x02000B91 RID: 2961
		[Token(Token = "0x2000B91")]
		public class PlayerExploreOuterContext
		{
			// Token: 0x0600682E RID: 26670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600682E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreOuterContext()
			{
			}

			// Token: 0x04003D4A RID: 15690
			[Token(Token = "0x4003D4A")]
			[FieldOffset(Offset = "0x10")]
			public bool isOpen;

			// Token: 0x04003D4B RID: 15691
			[Token(Token = "0x4003D4B")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerMainlineExplore.PlayerExploreOuterContextMissionState> mission;

			// Token: 0x04003D4C RID: 15692
			[Token(Token = "0x4003D4C")]
			[FieldOffset(Offset = "0x20")]
			public PlayerMainlineExplore.PlayerExploreGameResult lastGameResult;

			// Token: 0x04003D4D RID: 15693
			[Token(Token = "0x4003D4D")]
			[FieldOffset(Offset = "0x28")]
			public List<PlayerMainlineExplore.PlayerExploreOuterContextHistoryPath> historyPaths;
		}

		// Token: 0x02000B92 RID: 2962
		[Token(Token = "0x2000B92")]
		public class PlayerExploreGameResult
		{
			// Token: 0x0600682F RID: 26671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600682F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreGameResult()
			{
			}

			// Token: 0x04003D4E RID: 15694
			[Token(Token = "0x4003D4E")]
			[FieldOffset(Offset = "0x10")]
			public string groupId;

			// Token: 0x04003D4F RID: 15695
			[Token(Token = "0x4003D4F")]
			[FieldOffset(Offset = "0x18")]
			public string groupCode;

			// Token: 0x04003D50 RID: 15696
			[Token(Token = "0x4003D50")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, int> heritageAbilities;
		}

		// Token: 0x02000B93 RID: 2963
		[Token(Token = "0x2000B93")]
		public class PlayerExploreOuterContextMissionState
		{
			// Token: 0x06006830 RID: 26672 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006830")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreOuterContextMissionState()
			{
			}

			// Token: 0x04003D51 RID: 15697
			[Token(Token = "0x4003D51")]
			[FieldOffset(Offset = "0x10")]
			public int state;

			// Token: 0x04003D52 RID: 15698
			[Token(Token = "0x4003D52")]
			[FieldOffset(Offset = "0x18")]
			public List<int> progress;
		}

		// Token: 0x02000B94 RID: 2964
		[Token(Token = "0x2000B94")]
		public class PlayerExploreOuterContextHistoryPath
		{
			// Token: 0x06006831 RID: 26673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006831")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerExploreOuterContextHistoryPath()
			{
			}

			// Token: 0x04003D53 RID: 15699
			[Token(Token = "0x4003D53")]
			[FieldOffset(Offset = "0x10")]
			public bool success;

			// Token: 0x04003D54 RID: 15700
			[Token(Token = "0x4003D54")]
			[FieldOffset(Offset = "0x18")]
			public PlayerMainlineExplore.PlayerExploreGameContextMapDisplay path;
		}
	}
}
