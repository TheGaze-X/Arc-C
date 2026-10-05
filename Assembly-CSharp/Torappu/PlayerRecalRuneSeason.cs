using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AA1 RID: 2721
	[Token(Token = "0x2000AA1")]
	public class PlayerRecalRuneSeason
	{
		// Token: 0x06006762 RID: 26466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006762")]
		[Address(RVA = "0x1EFC260", Offset = "0x1EFAE60", VA = "0x181EFC260")]
		public PlayerRecalRuneSeason()
		{
		}

		// Token: 0x0400396D RID: 14701
		[Token(Token = "0x400396D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerRecalRuneStage> stage;

		// Token: 0x0400396E RID: 14702
		[Token(Token = "0x400396E")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRecalRuneReward reward;
	}
}
