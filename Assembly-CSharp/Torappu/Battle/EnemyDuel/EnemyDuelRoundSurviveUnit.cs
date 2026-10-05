using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C2 RID: 9922
	[Token(Token = "0x20026C2")]
	public class EnemyDuelRoundSurviveUnit
	{
		// Token: 0x060102CC RID: 66252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102CC")]
		[Address(RVA = "0x7E8770", Offset = "0x7E7370", VA = "0x1807E8770")]
		public EnemyDuelRoundSurviveUnit()
		{
		}

		// Token: 0x04012095 RID: 73877
		[Token(Token = "0x4012095")]
		[FieldOffset(Offset = "0x10")]
		public int round;

		// Token: 0x04012096 RID: 73878
		[Token(Token = "0x4012096")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, int> unitIds;
	}
}
