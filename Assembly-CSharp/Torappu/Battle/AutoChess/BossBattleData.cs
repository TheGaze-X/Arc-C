using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200272E RID: 10030
	[Token(Token = "0x200272E")]
	public class BossBattleData
	{
		// Token: 0x06010488 RID: 66696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010488")]
		[Address(RVA = "0x8035E0", Offset = "0x8021E0", VA = "0x1808035E0")]
		public BossBattleData()
		{
		}

		// Token: 0x04012351 RID: 74577
		[Token(Token = "0x4012351")]
		[FieldOffset(Offset = "0x10")]
		public BossPlayerGroup playerGroup;

		// Token: 0x04012352 RID: 74578
		[Token(Token = "0x4012352")]
		[FieldOffset(Offset = "0x14")]
		public int bossHp;

		// Token: 0x04012353 RID: 74579
		[Token(Token = "0x4012353")]
		[FieldOffset(Offset = "0x18")]
		public int enemyCount;

		// Token: 0x04012354 RID: 74580
		[Token(Token = "0x4012354")]
		[FieldOffset(Offset = "0x20")]
		public List<BossBattleEnemyInfo> enemyInfos;
	}
}
