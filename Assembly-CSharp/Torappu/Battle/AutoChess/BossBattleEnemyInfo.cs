using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200272F RID: 10031
	[Token(Token = "0x200272F")]
	public class BossBattleEnemyInfo
	{
		// Token: 0x06010489 RID: 66697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010489")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BossBattleEnemyInfo()
		{
		}

		// Token: 0x04012355 RID: 74581
		[Token(Token = "0x4012355")]
		[FieldOffset(Offset = "0x10")]
		public BossPlayerGroup playerGroup;

		// Token: 0x04012356 RID: 74582
		[Token(Token = "0x4012356")]
		[FieldOffset(Offset = "0x18")]
		public string enemyId;

		// Token: 0x04012357 RID: 74583
		[Token(Token = "0x4012357")]
		[FieldOffset(Offset = "0x20")]
		public int actionIndex;

		// Token: 0x04012358 RID: 74584
		[Token(Token = "0x4012358")]
		[FieldOffset(Offset = "0x24")]
		public int instId;
	}
}
