using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002719 RID: 10009
	[Token(Token = "0x2002719")]
	public class SceneRoundEnemyData
	{
		// Token: 0x06010473 RID: 66675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010473")]
		[Address(RVA = "0x80B130", Offset = "0x809D30", VA = "0x18080B130")]
		public SceneRoundEnemyData()
		{
		}

		// Token: 0x04012308 RID: 74504
		[Token(Token = "0x4012308")]
		[FieldOffset(Offset = "0x10")]
		public List<SceneRoundEnemyData.RoundEnemy> roundEnemies;

		// Token: 0x0200271A RID: 10010
		[Token(Token = "0x200271A")]
		public class RoundEnemy
		{
			// Token: 0x06010474 RID: 66676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010474")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoundEnemy()
			{
			}

			// Token: 0x04012309 RID: 74505
			[Token(Token = "0x4012309")]
			[FieldOffset(Offset = "0x10")]
			public int enemyType;

			// Token: 0x0401230A RID: 74506
			[Token(Token = "0x401230A")]
			[FieldOffset(Offset = "0x18")]
			public string enemyKey;

			// Token: 0x0401230B RID: 74507
			[Token(Token = "0x401230B")]
			[FieldOffset(Offset = "0x20")]
			public int actionIndex;

			// Token: 0x0401230C RID: 74508
			[Token(Token = "0x401230C")]
			[FieldOffset(Offset = "0x24")]
			public int count;

			// Token: 0x0401230D RID: 74509
			[Token(Token = "0x401230D")]
			[FieldOffset(Offset = "0x28")]
			public int round;
		}
	}
}
