using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.Battle.Sandbox;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004448 RID: 17480
	[Token(Token = "0x2004448")]
	public class SandboxV2BattleStartControllerPlugin : BattleStartController.IPlugin
	{
		// Token: 0x0601AB69 RID: 109417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB69")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public SandboxV2BattleStartControllerPlugin(SandboxV2BattleStartControllerPlugin.Param param)
		{
		}

		// Token: 0x0601AB6A RID: 109418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB6A")]
		[Address(RVA = "0x13DF760", Offset = "0x13DE360", VA = "0x1813DF760", Slot = "4")]
		public void OverrideInParams(ref BattleInOut.InParams inParams, CommonStartBattleResponse response)
		{
		}

		// Token: 0x0601AB6B RID: 109419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB6B")]
		[Address(RVA = "0x13E1DE0", Offset = "0x13E09E0", VA = "0x1813E1DE0")]
		private static void _ParseMonthlyNode(SandboxInput sandboxMeta, SandboxV2MonthRushData data)
		{
		}

		// Token: 0x0601AB6C RID: 109420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB6C")]
		[Address(RVA = "0x13E2000", Offset = "0x13E0C00", VA = "0x1813E2000")]
		private static void _ParseNormalNode(PlayerSandboxV2.Dungeon dungeon, SandboxInput sandboxMeta, PlayerSandboxV2 playerSandboxV2, SandboxV2Data gameData, string nodeId)
		{
		}

		// Token: 0x0601AB6D RID: 109421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB6D")]
		[Address(RVA = "0x13E3A90", Offset = "0x13E2690", VA = "0x1813E3A90")]
		private static void _ParseSelectionNode(SandboxInput sandboxMeta, PlayerSandboxV2 playerSandboxV2, SandboxV2Data gameData, SandboxV2BattleStartResponse response)
		{
		}

		// Token: 0x0601AB6E RID: 109422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB6E")]
		[Address(RVA = "0x13E1920", Offset = "0x13E0520", VA = "0x1813E1920")]
		private static void _ParseLureInsects(List<string> lureInsect, SandboxInput input, SandboxV2Data gameData)
		{
		}

		// Token: 0x0601AB6F RID: 109423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB6F")]
		[Address(RVA = "0x13E0480", Offset = "0x13DF080", VA = "0x1813E0480")]
		private static void _ParseCollectItems(SandboxInput input, PlayerSandboxV2 playerSandboxV2)
		{
		}

		// Token: 0x0601AB70 RID: 109424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB70")]
		[Address(RVA = "0x13E3280", Offset = "0x13E1E80", VA = "0x1813E3280")]
		private static void _ParseRiftData(SandboxInput input, PlayerSandboxV2 playerSandboxV2)
		{
		}

		// Token: 0x0601AB71 RID: 109425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB71")]
		[Address(RVA = "0x13E3370", Offset = "0x13E1F70", VA = "0x1813E3370")]
		private static void _ParseRushEnemies(PlayerSandboxV2.Dungeon dungeon, SandboxInput input, PlayerSandboxV2 playerSandboxV2, SandboxV2Data gameData, string nodeId)
		{
		}

		// Token: 0x0601AB72 RID: 109426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB72")]
		[Address(RVA = "0x13E2EC0", Offset = "0x13E1AC0", VA = "0x1813E2EC0")]
		private static void _ParseRareAnimals(PlayerSandboxV2.Dungeon dungeon, SandboxInput input, string nodeId)
		{
		}

		// Token: 0x0601AB73 RID: 109427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB73")]
		[Address(RVA = "0x13E18C0", Offset = "0x13E04C0", VA = "0x1813E18C0")]
		private static void _ParseLevelActions(SandboxInput input, PlayerSandboxV2.Dungeon.NodeStage nodeStage)
		{
		}

		// Token: 0x0601AB74 RID: 109428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB74")]
		[Address(RVA = "0x13E0CF0", Offset = "0x13DF8F0", VA = "0x1813E0CF0")]
		private static void _ParseEntityStatus(SandboxInput input, PlayerSandboxV2.Dungeon.NodeStage nodeStage)
		{
		}

		// Token: 0x0601AB75 RID: 109429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB75")]
		[Address(RVA = "0x13E2D90", Offset = "0x13E1990", VA = "0x1813E2D90")]
		private static void _ParsePlacedItems(SandboxInput input, PlayerSandboxV2.Dungeon.NodeStage nodeStage)
		{
		}

		// Token: 0x0601AB76 RID: 109430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB76")]
		[Address(RVA = "0x13E2050", Offset = "0x13E0C50", VA = "0x1813E2050")]
		private static void _ParseNpc(SandboxInput input, List<PlayerSandboxV2.Dungeon.NpcGroup.Npc> npcs, SandboxV2Data data, Dictionary<string, int> favor)
		{
		}

		// Token: 0x0601AB77 RID: 109431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB77")]
		[Address(RVA = "0x13E1440", Offset = "0x13E0040", VA = "0x1813E1440")]
		private static void _ParseIdInCompleteProgressCount(SandboxInput input, PlayerSandboxV2.Dungeon.NodeStage nodeStage)
		{
		}

		// Token: 0x0601AB78 RID: 109432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AB78")]
		[Address(RVA = "0x13E0440", Offset = "0x13DF040", VA = "0x1813E0440")]
		private static void _ParseAvgToTrigger(SandboxInput input, string topicId)
		{
		}

		// Token: 0x040221E6 RID: 139750
		[Token(Token = "0x40221E6")]
		[FieldOffset(Offset = "0x10")]
		private SandboxV2BattleStartControllerPlugin.Param m_param;

		// Token: 0x02004449 RID: 17481
		[Token(Token = "0x2004449")]
		public class Param
		{
			// Token: 0x0601AB79 RID: 109433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AB79")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040221E7 RID: 139751
			[Token(Token = "0x40221E7")]
			[FieldOffset(Offset = "0x10")]
			public List<int> squadInstIds;
		}
	}
}
