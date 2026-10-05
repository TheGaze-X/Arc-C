using System;
using Il2CppDummyDll;

namespace Torappu.Battle.EnemyDuel
{
	// Token: 0x020026C1 RID: 9921
	[Token(Token = "0x20026C1")]
	public class EnemyDuelRankInfo
	{
		// Token: 0x060102CB RID: 66251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102CB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelRankInfo()
		{
		}

		// Token: 0x04012091 RID: 73873
		[Token(Token = "0x4012091")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04012092 RID: 73874
		[Token(Token = "0x4012092")]
		[FieldOffset(Offset = "0x18")]
		public int money;

		// Token: 0x04012093 RID: 73875
		[Token(Token = "0x4012093")]
		[FieldOffset(Offset = "0x1C")]
		public bool isPlayer;

		// Token: 0x04012094 RID: 73876
		[Token(Token = "0x4012094")]
		[FieldOffset(Offset = "0x20")]
		public int aliveRoundN;
	}
}
