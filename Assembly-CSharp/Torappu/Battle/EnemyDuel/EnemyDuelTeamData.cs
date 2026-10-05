using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C9 RID: 9929
	[Token(Token = "0x20026C9")]
	[Serializable]
	public class EnemyDuelTeamData
	{
		// Token: 0x060102D7 RID: 66263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102D7")]
		[Address(RVA = "0x7E8B10", Offset = "0x7E7710", VA = "0x1807E8B10")]
		public EnemyDuelTeamData()
		{
		}

		// Token: 0x040120BE RID: 73918
		[Token(Token = "0x40120BE")]
		[FieldOffset(Offset = "0x10")]
		public List<EnemyDuelEnemyGenerationData> teamRight;

		// Token: 0x040120BF RID: 73919
		[Token(Token = "0x40120BF")]
		[FieldOffset(Offset = "0x18")]
		public List<EnemyDuelEnemyGenerationData> teamLeft;
	}
}
