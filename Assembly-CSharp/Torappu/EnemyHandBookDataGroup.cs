using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001036 RID: 4150
	[Token(Token = "0x2001036")]
	public class EnemyHandBookDataGroup
	{
		// Token: 0x06006DA4 RID: 28068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyHandBookDataGroup()
		{
		}

		// Token: 0x04005826 RID: 22566
		[Token(Token = "0x4005826")]
		[FieldOffset(Offset = "0x10")]
		public List<EnemyHandbookLevelInfoData> levelInfoList;

		// Token: 0x04005827 RID: 22567
		[Token(Token = "0x4005827")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, EnemyHandBookData> enemyData;

		// Token: 0x04005828 RID: 22568
		[Token(Token = "0x4005828")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, EnemyHandbookRaceData> raceData;
	}
}
