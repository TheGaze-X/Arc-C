using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200116E RID: 4462
	[Token(Token = "0x200116E")]
	public class RoguelikeConstTable
	{
		// Token: 0x06006F5C RID: 28508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5C")]
		[Address(RVA = "0x2110B40", Offset = "0x210F740", VA = "0x182110B40")]
		public RoguelikeConstTable()
		{
		}

		// Token: 0x04005F9D RID: 24477
		[Token(Token = "0x4005F9D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, RoguelikeConstTable.PlayerLevelData> playerLevelTable;

		// Token: 0x04005F9E RID: 24478
		[Token(Token = "0x4005F9E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, RoguelikeConstTable.RecruitData> recruitPopulationTable;

		// Token: 0x04005F9F RID: 24479
		[Token(Token = "0x4005F9F")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, RoguelikeConstTable.CharUpgradeData> charUpgradeTable;

		// Token: 0x04005FA0 RID: 24480
		[Token(Token = "0x4005FA0")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<RoguelikeEventType, RoguelikeConstTable.EventTypeData> eventTypeTable;

		// Token: 0x04005FA1 RID: 24481
		[Token(Token = "0x4005FA1")]
		[FieldOffset(Offset = "0x30")]
		public List<string> shopDialogs;

		// Token: 0x04005FA2 RID: 24482
		[Token(Token = "0x4005FA2")]
		[FieldOffset(Offset = "0x38")]
		public List<string> shopRelicDialogs;

		// Token: 0x04005FA3 RID: 24483
		[Token(Token = "0x4005FA3")]
		[FieldOffset(Offset = "0x40")]
		public List<string> shopTicketDialogs;

		// Token: 0x04005FA4 RID: 24484
		[Token(Token = "0x4005FA4")]
		[FieldOffset(Offset = "0x48")]
		public List<string> mimicEnemyIds;

		// Token: 0x04005FA5 RID: 24485
		[Token(Token = "0x4005FA5")]
		[FieldOffset(Offset = "0x50")]
		public List<int> clearZoneScores;

		// Token: 0x04005FA6 RID: 24486
		[Token(Token = "0x4005FA6")]
		[FieldOffset(Offset = "0x58")]
		public int moveToNodeScore;

		// Token: 0x04005FA7 RID: 24487
		[Token(Token = "0x4005FA7")]
		[FieldOffset(Offset = "0x5C")]
		public int clearNormalBattleScore;

		// Token: 0x04005FA8 RID: 24488
		[Token(Token = "0x4005FA8")]
		[FieldOffset(Offset = "0x60")]
		public int clearEliteBattleScore;

		// Token: 0x04005FA9 RID: 24489
		[Token(Token = "0x4005FA9")]
		[FieldOffset(Offset = "0x64")]
		public int clearBossBattleScore;

		// Token: 0x04005FAA RID: 24490
		[Token(Token = "0x4005FAA")]
		[FieldOffset(Offset = "0x68")]
		public int gainRelicScore;

		// Token: 0x04005FAB RID: 24491
		[Token(Token = "0x4005FAB")]
		[FieldOffset(Offset = "0x6C")]
		public int gainCharacterScore;

		// Token: 0x04005FAC RID: 24492
		[Token(Token = "0x4005FAC")]
		[FieldOffset(Offset = "0x70")]
		public int unlockRelicSpecialScore;

		// Token: 0x04005FAD RID: 24493
		[Token(Token = "0x4005FAD")]
		[FieldOffset(Offset = "0x74")]
		public int squadCapacityMax;

		// Token: 0x04005FAE RID: 24494
		[Token(Token = "0x4005FAE")]
		[FieldOffset(Offset = "0x78")]
		public List<string> bossIds;

		// Token: 0x0200116F RID: 4463
		[Token(Token = "0x200116F")]
		public class PlayerLevelData
		{
			// Token: 0x06006F5D RID: 28509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F5D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerLevelData()
			{
			}

			// Token: 0x04005FAF RID: 24495
			[Token(Token = "0x4005FAF")]
			[FieldOffset(Offset = "0x10")]
			public int exp;

			// Token: 0x04005FB0 RID: 24496
			[Token(Token = "0x4005FB0")]
			[FieldOffset(Offset = "0x14")]
			public int populationUp;

			// Token: 0x04005FB1 RID: 24497
			[Token(Token = "0x4005FB1")]
			[FieldOffset(Offset = "0x18")]
			public int squadCapacityUp;

			// Token: 0x04005FB2 RID: 24498
			[Token(Token = "0x4005FB2")]
			[FieldOffset(Offset = "0x1C")]
			public int battleCharLimitUp;
		}

		// Token: 0x02001170 RID: 4464
		[Token(Token = "0x2001170")]
		public class RecruitData
		{
			// Token: 0x06006F5E RID: 28510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F5E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RecruitData()
			{
			}

			// Token: 0x04005FB3 RID: 24499
			[Token(Token = "0x4005FB3")]
			[FieldOffset(Offset = "0x10")]
			public int recruitPopulation;

			// Token: 0x04005FB4 RID: 24500
			[Token(Token = "0x4005FB4")]
			[FieldOffset(Offset = "0x14")]
			public int upgradePopulation;
		}

		// Token: 0x02001171 RID: 4465
		[Token(Token = "0x2001171")]
		public class CharUpgradeData
		{
			// Token: 0x06006F5F RID: 28511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F5F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CharUpgradeData()
			{
			}

			// Token: 0x04005FB5 RID: 24501
			[Token(Token = "0x4005FB5")]
			[FieldOffset(Offset = "0x10")]
			public EvolvePhase evolvePhase;

			// Token: 0x04005FB6 RID: 24502
			[Token(Token = "0x4005FB6")]
			[FieldOffset(Offset = "0x14")]
			public int skillLevel;

			// Token: 0x04005FB7 RID: 24503
			[Token(Token = "0x4005FB7")]
			[FieldOffset(Offset = "0x18")]
			public int skillSpecializeLevel;
		}

		// Token: 0x02001172 RID: 4466
		[Token(Token = "0x2001172")]
		public class EventTypeData
		{
			// Token: 0x06006F60 RID: 28512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F60")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EventTypeData()
			{
			}

			// Token: 0x04005FB8 RID: 24504
			[Token(Token = "0x4005FB8")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04005FB9 RID: 24505
			[Token(Token = "0x4005FB9")]
			[FieldOffset(Offset = "0x18")]
			public string description;
		}
	}
}
