using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A76 RID: 10870
	[Token(Token = "0x2002A76")]
	public class SandboxInput : IHotfixable
	{
		// Token: 0x0601211E RID: 74014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601211E")]
		[Address(RVA = "0xA2CA90", Offset = "0xA2B690", VA = "0x180A2CA90")]
		public SandboxInput()
		{
		}

		// Token: 0x040146AA RID: 83626
		[Token(Token = "0x40146AA")]
		[FieldOffset(Offset = "0x10")]
		public string exploredMap;

		// Token: 0x040146AB RID: 83627
		[Token(Token = "0x40146AB")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x040146AC RID: 83628
		[Token(Token = "0x40146AC")]
		[FieldOffset(Offset = "0x20")]
		public int currentAp;

		// Token: 0x040146AD RID: 83629
		[Token(Token = "0x40146AD")]
		[FieldOffset(Offset = "0x24")]
		public int baseLv;

		// Token: 0x040146AE RID: 83630
		[Token(Token = "0x40146AE")]
		[FieldOffset(Offset = "0x28")]
		public string monthlyRushId;

		// Token: 0x040146AF RID: 83631
		[Token(Token = "0x40146AF")]
		[FieldOffset(Offset = "0x30")]
		public List<string> bossKill;

		// Token: 0x040146B0 RID: 83632
		[Token(Token = "0x40146B0")]
		[FieldOffset(Offset = "0x38")]
		public List<SandboxEntityStatus> entityStatus;

		// Token: 0x040146B1 RID: 83633
		[Token(Token = "0x40146B1")]
		[FieldOffset(Offset = "0x40")]
		public List<SandboxPlacedItemStatus> placedItems;

		// Token: 0x040146B2 RID: 83634
		[Token(Token = "0x40146B2")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, int> constructItems;

		// Token: 0x040146B3 RID: 83635
		[Token(Token = "0x40146B3")]
		[FieldOffset(Offset = "0x50")]
		public List<RushEnemy> rushEnemies;

		// Token: 0x040146B4 RID: 83636
		[Token(Token = "0x40146B4")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, Dictionary<string, SandboxRushBossStatus>> bossStatus;

		// Token: 0x040146B5 RID: 83637
		[Token(Token = "0x40146B5")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, int> resCollected;

		// Token: 0x040146B6 RID: 83638
		[Token(Token = "0x40146B6")]
		[FieldOffset(Offset = "0x68")]
		public List<RushEnemy> luredRacers;

		// Token: 0x040146B7 RID: 83639
		[Token(Token = "0x40146B7")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<int, Dictionary<string, int>> catchedAnimals;

		// Token: 0x040146B8 RID: 83640
		[Token(Token = "0x40146B8")]
		[FieldOffset(Offset = "0x78")]
		public ListDict<string, RushEnemy> rareAnimals;

		// Token: 0x040146B9 RID: 83641
		[Token(Token = "0x40146B9")]
		[FieldOffset(Offset = "0x80")]
		public List<List<int>> action;

		// Token: 0x040146BA RID: 83642
		[Token(Token = "0x40146BA")]
		[FieldOffset(Offset = "0x88")]
		public List<List<int>> actionKill;

		// Token: 0x040146BB RID: 83643
		[Token(Token = "0x40146BB")]
		[FieldOffset(Offset = "0x90")]
		public SandboxInput.RiftData riftData;

		// Token: 0x040146BC RID: 83644
		[Token(Token = "0x40146BC")]
		[FieldOffset(Offset = "0x98")]
		public bool escapeTrap;

		// Token: 0x040146BD RID: 83645
		[Token(Token = "0x40146BD")]
		[FieldOffset(Offset = "0xA0")]
		public List<NpcBattleInput> npcDatas;

		// Token: 0x040146BE RID: 83646
		[Token(Token = "0x40146BE")]
		[FieldOffset(Offset = "0xA8")]
		public Dictionary<string, int> conditionProgress;

		// Token: 0x040146BF RID: 83647
		[Token(Token = "0x40146BF")]
		[FieldOffset(Offset = "0xB0")]
		public Dictionary<string, int> npcFavor;

		// Token: 0x040146C0 RID: 83648
		[Token(Token = "0x40146C0")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<string, int> globalBuilding;

		// Token: 0x040146C1 RID: 83649
		[Token(Token = "0x40146C1")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<string, int> buildingLimit;

		// Token: 0x040146C2 RID: 83650
		[Token(Token = "0x40146C2")]
		[FieldOffset(Offset = "0xC8")]
		public SandboxInput.SandboxV2NodeRelatedData nodeRelatedData;

		// Token: 0x040146C3 RID: 83651
		[Token(Token = "0x40146C3")]
		[FieldOffset(Offset = "0xD0")]
		public List<string> storyIds;

		// Token: 0x040146C4 RID: 83652
		[Token(Token = "0x40146C4")]
		[FieldOffset(Offset = "0xD8")]
		public Dictionary<string, int> shinyAnimals;

		// Token: 0x040146C5 RID: 83653
		[Token(Token = "0x40146C5")]
		[FieldOffset(Offset = "0xE0")]
		public List<string> shinyUniEnemy;

		// Token: 0x040146C6 RID: 83654
		[Token(Token = "0x40146C6")]
		[FieldOffset(Offset = "0xE8")]
		public int remainingRacerItemSpace;

		// Token: 0x040146C7 RID: 83655
		[Token(Token = "0x40146C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A77 RID: 10871
		[Token(Token = "0x2002A77")]
		public class SandboxV2NodeRelatedData
		{
			// Token: 0x0601211F RID: 74015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601211F")]
			[Address(RVA = "0xA343E0", Offset = "0xA32FE0", VA = "0x180A343E0")]
			public SandboxV2NodeRelatedData()
			{
			}

			// Token: 0x040146C8 RID: 83656
			[Token(Token = "0x40146C8")]
			[FieldOffset(Offset = "0x10")]
			public string nodeStageId;

			// Token: 0x040146C9 RID: 83657
			[Token(Token = "0x40146C9")]
			[FieldOffset(Offset = "0x18")]
			public string nodeStageName;

			// Token: 0x040146CA RID: 83658
			[Token(Token = "0x40146CA")]
			[FieldOffset(Offset = "0x20")]
			public string nodeId;

			// Token: 0x040146CB RID: 83659
			[Token(Token = "0x40146CB")]
			[FieldOffset(Offset = "0x28")]
			public SandboxV2NodeType nodeType;

			// Token: 0x040146CC RID: 83660
			[Token(Token = "0x40146CC")]
			[FieldOffset(Offset = "0x2C")]
			public SandboxV2SeasonType nodeSeasonType;

			// Token: 0x040146CD RID: 83661
			[Token(Token = "0x40146CD")]
			[FieldOffset(Offset = "0x30")]
			public string nodeWeatherId;

			// Token: 0x040146CE RID: 83662
			[Token(Token = "0x40146CE")]
			[FieldOffset(Offset = "0x38")]
			public List<string> idInCompleteProgressCount;
		}

		// Token: 0x02002A78 RID: 10872
		[Token(Token = "0x2002A78")]
		public class RiftData
		{
			// Token: 0x06012120 RID: 74016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012120")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RiftData()
			{
			}

			// Token: 0x040146CF RID: 83663
			[Token(Token = "0x40146CF")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> reserveTimes;

			// Token: 0x040146D0 RID: 83664
			[Token(Token = "0x40146D0")]
			[FieldOffset(Offset = "0x18")]
			public string riftId;
		}
	}
}
