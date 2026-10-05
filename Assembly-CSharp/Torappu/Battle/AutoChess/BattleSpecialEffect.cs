using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002711 RID: 10001
	[Token(Token = "0x2002711")]
	public class BattleSpecialEffect
	{
		// Token: 0x0601046B RID: 66667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601046B")]
		[Address(RVA = "0x803340", Offset = "0x801F40", VA = "0x180803340")]
		public BattleSpecialEffect()
		{
		}

		// Token: 0x040122E8 RID: 74472
		[Token(Token = "0x40122E8")]
		[FieldOffset(Offset = "0x10")]
		public int effectInstId;

		// Token: 0x040122E9 RID: 74473
		[Token(Token = "0x40122E9")]
		[FieldOffset(Offset = "0x18")]
		public string effectId;

		// Token: 0x040122EA RID: 74474
		[Token(Token = "0x40122EA")]
		[FieldOffset(Offset = "0x20")]
		public HashSet<int> affectedUidIndex;
	}
}
