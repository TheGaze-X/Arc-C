using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026BF RID: 9919
	[Token(Token = "0x20026BF")]
	[Serializable]
	public class EnemyDuelSingleFinishSettle
	{
		// Token: 0x060102C9 RID: 66249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102C9")]
		[Address(RVA = "0x7E89E0", Offset = "0x7E75E0", VA = "0x1807E89E0")]
		public EnemyDuelSingleFinishSettle()
		{
		}

		// Token: 0x0401208B RID: 73867
		[Token(Token = "0x401208B")]
		[FieldOffset(Offset = "0x10")]
		public List<EnemyDuelRoundInfo> roundList;

		// Token: 0x0401208C RID: 73868
		[Token(Token = "0x401208C")]
		[FieldOffset(Offset = "0x18")]
		public List<EnemyDuelRankInfo> rankList;
	}
}
