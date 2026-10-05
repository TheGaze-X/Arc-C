using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002717 RID: 10007
	[Token(Token = "0x2002717")]
	public class BattleEffectEnemyInfo
	{
		// Token: 0x06010471 RID: 66673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010471")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleEffectEnemyInfo()
		{
		}

		// Token: 0x04012303 RID: 74499
		[Token(Token = "0x4012303")]
		[FieldOffset(Offset = "0x10")]
		public int effectInstId;

		// Token: 0x04012304 RID: 74500
		[Token(Token = "0x4012304")]
		[FieldOffset(Offset = "0x18")]
		public string enemyId;

		// Token: 0x04012305 RID: 74501
		[Token(Token = "0x4012305")]
		[FieldOffset(Offset = "0x20")]
		public int count;
	}
}
