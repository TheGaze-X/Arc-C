using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012AE RID: 4782
	[Token(Token = "0x20012AE")]
	[Serializable]
	public class SandboxV2BattleRushEnemyGroupConfig
	{
		// Token: 0x0600722F RID: 29231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600722F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BattleRushEnemyGroupConfig()
		{
		}

		// Token: 0x040069B0 RID: 27056
		[Token(Token = "0x40069B0")]
		[FieldOffset(Offset = "0x10")]
		public string enemyGroupKey;

		// Token: 0x040069B1 RID: 27057
		[Token(Token = "0x40069B1")]
		[FieldOffset(Offset = "0x18")]
		public List<SandboxV2BattleRushEnemyConfig> enemy;

		// Token: 0x040069B2 RID: 27058
		[Token(Token = "0x40069B2")]
		[FieldOffset(Offset = "0x20")]
		public List<string> dynamicEnemy;
	}
}
