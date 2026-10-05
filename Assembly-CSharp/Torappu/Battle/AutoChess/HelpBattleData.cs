using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200272A RID: 10026
	[Token(Token = "0x200272A")]
	public class HelpBattleData
	{
		// Token: 0x06010484 RID: 66692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010484")]
		[Address(RVA = "0x807F30", Offset = "0x806B30", VA = "0x180807F30")]
		public HelpBattleData()
		{
		}

		// Token: 0x04012340 RID: 74560
		[Token(Token = "0x4012340")]
		[FieldOffset(Offset = "0x10")]
		public List<int> players;

		// Token: 0x04012341 RID: 74561
		[Token(Token = "0x4012341")]
		[FieldOffset(Offset = "0x18")]
		public List<EscapedEnemyInfo> escapedEnemyInfos;

		// Token: 0x04012342 RID: 74562
		[Token(Token = "0x4012342")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, HelpBattleData.BattleChessStatus> battleChessStatus;

		// Token: 0x0200272B RID: 10027
		[Token(Token = "0x200272B")]
		public class BattleChessStatus
		{
			// Token: 0x06010485 RID: 66693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010485")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BattleChessStatus()
			{
			}

			// Token: 0x04012343 RID: 74563
			[Token(Token = "0x4012343")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x04012344 RID: 74564
			[Token(Token = "0x4012344")]
			[FieldOffset(Offset = "0x14")]
			public float hpRatio;

			// Token: 0x04012345 RID: 74565
			[Token(Token = "0x4012345")]
			[FieldOffset(Offset = "0x18")]
			public float spRatio;
		}
	}
}
