using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B1D RID: 2845
	[Token(Token = "0x2000B1D")]
	public class PlayerRoguelikeV2Dungeon
	{
		// Token: 0x060067CE RID: 26574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067CE")]
		[Address(RVA = "0x1EFCFF0", Offset = "0x1EFBBF0", VA = "0x181EFCFF0")]
		public PlayerRoguelikeV2Dungeon()
		{
		}

		// Token: 0x04003B79 RID: 15225
		[Token(Token = "0x4003B79")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, PlayerRoguelikeV2Zone> zones;

		// Token: 0x04003B7A RID: 15226
		[Token(Token = "0x4003B7A")]
		[FieldOffset(Offset = "0x18")]
		public int verticalCostDelta;
	}
}
