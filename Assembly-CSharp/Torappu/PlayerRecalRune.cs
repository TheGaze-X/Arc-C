using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AA0 RID: 2720
	[Token(Token = "0x2000AA0")]
	public class PlayerRecalRune
	{
		// Token: 0x06006761 RID: 26465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006761")]
		[Address(RVA = "0x1EFC3B0", Offset = "0x1EFAFB0", VA = "0x181EFC3B0")]
		public PlayerRecalRune()
		{
		}

		// Token: 0x0400396C RID: 14700
		[Token(Token = "0x400396C")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerRecalRuneSeason> seasons;
	}
}
