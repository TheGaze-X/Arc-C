using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200272D RID: 10029
	[Token(Token = "0x200272D")]
	public class BossRoundInfo
	{
		// Token: 0x06010487 RID: 66695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010487")]
		[Address(RVA = "0x803800", Offset = "0x802400", VA = "0x180803800")]
		public BossRoundInfo()
		{
		}

		// Token: 0x0401234B RID: 74571
		[Token(Token = "0x401234B")]
		[FieldOffset(Offset = "0x10")]
		public bool inBossRound;

		// Token: 0x0401234C RID: 74572
		[Token(Token = "0x401234C")]
		[FieldOffset(Offset = "0x11")]
		public bool isHiddenBoss;

		// Token: 0x0401234D RID: 74573
		[Token(Token = "0x401234D")]
		[FieldOffset(Offset = "0x18")]
		public string bossId;

		// Token: 0x0401234E RID: 74574
		[Token(Token = "0x401234E")]
		[FieldOffset(Offset = "0x20")]
		public string hiddenBossId;

		// Token: 0x0401234F RID: 74575
		[Token(Token = "0x401234F")]
		[FieldOffset(Offset = "0x28")]
		public int playerTotalHp;

		// Token: 0x04012350 RID: 74576
		[Token(Token = "0x4012350")]
		[FieldOffset(Offset = "0x30")]
		public ListDict<BossPlayerGroup, List<int>> groupInfos;
	}
}
