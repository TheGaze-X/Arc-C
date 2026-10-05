using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AB8 RID: 2744
	[Token(Token = "0x2000AB8")]
	public class PlayerRoguelike
	{
		// Token: 0x06006775 RID: 26485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006775")]
		[Address(RVA = "0x1EFD2A0", Offset = "0x1EFBEA0", VA = "0x181EFD2A0")]
		public PlayerRoguelike()
		{
		}

		// Token: 0x040039DB RID: 14811
		[Token(Token = "0x40039DB")]
		[FieldOffset(Offset = "0x10")]
		public PlayerRoguelike.CurrentData current;

		// Token: 0x040039DC RID: 14812
		[Token(Token = "0x40039DC")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRoguelike.StableData stable;

		// Token: 0x02000AB9 RID: 2745
		[Token(Token = "0x2000AB9")]
		public class CurrentData
		{
			// Token: 0x06006776 RID: 26486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006776")]
			[Address(RVA = "0x1EE8B50", Offset = "0x1EE7750", VA = "0x181EE8B50")]
			public CurrentData()
			{
			}

			// Token: 0x040039DD RID: 14813
			[Token(Token = "0x40039DD")]
			[FieldOffset(Offset = "0x10")]
			public PlayerRoguelikeStatus status;

			// Token: 0x040039DE RID: 14814
			[Token(Token = "0x40039DE")]
			[FieldOffset(Offset = "0x18")]
			public PlayerRoguelikeInitialReward initialRewards;

			// Token: 0x040039DF RID: 14815
			[Token(Token = "0x40039DF")]
			[FieldOffset(Offset = "0x20")]
			public PlayerRoguelikeDungeon map;

			// Token: 0x040039E0 RID: 14816
			[Token(Token = "0x40039E0")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, PlayerRoguelikeItem> inventory;

			// Token: 0x040039E1 RID: 14817
			[Token(Token = "0x40039E1")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, PlayerRoguelikeCharacter> chars;

			// Token: 0x040039E2 RID: 14818
			[Token(Token = "0x40039E2")]
			[FieldOffset(Offset = "0x38")]
			public PlayerRoguelikeRecord record;
		}

		// Token: 0x02000ABA RID: 2746
		[Token(Token = "0x2000ABA")]
		public class StableData
		{
			// Token: 0x06006777 RID: 26487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006777")]
			[Address(RVA = "0x1F01EE0", Offset = "0x1F00AE0", VA = "0x181F01EE0")]
			public StableData()
			{
			}

			// Token: 0x040039E3 RID: 14819
			[Token(Token = "0x40039E3")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> outBuff;

			// Token: 0x040039E4 RID: 14820
			[Token(Token = "0x40039E4")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, PlayerRoguelike.StableData.RelicRecord> relic;

			// Token: 0x040039E5 RID: 14821
			[Token(Token = "0x40039E5")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, PlayerRoguelike.StableData.StageRecord> stages;

			// Token: 0x040039E6 RID: 14822
			[Token(Token = "0x40039E6")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, PlayerRoguelike.StableData.EndingRecord> ending;

			// Token: 0x040039E7 RID: 14823
			[Token(Token = "0x40039E7")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<string, PlayerRoguelike.StableData.ModeRecord> mode;

			// Token: 0x040039E8 RID: 14824
			[Token(Token = "0x40039E8")]
			[FieldOffset(Offset = "0x38")]
			public PlayerRoguelike.StableData.StatsRecords stats;

			// Token: 0x02000ABB RID: 2747
			[Token(Token = "0x2000ABB")]
			public class RelicRecord
			{
				// Token: 0x06006778 RID: 26488 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006778")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public RelicRecord()
				{
				}

				// Token: 0x040039E9 RID: 14825
				[Token(Token = "0x40039E9")]
				[FieldOffset(Offset = "0x10")]
				public long uts;

				// Token: 0x040039EA RID: 14826
				[Token(Token = "0x40039EA")]
				[FieldOffset(Offset = "0x18")]
				public int cnt;
			}

			// Token: 0x02000ABC RID: 2748
			[Token(Token = "0x2000ABC")]
			public class StageRecord
			{
				// Token: 0x06006779 RID: 26489 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006779")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public StageRecord()
				{
				}

				// Token: 0x040039EB RID: 14827
				[Token(Token = "0x40039EB")]
				[FieldOffset(Offset = "0x10")]
				public int count;
			}

			// Token: 0x02000ABD RID: 2749
			[Token(Token = "0x2000ABD")]
			public class EndingRecord
			{
				// Token: 0x0600677A RID: 26490 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600677A")]
				[Address(RVA = "0x1EEA030", Offset = "0x1EE8C30", VA = "0x181EEA030")]
				public EndingRecord()
				{
				}

				// Token: 0x040039EC RID: 14828
				[Token(Token = "0x40039EC")]
				[FieldOffset(Offset = "0x10")]
				public int cnt;

				// Token: 0x040039ED RID: 14829
				[Token(Token = "0x40039ED")]
				[FieldOffset(Offset = "0x18")]
				public Dictionary<string, int> initialRelic;
			}

			// Token: 0x02000ABE RID: 2750
			[Token(Token = "0x2000ABE")]
			public class ModeRecord
			{
				// Token: 0x0600677B RID: 26491 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600677B")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ModeRecord()
				{
				}

				// Token: 0x040039EE RID: 14830
				[Token(Token = "0x40039EE")]
				[FieldOffset(Offset = "0x10")]
				public int uts;

				// Token: 0x040039EF RID: 14831
				[Token(Token = "0x40039EF")]
				[FieldOffset(Offset = "0x14")]
				public int cnt;
			}

			// Token: 0x02000ABF RID: 2751
			[Token(Token = "0x2000ABF")]
			public class StatsRecords
			{
				// Token: 0x0600677C RID: 26492 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600677C")]
				[Address(RVA = "0x1F02340", Offset = "0x1F00F40", VA = "0x181F02340")]
				public StatsRecords()
				{
				}

				// Token: 0x040039F0 RID: 14832
				[Token(Token = "0x40039F0")]
				[FieldOffset(Offset = "0x10")]
				public int complete_battle;

				// Token: 0x040039F1 RID: 14833
				[Token(Token = "0x40039F1")]
				[FieldOffset(Offset = "0x14")]
				public int cost_hp;

				// Token: 0x040039F2 RID: 14834
				[Token(Token = "0x40039F2")]
				[FieldOffset(Offset = "0x18")]
				public int recruit_char;

				// Token: 0x040039F3 RID: 14835
				[Token(Token = "0x40039F3")]
				[FieldOffset(Offset = "0x1C")]
				public int into_node_nobattle;

				// Token: 0x040039F4 RID: 14836
				[Token(Token = "0x40039F4")]
				[FieldOffset(Offset = "0x20")]
				public int shop_cost_gold;

				// Token: 0x040039F5 RID: 14837
				[Token(Token = "0x40039F5")]
				[FieldOffset(Offset = "0x24")]
				public int upgrade_char;

				// Token: 0x040039F6 RID: 14838
				[Token(Token = "0x40039F6")]
				[FieldOffset(Offset = "0x28")]
				public Dictionary<string, int> enemy_kill;

				// Token: 0x040039F7 RID: 14839
				[Token(Token = "0x40039F7")]
				[FieldOffset(Offset = "0x30")]
				public Dictionary<string, int> gain_resource;

				// Token: 0x040039F8 RID: 14840
				[Token(Token = "0x40039F8")]
				[FieldOffset(Offset = "0x38")]
				public Dictionary<string, int> scene_count;

				// Token: 0x040039F9 RID: 14841
				[Token(Token = "0x40039F9")]
				[FieldOffset(Offset = "0x40")]
				public Dictionary<string, int> choice_count;
			}
		}
	}
}
