using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002728 RID: 10024
	[Token(Token = "0x2002728")]
	public class SelfBattleData
	{
		// Token: 0x06010482 RID: 66690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010482")]
		[Address(RVA = "0x80B290", Offset = "0x809E90", VA = "0x18080B290")]
		public SelfBattleData()
		{
		}

		// Token: 0x0401233C RID: 74556
		[Token(Token = "0x401233C")]
		[FieldOffset(Offset = "0x10")]
		public List<SelfEnemyInfo> enemyInfos;
	}
}
