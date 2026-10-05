using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A7C RID: 10876
	[Token(Token = "0x2002A7C")]
	public class SandboxOutput : IHotfixable
	{
		// Token: 0x06012124 RID: 74020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012124")]
		[Address(RVA = "0xA33810", Offset = "0xA32410", VA = "0x180A33810")]
		public SandboxOutput()
		{
		}

		// Token: 0x040146DE RID: 83678
		[Token(Token = "0x40146DE")]
		[FieldOffset(Offset = "0x10")]
		public string exploredMap;

		// Token: 0x040146DF RID: 83679
		[Token(Token = "0x40146DF")]
		[FieldOffset(Offset = "0x18")]
		public List<List<int>> killedEnemies;

		// Token: 0x040146E0 RID: 83680
		[Token(Token = "0x40146E0")]
		[FieldOffset(Offset = "0x20")]
		public List<string> huntedUniEnemies;

		// Token: 0x040146E1 RID: 83681
		[Token(Token = "0x40146E1")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, List<int>> rushEnemies;

		// Token: 0x040146E2 RID: 83682
		[Token(Token = "0x40146E2")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<int, Dictionary<string, int>> catchedAnimals;

		// Token: 0x040146E3 RID: 83683
		[Token(Token = "0x40146E3")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, int> caughtRacers;

		// Token: 0x040146E4 RID: 83684
		[Token(Token = "0x40146E4")]
		[FieldOffset(Offset = "0x40")]
		public int usedLure;

		// Token: 0x040146E5 RID: 83685
		[Token(Token = "0x40146E5")]
		[FieldOffset(Offset = "0x48")]
		public List<SandboxEntityStatus> entityStatus;

		// Token: 0x040146E6 RID: 83686
		[Token(Token = "0x40146E6")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, Dictionary<string, SandboxRushBossStatus>> bossStatus;

		// Token: 0x040146E7 RID: 83687
		[Token(Token = "0x40146E7")]
		[FieldOffset(Offset = "0x58")]
		public List<SandboxPlacedItemStatus> placedItems;

		// Token: 0x040146E8 RID: 83688
		[Token(Token = "0x40146E8")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, int> constructItems;

		// Token: 0x040146E9 RID: 83689
		[Token(Token = "0x40146E9")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, int> entityDroppedThisLevel;

		// Token: 0x040146EA RID: 83690
		[Token(Token = "0x40146EA")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<int, Dictionary<string, int>> enemyDeathDetail;

		// Token: 0x040146EB RID: 83691
		[Token(Token = "0x40146EB")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, int> uniEnemyDeathDetail;

		// Token: 0x040146EC RID: 83692
		[Token(Token = "0x40146EC")]
		[FieldOffset(Offset = "0x80")]
		public readonly Dictionary<string, Dictionary<string, int>> enemyEvents;

		// Token: 0x040146ED RID: 83693
		[Token(Token = "0x40146ED")]
		[FieldOffset(Offset = "0x88")]
		public List<string> messengerReachExitUids;

		// Token: 0x040146EE RID: 83694
		[Token(Token = "0x40146EE")]
		[FieldOffset(Offset = "0x90")]
		public NpcOutput npcOutput;

		// Token: 0x040146EF RID: 83695
		[Token(Token = "0x40146EF")]
		[FieldOffset(Offset = "0x98")]
		public Dictionary<string, SandboxV2UniEnemyStatus> uniEnemyStatus;

		// Token: 0x040146F0 RID: 83696
		[Token(Token = "0x40146F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A7D RID: 10877
		[Token(Token = "0x2002A7D")]
		[Serializable]
		public enum EnemyDeathDetailType
		{
			// Token: 0x040146F2 RID: 83698
			[Token(Token = "0x40146F2")]
			CATCHED = 1,
			// Token: 0x040146F3 RID: 83699
			[Token(Token = "0x40146F3")]
			CATCHED_SHINING,
			// Token: 0x040146F4 RID: 83700
			[Token(Token = "0x40146F4")]
			STOLEN,
			// Token: 0x040146F5 RID: 83701
			[Token(Token = "0x40146F5")]
			ENUM
		}

		// Token: 0x02002A7E RID: 10878
		[Token(Token = "0x2002A7E")]
		[Serializable]
		public enum UniEnemyDeathDetailType
		{
			// Token: 0x040146F7 RID: 83703
			[Token(Token = "0x40146F7")]
			CATCHED = 1,
			// Token: 0x040146F8 RID: 83704
			[Token(Token = "0x40146F8")]
			CATCHED_SHINING,
			// Token: 0x040146F9 RID: 83705
			[Token(Token = "0x40146F9")]
			ENUM
		}
	}
}
