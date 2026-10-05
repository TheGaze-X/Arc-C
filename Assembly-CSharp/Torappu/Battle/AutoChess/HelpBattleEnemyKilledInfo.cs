using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002735 RID: 10037
	[Token(Token = "0x2002735")]
	public struct HelpBattleEnemyKilledInfo
	{
		// Token: 0x04012369 RID: 74601
		[Token(Token = "0x4012369")]
		[FieldOffset(Offset = "0x0")]
		public int killedByPlayer;

		// Token: 0x0401236A RID: 74602
		[Token(Token = "0x401236A")]
		[FieldOffset(Offset = "0x8")]
		public EscapedEnemyInfo enemyInfo;

		// Token: 0x0401236B RID: 74603
		[Token(Token = "0x401236B")]
		[FieldOffset(Offset = "0x10")]
		public BattleEnemyKilledInfo killedInfo;
	}
}
