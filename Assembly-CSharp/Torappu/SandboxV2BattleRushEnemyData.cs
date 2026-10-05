using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012AF RID: 4783
	[Token(Token = "0x20012AF")]
	[Serializable]
	public class SandboxV2BattleRushEnemyData
	{
		// Token: 0x06007230 RID: 29232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007230")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BattleRushEnemyData()
		{
		}

		// Token: 0x040069B3 RID: 27059
		[Token(Token = "0x40069B3")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<SandboxV2EnemyRushType, List<SandboxV2BattleRushEnemyGroupConfig>> rushEnemyGroupConfigs;

		// Token: 0x040069B4 RID: 27060
		[Token(Token = "0x40069B4")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2BattleRushEnemyData.RushEnemyDBRef[] rushEnemyDbRef;

		// Token: 0x020012B0 RID: 4784
		[Token(Token = "0x20012B0")]
		[Serializable]
		public class RushEnemyDBRef
		{
			// Token: 0x06007231 RID: 29233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007231")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RushEnemyDBRef()
			{
			}

			// Token: 0x040069B5 RID: 27061
			[Token(Token = "0x40069B5")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040069B6 RID: 27062
			[Token(Token = "0x40069B6")]
			[FieldOffset(Offset = "0x18")]
			public int level;
		}
	}
}
