using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002734 RID: 10036
	[Token(Token = "0x2002734")]
	public struct BattleEnemyKilledInfo
	{
		// Token: 0x04012366 RID: 74598
		[Token(Token = "0x4012366")]
		[FieldOffset(Offset = "0x0")]
		public int enemyInstId;

		// Token: 0x04012367 RID: 74599
		[Token(Token = "0x4012367")]
		[FieldOffset(Offset = "0x4")]
		public int attackerInstId;

		// Token: 0x04012368 RID: 74600
		[Token(Token = "0x4012368")]
		[FieldOffset(Offset = "0x8")]
		public AutoChessBattleDamageSrcType damageSrc;
	}
}
